class <Module>
{
}

namespace UnityEngine
{
    namespace UI
    {
        class AnimationTriggers
        {
            static string kDefaultNormalAnimName = "Normal";
            static string kDefaultHighlightedAnimName = "Highlighted";
            static string kDefaultPressedAnimName = "Pressed";
            static string kDefaultSelectedAnimName = "Selected";
            static string kDefaultDisabledAnimName = "Disabled";
            /*0x10*/ string m_NormalTrigger;
            /*0x18*/ string m_HighlightedTrigger;
            /*0x20*/ string m_PressedTrigger;
            /*0x28*/ string m_SelectedTrigger;
            /*0x30*/ string m_DisabledTrigger;

            /*0x296ac2c*/ AnimationTriggers();
            /*0x296abdc*/ string get_normalTrigger();
            /*0x296abe4*/ void set_normalTrigger(string value);
            /*0x296abec*/ string get_highlightedTrigger();
            /*0x296abf4*/ void set_highlightedTrigger(string value);
            /*0x296abfc*/ string get_pressedTrigger();
            /*0x296ac04*/ void set_pressedTrigger(string value);
            /*0x296ac0c*/ string get_selectedTrigger();
            /*0x296ac14*/ void set_selectedTrigger(string value);
            /*0x296ac1c*/ string get_disabledTrigger();
            /*0x296ac24*/ void set_disabledTrigger(string value);
        }

        class Button : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler
        {
            /*0xf8*/ UnityEngine.UI.Button.ButtonClickedEvent m_OnClick;

            /*0x296acfc*/ Button();
            /*0x296ad90*/ UnityEngine.UI.Button.ButtonClickedEvent get_onClick();
            /*0x296ad98*/ void set_onClick(UnityEngine.UI.Button.ButtonClickedEvent value);
            /*0x296ada0*/ void Press();
            /*0x296ae38*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x296ae5c*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x296aed4*/ System.Collections.IEnumerator OnFinishSubmit();

            class ButtonClickedEvent : UnityEngine.Events.UnityEvent
            {
                /*0x296ad88*/ ButtonClickedEvent();
            }

            class <OnFinishSubmit>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Button <>4__this;
                /*0x28*/ float <fadeTime>5__2;
                /*0x2c*/ float <elapsedTime>5__3;

                /*0x296af3c*/ <OnFinishSubmit>d__9(int <>1__state);
                /*0x296af64*/ void System.IDisposable.Dispose();
                /*0x296af68*/ bool MoveNext();
                /*0x296b024*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x296b02c*/ void System.Collections.IEnumerator.Reset();
                /*0x296b06c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        enum CanvasUpdate
        {
            Prelayout = 0,
            Layout = 1,
            PostLayout = 2,
            PreRender = 3,
            LatePreRender = 4,
            MaxUpdateValue = 5,
        }

        interface ICanvasElement
        {
            void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            UnityEngine.Transform get_transform();
            void LayoutComplete();
            void GraphicUpdateComplete();
            bool IsDestroyed();
        }

        class CanvasUpdateRegistry
        {
            static string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
            static /*0x0*/ UnityEngine.UI.CanvasUpdateRegistry s_Instance;
            static /*0x8*/ System.Comparison<UnityEngine.UI.ICanvasElement> s_SortLayoutFunction;
            /*0x10*/ bool m_PerformingLayoutUpdate;
            /*0x11*/ bool m_PerformingGraphicUpdate;
            /*0x18*/ string[] m_CanvasUpdateProfilerStrings;
            /*0x20*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_LayoutRebuildQueue;
            /*0x28*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.ICanvasElement> m_GraphicRebuildQueue;

            static /*0x296cb24*/ CanvasUpdateRegistry();
            static /*0x296b2e0*/ UnityEngine.UI.CanvasUpdateRegistry get_instance();
            static /*0x296bf04*/ int ParentCount(UnityEngine.Transform child);
            static /*0x296bfc4*/ int SortLayoutList(UnityEngine.UI.ICanvasElement x, UnityEngine.UI.ICanvasElement y);
            static /*0x296c114*/ void RegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296c20c*/ bool TryRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296c26c*/ void RegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296c39c*/ bool TryRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296c3fc*/ void UnRegisterCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296c734*/ void DisableCanvasElementForRebuild(UnityEngine.UI.ICanvasElement element);
            static /*0x296ca6c*/ bool IsRebuildingLayout();
            static /*0x296cac8*/ bool IsRebuildingGraphics();
            /*0x296b074*/ CanvasUpdateRegistry();
            /*0x296b388*/ bool ObjectValidForUpdate(UnityEngine.UI.ICanvasElement element);
            /*0x296b458*/ void CleanInvalidItems();
            /*0x296b73c*/ void PerformUpdate();
            /*0x296c174*/ bool InternalRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x296c2cc*/ bool InternalRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x296c46c*/ void InternalUnRegisterCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x296c5d0*/ void InternalUnRegisterCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x296c7a4*/ void InternalDisableCanvasElementForLayoutRebuild(UnityEngine.UI.ICanvasElement element);
            /*0x296c908*/ void InternalDisableCanvasElementForGraphicRebuild(UnityEngine.UI.ICanvasElement element);
        }

        struct ColorBlock : System.IEquatable<UnityEngine.UI.ColorBlock>
        {
            static /*0x0*/ UnityEngine.UI.ColorBlock defaultColorBlock;
            /*0x10*/ UnityEngine.Color m_NormalColor;
            /*0x20*/ UnityEngine.Color m_HighlightedColor;
            /*0x30*/ UnityEngine.Color m_PressedColor;
            /*0x40*/ UnityEngine.Color m_SelectedColor;
            /*0x50*/ UnityEngine.Color m_DisabledColor;
            /*0x60*/ float m_ColorMultiplier;
            /*0x64*/ float m_FadeDuration;

            static /*0x296cc50*/ ColorBlock();
            static /*0x296ce80*/ bool op_Equality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            static /*0x296ceb4*/ bool op_Inequality(UnityEngine.UI.ColorBlock point1, UnityEngine.UI.ColorBlock point2);
            /*0x296cbb8*/ UnityEngine.Color get_normalColor();
            /*0x296cbc4*/ void set_normalColor(UnityEngine.Color value);
            /*0x296cbd0*/ UnityEngine.Color get_highlightedColor();
            /*0x296cbdc*/ void set_highlightedColor(UnityEngine.Color value);
            /*0x296cbe8*/ UnityEngine.Color get_pressedColor();
            /*0x296cbf4*/ void set_pressedColor(UnityEngine.Color value);
            /*0x296cc00*/ UnityEngine.Color get_selectedColor();
            /*0x296cc0c*/ void set_selectedColor(UnityEngine.Color value);
            /*0x296cc18*/ UnityEngine.Color get_disabledColor();
            /*0x296cc24*/ void set_disabledColor(UnityEngine.Color value);
            /*0x296cc30*/ float get_colorMultiplier();
            /*0x296cc38*/ void set_colorMultiplier(float value);
            /*0x296cc40*/ float get_fadeDuration();
            /*0x296cc48*/ void set_fadeDuration(float value);
            /*0x296cccc*/ bool Equals(object obj);
            /*0x296cd5c*/ bool Equals(UnityEngine.UI.ColorBlock other);
            /*0x296ceec*/ int GetHashCode();
        }

        class ClipperRegistry
        {
            static /*0x0*/ UnityEngine.UI.ClipperRegistry s_Instance;
            /*0x10*/ UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.IClipper> m_Clippers;

            static /*0x296bd7c*/ UnityEngine.UI.ClipperRegistry get_instance();
            static /*0x296cfd4*/ void Register(UnityEngine.UI.IClipper c);
            static /*0x296d044*/ void Unregister(UnityEngine.UI.IClipper c);
            static /*0x296d0a0*/ void Disable(UnityEngine.UI.IClipper c);
            /*0x296cf58*/ ClipperRegistry();
            /*0x296bdf8*/ void Cull();
        }

        class Clipping
        {
            static /*0x296d0fc*/ UnityEngine.Rect FindCullAndClipWorldRect(System.Collections.Generic.List<UnityEngine.UI.RectMask2D> rectMaskParents, ref bool validRect);
        }

        interface IClipper
        {
            void PerformClipping();
        }

        interface IClippable
        {
            UnityEngine.GameObject get_gameObject();
            void RecalculateClipping();
            UnityEngine.RectTransform get_rectTransform();
            void Cull(UnityEngine.Rect clipRect, bool validRect);
            void SetClipRect(UnityEngine.Rect value, bool validRect);
            void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
        }

        class RectangularVertexClipper
        {
            /*0x10*/ UnityEngine.Vector3[] m_WorldCorners;
            /*0x18*/ UnityEngine.Vector3[] m_CanvasCorners;

            /*0x296d4cc*/ RectangularVertexClipper();
            /*0x296d35c*/ UnityEngine.Rect GetCanvasRect(UnityEngine.RectTransform t, UnityEngine.Canvas c);
        }

        class DefaultControls
        {
            static float kWidth = 160;
            static float kThickHeight = 30;
            static float kThinHeight = 20;
            static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory;
            static /*0x8*/ UnityEngine.Vector2 s_ThickElementSize;
            static /*0x10*/ UnityEngine.Vector2 s_ThinElementSize;
            static /*0x18*/ UnityEngine.Vector2 s_ImageElementSize;
            static /*0x20*/ UnityEngine.Color s_DefaultSelectableColor;
            static /*0x30*/ UnityEngine.Color s_PanelColor;
            static /*0x40*/ UnityEngine.Color s_TextColor;

