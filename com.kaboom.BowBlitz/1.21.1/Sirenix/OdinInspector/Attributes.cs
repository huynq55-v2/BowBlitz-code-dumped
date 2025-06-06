class <Module>
{
}

namespace Sirenix
{
    namespace OdinInspector
    {
        class AssetListAttribute : System.Attribute
        {
            /*0x10*/ bool AutoPopulate;
            /*0x18*/ string Tags;
            /*0x20*/ string LayerNames;
            /*0x28*/ string AssetNamePrefix;
            /*0x30*/ string Path;
            /*0x38*/ string CustomFilterMethod;

            /*0x22876fc*/ AssetListAttribute();
        }

        class AssetSelectorAttribute : System.Attribute
        {
            /*0x10*/ bool IsUniqueList;
            /*0x11*/ bool DrawDropdownForListElements;
            /*0x12*/ bool DisableListAddButtonBehaviour;
            /*0x13*/ bool ExcludeExistingValuesInList;
            /*0x14*/ bool ExpandAllMenuItems;
            /*0x15*/ bool FlattenTreeView;
            /*0x18*/ int DropdownWidth;
            /*0x1c*/ int DropdownHeight;
            /*0x20*/ string DropdownTitle;
            /*0x28*/ string[] SearchInFolders;
            /*0x30*/ string Filter;

            /*0x2287900*/ AssetSelectorAttribute();
            /*0x2287724*/ void set_Paths(string value);
            /*0x22878a0*/ string get_Paths();

            class <>c
            {
                static /*0x0*/ Sirenix.OdinInspector.AssetSelectorAttribute.<> <>9;
                static /*0x8*/ System.Func<string, string> <>9__12_0;

                static /*0x2287918*/ <>c();
                /*0x228797c*/ <>c();
                /*0x2287984*/ string <set_Paths>b__12_0(string x);
            }
        }

        class AssetsOnlyAttribute : System.Attribute
        {
            /*0x2287a24*/ AssetsOnlyAttribute();
        }

        class BoxGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x31*/ bool ShowLabel;
            /*0x32*/ bool CenterLabel;
            /*0x38*/ string LabelText;

            /*0x2287a2c*/ BoxGroupAttribute(string group, bool showLabel, bool centerLabel, float order);
            /*0x2287adc*/ BoxGroupAttribute();
            /*0x2287b30*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class ButtonAttribute : Sirenix.OdinInspector.ShowInInspectorAttribute
        {
            /*0x10*/ string Name;
            /*0x18*/ Sirenix.OdinInspector.ButtonStyle Style;
            /*0x1c*/ bool Expanded;
            /*0x1d*/ bool DisplayParameters;
            /*0x1e*/ bool DirtyOnClick;
            /*0x1f*/ bool <HasDefinedButtonHeight>k__BackingField;
            /*0x20*/ bool <HasDefinedIcon>k__BackingField;
            /*0x21*/ bool <HasDefinedButtonIconAlignment>k__BackingField;
            /*0x22*/ bool <HasDefinedButtonAlignment>k__BackingField;
            /*0x23*/ bool <HasDefinedStretch>k__BackingField;
            /*0x24*/ int buttonHeight;
            /*0x28*/ bool drawResult;
            /*0x29*/ bool drawResultIsSet;
            /*0x2a*/ bool stretch;
            /*0x2c*/ Sirenix.OdinInspector.SdfIconType icon;
            /*0x30*/ string iconGetter;
            /*0x38*/ Sirenix.OdinInspector.IconAlignment buttonIconAlignment;
            /*0x3c*/ float buttonAlignment;

            /*0x2287cec*/ ButtonAttribute();
            /*0x2287d18*/ ButtonAttribute(Sirenix.OdinInspector.ButtonSizes size);
            /*0x2287d54*/ ButtonAttribute(int buttonSize);
            /*0x2287d90*/ ButtonAttribute(string name);
            /*0x2287dc0*/ ButtonAttribute(string name, Sirenix.OdinInspector.ButtonSizes buttonSize);
            /*0x2287e00*/ ButtonAttribute(string name, int buttonSize);
            /*0x2287e40*/ ButtonAttribute(Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287e74*/ ButtonAttribute(int buttonSize, Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287eb8*/ ButtonAttribute(Sirenix.OdinInspector.ButtonSizes size, Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287efc*/ ButtonAttribute(string name, Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287f34*/ ButtonAttribute(string name, Sirenix.OdinInspector.ButtonSizes buttonSize, Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287f84*/ ButtonAttribute(string name, int buttonSize, Sirenix.OdinInspector.ButtonStyle parameterBtnStyle);
            /*0x2287fd4*/ ButtonAttribute(Sirenix.OdinInspector.SdfIconType icon, Sirenix.OdinInspector.IconAlignment iconAlignment);
            /*0x228801c*/ ButtonAttribute(Sirenix.OdinInspector.SdfIconType icon);
            /*0x2288058*/ ButtonAttribute(Sirenix.OdinInspector.SdfIconType icon, string name);
            /*0x2287be8*/ int get_ButtonHeight();
            /*0x2287bf0*/ void set_ButtonHeight(int value);
            /*0x2287c00*/ Sirenix.OdinInspector.SdfIconType get_Icon();
            /*0x2287c08*/ void set_Icon(Sirenix.OdinInspector.SdfIconType value);
            /*0x2287c18*/ Sirenix.OdinInspector.IconAlignment get_IconAlignment();
            /*0x2287c20*/ void set_IconAlignment(Sirenix.OdinInspector.IconAlignment value);
            /*0x2287c30*/ float get_ButtonAlignment();
            /*0x2287c38*/ void set_ButtonAlignment(float value);
            /*0x2287c48*/ bool get_Stretch();
            /*0x2287c50*/ void set_Stretch(bool value);
            /*0x2287c64*/ void set_DrawResult(bool value);
            /*0x2287c78*/ bool get_DrawResult();
            /*0x2287c80*/ bool get_DrawResultIsSet();
            /*0x2287c88*/ bool get_HasDefinedButtonHeight();
            /*0x2287c90*/ void set_HasDefinedButtonHeight(bool value);
            /*0x2287c9c*/ bool get_HasDefinedIcon();
            /*0x2287ca4*/ void set_HasDefinedIcon(bool value);
            /*0x2287cb0*/ bool get_HasDefinedButtonIconAlignment();
            /*0x2287cb8*/ void set_HasDefinedButtonIconAlignment(bool value);
            /*0x2287cc4*/ bool get_HasDefinedButtonAlignment();
            /*0x2287ccc*/ void set_HasDefinedButtonAlignment(bool value);
            /*0x2287cd8*/ bool get_HasDefinedStretch();
            /*0x2287ce0*/ void set_HasDefinedStretch(bool value);
        }

        class ButtonGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x34*/ int ButtonHeight;
            /*0x38*/ bool <HasDefinedButtonIconAlignment>k__BackingField;
            /*0x39*/ bool <HasDefinedButtonAlignment>k__BackingField;
            /*0x3a*/ bool <HasDefinedStretch>k__BackingField;
            /*0x3c*/ Sirenix.OdinInspector.IconAlignment buttonIconAlignment;
            /*0x40*/ int buttonAlignment;
            /*0x44*/ bool stretch;

            /*0x2288120*/ ButtonGroupAttribute(string group, float order);
            /*0x2288098*/ Sirenix.OdinInspector.IconAlignment get_IconAlignment();
            /*0x22880a0*/ void set_IconAlignment(Sirenix.OdinInspector.IconAlignment value);
            /*0x22880b0*/ int get_ButtonAlignment();
            /*0x22880b8*/ void set_ButtonAlignment(int value);
            /*0x22880c8*/ bool get_Stretch();
            /*0x22880d0*/ void set_Stretch(bool value);
            /*0x22880e4*/ bool get_HasDefinedButtonIconAlignment();
            /*0x22880ec*/ void set_HasDefinedButtonIconAlignment(bool value);
            /*0x22880f8*/ bool get_HasDefinedButtonAlignment();
            /*0x2288100*/ void set_HasDefinedButtonAlignment(bool value);
            /*0x228810c*/ bool get_HasDefinedStretch();
            /*0x2288114*/ void set_HasDefinedStretch(bool value);
        }

        enum ButtonStyle
        {
            CompactBox = 0,
            FoldoutButton = 1,
            Box = 2,
        }

        class ChildGameObjectsOnlyAttribute : System.Attribute
        {
            /*0x10*/ bool IncludeSelf;
            /*0x11*/ bool IncludeInactive;

            /*0x2288124*/ ChildGameObjectsOnlyAttribute();
        }

        class ColorPaletteAttribute : System.Attribute
        {
            /*0x10*/ string PaletteName;
            /*0x18*/ bool ShowAlpha;

            /*0x2288134*/ ColorPaletteAttribute();
            /*0x2288158*/ ColorPaletteAttribute(string paletteName);
        }

        class CustomContextMenuAttribute : System.Attribute
        {
            /*0x10*/ string MenuItem;
            /*0x18*/ string Action;

            /*0x2288198*/ CustomContextMenuAttribute(string menuItem, string action);
            /*0x2288188*/ string get_MethodName();
            /*0x2288190*/ void set_MethodName(string value);
        }

        class CustomValueDrawerAttribute : System.Attribute
        {
            /*0x10*/ string Action;

            /*0x22881d4*/ CustomValueDrawerAttribute(string action);
            /*0x22881c4*/ string get_MethodName();
            /*0x22881cc*/ void set_MethodName(string value);
        }

        class DelayedPropertyAttribute : System.Attribute
        {
            /*0x22881fc*/ DelayedPropertyAttribute();
        }

        class DetailedInfoBoxAttribute : System.Attribute
        {
            /*0x10*/ string Message;
            /*0x18*/ string Details;
            /*0x20*/ Sirenix.OdinInspector.InfoMessageType InfoMessageType;
            /*0x28*/ string VisibleIf;

            /*0x2288204*/ DetailedInfoBoxAttribute(string message, string details, Sirenix.OdinInspector.InfoMessageType infoMessageType, string visibleIf);
        }

        class DictionaryDrawerSettings : System.Attribute
        {
            /*0x10*/ string KeyLabel;
            /*0x18*/ string ValueLabel;
            /*0x20*/ Sirenix.OdinInspector.DictionaryDisplayOptions DisplayMode;
            /*0x24*/ bool IsReadOnly;
            /*0x28*/ float KeyColumnWidth;

            /*0x2288248*/ DictionaryDrawerSettings();
        }

        class DisableContextMenuAttribute : System.Attribute
        {
            /*0x10*/ bool DisableForMember;
            /*0x11*/ bool DisableForCollectionElements;

            /*0x22882c4*/ DisableContextMenuAttribute(bool disableForMember, bool disableCollectionElements);
        }

        class DisableIfAttribute : System.Attribute
        {
            /*0x10*/ string Condition;
            /*0x18*/ object Value;

            /*0x2288304*/ DisableIfAttribute(string condition);
            /*0x228832c*/ DisableIfAttribute(string condition, object optionalValue);
            /*0x22882f4*/ string get_MemberName();
            /*0x22882fc*/ void set_MemberName(string value);
        }

        class DisableInAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x2288358*/ DisableInAttribute(Sirenix.OdinInspector.PrefabKind prefabKind);
        }

        class DisableInEditorModeAttribute : System.Attribute
        {
            /*0x2288380*/ DisableInEditorModeAttribute();
        }

        class DisableInInlineEditorsAttribute : System.Attribute
        {
            /*0x2288388*/ DisableInInlineEditorsAttribute();
        }

        class DisableInNonPrefabsAttribute : System.Attribute
        {
            /*0x2288390*/ DisableInNonPrefabsAttribute();
        }

        class DisableInPlayModeAttribute : System.Attribute
        {
            /*0x2288398*/ DisableInPlayModeAttribute();
        }

        class DisableInPrefabAssetsAttribute : System.Attribute
        {
            /*0x22883a0*/ DisableInPrefabAssetsAttribute();
        }

        class DisableInPrefabInstancesAttribute : System.Attribute
        {
            /*0x22883a8*/ DisableInPrefabInstancesAttribute();
        }

        class DisableInPrefabsAttribute : System.Attribute
        {
            /*0x22883b0*/ DisableInPrefabsAttribute();
        }

        class DisallowModificationsInAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x22883b8*/ DisallowModificationsInAttribute(Sirenix.OdinInspector.PrefabKind kind);
        }

        class DisplayAsStringAttribute : System.Attribute
        {
            /*0x10*/ bool Overflow;

            /*0x22883e0*/ DisplayAsStringAttribute();
            /*0x2288400*/ DisplayAsStringAttribute(bool overflow);
        }

        class DoNotDrawAsReferenceAttribute : System.Attribute
        {
            /*0x2288428*/ DoNotDrawAsReferenceAttribute();
        }

        class DontApplyToListElementsAttribute : System.Attribute
        {
            /*0x2288430*/ DontApplyToListElementsAttribute();
        }

        class DontValidateAttribute : System.Attribute
        {
            /*0x2288438*/ DontValidateAttribute();
        }

        class DrawWithUnityAttribute : System.Attribute
        {
            /*0x2288440*/ DrawWithUnityAttribute();
        }

        class EnableGUIAttribute : System.Attribute
        {
            /*0x2288448*/ EnableGUIAttribute();
        }

        class EnableIfAttribute : System.Attribute
        {
            /*0x10*/ string Condition;
            /*0x18*/ object Value;

            /*0x2288460*/ EnableIfAttribute(string condition);
            /*0x2288488*/ EnableIfAttribute(string condition, object optionalValue);
            /*0x2288450*/ string get_MemberName();
            /*0x2288458*/ void set_MemberName(string value);
        }

        class EnableInAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x22884b4*/ EnableInAttribute(Sirenix.OdinInspector.PrefabKind prefabKind);
        }

        class EnumPagingAttribute : System.Attribute
        {
            /*0x22884dc*/ EnumPagingAttribute();
        }

        class EnumToggleButtonsAttribute : System.Attribute
        {
            /*0x22884e4*/ EnumToggleButtonsAttribute();
        }

        class FilePathAttribute : System.Attribute
        {
            /*0x10*/ bool AbsolutePath;
            /*0x18*/ string Extensions;
            /*0x20*/ string ParentFolder;
            /*0x28*/ bool RequireValidPath;
            /*0x29*/ bool RequireExistingPath;
            /*0x2a*/ bool UseBackslashes;
            /*0x2b*/ bool <ReadOnly>k__BackingField;

            /*0x2288500*/ FilePathAttribute();
            /*0x22884ec*/ bool get_ReadOnly();
            /*0x22884f4*/ void set_ReadOnly(bool value);
        }

        class FolderPathAttribute : System.Attribute
        {
            /*0x10*/ bool AbsolutePath;
            /*0x18*/ string ParentFolder;
            /*0x20*/ bool RequireValidPath;
            /*0x21*/ bool RequireExistingPath;
            /*0x22*/ bool UseBackslashes;

            /*0x2288508*/ FolderPathAttribute();
        }

        class FoldoutGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x31*/ bool expanded;
            /*0x32*/ bool <HasDefinedExpanded>k__BackingField;

            /*0x2288540*/ FoldoutGroupAttribute(string groupName, float order);
            /*0x2288544*/ FoldoutGroupAttribute(string groupName, bool expanded, float order);
            /*0x2288510*/ bool get_Expanded();
            /*0x2288518*/ void set_Expanded(bool value);
            /*0x228852c*/ bool get_HasDefinedExpanded();
            /*0x2288534*/ void set_HasDefinedExpanded(bool value);
            /*0x2288570*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class GUIColorAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.Color Color;
            /*0x20*/ string GetColor;

            /*0x228861c*/ GUIColorAttribute(float r, float g, float b, float a);
            /*0x228865c*/ GUIColorAttribute(string getColor);
        }

        class HideDuplicateReferenceBoxAttribute : System.Attribute
        {
            /*0x2288684*/ HideDuplicateReferenceBoxAttribute();
        }

        class HideIfAttribute : System.Attribute
        {
            /*0x10*/ string Condition;
            /*0x18*/ object Value;
            /*0x20*/ bool Animate;

            /*0x228869c*/ HideIfAttribute(string condition, bool animate);
            /*0x22886cc*/ HideIfAttribute(string condition, object optionalValue, bool animate);
            /*0x228868c*/ string get_MemberName();
            /*0x2288694*/ void set_MemberName(string value);
        }

        class HideIfGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x38*/ object Value;