            static /*0x2971d24*/ DefaultControls();
            static /*0x296d534*/ UnityEngine.UI.DefaultControls.IFactoryControls get_factory();
            static /*0x296d58c*/ UnityEngine.GameObject CreateUIElementRoot(string name, UnityEngine.Vector2 size, System.Type[] components);
            static /*0x296d6ec*/ UnityEngine.GameObject CreateUIObject(string name, UnityEngine.GameObject parent, System.Type[] components);
            static /*0x296d914*/ void SetDefaultTextValues(UnityEngine.UI.Text lbl);
            static /*0x296d9f0*/ void SetDefaultColorTransitionValues(UnityEngine.UI.Selectable slider);
            static /*0x296d814*/ void SetParentAndAlign(UnityEngine.GameObject child, UnityEngine.GameObject parent);
            static /*0x296da00*/ void SetLayerRecursively(UnityEngine.GameObject go, int layer);
            static /*0x296dae4*/ UnityEngine.GameObject CreatePanel(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296e108*/ UnityEngine.GameObject CreateButton(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296e4f4*/ UnityEngine.GameObject CreateText(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296e694*/ UnityEngine.GameObject CreateImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296e7d0*/ UnityEngine.GameObject CreateRawImage(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296e90c*/ UnityEngine.GameObject CreateSlider(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296efc0*/ UnityEngine.GameObject CreateScrollbar(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296f434*/ UnityEngine.GameObject CreateToggle(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296f9ac*/ UnityEngine.GameObject CreateInputField(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x296ffcc*/ UnityEngine.GameObject CreateDropdown(UnityEngine.UI.DefaultControls.Resources resources);
            static /*0x297143c*/ UnityEngine.GameObject CreateScrollView(UnityEngine.UI.DefaultControls.Resources resources);

            interface IFactoryControls
            {
                UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            class DefaultRuntimeFactory : UnityEngine.UI.DefaultControls.IFactoryControls
            {
                static /*0x0*/ UnityEngine.UI.DefaultControls.IFactoryControls Default;

                static /*0x2971e78*/ DefaultRuntimeFactory();
                /*0x2971e70*/ DefaultRuntimeFactory();
                /*0x2971dfc*/ UnityEngine.GameObject CreateGameObject(string name, System.Type[] components);
            }

            struct Resources
            {
                /*0x10*/ UnityEngine.Sprite standard;
                /*0x18*/ UnityEngine.Sprite background;
                /*0x20*/ UnityEngine.Sprite inputField;
                /*0x28*/ UnityEngine.Sprite knob;
                /*0x30*/ UnityEngine.Sprite checkmark;
                /*0x38*/ UnityEngine.Sprite dropdown;
                /*0x40*/ UnityEngine.Sprite mask;
            }
        }

        class Dropdown : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            static int kHighSortingLayer = 30000;
            static /*0x0*/ UnityEngine.UI.Dropdown.OptionData s_NoOptionData;
            /*0xf8*/ UnityEngine.RectTransform m_Template;
            /*0x100*/ UnityEngine.UI.Text m_CaptionText;
            /*0x108*/ UnityEngine.UI.Image m_CaptionImage;
            /*0x110*/ UnityEngine.UI.Text m_ItemText;
            /*0x118*/ UnityEngine.UI.Image m_ItemImage;
            /*0x120*/ int m_Value;
            /*0x128*/ UnityEngine.UI.Dropdown.OptionDataList m_Options;
            /*0x130*/ UnityEngine.UI.Dropdown.DropdownEvent m_OnValueChanged;
            /*0x138*/ float m_AlphaFadeSpeed;
            /*0x140*/ UnityEngine.GameObject m_Dropdown;
            /*0x148*/ UnityEngine.GameObject m_Blocker;
            /*0x150*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> m_Items;
            /*0x158*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.FloatTween> m_AlphaTweenRunner;
            /*0x160*/ bool validTemplate;

            static /*0x2974ad4*/ Dropdown();
            static T GetOrAddComponent<T>(UnityEngine.GameObject go);
            /*0x2972078*/ Dropdown();
            /*0x2971edc*/ UnityEngine.RectTransform get_template();
            /*0x2971224*/ void set_template(UnityEngine.RectTransform value);
            /*0x2971ee4*/ UnityEngine.UI.Text get_captionText();
            /*0x297122c*/ void set_captionText(UnityEngine.UI.Text value);
            /*0x2971eec*/ UnityEngine.UI.Image get_captionImage();
            /*0x2971ef4*/ void set_captionImage(UnityEngine.UI.Image value);
            /*0x2971efc*/ UnityEngine.UI.Text get_itemText();
            /*0x2971234*/ void set_itemText(UnityEngine.UI.Text value);
            /*0x2971f04*/ UnityEngine.UI.Image get_itemImage();
            /*0x2971f0c*/ void set_itemImage(UnityEngine.UI.Image value);
            /*0x297123c*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
            /*0x2971f14*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            /*0x2971f30*/ UnityEngine.UI.Dropdown.DropdownEvent get_onValueChanged();
            /*0x2971f38*/ void set_onValueChanged(UnityEngine.UI.Dropdown.DropdownEvent value);
            /*0x2971f40*/ float get_alphaFadeSpeed();
            /*0x2971f48*/ void set_alphaFadeSpeed(float value);
            /*0x2971f50*/ int get_value();
            /*0x2971f58*/ void set_value(int value);
            /*0x2972070*/ void SetValueWithoutNotify(int input);
            /*0x2971f60*/ void Set(int value, bool sendCallback);
            /*0x2972244*/ void Awake();
            /*0x2972340*/ void Start();
            /*0x29723d4*/ void OnDisable();
            /*0x2971260*/ void RefreshShownValue();
            /*0x29725d8*/ void AddOptions(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> options);
            /*0x2972640*/ void AddOptions(System.Collections.Generic.List<string> options);
            /*0x29727c4*/ void AddOptions(System.Collections.Generic.List<UnityEngine.Sprite> options);
            /*0x2972948*/ void ClearOptions();
            /*0x29729c0*/ void SetupTemplate(UnityEngine.Canvas rootCanvas);
            /*0x2973038*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2973c54*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x2973c58*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x297303c*/ void Show();
            /*0x2974174*/ UnityEngine.GameObject CreateBlocker(UnityEngine.Canvas rootCanvas);
            /*0x2974640*/ void DestroyBlocker(UnityEngine.GameObject blocker);
            /*0x2974698*/ UnityEngine.GameObject CreateDropdownList(UnityEngine.GameObject template);
            /*0x2974704*/ void DestroyDropdownList(UnityEngine.GameObject dropdownList);
            /*0x297475c*/ UnityEngine.UI.Dropdown.DropdownItem CreateItem(UnityEngine.UI.Dropdown.DropdownItem itemTemplate);
            /*0x29747c8*/ void DestroyItem(UnityEngine.UI.Dropdown.DropdownItem item);
            /*0x2973d60*/ UnityEngine.UI.Dropdown.DropdownItem AddItem(UnityEngine.UI.Dropdown.OptionData data, bool selected, UnityEngine.UI.Dropdown.DropdownItem itemTemplate, System.Collections.Generic.List<UnityEngine.UI.Dropdown.DropdownItem> items);
            /*0x29747cc*/ void AlphaFadeList(float duration, float alpha);
            /*0x297404c*/ void AlphaFadeList(float duration, float start, float end);
            /*0x297484c*/ void SetAlpha(float alpha);
            /*0x2973c5c*/ void Hide();
            /*0x2974900*/ System.Collections.IEnumerator DelayedDestroyDropdownList(float delay);
            /*0x2972468*/ void ImmediateDestroyDropdownList();
            /*0x29749a0*/ void OnSelectItem(UnityEngine.UI.Toggle toggle);

            class DropdownItem : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ICancelHandler
            {
                /*0x18*/ UnityEngine.UI.Text m_Text;
                /*0x20*/ UnityEngine.UI.Image m_Image;
                /*0x28*/ UnityEngine.RectTransform m_RectTransform;
                /*0x30*/ UnityEngine.UI.Toggle m_Toggle;

                /*0x2974cb4*/ DropdownItem();
                /*0x2974b4c*/ UnityEngine.UI.Text get_text();
                /*0x2974b54*/ void set_text(UnityEngine.UI.Text value);
                /*0x2974b5c*/ UnityEngine.UI.Image get_image();
                /*0x2974b64*/ void set_image(UnityEngine.UI.Image value);
                /*0x2974b6c*/ UnityEngine.RectTransform get_rectTransform();
                /*0x2974b74*/ void set_rectTransform(UnityEngine.RectTransform value);
                /*0x2974b7c*/ UnityEngine.UI.Toggle get_toggle();
                /*0x2974b84*/ void set_toggle(UnityEngine.UI.Toggle value);
                /*0x2974b8c*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                /*0x2974c08*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            }

            class OptionData
            {
                /*0x10*/ string m_Text;
                /*0x18*/ UnityEngine.Sprite m_Image;

                /*0x2971258*/ OptionData();
                /*0x297279c*/ OptionData(string text);
                /*0x2972920*/ OptionData(UnityEngine.Sprite image);
                /*0x2974cdc*/ OptionData(string text, UnityEngine.Sprite image);
                /*0x2974cbc*/ string get_text();
                /*0x2974cc4*/ void set_text(string value);
                /*0x2974ccc*/ UnityEngine.Sprite get_image();
                /*0x2974cd4*/ void set_image(UnityEngine.Sprite value);
            }

            class OptionDataList
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> m_Options;

                /*0x297217c*/ OptionDataList();
                /*0x2974d08*/ System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> get_options();
                /*0x2974d10*/ void set_options(System.Collections.Generic.List<UnityEngine.UI.Dropdown.OptionData> value);
            }

            class DropdownEvent : UnityEngine.Events.UnityEvent<int>
            {
                /*0x29721fc*/ DropdownEvent();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.UI.Dropdown.DropdownItem item;
                /*0x18*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x2973d58*/ <>c__DisplayClass63_0();
                /*0x2974d18*/ void <Show>b__0(bool x);
            }

            class <DelayedDestroyDropdownList>d__75 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ float delay;
                /*0x28*/ UnityEngine.UI.Dropdown <>4__this;

                /*0x2974978*/ <DelayedDestroyDropdownList>d__75(int <>1__state);
                /*0x2974d3c*/ void System.IDisposable.Dispose();
                /*0x2974d40*/ bool MoveNext();
                /*0x2974dec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2974df4*/ void System.Collections.IEnumerator.Reset();
                /*0x2974e34*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FontData : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Font m_Font;
            /*0x18*/ int m_FontSize;
            /*0x1c*/ UnityEngine.FontStyle m_FontStyle;
            /*0x20*/ bool m_BestFit;
            /*0x24*/ int m_MinSize;
            /*0x28*/ int m_MaxSize;
            /*0x2c*/ UnityEngine.TextAnchor m_Alignment;
            /*0x30*/ bool m_AlignByGeometry;
            /*0x31*/ bool m_RichText;
            /*0x34*/ UnityEngine.HorizontalWrapMode m_HorizontalOverflow;
            /*0x38*/ UnityEngine.VerticalWrapMode m_VerticalOverflow;
            /*0x3c*/ float m_LineSpacing;

            static /*0x2974e3c*/ UnityEngine.UI.FontData get_defaultFontData();
            /*0x2974ecc*/ FontData();
            /*0x2974ed4*/ UnityEngine.Font get_font();
            /*0x2974edc*/ void set_font(UnityEngine.Font value);
            /*0x2974ee4*/ int get_fontSize();
            /*0x2974eec*/ void set_fontSize(int value);
            /*0x2974ef4*/ UnityEngine.FontStyle get_fontStyle();
            /*0x2974efc*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x2974f04*/ bool get_bestFit();
            /*0x2974f0c*/ void set_bestFit(bool value);
            /*0x2974f18*/ int get_minSize();
            /*0x2974f20*/ void set_minSize(int value);
            /*0x2974f28*/ int get_maxSize();
            /*0x2974f30*/ void set_maxSize(int value);
            /*0x2974f38*/ UnityEngine.TextAnchor get_alignment();
            /*0x2974f40*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x2974f48*/ bool get_alignByGeometry();
            /*0x2974f50*/ void set_alignByGeometry(bool value);
            /*0x2974f5c*/ bool get_richText();
            /*0x2974f64*/ void set_richText(bool value);
            /*0x2974f70*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x2974f78*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x2974f80*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x2974f88*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x2974f90*/ float get_lineSpacing();
            /*0x2974f98*/ void set_lineSpacing(float value);
            /*0x2974fa0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x2974fa4*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        class FontUpdateTracker
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Font, System.Collections.Generic.HashSet<UnityEngine.UI.Text>> m_Tracked;

            static /*0x29755e8*/ FontUpdateTracker();
            static /*0x2974fe8*/ void TrackText(UnityEngine.UI.Text t);
            static /*0x2975238*/ void RebuildForFont(UnityEngine.Font f);
            static /*0x29753dc*/ void UntrackText(UnityEngine.UI.Text t);
        }

        class Graphic : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultUI;
            static /*0x8*/ UnityEngine.Texture2D s_WhiteTexture;
            static /*0x10*/ UnityEngine.Mesh s_Mesh;
            static /*0x18*/ UnityEngine.UI.VertexHelper s_VertexHelper;
            /*0x18*/ UnityEngine.Material m_Material;
            /*0x20*/ UnityEngine.Color m_Color;
            /*0x30*/ bool m_SkipLayoutUpdate;
            /*0x31*/ bool m_SkipMaterialUpdate;
            /*0x32*/ bool m_RaycastTarget;
            /*0x33*/ bool m_RaycastTargetCache;
            /*0x34*/ UnityEngine.Vector4 m_RaycastPadding;
            /*0x48*/ UnityEngine.RectTransform m_RectTransform;
            /*0x50*/ UnityEngine.CanvasRenderer m_CanvasRenderer;
            /*0x58*/ UnityEngine.Canvas m_Canvas;
            /*0x60*/ bool m_VertsDirty;
            /*0x61*/ bool m_MaterialDirty;
            /*0x68*/ UnityEngine.Events.UnityAction m_OnDirtyLayoutCallback;
            /*0x70*/ UnityEngine.Events.UnityAction m_OnDirtyVertsCallback;
            /*0x78*/ UnityEngine.Events.UnityAction m_OnDirtyMaterialCallback;
            /*0x80*/ UnityEngine.Mesh m_CachedMesh;
            /*0x88*/ UnityEngine.Vector2[] m_CachedUvs;
            /*0x90*/ UnityEngine.UI.CoroutineTween.TweenRunner<UnityEngine.UI.CoroutineTween.ColorTween> m_ColorTweenRunner;
            /*0x98*/ bool <useLegacyMeshGeneration>k__BackingField;

            static /*0x2978fec*/ Graphic();
            static /*0x2975674*/ UnityEngine.Material get_defaultGraphicMaterial();
            static /*0x2977c1c*/ UnityEngine.Mesh get_workerMesh();
            static /*0x2978c3c*/ UnityEngine.Color CreateColorFromAlpha(float alpha);
            /*0x2975c80*/ Graphic();
            /*0x2975750*/ UnityEngine.Color get_color();
            /*0x297575c*/ void set_color(UnityEngine.Color value);
            /*0x2975794*/ bool get_raycastTarget();
            /*0x297579c*/ void set_raycastTarget(bool value);
            /*0x2975c54*/ UnityEngine.Vector4 get_raycastPadding();
            /*0x2975c60*/ void set_raycastPadding(UnityEngine.Vector4 value);
            /*0x2975c6c*/ bool get_useLegacyMeshGeneration();
            /*0x2975c74*/ void set_useLegacyMeshGeneration(bool value);
            /*0x2975d30*/ void SetAllDirty();
            /*0x2975e70*/ void SetLayoutDirty();
            /*0x2975f68*/ void SetVerticesDirty();
            /*0x2975ffc*/ void SetMaterialDirty();
            /*0x2975da0*/ void SetRaycastDirty();
            /*0x2976090*/ void OnRectTransformDimensionsChange();
            /*0x297613c*/ void OnBeforeTransformParentChanged();
            /*0x2976364*/ void OnTransformParentChanged();
            /*0x297677c*/ int get_depth();
            /*0x2975f10*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2975870*/ UnityEngine.Canvas get_canvas();
            /*0x2976418*/ void CacheCanvas();
            /*0x2976798*/ UnityEngine.CanvasRenderer get_canvasRenderer();
            /*0x2976828*/ UnityEngine.Material get_defaultMaterial();
            /*0x2976874*/ UnityEngine.Material get_material();
            /*0x29768fc*/ void set_material(UnityEngine.Material value);
            /*0x2976994*/ UnityEngine.Material get_materialForRendering();
            /*0x2976bb8*/ UnityEngine.Texture get_mainTexture();
            /*0x2976c10*/ void OnEnable();
            /*0x2976d40*/ void OnDisable();
            /*0x2976e88*/ void OnDestroy();
            /*0x2977130*/ void OnCanvasHierarchyChanged();
            /*0x2977268*/ void OnCullingChanged();
            /*0x29772f4*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x29773d8*/ void LayoutComplete();
            /*0x29773dc*/ void GraphicUpdateComplete();
            /*0x29773e0*/ void UpdateMaterial();
            /*0x2977498*/ void UpdateGeometry();
            /*0x2977848*/ void DoMeshGeneration();
            /*0x29774a8*/ void DoLegacyMeshGeneration();
            /*0x2977d58*/ void OnFillVBO(System.Collections.Generic.List<UnityEngine.UIVertex> vbo);
            /*0x2977d5c*/ void OnPopulateMesh(UnityEngine.Mesh m);
            /*0x2977df4*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x29783ac*/ void OnDidApplyAnimationProperties();
            /*0x29783bc*/ void SetNativeSize();
            /*0x29783c0*/ bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x297884c*/ UnityEngine.Vector2 PixelAdjustPoint(UnityEngine.Vector2 point);
            /*0x2978280*/ UnityEngine.Rect GetPixelAdjustedRect();
            /*0x297898c*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha);
            /*0x29789a8*/ void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB);
            /*0x2978c50*/ void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale);
            /*0x2978cec*/ void RegisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x2978d6c*/ void UnregisterDirtyLayoutCallback(UnityEngine.Events.UnityAction action);
            /*0x2978dec*/ void RegisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x2978e6c*/ void UnregisterDirtyVerticesCallback(UnityEngine.Events.UnityAction action);
            /*0x2978eec*/ void RegisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x2978f6c*/ void UnregisterDirtyMaterialCallback(UnityEngine.Events.UnityAction action);
            /*0x297907c*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();
        }

        class GraphicRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_SortedGraphics;
            /*0x20*/ bool m_IgnoreReversedGraphics;
            /*0x24*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects m_BlockingObjects;
            /*0x28*/ UnityEngine.LayerMask m_BlockingMask;
            /*0x30*/ UnityEngine.Canvas m_Canvas;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> m_RaycastResults;

            static /*0x297a5f4*/ GraphicRaycaster();
            static /*0x2979fbc*/ void Raycast(UnityEngine.Canvas canvas, UnityEngine.Camera eventCamera, UnityEngine.Vector2 pointerPosition, System.Collections.Generic.IList<UnityEngine.UI.Graphic> foundGraphics, System.Collections.Generic.List<UnityEngine.UI.Graphic> results);
            /*0x29791e8*/ GraphicRaycaster();
            /*0x2979084*/ int get_sortOrderPriority();
            /*0x2979160*/ int get_renderOrderPriority();
            /*0x29791b4*/ bool get_ignoreReversedGraphics();
            /*0x29791bc*/ void set_ignoreReversedGraphics(bool value);
            /*0x29791c8*/ UnityEngine.UI.GraphicRaycaster.BlockingObjects get_blockingObjects();
            /*0x29791d0*/ void set_blockingObjects(UnityEngine.UI.GraphicRaycaster.BlockingObjects value);
            /*0x29791d8*/ UnityEngine.LayerMask get_blockingMask();
            /*0x29791e0*/ void set_blockingMask(UnityEngine.LayerMask value);
            /*0x29790cc*/ UnityEngine.Canvas get_canvas();
            /*0x297927c*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x297a52c*/ UnityEngine.Camera get_eventCamera();

            enum BlockingObjects
            {
                None = 0,
                TwoD = 1,
                ThreeD = 2,
                All = 3,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.GraphicRaycaster.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.UI.Graphic> <>9__27_0;

                static /*0x297a680*/ <>c();
                /*0x297a6e4*/ <>c();
                /*0x297a6ec*/ int <Raycast>b__27_0(UnityEngine.UI.Graphic g1, UnityEngine.UI.Graphic g2);
            }
        }

        class GraphicRegistry
        {
            static /*0x0*/ UnityEngine.UI.GraphicRegistry s_Instance;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.UI.Graphic> s_EmptyList;
            /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_Graphics;
            /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Canvas, UnityEngine.UI.Collections.IndexedSet<UnityEngine.UI.Graphic>> m_RaycastableGraphics;

            static /*0x297abc4*/ GraphicRegistry();
            static /*0x297a8e0*/ UnityEngine.UI.GraphicRegistry get_instance();
            static /*0x2976588*/ void RegisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x2975a60*/ void RegisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x2976f8c*/ void UnregisterGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x29758e4*/ void UnregisterRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x29761e4*/ void DisableGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x297a988*/ void DisableRaycastGraphicForCanvas(UnityEngine.Canvas c, UnityEngine.UI.Graphic graphic);
            static /*0x297ab08*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetGraphicsForCanvas(UnityEngine.Canvas canvas);
            static /*0x2979f00*/ System.Collections.Generic.IList<UnityEngine.UI.Graphic> GetRaycastableGraphicsForCanvas(UnityEngine.Canvas canvas);
            /*0x297a738*/ GraphicRegistry();
        }

        interface IGraphicEnabledDisabled
        {
            void OnSiblingGraphicEnabledDisabled();
        }

        class Image : UnityEngine.UI.MaskableGraphic, UnityEngine.ISerializationCallbackReceiver, UnityEngine.UI.ILayoutElement, UnityEngine.ICanvasRaycastFilter
        {
            static /*0x0*/ UnityEngine.Material s_ETC1DefaultUI;
            static /*0x8*/ UnityEngine.Vector2[] s_VertScratch;
            static /*0x10*/ UnityEngine.Vector2[] s_UVScratch;
            static /*0x18*/ UnityEngine.Vector3[] s_Xy;
            static /*0x20*/ UnityEngine.Vector3[] s_Uv;
            static /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Image> m_TrackedTexturelessImages;
            static /*0x30*/ bool s_Initialized;
            /*0xd0*/ UnityEngine.Sprite m_Sprite;
            /*0xd8*/ UnityEngine.Sprite m_OverrideSprite;
            /*0xe0*/ UnityEngine.UI.Image.Type m_Type;
            /*0xe4*/ bool m_PreserveAspect;
            /*0xe5*/ bool m_FillCenter;
            /*0xe8*/ UnityEngine.UI.Image.FillMethod m_FillMethod;
            /*0xec*/ float m_FillAmount;
            /*0xf0*/ bool m_FillClockwise;
            /*0xf4*/ int m_FillOrigin;
            /*0xf8*/ float m_AlphaHitTestMinimumThreshold;
            /*0xfc*/ bool m_Tracked;
            /*0xfd*/ bool m_UseSpriteMesh;
            /*0x100*/ float m_PixelsPerUnitMultiplier;
            /*0x104*/ float m_CachedReferencePixelsPerUnit;

            static /*0x2982ff0*/ Image();
            static /*0x297b288*/ UnityEngine.Material get_defaultETC1GraphicMaterial();
            static /*0x2981f58*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector3[] quadPositions, UnityEngine.Color32 color, UnityEngine.Vector3[] quadUVs);
            static /*0x2981e04*/ void AddQuad(UnityEngine.UI.VertexHelper vertexHelper, UnityEngine.Vector2 posMin, UnityEngine.Vector2 posMax, UnityEngine.Color32 color, UnityEngine.Vector2 uvMin, UnityEngine.Vector2 uvMax);
            static /*0x298203c*/ bool RadialCut(UnityEngine.Vector3[] xy, UnityEngine.Vector3[] uv, float fill, bool invert, int corner);
            static /*0x298215c*/ void RadialCut(UnityEngine.Vector3[] xy, float cos, float sin, bool invert, int corner);
            static /*0x2982e10*/ void RebuildImage(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x2981838*/ void TrackImage(UnityEngine.UI.Image g);
            static /*0x2981a28*/ void UnTrackImage(UnityEngine.UI.Image g);
            /*0x297b248*/ Image();
            /*0x297ac50*/ UnityEngine.Sprite get_sprite();
            /*0x296dda0*/ void set_sprite(UnityEngine.Sprite value);
            /*0x297ad44*/ void DisableSpriteOptimizations();
            /*0x297ad4c*/ UnityEngine.Sprite get_overrideSprite();
            /*0x297adc8*/ void set_overrideSprite(UnityEngine.Sprite value);
            /*0x297ad50*/ UnityEngine.Sprite get_activeSprite();
            /*0x297ae50*/ UnityEngine.UI.Image.Type get_type();
            /*0x296e088*/ void set_type(UnityEngine.UI.Image.Type value);
            /*0x297ae58*/ bool get_preserveAspect();
            /*0x297ae60*/ void set_preserveAspect(bool value);
            /*0x297aee0*/ bool get_fillCenter();
            /*0x297aee8*/ void set_fillCenter(bool value);
            /*0x297af68*/ UnityEngine.UI.Image.FillMethod get_fillMethod();
            /*0x297af70*/ void set_fillMethod(UnityEngine.UI.Image.FillMethod value);
            /*0x297afe8*/ float get_fillAmount();
            /*0x297aff0*/ void set_fillAmount(float value);
            /*0x297b080*/ bool get_fillClockwise();
            /*0x297b088*/ void set_fillClockwise(bool value);
            /*0x297b108*/ int get_fillOrigin();
            /*0x297b110*/ void set_fillOrigin(int value);
            /*0x297b190*/ float get_eventAlphaThreshold();
            /*0x297b1a0*/ void set_eventAlphaThreshold(float value);
            /*0x297b1b0*/ float get_alphaHitTestMinimumThreshold();
            /*0x297b1b8*/ void set_alphaHitTestMinimumThreshold(float value);
            /*0x297b1c0*/ bool get_useSpriteMesh();
            /*0x297b1c8*/ void set_useSpriteMesh(bool value);
            /*0x297b364*/ UnityEngine.Texture get_mainTexture();
            /*0x297b4dc*/ bool get_hasBorder();
            /*0x297b594*/ float get_pixelsPerUnitMultiplier();
            /*0x297b59c*/ void set_pixelsPerUnitMultiplier(float value);
            /*0x297b5bc*/ float get_pixelsPerUnit();
            /*0x297b6b0*/ float get_multipliedPixelsPerUnit();
            /*0x297b6cc*/ UnityEngine.Material get_material();
            /*0x297b7f8*/ void set_material(UnityEngine.Material value);
            /*0x297b7fc*/ void OnBeforeSerialize();
            /*0x297b800*/ void OnAfterDeserialize();
            /*0x297b850*/ void PreserveSpriteAspectRatio(ref UnityEngine.Rect rect, UnityEngine.Vector2 spriteSize);
            /*0x297b9a8*/ UnityEngine.Vector4 GetDrawingDimensions(bool shouldPreserveAspect);
            /*0x297be2c*/ void SetNativeSize();
            /*0x297bf90*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x297ac58*/ void TrackSprite();
            /*0x2981998*/ void OnEnable();
            /*0x29819b4*/ void OnDisable();
            /*0x2981aa8*/ void UpdateMaterial();
            /*0x2981b9c*/ void OnCanvasHierarchyChanged();
            /*0x297c0d4*/ void GenerateSimpleSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x297cbf8*/ void GenerateSprite(UnityEngine.UI.VertexHelper vh, bool lPreserveAspect);
            /*0x297d1e8*/ void GenerateSlicedSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x297da38*/ void GenerateTiledSprite(UnityEngine.UI.VertexHelper toFill);
            /*0x2981ca4*/ UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect adjustedRect);
            /*0x2980410*/ void GenerateFilledSprite(UnityEngine.UI.VertexHelper toFill, bool preserveAspect);
            /*0x2982548*/ void CalculateLayoutInputHorizontal();
            /*0x298254c*/ void CalculateLayoutInputVertical();
            /*0x2982550*/ float get_minWidth();
            /*0x2982558*/ float get_preferredWidth();
            /*0x298263c*/ float get_flexibleWidth();
            /*0x2982644*/ float get_minHeight();
            /*0x298264c*/ float get_preferredHeight();
            /*0x2982730*/ float get_flexibleHeight();
            /*0x2982738*/ int get_layoutPriority();
            /*0x2982740*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
            /*0x2982ad0*/ UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect);
            /*0x2982fb8*/ void OnDidApplyAnimationProperties();

            enum Type
            {
                Simple = 0,
                Sliced = 1,
                Tiled = 2,
                Filled = 3,
            }

            enum FillMethod
            {
                Horizontal = 0,
                Vertical = 1,
                Radial90 = 2,
                Radial180 = 3,
                Radial360 = 4,
            }

            enum OriginHorizontal
            {
                Left = 0,
                Right = 1,
            }

            enum OriginVertical
            {
                Bottom = 0,
                Top = 1,
            }

            enum Origin90
            {
                BottomLeft = 0,
                TopLeft = 1,
                TopRight = 2,
                BottomRight = 3,
            }

            enum Origin180
            {
                Bottom = 0,
                Left = 1,
                Top = 2,
                Right = 3,
            }

            enum Origin360
            {
                Bottom = 0,
                Right = 1,
                Top = 2,
                Left = 3,
            }
        }

        interface IMask
        {
            bool Enabled();
            UnityEngine.RectTransform get_rectTransform();
        }

        interface IMaskable
        {
            void RecalculateMasking();
        }

        class InputField : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement
        {
            static float kHScrollSpeed = 0.05000000074505806;
            static float kVScrollSpeed = 0.10000000149011612;
            static string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
            static string kOculusQuestDeviceModel = "Oculus Quest";
            static int k_MaxTextLength = 16382;
            static /*0x0*/ char[] kSeparators;
            static /*0x8*/ bool s_IsQuestDeviceEvaluated;
            static /*0x9*/ bool s_IsQuestDevice;
            /*0xf8*/ UnityEngine.TouchScreenKeyboard m_Keyboard;
            /*0x100*/ UnityEngine.UI.Text m_TextComponent;
            /*0x108*/ UnityEngine.UI.Graphic m_Placeholder;
            /*0x110*/ UnityEngine.UI.InputField.ContentType m_ContentType;
            /*0x114*/ UnityEngine.UI.InputField.InputType m_InputType;
            /*0x118*/ char m_AsteriskChar;
            /*0x11c*/ UnityEngine.TouchScreenKeyboardType m_KeyboardType;
            /*0x120*/ UnityEngine.UI.InputField.LineType m_LineType;
            /*0x124*/ bool m_HideMobileInput;
            /*0x128*/ UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;
            /*0x12c*/ int m_CharacterLimit;
            /*0x130*/ UnityEngine.UI.InputField.SubmitEvent m_OnSubmit;
            /*0x138*/ UnityEngine.UI.InputField.EndEditEvent m_OnDidEndEdit;
            /*0x140*/ UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;
            /*0x148*/ UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;
            /*0x150*/ UnityEngine.Color m_CaretColor;
            /*0x160*/ bool m_CustomCaretColor;
            /*0x164*/ UnityEngine.Color m_SelectionColor;
            /*0x178*/ string m_Text;
            /*0x180*/ float m_CaretBlinkRate;
            /*0x184*/ int m_CaretWidth;
            /*0x188*/ bool m_ReadOnly;
            /*0x189*/ bool m_ShouldActivateOnSelect;
            /*0x18c*/ int m_CaretPosition;
            /*0x190*/ int m_CaretSelectPosition;
            /*0x198*/ UnityEngine.RectTransform caretRectTrans;
            /*0x1a0*/ UnityEngine.UIVertex[] m_CursorVerts;
            /*0x1a8*/ UnityEngine.TextGenerator m_InputTextCache;
            /*0x1b0*/ UnityEngine.CanvasRenderer m_CachedInputRenderer;
            /*0x1b8*/ bool m_PreventFontCallback;
            /*0x1c0*/ UnityEngine.Mesh m_Mesh;
            /*0x1c8*/ bool m_AllowInput;
            /*0x1c9*/ bool m_ShouldActivateNextUpdate;
            /*0x1ca*/ bool m_UpdateDrag;
            /*0x1cb*/ bool m_DragPositionOutOfBounds;
            /*0x1cc*/ bool m_CaretVisible;
            /*0x1d0*/ UnityEngine.Coroutine m_BlinkCoroutine;
            /*0x1d8*/ float m_BlinkStartTime;
            /*0x1dc*/ int m_DrawStart;
            /*0x1e0*/ int m_DrawEnd;
            /*0x1e8*/ UnityEngine.Coroutine m_DragCoroutine;
            /*0x1f0*/ string m_OriginalText;
            /*0x1f8*/ bool m_WasCanceled;
            /*0x1f9*/ bool m_HasDoneFocusTransition;
            /*0x200*/ UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
            /*0x208*/ bool m_TouchKeyboardAllowsInPlaceEditing;
            /*0x209*/ bool m_IsCompositionActive;
            /*0x210*/ UnityEngine.Event m_ProcessingEvent;

            static /*0x298d9ec*/ InputField();
            static /*0x298698c*/ string get_clipboard();
            static /*0x2986994*/ void set_clipboard(string value);
            static /*0x298b730*/ int GetLineStartPosition(UnityEngine.TextGenerator gen, int line);
            static /*0x29888b0*/ int GetLineEndPosition(UnityEngine.TextGenerator gen, int line);
            /*0x29842bc*/ InputField();
            /*0x2984118*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x2984228*/ string get_compositionString();
            /*0x29845c0*/ UnityEngine.Mesh get_mesh();
            /*0x2984668*/ UnityEngine.TextGenerator get_cachedInputTextGenerator();
            /*0x29846d4*/ void set_shouldHideMobileInput(bool value);
            /*0x298472c*/ bool get_shouldHideMobileInput();
            /*0x2984774*/ void set_shouldActivateOnSelect(bool value);
            /*0x2984780*/ bool get_shouldActivateOnSelect();
            /*0x29847ac*/ string get_text();
            /*0x29847b4*/ void set_text(string value);
            /*0x2984ac8*/ void SetTextWithoutNotify(string input);
            /*0x29847bc*/ void SetText(string value, bool sendCallback);
            /*0x2985044*/ bool get_isFocused();
            /*0x298504c*/ float get_caretBlinkRate();
            /*0x2985054*/ void set_caretBlinkRate(float value);
            /*0x2985124*/ int get_caretWidth();
            /*0x298512c*/ void set_caretWidth(int value);
            /*0x29851f8*/ UnityEngine.UI.Text get_textComponent();
            /*0x2985200*/ void set_textComponent(UnityEngine.UI.Text value);
            /*0x29854a4*/ UnityEngine.UI.Graphic get_placeholder();
            /*0x29854ac*/ void set_placeholder(UnityEngine.UI.Graphic value);
            /*0x2985504*/ UnityEngine.Color get_caretColor();
            /*0x2985548*/ void set_caretColor(UnityEngine.Color value);
            /*0x2985574*/ bool get_customCaretColor();
            /*0x298557c*/ void set_customCaretColor(bool value);
            /*0x2985598*/ UnityEngine.Color get_selectionColor();
            /*0x29855ac*/ void set_selectionColor(UnityEngine.Color value);
            /*0x29855d8*/ UnityEngine.UI.InputField.EndEditEvent get_onEndEdit();
            /*0x29855e0*/ void set_onEndEdit(UnityEngine.UI.InputField.EndEditEvent value);
            /*0x2985638*/ UnityEngine.UI.InputField.SubmitEvent get_onSubmit();
            /*0x2985640*/ void set_onSubmit(UnityEngine.UI.InputField.SubmitEvent value);
            /*0x2985698*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChange();
            /*0x29856a0*/ void set_onValueChange(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x29856fc*/ UnityEngine.UI.InputField.OnChangeEvent get_onValueChanged();
            /*0x29856a4*/ void set_onValueChanged(UnityEngine.UI.InputField.OnChangeEvent value);
            /*0x2985704*/ UnityEngine.UI.InputField.OnValidateInput get_onValidateInput();
            /*0x298570c*/ void set_onValidateInput(UnityEngine.UI.InputField.OnValidateInput value);
            /*0x2985764*/ int get_characterLimit();
            /*0x298576c*/ void set_characterLimit(int value);
            /*0x298582c*/ UnityEngine.UI.InputField.ContentType get_contentType();
            /*0x2985834*/ void set_contentType(UnityEngine.UI.InputField.ContentType value);
            /*0x2985964*/ UnityEngine.UI.InputField.LineType get_lineType();
            /*0x298596c*/ void set_lineType(UnityEngine.UI.InputField.LineType value);
            /*0x2985a84*/ UnityEngine.UI.InputField.InputType get_inputType();
            /*0x2985a8c*/ void set_inputType(UnityEngine.UI.InputField.InputType value);
            /*0x2985b28*/ UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard();
            /*0x2985b30*/ UnityEngine.TouchScreenKeyboardType get_keyboardType();
            /*0x2985b38*/ void set_keyboardType(UnityEngine.TouchScreenKeyboardType value);
            /*0x2985bbc*/ UnityEngine.UI.InputField.CharacterValidation get_characterValidation();
            /*0x2985bc4*/ void set_characterValidation(UnityEngine.UI.InputField.CharacterValidation value);
            /*0x2985c48*/ bool get_readOnly();
            /*0x2985c50*/ void set_readOnly(bool value);
            /*0x2985c5c*/ bool get_multiLine();
            /*0x2985c70*/ char get_asteriskChar();
            /*0x2985c78*/ void set_asteriskChar(char value);
            /*0x2985cec*/ bool get_wasCanceled();
            /*0x2985cf4*/ void ClampPos(ref int pos);
            /*0x2985d2c*/ int get_caretPositionInternal();
            /*0x2985d50*/ void set_caretPositionInternal(int value);
            /*0x2985d88*/ int get_caretSelectPositionInternal();
            /*0x2985dac*/ void set_caretSelectPositionInternal(int value);
            /*0x2985de4*/ bool get_hasSelection();
            /*0x2985e14*/ int get_caretPosition();
            /*0x2985e38*/ void set_caretPosition(int value);
            /*0x2985f18*/ int get_selectionAnchorPosition();
            /*0x2985e60*/ void set_selectionAnchorPosition(int value);
            /*0x2985f3c*/ int get_selectionFocusPosition();
            /*0x2985ebc*/ void set_selectionFocusPosition(int value);
            /*0x2985f60*/ void Awake();
            /*0x2986020*/ void OnEnable();
            /*0x298628c*/ void OnDisable();
            /*0x298663c*/ void OnDestroy();
            /*0x29866a0*/ System.Collections.IEnumerator CaretBlink();
            /*0x2986730*/ void SetCaretVisible();
            /*0x29850d0*/ void SetCaretActive();
            /*0x2986768*/ void UpdateCaretMaterial();
            /*0x2986878*/ void OnFocus();
            /*0x298687c*/ void SelectAll();
            /*0x29868b0*/ void MoveTextEnd(bool shift);
            /*0x2986910*/ void MoveTextStart(bool shift);
            /*0x298699c*/ bool TouchScreenKeyboardShouldBeUsed();
            /*0x2986a1c*/ bool InPlaceEditing();
            /*0x2986a4c*/ bool InPlaceEditingChanged();
            /*0x2986ad0*/ void UpdateCaretFromKeyboard();
            /*0x2986bb8*/ void LateUpdate();
            /*0x298819c*/ UnityEngine.Vector2 ScreenToLocal(UnityEngine.Vector2 screen);
            /*0x298840c*/ int GetUnclampedCharacterLineFromPosition(UnityEngine.Vector2 pos, UnityEngine.TextGenerator generator);
            /*0x298861c*/ int GetCharacterIndexFromPosition(UnityEngine.Vector2 pos);
            /*0x2988a14*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988aec*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988b0c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988cf8*/ System.Collections.IEnumerator MouseDragOutsideRect(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988d94*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988db0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x2988fa0*/ UnityEngine.UI.InputField.EditState KeyPressed(UnityEngine.Event evt);
            /*0x2989a34*/ bool IsValidChar(char c);
            /*0x2989aa4*/ void ProcessEvent(UnityEngine.Event e);
            /*0x2989aa8*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x2989520*/ string GetSelectedString();
            /*0x2989c30*/ int FindtNextWordBegin();
            /*0x29898f0*/ void MoveRight(bool shift, bool ctrl);
            /*0x2989cec*/ int FindtPrevWordBegin();
            /*0x29897c4*/ void MoveLeft(bool shift, bool ctrl);
            /*0x2989d8c*/ int DetermineCharacterLine(int charPos, UnityEngine.TextGenerator generator);
            /*0x2989e9c*/ int LineUpCharacterPosition(int originalPos, bool goToFirstChar);
            /*0x298a1f4*/ int LineDownCharacterPosition(int originalPos, bool goToLastChar);
            /*0x2989a28*/ void MoveDown(bool shift);
            /*0x298a4a8*/ void MoveDown(bool shift, bool goToLastChar);
            /*0x2989a1c*/ void MoveUp(bool shift);
            /*0x298a5dc*/ void MoveUp(bool shift, bool goToFirstChar);
            /*0x29895c8*/ void Delete();
            /*0x298947c*/ void ForwardSpace();
            /*0x2989378*/ void Backspace();
            /*0x298a71c*/ void Insert(char c);
            /*0x298977c*/ void UpdateTouchKeyboardFromEditChanges();
            /*0x2988184*/ void SendOnValueChangedAndUpdateLabel();
            /*0x2984ba8*/ void SendOnValueChanged();
            /*0x298a7fc*/ void SendOnEndEdit();
            /*0x2987a30*/ void SendOnSubmit();
            /*0x298a87c*/ void Append(string input);
            /*0x298a938*/ void Append(char input);
            /*0x2984c28*/ void UpdateLabel();
            /*0x298b6c4*/ bool IsSelectionVisible();
            /*0x298aba8*/ void SetDrawRangeToContainCaretPosition(int caretPos);
            /*0x298b880*/ void ForceLabelUpdate();
            /*0x29851a0*/ void MarkGeometryAsDirty();
            /*0x298b884*/ void Rebuild(UnityEngine.UI.CanvasUpdate update);
            /*0x298bce4*/ void LayoutComplete();
            /*0x298bce8*/ void GraphicUpdateComplete();
            /*0x298b894*/ void UpdateGeometry();
            /*0x2987530*/ void AssignPositioningIfNeeded();
            /*0x298bcec*/ void OnFillVBO(UnityEngine.Mesh vbo);
            /*0x298bf64*/ void GenerateCaret(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x298d394*/ void CreateCursorVerts();
            /*0x298c938*/ void GenerateHighlight(UnityEngine.UI.VertexHelper vbo, UnityEngine.Vector2 roundingOffset);
            /*0x2987ab0*/ char Validate(string text, int pos, char ch);
            /*0x298d4e4*/ void ActivateInputField();
            /*0x29871e0*/ void ActivateInputFieldInternal();
            /*0x298d604*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x298d640*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29864c0*/ void DeactivateInputField();
            /*0x298d664*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x298d690*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29858a8*/ void EnforceContentType();
            /*0x298452c*/ void EnforceTextHOverflow();
            /*0x2985a2c*/ void SetToCustomIfContentTypeIsNot(UnityEngine.UI.InputField.ContentType[] allowedContentTypes);
            /*0x2985b10*/ void SetToCustom();
            /*0x298d6d8*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x298d704*/ void CalculateLayoutInputHorizontal();
            /*0x298d708*/ void CalculateLayoutInputVertical();
            /*0x298d70c*/ float get_minWidth();
            /*0x298d714*/ float get_preferredWidth();
            /*0x298d870*/ float get_flexibleWidth();
            /*0x298d878*/ float get_minHeight();
            /*0x298d880*/ float get_preferredHeight();
            /*0x298d9dc*/ float get_flexibleHeight();
            /*0x298d9e4*/ int get_layoutPriority();
            /*0x298da8c*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ContentType
            {
                Standard = 0,
                Autocorrected = 1,
                IntegerNumber = 2,
                DecimalNumber = 3,
                Alphanumeric = 4,
                Name = 5,
                EmailAddress = 6,
                Password = 7,
                Pin = 8,
                Custom = 9,
            }

            enum InputType
            {
                Standard = 0,
                AutoCorrect = 1,
                Password = 2,
            }

            enum CharacterValidation
            {
                None = 0,
                Integer = 1,
                Decimal = 2,
                Alphanumeric = 3,
                Name = 4,
                EmailAddress = 5,
            }

            enum LineType
            {
                SingleLine = 0,
                MultiLineSubmit = 1,
                MultiLineNewline = 2,
            }

            class OnValidateInput : System.MulticastDelegate
            {
                /*0x2984ad0*/ OnValidateInput(object object, nint method);
                /*0x298da94*/ char Invoke(string text, int charIndex, char addedChar);
                /*0x298daa8*/ System.IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, System.AsyncCallback callback, object object);
                /*0x298db68*/ char EndInvoke(System.IAsyncResult result);
            }

            class SubmitEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x2984454*/ SubmitEvent();
            }

            class EndEditEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x298449c*/ EndEditEvent();
            }

            class OnChangeEvent : UnityEngine.Events.UnityEvent<string>
            {
                /*0x29844e4*/ OnChangeEvent();
            }

            enum EditState
            {
                Continue = 0,
                Finish = 1,
            }

            class <CaretBlink>d__172 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.InputField <>4__this;

                /*0x2986708*/ <CaretBlink>d__172(int <>1__state);
                /*0x298db90*/ void System.IDisposable.Dispose();
                /*0x298db94*/ bool MoveNext();
                /*0x298dca0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x298dca8*/ void System.Collections.IEnumerator.Reset();
                /*0x298dce8*/ object System.Collections.IEnumerator.get_Current();
            }

            class <MouseDragOutsideRect>d__194 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.EventSystems.PointerEventData eventData;
                /*0x28*/ UnityEngine.UI.InputField <>4__this;

                /*0x2988d6c*/ <MouseDragOutsideRect>d__194(int <>1__state);
                /*0x298dcf0*/ void System.IDisposable.Dispose();
                /*0x298dcf4*/ bool MoveNext();
                /*0x298df9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x298dfa4*/ void System.Collections.IEnumerator.Reset();
                /*0x298dfe4*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class AspectRatioFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.UI.AspectRatioFitter.AspectMode m_AspectMode;
            /*0x1c*/ float m_AspectRatio;
            /*0x20*/ UnityEngine.RectTransform m_Rect;
            /*0x28*/ bool m_DelayedSetDirty;
            /*0x29*/ bool m_DoesParentExist;
            /*0x2a*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x298e17c*/ AspectRatioFitter();
            /*0x298dfec*/ UnityEngine.UI.AspectRatioFitter.AspectMode get_aspectMode();
            /*0x298dff4*/ void set_aspectMode(UnityEngine.UI.AspectRatioFitter.AspectMode value);
            /*0x298e06c*/ float get_aspectRatio();
            /*0x298e074*/ void set_aspectRatio(float value);
            /*0x298e0e8*/ UnityEngine.RectTransform get_rectTransform();
            /*0x298e18c*/ void OnEnable();
            /*0x298e224*/ void Start();
            /*0x298e368*/ void OnDisable();
            /*0x298e7d0*/ void OnTransformParentChanged();
            /*0x298e868*/ void Update();
            /*0x298e87c*/ void OnRectTransformDimensionsChange();
            /*0x298e880*/ void UpdateRect();
            /*0x298ec94*/ float GetSizeDeltaToProduceSize(float size, int axis);
            /*0x298eb84*/ UnityEngine.Vector2 GetParentSize();
            /*0x298ed8c*/ void SetLayoutHorizontal();
            /*0x298ed90*/ void SetLayoutVertical();
            /*0x298e068*/ void SetDirty();
            /*0x298e274*/ bool IsComponentValidOnObject();
            /*0x298e340*/ bool IsAspectModeValid();
            /*0x298ed94*/ bool DoesParentExists();

            enum AspectMode
            {
                None = 0,
                WidthControlsHeight = 1,
                HeightControlsWidth = 2,
                FitInParent = 3,
                EnvelopeParent = 4,
            }
        }

        class CanvasScaler : UnityEngine.EventSystems.UIBehaviour
        {
            static float kLogBase = 2;
            /*0x18*/ UnityEngine.UI.CanvasScaler.ScaleMode m_UiScaleMode;
            /*0x1c*/ float m_ReferencePixelsPerUnit;
            /*0x20*/ float m_ScaleFactor;
            /*0x24*/ UnityEngine.Vector2 m_ReferenceResolution;
            /*0x2c*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode m_ScreenMatchMode;
            /*0x30*/ float m_MatchWidthOrHeight;
            /*0x34*/ UnityEngine.UI.CanvasScaler.Unit m_PhysicalUnit;
            /*0x38*/ float m_FallbackScreenDPI;
            /*0x3c*/ float m_DefaultSpriteDPI;
            /*0x40*/ float m_DynamicPixelsPerUnit;
            /*0x48*/ UnityEngine.Canvas m_Canvas;
            /*0x50*/ float m_PrevScaleFactor;
            /*0x54*/ float m_PrevReferencePixelsPerUnit;
            /*0x58*/ bool m_PresetInfoIsWorld;

            /*0x298eeac*/ CanvasScaler();
            /*0x298ed9c*/ UnityEngine.UI.CanvasScaler.ScaleMode get_uiScaleMode();
            /*0x298eda4*/ void set_uiScaleMode(UnityEngine.UI.CanvasScaler.ScaleMode value);
            /*0x298edac*/ float get_referencePixelsPerUnit();
            /*0x298edb4*/ void set_referencePixelsPerUnit(float value);
            /*0x298edbc*/ float get_scaleFactor();
            /*0x298edc4*/ void set_scaleFactor(float value);
            /*0x298edd8*/ UnityEngine.Vector2 get_referenceResolution();
            /*0x298ede0*/ void set_referenceResolution(UnityEngine.Vector2 value);
            /*0x298ee44*/ UnityEngine.UI.CanvasScaler.ScreenMatchMode get_screenMatchMode();
            /*0x298ee4c*/ void set_screenMatchMode(UnityEngine.UI.CanvasScaler.ScreenMatchMode value);
            /*0x298ee54*/ float get_matchWidthOrHeight();
            /*0x298ee5c*/ void set_matchWidthOrHeight(float value);
            /*0x298ee64*/ UnityEngine.UI.CanvasScaler.Unit get_physicalUnit();
            /*0x298ee6c*/ void set_physicalUnit(UnityEngine.UI.CanvasScaler.Unit value);
            /*0x298ee74*/ float get_fallbackScreenDPI();
            /*0x298ee7c*/ void set_fallbackScreenDPI(float value);
            /*0x298ee84*/ float get_defaultSpriteDPI();
            /*0x298ee8c*/ void set_defaultSpriteDPI(float value);
            /*0x298ee9c*/ float get_dynamicPixelsPerUnit();
            /*0x298eea4*/ void set_dynamicPixelsPerUnit(float value);
            /*0x298eef4*/ void OnEnable();
            /*0x298efc0*/ void Canvas_preWillRenderCanvases();
            /*0x298efd0*/ void OnDisable();
            /*0x298f0f8*/ void Handle();
            /*0x298f1f4*/ void HandleWorldCanvas();
            /*0x298f214*/ void HandleConstantPixelSize();
            /*0x298f234*/ void HandleScaleWithScreenSize();
            /*0x298f468*/ void HandleConstantPhysicalSize();
            /*0x298f078*/ void SetScaleFactor(float scaleFactor);
            /*0x298f0b8*/ void SetReferencePixelsPerUnit(float referencePixelsPerUnit);

            enum ScaleMode
            {
                ConstantPixelSize = 0,
                ScaleWithScreenSize = 1,
                ConstantPhysicalSize = 2,
            }

            enum ScreenMatchMode
            {
                MatchWidthOrHeight = 0,
                Expand = 1,
                Shrink = 2,
            }

            enum Unit
            {
                Centimeters = 0,
                Millimeters = 1,
                Inches = 2,
                Points = 3,
                Picas = 4,
            }
        }

        class ContentSizeFitter : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutSelfController, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.UI.ContentSizeFitter.FitMode m_HorizontalFit;
            /*0x1c*/ UnityEngine.UI.ContentSizeFitter.FitMode m_VerticalFit;
            /*0x20*/ UnityEngine.RectTransform m_Rect;
            /*0x28*/ UnityEngine.DrivenRectTransformTracker m_Tracker;

            /*0x298f6e4*/ ContentSizeFitter();
            /*0x298f4d4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_horizontalFit();
            /*0x298f4dc*/ void set_horizontalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x298f5d4*/ UnityEngine.UI.ContentSizeFitter.FitMode get_verticalFit();
            /*0x298f5dc*/ void set_verticalFit(UnityEngine.UI.ContentSizeFitter.FitMode value);
            /*0x298f650*/ UnityEngine.RectTransform get_rectTransform();
            /*0x298f6ec*/ void OnEnable();
            /*0x298f708*/ void OnDisable();
            /*0x298f784*/ void OnRectTransformDimensionsChange();
            /*0x298f788*/ void HandleSelfFittingAlongAxis(int axis);
            /*0x298f884*/ void SetLayoutHorizontal();
            /*0x298f8a8*/ void SetLayoutVertical();
            /*0x298f550*/ void SetDirty();

            enum FitMode
            {
                Unconstrained = 0,
                MinSize = 1,
                PreferredSize = 2,
            }
        }

        class GridLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x58*/ UnityEngine.UI.GridLayoutGroup.Corner m_StartCorner;
            /*0x5c*/ UnityEngine.UI.GridLayoutGroup.Axis m_StartAxis;
            /*0x60*/ UnityEngine.Vector2 m_CellSize;
            /*0x68*/ UnityEngine.Vector2 m_Spacing;
            /*0x70*/ UnityEngine.UI.GridLayoutGroup.Constraint m_Constraint;
            /*0x74*/ int m_ConstraintCount;

            /*0x298fb1c*/ GridLayoutGroup();
            /*0x298f8b0*/ UnityEngine.UI.GridLayoutGroup.Corner get_startCorner();
            /*0x298f8b8*/ void set_startCorner(UnityEngine.UI.GridLayoutGroup.Corner value);
            /*0x298f914*/ UnityEngine.UI.GridLayoutGroup.Axis get_startAxis();
            /*0x298f91c*/ void set_startAxis(UnityEngine.UI.GridLayoutGroup.Axis value);
            /*0x298f978*/ UnityEngine.Vector2 get_cellSize();
            /*0x298f980*/ void set_cellSize(UnityEngine.Vector2 value);
            /*0x298f9e4*/ UnityEngine.Vector2 get_spacing();
            /*0x298f9ec*/ void set_spacing(UnityEngine.Vector2 value);
            /*0x298fa50*/ UnityEngine.UI.GridLayoutGroup.Constraint get_constraint();
            /*0x298fa58*/ void set_constraint(UnityEngine.UI.GridLayoutGroup.Constraint value);
            /*0x298fab4*/ int get_constraintCount();
            /*0x298fabc*/ void set_constraintCount(int value);
            /*0x298fcb0*/ void CalculateLayoutInputHorizontal();
            /*0x29902bc*/ void CalculateLayoutInputVertical();
            /*0x2990578*/ void SetLayoutHorizontal();
            /*0x2990b58*/ void SetLayoutVertical();
            /*0x2990580*/ void SetCellsAlongAxis(int axis);

            enum Corner
            {
                UpperLeft = 0,
                UpperRight = 1,
                LowerLeft = 2,
                LowerRight = 3,
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }

            enum Constraint
            {
                Flexible = 0,
                FixedColumnCount = 1,
                FixedRowCount = 2,
            }
        }