            /*0x228878c*/ HideIfGroupAttribute(string path, bool animate);
            /*0x22887c0*/ HideIfGroupAttribute(string path, object value, bool animate);
            /*0x2288708*/ bool get_Animate();
            /*0x2288710*/ void set_Animate(bool value);
            /*0x228871c*/ string get_MemberName();
            /*0x228877c*/ void set_MemberName(string value);
            /*0x228874c*/ string get_Condition();
            /*0x2288784*/ void set_Condition(string value);
            /*0x22887f4*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class HideInAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x2288884*/ HideInAttribute(Sirenix.OdinInspector.PrefabKind prefabKind);
        }

        class HideInEditorModeAttribute : System.Attribute
        {
            /*0x22888ac*/ HideInEditorModeAttribute();
        }

        class HideInInlineEditorsAttribute : System.Attribute
        {
            /*0x22888b4*/ HideInInlineEditorsAttribute();
        }

        class HideInNonPrefabsAttribute : System.Attribute
        {
            /*0x22888bc*/ HideInNonPrefabsAttribute();
        }

        class HideInPlayModeAttribute : System.Attribute
        {
            /*0x22888c4*/ HideInPlayModeAttribute();
        }

        class HideInPrefabAssetsAttribute : System.Attribute
        {
            /*0x22888cc*/ HideInPrefabAssetsAttribute();
        }

        class HideInPrefabInstancesAttribute : System.Attribute
        {
            /*0x22888d4*/ HideInPrefabInstancesAttribute();
        }

        class HideInPrefabsAttribute : System.Attribute
        {
            /*0x22888dc*/ HideInPrefabsAttribute();
        }

        class HideInTablesAttribute : System.Attribute
        {
            /*0x22888e4*/ HideInTablesAttribute();
        }

        class HideLabelAttribute : System.Attribute
        {
            /*0x22888ec*/ HideLabelAttribute();
        }

        class HideMonoScriptAttribute : System.Attribute
        {
            /*0x22888f4*/ HideMonoScriptAttribute();
        }

        class HideNetworkBehaviourFieldsAttribute : System.Attribute
        {
            /*0x22888fc*/ HideNetworkBehaviourFieldsAttribute();
        }

        class HideReferenceObjectPickerAttribute : System.Attribute
        {
            /*0x2288904*/ HideReferenceObjectPickerAttribute();
        }

        class HorizontalGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x34*/ float Width;
            /*0x38*/ float MarginLeft;
            /*0x3c*/ float MarginRight;
            /*0x40*/ float PaddingLeft;
            /*0x44*/ float PaddingRight;
            /*0x48*/ float MinWidth;
            /*0x4c*/ float MaxWidth;
            /*0x50*/ string Title;
            /*0x58*/ float LabelWidth;

            /*0x228890c*/ HorizontalGroupAttribute(string group, float width, int marginLeft, int marginRight, float order);
            /*0x2288950*/ HorizontalGroupAttribute(float width, int marginLeft, int marginRight, float order);
            /*0x22889d0*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class IndentAttribute : System.Attribute
        {
            /*0x10*/ int IndentLevel;

            /*0x2288ad4*/ IndentAttribute(int indentLevel);
        }

        class InfoBoxAttribute : System.Attribute
        {
            /*0x10*/ string Message;
            /*0x18*/ Sirenix.OdinInspector.InfoMessageType InfoMessageType;
            /*0x20*/ string VisibleIf;
            /*0x28*/ bool GUIAlwaysEnabled;
            /*0x30*/ string IconColor;
            /*0x38*/ bool <HasDefinedIcon>k__BackingField;
            /*0x3c*/ Sirenix.OdinInspector.SdfIconType icon;

            /*0x2288b28*/ InfoBoxAttribute(string message, Sirenix.OdinInspector.InfoMessageType infoMessageType, string visibleIfMemberName);
            /*0x2288b68*/ InfoBoxAttribute(string message, string visibleIfMemberName);
            /*0x2288ba0*/ InfoBoxAttribute(string message, Sirenix.OdinInspector.SdfIconType icon, string visibleIfMemberName);
            /*0x2288afc*/ Sirenix.OdinInspector.SdfIconType get_Icon();
            /*0x2288b04*/ void set_Icon(Sirenix.OdinInspector.SdfIconType value);
            /*0x2288b14*/ bool get_HasDefinedIcon();
            /*0x2288b1c*/ void set_HasDefinedIcon(bool value);
        }

        class InlineButtonAttribute : System.Attribute
        {
            /*0x10*/ string Action;
            /*0x18*/ string Label;
            /*0x20*/ string ShowIf;
            /*0x28*/ bool <HasDefinedIcon>k__BackingField;
            /*0x29*/ bool <HasDefinedIconAlignment>k__BackingField;
            /*0x2c*/ Sirenix.OdinInspector.SdfIconType icon;
            /*0x30*/ Sirenix.OdinInspector.IconAlignment buttonIconAlignment;

            /*0x2288c54*/ InlineButtonAttribute(string action, string label);
            /*0x2288c80*/ InlineButtonAttribute(string action, Sirenix.OdinInspector.SdfIconType icon, string label);
            /*0x2288bec*/ string get_MemberMethod();
            /*0x2288bf4*/ void set_MemberMethod(string value);
            /*0x2288bfc*/ Sirenix.OdinInspector.SdfIconType get_Icon();
            /*0x2288c04*/ void set_Icon(Sirenix.OdinInspector.SdfIconType value);
            /*0x2288c14*/ Sirenix.OdinInspector.IconAlignment get_IconAlignment();
            /*0x2288c1c*/ void set_IconAlignment(Sirenix.OdinInspector.IconAlignment value);
            /*0x2288c2c*/ bool get_HasDefinedIcon();
            /*0x2288c34*/ void set_HasDefinedIcon(bool value);
            /*0x2288c40*/ bool get_HasDefinedIconAlignment();
            /*0x2288c48*/ void set_HasDefinedIconAlignment(bool value);
        }

        class InlineEditorAttribute : System.Attribute
        {
            /*0x10*/ bool expanded;
            /*0x11*/ bool DrawHeader;
            /*0x12*/ bool DrawGUI;
            /*0x13*/ bool DrawPreview;
            /*0x14*/ float MaxHeight;
            /*0x18*/ float PreviewWidth;
            /*0x1c*/ float PreviewHeight;
            /*0x20*/ bool IncrementInlineEditorDrawerDepth;
            /*0x24*/ Sirenix.OdinInspector.InlineEditorObjectFieldModes ObjectFieldMode;
            /*0x28*/ bool DisableGUIForVCSLockedAssets;
            /*0x29*/ bool <ExpandedHasValue>k__BackingField;

            /*0x2288cf4*/ InlineEditorAttribute(Sirenix.OdinInspector.InlineEditorModes inlineEditorMode, Sirenix.OdinInspector.InlineEditorObjectFieldModes objectFieldMode);
            /*0x2288df4*/ InlineEditorAttribute(Sirenix.OdinInspector.InlineEditorObjectFieldModes objectFieldMode);
            /*0x2288cc4*/ bool get_Expanded();
            /*0x2288ccc*/ void set_Expanded(bool value);
            /*0x2288ce0*/ bool get_ExpandedHasValue();
            /*0x2288ce8*/ void set_ExpandedHasValue(bool value);
        }

        class InlinePropertyAttribute : System.Attribute
        {
            /*0x10*/ int LabelWidth;

            /*0x2288e38*/ InlinePropertyAttribute();
        }

        class LabelTextAttribute : System.Attribute
        {
            /*0x10*/ string Text;
            /*0x18*/ bool NicifyText;
            /*0x20*/ string IconColor;
            /*0x28*/ bool <HasDefinedIcon>k__BackingField;
            /*0x2c*/ Sirenix.OdinInspector.SdfIconType icon;

            /*0x2288e6c*/ LabelTextAttribute(string text);
            /*0x2288e94*/ LabelTextAttribute(string text, bool nicifyText);
            /*0x2288ec4*/ LabelTextAttribute(string text, Sirenix.OdinInspector.SdfIconType icon);
            /*0x2288efc*/ LabelTextAttribute(string text, bool nicifyText, Sirenix.OdinInspector.SdfIconType icon);
            /*0x2288e40*/ Sirenix.OdinInspector.SdfIconType get_Icon();
            /*0x2288e48*/ void set_Icon(Sirenix.OdinInspector.SdfIconType value);
            /*0x2288e58*/ bool get_HasDefinedIcon();
            /*0x2288e60*/ void set_HasDefinedIcon(bool value);
        }

        class LabelWidthAttribute : System.Attribute
        {
            /*0x10*/ float Width;

            /*0x2288f44*/ LabelWidthAttribute(float width);
        }

        class ListDrawerSettingsAttribute : System.Attribute
        {
            /*0x10*/ bool HideAddButton;
            /*0x11*/ bool HideRemoveButton;
            /*0x18*/ string ListElementLabelName;
            /*0x20*/ string CustomAddFunction;
            /*0x28*/ string CustomRemoveIndexFunction;
            /*0x30*/ string CustomRemoveElementFunction;
            /*0x38*/ string OnBeginListElementGUI;
            /*0x40*/ string OnEndListElementGUI;
            /*0x48*/ bool AlwaysAddDefaultValue;
            /*0x49*/ bool AddCopiesLastElement;
            /*0x50*/ string ElementColor;
            /*0x58*/ string onTitleBarGUI;
            /*0x60*/ int numberOfItemsPerPage;
            /*0x64*/ bool paging;
            /*0x65*/ bool draggable;
            /*0x66*/ bool isReadOnly;
            /*0x67*/ bool showItemCount;
            /*0x68*/ bool pagingHasValue;
            /*0x69*/ bool draggableHasValue;
            /*0x6a*/ bool isReadOnlyHasValue;
            /*0x6b*/ bool showItemCountHasValue;
            /*0x6c*/ bool expanded;
            /*0x6d*/ bool expandedHasValue;
            /*0x6e*/ bool numberOfItemsPerPageHasValue;
            /*0x6f*/ bool showIndexLabels;
            /*0x70*/ bool showIndexLabelsHasValue;

            /*0x2289074*/ ListDrawerSettingsAttribute();
            /*0x2288f6c*/ bool get_ShowPaging();
            /*0x2288f74*/ void set_ShowPaging(bool value);
            /*0x2288f88*/ bool get_DraggableItems();
            /*0x2288f90*/ void set_DraggableItems(bool value);
            /*0x2288fa4*/ int get_NumberOfItemsPerPage();
            /*0x2288fac*/ void set_NumberOfItemsPerPage(int value);
            /*0x2288fbc*/ bool get_IsReadOnly();
            /*0x2288fc4*/ void set_IsReadOnly(bool value);
            /*0x2288fd8*/ bool get_ShowItemCount();
            /*0x2288fe0*/ void set_ShowItemCount(bool value);
            /*0x2288ff4*/ bool get_Expanded();
            /*0x2288ffc*/ void set_Expanded(bool value);
            /*0x2289010*/ bool get_ShowIndexLabels();
            /*0x2289018*/ void set_ShowIndexLabels(bool value);
            /*0x228902c*/ string get_OnTitleBarGUI();
            /*0x2289034*/ void set_OnTitleBarGUI(string value);
            /*0x228903c*/ bool get_PagingHasValue();
            /*0x2289044*/ bool get_ShowItemCountHasValue();
            /*0x228904c*/ bool get_NumberOfItemsPerPageHasValue();
            /*0x2289054*/ bool get_DraggableHasValue();
            /*0x228905c*/ bool get_IsReadOnlyHasValue();
            /*0x2289064*/ bool get_ExpandedHasValue();
            /*0x228906c*/ bool get_ShowIndexLabelsHasValue();
        }

        class MaxValueAttribute : System.Attribute
        {
            /*0x10*/ double MaxValue;
            /*0x18*/ string Expression;

            /*0x228907c*/ MaxValueAttribute(double maxValue);
            /*0x22890a4*/ MaxValueAttribute(string expression);
        }

        class MinMaxSliderAttribute : System.Attribute
        {
            /*0x10*/ float MinValue;
            /*0x14*/ float MaxValue;
            /*0x18*/ string MinValueGetter;
            /*0x20*/ string MaxValueGetter;
            /*0x28*/ string MinMaxValueGetter;
            /*0x30*/ bool ShowFields;

            /*0x22890fc*/ MinMaxSliderAttribute(float minValue, float maxValue, bool showFields);
            /*0x2289138*/ MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields);
            /*0x2289178*/ MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields);
            /*0x22891b8*/ MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields);
            /*0x22891f4*/ MinMaxSliderAttribute(string minMaxValueGetter, bool showFields);
            /*0x22890cc*/ string get_MinMember();
            /*0x22890d4*/ void set_MinMember(string value);
            /*0x22890dc*/ string get_MaxMember();
            /*0x22890e4*/ void set_MaxMember(string value);
            /*0x22890ec*/ string get_MinMaxMember();
            /*0x22890f4*/ void set_MinMaxMember(string value);
        }

        class MinValueAttribute : System.Attribute
        {
            /*0x10*/ double MinValue;
            /*0x18*/ string Expression;

            /*0x2289224*/ MinValueAttribute(double minValue);
            /*0x228924c*/ MinValueAttribute(string expression);
        }

        class MultiLinePropertyAttribute : System.Attribute
        {
            /*0x10*/ int Lines;

            /*0x2289274*/ MultiLinePropertyAttribute(int lines);
        }

        class OnCollectionChangedAttribute : System.Attribute
        {
            /*0x10*/ string Before;
            /*0x18*/ string After;

            /*0x22892f0*/ OnCollectionChangedAttribute();
            /*0x22892f8*/ OnCollectionChangedAttribute(string after);
            /*0x2289320*/ OnCollectionChangedAttribute(string before, string after);
        }

        class OnInspectorDisposeAttribute : Sirenix.OdinInspector.ShowInInspectorAttribute
        {
            /*0x10*/ string Action;

            /*0x228934c*/ OnInspectorDisposeAttribute();
            /*0x2289354*/ OnInspectorDisposeAttribute(string action);
        }

        class OnInspectorGUIAttribute : Sirenix.OdinInspector.ShowInInspectorAttribute
        {
            /*0x10*/ string Prepend;
            /*0x18*/ string Append;
            /*0x20*/ string PrependMethodName;
            /*0x28*/ string AppendMethodName;

            /*0x228937c*/ OnInspectorGUIAttribute();
            /*0x2289384*/ OnInspectorGUIAttribute(string action, bool append);
            /*0x22893c0*/ OnInspectorGUIAttribute(string prepend, string append);
        }

        class OnInspectorInitAttribute : Sirenix.OdinInspector.ShowInInspectorAttribute
        {
            /*0x10*/ string Action;

            /*0x22893ec*/ OnInspectorInitAttribute();
            /*0x22893f4*/ OnInspectorInitAttribute(string action);
        }

        class OnStateUpdateAttribute : System.Attribute
        {
            /*0x10*/ string Action;

            /*0x228941c*/ OnStateUpdateAttribute(string action);
        }

        class OnValueChangedAttribute : System.Attribute
        {
            /*0x10*/ string Action;
            /*0x18*/ bool IncludeChildren;
            /*0x19*/ bool InvokeOnUndoRedo;
            /*0x1a*/ bool InvokeOnInitialize;

            /*0x2289454*/ OnValueChangedAttribute(string action, bool includeChildren);
            /*0x2289444*/ string get_MethodName();
            /*0x228944c*/ void set_MethodName(string value);
        }

        class OptionalAttribute : System.Attribute
        {
            /*0x228948c*/ OptionalAttribute();
        }

        class PreviewFieldAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.ObjectFieldAlignment alignment;
            /*0x14*/ bool alignmentHasValue;
            /*0x18*/ float Height;

            /*0x22894b4*/ PreviewFieldAttribute();
            /*0x22894d0*/ PreviewFieldAttribute(float height);
            /*0x22894f8*/ PreviewFieldAttribute(float height, Sirenix.OdinInspector.ObjectFieldAlignment alignment);
            /*0x2289538*/ PreviewFieldAttribute(Sirenix.OdinInspector.ObjectFieldAlignment alignment);
            /*0x2289494*/ Sirenix.OdinInspector.ObjectFieldAlignment get_Alignment();
            /*0x228949c*/ void set_Alignment(Sirenix.OdinInspector.ObjectFieldAlignment value);
            /*0x22894ac*/ bool get_AlignmentHasValue();
        }

        class ProgressBarAttribute : System.Attribute
        {
            /*0x10*/ double Min;
            /*0x18*/ double Max;
            /*0x20*/ string MinGetter;
            /*0x28*/ string MaxGetter;
            /*0x30*/ float R;
            /*0x34*/ float G;
            /*0x38*/ float B;
            /*0x3c*/ int Height;
            /*0x40*/ string ColorGetter;
            /*0x48*/ string BackgroundColorGetter;
            /*0x50*/ bool Segmented;
            /*0x58*/ string CustomValueStringGetter;
            /*0x60*/ bool drawValueLabel;
            /*0x64*/ UnityEngine.TextAlignment valueLabelAlignment;
            /*0x68*/ bool <DrawValueLabelHasValue>k__BackingField;
            /*0x69*/ bool <ValueLabelAlignmentHasValue>k__BackingField;

            /*0x22895b8*/ ProgressBarAttribute(double min, double max, float r, float g, float b);
            /*0x2289624*/ ProgressBarAttribute(string minGetter, double max, float r, float g, float b);
            /*0x2289694*/ ProgressBarAttribute(double min, string maxGetter, float r, float g, float b);
            /*0x2289704*/ ProgressBarAttribute(string minGetter, string maxGetter, float r, float g, float b);
            /*0x2289568*/ string get_MinMember();
            /*0x2289570*/ void set_MinMember(string value);
            /*0x2289578*/ string get_MaxMember();
            /*0x2289580*/ void set_MaxMember(string value);
            /*0x2289588*/ string get_ColorMember();
            /*0x2289590*/ void set_ColorMember(string value);
            /*0x2289598*/ string get_BackgroundColorMember();
            /*0x22895a0*/ void set_BackgroundColorMember(string value);
            /*0x22895a8*/ string get_CustomValueStringMember();
            /*0x22895b0*/ void set_CustomValueStringMember(string value);
            /*0x2289770*/ bool get_DrawValueLabel();
            /*0x2289778*/ void set_DrawValueLabel(bool value);
            /*0x228978c*/ bool get_DrawValueLabelHasValue();
            /*0x2289794*/ void set_DrawValueLabelHasValue(bool value);
            /*0x22897a0*/ UnityEngine.TextAlignment get_ValueLabelAlignment();
            /*0x22897a8*/ void set_ValueLabelAlignment(UnityEngine.TextAlignment value);
            /*0x22897b8*/ bool get_ValueLabelAlignmentHasValue();
            /*0x22897c0*/ void set_ValueLabelAlignmentHasValue(bool value);
            /*0x22897cc*/ UnityEngine.Color get_Color();
        }

        class PropertyGroupAttribute : System.Attribute
        {
            /*0x10*/ string GroupID;
            /*0x18*/ string GroupName;
            /*0x20*/ float Order;
            /*0x24*/ bool HideWhenChildrenAreInvisible;
            /*0x28*/ string VisibleIf;
            /*0x30*/ bool AnimateVisibility;

            /*0x2287a58*/ PropertyGroupAttribute(string groupId, float order);
            /*0x22887b8*/ PropertyGroupAttribute(string groupId);
            /*0x22897dc*/ Sirenix.OdinInspector.PropertyGroupAttribute Combine(Sirenix.OdinInspector.PropertyGroupAttribute other);
            /*0x22899dc*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class PropertyOrderAttribute : System.Attribute
        {
            /*0x10*/ float Order;

            /*0x22899e0*/ PropertyOrderAttribute();
            /*0x22899e8*/ PropertyOrderAttribute(float order);
        }

        class PropertyRangeAttribute : System.Attribute
        {
            /*0x10*/ double Min;
            /*0x18*/ double Max;
            /*0x20*/ string MinGetter;
            /*0x28*/ string MaxGetter;

            /*0x2289a30*/ PropertyRangeAttribute(double min, double max);
            /*0x2289a70*/ PropertyRangeAttribute(string minGetter, double max);
            /*0x2289aa8*/ PropertyRangeAttribute(double min, string maxGetter);
            /*0x2289ae0*/ PropertyRangeAttribute(string minGetter, string maxGetter);
            /*0x2289a10*/ string get_MinMember();
            /*0x2289a18*/ void set_MinMember(string value);
            /*0x2289a20*/ string get_MaxMember();
            /*0x2289a28*/ void set_MaxMember(string value);
        }

        class PropertySpaceAttribute : System.Attribute
        {
            /*0x10*/ float SpaceBefore;
            /*0x14*/ float SpaceAfter;

            /*0x2289b0c*/ PropertySpaceAttribute();
            /*0x2289b30*/ PropertySpaceAttribute(float spaceBefore);
            /*0x2289b5c*/ PropertySpaceAttribute(float spaceBefore, float spaceAfter);
        }

        class PropertyTooltipAttribute : System.Attribute
        {
            /*0x10*/ string Tooltip;

            /*0x2289b88*/ PropertyTooltipAttribute(string tooltip);
        }

        class ReadOnlyAttribute : System.Attribute
        {
            /*0x2289bb0*/ ReadOnlyAttribute();
        }

        class RequiredAttribute : System.Attribute
        {
            /*0x10*/ string ErrorMessage;
            /*0x18*/ Sirenix.OdinInspector.InfoMessageType MessageType;

            /*0x2289bb8*/ RequiredAttribute();
            /*0x2289bd8*/ RequiredAttribute(string errorMessage, Sirenix.OdinInspector.InfoMessageType messageType);
            /*0x2289c08*/ RequiredAttribute(string errorMessage);
            /*0x2289c38*/ RequiredAttribute(Sirenix.OdinInspector.InfoMessageType messageType);
        }

        class RequiredInAttribute : System.Attribute
        {
            /*0x10*/ string ErrorMessage;
            /*0x18*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x2289c60*/ RequiredInAttribute(Sirenix.OdinInspector.PrefabKind kind);
        }

        class RequiredInPrefabAssetsAttribute : System.Attribute
        {
            /*0x10*/ string ErrorMessage;
            /*0x18*/ Sirenix.OdinInspector.InfoMessageType MessageType;

            /*0x2289c88*/ RequiredInPrefabAssetsAttribute();
            /*0x2289ca8*/ RequiredInPrefabAssetsAttribute(string errorMessage, Sirenix.OdinInspector.InfoMessageType messageType);
            /*0x2289cd8*/ RequiredInPrefabAssetsAttribute(string errorMessage);
            /*0x2289d08*/ RequiredInPrefabAssetsAttribute(Sirenix.OdinInspector.InfoMessageType messageType);
        }

        class RequiredInPrefabInstancesAttribute : System.Attribute
        {
            /*0x10*/ string ErrorMessage;
            /*0x18*/ Sirenix.OdinInspector.InfoMessageType MessageType;

            /*0x2289d30*/ RequiredInPrefabInstancesAttribute();
            /*0x2289d50*/ RequiredInPrefabInstancesAttribute(string errorMessage, Sirenix.OdinInspector.InfoMessageType messageType);
            /*0x2289d80*/ RequiredInPrefabInstancesAttribute(string errorMessage);
            /*0x2289db0*/ RequiredInPrefabInstancesAttribute(Sirenix.OdinInspector.InfoMessageType messageType);
        }

        class ResponsiveButtonGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x34*/ Sirenix.OdinInspector.ButtonSizes DefaultButtonSize;
            /*0x38*/ bool UniformLayout;

            /*0x2289dd8*/ ResponsiveButtonGroupAttribute(string group);
            /*0x2289de8*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class SceneObjectsOnlyAttribute : System.Attribute
        {
            /*0x2289e9c*/ SceneObjectsOnlyAttribute();
        }

        class SearchableAttribute : System.Attribute
        {
            /*0x10*/ bool FuzzySearch;
            /*0x14*/ Sirenix.OdinInspector.SearchFilterOptions FilterOptions;
            /*0x18*/ bool Recursive;

            /*0x2289ea4*/ SearchableAttribute();
        }

        class ShowDrawerChainAttribute : System.Attribute
        {
            /*0x2289ec0*/ ShowDrawerChainAttribute();
        }

        class ShowIfAttribute : System.Attribute
        {
            /*0x10*/ string Condition;
            /*0x18*/ object Value;
            /*0x20*/ bool Animate;

            /*0x2289ed8*/ ShowIfAttribute(string condition, bool animate);
            /*0x2289f08*/ ShowIfAttribute(string condition, object optionalValue, bool animate);
            /*0x2289ec8*/ string get_MemberName();
            /*0x2289ed0*/ void set_MemberName(string value);
        }

        class ShowIfGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x38*/ object Value;

            /*0x2289fc8*/ ShowIfGroupAttribute(string path, bool animate);
            /*0x2289ff4*/ ShowIfGroupAttribute(string path, object value, bool animate);
            /*0x2289f44*/ bool get_Animate();
            /*0x2289f4c*/ void set_Animate(bool value);
            /*0x2289f58*/ string get_MemberName();
            /*0x2289fb8*/ void set_MemberName(string value);
            /*0x2289f88*/ string get_Condition();
            /*0x2289fc0*/ void set_Condition(string value);
            /*0x228a028*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class ShowInAttribute : System.Attribute
        {
            /*0x10*/ Sirenix.OdinInspector.PrefabKind PrefabKind;

            /*0x228a0b8*/ ShowInAttribute(Sirenix.OdinInspector.PrefabKind prefabKind);
        }

        class ShowInInlineEditorsAttribute : System.Attribute
        {
            /*0x228a0e0*/ ShowInInlineEditorsAttribute();
        }

        class ShowInInspectorAttribute : System.Attribute
        {
            /*0x2287d10*/ ShowInInspectorAttribute();
        }

        class ShowOdinSerializedPropertiesInInspectorAttribute : System.Attribute
        {
            /*0x228a0e8*/ ShowOdinSerializedPropertiesInInspectorAttribute();
        }

        class ShowPropertyResolverAttribute : System.Attribute
        {
            /*0x228a0f0*/ ShowPropertyResolverAttribute();
        }

        class SuffixLabelAttribute : System.Attribute
        {
            /*0x10*/ string Label;
            /*0x18*/ bool Overlay;
            /*0x20*/ string IconColor;
            /*0x28*/ bool <HasDefinedIcon>k__BackingField;
            /*0x2c*/ Sirenix.OdinInspector.SdfIconType icon;

            /*0x228a124*/ SuffixLabelAttribute(string label, bool overlay);
            /*0x228a154*/ SuffixLabelAttribute(string label, Sirenix.OdinInspector.SdfIconType icon, bool overlay);
            /*0x228a0f8*/ Sirenix.OdinInspector.SdfIconType get_Icon();
            /*0x228a100*/ void set_Icon(Sirenix.OdinInspector.SdfIconType value);
            /*0x228a110*/ bool get_HasDefinedIcon();
            /*0x228a118*/ void set_HasDefinedIcon(bool value);
        }

        class SuppressInvalidAttributeErrorAttribute : System.Attribute
        {
            /*0x228a19c*/ SuppressInvalidAttributeErrorAttribute();
        }

        class TabGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute, Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute
        {
            static string DEFAULT_NAME = "_DefaultTabGroup";
            /*0x38*/ string TabName;
            /*0x40*/ bool UseFixedHeight;
            /*0x41*/ bool Paddingless;
            /*0x42*/ bool HideTabGroupIfTabGroupOnlyHasOneTab;
            /*0x48*/ System.Collections.Generic.List<string> <Tabs>k__BackingField;

            /*0x228a1a4*/ TabGroupAttribute(string tab, bool useFixedHeight, float order);
            /*0x228a214*/ TabGroupAttribute(string group, string tab, bool useFixedHeight, float order);
            /*0x228a348*/ System.Collections.Generic.List<string> get_Tabs();
            /*0x228a350*/ void set_Tabs(System.Collections.Generic.List<string> value);
            /*0x228a358*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
            /*0x228a4bc*/ System.Collections.Generic.IList<Sirenix.OdinInspector.PropertyGroupAttribute> Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.GetSubGroupAttributes();
            /*0x228a758*/ string Sirenix.OdinInspector.Internal.ISubGroupProviderAttribute.RepathMemberAttribute(Sirenix.OdinInspector.PropertyGroupAttribute attr);

            class TabSubGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
            {
                /*0x228a754*/ TabSubGroupAttribute(string groupId, float order);
            }
        }

        class TableColumnWidthAttribute : System.Attribute
        {
            /*0x10*/ int Width;
            /*0x14*/ bool Resizable;

            /*0x228a7fc*/ TableColumnWidthAttribute(int width, bool resizable);
        }

        class TableListAttribute : System.Attribute
        {
            /*0x10*/ int NumberOfItemsPerPage;
            /*0x14*/ bool IsReadOnly;
            /*0x18*/ int DefaultMinColumnWidth;
            /*0x1c*/ bool ShowIndexLabels;
            /*0x1d*/ bool DrawScrollView;
            /*0x20*/ int MinScrollViewHeight;
            /*0x24*/ int MaxScrollViewHeight;
            /*0x28*/ bool AlwaysExpanded;
            /*0x29*/ bool HideToolbar;
            /*0x2c*/ int CellPadding;
            /*0x30*/ bool showPagingHasValue;
            /*0x31*/ bool showPaging;

            /*0x228a8c0*/ TableListAttribute();
            /*0x228a834*/ bool get_ShowPaging();
            /*0x228a83c*/ void set_ShowPaging(bool value);
            /*0x228a850*/ bool get_ShowPagingHasValue();
            /*0x228a858*/ int get_ScrollViewHeight();
            /*0x228a8b8*/ void set_ScrollViewHeight(int value);
        }

        class TableMatrixAttribute : System.Attribute
        {
            /*0x10*/ bool IsReadOnly;
            /*0x11*/ bool ResizableColumns;
            /*0x18*/ string VerticalTitle;
            /*0x20*/ string HorizontalTitle;
            /*0x28*/ string DrawElementMethod;
            /*0x30*/ int RowHeight;
            /*0x34*/ bool SquareCells;
            /*0x35*/ bool HideColumnIndices;
            /*0x36*/ bool HideRowIndices;
            /*0x37*/ bool RespectIndentLevel;
            /*0x38*/ bool Transpose;

            /*0x228a8e8*/ TableMatrixAttribute();
        }

        class TitleAttribute : System.Attribute
        {
            /*0x10*/ string Title;
            /*0x18*/ string Subtitle;
            /*0x20*/ bool Bold;
            /*0x21*/ bool HorizontalLine;
            /*0x24*/ Sirenix.OdinInspector.TitleAlignments TitleAlignment;

            /*0x228a8fc*/ TitleAttribute(string title, string subtitle, Sirenix.OdinInspector.TitleAlignments titleAlignment, bool horizontalLine, bool bold);
        }

        class TitleGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x38*/ string Subtitle;
            /*0x40*/ Sirenix.OdinInspector.TitleAlignments Alignment;
            /*0x44*/ bool HorizontalLine;
            /*0x45*/ bool BoldTitle;
            /*0x46*/ bool Indent;

            /*0x228a998*/ TitleGroupAttribute(string title, string subtitle, Sirenix.OdinInspector.TitleAlignments alignment, bool horizontalLine, bool boldTitle, bool indent, float order);
            /*0x228a9ec*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class ToggleAttribute : System.Attribute
        {
            /*0x10*/ string ToggleMemberName;
            /*0x18*/ bool CollapseOthersOnExpand;

            /*0x228aad0*/ ToggleAttribute(string toggleMemberName);
        }

        class ToggleGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x38*/ string ToggleGroupTitle;
            /*0x40*/ bool CollapseOthersOnExpand;
            /*0x48*/ string <TitleStringMemberName>k__BackingField;

            /*0x228ab00*/ ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle);
            /*0x228ab2c*/ ToggleGroupAttribute(string toggleMemberName, string groupTitle);
            /*0x228ab5c*/ ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName);
            /*0x228ab88*/ string get_ToggleMemberName();
            /*0x228ab90*/ string get_TitleStringMemberName();
            /*0x228ab98*/ void set_TitleStringMemberName(string value);
            /*0x228aba0*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class ToggleLeftAttribute : System.Attribute
        {
            /*0x228ac2c*/ ToggleLeftAttribute();
        }

        class TypeFilterAttribute : System.Attribute
        {
            /*0x10*/ string FilterGetter;
            /*0x18*/ string DropdownTitle;
            /*0x20*/ bool DrawValueNormally;

            /*0x228ac44*/ TypeFilterAttribute(string filterGetter);
            /*0x228ac34*/ string get_MemberName();
            /*0x228ac3c*/ void set_MemberName(string value);
        }

        class TypeInfoBoxAttribute : System.Attribute
        {
            /*0x10*/ string Message;

            /*0x228ac6c*/ TypeInfoBoxAttribute(string message);
        }

        class ValidateInputAttribute : System.Attribute
        {
            /*0x10*/ string DefaultMessage;
            /*0x18*/ string Condition;
            /*0x20*/ Sirenix.OdinInspector.InfoMessageType MessageType;
            /*0x24*/ bool IncludeChildren;
            /*0x25*/ bool ContinuousValidationCheck;

            /*0x228acb8*/ ValidateInputAttribute(string condition, string defaultMessage, Sirenix.OdinInspector.InfoMessageType messageType);
            /*0x228acfc*/ ValidateInputAttribute(string condition, string message, Sirenix.OdinInspector.InfoMessageType messageType, bool rejectedInvalidInput);
            /*0x228ac94*/ string get_MemberName();
            /*0x228ac9c*/ void set_MemberName(string value);
            /*0x228aca4*/ bool get_ContiniousValidationCheck();
            /*0x228acac*/ void set_ContiniousValidationCheck(bool value);
        }

        class ValueDropdownAttribute : System.Attribute
        {
            /*0x10*/ string ValuesGetter;
            /*0x18*/ int NumberOfItemsBeforeEnablingSearch;
            /*0x1c*/ bool IsUniqueList;
            /*0x1d*/ bool DrawDropdownForListElements;
            /*0x1e*/ bool DisableListAddButtonBehaviour;
            /*0x1f*/ bool ExcludeExistingValuesInList;
            /*0x20*/ bool ExpandAllMenuItems;
            /*0x21*/ bool AppendNextDrawer;
            /*0x22*/ bool DisableGUIInAppendedDrawer;
            /*0x23*/ bool DoubleClickToConfirm;
            /*0x24*/ bool FlattenTreeView;
            /*0x28*/ int DropdownWidth;
            /*0x2c*/ int DropdownHeight;
            /*0x30*/ string DropdownTitle;
            /*0x38*/ bool SortDropdownItems;
            /*0x39*/ bool HideChildProperties;
            /*0x3a*/ bool CopyValues;
            /*0x3b*/ bool OnlyChangeValueOnConfirm;

            /*0x228ad50*/ ValueDropdownAttribute(string valuesGetter);
            /*0x228ad40*/ string get_MemberName();
            /*0x228ad48*/ void set_MemberName(string value);
        }

        interface IValueDropdownItem
        {
            string GetText();
            object GetValue();
        }

        class ValueDropdownList<T> : System.Collections.Generic.List<Sirenix.OdinInspector.ValueDropdownItem<T>>
        {
            ValueDropdownList();
            void Add(string text, T value);
            void Add(T value);
        }

        struct ValueDropdownItem : Sirenix.OdinInspector.IValueDropdownItem
        {
            /*0x10*/ string Text;
            /*0x18*/ object Value;

            /*0x228ad8c*/ ValueDropdownItem(string text, object value);
            /*0x228ad94*/ string ToString();
            /*0x228adfc*/ string Sirenix.OdinInspector.IValueDropdownItem.GetText();
            /*0x228ae04*/ object Sirenix.OdinInspector.IValueDropdownItem.GetValue();
        }

        struct ValueDropdownItem<T> : Sirenix.OdinInspector.IValueDropdownItem
        {
            /*0x0*/ string Text;
            /*0x0*/ T Value;

            ValueDropdownItem(string text, T value);
            string Sirenix.OdinInspector.IValueDropdownItem.GetText();
            object Sirenix.OdinInspector.IValueDropdownItem.GetValue();
            string ToString();
        }

        class VerticalGroupAttribute : Sirenix.OdinInspector.PropertyGroupAttribute
        {
            /*0x34*/ float PaddingTop;
            /*0x38*/ float PaddingBottom;

            /*0x228ae0c*/ VerticalGroupAttribute(string groupId, float order);
            /*0x228ae10*/ VerticalGroupAttribute(float order);
            /*0x228ae68*/ void CombineValuesWith(Sirenix.OdinInspector.PropertyGroupAttribute other);
        }

        class WrapAttribute : System.Attribute
        {
            /*0x10*/ double Min;
            /*0x18*/ double Max;

            /*0x228af08*/ WrapAttribute(double min, double max);
        }

        class AttributeTargetFlags
        {
            static System.AttributeTargets Default = 32767;
        }

        enum ButtonSizes
        {
            Small = 0,
            Medium = 22,
            Large = 31,
            Gigantic = 62,
        }

        enum DictionaryDisplayOptions
        {
            OneLine = 0,
            Foldout = 1,
            CollapsedFoldout = 2,
            ExpandedFoldout = 3,
        }

        enum IconAlignment
        {
            LeftOfText = 0,
            RightOfText = 1,
            LeftEdge = 2,
            RightEdge = 3,
        }

        class IncludeMyAttributesAttribute : System.Attribute
        {
            /*0x228af48*/ IncludeMyAttributesAttribute();
        }

        enum InfoMessageType
        {
            None = 0,
            Info = 1,
            Warning = 2,
            Error = 3,
        }

        enum InlineEditorModes
        {
            GUIOnly = 0,
            GUIAndHeader = 1,
            GUIAndPreview = 2,
            SmallPreview = 3,
            LargePreview = 4,
            FullEditor = 5,
        }

        enum InlineEditorObjectFieldModes
        {
            Boxed = 0,
            Foldout = 1,
            Hidden = 2,
            CompletelyHidden = 3,
        }

        interface ISearchFilterable
        {
            bool IsMatch(string searchString);
        }

        interface ISelfValidator
        {
            void Validate(Sirenix.OdinInspector.SelfValidationResult result);
        }

        enum ValidatorSeverity
        {
            Error = 0,
            Warning = 1,
            Ignore = 2,
        }

        class SelfValidationResultItemExtensions
        {
            static /*0x228af50*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithFix(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, string title, System.Action fix, bool offerInInspector);
            static ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithFix<T>(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, string title, System.Action<T> fix, bool offerInInspector);
            static /*0x228b000*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithFix(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, System.Action fix, bool offerInInspector);
            static ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithFix<T>(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, System.Action<T> fix, bool offerInInspector);
            static /*0x228b12c*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithFix(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, Sirenix.OdinInspector.SelfFix fix);
            static /*0x228b1bc*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithContextClick(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, System.Func<System.Collections.Generic.IEnumerable<Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem>> onContextClick);
            static /*0x228b1c4*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithContextClick(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, string path, System.Action onClick);
            static /*0x228b28c*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithContextClick(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, string path, bool on, System.Action onClick);
            static /*0x228b36c*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithContextClick(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem onContextClick);
            static /*0x228b43c*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithSceneGUI(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem item, System.Action onSceneGUI);
            static /*0x228b444*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithMetaData(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem resultItem, string name, object value, System.Attribute[] attributes);
            static /*0x228b524*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithMetaData(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem resultItem, object value, System.Attribute[] attributes);
            static /*0x228b5f4*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem WithButton(ref Sirenix.OdinInspector.SelfValidationResult.ResultItem resultItem, string name, System.Action onClick);

            class <>c__DisplayClass6_0
            {
                /*0x10*/ string path;
                /*0x18*/ System.Action onClick;

                /*0x228b284*/ <>c__DisplayClass6_0();
                /*0x228b718*/ System.Collections.Generic.IEnumerable<Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem> <WithContextClick>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ string path;
                /*0x18*/ bool on;
                /*0x20*/ System.Action onClick;

                /*0x228b364*/ <>c__DisplayClass7_0();
                /*0x228b784*/ System.Collections.Generic.IEnumerable<Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem> <WithContextClick>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem onContextClick;

                /*0x228b434*/ <>c__DisplayClass8_0();
                /*0x228b82c*/ System.Collections.Generic.IEnumerable<Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem> <WithContextClick>b__0();
            }
        }

        class SelfValidationResult
        {
            static /*0x0*/ Sirenix.OdinInspector.SelfValidationResult.ResultItem NoResultItem;
            /*0x10*/ Sirenix.OdinInspector.SelfValidationResult.ResultItem[] items;
            /*0x18*/ int itemsCount;

            /*0x228bbd8*/ SelfValidationResult();
            /*0x228b8c4*/ int get_Count();
            /*0x228b8cc*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem get_Item(int index);
            /*0x228b900*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem AddError(string error);
            /*0x228bac4*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem AddWarning(string warning);
            /*0x228bb00*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem Add(Sirenix.OdinInspector.ValidatorSeverity severity, string message);
            /*0x228b938*/ ref Sirenix.OdinInspector.SelfValidationResult.ResultItem Add(Sirenix.OdinInspector.SelfValidationResult.ResultItem item);

            struct ContextMenuItem
            {
                /*0x10*/ string Path;
                /*0x18*/ bool On;
                /*0x19*/ bool AddSeparatorBefore;
                /*0x20*/ System.Action OnClick;
            }

            enum ResultType
            {
                Error = 0,
                Warning = 1,
                Valid = 2,
            }

            struct ResultItem
            {
                /*0x10*/ string Message;
                /*0x18*/ Sirenix.OdinInspector.SelfValidationResult.ResultType ResultType;
                /*0x20*/ System.Nullable<Sirenix.OdinInspector.SelfFix> Fix;
                /*0x40*/ Sirenix.OdinInspector.SelfValidationResult.ResultItemMetaData[] MetaData;
                /*0x48*/ System.Func<System.Collections.Generic.IEnumerable<Sirenix.OdinInspector.SelfValidationResult.ContextMenuItem>> OnContextClick;
                /*0x50*/ System.Action OnSceneGUI;
            }

            struct ResultItemMetaData
            {
                /*0x10*/ string Name;
                /*0x18*/ object Value;
                /*0x20*/ System.Attribute[] Attributes;

                /*0x228b518*/ ResultItemMetaData(string name, object value, System.Attribute[] attributes);
            }
        }

        class SelfMetaData : System.Collections.Generic.List<Sirenix.OdinInspector.SelfValidationResult.ResultItemMetaData>
        {
            /*0x228bcfc*/ SelfMetaData();
            /*0x228bbe0*/ void Add(string key, object value);
        }

        struct SelfFix
        {
            /*0x10*/ string Title;
            /*0x18*/ System.Delegate Action;
            /*0x20*/ bool OfferInInspector;

            static /*0x228b0c4*/ Sirenix.OdinInspector.SelfFix Create(System.Action action, bool offerInInspector);
            static /*0x228afec*/ Sirenix.OdinInspector.SelfFix Create(string title, System.Action action, bool offerInInspector);
            static Sirenix.OdinInspector.SelfFix Create<T>(System.Action<T> action, bool offerInInspector);
            static Sirenix.OdinInspector.SelfFix Create<T>(string title, System.Action<T> action, bool offerInInspector);
            /*0x228bd68*/ SelfFix(string name, System.Action action, bool offerInInspector);
            /*0x228bd78*/ SelfFix(string name, System.Delegate action, bool offerInInspector);
        }

        enum ObjectFieldAlignment
        {
            Left = 0,
            Center = 1,
            Right = 2,
        }

        class OdinRegisterAttributeAttribute : System.Attribute
        {
            /*0x10*/ System.Type AttributeType;
            /*0x18*/ string Categories;
            /*0x20*/ string Description;
            /*0x28*/ string DocumentationUrl;
            /*0x30*/ bool IsEnterprise;

            /*0x228bd88*/ OdinRegisterAttributeAttribute(System.Type attributeType, string category, string description, bool isEnterprise);
            /*0x228bdcc*/ OdinRegisterAttributeAttribute(System.Type attributeType, string category, string description, bool isEnterprise, string url);
        }

        enum PrefabKind
        {
            None = 0,
            InstanceInScene = 1,
            InstanceInPrefab = 2,
            Regular = 4,
            Variant = 8,
            NonPrefabInstance = 16,
            PrefabInstance = 3,
            PrefabAsset = 12,
            PrefabInstanceAndNonPrefabInstance = 19,
            All = 31,
        }

        enum SdfIconType
        {
            None = 0,
            AlarmFill = 1,
            Alarm = 2,
            AlignBottom = 3,
            AlignCenter = 4,
            AlignEnd = 5,
            AlignMiddle = 6,
            AlignStart = 7,
            AlignTop = 8,
            Alt = 9,
            AppIndicator = 10,
            App = 11,
            ArchiveFill = 12,
            Archive = 13,
            Arrow90degDown = 14,
            Arrow90degLeft = 15,
            Arrow90degRight = 16,
            Arrow90degUp = 17,
            ArrowBarDown = 18,
            ArrowBarLeft = 19,
            ArrowBarRight = 20,
            ArrowBarUp = 21,
            ArrowClockwise = 22,
            ArrowCounterclockwise = 23,
            ArrowDownCircleFill = 24,
            ArrowDownCircle = 25,
            ArrowDownLeftCircleFill = 26,
            ArrowDownLeftCircle = 27,
            ArrowDownLeftSquareFill = 28,
            ArrowDownLeftSquare = 29,
            ArrowDownLeft = 30,
            ArrowDownRightCircleFill = 31,
            ArrowDownRightCircle = 32,
            ArrowDownRightSquareFill = 33,
            ArrowDownRightSquare = 34,
            ArrowDownRight = 35,
            ArrowDownShort = 36,
            ArrowDownSquareFill = 37,
            ArrowDownSquare = 38,
            ArrowDownUp = 39,
            ArrowDown = 40,
            ArrowLeftCircleFill = 41,
            ArrowLeftCircle = 42,
            ArrowLeftRight = 43,
            ArrowLeftShort = 44,
            ArrowLeftSquareFill = 45,
            ArrowLeftSquare = 46,
            ArrowLeft = 47,
            ArrowRepeat = 48,
            ArrowReturnLeft = 49,
            ArrowReturnRight = 50,
            ArrowRightCircleFill = 51,
            ArrowRightCircle = 52,
            ArrowRightShort = 53,
            ArrowRightSquareFill = 54,
            ArrowRightSquare = 55,
            ArrowRight = 56,
            ArrowUpCircleFill = 57,
            ArrowUpCircle = 58,
            ArrowUpLeftCircleFill = 59,
            ArrowUpLeftCircle = 60,
            ArrowUpLeftSquareFill = 61,
            ArrowUpLeftSquare = 62,
            ArrowUpLeft = 63,
            ArrowUpRightCircleFill = 64,
            ArrowUpRightCircle = 65,
            ArrowUpRightSquareFill = 66,
            ArrowUpRightSquare = 67,
            ArrowUpRight = 68,
            ArrowUpShort = 69,
            ArrowUpSquareFill = 70,
            ArrowUpSquare = 71,
            ArrowUp = 72,
            ArrowsAngleContract = 73,
            ArrowsAngleExpand = 74,
            ArrowsCollapse = 75,
            ArrowsExpand = 76,
            ArrowsFullscreen = 77,
            ArrowsMove = 78,
            AspectRatioFill = 79,
            AspectRatio = 80,
            Asterisk = 81,
            At = 82,
            AwardFill = 83,
            Award = 84,
            Back = 85,
            BackspaceFill = 86,
            BackspaceReverseFill = 87,
            BackspaceReverse = 88,
            Backspace = 89,
            Badge3dFill = 90,
            Badge3d = 91,
            Badge4kFill = 92,
            Badge4k = 93,
            Badge8kFill = 94,
            Badge8k = 95,
            BadgeAdFill = 96,
            BadgeAd = 97,
            BadgeArFill = 98,
            BadgeAr = 99,
            BadgeCcFill = 100,
            BadgeCc = 101,
            BadgeHdFill = 102,
            BadgeHd = 103,
            BadgeTmFill = 104,
            BadgeTm = 105,
            BadgeVoFill = 106,
            BadgeVo = 107,
            BadgeVrFill = 108,
            BadgeVr = 109,
            BadgeWcFill = 110,
            BadgeWc = 111,
            BagCheckFill = 112,
            BagCheck = 113,
            BagDashFill = 114,
            BagDash = 115,
            BagFill = 116,
            BagPlusFill = 117,
            BagPlus = 118,
            BagXFill = 119,
            BagX = 120,
            Bag = 121,
            BarChartFill = 122,
            BarChartLineFill = 123,
            BarChartLine = 124,
            BarChartSteps = 125,
            BarChart = 126,
            BasketFill = 127,
            Basket = 128,
            Basket2Fill = 129,
            Basket2 = 130,
            Basket3Fill = 131,
            Basket3 = 132,
            BatteryCharging = 133,
            BatteryFull = 134,
            BatteryHalf = 135,
            Battery = 136,
            BellFill = 137,
            Bell = 138,
            Bezier = 139,
            Bezier2 = 140,
            Bicycle = 141,
            BinocularsFill = 142,
            Binoculars = 143,
            BlockquoteLeft = 144,
            BlockquoteRight = 145,
            BookFill = 146,
            BookHalf = 147,
            Book = 148,
            BookmarkCheckFill = 149,
            BookmarkCheck = 150,
            BookmarkDashFill = 151,
            BookmarkDash = 152,
            BookmarkFill = 153,
            BookmarkHeartFill = 154,
            BookmarkHeart = 155,
            BookmarkPlusFill = 156,
            BookmarkPlus = 157,
            BookmarkStarFill = 158,
            BookmarkStar = 159,
            BookmarkXFill = 160,
            BookmarkX = 161,
            Bookmark = 162,
            BookmarksFill = 163,
            Bookmarks = 164,
            Bookshelf = 165,
            BootstrapFill = 166,
            BootstrapReboot = 167,
            Bootstrap = 168,
            BorderAll = 169,
            BorderBottom = 170,
            BorderCenter = 171,
            BorderInner = 172,
            BorderLeft = 173,
            BorderMiddle = 174,
            BorderOuter = 175,
            BorderRight = 176,
            BorderStyle = 177,
            BorderTop = 178,
            BorderWidth = 179,
            Border = 180,
            BoundingBoxCircles = 181,
            BoundingBox = 182,
            BoxArrowDownLeft = 183,
            BoxArrowDownRight = 184,
            BoxArrowDown = 185,
            BoxArrowInDownLeft = 186,
            BoxArrowInDownRight = 187,
            BoxArrowInDown = 188,
            BoxArrowInLeft = 189,
            BoxArrowInRight = 190,
            BoxArrowInUpLeft = 191,
            BoxArrowInUpRight = 192,
            BoxArrowInUp = 193,
            BoxArrowLeft = 194,
            BoxArrowRight = 195,
            BoxArrowUpLeft = 196,
            BoxArrowUpRight = 197,
            BoxArrowUp = 198,
            BoxSeam = 199,
            Box = 200,
            Braces = 201,
            Bricks = 202,
            BriefcaseFill = 203,
            Briefcase = 204,
            BrightnessAltHighFill = 205,
            BrightnessAltHigh = 206,
            BrightnessAltLowFill = 207,
            BrightnessAltLow = 208,
            BrightnessHighFill = 209,
            BrightnessHigh = 210,
            BrightnessLowFill = 211,
            BrightnessLow = 212,
            BroadcastPin = 213,
            Broadcast = 214,
            BrushFill = 215,
            Brush = 216,
            BucketFill = 217,
            Bucket = 218,
            BugFill = 219,
            Bug = 220,
            Building = 221,
            Bullseye = 222,
            CalculatorFill = 223,
            Calculator = 224,
            CalendarCheckFill = 225,
            CalendarCheck = 226,
            CalendarDateFill = 227,
            CalendarDate = 228,
            CalendarDayFill = 229,
            CalendarDay = 230,
            CalendarEventFill = 231,
            CalendarEvent = 232,
            CalendarFill = 233,
            CalendarMinusFill = 234,
            CalendarMinus = 235,
            CalendarMonthFill = 236,
            CalendarMonth = 237,
            CalendarPlusFill = 238,
            CalendarPlus = 239,
            CalendarRangeFill = 240,
            CalendarRange = 241,
            CalendarWeekFill = 242,
            CalendarWeek = 243,
            CalendarXFill = 244,
            CalendarX = 245,
            Calendar = 246,
            Calendar2CheckFill = 247,
            Calendar2Check = 248,
            Calendar2DateFill = 249,
            Calendar2Date = 250,
            Calendar2DayFill = 251,
            Calendar2Day = 252,
            Calendar2EventFill = 253,
            Calendar2Event = 254,
            Calendar2Fill = 255,
            Calendar2MinusFill = 256,
            Calendar2Minus = 257,
            Calendar2MonthFill = 258,
            Calendar2Month = 259,
            Calendar2PlusFill = 260,
            Calendar2Plus = 261,
            Calendar2RangeFill = 262,
            Calendar2Range = 263,
            Calendar2WeekFill = 264,
            Calendar2Week = 265,
            Calendar2XFill = 266,
            Calendar2X = 267,
            Calendar2 = 268,
            Calendar3EventFill = 269,
            Calendar3Event = 270,
            Calendar3Fill = 271,
            Calendar3RangeFill = 272,
            Calendar3Range = 273,
            Calendar3WeekFill = 274,
            Calendar3Week = 275,
            Calendar3 = 276,
            Calendar4Event = 277,
            Calendar4Range = 278,
            Calendar4Week = 279,
            Calendar4 = 280,
            CameraFill = 281,
            CameraReelsFill = 282,
            CameraReels = 283,
            CameraVideoFill = 284,
            CameraVideoOffFill = 285,
            CameraVideoOff = 286,
            CameraVideo = 287,
            Camera = 288,
            Camera2 = 289,
            CapslockFill = 290,
            Capslock = 291,
            CardChecklist = 292,
            CardHeading = 293,
            CardImage = 294,
            CardList = 295,
            CardText = 296,
            CaretDownFill = 297,
            CaretDownSquareFill = 298,
            CaretDownSquare = 299,
            CaretDown = 300,
            CaretLeftFill = 301,
            CaretLeftSquareFill = 302,
            CaretLeftSquare = 303,
            CaretLeft = 304,
            CaretRightFill = 305,
            CaretRightSquareFill = 306,
            CaretRightSquare = 307,
            CaretRight = 308,
            CaretUpFill = 309,
            CaretUpSquareFill = 310,
            CaretUpSquare = 311,
            CaretUp = 312,
            CartCheckFill = 313,
            CartCheck = 314,
            CartDashFill = 315,
            CartDash = 316,
            CartFill = 317,
            CartPlusFill = 318,
            CartPlus = 319,
            CartXFill = 320,
            CartX = 321,
            Cart = 322,
            Cart2 = 323,
            Cart3 = 324,
            Cart4 = 325,
            CashStack = 326,
            Cash = 327,
            Cast = 328,
            ChatDotsFill = 329,
            ChatDots = 330,
            ChatFill = 331,
            ChatLeftDotsFill = 332,
            ChatLeftDots = 333,
            ChatLeftFill = 334,
            ChatLeftQuoteFill = 335,
            ChatLeftQuote = 336,
            ChatLeftTextFill = 337,
            ChatLeftText = 338,
            ChatLeft = 339,
            ChatQuoteFill = 340,
            ChatQuote = 341,
            ChatRightDotsFill = 342,
            ChatRightDots = 343,
            ChatRightFill = 344,
            ChatRightQuoteFill = 345,
            ChatRightQuote = 346,
            ChatRightTextFill = 347,
            ChatRightText = 348,
            ChatRight = 349,
            ChatSquareDotsFill = 350,
            ChatSquareDots = 351,
            ChatSquareFill = 352,
            ChatSquareQuoteFill = 353,
            ChatSquareQuote = 354,
            ChatSquareTextFill = 355,
            ChatSquareText = 356,
            ChatSquare = 357,
            ChatTextFill = 358,
            ChatText = 359,
            Chat = 360,
            CheckAll = 361,
            CheckCircleFill = 362,
            CheckCircle = 363,
            CheckSquareFill = 364,
            CheckSquare = 365,
            Check = 366,
            Check2All = 367,
            Check2Circle = 368,
            Check2Square = 369,
            Check2 = 370,
            ChevronBarContract = 371,
            ChevronBarDown = 372,
            ChevronBarExpand = 373,
            ChevronBarLeft = 374,
            ChevronBarRight = 375,
            ChevronBarUp = 376,
            ChevronCompactDown = 377,
            ChevronCompactLeft = 378,
            ChevronCompactRight = 379,
            ChevronCompactUp = 380,
            ChevronContract = 381,
            ChevronDoubleDown = 382,
            ChevronDoubleLeft = 383,
            ChevronDoubleRight = 384,
            ChevronDoubleUp = 385,
            ChevronDown = 386,
            ChevronExpand = 387,
            ChevronLeft = 388,
            ChevronRight = 389,
            ChevronUp = 390,
            CircleFill = 391,
            CircleHalf = 392,
            CircleSquare = 393,
            Circle = 394,
            ClipboardCheck = 395,
            ClipboardData = 396,
            ClipboardMinus = 397,
            ClipboardPlus = 398,
            ClipboardX = 399,
            Clipboard = 400,
            ClockFill = 401,
            ClockHistory = 402,
            Clock = 403,
            CloudArrowDownFill = 404,
            CloudArrowDown = 405,
            CloudArrowUpFill = 406,
            CloudArrowUp = 407,
            CloudCheckFill = 408,
            CloudCheck = 409,
            CloudDownloadFill = 410,
            CloudDownload = 411,
            CloudDrizzleFill = 412,
            CloudDrizzle = 413,
            CloudFill = 414,
            CloudFogFill = 415,
            CloudFog = 416,
            CloudFog2Fill = 417,
            CloudFog2 = 418,
            CloudHailFill = 419,
            CloudHail = 420,
            CloudHaze1 = 421,
            CloudHazeFill = 422,
            CloudHaze = 423,
            CloudHaze2Fill = 424,
            CloudLightningFill = 425,
            CloudLightningRainFill = 426,
            CloudLightningRain = 427,
            CloudLightning = 428,
            CloudMinusFill = 429,
            CloudMinus = 430,
            CloudMoonFill = 431,
            CloudMoon = 432,
            CloudPlusFill = 433,
            CloudPlus = 434,
            CloudRainFill = 435,
            CloudRainHeavyFill = 436,
            CloudRainHeavy = 437,
            CloudRain = 438,
            CloudSlashFill = 439,
            CloudSlash = 440,
            CloudSleetFill = 441,
            CloudSleet = 442,
            CloudSnowFill = 443,
            CloudSnow = 444,
            CloudSunFill = 445,
            CloudSun = 446,
            CloudUploadFill = 447,
            CloudUpload = 448,
            Cloud = 449,
            CloudsFill = 450,
            Clouds = 451,
            CloudyFill = 452,
            Cloudy = 453,
            CodeSlash = 454,
            CodeSquare = 455,
            Code = 456,
            CollectionFill = 457,
            CollectionPlayFill = 458,
            CollectionPlay = 459,
            Collection = 460,
            ColumnsGap = 461,
            Columns = 462,
            Command = 463,
            CompassFill = 464,
            Compass = 465,
            ConeStriped = 466,
            Cone = 467,
            Controller = 468,
            CpuFill = 469,
            Cpu = 470,
            CreditCard2BackFill = 471,
            CreditCard2Back = 472,
            CreditCard2FrontFill = 473,
            CreditCard2Front = 474,
            CreditCardFill = 475,
            CreditCard = 476,
            Crop = 477,
            CupFill = 478,
            CupStraw = 479,
            Cup = 480,
            CursorFill = 481,
            CursorText = 482,
            Cursor = 483,
            DashCircleDotted = 484,
            DashCircleFill = 485,
            DashCircle = 486,
            DashSquareDotted = 487,
            DashSquareFill = 488,
            DashSquare = 489,
            Dash = 490,
            Diagram2Fill = 491,
            Diagram2 = 492,
            Diagram3Fill = 493,
            Diagram3 = 494,
            DiamondFill = 495,
            DiamondHalf = 496,
            Diamond = 497,
            Dice1Fill = 498,
            Dice1 = 499,
            Dice2Fill = 500,
            Dice2 = 501,
            Dice3Fill = 502,
            Dice3 = 503,
            Dice4Fill = 504,
            Dice4 = 505,
            Dice5Fill = 506,
            Dice5 = 507,
            Dice6Fill = 508,
            Dice6 = 509,
            DiscFill = 510,
            Disc = 511,
            Discord = 512,
            DisplayFill = 513,
            Display = 514,
            DistributeHorizontal = 515,
            DistributeVertical = 516,
            DoorClosedFill = 517,
            DoorClosed = 518,
            DoorOpenFill = 519,
            DoorOpen = 520,
            Dot = 521,
            Download = 522,
            DropletFill = 523,
            DropletHalf = 524,
            Droplet = 525,
            Earbuds = 526,
            EaselFill = 527,
            Easel = 528,
            EggFill = 529,
            EggFried = 530,
            Egg = 531,
            EjectFill = 532,
            Eject = 533,
            EmojiAngryFill = 534,
            EmojiAngry = 535,
            EmojiDizzyFill = 536,
            EmojiDizzy = 537,
            EmojiExpressionlessFill = 538,
            EmojiExpressionless = 539,
            EmojiFrownFill = 540,
            EmojiFrown = 541,
            EmojiHeartEyesFill = 542,
            EmojiHeartEyes = 543,
            EmojiLaughingFill = 544,
            EmojiLaughing = 545,
            EmojiNeutralFill = 546,
            EmojiNeutral = 547,
            EmojiSmileFill = 548,
            EmojiSmileUpsideDownFill = 549,
            EmojiSmileUpsideDown = 550,
            EmojiSmile = 551,
            EmojiSunglassesFill = 552,
            EmojiSunglasses = 553,
            EmojiWinkFill = 554,
            EmojiWink = 555,
            EnvelopeFill = 556,
            EnvelopeOpenFill = 557,
            EnvelopeOpen = 558,
            Envelope = 559,
            EraserFill = 560,
            Eraser = 561,
            ExclamationCircleFill = 562,
            ExclamationCircle = 563,
            ExclamationDiamondFill = 564,
            ExclamationDiamond = 565,
            ExclamationOctagonFill = 566,
            ExclamationOctagon = 567,
            ExclamationSquareFill = 568,
            ExclamationSquare = 569,
            ExclamationTriangleFill = 570,
            ExclamationTriangle = 571,
            Exclamation = 572,
            Exclude = 573,
            EyeFill = 574,
            EyeSlashFill = 575,
            EyeSlash = 576,
            Eye = 577,
            Eyedropper = 578,
            Eyeglasses = 579,
            Facebook = 580,
            FileArrowDownFill = 581,
            FileArrowDown = 582,
            FileArrowUpFill = 583,
            FileArrowUp = 584,
            FileBarGraphFill = 585,
            FileBarGraph = 586,
            FileBinaryFill = 587,
            FileBinary = 588,
            FileBreakFill = 589,
            FileBreak = 590,
            FileCheckFill = 591,
            FileCheck = 592,
            FileCodeFill = 593,
            FileCode = 594,
            FileDiffFill = 595,
            FileDiff = 596,
            FileEarmarkArrowDownFill = 597,
            FileEarmarkArrowDown = 598,
            FileEarmarkArrowUpFill = 599,
            FileEarmarkArrowUp = 600,
            FileEarmarkBarGraphFill = 601,
            FileEarmarkBarGraph = 602,
            FileEarmarkBinaryFill = 603,
            FileEarmarkBinary = 604,
            FileEarmarkBreakFill = 605,
            FileEarmarkBreak = 606,
            FileEarmarkCheckFill = 607,
            FileEarmarkCheck = 608,
            FileEarmarkCodeFill = 609,
            FileEarmarkCode = 610,
            FileEarmarkDiffFill = 611,
            FileEarmarkDiff = 612,
            FileEarmarkEaselFill = 613,
            FileEarmarkEasel = 614,
            FileEarmarkExcelFill = 615,
            FileEarmarkExcel = 616,
            FileEarmarkFill = 617,
            FileEarmarkFontFill = 618,
            FileEarmarkFont = 619,
            FileEarmarkImageFill = 620,
            FileEarmarkImage = 621,
            FileEarmarkLockFill = 622,
            FileEarmarkLock = 623,
            FileEarmarkLock2Fill = 624,
            FileEarmarkLock2 = 625,
            FileEarmarkMedicalFill = 626,
            FileEarmarkMedical = 627,
            FileEarmarkMinusFill = 628,
            FileEarmarkMinus = 629,
            FileEarmarkMusicFill = 630,
            FileEarmarkMusic = 631,
            FileEarmarkPersonFill = 632,
            FileEarmarkPerson = 633,
            FileEarmarkPlayFill = 634,
            FileEarmarkPlay = 635,
            FileEarmarkPlusFill = 636,
            FileEarmarkPlus = 637,
            FileEarmarkPostFill = 638,
            FileEarmarkPost = 639,
            FileEarmarkPptFill = 640,
            FileEarmarkPpt = 641,
            FileEarmarkRichtextFill = 642,
            FileEarmarkRichtext = 643,
            FileEarmarkRuledFill = 644,
            FileEarmarkRuled = 645,
            FileEarmarkSlidesFill = 646,
            FileEarmarkSlides = 647,
            FileEarmarkSpreadsheetFill = 648,
            FileEarmarkSpreadsheet = 649,
            FileEarmarkTextFill = 650,
            FileEarmarkText = 651,
            FileEarmarkWordFill = 652,
            FileEarmarkWord = 653,
            FileEarmarkXFill = 654,
            FileEarmarkX = 655,
            FileEarmarkZipFill = 656,
            FileEarmarkZip = 657,
            FileEarmark = 658,
            FileEaselFill = 659,
            FileEasel = 660,
            FileExcelFill = 661,
            FileExcel = 662,
            FileFill = 663,
            FileFontFill = 664,
            FileFont = 665,
            FileImageFill = 666,
            FileImage = 667,
            FileLockFill = 668,
            FileLock = 669,
            FileLock2Fill = 670,
            FileLock2 = 671,
            FileMedicalFill = 672,
            FileMedical = 673,
            FileMinusFill = 674,
            FileMinus = 675,
            FileMusicFill = 676,
            FileMusic = 677,
            FilePersonFill = 678,
            FilePerson = 679,
            FilePlayFill = 680,
            FilePlay = 681,
            FilePlusFill = 682,
            FilePlus = 683,
            FilePostFill = 684,
            FilePost = 685,
            FilePptFill = 686,
            FilePpt = 687,
            FileRichtextFill = 688,
            FileRichtext = 689,
            FileRuledFill = 690,
            FileRuled = 691,
            FileSlidesFill = 692,
            FileSlides = 693,
            FileSpreadsheetFill = 694,
            FileSpreadsheet = 695,
            FileTextFill = 696,
            FileText = 697,
            FileWordFill = 698,
            FileWord = 699,
            FileXFill = 700,
            FileX = 701,
            FileZipFill = 702,
            FileZip = 703,
            File = 704,
            FilesAlt = 705,
            Files = 706,
            Film = 707,
            FilterCircleFill = 708,
            FilterCircle = 709,
            FilterLeft = 710,
            FilterRight = 711,
            FilterSquareFill = 712,
            FilterSquare = 713,
            Filter = 714,
            FlagFill = 715,
            Flag = 716,
            Flower1 = 717,
            Flower2 = 718,
            Flower3 = 719,
            FolderCheck = 720,
            FolderFill = 721,
            FolderMinus = 722,
            FolderPlus = 723,
            FolderSymlinkFill = 724,
            FolderSymlink = 725,
            FolderX = 726,
            Folder = 727,
            Folder2Open = 728,
            Folder2 = 729,
            Fonts = 730,
            ForwardFill = 731,
            Forward = 732,
            Front = 733,
            FullscreenExit = 734,
            Fullscreen = 735,
            FunnelFill = 736,
            Funnel = 737,
            GearFill = 738,
            GearWideConnected = 739,
            GearWide = 740,
            Gear = 741,
            Gem = 742,
            GeoAltFill = 743,
            GeoAlt = 744,
            GeoFill = 745,
            Geo = 746,
            GiftFill = 747,
            Gift = 748,
            Github = 749,
            Globe = 750,
            Globe2 = 751,
            Google = 752,
            GraphDown = 753,
            GraphUp = 754,
            Grid1x2Fill = 755,
            Grid1x2 = 756,
            Grid3x2GapFill = 757,
            Grid3x2Gap = 758,
            Grid3x2 = 759,
            Grid3x3GapFill = 760,
            Grid3x3Gap = 761,
            Grid3x3 = 762,
            GridFill = 763,
            Grid = 764,
            GripHorizontal = 765,
            GripVertical = 766,
            Hammer = 767,
            HandIndexFill = 768,
            HandIndexThumbFill = 769,
            HandIndexThumb = 770,
            HandIndex = 771,
            HandThumbsDownFill = 772,
            HandThumbsDown = 773,
            HandThumbsUpFill = 774,
            HandThumbsUp = 775,
            HandbagFill = 776,
            Handbag = 777,
            Hash = 778,
            HddFill = 779,
            HddNetworkFill = 780,
            HddNetwork = 781,
            HddRackFill = 782,
            HddRack = 783,
            HddStackFill = 784,
            HddStack = 785,
            Hdd = 786,
            Headphones = 787,
            Headset = 788,
            HeartFill = 789,
            HeartHalf = 790,
            Heart = 791,
            HeptagonFill = 792,
            HeptagonHalf = 793,
            Heptagon = 794,
            HexagonFill = 795,
            HexagonHalf = 796,
            Hexagon = 797,
            HourglassBottom = 798,
            HourglassSplit = 799,
            HourglassTop = 800,
            Hourglass = 801,
            HouseDoorFill = 802,
            HouseDoor = 803,
            HouseFill = 804,
            House = 805,
            Hr = 806,
            Hurricane = 807,
            ImageAlt = 808,
            ImageFill = 809,
            Image = 810,
            Images = 811,
            InboxFill = 812,
            Inbox = 813,
            InboxesFill = 814,
            Inboxes = 815,
            InfoCircleFill = 816,
            InfoCircle = 817,
            InfoSquareFill = 818,
            InfoSquare = 819,
            Info = 820,
            InputCursorText = 821,
            InputCursor = 822,
            Instagram = 823,
            Intersect = 824,
            JournalAlbum = 825,
            JournalArrowDown = 826,
            JournalArrowUp = 827,
            JournalBookmarkFill = 828,
            JournalBookmark = 829,
            JournalCheck = 830,
            JournalCode = 831,
            JournalMedical = 832,
            JournalMinus = 833,
            JournalPlus = 834,
            JournalRichtext = 835,
            JournalText = 836,
            JournalX = 837,
            Journal = 838,
            Journals = 839,
            Joystick = 840,
            JustifyLeft = 841,
            JustifyRight = 842,
            Justify = 843,
            KanbanFill = 844,
            Kanban = 845,
            KeyFill = 846,
            Key = 847,
            KeyboardFill = 848,
            Keyboard = 849,
            Ladder = 850,
            LampFill = 851,
            Lamp = 852,
            LaptopFill = 853,
            Laptop = 854,
            LayerBackward = 855,
            LayerForward = 856,
            LayersFill = 857,
            LayersHalf = 858,
            Layers = 859,
            LayoutSidebarInsetReverse = 860,
            LayoutSidebarInset = 861,
            LayoutSidebarReverse = 862,
            LayoutSidebar = 863,
            LayoutSplit = 864,
            LayoutTextSidebarReverse = 865,
            LayoutTextSidebar = 866,
            LayoutTextWindowReverse = 867,
            LayoutTextWindow = 868,
            LayoutThreeColumns = 869,
            LayoutWtf = 870,
            LifePreserver = 871,
            LightbulbFill = 872,
            LightbulbOffFill = 873,
            LightbulbOff = 874,
            Lightbulb = 875,
            LightningChargeFill = 876,
            LightningCharge = 877,
            LightningFill = 878,
            Lightning = 879,
            Link45deg = 880,
            Link = 881,
            Linkedin = 882,
            ListCheck = 883,
            ListNested = 884,
            ListOl = 885,
            ListStars = 886,
            ListTask = 887,
            ListUl = 888,
            List = 889,
            LockFill = 890,
            Lock = 891,
            Mailbox = 892,
            Mailbox2 = 893,
            MapFill = 894,
            Map = 895,
            MarkdownFill = 896,
            Markdown = 897,
            Mask = 898,
            MegaphoneFill = 899,
            Megaphone = 900,
            MenuAppFill = 901,
            MenuApp = 902,
            MenuButtonFill = 903,
            MenuButtonWideFill = 904,
            MenuButtonWide = 905,
            MenuButton = 906,
            MenuDown = 907,
            MenuUp = 908,
            MicFill = 909,
            MicMuteFill = 910,
            MicMute = 911,
            Mic = 912,
            MinecartLoaded = 913,
            Minecart = 914,
            Moisture = 915,
            MoonFill = 916,
            MoonStarsFill = 917,
            MoonStars = 918,
            Moon = 919,
            MouseFill = 920,
            Mouse = 921,
            Mouse2Fill = 922,
            Mouse2 = 923,
            Mouse3Fill = 924,
            Mouse3 = 925,
            MusicNoteBeamed = 926,
            MusicNoteList = 927,
            MusicNote = 928,
            MusicPlayerFill = 929,
            MusicPlayer = 930,
            Newspaper = 931,
            NodeMinusFill = 932,
            NodeMinus = 933,
            NodePlusFill = 934,
            NodePlus = 935,
            NutFill = 936,
            Nut = 937,
            OctagonFill = 938,
            OctagonHalf = 939,
            Octagon = 940,
            Option = 941,
            Outlet = 942,
            PaintBucket = 943,
            PaletteFill = 944,
            Palette = 945,
            Palette2 = 946,
            Paperclip = 947,
            Paragraph = 948,
            PatchCheckFill = 949,
            PatchCheck = 950,
            PatchExclamationFill = 951,
            PatchExclamation = 952,
            PatchMinusFill = 953,
            PatchMinus = 954,
            PatchPlusFill = 955,
            PatchPlus = 956,
            PatchQuestionFill = 957,
            PatchQuestion = 958,
            PauseBtnFill = 959,
            PauseBtn = 960,
            PauseCircleFill = 961,
            PauseCircle = 962,
            PauseFill = 963,
            Pause = 964,
            PeaceFill = 965,
            Peace = 966,
            PenFill = 967,
            Pen = 968,
            PencilFill = 969,
            PencilSquare = 970,
            Pencil = 971,
            PentagonFill = 972,
            PentagonHalf = 973,
            Pentagon = 974,
            PeopleFill = 975,
            People = 976,
            Percent = 977,
            PersonBadgeFill = 978,
            PersonBadge = 979,
            PersonBoundingBox = 980,
            PersonCheckFill = 981,
            PersonCheck = 982,
            PersonCircle = 983,
            PersonDashFill = 984,
            PersonDash = 985,
            PersonFill = 986,
            PersonLinesFill = 987,
            PersonPlusFill = 988,
            PersonPlus = 989,
            PersonSquare = 990,
            PersonXFill = 991,
            PersonX = 992,
            Person = 993,
            PhoneFill = 994,
            PhoneLandscapeFill = 995,
            PhoneLandscape = 996,
            PhoneVibrateFill = 997,
            PhoneVibrate = 998,
            Phone = 999,
            PieChartFill = 1000,
            PieChart = 1001,
            PinAngleFill = 1002,
            PinAngle = 1003,
            PinFill = 1004,
            Pin = 1005,
            PipFill = 1006,
            Pip = 1007,
            PlayBtnFill = 1008,
            PlayBtn = 1009,
            PlayCircleFill = 1010,
            PlayCircle = 1011,
            PlayFill = 1012,
            Play = 1013,
            PlugFill = 1014,
            Plug = 1015,
            PlusCircleDotted = 1016,
            PlusCircleFill = 1017,
            PlusCircle = 1018,
            PlusSquareDotted = 1019,
            PlusSquareFill = 1020,
            PlusSquare = 1021,
            Plus = 1022,
            Power = 1023,
            PrinterFill = 1024,
            Printer = 1025,
            PuzzleFill = 1026,
            Puzzle = 1027,
            QuestionCircleFill = 1028,
            QuestionCircle = 1029,
            QuestionDiamondFill = 1030,
            QuestionDiamond = 1031,
            QuestionOctagonFill = 1032,
            QuestionOctagon = 1033,
            QuestionSquareFill = 1034,
            QuestionSquare = 1035,
            Question = 1036,
            Rainbow = 1037,
            ReceiptCutoff = 1038,
            Receipt = 1039,
            Reception0 = 1040,
            Reception1 = 1041,
            Reception2 = 1042,
            Reception3 = 1043,
            Reception4 = 1044,
            RecordBtnFill = 1045,
            RecordBtn = 1046,
            RecordCircleFill = 1047,
            RecordCircle = 1048,
            RecordFill = 1049,
            Record = 1050,
            Record2Fill = 1051,
            Record2 = 1052,
            ReplyAllFill = 1053,
            ReplyAll = 1054,
            ReplyFill = 1055,
            Reply = 1056,
            RssFill = 1057,
            Rss = 1058,
            Rulers = 1059,
            SaveFill = 1060,
            Save = 1061,
            Save2Fill = 1062,
            Save2 = 1063,
            Scissors = 1064,
            Screwdriver = 1065,
            Search = 1066,
            SegmentedNav = 1067,
            Server = 1068,
            ShareFill = 1069,
            Share = 1070,
            ShieldCheck = 1071,
            ShieldExclamation = 1072,
            ShieldFillCheck = 1073,
            ShieldFillExclamation = 1074,
            ShieldFillMinus = 1075,
            ShieldFillPlus = 1076,
            ShieldFillX = 1077,
            ShieldFill = 1078,
            ShieldLockFill = 1079,
            ShieldLock = 1080,
            ShieldMinus = 1081,
            ShieldPlus = 1082,
            ShieldShaded = 1083,
            ShieldSlashFill = 1084,
            ShieldSlash = 1085,
            ShieldX = 1086,
            Shield = 1087,
            ShiftFill = 1088,
            Shift = 1089,
            ShopWindow = 1090,
            Shop = 1091,
            Shuffle = 1092,
            Signpost2Fill = 1093,
            Signpost2 = 1094,
            SignpostFill = 1095,
            SignpostSplitFill = 1096,
            SignpostSplit = 1097,
            Signpost = 1098,
            SimFill = 1099,
            Sim = 1100,
            SkipBackwardBtnFill = 1101,
            SkipBackwardBtn = 1102,
            SkipBackwardCircleFill = 1103,
            SkipBackwardCircle = 1104,
            SkipBackwardFill = 1105,
            SkipBackward = 1106,
            SkipEndBtnFill = 1107,
            SkipEndBtn = 1108,
            SkipEndCircleFill = 1109,
            SkipEndCircle = 1110,
            SkipEndFill = 1111,
            SkipEnd = 1112,
            SkipForwardBtnFill = 1113,
            SkipForwardBtn = 1114,
            SkipForwardCircleFill = 1115,
            SkipForwardCircle = 1116,
            SkipForwardFill = 1117,
            SkipForward = 1118,
            SkipStartBtnFill = 1119,
            SkipStartBtn = 1120,
            SkipStartCircleFill = 1121,
            SkipStartCircle = 1122,
            SkipStartFill = 1123,
            SkipStart = 1124,
            Slack = 1125,
            SlashCircleFill = 1126,
            SlashCircle = 1127,
            SlashSquareFill = 1128,
            SlashSquare = 1129,
            Slash = 1130,
            Sliders = 1131,
            Smartwatch = 1132,
            Snow = 1133,
            Snow2 = 1134,
            Snow3 = 1135,
            SortAlphaDownAlt = 1136,
            SortAlphaDown = 1137,
            SortAlphaUpAlt = 1138,
            SortAlphaUp = 1139,
            SortDownAlt = 1140,
            SortDown = 1141,
            SortNumericDownAlt = 1142,
            SortNumericDown = 1143,
            SortNumericUpAlt = 1144,
            SortNumericUp = 1145,
            SortUpAlt = 1146,
            SortUp = 1147,
            Soundwave = 1148,
            SpeakerFill = 1149,
            Speaker = 1150,
            Speedometer = 1151,
            Speedometer2 = 1152,
            Spellcheck = 1153,
            SquareFill = 1154,
            SquareHalf = 1155,
            Square = 1156,
            Stack = 1157,
            StarFill = 1158,
            StarHalf = 1159,
            Star = 1160,
            Stars = 1161,
            StickiesFill = 1162,
            Stickies = 1163,
            StickyFill = 1164,
            Sticky = 1165,
            StopBtnFill = 1166,
            StopBtn = 1167,
            StopCircleFill = 1168,
            StopCircle = 1169,
            StopFill = 1170,
            Stop = 1171,
            StoplightsFill = 1172,
            Stoplights = 1173,
            StopwatchFill = 1174,
            Stopwatch = 1175,
            Subtract = 1176,
            SuitClubFill = 1177,
            SuitClub = 1178,
            SuitDiamondFill = 1179,
            SuitDiamond = 1180,
            SuitHeartFill = 1181,
            SuitHeart = 1182,
            SuitSpadeFill = 1183,
            SuitSpade = 1184,
            SunFill = 1185,
            Sun = 1186,
            Sunglasses = 1187,
            SunriseFill = 1188,
            Sunrise = 1189,
            SunsetFill = 1190,
            Sunset = 1191,
            SymmetryHorizontal = 1192,
            SymmetryVertical = 1193,
            Table = 1194,
            TabletFill = 1195,
            TabletLandscapeFill = 1196,
            TabletLandscape = 1197,
            Tablet = 1198,
            TagFill = 1199,
            Tag = 1200,
            TagsFill = 1201,
            Tags = 1202,
            Telegram = 1203,
            TelephoneFill = 1204,
            TelephoneForwardFill = 1205,
            TelephoneForward = 1206,
            TelephoneInboundFill = 1207,
            TelephoneInbound = 1208,
            TelephoneMinusFill = 1209,
            TelephoneMinus = 1210,
            TelephoneOutboundFill = 1211,
            TelephoneOutbound = 1212,
            TelephonePlusFill = 1213,
            TelephonePlus = 1214,
            TelephoneXFill = 1215,
            TelephoneX = 1216,
            Telephone = 1217,
            TerminalFill = 1218,
            Terminal = 1219,
            TextCenter = 1220,
            TextIndentLeft = 1221,
            TextIndentRight = 1222,
            TextLeft = 1223,
            TextParagraph = 1224,
            TextRight = 1225,
            TextareaResize = 1226,
            TextareaT = 1227,
            Textarea = 1228,
            ThermometerHalf = 1229,
            ThermometerHigh = 1230,
            ThermometerLow = 1231,
            ThermometerSnow = 1232,
            ThermometerSun = 1233,
            Thermometer = 1234,
            ThreeDotsVertical = 1235,
            ThreeDots = 1236,
            ToggleOff = 1237,
            ToggleOn = 1238,
            Toggle2Off = 1239,
            Toggle2On = 1240,
            Toggles = 1241,
            Toggles2 = 1242,
            Tools = 1243,
            Tornado = 1244,
            TrashFill = 1245,
            Trash = 1246,
            Trash2Fill = 1247,
            Trash2 = 1248,
            TreeFill = 1249,
            Tree = 1250,
            TriangleFill = 1251,
            TriangleHalf = 1252,
            Triangle = 1253,
            TrophyFill = 1254,
            Trophy = 1255,
            TropicalStorm = 1256,
            TruckFlatbed = 1257,
            Truck = 1258,
            Tsunami = 1259,
            TvFill = 1260,
            Tv = 1261,
            Twitch = 1262,
            Twitter = 1263,
            TypeBold = 1264,
            TypeH1 = 1265,
            TypeH2 = 1266,
            TypeH3 = 1267,
            TypeItalic = 1268,
            TypeStrikethrough = 1269,
            TypeUnderline = 1270,
            Type = 1271,
            UiChecksGrid = 1272,
            UiChecks = 1273,
            UiRadiosGrid = 1274,
            UiRadios = 1275,
            UmbrellaFill = 1276,
            Umbrella = 1277,
            Union = 1278,
            UnlockFill = 1279,
            Unlock = 1280,
            UpcScan = 1281,
            Upc = 1282,
            Upload = 1283,
            VectorPen = 1284,
            ViewList = 1285,
            ViewStacked = 1286,
            VinylFill = 1287,
            Vinyl = 1288,
            Voicemail = 1289,
            VolumeDownFill = 1290,
            VolumeDown = 1291,
            VolumeMuteFill = 1292,
            VolumeMute = 1293,
            VolumeOffFill = 1294,
            VolumeOff = 1295,
            VolumeUpFill = 1296,
            VolumeUp = 1297,
            Vr = 1298,
            WalletFill = 1299,
            Wallet = 1300,
            Wallet2 = 1301,
            Watch = 1302,
            Water = 1303,
            Whatsapp = 1304,
            Wifi1 = 1305,
            Wifi2 = 1306,
            WifiOff = 1307,
            Wifi = 1308,
            Wind = 1309,
            WindowDock = 1310,
            WindowSidebar = 1311,
            Window = 1312,
            Wrench = 1313,
            XCircleFill = 1314,
            XCircle = 1315,
            XDiamondFill = 1316,
            XDiamond = 1317,
            XOctagonFill = 1318,
            XOctagon = 1319,
            XSquareFill = 1320,
            XSquare = 1321,
            X = 1322,
            Youtube = 1323,
            ZoomIn = 1324,
            ZoomOut = 1325,
            Bank = 1326,
            Bank2 = 1327,
            BellSlashFill = 1328,
            BellSlash = 1329,
            CashCoin = 1330,
            CheckLg = 1331,
            Coin = 1332,
            CurrencyBitcoin = 1333,
            CurrencyDollar = 1334,
            CurrencyEuro = 1335,
            CurrencyExchange = 1336,
            CurrencyPound = 1337,
            CurrencyYen = 1338,
            DashLg = 1339,
            ExclamationLg = 1340,
            FileEarmarkPdfFill = 1341,
            FileEarmarkPdf = 1342,
            FilePdfFill = 1343,
            FilePdf = 1344,
            GenderAmbiguous = 1345,
            GenderFemale = 1346,
            GenderMale = 1347,
            GenderTrans = 1348,
            HeadsetVr = 1349,
            InfoLg = 1350,
            Mastodon = 1351,
            Messenger = 1352,
            PiggyBankFill = 1353,
            PiggyBank = 1354,
            PinMapFill = 1355,
            PinMap = 1356,
            PlusLg = 1357,
            QuestionLg = 1358,
            Recycle = 1359,
            Reddit = 1360,
            SafeFill = 1361,
            Safe2Fill = 1362,
            Safe2 = 1363,
            SdCardFill = 1364,
            SdCard = 1365,
            Skype = 1366,
            SlashLg = 1367,
            Translate = 1368,
            XLg = 1369,
            Safe = 1370,
            Apple = 1371,
            Microsoft = 1372,
            Windows = 1373,
            Behance = 1374,
            Dribbble = 1375,
            Line = 1376,
            Medium = 1377,
            Paypal = 1378,
            Pinterest = 1379,
            Signal = 1380,
            Snapchat = 1381,
            Spotify = 1382,
            StackOverflow = 1383,
            Strava = 1384,
            Wordpress = 1385,
            Vimeo = 1386,
            Activity = 1387,
            Easel2Fill = 1388,
            Easel2 = 1389,
            Easel3Fill = 1390,
            Easel3 = 1391,
            Fan = 1392,
            Fingerprint = 1393,
            GraphDownArrow = 1394,
            GraphUpArrow = 1395,
            Hypnotize = 1396,
            Magic = 1397,
            PersonRolodex = 1398,
            PersonVideo = 1399,
            PersonVideo2 = 1400,
            PersonVideo3 = 1401,
            PersonWorkspace = 1402,
            Radioactive = 1403,
            WebcamFill = 1404,
            Webcam = 1405,
            YinYang = 1406,
            BandaidFill = 1407,
            Bandaid = 1408,
            Bluetooth = 1409,
            BodyText = 1410,
            Boombox = 1411,
            Boxes = 1412,
            DpadFill = 1413,
            Dpad = 1414,
            EarFill = 1415,
            Ear = 1416,
            EnvelopeCheck1 = 1417,
            EnvelopeCheckFill = 1418,
            EnvelopeCheck = 1419,
            EnvelopeDash1 = 1420,
            EnvelopeDashFill = 1421,
            EnvelopeDash = 1422,
            EnvelopeExclamation1 = 1423,
            EnvelopeExclamationFill = 1424,
            EnvelopeExclamation = 1425,
            EnvelopePlusFill = 1426,
            EnvelopePlus = 1427,
            EnvelopeSlash1 = 1428,
            EnvelopeSlashFill = 1429,
            EnvelopeSlash = 1430,
            EnvelopeX1 = 1431,
            EnvelopeXFill = 1432,
            EnvelopeX = 1433,
            ExplicitFill = 1434,
            Explicit = 1435,
            Git = 1436,
            Infinity = 1437,
            ListColumnsReverse = 1438,
            ListColumns = 1439,
            Meta = 1440,
            MortorboardFill = 1441,
            Mortorboard = 1442,
            NintendoSwitch = 1443,
            PcDisplayHorizontal = 1444,
            PcDisplay = 1445,
            PcHorizontal = 1446,
            Pc = 1447,
            Playstation = 1448,
            PlusSlashMinus = 1449,
            ProjectorFill = 1450,
            Projector = 1451,
            QrCodeScan = 1452,
            QrCode = 1453,
            Quora = 1454,
            Quote = 1455,
            Robot = 1456,
            SendCheckFill = 1457,
            SendCheck = 1458,
            SendDashFill = 1459,
            SendDash = 1460,
            SendExclamation1 = 1461,
            SendExclamationFill = 1462,
            SendExclamation = 1463,
            SendFill = 1464,
            SendPlusFill = 1465,
            SendPlus = 1466,
            SendSlashFill = 1467,
            SendSlash = 1468,
            SendXFill = 1469,
            SendX = 1470,
            Send = 1471,
            Steam = 1472,
            TerminalDash1 = 1473,
            TerminalDash = 1474,
            TerminalPlus = 1475,
            TerminalSplit = 1476,
            TicketDetailedFill = 1477,
            TicketDetailed = 1478,
            TicketFill = 1479,
            TicketPerforatedFill = 1480,
            TicketPerforated = 1481,
            Ticket = 1482,
            Tiktok = 1483,
            WindowDash = 1484,
            WindowDesktop = 1485,
            WindowFullscreen = 1486,
            WindowPlus = 1487,
            WindowSplit = 1488,
            WindowStack = 1489,
            WindowX = 1490,
            Xbox = 1491,
            Ethernet = 1492,
            HdmiFill = 1493,
            Hdmi = 1494,
            UsbCFill = 1495,
            UsbC = 1496,
            UsbFill = 1497,
            UsbPlugFill = 1498,
            UsbPlug = 1499,
            UsbSymbol = 1500,
            Usb = 1501,
            BoomboxFill = 1502,
            Displayport1 = 1503,
            Displayport = 1504,
            GpuCard = 1505,
            Memory = 1506,
            ModemFill = 1507,
            Modem = 1508,
            MotherboardFill = 1509,
            Motherboard = 1510,
            OpticalAudioFill = 1511,
            OpticalAudio = 1512,
            PciCard = 1513,
            RouterFill = 1514,
            Router = 1515,
            SsdFill = 1516,
            Ssd = 1517,
            ThunderboltFill = 1518,
            Thunderbolt = 1519,
            UsbDriveFill = 1520,
            UsbDrive = 1521,
            UsbMicroFill = 1522,
            UsbMicro = 1523,
            UsbMiniFill = 1524,
            UsbMini = 1525,
            CloudHaze2 = 1526,
            DeviceHddFill = 1527,
            DeviceHdd = 1528,
            DeviceSsdFill = 1529,
            DeviceSsd = 1530,
            DisplayportFill = 1531,
            MortarboardFill = 1532,
            Mortarboard = 1533,
            TerminalX = 1534,
        }

        enum SearchFilterOptions
        {
            PropertyName = 1,
            PropertyNiceName = 2,
            TypeOfValue = 4,
            ValueToString = 8,
            ISearchFilterableInterface = 16,
            All = -1,
        }

        enum TitleAlignments
        {
            Left = 0,
            Centered = 1,
            Right = 2,
            Split = 3,
        }

        namespace Internal
        {
            interface ISubGroupProviderAttribute
            {
                System.Collections.Generic.IList<Sirenix.OdinInspector.PropertyGroupAttribute> GetSubGroupAttributes();
                string RepathMemberAttribute(Sirenix.OdinInspector.PropertyGroupAttribute attr);
            }
        }
    }
}