        class HorizontalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x2990d74*/ HorizontalLayoutGroup();
            /*0x2990d8c*/ void CalculateLayoutInputHorizontal();
            /*0x2991050*/ void CalculateLayoutInputVertical();
            /*0x299105c*/ void SetLayoutHorizontal();
            /*0x29916d4*/ void SetLayoutVertical();
        }

        class HorizontalOrVerticalLayoutGroup : UnityEngine.UI.LayoutGroup
        {
            /*0x58*/ float m_Spacing;
            /*0x5c*/ bool m_ChildForceExpandWidth;
            /*0x5d*/ bool m_ChildForceExpandHeight;
            /*0x5e*/ bool m_ChildControlWidth;
            /*0x5f*/ bool m_ChildControlHeight;
            /*0x60*/ bool m_ChildScaleWidth;
            /*0x61*/ bool m_ChildScaleHeight;
            /*0x62*/ bool m_ReverseArrangement;

            /*0x2990d80*/ HorizontalOrVerticalLayoutGroup();
            /*0x29916e0*/ float get_spacing();
            /*0x29916e8*/ void set_spacing(float value);
            /*0x2991744*/ bool get_childForceExpandWidth();
            /*0x299174c*/ void set_childForceExpandWidth(bool value);
            /*0x29917a8*/ bool get_childForceExpandHeight();
            /*0x29917b0*/ void set_childForceExpandHeight(bool value);
            /*0x299180c*/ bool get_childControlWidth();
            /*0x2991814*/ void set_childControlWidth(bool value);
            /*0x2991870*/ bool get_childControlHeight();
            /*0x2991878*/ void set_childControlHeight(bool value);
            /*0x29918d4*/ bool get_childScaleWidth();
            /*0x29918dc*/ void set_childScaleWidth(bool value);
            /*0x2991938*/ bool get_childScaleHeight();
            /*0x2991940*/ void set_childScaleHeight(bool value);
            /*0x299199c*/ bool get_reverseArrangement();
            /*0x29919a4*/ void set_reverseArrangement(bool value);
            /*0x2990dac*/ void CalcAlongAxis(int axis, bool isVertical);
            /*0x2991068*/ void SetChildrenAlongAxis(int axis, bool isVertical);
            /*0x2991a00*/ void GetChildSizes(UnityEngine.RectTransform child, int axis, bool controlSize, bool childForceExpand, ref float min, ref float preferred, ref float flexible);
        }

        interface ILayoutElement
        {
            void CalculateLayoutInputHorizontal();
            void CalculateLayoutInputVertical();
            float get_minWidth();
            float get_preferredWidth();
            float get_flexibleWidth();
            float get_minHeight();
            float get_preferredHeight();
            float get_flexibleHeight();
            int get_layoutPriority();
        }

        interface ILayoutController
        {
            void SetLayoutHorizontal();
            void SetLayoutVertical();
        }

        interface ILayoutGroup : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutSelfController : UnityEngine.UI.ILayoutController
        {
        }

        interface ILayoutIgnorer
        {
            bool get_ignoreLayout();
        }

        class LayoutElement : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutIgnorer
        {
            /*0x18*/ bool m_IgnoreLayout;
            /*0x1c*/ float m_MinWidth;
            /*0x20*/ float m_MinHeight;
            /*0x24*/ float m_PreferredWidth;
            /*0x28*/ float m_PreferredHeight;
            /*0x2c*/ float m_FlexibleWidth;
            /*0x30*/ float m_FlexibleHeight;
            /*0x34*/ int m_LayoutPriority;

            /*0x2992630*/ LayoutElement();
            /*0x2992190*/ bool get_ignoreLayout();
            /*0x2992198*/ void set_ignoreLayout(bool value);
            /*0x29922c4*/ void CalculateLayoutInputHorizontal();
            /*0x29922c8*/ void CalculateLayoutInputVertical();
            /*0x29922cc*/ float get_minWidth();
            /*0x29922d4*/ void set_minWidth(float value);
            /*0x2992348*/ float get_minHeight();
            /*0x2992350*/ void set_minHeight(float value);
            /*0x29923c4*/ float get_preferredWidth();
            /*0x29923cc*/ void set_preferredWidth(float value);
            /*0x2992440*/ float get_preferredHeight();
            /*0x2992448*/ void set_preferredHeight(float value);
            /*0x29924bc*/ float get_flexibleWidth();
            /*0x29924c4*/ void set_flexibleWidth(float value);
            /*0x2992538*/ float get_flexibleHeight();
            /*0x2992540*/ void set_flexibleHeight(float value);
            /*0x29925b4*/ int get_layoutPriority();
            /*0x29925bc*/ void set_layoutPriority(int value);
            /*0x2992654*/ void OnEnable();
            /*0x2992670*/ void OnTransformParentChanged();
            /*0x2992674*/ void OnDisable();
            /*0x2992690*/ void OnDidApplyAnimationProperties();
            /*0x2992694*/ void OnBeforeTransformParentChanged();
            /*0x299220c*/ void SetDirty();
        }

        class LayoutGroup : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.RectOffset m_Padding;
            /*0x20*/ UnityEngine.TextAnchor m_ChildAlignment;
            /*0x28*/ UnityEngine.RectTransform m_Rect;
            /*0x30*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x34*/ UnityEngine.Vector2 m_TotalMinSize;
            /*0x3c*/ UnityEngine.Vector2 m_TotalPreferredSize;
            /*0x44*/ UnityEngine.Vector2 m_TotalFlexibleSize;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.RectTransform> m_RectChildren;

            /*0x298fb84*/ LayoutGroup();
            /*0x2992698*/ UnityEngine.RectOffset get_padding();
            /*0x29926a0*/ void set_padding(UnityEngine.RectOffset value);
            /*0x29926fc*/ UnityEngine.TextAnchor get_childAlignment();
            /*0x2992704*/ void set_childAlignment(UnityEngine.TextAnchor value);
            /*0x29904e4*/ UnityEngine.RectTransform get_rectTransform();
            /*0x2992760*/ System.Collections.Generic.List<UnityEngine.RectTransform> get_rectChildren();
            /*0x298fe7c*/ void CalculateLayoutInputHorizontal();
            void CalculateLayoutInputVertical();
            /*0x2992768*/ float get_minWidth();
            /*0x2992770*/ float get_preferredWidth();
            /*0x2992778*/ float get_flexibleWidth();
            /*0x2992780*/ float get_minHeight();
            /*0x2992788*/ float get_preferredHeight();
            /*0x2992790*/ float get_flexibleHeight();
            /*0x2992798*/ int get_layoutPriority();
            void SetLayoutHorizontal();
            void SetLayoutVertical();
            /*0x29927a0*/ void OnEnable();
            /*0x2992890*/ void OnDisable();
            /*0x299290c*/ void OnDidApplyAnimationProperties();
            /*0x2992110*/ float GetTotalMinSize(int axis);
            /*0x2992028*/ float GetTotalPreferredSize(int axis);
            /*0x299209c*/ float GetTotalFlexibleSize(int axis);
            /*0x2990b60*/ float GetStartOffset(int axis, float requiredSpaceWithoutPadding);
            /*0x2991b18*/ float GetAlignmentOnAxis(int axis);
            /*0x2990238*/ void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis);
            /*0x2992910*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos);
            /*0x2991de8*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float scaleFactor);
            /*0x2990cc4*/ void SetChildAlongAxis(UnityEngine.RectTransform rect, int axis, float pos, float size);
            /*0x2991b64*/ void SetChildAlongAxisWithScale(UnityEngine.RectTransform rect, int axis, float pos, float size, float scaleFactor);
            /*0x29929b8*/ bool get_isRootLayoutGroup();
            /*0x2992af0*/ void OnRectTransformDimensionsChange();
            /*0x2992b20*/ void OnTransformChildrenChanged();
            void SetProperty<T>(ref T currentValue, T newValue);
            /*0x29927bc*/ void SetDirty();
            /*0x2992b24*/ System.Collections.IEnumerator DelayedSetDirty(UnityEngine.RectTransform rectTransform);

            class <DelayedSetDirty>d__56 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.RectTransform rectTransform;

                /*0x2992b8c*/ <DelayedSetDirty>d__56(int <>1__state);
                /*0x2992bb4*/ void System.IDisposable.Dispose();
                /*0x2992bb8*/ bool MoveNext();
                /*0x2992c40*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2992c48*/ void System.Collections.IEnumerator.Reset();
                /*0x2992c88*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class LayoutRebuilder : UnityEngine.UI.ICanvasElement
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<UnityEngine.UI.LayoutRebuilder> s_Rebuilders;
            /*0x10*/ UnityEngine.RectTransform m_ToRebuild;
            /*0x18*/ int m_CachedHashFromTransform;

            static /*0x2992cd0*/ LayoutRebuilder();
            static /*0x2992ea8*/ void ReapplyDrivenProperties(UnityEngine.RectTransform driven);
            static /*0x2992f64*/ void StripDisabledBehavioursFromList(System.Collections.Generic.List<UnityEngine.Component> components);
            static /*0x2993060*/ void ForceRebuildLayoutImmediate(UnityEngine.RectTransform layoutRoot);
            static /*0x298e3e4*/ void MarkLayoutForRebuild(UnityEngine.RectTransform rect);
            static /*0x2993ac0*/ bool ValidController(UnityEngine.RectTransform layoutRoot, System.Collections.Generic.List<UnityEngine.Component> comps);
            static /*0x2993cb4*/ void MarkLayoutRootForRebuild(UnityEngine.RectTransform controller);
            /*0x2993f60*/ LayoutRebuilder();
            /*0x2992c90*/ void Initialize(UnityEngine.RectTransform controller);
            /*0x2992cc4*/ void Clear();
            /*0x2992efc*/ UnityEngine.Transform get_transform();
            /*0x2992f04*/ bool IsDestroyed();
            /*0x299313c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x29936f0*/ void PerformLayoutControl(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x29933f0*/ void PerformLayoutCalculation(UnityEngine.RectTransform rect, UnityEngine.Events.UnityAction<UnityEngine.Component> action);
            /*0x2993e18*/ void LayoutComplete();
            /*0x2993e98*/ void GraphicUpdateComplete();
            /*0x2993e9c*/ int GetHashCode();
            /*0x2993ea4*/ bool Equals(object obj);
            /*0x2993ef4*/ string ToString();

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutRebuilder.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.Component> <>9__10_0;
                static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_0;
                static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_1;
                static /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_2;
                static /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.Component> <>9__12_3;

                static /*0x2993f68*/ <>c();
                /*0x2993fcc*/ <>c();
                /*0x2993fd4*/ UnityEngine.UI.LayoutRebuilder <.cctor>b__5_0();
                /*0x2994030*/ void <.cctor>b__5_1(UnityEngine.UI.LayoutRebuilder x);
                /*0x299404c*/ bool <StripDisabledBehavioursFromList>b__10_0(UnityEngine.Component e);
                /*0x29940d8*/ void <Rebuild>b__12_0(UnityEngine.Component e);
                /*0x2994194*/ void <Rebuild>b__12_1(UnityEngine.Component e);
                /*0x2994250*/ void <Rebuild>b__12_2(UnityEngine.Component e);
                /*0x2994310*/ void <Rebuild>b__12_3(UnityEngine.Component e);
            }
        }

        class LayoutUtility
        {
            static /*0x298f86c*/ float GetMinSize(UnityEngine.RectTransform rect, int axis);
            static /*0x298f878*/ float GetPreferredSize(UnityEngine.RectTransform rect, int axis);
            static /*0x2992184*/ float GetFlexibleSize(UnityEngine.RectTransform rect, int axis);
            static /*0x29944c0*/ float GetMinWidth(UnityEngine.RectTransform rect);
            static /*0x2994744*/ float GetPreferredWidth(UnityEngine.RectTransform rect);
            static /*0x29949c8*/ float GetFlexibleWidth(UnityEngine.RectTransform rect);
            static /*0x29943d0*/ float GetMinHeight(UnityEngine.RectTransform rect);
            static /*0x29945b0*/ float GetPreferredHeight(UnityEngine.RectTransform rect);
            static /*0x29948d8*/ float GetFlexibleHeight(UnityEngine.RectTransform rect);
            static /*0x2994ab8*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue);
            static /*0x2994ad0*/ float GetLayoutProperty(UnityEngine.RectTransform rect, System.Func<UnityEngine.UI.ILayoutElement, float> property, float defaultValue, ref UnityEngine.UI.ILayoutElement source);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.LayoutUtility.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__3_0;
                static /*0x10*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_0;
                static /*0x18*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__4_1;
                static /*0x20*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__5_0;
                static /*0x28*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__6_0;
                static /*0x30*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_0;
                static /*0x38*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__7_1;
                static /*0x40*/ System.Func<UnityEngine.UI.ILayoutElement, float> <>9__8_0;

                static /*0x2994de0*/ <>c();
                /*0x2994e44*/ <>c();
                /*0x2994e4c*/ float <GetMinWidth>b__3_0(UnityEngine.UI.ILayoutElement e);
                /*0x2994eec*/ float <GetPreferredWidth>b__4_0(UnityEngine.UI.ILayoutElement e);
                /*0x2994f8c*/ float <GetPreferredWidth>b__4_1(UnityEngine.UI.ILayoutElement e);
                /*0x299502c*/ float <GetFlexibleWidth>b__5_0(UnityEngine.UI.ILayoutElement e);
                /*0x29950cc*/ float <GetMinHeight>b__6_0(UnityEngine.UI.ILayoutElement e);
                /*0x299516c*/ float <GetPreferredHeight>b__7_0(UnityEngine.UI.ILayoutElement e);
                /*0x299520c*/ float <GetPreferredHeight>b__7_1(UnityEngine.UI.ILayoutElement e);
                /*0x29952ac*/ float <GetFlexibleHeight>b__8_0(UnityEngine.UI.ILayoutElement e);
            }
        }

        class VerticalLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
        {
            /*0x299534c*/ VerticalLayoutGroup();
            /*0x2995358*/ void CalculateLayoutInputHorizontal();
            /*0x2995378*/ void CalculateLayoutInputVertical();
            /*0x2995384*/ void SetLayoutHorizontal();
            /*0x2995390*/ void SetLayoutVertical();
        }

        class Mask : UnityEngine.EventSystems.UIBehaviour, UnityEngine.ICanvasRaycastFilter, UnityEngine.UI.IMaterialModifier
        {
            /*0x18*/ UnityEngine.RectTransform m_RectTransform;
            /*0x20*/ bool m_ShowMaskGraphic;
            /*0x28*/ UnityEngine.UI.Graphic m_Graphic;
            /*0x30*/ UnityEngine.Material m_MaskMaterial;
            /*0x38*/ UnityEngine.Material m_UnmaskMaterial;

            /*0x2995504*/ Mask();
            /*0x299539c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x29953f4*/ bool get_showMaskGraphic();
            /*0x29953fc*/ void set_showMaskGraphic(bool value);
            /*0x29954ac*/ UnityEngine.UI.Graphic get_graphic();
            /*0x2995514*/ bool MaskEnabled();
            /*0x29955a4*/ void OnSiblingGraphicEnabledDisabled();
            /*0x29955a8*/ void OnEnable();
            /*0x2995978*/ void OnDisable();
            /*0x2995b3c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x2995be8*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class MaskableGraphic : UnityEngine.UI.Graphic, UnityEngine.UI.IClippable, UnityEngine.UI.IMaskable, UnityEngine.UI.IMaterialModifier
        {
            /*0x99*/ bool m_ShouldRecalculateStencil;
            /*0xa0*/ UnityEngine.Material m_MaskMaterial;
            /*0xa8*/ UnityEngine.UI.RectMask2D m_ParentMask;
            /*0xb0*/ bool m_Maskable;
            /*0xb1*/ bool m_IsMaskingGraphic;
            /*0xb2*/ bool m_IncludeForMasking;
            /*0xb8*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;
            /*0xc0*/ bool m_ShouldRecalculate;
            /*0xc4*/ int m_StencilValue;
            /*0xc8*/ UnityEngine.Vector3[] m_Corners;

            /*0x2996f3c*/ MaskableGraphic();
            /*0x29962a4*/ UnityEngine.UI.MaskableGraphic.CullStateChangedEvent get_onCullStateChanged();
            /*0x29962ac*/ void set_onCullStateChanged(UnityEngine.UI.MaskableGraphic.CullStateChangedEvent value);
            /*0x29962b4*/ bool get_maskable();
            /*0x29962bc*/ void set_maskable(bool value);
            /*0x29962ec*/ bool get_isMaskingGraphic();
            /*0x2995708*/ void set_isMaskingGraphic(bool value);
            /*0x29962f4*/ UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
            /*0x29963f4*/ void Cull(UnityEngine.Rect clipRect, bool validRect);
            /*0x299662c*/ void UpdateCull(bool cull);
            /*0x2996708*/ void SetClipRect(UnityEngine.Rect clipRect, bool validRect);
            /*0x2996774*/ void SetClipSoftness(UnityEngine.Vector2 clipSoftness);
            /*0x29967ac*/ void OnEnable();
            /*0x2996950*/ void OnDisable();
            /*0x29969fc*/ void OnTransformParentChanged();
            /*0x2996a4c*/ void ParentMaskStateChanged();
            /*0x2996a50*/ void OnCanvasHierarchyChanged();
            /*0x2996448*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x29967fc*/ void UpdateClipParent();
            /*0x2996ebc*/ void RecalculateClipping();
            /*0x2996ec0*/ void RecalculateMasking();
            /*0x2997048*/ UnityEngine.GameObject UnityEngine.UI.IClippable.get_gameObject();

            class CullStateChangedEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x2997000*/ CullStateChangedEvent();
            }
        }

        class MaskUtilities
        {
            static /*0x2997050*/ void Notify2DMaskStateChanged(UnityEngine.Component mask);
            static /*0x2995720*/ void NotifyStencilStateChanged(UnityEngine.Component mask);
            static /*0x2995e7c*/ UnityEngine.Transform FindRootSortOverrideCanvas(UnityEngine.Transform start);
            static /*0x299601c*/ int GetStencilDepth(UnityEngine.Transform transform, UnityEngine.Transform stopAfter);
            static /*0x29972ac*/ bool IsDescendantOrSelf(UnityEngine.Transform father, UnityEngine.Transform child);
            static /*0x2996aa0*/ UnityEngine.UI.RectMask2D GetRectMaskForClippable(UnityEngine.UI.IClippable clippable);
            static /*0x29973fc*/ void GetRectMasksForClip(UnityEngine.UI.RectMask2D clipper, System.Collections.Generic.List<UnityEngine.UI.RectMask2D> masks);
            /*0x2997760*/ MaskUtilities();
        }

        interface IMaterialModifier
        {
            UnityEngine.Material GetModifiedMaterial(UnityEngine.Material baseMaterial);
        }

        class Misc
        {
            static /*0x2997768*/ void Destroy(UnityEngine.Object obj);
            static /*0x2997868*/ void DestroyImmediate(UnityEngine.Object obj);
        }

        class MultipleDisplayUtilities
        {
            static /*0x2997910*/ bool GetRelativeMousePositionForDrag(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Vector2 position);
            static /*0x2997980*/ UnityEngine.Vector3 RelativeMouseAtScaled(UnityEngine.Vector2 position);
        }

        struct Navigation : System.IEquatable<UnityEngine.UI.Navigation>
        {
            /*0x10*/ UnityEngine.UI.Navigation.Mode m_Mode;
            /*0x14*/ bool m_WrapAround;
            /*0x18*/ UnityEngine.UI.Selectable m_SelectOnUp;
            /*0x20*/ UnityEngine.UI.Selectable m_SelectOnDown;
            /*0x28*/ UnityEngine.UI.Selectable m_SelectOnLeft;
            /*0x30*/ UnityEngine.UI.Selectable m_SelectOnRight;

            static /*0x2997e4c*/ UnityEngine.UI.Navigation get_defaultNavigation();
            /*0x2997de8*/ UnityEngine.UI.Navigation.Mode get_mode();
            /*0x2997df0*/ void set_mode(UnityEngine.UI.Navigation.Mode value);
            /*0x2997df8*/ bool get_wrapAround();
            /*0x2997e00*/ void set_wrapAround(bool value);
            /*0x2997e0c*/ UnityEngine.UI.Selectable get_selectOnUp();
            /*0x2997e14*/ void set_selectOnUp(UnityEngine.UI.Selectable value);
            /*0x2997e1c*/ UnityEngine.UI.Selectable get_selectOnDown();
            /*0x2997e24*/ void set_selectOnDown(UnityEngine.UI.Selectable value);
            /*0x2997e2c*/ UnityEngine.UI.Selectable get_selectOnLeft();
            /*0x2997e34*/ void set_selectOnLeft(UnityEngine.UI.Selectable value);
            /*0x2997e3c*/ UnityEngine.UI.Selectable get_selectOnRight();
            /*0x2997e44*/ void set_selectOnRight(UnityEngine.UI.Selectable value);
            /*0x2997e6c*/ bool Equals(UnityEngine.UI.Navigation other);

            enum Mode
            {
                None = 0,
                Horizontal = 1,
                Vertical = 2,
                Automatic = 3,
                Explicit = 4,
            }
        }

        class RawImage : UnityEngine.UI.MaskableGraphic
        {
            /*0xd0*/ UnityEngine.Texture m_Texture;
            /*0xd8*/ UnityEngine.Rect m_UVRect;

            /*0x2997f84*/ RawImage();
            /*0x2997fd4*/ UnityEngine.Texture get_mainTexture();
            /*0x299812c*/ UnityEngine.Texture get_texture();
            /*0x2998134*/ void set_texture(UnityEngine.Texture value);
            /*0x29981e0*/ UnityEngine.Rect get_uvRect();
            /*0x29981ec*/ void set_uvRect(UnityEngine.Rect value);
            /*0x299826c*/ void SetNativeSize();
            /*0x299854c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
            /*0x299962c*/ void OnDidApplyAnimationProperties();
        }

        class RectMask2D : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IClipper, UnityEngine.ICanvasRaycastFilter
        {
            /*0x18*/ UnityEngine.UI.RectangularVertexClipper m_VertexClipper;
            /*0x20*/ UnityEngine.RectTransform m_RectTransform;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.UI.MaskableGraphic> m_MaskableTargets;
            /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.UI.IClippable> m_ClipTargets;
            /*0x38*/ bool m_ShouldRecalculateClipRects;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.UI.RectMask2D> m_Clippers;
            /*0x48*/ UnityEngine.Rect m_LastClipRectCanvasSpace;
            /*0x58*/ bool m_ForceClip;
            /*0x5c*/ UnityEngine.Vector4 m_Padding;
            /*0x6c*/ UnityEngine.Vector2Int m_Softness;
            /*0x78*/ UnityEngine.Canvas m_Canvas;
            /*0x80*/ UnityEngine.Vector3[] m_Corners;

            /*0x29998a4*/ RectMask2D();
            /*0x2999668*/ UnityEngine.Vector4 get_padding();
            /*0x2999674*/ void set_padding(UnityEngine.Vector4 value);
            /*0x2999684*/ UnityEngine.Vector2Int get_softness();
            /*0x299968c*/ void set_softness(UnityEngine.Vector2Int value);
            /*0x29996a8*/ UnityEngine.Canvas get_Canvas();
            /*0x2999808*/ UnityEngine.Rect get_canvasRect();
            /*0x299984c*/ UnityEngine.RectTransform get_rectTransform();
            /*0x29999fc*/ void OnEnable();
            /*0x2999a30*/ void OnDisable();
            /*0x2999b00*/ void OnDestroy();
            /*0x2999b20*/ bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera);
            /*0x2999bfc*/ UnityEngine.Rect get_rootCanvasRect();
            /*0x2999d18*/ void PerformClipping();
            /*0x299a43c*/ void UpdateClipSoftness();
            /*0x299a730*/ void AddClippable(UnityEngine.UI.IClippable clippable);
            /*0x299a844*/ void RemoveClippable(UnityEngine.UI.IClippable clippable);
            /*0x299a9e4*/ void OnTransformParentChanged();
            /*0x299aa08*/ void OnCanvasHierarchyChanged();
        }

        class Scrollbar : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.RectTransform m_HandleRect;
            /*0x100*/ UnityEngine.UI.Scrollbar.Direction m_Direction;
            /*0x104*/ float m_Value;
            /*0x108*/ float m_Size;
            /*0x10c*/ int m_NumberOfSteps;
            /*0x110*/ UnityEngine.UI.Scrollbar.ScrollEvent m_OnValueChanged;
            /*0x118*/ UnityEngine.RectTransform m_ContainerRect;
            /*0x120*/ UnityEngine.Vector2 m_Offset;
            /*0x128*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x130*/ UnityEngine.Coroutine m_PointerDownRepeat;
            /*0x138*/ bool isPointerDownAndNotDragging;
            /*0x139*/ bool m_DelayedUpdateVisuals;

            /*0x299ada4*/ Scrollbar();
            /*0x299aa2c*/ UnityEngine.RectTransform get_handleRect();
            /*0x299aa34*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x299ad28*/ UnityEngine.UI.Scrollbar.Direction get_direction();
            /*0x299ad30*/ void set_direction(UnityEngine.UI.Scrollbar.Direction value);
            /*0x299afcc*/ float get_value();
            /*0x299b084*/ void set_value(float value);
            /*0x299b150*/ void SetValueWithoutNotify(float input);
            /*0x299b158*/ float get_size();
            /*0x299b160*/ void set_size(float value);
            /*0x299b1e4*/ int get_numberOfSteps();
            /*0x299b1ec*/ void set_numberOfSteps(int value);
            /*0x299b270*/ UnityEngine.UI.Scrollbar.ScrollEvent get_onValueChanged();
            /*0x299b278*/ void set_onValueChanged(UnityEngine.UI.Scrollbar.ScrollEvent value);
            /*0x299b280*/ float get_stepSize();
            /*0x299b2ac*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x299b2b0*/ void LayoutComplete();
            /*0x299b2b4*/ void GraphicUpdateComplete();
            /*0x299b2b8*/ void OnEnable();
            /*0x299b590*/ void OnDisable();
            /*0x299b6d8*/ void Update();
            /*0x299aab0*/ void UpdateCachedReferences();
            /*0x299b08c*/ void Set(float input, bool sendCallback);
            /*0x299b6ec*/ void OnRectTransformDimensionsChange();
            /*0x299b724*/ UnityEngine.UI.Scrollbar.Axis get_axis();
            /*0x299b734*/ bool get_reverseValue();
            /*0x299ab90*/ void UpdateVisuals();
            /*0x299b748*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299b9ac*/ void DoUpdateDrag(UnityEngine.Vector2 handleCorner, float remainingSize);
            /*0x299ba10*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299ba74*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299bc30*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299bcc0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299befc*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299be70*/ System.Collections.IEnumerator ClickRepeat(UnityEngine.Vector2 screenPosition, UnityEngine.Camera camera);
            /*0x299bf64*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299bfa4*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x299c2f4*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x299c3f0*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x299c4ec*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x299c5e8*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x299c6e4*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299c6fc*/ void SetDirection(UnityEngine.UI.Scrollbar.Direction direction, bool includeRectLayouts);
            /*0x299c874*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class ScrollEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x299ae6c*/ ScrollEvent();
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }

            class <ClickRepeat>d__58 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ UnityEngine.UI.Scrollbar <>4__this;
                /*0x28*/ UnityEngine.Vector2 screenPosition;
                /*0x30*/ UnityEngine.Camera camera;

                /*0x299bf3c*/ <ClickRepeat>d__58(int <>1__state);
                /*0x299c87c*/ void System.IDisposable.Dispose();
                /*0x299c880*/ bool MoveNext();
                /*0x299caf4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x299cafc*/ void System.Collections.IEnumerator.Reset();
                /*0x299cb3c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class ScrollRect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.UI.ICanvasElement, UnityEngine.UI.ILayoutElement, UnityEngine.UI.ILayoutGroup, UnityEngine.UI.ILayoutController
        {
            /*0x18*/ UnityEngine.RectTransform m_Content;
            /*0x20*/ bool m_Horizontal;
            /*0x21*/ bool m_Vertical;
            /*0x24*/ UnityEngine.UI.ScrollRect.MovementType m_MovementType;
            /*0x28*/ float m_Elasticity;
            /*0x2c*/ bool m_Inertia;
            /*0x30*/ float m_DecelerationRate;
            /*0x34*/ float m_ScrollSensitivity;
            /*0x38*/ UnityEngine.RectTransform m_Viewport;
            /*0x40*/ UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
            /*0x48*/ UnityEngine.UI.Scrollbar m_VerticalScrollbar;
            /*0x50*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;
            /*0x54*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;
            /*0x58*/ float m_HorizontalScrollbarSpacing;
            /*0x5c*/ float m_VerticalScrollbarSpacing;
            /*0x60*/ UnityEngine.UI.ScrollRect.ScrollRectEvent m_OnValueChanged;
            /*0x68*/ UnityEngine.Vector2 m_PointerStartLocalCursor;
            /*0x70*/ UnityEngine.Vector2 m_ContentStartPosition;
            /*0x78*/ UnityEngine.RectTransform m_ViewRect;
            /*0x80*/ UnityEngine.Bounds m_ContentBounds;
            /*0x98*/ UnityEngine.Bounds m_ViewBounds;
            /*0xb0*/ UnityEngine.Vector2 m_Velocity;
            /*0xb8*/ bool m_Dragging;
            /*0xb9*/ bool m_Scrolling;
            /*0xbc*/ UnityEngine.Vector2 m_PrevPosition;
            /*0xc4*/ UnityEngine.Bounds m_PrevContentBounds;
            /*0xdc*/ UnityEngine.Bounds m_PrevViewBounds;
            /*0xf4*/ bool m_HasRebuiltLayout;
            /*0xf5*/ bool m_HSliderExpand;
            /*0xf6*/ bool m_VSliderExpand;
            /*0xf8*/ float m_HSliderHeight;
            /*0xfc*/ float m_VSliderWidth;
            /*0x100*/ UnityEngine.RectTransform m_Rect;
            /*0x108*/ UnityEngine.RectTransform m_HorizontalScrollbarRect;
            /*0x110*/ UnityEngine.RectTransform m_VerticalScrollbarRect;
            /*0x118*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x120*/ UnityEngine.Vector3[] m_Corners;

            static /*0x299e94c*/ float RubberDelta(float overStretching, float viewSize);
            static /*0x29a0108*/ void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, UnityEngine.UI.ScrollRect.ScrollbarVisibility scrollbarVisibility, UnityEngine.UI.Scrollbar scrollbar);
            static /*0x29a01fc*/ void AdjustBounds(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Vector2 contentPivot, ref UnityEngine.Vector3 contentSize, ref UnityEngine.Vector3 contentPos);
            static /*0x29a02a8*/ UnityEngine.Bounds InternalGetBounds(UnityEngine.Vector3[] corners, ref UnityEngine.Matrix4x4 viewWorldToLocalMatrix);
            static /*0x29a0400*/ UnityEngine.Vector2 InternalCalculateOffset(ref UnityEngine.Bounds viewBounds, ref UnityEngine.Bounds contentBounds, bool horizontal, bool vertical, UnityEngine.UI.ScrollRect.MovementType movementType, ref UnityEngine.Vector2 delta);
            /*0x299d1f8*/ ScrollRect();
            /*0x299cb44*/ UnityEngine.RectTransform get_content();
            /*0x299cb4c*/ void set_content(UnityEngine.RectTransform value);
            /*0x299cb54*/ bool get_horizontal();
            /*0x299cb5c*/ void set_horizontal(bool value);
            /*0x299cb68*/ bool get_vertical();
            /*0x299cb70*/ void set_vertical(bool value);
            /*0x299cb7c*/ UnityEngine.UI.ScrollRect.MovementType get_movementType();
            /*0x299cb84*/ void set_movementType(UnityEngine.UI.ScrollRect.MovementType value);
            /*0x299cb8c*/ float get_elasticity();
            /*0x299cb94*/ void set_elasticity(float value);
            /*0x299cb9c*/ bool get_inertia();
            /*0x299cba4*/ void set_inertia(bool value);
            /*0x299cbb0*/ float get_decelerationRate();
            /*0x299cbb8*/ void set_decelerationRate(float value);
            /*0x299cbc0*/ float get_scrollSensitivity();
            /*0x299cbc8*/ void set_scrollSensitivity(float value);
            /*0x299cbd0*/ UnityEngine.RectTransform get_viewport();
            /*0x299cbd8*/ void set_viewport(UnityEngine.RectTransform value);
            /*0x299cc94*/ UnityEngine.UI.Scrollbar get_horizontalScrollbar();
            /*0x299cc9c*/ void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x299ce10*/ UnityEngine.UI.Scrollbar get_verticalScrollbar();
            /*0x299ce18*/ void set_verticalScrollbar(UnityEngine.UI.Scrollbar value);
            /*0x299cf8c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility();
            /*0x299cf94*/ void set_horizontalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x299cf9c*/ UnityEngine.UI.ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility();
            /*0x299cfa4*/ void set_verticalScrollbarVisibility(UnityEngine.UI.ScrollRect.ScrollbarVisibility value);
            /*0x299cfac*/ float get_horizontalScrollbarSpacing();
            /*0x299cfb4*/ void set_horizontalScrollbarSpacing(float value);
            /*0x299d044*/ float get_verticalScrollbarSpacing();
            /*0x299d04c*/ void set_verticalScrollbarSpacing(float value);
            /*0x299d054*/ UnityEngine.UI.ScrollRect.ScrollRectEvent get_onValueChanged();
            /*0x299d05c*/ void set_onValueChanged(UnityEngine.UI.ScrollRect.ScrollRectEvent value);
            /*0x299d064*/ UnityEngine.RectTransform get_viewRect();
            /*0x299d154*/ UnityEngine.Vector2 get_velocity();
            /*0x299d15c*/ void set_velocity(UnityEngine.Vector2 value);
            /*0x299d164*/ UnityEngine.RectTransform get_rectTransform();
            /*0x299d344*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x299deac*/ void LayoutComplete();
            /*0x299deb0*/ void GraphicUpdateComplete();
            /*0x299d3cc*/ void UpdateCachedData();
            /*0x299deb4*/ void OnEnable();
            /*0x299e060*/ void OnDisable();
            /*0x299e290*/ bool IsActive();
            /*0x299e310*/ void EnsureLayoutHasRebuilt();
            /*0x299e384*/ void StopMovement();
            /*0x299e3d4*/ void OnScroll(UnityEngine.EventSystems.PointerEventData data);
            /*0x299e57c*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299e5dc*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299e708*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299e728*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299e988*/ void SetContentAnchoredPosition(UnityEngine.Vector2 position);
            /*0x299ea3c*/ void LateUpdate();
            /*0x299ddd0*/ void UpdatePrevData();
            /*0x299dbf8*/ void UpdateScrollbars(UnityEngine.Vector2 offset);
            /*0x299efd0*/ UnityEngine.Vector2 get_normalizedPosition();
            /*0x299f2f8*/ void set_normalizedPosition(UnityEngine.Vector2 value);
            /*0x299f040*/ float get_horizontalNormalizedPosition();
            /*0x299f340*/ void set_horizontalNormalizedPosition(float value);
            /*0x299f19c*/ float get_verticalNormalizedPosition();
            /*0x299f354*/ void set_verticalNormalizedPosition(float value);
            /*0x299f368*/ void SetHorizontalNormalizedPosition(float value);
            /*0x299f37c*/ void SetVerticalNormalizedPosition(float value);
            /*0x299f390*/ void SetNormalizedPosition(float value, int axis);
            /*0x299f688*/ void OnRectTransformDimensionsChange();
            /*0x299f68c*/ bool get_hScrollingNeeded();
            /*0x299f6e8*/ bool get_vScrollingNeeded();
            /*0x299f744*/ void CalculateLayoutInputHorizontal();
            /*0x299f748*/ void CalculateLayoutInputVertical();
            /*0x299f74c*/ float get_minWidth();
            /*0x299f754*/ float get_preferredWidth();
            /*0x299f75c*/ float get_flexibleWidth();
            /*0x299f764*/ float get_minHeight();
            /*0x299f76c*/ float get_preferredHeight();
            /*0x299f774*/ float get_flexibleHeight();
            /*0x299f77c*/ int get_layoutPriority();
            /*0x299f784*/ void SetLayoutHorizontal();
            /*0x299fdd8*/ void SetLayoutVertical();
            /*0x299f000*/ void UpdateScrollbarVisibility();
            /*0x299feb4*/ void UpdateScrollbarLayout();
            /*0x299d744*/ void UpdateBounds();
            /*0x299fcdc*/ UnityEngine.Bounds GetBounds();
            /*0x299e54c*/ UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta);
            /*0x299cfbc*/ void SetDirty();
            /*0x299cbe0*/ void SetDirtyCaching();
            /*0x29a0584*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum MovementType
            {
                Unrestricted = 0,
                Elastic = 1,
                Clamped = 2,
            }

            enum ScrollbarVisibility
            {
                Permanent = 0,
                AutoHide = 1,
                AutoHideAndExpandViewport = 2,
            }

            class ScrollRectEvent : UnityEngine.Events.UnityEvent<UnityEngine.Vector2>
            {
                /*0x299d2fc*/ ScrollRectEvent();
            }
        }

        class Selectable : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler
        {
            static /*0x0*/ UnityEngine.UI.Selectable[] s_Selectables;
            static /*0x8*/ int s_SelectableCount;
            /*0x18*/ bool m_EnableCalled;
            /*0x20*/ UnityEngine.UI.Navigation m_Navigation;
            /*0x48*/ UnityEngine.UI.Selectable.Transition m_Transition;
            /*0x4c*/ UnityEngine.UI.ColorBlock m_Colors;
            /*0xa8*/ UnityEngine.UI.SpriteState m_SpriteState;
            /*0xc8*/ UnityEngine.UI.AnimationTriggers m_AnimationTriggers;
            /*0xd0*/ bool m_Interactable;
            /*0xd8*/ UnityEngine.UI.Graphic m_TargetGraphic;
            /*0xe0*/ bool m_GroupsAllowInteraction;
            /*0xe4*/ int m_CurrentIndex;
            /*0xe8*/ bool <isPointerInside>k__BackingField;
            /*0xe9*/ bool <isPointerDown>k__BackingField;
            /*0xea*/ bool <hasSelection>k__BackingField;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.CanvasGroup> m_CanvasGroupCache;

            static /*0x29a1fdc*/ Selectable();
            static /*0x29a058c*/ UnityEngine.UI.Selectable[] get_allSelectablesArray();
            static /*0x29a0628*/ int get_allSelectableCount();
            static /*0x29a0680*/ System.Collections.Generic.List<UnityEngine.UI.Selectable> get_allSelectables();
            static /*0x29a0724*/ int AllSelectablesNoAlloc(UnityEngine.UI.Selectable[] selectables);
            static /*0x29a1b60*/ UnityEngine.Vector3 GetPointOnRectEdge(UnityEngine.RectTransform rect, UnityEngine.Vector2 dir);
            /*0x299aeb4*/ Selectable();
            /*0x29a07e0*/ UnityEngine.UI.Navigation get_navigation();
            /*0x29a07f4*/ void set_navigation(UnityEngine.UI.Navigation value);
            /*0x29a08e0*/ UnityEngine.UI.Selectable.Transition get_transition();
            /*0x29a08e8*/ void set_transition(UnityEngine.UI.Selectable.Transition value);
            /*0x29a095c*/ UnityEngine.UI.ColorBlock get_colors();
            /*0x29a096c*/ void set_colors(UnityEngine.UI.ColorBlock value);
            /*0x29a0a04*/ UnityEngine.UI.SpriteState get_spriteState();
            /*0x29a0a14*/ void set_spriteState(UnityEngine.UI.SpriteState value);
            /*0x29a0a90*/ UnityEngine.UI.AnimationTriggers get_animationTriggers();
            /*0x29a0a98*/ void set_animationTriggers(UnityEngine.UI.AnimationTriggers value);
            /*0x29a0b0c*/ UnityEngine.UI.Graphic get_targetGraphic();
            /*0x29a0b14*/ void set_targetGraphic(UnityEngine.UI.Graphic value);
            /*0x29a0b88*/ bool get_interactable();
            /*0x29a0b90*/ void set_interactable(bool value);
            /*0x29a0d00*/ bool get_isPointerInside();
            /*0x29a0d08*/ void set_isPointerInside(bool value);
            /*0x29a0d14*/ bool get_isPointerDown();
            /*0x29a0d1c*/ void set_isPointerDown(bool value);
            /*0x29a0d28*/ bool get_hasSelection();
            /*0x29a0d30*/ void set_hasSelection(bool value);
            /*0x29a0d3c*/ UnityEngine.UI.Image get_image();
            /*0x29a0db8*/ void set_image(UnityEngine.UI.Image value);
            /*0x29a0dc0*/ UnityEngine.Animator get_animator();
            /*0x29a0e08*/ void Awake();
            /*0x29a0e94*/ void OnCanvasGroupChanged();
            /*0x29a1054*/ bool IsInteractable();
            /*0x29a1074*/ void OnDidApplyAnimationProperties();
            /*0x299b2e8*/ void OnEnable();
            /*0x29a10c8*/ void OnTransformParentChanged();
            /*0x29a087c*/ void OnSetProperty();
            /*0x299b5b0*/ void OnDisable();
            /*0x29a10f0*/ void OnApplicationFocus(bool hasFocus);
            /*0x29a1078*/ UnityEngine.UI.Selectable.SelectionState get_currentSelectionState();
            /*0x29a1198*/ void InstantClearState();
            /*0x29a1520*/ void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant);
            /*0x29a16b4*/ UnityEngine.UI.Selectable FindSelectable(UnityEngine.Vector3 dir);
            /*0x29a1d04*/ void Navigate(UnityEngine.EventSystems.AxisEventData eventData, UnityEngine.UI.Selectable sel);
            /*0x299c318*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x299c414*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x299c510*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x299c60c*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x299c268*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x29a1208*/ void StartColorTween(UnityEngine.Color targetColor, bool instant);
            /*0x29a12f0*/ void DoSpriteSwap(UnityEngine.Sprite newSprite);
            /*0x29a1398*/ void TriggerAnimation(string triggername);
            /*0x29a1dbc*/ bool IsHighlighted();
            /*0x29a114c*/ bool IsPressed();
            /*0x29a1e18*/ void EvaluateAndTransitionToSelectionState();
            /*0x299bd40*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x299bf7c*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a1eb0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a1ebc*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a1ec4*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29a1ed0*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29a1ed8*/ void Select();

            enum Transition
            {
                None = 0,
                ColorTint = 1,
                SpriteSwap = 2,
                Animation = 3,
            }

            enum SelectionState
            {
                Normal = 0,
                Highlighted = 1,
                Pressed = 2,
                Selected = 3,
                Disabled = 4,
            }
        }

        class SetPropertyUtility
        {
            static /*0x29a2050*/ bool SetColor(ref UnityEngine.Color currentValue, UnityEngine.Color newValue);
            static bool SetStruct<T>(ref T currentValue, T newValue);
            static bool SetClass<T>(ref T currentValue, T newValue);
        }

        class Slider : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.RectTransform m_FillRect;
            /*0x100*/ UnityEngine.RectTransform m_HandleRect;
            /*0x108*/ UnityEngine.UI.Slider.Direction m_Direction;
            /*0x10c*/ float m_MinValue;
            /*0x110*/ float m_MaxValue;
            /*0x114*/ bool m_WholeNumbers;
            /*0x118*/ float m_Value;
            /*0x120*/ UnityEngine.UI.Slider.SliderEvent m_OnValueChanged;
            /*0x128*/ UnityEngine.UI.Image m_FillImage;
            /*0x130*/ UnityEngine.Transform m_FillTransform;
            /*0x138*/ UnityEngine.RectTransform m_FillContainerRect;
            /*0x140*/ UnityEngine.Transform m_HandleTransform;
            /*0x148*/ UnityEngine.RectTransform m_HandleContainerRect;
            /*0x150*/ UnityEngine.Vector2 m_Offset;
            /*0x158*/ UnityEngine.DrivenRectTransformTracker m_Tracker;
            /*0x159*/ bool m_DelayedUpdateVisuals;

            /*0x29a2b90*/ Slider();
            /*0x29a2098*/ UnityEngine.RectTransform get_fillRect();
            /*0x29a20a0*/ void set_fillRect(UnityEngine.RectTransform value);
            /*0x29a26a8*/ UnityEngine.RectTransform get_handleRect();
            /*0x29a26b0*/ void set_handleRect(UnityEngine.RectTransform value);
            /*0x29a272c*/ UnityEngine.UI.Slider.Direction get_direction();
            /*0x29a2734*/ void set_direction(UnityEngine.UI.Slider.Direction value);
            /*0x29a27a8*/ float get_minValue();
            /*0x29a27b0*/ void set_minValue(float value);
            /*0x29a2840*/ float get_maxValue();
            /*0x29a2848*/ void set_maxValue(float value);
            /*0x29a28d8*/ bool get_wholeNumbers();
            /*0x29a28e0*/ void set_wholeNumbers(bool value);
            /*0x29a2970*/ float get_value();
            /*0x29a2a10*/ void set_value(float value);
            /*0x29a2a24*/ void SetValueWithoutNotify(float input);
            /*0x29a2a38*/ float get_normalizedValue();
            /*0x29a2b1c*/ void set_normalizedValue(float value);
            /*0x29a2b54*/ UnityEngine.UI.Slider.SliderEvent get_onValueChanged();
            /*0x29a2b5c*/ void set_onValueChanged(UnityEngine.UI.Slider.SliderEvent value);
            /*0x29a2b64*/ float get_stepSize();
            /*0x29a2c9c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x29a2ca0*/ void LayoutComplete();
            /*0x29a2ca4*/ void GraphicUpdateComplete();
            /*0x29a2ca8*/ void OnEnable();
            /*0x29a2ce4*/ void OnDisable();
            /*0x29a2d04*/ void Update();
            /*0x29a2d44*/ void OnDidApplyAnimationProperties();
            /*0x29a211c*/ void UpdateCachedReferences();
            /*0x29a2f34*/ float ClampValue(float input);
            /*0x29a300c*/ void Set(float input, bool sendCallback);
            /*0x29a30d0*/ void OnRectTransformDimensionsChange();
            /*0x29a2ffc*/ UnityEngine.UI.Slider.Axis get_axis();
            /*0x29a2fe8*/ bool get_reverseValue();
            /*0x29a23c0*/ void UpdateVisuals();
            /*0x29a3108*/ void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam);
            /*0x29a3340*/ bool MayDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a33a4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a355c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a35ac*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x29a37f8*/ UnityEngine.UI.Selectable FindSelectableOnLeft();
            /*0x29a381c*/ UnityEngine.UI.Selectable FindSelectableOnRight();
            /*0x29a3840*/ UnityEngine.UI.Selectable FindSelectableOnUp();
            /*0x29a3864*/ UnityEngine.UI.Selectable FindSelectableOnDown();
            /*0x29a3888*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a38a0*/ void SetDirection(UnityEngine.UI.Slider.Direction direction, bool includeRectLayouts);
            /*0x29a3a18*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum Direction
            {
                LeftToRight = 0,
                RightToLeft = 1,
                BottomToTop = 2,
                TopToBottom = 3,
            }

            class SliderEvent : UnityEngine.Events.UnityEvent<float>
            {
                /*0x29a2c54*/ SliderEvent();
            }

            enum Axis
            {
                Horizontal = 0,
                Vertical = 1,
            }
        }

        struct SpriteState : System.IEquatable<UnityEngine.UI.SpriteState>
        {
            /*0x10*/ UnityEngine.Sprite m_HighlightedSprite;
            /*0x18*/ UnityEngine.Sprite m_PressedSprite;
            /*0x20*/ UnityEngine.Sprite m_SelectedSprite;
            /*0x28*/ UnityEngine.Sprite m_DisabledSprite;

            /*0x29a3a20*/ UnityEngine.Sprite get_highlightedSprite();
            /*0x29a3a28*/ void set_highlightedSprite(UnityEngine.Sprite value);
            /*0x29a3a30*/ UnityEngine.Sprite get_pressedSprite();
            /*0x29a3a38*/ void set_pressedSprite(UnityEngine.Sprite value);
            /*0x29a3a40*/ UnityEngine.Sprite get_selectedSprite();
            /*0x29a3a48*/ void set_selectedSprite(UnityEngine.Sprite value);
            /*0x29a3a50*/ UnityEngine.Sprite get_disabledSprite();
            /*0x29a3a58*/ void set_disabledSprite(UnityEngine.Sprite value);
            /*0x29a3a60*/ bool Equals(UnityEngine.UI.SpriteState other);
        }

        class StencilMaterial
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.UI.StencilMaterial.MatEntry> m_List;

            static /*0x29a4878*/ StencilMaterial();
            static /*0x29a3b68*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID);
            static /*0x29a3b70*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask);
            static /*0x29a4514*/ void LogWarningWhenNotInBatchmode(string warning, UnityEngine.Object context);
            static /*0x29a3bfc*/ UnityEngine.Material Add(UnityEngine.Material baseMat, int stencilID, UnityEngine.Rendering.StencilOp operation, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.ColorWriteMask colorWriteMask, int readMask, int writeMask);
            static /*0x29a459c*/ void Remove(UnityEngine.Material customMat);
            static /*0x29a475c*/ void ClearAll();

            class MatEntry
            {
                /*0x10*/ UnityEngine.Material baseMat;
                /*0x18*/ UnityEngine.Material customMat;
                /*0x20*/ int count;
                /*0x24*/ int stencilId;
                /*0x28*/ UnityEngine.Rendering.StencilOp operation;
                /*0x2c*/ UnityEngine.Rendering.CompareFunction compareFunction;
                /*0x30*/ int readMask;
                /*0x34*/ int writeMask;
                /*0x38*/ bool useAlphaClip;
                /*0x3c*/ UnityEngine.Rendering.ColorWriteMask colorMask;

                /*0x29a458c*/ MatEntry();
            }
        }

        class Text : UnityEngine.UI.MaskableGraphic, UnityEngine.UI.ILayoutElement
        {
            static /*0x0*/ UnityEngine.Material s_DefaultText;
            /*0xd0*/ UnityEngine.UI.FontData m_FontData;
            /*0xd8*/ string m_Text;
            /*0xe0*/ UnityEngine.TextGenerator m_TextCache;
            /*0xe8*/ UnityEngine.TextGenerator m_TextCacheForLayout;
            /*0xf0*/ bool m_DisableFontTextureRebuiltCallback;
            /*0xf8*/ UnityEngine.UIVertex[] m_TempVerts;

            static /*0x29a59f0*/ UnityEngine.Vector2 GetTextAnchorPivot(UnityEngine.TextAnchor anchor);
            /*0x29a4904*/ Text();
            /*0x29a499c*/ UnityEngine.TextGenerator get_cachedTextGenerator();
            /*0x29a4a34*/ UnityEngine.TextGenerator get_cachedTextGeneratorForLayout();
            /*0x29a4aa0*/ UnityEngine.Texture get_mainTexture();
            /*0x29a4c64*/ void FontTextureChanged();
            /*0x29a4c48*/ UnityEngine.Font get_font();
            /*0x29a4d70*/ void set_font(UnityEngine.Font value);
            /*0x29a4e7c*/ string get_text();
            /*0x29a4e84*/ void set_text(string value);
            /*0x29a4f4c*/ bool get_supportRichText();
            /*0x29a4f68*/ void set_supportRichText(bool value);
            /*0x29a4fc8*/ bool get_resizeTextForBestFit();
            /*0x29a4fe4*/ void set_resizeTextForBestFit(bool value);
            /*0x29a5044*/ int get_resizeTextMinSize();
            /*0x29a5060*/ void set_resizeTextMinSize(int value);
            /*0x29a50b4*/ int get_resizeTextMaxSize();
            /*0x29a50d0*/ void set_resizeTextMaxSize(int value);
            /*0x29a5124*/ UnityEngine.TextAnchor get_alignment();
            /*0x29a5140*/ void set_alignment(UnityEngine.TextAnchor value);
            /*0x29a5194*/ bool get_alignByGeometry();
            /*0x29a51b0*/ void set_alignByGeometry(bool value);
            /*0x29a51f8*/ int get_fontSize();
            /*0x29a5214*/ void set_fontSize(int value);
            /*0x29a5268*/ UnityEngine.HorizontalWrapMode get_horizontalOverflow();
            /*0x29a5284*/ void set_horizontalOverflow(UnityEngine.HorizontalWrapMode value);
            /*0x29a52d8*/ UnityEngine.VerticalWrapMode get_verticalOverflow();
            /*0x29a52f4*/ void set_verticalOverflow(UnityEngine.VerticalWrapMode value);
            /*0x29a5348*/ float get_lineSpacing();
            /*0x29a5364*/ void set_lineSpacing(float value);
            /*0x29a53b8*/ UnityEngine.FontStyle get_fontStyle();
            /*0x29a53d4*/ void set_fontStyle(UnityEngine.FontStyle value);
            /*0x29a5428*/ float get_pixelsPerUnit();
            /*0x29a5570*/ void OnEnable();
            /*0x29a55ec*/ void OnDisable();
            /*0x29a5650*/ void UpdateGeometry();
            /*0x29a56d8*/ void AssignDefaultFont();
            /*0x29a5748*/ void AssignDefaultFontIfNecessary();
            /*0x29a5804*/ UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.Vector2 extents);
            /*0x29a5a5c*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill);
            /*0x29a615c*/ void CalculateLayoutInputHorizontal();
            /*0x29a6160*/ void CalculateLayoutInputVertical();
            /*0x29a6164*/ float get_minWidth();
            /*0x29a616c*/ float get_preferredWidth();
            /*0x29a6248*/ float get_flexibleWidth();
            /*0x29a6250*/ float get_minHeight();
            /*0x29a6258*/ float get_preferredHeight();
            /*0x29a6320*/ float get_flexibleHeight();
            /*0x29a6328*/ int get_layoutPriority();
        }

        class Toggle : UnityEngine.UI.Selectable, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.UI.ICanvasElement
        {
            /*0xf8*/ UnityEngine.UI.Toggle.ToggleTransition toggleTransition;
            /*0x100*/ UnityEngine.UI.Graphic graphic;
            /*0x108*/ UnityEngine.UI.ToggleGroup m_Group;
            /*0x110*/ UnityEngine.UI.Toggle.ToggleEvent onValueChanged;
            /*0x118*/ bool m_IsOn;

            /*0x29a6558*/ Toggle();
            /*0x29a6330*/ UnityEngine.UI.ToggleGroup get_group();
            /*0x29a6338*/ void set_group(UnityEngine.UI.ToggleGroup value);
            /*0x29a662c*/ void Rebuild(UnityEngine.UI.CanvasUpdate executing);
            /*0x29a6630*/ void LayoutComplete();
            /*0x29a6634*/ void GraphicUpdateComplete();
            /*0x29a6638*/ void OnDestroy();
            /*0x29a6aa4*/ void OnEnable();
            /*0x29a6ad0*/ void OnDisable();
            /*0x29a6af0*/ void OnDidApplyAnimationProperties();
            /*0x29a6358*/ void SetToggleGroup(UnityEngine.UI.ToggleGroup newGroup, bool setMemberValue);
            /*0x29a6ff8*/ bool get_isOn();
            /*0x29a7000*/ void set_isOn(bool value);
            /*0x29a700c*/ void SetIsOnWithoutNotify(bool value);
            /*0x29a6c14*/ void Set(bool value, bool sendCallback);
            /*0x29a6494*/ void PlayEffect(bool instant);
            /*0x29a7154*/ void Start();
            /*0x29a715c*/ void InternalToggle();
            /*0x29a71b0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29a71d4*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29a71d8*/ UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform();

            enum ToggleTransition
            {
                None = 0,
                Fade = 1,
            }

            class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
            {
                /*0x29a65e4*/ ToggleEvent();
            }
        }

        class ToggleGroup : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ bool m_AllowSwitchOff;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.Toggle> m_Toggles;

            /*0x29a71f4*/ ToggleGroup();
            /*0x29a71e0*/ bool get_allowSwitchOff();
            /*0x29a71e8*/ void set_allowSwitchOff(bool value);
            /*0x29a7270*/ void Start();
            /*0x29a728c*/ void OnEnable();
            /*0x29a72a8*/ void ValidateToggleIsInGroup(UnityEngine.UI.Toggle toggle);
            /*0x29a6eec*/ void NotifyToggleOn(UnityEngine.UI.Toggle toggle, bool sendCallback);
            /*0x29a6d88*/ void UnregisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x29a6e18*/ void RegisterToggle(UnityEngine.UI.Toggle toggle);
            /*0x29a66b8*/ void EnsureValidState();
            /*0x29a7018*/ bool AnyTogglesOn();
            /*0x29a7400*/ System.Collections.Generic.IEnumerable<UnityEngine.UI.Toggle> ActiveToggles();
            /*0x29a74fc*/ UnityEngine.UI.Toggle GetFirstActiveToggle();
            /*0x29a7584*/ void SetAllTogglesOff(bool sendCallback);

            class <>c
            {
                static /*0x0*/ UnityEngine.UI.ToggleGroup.<> <>9;
                static /*0x8*/ System.Predicate<UnityEngine.UI.Toggle> <>9__13_0;
                static /*0x10*/ System.Func<UnityEngine.UI.Toggle, bool> <>9__14_0;

                static /*0x29a7674*/ <>c();
                /*0x29a76d8*/ <>c();
                /*0x29a76e0*/ bool <AnyTogglesOn>b__13_0(UnityEngine.UI.Toggle x);
                /*0x29a76f8*/ bool <ActiveToggles>b__14_0(UnityEngine.UI.Toggle x);
            }
        }

        class ReflectionMethodsCache
        {
            static /*0x0*/ UnityEngine.UI.ReflectionMethodsCache s_ReflectionMethodsCache;
            /*0x10*/ UnityEngine.UI.ReflectionMethodsCache.Raycast3DCallback raycast3D;
            /*0x18*/ UnityEngine.UI.ReflectionMethodsCache.RaycastAllCallback raycast3DAll;
            /*0x20*/ UnityEngine.UI.ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc;
            /*0x28*/ UnityEngine.UI.ReflectionMethodsCache.Raycast2DCallback raycast2D;
            /*0x30*/ UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll;
            /*0x38*/ UnityEngine.UI.ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc;

            static /*0x29a8324*/ UnityEngine.UI.ReflectionMethodsCache get_Singleton();
            /*0x29a7710*/ ReflectionMethodsCache();

            class Raycast3DCallback : System.MulticastDelegate
            {
                /*0x29a83a0*/ Raycast3DCallback(object object, nint method);
                /*0x29a8464*/ bool Invoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i);
                /*0x29a84a4*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, ref UnityEngine.RaycastHit hit, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a85c4*/ bool EndInvoke(ref UnityEngine.RaycastHit hit, System.IAsyncResult result);
            }

            class RaycastAllCallback : System.MulticastDelegate
            {
                /*0x29a85f0*/ RaycastAllCallback(object object, nint method);
                /*0x29a86b4*/ UnityEngine.RaycastHit[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x29a86f0*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a87dc*/ UnityEngine.RaycastHit[] EndInvoke(System.IAsyncResult result);
            }

            class GetRaycastNonAllocCallback : System.MulticastDelegate
            {
                /*0x29a87e8*/ GetRaycastNonAllocCallback(object object, nint method);
                /*0x29a88ac*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i);
                /*0x29a88e8*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a89d8*/ int EndInvoke(System.IAsyncResult result);
            }

            class Raycast2DCallback : System.MulticastDelegate
            {
                /*0x29a8a00*/ Raycast2DCallback(object object, nint method);
                /*0x29a8ac4*/ UnityEngine.RaycastHit2D Invoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i);
                /*0x29a8ad8*/ System.IAsyncResult BeginInvoke(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a8bd4*/ UnityEngine.RaycastHit2D EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllCallback : System.MulticastDelegate
            {
                /*0x29a8c0c*/ GetRayIntersectionAllCallback(object object, nint method);
                /*0x29a8cd0*/ UnityEngine.RaycastHit2D[] Invoke(UnityEngine.Ray r, float f, int i);
                /*0x29a8d0c*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a8df8*/ UnityEngine.RaycastHit2D[] EndInvoke(System.IAsyncResult result);
            }

            class GetRayIntersectionAllNonAllocCallback : System.MulticastDelegate
            {
                /*0x29a8e04*/ GetRayIntersectionAllNonAllocCallback(object object, nint method);
                /*0x29a8ec8*/ int Invoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i);
                /*0x29a8f04*/ System.IAsyncResult BeginInvoke(UnityEngine.Ray r, UnityEngine.RaycastHit2D[] results, float f, int i, System.AsyncCallback callback, object object);
                /*0x29a8ff4*/ int EndInvoke(System.IAsyncResult result);
            }
        }

        class VertexHelper : System.IDisposable
        {
            static /*0x0*/ UnityEngine.Vector4 s_DefaultTangent;
            static /*0x10*/ UnityEngine.Vector3 s_DefaultNormal;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Vector3> m_Positions;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Color32> m_Colors;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv0S;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv1S;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv2S;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Uv3S;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Vector3> m_Normals;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector4> m_Tangents;
            /*0x50*/ System.Collections.Generic.List<int> m_Indices;
            /*0x58*/ bool m_ListsInitalized;

            static /*0x29aa244*/ VertexHelper();
            /*0x29a901c*/ VertexHelper();
            /*0x29a9024*/ VertexHelper(UnityEngine.Mesh m);
            /*0x29a925c*/ void InitializeListIfRequired();
            /*0x29a93ec*/ void Dispose();
            /*0x2999264*/ void Clear();
            /*0x29a95a0*/ int get_currentVertCount();
            /*0x29a95ec*/ int get_currentIndexCount();
            /*0x29a9638*/ void PopulateUIVertex(ref UnityEngine.UIVertex vertex, int i);
            /*0x29a9798*/ void SetUIVertex(UnityEngine.UIVertex vertex, int i);
            /*0x29a98f4*/ void FillMesh(UnityEngine.Mesh mesh);
            /*0x29a9a58*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector4 uv2, UnityEngine.Vector4 uv3, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x29a9f54*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0, UnityEngine.Vector4 uv1, UnityEngine.Vector3 normal, UnityEngine.Vector4 tangent);
            /*0x2999380*/ void AddVert(UnityEngine.Vector3 position, UnityEngine.Color32 color, UnityEngine.Vector4 uv0);
            /*0x29aa064*/ void AddVert(UnityEngine.UIVertex v);
            /*0x29994b0*/ void AddTriangle(int idx0, int idx1, int idx2);
            /*0x29a604c*/ void AddUIVertexQuad(UnityEngine.UIVertex[] verts);
            /*0x29aa0f8*/ void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<int> indices);
            /*0x29aa1a4*/ void AddUIVertexTriangleStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
            /*0x29aa1f4*/ void GetUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> stream);
        }

        class BaseVertexEffect
        {
            /*0x29aa2dc*/ BaseVertexEffect();
            void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices);
        }

        class BaseMeshEffect : UnityEngine.EventSystems.UIBehaviour, UnityEngine.UI.IMeshModifier
        {
            /*0x18*/ UnityEngine.UI.Graphic m_Graphic;

            /*0x29aa700*/ BaseMeshEffect();
            /*0x29aa2e4*/ UnityEngine.UI.Graphic get_graphic();
            /*0x29aa378*/ void OnEnable();
            /*0x29aa420*/ void OnDisable();
            /*0x29aa4bc*/ void OnDidApplyAnimationProperties();
            /*0x29aa558*/ void ModifyMesh(UnityEngine.Mesh mesh);
            void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        interface IVertexModifier
        {
            void ModifyVertices(System.Collections.Generic.List<UnityEngine.UIVertex> verts);
        }

        interface IMeshModifier
        {
            void ModifyMesh(UnityEngine.Mesh mesh);
            void ModifyMesh(UnityEngine.UI.VertexHelper verts);
        }

        class Outline : UnityEngine.UI.Shadow
        {
            /*0x29aa708*/ Outline();
            /*0x29aa710*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class PositionAsUV1 : UnityEngine.UI.BaseMeshEffect
        {
            /*0x29ab350*/ PositionAsUV1();
            /*0x29ab358*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        class Shadow : UnityEngine.UI.BaseMeshEffect
        {
            static float kMaxEffectDistance = 600;
            /*0x20*/ UnityEngine.Color m_EffectColor;
            /*0x30*/ UnityEngine.Vector2 m_EffectDistance;
            /*0x38*/ bool m_UseGraphicAlpha;

            /*0x29ab414*/ Shadow();
            /*0x29ab43c*/ UnityEngine.Color get_effectColor();
            /*0x29ab448*/ void set_effectColor(UnityEngine.Color value);
            /*0x29ab51c*/ UnityEngine.Vector2 get_effectDistance();
            /*0x29ab524*/ void set_effectDistance(UnityEngine.Vector2 value);
            /*0x29ab628*/ bool get_useGraphicAlpha();
            /*0x29ab630*/ void set_useGraphicAlpha(bool value);
            /*0x29ab6e8*/ void ApplyShadowZeroAlloc(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x29ab9f4*/ void ApplyShadow(System.Collections.Generic.List<UnityEngine.UIVertex> verts, UnityEngine.Color32 color, int start, int end, float x, float y);
            /*0x29ab9fc*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
        }

        namespace Collections
        {
            class IndexedSet<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.List<T> m_List;
                /*0x0*/ System.Collections.Generic.Dictionary<T, int> m_Dictionary;
                /*0x0*/ int m_EnabledObjectCount;

                IndexedSet();
                void Add(T item);
                void Add(T item, bool isActive);
                bool AddUnique(T item, bool isActive);
                bool EnableItem(T item);
                bool DisableItem(T item);
                bool Remove(T item);
                System.Collections.Generic.IEnumerator<T> GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int arrayIndex);
                int get_Count();
                int get_Capacity();
                bool get_IsReadOnly();
                int IndexOf(T item);
                void Insert(int index, T item);
                void RemoveAt(int index);
                void Swap(int index1, int index2);
                T get_Item(int index);
                void set_Item(int index, T value);
                void RemoveAll(System.Predicate<T> match);
                void Sort(System.Comparison<T> sortLayoutFunction);
            }
        }

        namespace CoroutineTween
        {
            interface ITweenValue
            {
                void TweenValue(float floatPercentage);
                bool get_ignoreTimeScale();
                float get_duration();
                bool ValidTarget();
            }

            struct ColorTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenCallback m_Target;
                /*0x18*/ UnityEngine.Color m_StartColor;
                /*0x28*/ UnityEngine.Color m_TargetColor;
                /*0x38*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode m_TweenMode;
                /*0x3c*/ float m_Duration;
                /*0x40*/ bool m_IgnoreTimeScale;

                /*0x29abddc*/ UnityEngine.Color get_startColor();
                /*0x29abde8*/ void set_startColor(UnityEngine.Color value);
                /*0x29abdf4*/ UnityEngine.Color get_targetColor();
                /*0x29abe00*/ void set_targetColor(UnityEngine.Color value);
                /*0x29abe0c*/ UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode get_tweenMode();
                /*0x29abe14*/ void set_tweenMode(UnityEngine.UI.CoroutineTween.ColorTween.ColorTweenMode value);
                /*0x29abe1c*/ float get_duration();
                /*0x29abe24*/ void set_duration(float value);
                /*0x29abe2c*/ bool get_ignoreTimeScale();
                /*0x29abe34*/ void set_ignoreTimeScale(bool value);
                /*0x29abe40*/ void TweenValue(float floatPercentage);
                /*0x29abf2c*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<UnityEngine.Color> callback);
                /*0x29abffc*/ bool GetIgnoreTimescale();
                /*0x29ac004*/ float GetDuration();
                /*0x29abf1c*/ bool ValidTarget();

                enum ColorTweenMode
                {
                    All = 0,
                    RGB = 1,
                    Alpha = 2,
                }

                class ColorTweenCallback : UnityEngine.Events.UnityEvent<UnityEngine.Color>
                {
                    /*0x29abfb4*/ ColorTweenCallback();
                }
            }

            struct FloatTween : UnityEngine.UI.CoroutineTween.ITweenValue
            {
                /*0x10*/ UnityEngine.UI.CoroutineTween.FloatTween.FloatTweenCallback m_Target;
                /*0x18*/ float m_StartValue;
                /*0x1c*/ float m_TargetValue;
                /*0x20*/ float m_Duration;
                /*0x24*/ bool m_IgnoreTimeScale;

                /*0x29ac00c*/ float get_startValue();
                /*0x29ac014*/ void set_startValue(float value);
                /*0x29ac01c*/ float get_targetValue();
                /*0x29ac024*/ void set_targetValue(float value);
                /*0x29ac02c*/ float get_duration();
                /*0x29ac034*/ void set_duration(float value);
                /*0x29ac03c*/ bool get_ignoreTimeScale();
                /*0x29ac044*/ void set_ignoreTimeScale(bool value);
                /*0x29ac050*/ void TweenValue(float floatPercentage);
                /*0x29ac0ec*/ void AddOnChangedCallback(UnityEngine.Events.UnityAction<float> callback);
                /*0x29ac1bc*/ bool GetIgnoreTimescale();
                /*0x29ac1c4*/ float GetDuration();
                /*0x29ac0dc*/ bool ValidTarget();

                class FloatTweenCallback : UnityEngine.Events.UnityEvent<float>
                {
                    /*0x29ac174*/ FloatTweenCallback();
                }
            }

            class TweenRunner<T>
            {
                /*0x0*/ UnityEngine.MonoBehaviour m_CoroutineContainer;
                /*0x0*/ System.Collections.IEnumerator m_Tween;

                static System.Collections.IEnumerator Start(T tweenInfo);
                TweenRunner();
                void Init(UnityEngine.MonoBehaviour coroutineContainer);
                void StartTween(T info);
                void StopTween();

                class <Start>d__2<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ object <>2__current;
                    /*0x0*/ T tweenInfo;
                    /*0x0*/ float <elapsedTime>5__2;

                    <Start>d__2(int <>1__state);
                    void System.IDisposable.Dispose();
                    bool MoveNext();
                    object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }

    namespace UIElements
    {
        class PanelEventHandler : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerMoveHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.UIElements.IRuntimePanelComponent
        {
            static /*0x0*/ UnityEngine.EventModifiers s_Modifiers;
            /*0x18*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;
            /*0x20*/ UnityEngine.UIElements.PanelEventHandler.PointerEvent m_PointerEvent;
            /*0x28*/ bool m_Selecting;
            /*0x30*/ UnityEngine.Event m_Event;

            /*0x29ae774*/ PanelEventHandler();
            /*0x29ac1cc*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x29ac1d4*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x29ac5f8*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x29ac610*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x29ac6e4*/ void OnEnable();
            /*0x29ac6ec*/ void OnDisable();
            /*0x29ac438*/ void RegisterCallbacks();
            /*0x29ac278*/ void UnregisterCallbacks();
            /*0x29ac6f4*/ void OnPanelDestroyed();
            /*0x29ac6fc*/ void OnElementFocus(UnityEngine.UIElements.FocusEvent e);
            /*0x29ac7e4*/ void OnElementBlur(UnityEngine.UIElements.BlurEvent e);
            /*0x29ac7e8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29ac860*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29ac874*/ void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29acbc4*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29acde4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29ad06c*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29ad320*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29ad374*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29ad52c*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29ad6e4*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x29ad870*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29acb60*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.EventSystems.BaseEventData sourceEventData);
            /*0x29ada30*/ void SendEvent(UnityEngine.UIElements.EventBase e, UnityEngine.Event sourceEvent);
            /*0x29ada90*/ void Update();
            /*0x29adcb8*/ void LateUpdate();
            /*0x29adb70*/ void ProcessImguiEvents(bool isSelected);
            /*0x29adcc0*/ void ProcessKeyboardEvent(UnityEngine.Event e);
            /*0x29add34*/ void ProcessTabEvent(UnityEngine.Event e);
            /*0x29ae144*/ void SendTabEvent(UnityEngine.Event e, int direction);
            /*0x29addb4*/ void SendKeyUpEvent(UnityEngine.Event e);
            /*0x29adf70*/ void SendKeyDownEvent(UnityEngine.Event e);
            /*0x29aca24*/ bool ReadPointerData(UnityEngine.UIElements.PanelEventHandler.PointerEvent pe, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);

            enum PointerEventType
            {
                Default = 0,
                Down = 1,
                Up = 2,
            }

            class PointerEvent : UnityEngine.UIElements.IPointerEvent
            {
                /*0x10*/ int <pointerId>k__BackingField;
                /*0x18*/ string <pointerType>k__BackingField;
                /*0x20*/ bool <isPrimary>k__BackingField;
                /*0x24*/ int <button>k__BackingField;
                /*0x28*/ int <pressedButtons>k__BackingField;
                /*0x2c*/ UnityEngine.Vector3 <position>k__BackingField;
                /*0x38*/ UnityEngine.Vector3 <localPosition>k__BackingField;
                /*0x44*/ UnityEngine.Vector3 <deltaPosition>k__BackingField;
                /*0x50*/ float <deltaTime>k__BackingField;
                /*0x54*/ int <clickCount>k__BackingField;
                /*0x58*/ float <pressure>k__BackingField;
                /*0x5c*/ float <tangentialPressure>k__BackingField;
                /*0x60*/ float <altitudeAngle>k__BackingField;
                /*0x64*/ float <azimuthAngle>k__BackingField;
                /*0x68*/ float <twist>k__BackingField;
                /*0x6c*/ UnityEngine.Vector2 <radius>k__BackingField;
                /*0x74*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
                /*0x7c*/ UnityEngine.EventModifiers <modifiers>k__BackingField;

                static /*0x29ae9cc*/ bool <Read>g__InRange|82_0(int i, int start, int count);
                /*0x29ae80c*/ PointerEvent();
                /*0x29ae81c*/ int get_pointerId();
                /*0x29ae824*/ void set_pointerId(int value);
                /*0x29ae82c*/ string get_pointerType();
                /*0x29ae834*/ void set_pointerType(string value);
                /*0x29ae83c*/ bool get_isPrimary();
                /*0x29ae844*/ void set_isPrimary(bool value);
                /*0x29ae850*/ int get_button();
                /*0x29ae858*/ void set_button(int value);
                /*0x29ae860*/ int get_pressedButtons();
                /*0x29ae868*/ void set_pressedButtons(int value);
                /*0x29ae870*/ UnityEngine.Vector3 get_position();
                /*0x29ae87c*/ void set_position(UnityEngine.Vector3 value);
                /*0x29ae888*/ UnityEngine.Vector3 get_localPosition();
                /*0x29ae894*/ void set_localPosition(UnityEngine.Vector3 value);
                /*0x29ae8a0*/ UnityEngine.Vector3 get_deltaPosition();
                /*0x29ae8ac*/ void set_deltaPosition(UnityEngine.Vector3 value);
                /*0x29ae8b8*/ float get_deltaTime();
                /*0x29ae8c0*/ void set_deltaTime(float value);
                /*0x29ae8c8*/ int get_clickCount();
                /*0x29ae8d0*/ void set_clickCount(int value);
                /*0x29ae8d8*/ float get_pressure();
                /*0x29ae8e0*/ void set_pressure(float value);
                /*0x29ae8e8*/ float get_tangentialPressure();
                /*0x29ae8f0*/ void set_tangentialPressure(float value);
                /*0x29ae8f8*/ float get_altitudeAngle();
                /*0x29ae900*/ void set_altitudeAngle(float value);
                /*0x29ae908*/ float get_azimuthAngle();
                /*0x29ae910*/ void set_azimuthAngle(float value);
                /*0x29ae918*/ float get_twist();
                /*0x29ae920*/ void set_twist(float value);
                /*0x29ae928*/ UnityEngine.Vector2 get_radius();
                /*0x29ae930*/ void set_radius(UnityEngine.Vector2 value);
                /*0x29ae938*/ UnityEngine.Vector2 get_radiusVariance();
                /*0x29ae940*/ void set_radiusVariance(UnityEngine.Vector2 value);
                /*0x29ae948*/ UnityEngine.EventModifiers get_modifiers();
                /*0x29ae950*/ void set_modifiers(UnityEngine.EventModifiers value);
                /*0x29ae958*/ bool get_shiftKey();
                /*0x29ae964*/ bool get_ctrlKey();
                /*0x29ae970*/ bool get_commandKey();
                /*0x29ae97c*/ bool get_altKey();
                /*0x29ae988*/ bool get_actionKey();
                /*0x29ae2c4*/ void Read(UnityEngine.UIElements.PanelEventHandler self, UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.UIElements.PanelEventHandler.PointerEventType eventType);
                /*0x29ae75c*/ void SetPosition(UnityEngine.Vector3 positionOverride, UnityEngine.Vector3 deltaOverride);
            }
        }

        class PanelRaycaster : UnityEngine.EventSystems.BaseRaycaster, UnityEngine.UIElements.IRuntimePanelComponent
        {
            /*0x20*/ UnityEngine.UIElements.BaseRuntimePanel m_Panel;

            static /*0x29aec30*/ int ConvertFloatBitsToInt(float f);
            /*0x29af16c*/ PanelRaycaster();
            /*0x29ae9e8*/ UnityEngine.UIElements.IPanel get_panel();
            /*0x29ae9f0*/ void set_panel(UnityEngine.UIElements.IPanel value);
            /*0x29aeb2c*/ void RegisterCallbacks();
            /*0x29aea94*/ void UnregisterCallbacks();
            /*0x29aebc4*/ void OnPanelDestroyed();
            /*0x29aebcc*/ UnityEngine.GameObject get_selectableGameObject();
            /*0x29aebe4*/ int get_sortOrderPriority();
            /*0x29aec18*/ int get_renderOrderPriority();
            /*0x29aec38*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            /*0x29af164*/ UnityEngine.Camera get_eventCamera();

            struct FloatIntBits
            {
                /*0x10*/ float f;
                /*0x10*/ int i;
            }
        }
    }

    namespace EventSystems
    {
        class AxisEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.Vector2 <moveVector>k__BackingField;
            /*0x28*/ UnityEngine.EventSystems.MoveDirection <moveDir>k__BackingField;

            /*0x29af19c*/ AxisEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x29af17c*/ UnityEngine.Vector2 get_moveVector();
            /*0x29af184*/ void set_moveVector(UnityEngine.Vector2 value);
            /*0x29af18c*/ UnityEngine.EventSystems.MoveDirection get_moveDir();
            /*0x29af194*/ void set_moveDir(UnityEngine.EventSystems.MoveDirection value);
        }

        class AbstractEventData
        {
            /*0x10*/ bool m_Used;

            /*0x29af248*/ AbstractEventData();
            /*0x29af22c*/ void Reset();
            /*0x29af234*/ void Use();
            /*0x29af240*/ bool get_used();
        }

        class BaseEventData : UnityEngine.EventSystems.AbstractEventData
        {
            /*0x18*/ UnityEngine.EventSystems.EventSystem m_EventSystem;

            /*0x29af204*/ BaseEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x29af250*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x29af26c*/ UnityEngine.GameObject get_selectedObject();
            /*0x29af288*/ void set_selectedObject(UnityEngine.GameObject value);
        }

        class PointerEventData : UnityEngine.EventSystems.BaseEventData
        {
            /*0x20*/ UnityEngine.GameObject <pointerEnter>k__BackingField;
            /*0x28*/ UnityEngine.GameObject m_PointerPress;
            /*0x30*/ UnityEngine.GameObject <lastPress>k__BackingField;
            /*0x38*/ UnityEngine.GameObject <rawPointerPress>k__BackingField;
            /*0x40*/ UnityEngine.GameObject <pointerDrag>k__BackingField;
            /*0x48*/ UnityEngine.GameObject <pointerClick>k__BackingField;
            /*0x50*/ UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField;
            /*0xa0*/ UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField;
            /*0xf0*/ System.Collections.Generic.List<UnityEngine.GameObject> hovered;
            /*0xf8*/ bool <eligibleForClick>k__BackingField;
            /*0xfc*/ int <pointerId>k__BackingField;
            /*0x100*/ UnityEngine.Vector2 <position>k__BackingField;
            /*0x108*/ UnityEngine.Vector2 <delta>k__BackingField;
            /*0x110*/ UnityEngine.Vector2 <pressPosition>k__BackingField;
            /*0x118*/ UnityEngine.Vector3 <worldPosition>k__BackingField;
            /*0x124*/ UnityEngine.Vector3 <worldNormal>k__BackingField;
            /*0x130*/ float <clickTime>k__BackingField;
            /*0x134*/ int <clickCount>k__BackingField;
            /*0x138*/ UnityEngine.Vector2 <scrollDelta>k__BackingField;
            /*0x140*/ bool <useDragThreshold>k__BackingField;
            /*0x141*/ bool <dragging>k__BackingField;
            /*0x144*/ UnityEngine.EventSystems.PointerEventData.InputButton <button>k__BackingField;
            /*0x148*/ float <pressure>k__BackingField;
            /*0x14c*/ float <tangentialPressure>k__BackingField;
            /*0x150*/ float <altitudeAngle>k__BackingField;
            /*0x154*/ float <azimuthAngle>k__BackingField;
            /*0x158*/ float <twist>k__BackingField;
            /*0x15c*/ UnityEngine.Vector2 <radius>k__BackingField;
            /*0x164*/ UnityEngine.Vector2 <radiusVariance>k__BackingField;
            /*0x16c*/ bool <fullyExited>k__BackingField;
            /*0x16d*/ bool <reentered>k__BackingField;

            /*0x29af72c*/ PointerEventData(UnityEngine.EventSystems.EventSystem eventSystem);
            /*0x29af4c8*/ UnityEngine.GameObject get_pointerEnter();
            /*0x29af4d0*/ void set_pointerEnter(UnityEngine.GameObject value);
            /*0x29af4d8*/ UnityEngine.GameObject get_lastPress();
            /*0x29af4e0*/ void set_lastPress(UnityEngine.GameObject value);
            /*0x29af4e8*/ UnityEngine.GameObject get_rawPointerPress();
            /*0x29af4f0*/ void set_rawPointerPress(UnityEngine.GameObject value);
            /*0x29af4f8*/ UnityEngine.GameObject get_pointerDrag();
            /*0x29af500*/ void set_pointerDrag(UnityEngine.GameObject value);
            /*0x29af508*/ UnityEngine.GameObject get_pointerClick();
            /*0x29af510*/ void set_pointerClick(UnityEngine.GameObject value);
            /*0x29af518*/ UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast();
            /*0x29af528*/ void set_pointerCurrentRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x29af540*/ UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast();
            /*0x29af550*/ void set_pointerPressRaycast(UnityEngine.EventSystems.RaycastResult value);
            /*0x29af568*/ bool get_eligibleForClick();
            /*0x29af570*/ void set_eligibleForClick(bool value);
            /*0x29af57c*/ int get_pointerId();
            /*0x29af584*/ void set_pointerId(int value);
            /*0x29af58c*/ UnityEngine.Vector2 get_position();
            /*0x29af598*/ void set_position(UnityEngine.Vector2 value);
            /*0x29af5a4*/ UnityEngine.Vector2 get_delta();
            /*0x29af5b0*/ void set_delta(UnityEngine.Vector2 value);
            /*0x29af5bc*/ UnityEngine.Vector2 get_pressPosition();
            /*0x29af5c8*/ void set_pressPosition(UnityEngine.Vector2 value);
            /*0x29af5d4*/ UnityEngine.Vector3 get_worldPosition();
            /*0x29af5e4*/ void set_worldPosition(UnityEngine.Vector3 value);
            /*0x29af5f4*/ UnityEngine.Vector3 get_worldNormal();
            /*0x29af604*/ void set_worldNormal(UnityEngine.Vector3 value);
            /*0x29af614*/ float get_clickTime();
            /*0x29af61c*/ void set_clickTime(float value);
            /*0x29af624*/ int get_clickCount();
            /*0x29af62c*/ void set_clickCount(int value);
            /*0x29af634*/ UnityEngine.Vector2 get_scrollDelta();
            /*0x29af640*/ void set_scrollDelta(UnityEngine.Vector2 value);
            /*0x29af64c*/ bool get_useDragThreshold();
            /*0x29af654*/ void set_useDragThreshold(bool value);
            /*0x29af660*/ bool get_dragging();
            /*0x29af668*/ void set_dragging(bool value);
            /*0x29af674*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
            /*0x29af67c*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            /*0x29af684*/ float get_pressure();
            /*0x29af68c*/ void set_pressure(float value);
            /*0x29af694*/ float get_tangentialPressure();
            /*0x29af69c*/ void set_tangentialPressure(float value);
            /*0x29af6a4*/ float get_altitudeAngle();
            /*0x29af6ac*/ void set_altitudeAngle(float value);
            /*0x29af6b4*/ float get_azimuthAngle();
            /*0x29af6bc*/ void set_azimuthAngle(float value);
            /*0x29af6c4*/ float get_twist();
            /*0x29af6cc*/ void set_twist(float value);
            /*0x29af6d4*/ UnityEngine.Vector2 get_radius();
            /*0x29af6e0*/ void set_radius(UnityEngine.Vector2 value);
            /*0x29af6ec*/ UnityEngine.Vector2 get_radiusVariance();
            /*0x29af6f8*/ void set_radiusVariance(UnityEngine.Vector2 value);
            /*0x29af704*/ bool get_fullyExited();
            /*0x29af70c*/ void set_fullyExited(bool value);
            /*0x29af718*/ bool get_reentered();
            /*0x29af720*/ void set_reentered(bool value);
            /*0x29af858*/ bool IsPointerMoving();
            /*0x29af878*/ bool IsScrolling();
            /*0x29af898*/ UnityEngine.Camera get_enterEventCamera();
            /*0x29af928*/ UnityEngine.Camera get_pressEventCamera();
            /*0x29af9b8*/ UnityEngine.GameObject get_pointerPress();
            /*0x29af9c0*/ void set_pointerPress(UnityEngine.GameObject value);
            /*0x29afa3c*/ string ToString();

            enum InputButton
            {
                Left = 0,
                Right = 1,
                Middle = 2,
            }

            enum FramePressState
            {
                Pressed = 0,
                Released = 1,
                PressedAndReleased = 2,
                NotChanged = 3,
            }
        }

        enum EventHandle
        {
            Unused = 0,
            Used = 1,
        }

        interface IEventSystemHandler
        {
        }

        interface IPointerMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerMove(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerEnterHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerExitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerDownHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerUpHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IPointerClickHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IBeginDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IInitializePotentialDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IEndDragHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IDropHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IScrollHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        interface IUpdateSelectedHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ISelectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IDeselectHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface IMoveHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        interface ISubmitHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        interface ICancelHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class EventSystem : UnityEngine.EventSystems.UIBehaviour
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventSystem> m_EventSystems;
            static /*0x8*/ System.Comparison<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer;
            static /*0x10*/ UnityEngine.EventSystems.EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules;
            /*0x20*/ UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule;
            /*0x28*/ UnityEngine.GameObject m_FirstSelected;
            /*0x30*/ bool m_sendNavigationEvents;
            /*0x34*/ int m_DragThreshold;
            /*0x38*/ UnityEngine.GameObject m_CurrentSelected;
            /*0x40*/ bool m_HasFocus;
            /*0x41*/ bool m_SelectionGuard;
            /*0x48*/ UnityEngine.EventSystems.BaseEventData m_DummyData;

            static /*0x29b23d0*/ EventSystem();
            static /*0x29b06f4*/ UnityEngine.EventSystems.EventSystem get_current();
            static /*0x29b07b8*/ void set_current(UnityEngine.EventSystems.EventSystem value);
            static /*0x29b0be8*/ int RaycastComparer(UnityEngine.EventSystems.RaycastResult lhs, UnityEngine.EventSystems.RaycastResult rhs);
            static /*0x29b14cc*/ void SetUITookitEventSystemOverride(UnityEngine.EventSystems.EventSystem activeEventSystem, bool sendEvents, bool createPanelGameObjectsOnStart);
            /*0x29b09a0*/ EventSystem();
            /*0x29b094c*/ bool get_sendNavigationEvents();
            /*0x29b0954*/ void set_sendNavigationEvents(bool value);
            /*0x29b0960*/ int get_pixelDragThreshold();
            /*0x29b0968*/ void set_pixelDragThreshold(int value);
            /*0x29b0970*/ UnityEngine.EventSystems.BaseInputModule get_currentInputModule();
            /*0x29b0978*/ UnityEngine.GameObject get_firstSelectedGameObject();
            /*0x29b0980*/ void set_firstSelectedGameObject(UnityEngine.GameObject value);
            /*0x29b0988*/ UnityEngine.GameObject get_currentSelectedGameObject();
            /*0x29b0990*/ UnityEngine.GameObject get_lastSelectedGameObject();
            /*0x29b0998*/ bool get_isFocused();
            /*0x29b0a30*/ void UpdateModules();
            /*0x29b0b70*/ bool get_alreadySelecting();
            /*0x29af2a4*/ void SetSelectedGameObject(UnityEngine.GameObject selected, UnityEngine.EventSystems.BaseEventData pointer);
            /*0x29b0b78*/ UnityEngine.EventSystems.BaseEventData get_baseEventDataCache();
            /*0x29ac7b8*/ void SetSelectedGameObject(UnityEngine.GameObject selected);
            /*0x29b1058*/ void RaycastAll(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> raycastResults);
            /*0x29b1248*/ bool IsPointerOverGameObject();
            /*0x29b1250*/ bool IsPointerOverGameObject(int pointerId);
            /*0x29b12f4*/ bool get_isUIToolkitActiveEventSystem();
            /*0x29b13e4*/ bool get_sendUIToolkitEvents();
            /*0x29b1458*/ bool get_createUIToolkitPanelGameObjectsOnStart();
            /*0x29b1668*/ void CreateUIToolkitPanelGameObject(UnityEngine.UIElements.BaseRuntimePanel panel);
            /*0x29b190c*/ void Start();
            /*0x29b1b4c*/ void OnDestroy();
            /*0x29b1bf4*/ void OnEnable();
            /*0x29b1d04*/ void OnDisable();
            /*0x29b1e0c*/ void TickModules();
            /*0x29b1f0c*/ void OnApplicationFocus(bool hasFocus);
            /*0x29b1f20*/ void Update();
            /*0x29b2180*/ void ChangeEventModule(UnityEngine.EventSystems.BaseInputModule module);
            /*0x29b2278*/ string ToString();

            struct UIToolkitOverrideConfig
            {
                /*0x10*/ UnityEngine.EventSystems.EventSystem activeEventSystem;
                /*0x18*/ bool sendEvents;
                /*0x19*/ bool createPanelGameObjectsOnStart;
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.GameObject go;

                /*0x29b1904*/ <>c__DisplayClass52_0();
                /*0x29b24c0*/ void <CreateUIToolkitPanelGameObject>b__0();
            }
        }

        class EventTrigger : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> m_Delegates;

            /*0x29b25a8*/ EventTrigger();
            /*0x29b251c*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_delegates();
            /*0x29b25a0*/ void set_delegates(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x29b2520*/ System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> get_triggers();
            /*0x29b25b0*/ void set_triggers(System.Collections.Generic.List<UnityEngine.EventSystems.EventTrigger.Entry> value);
            /*0x29b25b8*/ void Execute(UnityEngine.EventSystems.EventTriggerType id, UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29b26a4*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26b0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26bc*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26c8*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26d4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26e0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26ec*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b26f8*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29b2704*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29b2710*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b271c*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x29b2728*/ void OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29b2734*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b2740*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b274c*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x29b2758*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x29b2764*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);

            class TriggerEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>
            {
                /*0x29b2770*/ TriggerEvent();
            }

            class Entry
            {
                /*0x10*/ UnityEngine.EventSystems.EventTriggerType eventID;
                /*0x18*/ UnityEngine.EventSystems.EventTrigger.TriggerEvent callback;

                /*0x29b27b8*/ Entry();
            }
        }

        enum EventTriggerType
        {
            PointerEnter = 0,
            PointerExit = 1,
            PointerDown = 2,
            PointerUp = 3,
            PointerClick = 4,
            Drag = 5,
            Drop = 6,
            Scroll = 7,
            UpdateSelected = 8,
            Select = 9,
            Deselect = 10,
            Move = 11,
            InitializePotentialDrag = 12,
            BeginDrag = 13,
            EndDrag = 14,
            Submit = 15,
            Cancel = 16,
        }

        class ExecuteEvents
        {
            static /*0x0*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler;
            static /*0x8*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler;
            static /*0x10*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler;
            static /*0x18*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler;
            static /*0x20*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler;
            static /*0x28*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler;
            static /*0x30*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler;
            static /*0x38*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler;
            static /*0x40*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> s_DragHandler;
            static /*0x48*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler;
            static /*0x50*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> s_DropHandler;
            static /*0x58*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler;
            static /*0x60*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler;
            static /*0x68*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler;
            static /*0x70*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler;
            static /*0x78*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler;
            static /*0x80*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler;
            static /*0x88*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler;
            static /*0x90*/ System.Collections.Generic.List<UnityEngine.Transform> s_InternalTransformList;

            static /*0x29b3f80*/ ExecuteEvents();
            static T ValidateEventData<T>(UnityEngine.EventSystems.BaseEventData data);
            static /*0x29b2824*/ void Execute(UnityEngine.EventSystems.IPointerMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2918*/ void Execute(UnityEngine.EventSystems.IPointerEnterHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2a0c*/ void Execute(UnityEngine.EventSystems.IPointerExitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2b00*/ void Execute(UnityEngine.EventSystems.IPointerDownHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2bf4*/ void Execute(UnityEngine.EventSystems.IPointerUpHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2ce8*/ void Execute(UnityEngine.EventSystems.IPointerClickHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2ddc*/ void Execute(UnityEngine.EventSystems.IInitializePotentialDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2ed0*/ void Execute(UnityEngine.EventSystems.IBeginDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b2fc4*/ void Execute(UnityEngine.EventSystems.IDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b30b8*/ void Execute(UnityEngine.EventSystems.IEndDragHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b31ac*/ void Execute(UnityEngine.EventSystems.IDropHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b32a0*/ void Execute(UnityEngine.EventSystems.IScrollHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b3394*/ void Execute(UnityEngine.EventSystems.IUpdateSelectedHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b3438*/ void Execute(UnityEngine.EventSystems.ISelectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b34dc*/ void Execute(UnityEngine.EventSystems.IDeselectHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b3580*/ void Execute(UnityEngine.EventSystems.IMoveHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b3674*/ void Execute(UnityEngine.EventSystems.ISubmitHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b3718*/ void Execute(UnityEngine.EventSystems.ICancelHandler handler, UnityEngine.EventSystems.BaseEventData eventData);
            static /*0x29b37bc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerMoveHandler> get_pointerMoveHandler();
            static /*0x29b3814*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> get_pointerEnterHandler();
            static /*0x29b386c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> get_pointerExitHandler();
            static /*0x29b38c4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> get_pointerDownHandler();
            static /*0x29b391c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> get_pointerUpHandler();
            static /*0x29b3974*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> get_pointerClickHandler();
            static /*0x29b39cc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IInitializePotentialDragHandler> get_initializePotentialDrag();
            static /*0x29b3a24*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> get_beginDragHandler();
            static /*0x29b3a7c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDragHandler> get_dragHandler();
            static /*0x29b3ad4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> get_endDragHandler();
            static /*0x29b3b2c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> get_dropHandler();
            static /*0x29b3b84*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IScrollHandler> get_scrollHandler();
            static /*0x29b3bdc*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> get_updateSelectedHandler();
            static /*0x29b3c34*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISelectHandler> get_selectHandler();
            static /*0x29b3c8c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> get_deselectHandler();
            static /*0x29b3ce4*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> get_moveHandler();
            static /*0x29b3d3c*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> get_submitHandler();
            static /*0x29b3d94*/ UnityEngine.EventSystems.ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> get_cancelHandler();
            static /*0x29b3dec*/ void GetEventChain(UnityEngine.GameObject root, System.Collections.Generic.IList<UnityEngine.Transform> eventChain);
            static bool Execute<T>(UnityEngine.GameObject target, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> functor);
            static UnityEngine.GameObject ExecuteHierarchy<T>(UnityEngine.GameObject root, UnityEngine.EventSystems.BaseEventData eventData, UnityEngine.EventSystems.ExecuteEvents.EventFunction<T> callbackFunction);
            static bool ShouldSendToComponent<T>(UnityEngine.Component component);
            static void GetEventList<T>(UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.EventSystems.IEventSystemHandler> results);
            static bool CanHandleEvent<T>(UnityEngine.GameObject go);
            static UnityEngine.GameObject GetEventHandler<T>(UnityEngine.GameObject root);

            class EventFunction<T1> : System.MulticastDelegate
            {
                EventFunction(object object, nint method);
                void Invoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData);
                System.IAsyncResult BeginInvoke(T1 handler, UnityEngine.EventSystems.BaseEventData eventData, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }
        }

        class BaseInput : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x29b46c0*/ BaseInput();
            /*0x29b45f8*/ string get_compositionString();
            /*0x29b4600*/ UnityEngine.IMECompositionMode get_imeCompositionMode();
            /*0x29b4608*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
            /*0x29b4614*/ UnityEngine.Vector2 get_compositionCursorPos();
            /*0x29b461c*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
            /*0x29b4624*/ bool get_mousePresent();
            /*0x29b462c*/ bool GetMouseButtonDown(int button);
            /*0x29b4638*/ bool GetMouseButtonUp(int button);
            /*0x29b4644*/ bool GetMouseButton(int button);
            /*0x29b4650*/ UnityEngine.Vector2 get_mousePosition();
            /*0x29b4658*/ UnityEngine.Vector2 get_mouseScrollDelta();
            /*0x29b4660*/ bool get_touchSupported();
            /*0x29b4668*/ int get_touchCount();
            /*0x29b4670*/ UnityEngine.Touch GetTouch(int index);
            /*0x29b46a8*/ float GetAxisRaw(string axisName);
            /*0x29b46b4*/ bool GetButtonDown(string buttonName);
        }

        class BaseInputModule : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache;
            /*0x20*/ bool m_SendPointerHoverToParent;
            /*0x28*/ UnityEngine.EventSystems.AxisEventData m_AxisEventData;
            /*0x30*/ UnityEngine.EventSystems.EventSystem m_EventSystem;
            /*0x38*/ UnityEngine.EventSystems.BaseEventData m_BaseEventData;
            /*0x40*/ UnityEngine.EventSystems.BaseInput m_InputOverride;
            /*0x48*/ UnityEngine.EventSystems.BaseInput m_DefaultInput;

            static /*0x29b497c*/ UnityEngine.EventSystems.RaycastResult FindFirstRaycast(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> candidates);
            static /*0x29b4a90*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y);
            static /*0x29b4ae4*/ UnityEngine.EventSystems.MoveDirection DetermineMoveDirection(float x, float y, float deadZone);
            static /*0x29b4b34*/ UnityEngine.GameObject FindCommonRoot(UnityEngine.GameObject g1, UnityEngine.GameObject g2);
            /*0x29b5950*/ BaseInputModule();
            /*0x29b46c8*/ bool get_sendPointerHoverToParent();
            /*0x29b46d0*/ void set_sendPointerHoverToParent(bool value);
            /*0x29b46dc*/ UnityEngine.EventSystems.BaseInput get_input();
            /*0x29b48f4*/ UnityEngine.EventSystems.BaseInput get_inputOverride();
            /*0x29b48fc*/ void set_inputOverride(UnityEngine.EventSystems.BaseInput value);
            /*0x29b4904*/ UnityEngine.EventSystems.EventSystem get_eventSystem();
            /*0x29b490c*/ void OnEnable();
            /*0x29b4964*/ void OnDisable();
            void Process();
            /*0x29b4ca8*/ void HandlePointerExitAndEnter(UnityEngine.EventSystems.PointerEventData currentPointerData, UnityEngine.GameObject newEnterTarget);
            /*0x29b56f4*/ UnityEngine.EventSystems.AxisEventData GetAxisEventData(float x, float y, float moveDeadZone);
            /*0x29b57f4*/ UnityEngine.EventSystems.BaseEventData GetBaseEventData();
            /*0x29b5878*/ bool IsPointerOverGameObject(int pointerId);
            /*0x29b5880*/ bool ShouldActivateModule();
            /*0x29b58c0*/ void DeactivateModule();
            /*0x29b58c4*/ void ActivateModule();
            /*0x29b58c8*/ void UpdateModule();
            /*0x29b58cc*/ bool IsModuleSupported();
            /*0x29b58d4*/ int ConvertUIToolkitPointerId(UnityEngine.EventSystems.PointerEventData sourcePointerData);
        }

        class PointerInputModule : UnityEngine.EventSystems.BaseInputModule
        {
            static int kMouseLeftId = -1;
            static int kMouseRightId = -2;
            static int kMouseMiddleId = -3;
            static int kFakeTouchesId = -4;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.EventSystems.PointerEventData> m_PointerData;
            /*0x58*/ UnityEngine.EventSystems.PointerInputModule.MouseState m_MouseState;

            static /*0x29b6324*/ bool ShouldStartDrag(UnityEngine.Vector2 pressPos, UnityEngine.Vector2 currentPos, float threshold, bool useDragThreshold);
            /*0x29b6bfc*/ PointerInputModule();
            /*0x29b59d4*/ bool GetPointerData(int id, ref UnityEngine.EventSystems.PointerEventData data, bool create);
            /*0x29b5abc*/ void RemovePointerData(UnityEngine.EventSystems.PointerEventData data);
            /*0x29b5b18*/ UnityEngine.EventSystems.PointerEventData GetTouchPointerEventData(UnityEngine.Touch input, ref bool pressed, ref bool released);
            /*0x29b5e88*/ void CopyFromTo(UnityEngine.EventSystems.PointerEventData from, UnityEngine.EventSystems.PointerEventData to);
            /*0x29b5f18*/ UnityEngine.EventSystems.PointerEventData.FramePressState StateForMouseButton(int buttonId);
            /*0x29b5f94*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData();
            /*0x29b5fa8*/ UnityEngine.EventSystems.PointerInputModule.MouseState GetMousePointerEventData(int id);
            /*0x29b6304*/ UnityEngine.EventSystems.PointerEventData GetLastPointerEventData(int id);
            /*0x29b6354*/ void ProcessMove(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x29b6398*/ void ProcessDrag(UnityEngine.EventSystems.PointerEventData pointerEvent);
            /*0x29b6644*/ bool IsPointerOverGameObject(int pointerId);
            /*0x29b66e0*/ void ClearSelection();
            /*0x29b68a0*/ string ToString();
            /*0x29b6b10*/ void DeselectIfSelectionChanged(UnityEngine.GameObject currentOverGo, UnityEngine.EventSystems.BaseEventData pointerEvent);

            class ButtonState
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.InputButton m_Button;
                /*0x18*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData m_EventData;

                /*0x29b6d3c*/ ButtonState();
                /*0x29b6d1c*/ UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData get_eventData();
                /*0x29b6d24*/ void set_eventData(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData value);
                /*0x29b6d2c*/ UnityEngine.EventSystems.PointerEventData.InputButton get_button();
                /*0x29b6d34*/ void set_button(UnityEngine.EventSystems.PointerEventData.InputButton value);
            }

            class MouseState
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.EventSystems.PointerInputModule.ButtonState> m_TrackedButtons;

                /*0x29b6ca0*/ MouseState();
                /*0x29b6d44*/ bool AnyPressesThisFrame();
                /*0x29b6e08*/ bool AnyReleasesThisFrame();
                /*0x29b6ed4*/ UnityEngine.EventSystems.PointerInputModule.ButtonState GetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button);
                /*0x29b62cc*/ void SetButtonState(UnityEngine.EventSystems.PointerEventData.InputButton button, UnityEngine.EventSystems.PointerEventData.FramePressState stateForMouseButton, UnityEngine.EventSystems.PointerEventData data);
            }

            class MouseButtonEventData
            {
                /*0x10*/ UnityEngine.EventSystems.PointerEventData.FramePressState buttonState;
                /*0x18*/ UnityEngine.EventSystems.PointerEventData buttonData;

                /*0x29b706c*/ MouseButtonEventData();
                /*0x29b6df8*/ bool PressedThisFrame();
                /*0x29b6ec0*/ bool ReleasedThisFrame();
            }
        }

        class StandaloneInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x60*/ float m_PrevActionTime;
            /*0x64*/ UnityEngine.Vector2 m_LastMoveVector;
            /*0x6c*/ int m_ConsecutiveMoveCount;
            /*0x70*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x78*/ UnityEngine.Vector2 m_MousePosition;
            /*0x80*/ UnityEngine.GameObject m_CurrentFocusedGameObject;
            /*0x88*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x90*/ string m_HorizontalAxis;
            /*0x98*/ string m_VerticalAxis;
            /*0xa0*/ string m_SubmitButton;
            /*0xa8*/ string m_CancelButton;
            /*0xb0*/ float m_InputActionsPerSecond;
            /*0xb4*/ float m_RepeatDelay;
            /*0xb8*/ bool m_ForceModuleActive;

            /*0x29b7074*/ StandaloneInputModule();
            /*0x29b7130*/ UnityEngine.EventSystems.StandaloneInputModule.InputMode get_inputMode();
            /*0x29b7138*/ bool get_allowActivationOnMobileDevice();
            /*0x29b7140*/ void set_allowActivationOnMobileDevice(bool value);
            /*0x29b714c*/ bool get_forceModuleActive();
            /*0x29b7154*/ void set_forceModuleActive(bool value);
            /*0x29b7160*/ float get_inputActionsPerSecond();
            /*0x29b7168*/ void set_inputActionsPerSecond(float value);
            /*0x29b7170*/ float get_repeatDelay();
            /*0x29b7178*/ void set_repeatDelay(float value);
            /*0x29b7180*/ string get_horizontalAxis();
            /*0x29b7188*/ void set_horizontalAxis(string value);
            /*0x29b7190*/ string get_verticalAxis();
            /*0x29b7198*/ void set_verticalAxis(string value);
            /*0x29b71a0*/ string get_submitButton();
            /*0x29b71a8*/ void set_submitButton(string value);
            /*0x29b71b0*/ string get_cancelButton();
            /*0x29b71b8*/ void set_cancelButton(string value);
            /*0x29b71c0*/ bool ShouldIgnoreEventsOnNoFocus();
            /*0x29b71c8*/ void UpdateModule();
            /*0x29b7298*/ void ReleaseMouse(UnityEngine.EventSystems.PointerEventData pointerEvent, UnityEngine.GameObject currentOverGo);
            /*0x29b7604*/ bool ShouldActivateModule();
            /*0x29b7838*/ void ActivateModule();
            /*0x29b7938*/ void DeactivateModule();
            /*0x29b793c*/ void Process();
            /*0x29b7b28*/ bool ProcessTouchEvents();
            /*0x29b8104*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x29b7ef8*/ bool SendSubmitEventToSelectedObject();
            /*0x29b8768*/ UnityEngine.Vector2 GetRawMoveVector();
            /*0x29b7c94*/ bool SendMoveEventToSelectedObject();
            /*0x29b7c8c*/ void ProcessMouseEvent();
            /*0x29b8b20*/ bool ForceAutoSelect();
            /*0x29b8878*/ void ProcessMouseEvent(int id);
            /*0x29b79e0*/ bool SendUpdateEventToSelectedObject();
            /*0x29b8b28*/ void ProcessMousePress(UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData data);
            /*0x29b8e7c*/ UnityEngine.GameObject GetCurrentFocusedGameObject();

            enum InputMode
            {
                Mouse = 0,
                Buttons = 1,
            }
        }

        class TouchInputModule : UnityEngine.EventSystems.PointerInputModule
        {
            /*0x60*/ UnityEngine.Vector2 m_LastMousePosition;
            /*0x68*/ UnityEngine.Vector2 m_MousePosition;
            /*0x70*/ UnityEngine.EventSystems.PointerEventData m_InputPointerEvent;
            /*0x78*/ bool m_ForceModuleActive;

            /*0x29b8e84*/ TouchInputModule();
            /*0x29b8e88*/ bool get_allowActivationOnStandalone();
            /*0x29b8e90*/ void set_allowActivationOnStandalone(bool value);
            /*0x29b8e9c*/ bool get_forceModuleActive();
            /*0x29b8ea4*/ void set_forceModuleActive(bool value);
            /*0x29b8eb0*/ void UpdateModule();
            /*0x29b9000*/ bool IsModuleSupported();
            /*0x29b9038*/ bool ShouldActivateModule();
            /*0x29b90dc*/ bool UseFakeInput();
            /*0x29b910c*/ void Process();
            /*0x29b9134*/ void FakeTouches();
            /*0x29b9258*/ void ProcessTouchEvents();
            /*0x29b93a0*/ void ProcessTouchPress(UnityEngine.EventSystems.PointerEventData pointerEvent, bool pressed, bool released);
            /*0x29b9a08*/ void DeactivateModule();
            /*0x29b9a0c*/ string ToString();
        }

        enum MoveDirection
        {
            Left = 0,
            Up = 1,
            Right = 2,
            Down = 3,
            None = 4,
        }

        class RaycasterManager
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;

            static /*0x29b9e98*/ RaycasterManager();
            static /*0x29b9c5c*/ void AddRaycaster(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
            static /*0x29b9d70*/ System.Collections.Generic.List<UnityEngine.EventSystems.BaseRaycaster> GetRaycasters();
            static /*0x29b9dc8*/ void RemoveRaycasters(UnityEngine.EventSystems.BaseRaycaster baseRaycaster);
        }

        class BaseRaycaster : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster;

            /*0x29af174*/ BaseRaycaster();
            void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
            UnityEngine.Camera get_eventCamera();
            /*0x29b9f24*/ int get_priority();
            /*0x29b9f2c*/ int get_sortOrderPriority();
            /*0x29b9f34*/ int get_renderOrderPriority();
            /*0x29b0fa0*/ UnityEngine.EventSystems.BaseRaycaster get_rootRaycaster();
            /*0x29b9f3c*/ string ToString();
            /*0x29ba200*/ void OnEnable();
            /*0x29ba254*/ void OnDisable();
            /*0x29ba2a8*/ void OnCanvasHierarchyChanged();
            /*0x29ba2b4*/ void OnTransformParentChanged();
        }

        class Physics2DRaycaster : UnityEngine.EventSystems.PhysicsRaycaster
        {
            /*0x40*/ UnityEngine.RaycastHit2D[] m_Hits;

            /*0x29ba2c0*/ Physics2DRaycaster();
            /*0x29ba310*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);
        }

        class PhysicsRaycaster : UnityEngine.EventSystems.BaseRaycaster
        {
            static int kNoEventMaskSet = -1;
            /*0x20*/ UnityEngine.Camera m_EventCamera;
            /*0x28*/ UnityEngine.LayerMask m_EventMask;
            /*0x2c*/ int m_MaxRayIntersections;
            /*0x30*/ int m_LastMaxRayIntersections;
            /*0x38*/ UnityEngine.RaycastHit[] m_Hits;

            /*0x29ba2e8*/ PhysicsRaycaster();
            /*0x29baec0*/ UnityEngine.Camera get_eventCamera();
            /*0x29baf64*/ int get_depth();
            /*0x29badfc*/ int get_finalEventMask();
            /*0x29bb028*/ UnityEngine.LayerMask get_eventMask();
            /*0x29bb030*/ void set_eventMask(UnityEngine.LayerMask value);
            /*0x29bb038*/ int get_maxRayIntersections();
            /*0x29bb040*/ void set_maxRayIntersections(int value);
            /*0x29baafc*/ bool ComputeRayAndDistance(UnityEngine.EventSystems.PointerEventData eventData, ref UnityEngine.Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane);
            /*0x29bb048*/ void Raycast(UnityEngine.EventSystems.PointerEventData eventData, System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> resultAppendList);

            class RaycastHitComparer : System.Collections.Generic.IComparer<UnityEngine.RaycastHit>
            {
                static /*0x0*/ UnityEngine.EventSystems.PhysicsRaycaster.RaycastHitComparer instance;

                static /*0x29bb4a8*/ RaycastHitComparer();
                /*0x29bb4a0*/ RaycastHitComparer();
                /*0x29bb460*/ int Compare(UnityEngine.RaycastHit x, UnityEngine.RaycastHit y);
            }
        }

        struct RaycastResult
        {
            /*0x10*/ UnityEngine.GameObject m_GameObject;
            /*0x18*/ UnityEngine.EventSystems.BaseRaycaster module;
            /*0x20*/ float distance;
            /*0x24*/ float index;
            /*0x28*/ int depth;
            /*0x2c*/ int sortingGroupID;
            /*0x30*/ int sortingGroupOrder;
            /*0x34*/ int sortingLayer;
            /*0x38*/ int sortingOrder;
            /*0x3c*/ UnityEngine.Vector3 worldPosition;
            /*0x48*/ UnityEngine.Vector3 worldNormal;
            /*0x54*/ UnityEngine.Vector2 screenPosition;
            /*0x5c*/ int displayIndex;

            /*0x29bb50c*/ UnityEngine.GameObject get_gameObject();
            /*0x29bb514*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x29bb51c*/ bool get_isValid();
            /*0x29bb5b4*/ void Clear();
            /*0x29b001c*/ string ToString();
        }

        class UIBehaviour : UnityEngine.MonoBehaviour
        {
            /*0x29ae814*/ UIBehaviour();
            /*0x29bb65c*/ void Awake();
            /*0x29ac6e8*/ void OnEnable();
            /*0x29b1b48*/ void Start();
            /*0x29ac6f0*/ void OnDisable();
            /*0x29b1bf0*/ void OnDestroy();
            /*0x29bb660*/ bool IsActive();
            /*0x29bb668*/ void OnRectTransformDimensionsChange();
            /*0x29bb66c*/ void OnBeforeTransformParentChanged();
            /*0x29ba2bc*/ void OnTransformParentChanged();
            /*0x29bb670*/ void OnDidApplyAnimationProperties();
            /*0x29bb674*/ void OnCanvasGroupChanged();
            /*0x29ba2b0*/ void OnCanvasHierarchyChanged();
            /*0x29bb678*/ bool IsDestroyed();
        }
    }
}

namespace UnityEditor
{
    namespace Rendering
    {
        namespace BuiltIn
        {
            namespace ShaderGraph
            {
                class MaterialAccess
                {
                    static /*0x29bb6d4*/ int ReadMaterialRawRenderQueue(UnityEngine.Material mat);
                }
            }
        }

        namespace Universal
        {
            class MaterialAccess
            {
                static /*0x29bb6e8*/ int ReadMaterialRawRenderQueue(UnityEngine.Material mat);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

    struct __StaticArrayInitTypeSize=12
    {
    }
}
