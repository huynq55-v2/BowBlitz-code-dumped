class <Module>
{
}

namespace UnityEngine
{
    namespace TextCore
    {
        namespace Text
        {
            enum TextFontWeight
            {
                Thin = 100,
                ExtraLight = 200,
                Light = 300,
                Regular = 400,
                Medium = 500,
                SemiBold = 600,
                Bold = 700,
                Heavy = 800,
                Black = 900,
            }

            struct FontWeightPair
            {
                /*0x10*/ UnityEngine.TextCore.Text.FontAsset regularTypeface;
                /*0x18*/ UnityEngine.TextCore.Text.FontAsset italicTypeface;
            }

            struct FontAssetCreationEditorSettings
            {
                /*0x10*/ string sourceFontFileGUID;
                /*0x18*/ int faceIndex;
                /*0x1c*/ int pointSizeSamplingMode;
                /*0x20*/ int pointSize;
                /*0x24*/ int padding;
                /*0x28*/ int packingMode;
                /*0x2c*/ int atlasWidth;
                /*0x30*/ int atlasHeight;
                /*0x34*/ int characterSetSelectionMode;
                /*0x38*/ string characterSequence;
                /*0x40*/ string referencedFontAssetGUID;
                /*0x48*/ string referencedTextAssetGUID;
                /*0x50*/ int fontStyle;
                /*0x54*/ float fontStyleModifier;
                /*0x58*/ int renderMode;
                /*0x5c*/ bool includeFontFeatures;
            }

            enum AtlasPopulationMode
            {
                Static = 0,
                Dynamic = 1,
                DynamicOS = 2,
            }

            class FontAsset : UnityEngine.TextCore.Text.TextAsset
            {
                static /*0x0*/ Unity.Profiling.ProfilerMarker k_ReadFontAssetDefinitionMarker;
                static /*0x8*/ Unity.Profiling.ProfilerMarker k_AddSynthesizedCharactersMarker;
                static /*0x10*/ Unity.Profiling.ProfilerMarker k_TryAddCharacterMarker;
                static /*0x18*/ Unity.Profiling.ProfilerMarker k_TryAddCharactersMarker;
                static /*0x20*/ Unity.Profiling.ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;
                static /*0x28*/ Unity.Profiling.ProfilerMarker k_ClearFontAssetDataMarker;
                static /*0x30*/ Unity.Profiling.ProfilerMarker k_UpdateFontAssetDataMarker;
                static /*0x38*/ string s_DefaultMaterialSuffix;
                static /*0x40*/ System.Collections.Generic.HashSet<int> k_SearchedFontAssetLookup;
                static /*0x48*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue;
                static /*0x50*/ System.Collections.Generic.HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;
                static /*0x58*/ System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;
                static /*0x60*/ System.Collections.Generic.HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;
                static /*0x68*/ uint[] k_GlyphIndexArray;
                /*0x38*/ string m_SourceFontFileGUID;
                /*0x40*/ UnityEngine.Font m_SourceFontFile;
                /*0x48*/ UnityEngine.TextCore.Text.AtlasPopulationMode m_AtlasPopulationMode;
                /*0x4c*/ bool InternalDynamicOS;
                /*0x50*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
                /*0xb0*/ int m_FamilyNameHashCode;
                /*0xb4*/ int m_StyleNameHashCode;
                /*0xb8*/ UnityEngine.TextCore.Text.FontWeightPair[] m_FontWeightTable;
                /*0xc0*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable;
                /*0xc8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary;
                /*0xd0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharacterTable;
                /*0xd8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary;
                /*0xe0*/ UnityEngine.Texture2D m_AtlasTexture;
                /*0xe8*/ UnityEngine.Texture2D[] m_AtlasTextures;
                /*0xf0*/ int m_AtlasTextureIndex;
                /*0xf4*/ bool m_IsMultiAtlasTexturesEnabled;
                /*0xf5*/ bool m_ClearDynamicDataOnBuild;
                /*0xf8*/ int m_AtlasWidth;
                /*0xfc*/ int m_AtlasHeight;
                /*0x100*/ int m_AtlasPadding;
                /*0x104*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode m_AtlasRenderMode;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects;
                /*0x110*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects;
                /*0x118*/ UnityEngine.TextCore.Text.FontFeatureTable m_FontFeatureTable;
                /*0x120*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable;
                /*0x128*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;
                /*0x178*/ float m_RegularStyleWeight;
                /*0x17c*/ float m_RegularStyleSpacing;
                /*0x180*/ float m_BoldStyleWeight;
                /*0x184*/ float m_BoldStyleSpacing;
                /*0x188*/ byte m_ItalicStyleSlant;
                /*0x189*/ byte m_TabMultiple;
                /*0x18a*/ bool IsFontAssetLookupTablesDirty;
                /*0x190*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender;
                /*0x198*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered;
                /*0x1a0*/ System.Collections.Generic.List<uint> m_GlyphIndexList;
                /*0x1a8*/ System.Collections.Generic.List<uint> m_GlyphIndexListNewlyAdded;
                /*0x1b0*/ System.Collections.Generic.List<uint> m_GlyphsToAdd;
                /*0x1b8*/ System.Collections.Generic.HashSet<uint> m_GlyphsToAddLookup;
                /*0x1c0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd;
                /*0x1c8*/ System.Collections.Generic.HashSet<uint> m_CharactersToAddLookup;
                /*0x1d0*/ System.Collections.Generic.List<uint> s_MissingCharacterList;
                /*0x1d8*/ System.Collections.Generic.HashSet<uint> m_MissingUnicodesFromFontFile;

                static /*0x2959dec*/ FontAsset();
                static /*0x29529f0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string familyName, string styleName, int pointSize);
                static /*0x2952c64*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x295323c*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font);
                static /*0x29532b8*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x2953378*/ UnityEngine.TextCore.Text.FontAsset CreateFontAsset(UnityEngine.Font font, int faceIndex, int samplingPointSize, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x2952de0*/ UnityEngine.TextCore.Text.FontAsset CreateFontAssetInstance(UnityEngine.Font font, int atlasPadding, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, UnityEngine.TextCore.Text.AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport);
                static /*0x2955fa8*/ string GetCharacters(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x2956088*/ int[] GetCharactersArray(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x2956248*/ void RegisterFontAssetForFontFeatureUpdate(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x2956374*/ void UpdateFontFeaturesForFontAssetsInQueue();
                static /*0x2956844*/ void RegisterAtlasTextureForApply(UnityEngine.Texture2D texture);
                static /*0x2956970*/ void UpdateAtlasTexturesInQueue();
                static /*0x2956af4*/ void UpdateFontAssetInUpdateQueue();
                /*0x2959b44*/ FontAsset();
                /*0x29522e4*/ UnityEngine.Font get_sourceFontFile();
                /*0x29522ec*/ void set_sourceFontFile(UnityEngine.Font value);
                /*0x29522f4*/ UnityEngine.TextCore.Text.AtlasPopulationMode get_atlasPopulationMode();
                /*0x29522fc*/ void set_atlasPopulationMode(UnityEngine.TextCore.Text.AtlasPopulationMode value);
                /*0x2952304*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x2952320*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x2952338*/ int get_familyNameHashCode();
                /*0x29523d4*/ void set_familyNameHashCode(int value);
                /*0x29523dc*/ int get_styleNameHashCode();
                /*0x2952408*/ void set_styleNameHashCode(int value);
                /*0x2952410*/ UnityEngine.TextCore.Text.FontWeightPair[] get_fontWeightTable();
                /*0x2952418*/ void set_fontWeightTable(UnityEngine.TextCore.Text.FontWeightPair[] value);
                /*0x2952420*/ System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable();
                /*0x2952428*/ void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value);
                /*0x2952430*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> get_glyphLookupTable();
                /*0x29527d4*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable();
                /*0x29527dc*/ void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value);
                /*0x29527e4*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.Character> get_characterLookupTable();
                /*0x2952808*/ UnityEngine.Texture2D get_atlasTexture();
                /*0x2952898*/ UnityEngine.Texture2D[] get_atlasTextures();
                /*0x29528a0*/ void set_atlasTextures(UnityEngine.Texture2D[] value);
                /*0x29528a8*/ int get_atlasTextureCount();
                /*0x29528b4*/ bool get_isMultiAtlasTexturesEnabled();
                /*0x29528bc*/ void set_isMultiAtlasTexturesEnabled(bool value);
                /*0x29528c8*/ bool get_clearDynamicDataOnBuild();
                /*0x29528d0*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x29528dc*/ int get_atlasWidth();
                /*0x29528e4*/ void set_atlasWidth(int value);
                /*0x29528ec*/ int get_atlasHeight();
                /*0x29528f4*/ void set_atlasHeight(int value);
                /*0x29528fc*/ int get_atlasPadding();
                /*0x2952904*/ void set_atlasPadding(int value);
                /*0x295290c*/ UnityEngine.TextCore.LowLevel.GlyphRenderMode get_atlasRenderMode();
                /*0x2952914*/ void set_atlasRenderMode(UnityEngine.TextCore.LowLevel.GlyphRenderMode value);
                /*0x295291c*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects();
                /*0x2952924*/ void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x295292c*/ System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects();
                /*0x2952934*/ void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value);
                /*0x295293c*/ UnityEngine.TextCore.Text.FontFeatureTable get_fontFeatureTable();
                /*0x2952944*/ void set_fontFeatureTable(UnityEngine.TextCore.Text.FontFeatureTable value);
                /*0x295294c*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable();
                /*0x2952954*/ void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x295295c*/ UnityEngine.TextCore.Text.FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings();
                /*0x2952978*/ void set_fontAssetCreationEditorSettings(UnityEngine.TextCore.Text.FontAssetCreationEditorSettings value);
                /*0x2952990*/ float get_regularStyleWeight();
                /*0x2952998*/ void set_regularStyleWeight(float value);
                /*0x29529a0*/ float get_regularStyleSpacing();
                /*0x29529a8*/ void set_regularStyleSpacing(float value);
                /*0x29529b0*/ float get_boldStyleWeight();
                /*0x29529b8*/ void set_boldStyleWeight(float value);
                /*0x29529c0*/ float get_boldStyleSpacing();
                /*0x29529c8*/ void set_boldStyleSpacing(float value);
                /*0x29529d0*/ byte get_italicStyleSlant();
                /*0x29529d8*/ void set_italicStyleSlant(byte value);
                /*0x29529e0*/ byte get_tabMultiple();
                /*0x29529e8*/ void set_tabMultiple(byte value);
                /*0x295358c*/ void Awake();
                /*0x2953590*/ void OnDestroy();
                /*0x2952454*/ void ReadFontAssetDefinition();
                /*0x29536b8*/ void InitializeDictionaryLookupTables();
                /*0x29538b8*/ void InitializeGlyphLookupDictionary();
                /*0x2953b40*/ void InitializeCharacterLookupDictionary();
                /*0x2953cdc*/ void InitializeGlyphPaidAdjustmentRecordsLookupDictionary();
                /*0x29536d8*/ void AddSynthesizedCharactersAndFaceMetrics();
                /*0x2954038*/ void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately);
                /*0x29542ec*/ void AddCharacterToLookupCache(uint unicode, UnityEngine.TextCore.Text.Character character);
                /*0x2953f30*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace();
                /*0x2954354*/ void SortCharacterTable();
                /*0x2954490*/ void SortGlyphTable();
                /*0x29545cc*/ void SortFontFeatureTable();
                /*0x29547d0*/ void SortAllTables();
                /*0x29547f8*/ bool HasCharacter(int character);
                /*0x2954858*/ bool HasCharacter(char character, bool searchFallbacks, bool tryAddCharacter);
                /*0x29556e8*/ bool HasCharacter_Internal(uint character, bool searchFallbacks, bool tryAddCharacter);
                /*0x295590c*/ bool HasCharacters(string text, ref System.Collections.Generic.List<char> missingCharacters);
                /*0x2955ab4*/ bool HasCharacters(string text, ref uint[] missingCharacters, bool searchFallbacks, bool tryAddCharacter);
                /*0x2955ef4*/ bool HasCharacters(string text);
                /*0x295616c*/ uint GetGlyphIndex(uint unicode);
                /*0x2956b44*/ bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures);
                /*0x2956b64*/ bool TryAddCharacters(uint[] unicodes, ref uint[] missingUnicodes, bool includeFontFeatures);
                /*0x2957c24*/ bool TryAddCharacters(string characters, bool includeFontFeatures);
                /*0x2957c44*/ bool TryAddCharacters(string characters, ref string missingCharacters, bool includeFontFeatures);
                /*0x2954b74*/ bool TryAddCharacterInternal(uint unicode, ref UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures);
                /*0x2958af8*/ bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, ref UnityEngine.TextCore.Text.Character character, bool shouldGetFontFeatures);
                /*0x295906c*/ void TryAddGlyphsToAtlasTextures();
                /*0x2957798*/ bool TryAddGlyphsToNewAtlasTexture();
                /*0x29588c8*/ void SetupNewAtlasTexture();
                /*0x2959070*/ void UpdateAtlasTexture();
                /*0x29564ec*/ void UpdateGlyphAdjustmentRecords();
                /*0x29592a8*/ void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes);
                /*0x29595d8*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes);
                /*0x29595dc*/ void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<uint> newGlyphIndexes, System.Collections.Generic.List<uint> allGlyphIndexes);
                void CopyListDataToArray<T>(System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                /*0x29595e0*/ void ClearFontAssetData(bool setAtlasSizeToZero);
                /*0x29599fc*/ void ClearFontAssetDataInternal();
                /*0x2959a18*/ void UpdateFontAssetData();
                /*0x2959610*/ void ClearFontAssetTables();
                /*0x2959808*/ void ClearAtlasTextures(bool setAtlasSizeToZero);
                /*0x29535f4*/ void DestroyAtlasTextures();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.Character, uint> <>9__144_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Glyph, uint> <>9__145_0;

                    static /*0x295a0f4*/ <>c();
                    /*0x295a158*/ <>c();
                    /*0x295a160*/ uint <SortCharacterTable>b__144_0(UnityEngine.TextCore.Text.Character c);
                    /*0x295a178*/ uint <SortGlyphTable>b__145_0(UnityEngine.TextCore.Glyph c);
                }
            }

            class TextSettings : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ UnityEngine.TextCore.Text.FontAsset m_DefaultFontAsset;
                /*0x28*/ string m_DefaultFontAssetPath;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets;
                /*0x38*/ bool m_MatchMaterialPreset;
                /*0x3c*/ int m_MissingCharacterUnicode;
                /*0x40*/ bool m_ClearDynamicDataOnBuild;
                /*0x48*/ UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;
                /*0x50*/ string m_DefaultSpriteAssetPath;
                /*0x58*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets;
                /*0x60*/ uint m_MissingSpriteCharacterUnicode;
                /*0x68*/ UnityEngine.TextCore.Text.TextStyleSheet m_DefaultStyleSheet;
                /*0x70*/ string m_StyleSheetsResourcePath;
                /*0x78*/ string m_DefaultColorGradientPresetsPath;
                /*0x80*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules m_UnicodeLineBreakingRules;
                /*0x88*/ bool m_DisplayWarnings;
                /*0x90*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontLookup;
                /*0x98*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences;

                /*0x295a814*/ TextSettings();
                /*0x295a190*/ string get_version();
                /*0x295a198*/ void set_version(string value);
                /*0x295a1a0*/ UnityEngine.TextCore.Text.FontAsset get_defaultFontAsset();
                /*0x295a1a8*/ void set_defaultFontAsset(UnityEngine.TextCore.Text.FontAsset value);
                /*0x295a1b0*/ string get_defaultFontAssetPath();
                /*0x295a1b8*/ void set_defaultFontAssetPath(string value);
                /*0x295a1c0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets();
                /*0x295a1c8*/ void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value);
                /*0x295a1d0*/ bool get_matchMaterialPreset();
                /*0x295a1d8*/ void set_matchMaterialPreset(bool value);
                /*0x295a1e4*/ int get_missingCharacterUnicode();
                /*0x295a1ec*/ void set_missingCharacterUnicode(int value);
                /*0x295a1f4*/ bool get_clearDynamicDataOnBuild();
                /*0x295a1fc*/ void set_clearDynamicDataOnBuild(bool value);
                /*0x295a208*/ UnityEngine.TextCore.Text.SpriteAsset get_defaultSpriteAsset();
                /*0x295a210*/ void set_defaultSpriteAsset(UnityEngine.TextCore.Text.SpriteAsset value);
                /*0x295a218*/ string get_defaultSpriteAssetPath();
                /*0x295a220*/ void set_defaultSpriteAssetPath(string value);
                /*0x295a228*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets();
                /*0x295a230*/ void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value);
                /*0x295a238*/ uint get_missingSpriteCharacterUnicode();
                /*0x295a240*/ void set_missingSpriteCharacterUnicode(uint value);
                /*0x295a248*/ UnityEngine.TextCore.Text.TextStyleSheet get_defaultStyleSheet();
                /*0x295a250*/ void set_defaultStyleSheet(UnityEngine.TextCore.Text.TextStyleSheet value);
                /*0x295a258*/ string get_styleSheetsResourcePath();
                /*0x295a260*/ void set_styleSheetsResourcePath(string value);
                /*0x295a268*/ string get_defaultColorGradientPresetsPath();
                /*0x295a270*/ void set_defaultColorGradientPresetsPath(string value);
                /*0x295a278*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules get_lineBreakingRules();
                /*0x295a2fc*/ void set_lineBreakingRules(UnityEngine.TextCore.Text.UnicodeLineBreakingRules value);
                /*0x295a304*/ bool get_displayWarnings();
                /*0x295a30c*/ void set_displayWarnings(bool value);
                /*0x295a318*/ void InitializeFontReferenceLookup();
                /*0x295a504*/ UnityEngine.TextCore.Text.FontAsset GetCachedFontAssetInternal(UnityEngine.Font font);

                struct FontReferenceMap
                {
                    /*0x10*/ UnityEngine.Font font;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x295a80c*/ FontReferenceMap(UnityEngine.Font font, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }
            }

            class MaterialReferenceManager
            {
                static /*0x0*/ UnityEngine.TextCore.Text.MaterialReferenceManager s_Instance;
                /*0x10*/ System.Collections.Generic.Dictionary<int, UnityEngine.Material> m_FontMaterialReferenceLookup;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup;
                /*0x28*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup;

                static /*0x295a91c*/ UnityEngine.TextCore.Text.MaterialReferenceManager get_instance();
                static /*0x295aadc*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x295abf0*/ void AddSpriteAsset(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x295acf4*/ void AddFontMaterial(int hashCode, UnityEngine.Material material);
                static /*0x295ad8c*/ void AddColorGradientPreset(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                static /*0x295ae60*/ bool TryGetFontAsset(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                static /*0x295aefc*/ bool TryGetSpriteAsset(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                static /*0x295af98*/ bool TryGetColorGradientPreset(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                static /*0x295b034*/ bool TryGetMaterial(int hashCode, ref UnityEngine.Material material);
                /*0x295a994*/ MaterialReferenceManager();
                /*0x295aafc*/ void AddFontAssetInternal(UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x295ac20*/ void AddSpriteAssetInternal(int hashCode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x295ad24*/ void AddFontMaterialInternal(int hashCode, UnityEngine.Material material);
                /*0x295adbc*/ void AddColorGradientPreset_Internal(int hashCode, UnityEngine.TextCore.Text.TextColorGradient spriteAsset);
                /*0x295ae90*/ bool TryGetFontAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.FontAsset fontAsset);
                /*0x295af2c*/ bool TryGetSpriteAssetInternal(int hashCode, ref UnityEngine.TextCore.Text.SpriteAsset spriteAsset);
                /*0x295afc8*/ bool TryGetColorGradientPresetInternal(int hashCode, ref UnityEngine.TextCore.Text.TextColorGradient gradientPreset);
                /*0x295b064*/ bool TryGetMaterialInternal(int hashCode, ref UnityEngine.Material material);
            }

            struct LinkInfo
            {
                /*0x10*/ int hashCode;
                /*0x14*/ int linkIdFirstCharacterIndex;
                /*0x18*/ int linkIdLength;
                /*0x1c*/ int linkTextfirstCharacterIndex;
                /*0x20*/ int linkTextLength;
                /*0x28*/ char[] linkId;

                /*0x295b0d0*/ void SetLinkId(char[] text, int startIndex, int length);
            }

            enum TextOverflowMode
            {
                Overflow = 0,
                Ellipsis = 1,
                Masking = 2,
                Truncate = 3,
                ScrollRect = 4,
                Page = 5,
                Linked = 6,
            }

            enum TextureMapping
            {
                Character = 0,
                Line = 1,
                Paragraph = 2,
                MatchAspect = 3,
            }

            class TextGenerationSettings : System.IEquatable<UnityEngine.TextCore.Text.TextGenerationSettings>
            {
                /*0x10*/ string text;
                /*0x18*/ UnityEngine.Rect screenRect;
                /*0x28*/ UnityEngine.Vector4 margins;
                /*0x38*/ float scale;
                /*0x40*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x48*/ UnityEngine.Material material;
                /*0x50*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x58*/ UnityEngine.TextCore.Text.TextStyleSheet styleSheet;
                /*0x60*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x68*/ UnityEngine.TextCore.Text.TextSettings textSettings;
                /*0x70*/ UnityEngine.TextCore.Text.TextAlignment textAlignment;
                /*0x74*/ UnityEngine.TextCore.Text.TextOverflowMode overflowMode;
                /*0x78*/ bool wordWrap;
                /*0x7c*/ float wordWrappingRatio;
                /*0x80*/ UnityEngine.Color color;
                /*0x90*/ UnityEngine.TextCore.Text.TextColorGradient fontColorGradient;
                /*0x98*/ bool tintSprites;
                /*0x99*/ bool overrideRichTextColors;
                /*0x9c*/ float fontSize;
                /*0xa0*/ bool autoSize;
                /*0xa4*/ float fontSizeMin;
                /*0xa8*/ float fontSizeMax;
                /*0xac*/ bool enableKerning;
                /*0xad*/ bool richText;
                /*0xae*/ bool isRightToLeft;
                /*0xaf*/ bool extraPadding;
                /*0xb0*/ bool parseControlCharacters;
                /*0xb4*/ float characterSpacing;
                /*0xb8*/ float wordSpacing;
                /*0xbc*/ float lineSpacing;
                /*0xc0*/ float paragraphSpacing;
                /*0xc4*/ float lineSpacingMax;
                /*0xc8*/ int maxVisibleCharacters;
                /*0xcc*/ int maxVisibleWords;
                /*0xd0*/ int maxVisibleLines;
                /*0xd4*/ int firstVisibleCharacter;
                /*0xd8*/ bool useMaxVisibleDescender;
                /*0xdc*/ UnityEngine.TextCore.Text.TextFontWeight fontWeight;
                /*0xe0*/ int pageToDisplay;
                /*0xe4*/ UnityEngine.TextCore.Text.TextureMapping horizontalMapping;
                /*0xe8*/ UnityEngine.TextCore.Text.TextureMapping verticalMapping;
                /*0xec*/ float uvLineOffset;
                /*0xf0*/ UnityEngine.TextCore.Text.VertexSortingOrder geometrySortingOrder;
                /*0xf4*/ bool inverseYAxis;
                /*0xf8*/ float charWidthMaxAdj;

                /*0x295d3a8*/ TextGenerationSettings();
                /*0x295b1a4*/ bool Equals(UnityEngine.TextCore.Text.TextGenerationSettings other);
                /*0x295b58c*/ bool Equals(object obj);
                /*0x295b654*/ int GetHashCode();
                /*0x295bc14*/ string ToString();
            }

            class TextGenerator
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextGenerator s_TextGenerator;
                /*0x10*/ UnityEngine.Vector3[] m_RectTransformCorners;
                /*0x18*/ float m_MarginWidth;
                /*0x1c*/ float m_MarginHeight;
                /*0x20*/ int[] m_CharBuffer;
                /*0x28*/ float m_PreferredWidth;
                /*0x2c*/ float m_PreferredHeight;
                /*0x30*/ UnityEngine.TextCore.Text.FontAsset m_CurrentFontAsset;
                /*0x38*/ UnityEngine.Material m_CurrentMaterial;
                /*0x40*/ int m_CurrentMaterialIndex;
                /*0x48*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack;
                /*0xa0*/ float m_Padding;
                /*0xa8*/ UnityEngine.TextCore.Text.SpriteAsset m_CurrentSpriteAsset;
                /*0xb0*/ int m_TotalCharacterCount;
                /*0xb4*/ float m_FontScale;
                /*0xb8*/ float m_FontSize;
                /*0xbc*/ float m_FontScaleMultiplier;
                /*0xc0*/ float m_CurrentFontSize;
                /*0xc8*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_SizeStack;
                /*0xe8*/ UnityEngine.TextCore.Text.FontStyles m_FontStyleInternal;
                /*0xec*/ UnityEngine.TextCore.Text.FontStyleStack m_FontStyleStack;
                /*0xf8*/ UnityEngine.TextCore.Text.TextFontWeight m_FontWeightInternal;
                /*0x100*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> m_FontWeightStack;
                /*0x120*/ UnityEngine.TextCore.Text.TextAlignment m_LineJustification;
                /*0x128*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> m_LineJustificationStack;
                /*0x148*/ float m_BaselineOffset;
                /*0x150*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_BaselineOffsetStack;
                /*0x170*/ UnityEngine.Color32 m_FontColor32;
                /*0x174*/ UnityEngine.Color32 m_HtmlColor;
                /*0x178*/ UnityEngine.Color32 m_UnderlineColor;
                /*0x17c*/ UnityEngine.Color32 m_StrikethroughColor;
                /*0x180*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_ColorStack;
                /*0x1a0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_UnderlineColorStack;
                /*0x1c0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_StrikethroughColorStack;
                /*0x1e0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_HighlightColorStack;
                /*0x200*/ UnityEngine.TextCore.Text.TextColorGradient m_ColorGradientPreset;
                /*0x208*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack;
                /*0x230*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_ActionStack;
                /*0x250*/ bool m_IsFxMatrixSet;
                /*0x254*/ float m_LineOffset;
                /*0x258*/ float m_LineHeight;
                /*0x25c*/ float m_CSpacing;
                /*0x260*/ float m_MonoSpacing;
                /*0x264*/ float m_XAdvance;
                /*0x268*/ float m_TagLineIndent;
                /*0x26c*/ float m_TagIndent;
                /*0x270*/ UnityEngine.TextCore.Text.TextProcessingStack<float> m_IndentStack;
                /*0x290*/ bool m_TagNoParsing;
                /*0x294*/ int m_CharacterCount;
                /*0x298*/ int m_FirstCharacterOfLine;
                /*0x29c*/ int m_LastCharacterOfLine;
                /*0x2a0*/ int m_FirstVisibleCharacterOfLine;
                /*0x2a4*/ int m_LastVisibleCharacterOfLine;
                /*0x2a8*/ float m_MaxLineAscender;
                /*0x2ac*/ float m_MaxLineDescender;
                /*0x2b0*/ int m_LineNumber;
                /*0x2b4*/ int m_LineVisibleCharacterCount;
                /*0x2b8*/ int m_FirstOverflowCharacterIndex;
                /*0x2bc*/ int m_PageNumber;
                /*0x2c0*/ float m_MarginLeft;
                /*0x2c4*/ float m_MarginRight;
                /*0x2c8*/ float m_Width;
                /*0x2cc*/ UnityEngine.TextCore.Text.Extents m_MeshExtents;
                /*0x2dc*/ float m_MaxCapHeight;
                /*0x2e0*/ float m_MaxAscender;
                /*0x2e4*/ float m_MaxDescender;
                /*0x2e8*/ bool m_IsNewPage;
                /*0x2e9*/ bool m_IsNonBreakingSpace;
                /*0x2f0*/ UnityEngine.TextCore.Text.WordWrapState m_SavedWordWrapState;
                /*0x600*/ UnityEngine.TextCore.Text.WordWrapState m_SavedLineState;
                /*0x910*/ int m_LoopCountA;
                /*0x914*/ UnityEngine.TextCore.Text.TextElementType m_TextElementType;
                /*0x915*/ bool m_IsParsingText;
                /*0x918*/ int m_SpriteIndex;
                /*0x91c*/ UnityEngine.Color32 m_SpriteColor;
                /*0x920*/ UnityEngine.TextCore.Text.TextElement m_CachedTextElement;
                /*0x928*/ UnityEngine.Color32 m_HighlightColor;
                /*0x92c*/ float m_CharWidthAdjDelta;
                /*0x930*/ UnityEngine.Matrix4x4 m_FxMatrix;
                /*0x970*/ float m_MaxFontSize;
                /*0x974*/ float m_MinFontSize;
                /*0x978*/ bool m_IsCharacterWrappingEnabled;
                /*0x97c*/ float m_StartOfLineAscender;
                /*0x980*/ float m_LineSpacingDelta;
                /*0x984*/ bool m_IsMaskingEnabled;
                /*0x988*/ UnityEngine.TextCore.Text.MaterialReference[] m_MaterialReferences;
                /*0x990*/ int m_SpriteCount;
                /*0x998*/ UnityEngine.TextCore.Text.TextProcessingStack<int> m_StyleStack;
                /*0x9b8*/ int m_SpriteAnimationId;
                /*0x9c0*/ uint[] m_InternalTextParsingBuffer;
                /*0x9c8*/ UnityEngine.TextCore.Text.RichTextTagAttribute[] m_Attributes;
                /*0x9d0*/ UnityEngine.TextCore.Text.XmlTagAttribute[] m_XmlAttribute;
                /*0x9d8*/ char[] m_RichTextTag;
                /*0x9e0*/ System.Collections.Generic.Dictionary<int, int> m_MaterialReferenceIndexLookup;
                /*0x9e8*/ bool m_IsCalculatingPreferredValues;
                /*0x9f0*/ UnityEngine.TextCore.Text.SpriteAsset m_DefaultSpriteAsset;
                /*0x9f8*/ bool m_TintSprite;
                /*0xa00*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Ellipsis;
                /*0xa20*/ UnityEngine.TextCore.Text.TextGenerator.SpecialCharacter m_Underline;
                /*0xa40*/ bool m_IsUsingBold;
                /*0xa41*/ bool m_IsSdfShader;
                /*0xa48*/ UnityEngine.TextCore.Text.TextElementInfo[] m_InternalTextElementInfo;
                /*0xa50*/ int m_RecursiveCount;

                static /*0x2944fd4*/ UnityEngine.TextCore.Text.TextGenerator GetTextGenerator();
                static /*0x2945528*/ void GenerateText(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x29457d0*/ UnityEngine.Vector2 GetCursorPosition(UnityEngine.TextCore.Text.TextInfo textInfo, UnityEngine.Rect screenRect, int index, bool inverseYAxis);
                static /*0x2945908*/ UnityEngine.Vector2 GetPreferredValues(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x2950114*/ void ClearMesh(bool updateMesh, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x294504c*/ TextGenerator();
                /*0x294569c*/ void Prepare(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x293e70c*/ void GenerateTextMesh(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x2946b28*/ void SaveWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, int index, int count, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x2946d40*/ int RestoreWordWrappingState(ref UnityEngine.TextCore.Text.WordWrapState state, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x2946f7c*/ bool ValidateHtmlTag(int[] chars, int startIndex, ref int endIndex, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x294b228*/ void SaveGlyphVertexInfo(float padding, float stylePadding, UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x294d014*/ void SaveSpriteVertexInfo(UnityEngine.Color32 vertexColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x294eac8*/ void DrawUnderlineMesh(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, UnityEngine.Color32 underlineColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x294fb68*/ void DrawTextHighlight(UnityEngine.Vector3 start, UnityEngine.Vector3 end, ref int index, UnityEngine.Color32 highlightColor, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x2950134*/ void EnableMasking();
                /*0x2950140*/ void DisableMasking();
                /*0x2945cb0*/ void SetArraySizes(int[] chars, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x2950148*/ UnityEngine.TextCore.Text.TextElement GetTextElement(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isUsingAlternativeTypeface);
                /*0x2945b70*/ void ComputeMarginSize(UnityEngine.Rect rect, UnityEngine.Vector4 margins);
                /*0x2945b48*/ void GetSpecialCharacters(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x2950434*/ void GetEllipsisSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x294fa30*/ void GetUnderlineSpecialCharacter(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                /*0x29505c0*/ float GetPaddingForMaterial(UnityEngine.Material material, bool extraPadding);
                /*0x2945a34*/ UnityEngine.Vector2 GetPreferredValuesInternal(UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                /*0x29506d4*/ UnityEngine.Vector2 CalculatePreferredValues(float defaultFontSize, UnityEngine.Vector2 marginSize, bool ignoreTextAutoSizing, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);

                struct SpecialCharacter
                {
                    /*0x10*/ UnityEngine.TextCore.Text.Character character;
                    /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                    /*0x20*/ UnityEngine.Material material;
                    /*0x28*/ int materialIndex;

                    /*0x295d404*/ SpecialCharacter(UnityEngine.TextCore.Text.Character character, int materialIndex);
                }
            }

            class SpriteAsset : UnityEngine.TextCore.Text.TextAsset
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_searchedSpriteAssets;
                /*0x38*/ System.Collections.Generic.Dictionary<int, int> m_NameLookup;
                /*0x40*/ System.Collections.Generic.Dictionary<uint, int> m_GlyphIndexLookup;
                /*0x48*/ UnityEngine.TextCore.FaceInfo m_FaceInfo;
                /*0xa8*/ UnityEngine.Texture m_SpriteAtlasTexture;
                /*0xb0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable;
                /*0xb8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup;
                /*0xc0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable;
                /*0xc8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup;
                /*0xd0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets;
                /*0xd8*/ bool m_IsSpriteAssetLookupTablesDirty;

                static /*0x295dbdc*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x295dda4*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x295df44*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByUnicodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, ref int spriteIndex);
                static /*0x295dff4*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCode(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, ref int spriteIndex, UnityEngine.TextCore.Text.TextSettings textSettings);
                static /*0x295e320*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, ref int spriteIndex);
                static /*0x295e4c0*/ UnityEngine.TextCore.Text.SpriteAsset SearchForSpriteByHashCodeInternal(UnityEngine.TextCore.Text.SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, ref int spriteIndex);
                /*0x295e7fc*/ SpriteAsset();
                /*0x295d4f8*/ UnityEngine.TextCore.FaceInfo get_faceInfo();
                /*0x295d514*/ void set_faceInfo(UnityEngine.TextCore.FaceInfo value);
                /*0x295d52c*/ UnityEngine.Texture get_spriteSheet();
                /*0x295d534*/ void set_spriteSheet(UnityEngine.Texture value);
                /*0x295d53c*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable();
                /*0x295da3c*/ void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x295da44*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable();
                /*0x295da68*/ void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Text.SpriteCharacter> value);
                /*0x295da70*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable();
                /*0x295da78*/ void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value);
                /*0x295da80*/ void Awake();
                /*0x295d560*/ void UpdateLookupTables();
                /*0x295da84*/ int GetSpriteIndexFromHashcode(int hashCode);
                /*0x295db0c*/ int GetSpriteIndexFromUnicode(uint unicode);
                /*0x295dba0*/ int GetSpriteIndexFromName(string name);
                /*0x295e570*/ void SortGlyphTable();
                /*0x295e6a8*/ void SortCharacterTable();
                /*0x295e7e4*/ void SortGlyphAndCharacterTables();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.SpriteAsset.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.Text.SpriteGlyph, uint> <>9__37_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.Text.SpriteCharacter, uint> <>9__38_0;

                    static /*0x295e8c0*/ <>c();
                    /*0x295e924*/ <>c();
                    /*0x295e92c*/ uint <SortGlyphTable>b__37_0(UnityEngine.TextCore.Text.SpriteGlyph item);
                    /*0x295e944*/ uint <SortCharacterTable>b__38_0(UnityEngine.TextCore.Text.SpriteCharacter c);
                }
            }

            struct Extents
            {
                /*0x10*/ UnityEngine.Vector2 min;
                /*0x18*/ UnityEngine.Vector2 max;

                /*0x295e95c*/ string ToString();
            }

            struct LineInfo
            {
                /*0x10*/ int controlCharacterCount;
                /*0x14*/ int characterCount;
                /*0x18*/ int visibleCharacterCount;
                /*0x1c*/ int spaceCount;
                /*0x20*/ int visibleSpaceCount;
                /*0x24*/ int wordCount;
                /*0x28*/ int firstCharacterIndex;
                /*0x2c*/ int firstVisibleCharacterIndex;
                /*0x30*/ int lastCharacterIndex;
                /*0x34*/ int lastVisibleCharacterIndex;
                /*0x38*/ float length;
                /*0x3c*/ float lineHeight;
                /*0x40*/ float ascender;
                /*0x44*/ float baseline;
                /*0x48*/ float descender;
                /*0x4c*/ float maxAdvance;
                /*0x50*/ float width;
                /*0x54*/ float marginLeft;
                /*0x58*/ float marginRight;
                /*0x5c*/ UnityEngine.TextCore.Text.TextAlignment alignment;
                /*0x60*/ UnityEngine.TextCore.Text.Extents lineExtents;
            }

            class MaterialManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<long, UnityEngine.Material> s_FallbackMaterials;

                static /*0x295f138*/ MaterialManager();
                static /*0x295ec08*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.Material sourceMaterial, UnityEngine.Material targetMaterial);
                static /*0x295ef68*/ UnityEngine.Material GetFallbackMaterial(UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.Material sourceMaterial, int atlasIndex);
            }

            struct MaterialReference
            {
                /*0x10*/ int index;
                /*0x18*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x20*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ bool isDefaultMaterial;
                /*0x31*/ bool isFallbackMaterial;
                /*0x38*/ UnityEngine.Material fallbackMaterial;
                /*0x40*/ float padding;
                /*0x44*/ int referenceCount;

                static /*0x295f240*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.FontAsset fontAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                static /*0x295f44c*/ int AddMaterialReference(UnityEngine.Material material, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, ref UnityEngine.TextCore.Text.MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<int, int> materialReferenceIndexLookup);
                /*0x295f1c4*/ MaterialReference(int index, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, UnityEngine.Material material, float padding);
            }

            struct TextVertex
            {
                /*0x10*/ UnityEngine.Vector3 position;
                /*0x1c*/ UnityEngine.Vector2 uv;
                /*0x24*/ UnityEngine.Vector2 uv2;
                /*0x2c*/ UnityEngine.Vector2 uv4;
                /*0x34*/ UnityEngine.Color32 color;
            }

            struct TextElementInfo
            {
                /*0x10*/ char character;
                /*0x14*/ int index;
                /*0x18*/ UnityEngine.TextCore.Text.TextElementType elementType;
                /*0x20*/ UnityEngine.TextCore.Text.TextElement textElement;
                /*0x28*/ UnityEngine.TextCore.Text.FontAsset fontAsset;
                /*0x30*/ UnityEngine.TextCore.Text.SpriteAsset spriteAsset;
                /*0x38*/ int spriteIndex;
                /*0x40*/ UnityEngine.Material material;
                /*0x48*/ int materialReferenceIndex;
                /*0x4c*/ bool isUsingAlternateTypeface;
                /*0x50*/ float pointSize;
                /*0x54*/ int lineNumber;
                /*0x58*/ int pageNumber;
                /*0x5c*/ int vertexIndex;
                /*0x60*/ UnityEngine.TextCore.Text.TextVertex vertexTopLeft;
                /*0x88*/ UnityEngine.TextCore.Text.TextVertex vertexBottomLeft;
                /*0xb0*/ UnityEngine.TextCore.Text.TextVertex vertexTopRight;
                /*0xd8*/ UnityEngine.TextCore.Text.TextVertex vertexBottomRight;
                /*0x100*/ UnityEngine.Vector3 topLeft;
                /*0x10c*/ UnityEngine.Vector3 bottomLeft;
                /*0x118*/ UnityEngine.Vector3 topRight;
                /*0x124*/ UnityEngine.Vector3 bottomRight;
                /*0x130*/ float origin;
                /*0x134*/ float ascender;
                /*0x138*/ float baseLine;
                /*0x13c*/ float descender;
                /*0x140*/ float xAdvance;
                /*0x144*/ float aspectRatio;
                /*0x148*/ float scale;
                /*0x14c*/ UnityEngine.Color32 color;
                /*0x150*/ UnityEngine.Color32 underlineColor;
                /*0x154*/ UnityEngine.Color32 strikethroughColor;
                /*0x158*/ UnityEngine.Color32 highlightColor;
                /*0x15c*/ UnityEngine.TextCore.Text.FontStyles style;
                /*0x160*/ bool isVisible;
            }

            class Character : UnityEngine.TextCore.Text.TextElement
            {
                /*0x295f624*/ Character();
                /*0x295428c*/ Character(uint unicode, UnityEngine.TextCore.Text.FontAsset fontAsset, UnityEngine.TextCore.Glyph glyph);
                /*0x2957758*/ Character(uint unicode, uint glyphIndex);
            }

            class TextUtilities
            {
                static /*0x295f66c*/ char ToUpperFast(char c);
                static /*0x295f6e0*/ uint ToUpperASCIIFast(uint c);
                static /*0x2952364*/ int GetHashCodeCaseInSensitive(string s);
                static /*0x29587f0*/ string UintToString(System.Collections.Generic.List<uint> unicodes);
            }

            class FontFeatureTable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;
                /*0x18*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;

                /*0x29591e4*/ FontFeatureTable();
                /*0x2959b3c*/ System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords();
                /*0x29545e4*/ void SortGlyphPairAdjustmentRecords();

                class <>c
                {
                    static /*0x0*/ UnityEngine.TextCore.Text.FontFeatureTable.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__6_0;
                    static /*0x10*/ System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, uint> <>9__6_1;

                    static /*0x295f754*/ <>c();
                    /*0x295f7b8*/ <>c();
                    /*0x295f7c0*/ uint <SortGlyphPairAdjustmentRecords>b__6_0(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                    /*0x295f808*/ uint <SortGlyphPairAdjustmentRecords>b__6_1(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord s);
                }
            }

            class TextStyle
            {
                static /*0x0*/ UnityEngine.TextCore.Text.TextStyle k_NormalStyle;
                /*0x10*/ string m_Name;
                /*0x18*/ int m_HashCode;
                /*0x20*/ string m_OpeningDefinition;
                /*0x28*/ string m_ClosingDefinition;
                /*0x30*/ int[] m_OpeningTagArray;
                /*0x38*/ int[] m_ClosingTagArray;
                /*0x40*/ uint[] m_OpeningTagUnicodeArray;
                /*0x48*/ uint[] m_ClosingTagUnicodeArray;

                /*0x295f850*/ int get_hashCode();
                /*0x295f858*/ int[] get_styleOpeningTagArray();
                /*0x295f860*/ int[] get_styleClosingTagArray();
                /*0x295f868*/ void RefreshStyle();
            }

            enum TextElementType
            {
                Character = 1,
                Sprite = 2,
            }

            class TextElement
            {
                /*0x10*/ UnityEngine.TextCore.Text.TextElementType m_ElementType;
                /*0x14*/ uint m_Unicode;
                /*0x18*/ UnityEngine.TextCore.Text.TextAsset m_TextAsset;
                /*0x20*/ UnityEngine.TextCore.Glyph m_Glyph;
                /*0x28*/ uint m_GlyphIndex;
                /*0x2c*/ float m_Scale;

                /*0x295f64c*/ TextElement();
                /*0x295fa4c*/ UnityEngine.TextCore.Text.TextElementType get_elementType();
                /*0x2953f18*/ uint get_unicode();
                /*0x295f65c*/ void set_unicode(uint value);
                /*0x295d4f0*/ UnityEngine.TextCore.Text.TextAsset get_textAsset();
                /*0x2953f20*/ void set_textAsset(UnityEngine.TextCore.Text.TextAsset value);
                /*0x295fa54*/ UnityEngine.TextCore.Glyph get_glyph();
                /*0x2953f28*/ void set_glyph(UnityEngine.TextCore.Glyph value);
                /*0x29538b0*/ uint get_glyphIndex();
                /*0x295f664*/ void set_glyphIndex(uint value);
                /*0x295fa5c*/ float get_scale();
                /*0x295f654*/ void set_scale(float value);
            }

            struct XmlTagAttribute
            {
                /*0x10*/ int nameHashCode;
                /*0x14*/ UnityEngine.TextCore.Text.TagValueType valueType;
                /*0x18*/ int valueStartIndex;
                /*0x1c*/ int valueLength;
                /*0x20*/ int valueHashCode;
            }

            struct RichTextTagAttribute
            {
                /*0x10*/ int nameHashCode;
                /*0x14*/ int valueHashCode;
                /*0x18*/ UnityEngine.TextCore.Text.TagValueType valueType;
                /*0x1c*/ int valueStartIndex;
                /*0x20*/ int valueLength;
            }

            struct WordWrapState
            {
                /*0x10*/ int previousWordBreak;
                /*0x14*/ int totalCharacterCount;
                /*0x18*/ int visibleCharacterCount;
                /*0x1c*/ int visibleSpriteCount;
                /*0x20*/ int visibleLinkCount;
                /*0x24*/ int firstCharacterIndex;
                /*0x28*/ int firstVisibleCharacterIndex;
                /*0x2c*/ int lastCharacterIndex;
                /*0x30*/ int lastVisibleCharIndex;
                /*0x34*/ int lineNumber;
                /*0x38*/ float maxCapHeight;
                /*0x3c*/ float maxAscender;
                /*0x40*/ float maxDescender;
                /*0x44*/ float maxLineAscender;
                /*0x48*/ float maxLineDescender;
                /*0x4c*/ float previousLineAscender;
                /*0x50*/ float xAdvance;
                /*0x54*/ float preferredWidth;
                /*0x58*/ float preferredHeight;
                /*0x5c*/ float previousLineScale;
                /*0x60*/ int wordCount;
                /*0x64*/ UnityEngine.TextCore.Text.FontStyles fontStyle;
                /*0x68*/ float fontScale;
                /*0x6c*/ float fontScaleMultiplier;
                /*0x70*/ float currentFontSize;
                /*0x74*/ float baselineOffset;
                /*0x78*/ float lineOffset;
                /*0x80*/ UnityEngine.TextCore.Text.TextInfo textInfo;
                /*0x88*/ UnityEngine.TextCore.Text.LineInfo lineInfo;
                /*0xe8*/ UnityEngine.Color32 vertexColor;
                /*0xec*/ UnityEngine.Color32 underlineColor;
                /*0xf0*/ UnityEngine.Color32 strikethroughColor;
                /*0xf4*/ UnityEngine.Color32 highlightColor;
                /*0xf8*/ UnityEngine.TextCore.Text.FontStyleStack basicStyleStack;
                /*0x108*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> colorStack;
                /*0x128*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> underlineColorStack;
                /*0x148*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> strikethroughColorStack;
                /*0x168*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> highlightColorStack;
                /*0x188*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack;
                /*0x1b0*/ UnityEngine.TextCore.Text.TextProcessingStack<float> sizeStack;
                /*0x1d0*/ UnityEngine.TextCore.Text.TextProcessingStack<float> indentStack;
                /*0x1f0*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> fontWeightStack;
                /*0x210*/ UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack;
                /*0x230*/ UnityEngine.TextCore.Text.TextProcessingStack<float> baselineStack;
                /*0x250*/ UnityEngine.TextCore.Text.TextProcessingStack<int> actionStack;
                /*0x270*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack;
                /*0x2c8*/ UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> lineJustificationStack;
                /*0x2e8*/ int spriteAnimationId;
                /*0x2f0*/ UnityEngine.TextCore.Text.FontAsset currentFontAsset;
                /*0x2f8*/ UnityEngine.TextCore.Text.SpriteAsset currentSpriteAsset;
                /*0x300*/ UnityEngine.Material currentMaterial;
                /*0x308*/ int currentMaterialIndex;
                /*0x30c*/ UnityEngine.TextCore.Text.Extents meshExtents;
                /*0x31c*/ bool tagNoParsing;
                /*0x31d*/ bool isNonBreakingSpace;
            }

            class TextGeneratorUtilities
            {
                static /*0x0*/ UnityEngine.Vector2 largePositiveVector2;
                static /*0x8*/ UnityEngine.Vector2 largeNegativeVector2;

                static /*0x2963090*/ TextGeneratorUtilities();
                static /*0x295fa64*/ bool Approximately(float a, float b);
                static /*0x295fa94*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int tagCount);
                static /*0x296007c*/ UnityEngine.Color32 HexCharsToColor(char[] hexChars, int startIndex, int length);
                static /*0x2960050*/ int HexToInt(char hex);
                static /*0x2960300*/ float ConvertToFloat(char[] chars, int startIndex, int length);
                static /*0x2960380*/ float ConvertToFloat(char[] chars, int startIndex, int length, ref int lastIndex);
                static /*0x29604e4*/ UnityEngine.Vector2 PackUV(float x, float y, float scale);
                static /*0x2960544*/ void StringToCharArray(string sourceText, ref int[] charBuffer, ref UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static void ResizeInternalArray<T>(ref T[] array);
                static /*0x2960f84*/ bool IsTagName(ref string text, string tag, int index);
                static /*0x2961688*/ bool IsTagName(ref int[] text, string tag, int index);
                static /*0x2961754*/ bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, ref int srcOffset, ref int[] charBuffer, ref int writeIndex, ref UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x296102c*/ bool ReplaceOpeningStyleTag(ref string sourceText, int srcIndex, ref int srcOffset, ref int[] charBuffer, ref int writeIndex, ref UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x2961360*/ void ReplaceClosingStyleTag(ref int[] charBuffer, ref int writeIndex, ref UnityEngine.TextCore.Text.TextProcessingStack<int> styleStack, ref UnityEngine.TextCore.Text.TextGenerationSettings generationSettings);
                static /*0x2961b1c*/ UnityEngine.TextCore.Text.TextStyle GetStyle(UnityEngine.TextCore.Text.TextGenerationSettings generationSetting, int hashCode);
                static /*0x2960d8c*/ int GetUtf32(string text, int i);
                static /*0x2960eb8*/ int GetUtf16(string text, int i);
                static /*0x2961a88*/ int GetTagHashCode(ref int[] text, int index, ref int closeIndex);
                static /*0x2961c08*/ int GetTagHashCode(ref string text, int index, ref int closeIndex);
                static /*0x2961cc0*/ void FillCharacterVertexBuffers(int i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x2962540*/ void FillSpriteVertexBuffers(int i, UnityEngine.TextCore.Text.TextGenerationSettings generationSettings, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x2962d30*/ void AdjustLineOffset(int startIndex, int endIndex, float offset, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x2962eb0*/ void ResizeLineExtents(int size, UnityEngine.TextCore.Text.TextInfo textInfo);
                static /*0x296305c*/ UnityEngine.TextCore.Text.FontStyles LegacyStyleToNewStyle(UnityEngine.FontStyle fontStyle);
                static /*0x296306c*/ UnityEngine.TextCore.Text.TextAlignment LegacyAlignmentToNewAlignment(UnityEngine.TextAnchor anchor);
            }

            struct PageInfo
            {
                /*0x10*/ int firstCharacterIndex;
                /*0x14*/ int lastCharacterIndex;
                /*0x18*/ float ascender;
                /*0x1c*/ float baseLine;
                /*0x20*/ float descender;
            }

            struct WordInfo
            {
                /*0x10*/ int firstCharacterIndex;
                /*0x14*/ int lastCharacterIndex;
                /*0x18*/ int characterCount;
            }

            class TextInfo
            {
                static /*0x0*/ UnityEngine.Vector2 s_InfinityVectorPositive;
                static /*0x8*/ UnityEngine.Vector2 s_InfinityVectorNegative;
                /*0x10*/ int characterCount;
                /*0x14*/ int spriteCount;
                /*0x18*/ int spaceCount;
                /*0x1c*/ int wordCount;
                /*0x20*/ int linkCount;
                /*0x24*/ int lineCount;
                /*0x28*/ int pageCount;
                /*0x2c*/ int materialCount;
                /*0x30*/ UnityEngine.TextCore.Text.TextElementInfo[] textElementInfo;
                /*0x38*/ UnityEngine.TextCore.Text.WordInfo[] wordInfo;
                /*0x40*/ UnityEngine.TextCore.Text.LinkInfo[] linkInfo;
                /*0x48*/ UnityEngine.TextCore.Text.LineInfo[] lineInfo;
                /*0x50*/ UnityEngine.TextCore.Text.PageInfo[] pageInfo;
                /*0x58*/ UnityEngine.TextCore.Text.MeshInfo[] meshInfo;
                /*0x60*/ bool isDirty;

                static /*0x296449c*/ TextInfo();
                static void Resize<T>(ref T[] array, int size);
                static void Resize<T>(ref T[] array, int size, bool isBlockAllocated);
                /*0x29640f4*/ TextInfo();
                /*0x2964228*/ void Clear();
                /*0x2964284*/ void ClearMeshInfo(bool updateMesh);
                /*0x2964330*/ void ClearLineInfo();
            }

            class TextShaderUtilities
            {
                static /*0x0*/ int ID_MainTex;
                static /*0x4*/ int ID_FaceTex;
                static /*0x8*/ int ID_FaceColor;
                static /*0xc*/ int ID_FaceDilate;
                static /*0x10*/ int ID_Shininess;
                static /*0x14*/ int ID_UnderlayColor;
                static /*0x18*/ int ID_UnderlayOffsetX;
                static /*0x1c*/ int ID_UnderlayOffsetY;
                static /*0x20*/ int ID_UnderlayDilate;
                static /*0x24*/ int ID_UnderlaySoftness;
                static /*0x28*/ int ID_WeightNormal;
                static /*0x2c*/ int ID_WeightBold;
                static /*0x30*/ int ID_OutlineTex;
                static /*0x34*/ int ID_OutlineWidth;
                static /*0x38*/ int ID_OutlineSoftness;
                static /*0x3c*/ int ID_OutlineColor;
                static /*0x40*/ int ID_Outline2Color;
                static /*0x44*/ int ID_Outline2Width;
                static /*0x48*/ int ID_Padding;
                static /*0x4c*/ int ID_GradientScale;
                static /*0x50*/ int ID_ScaleX;
                static /*0x54*/ int ID_ScaleY;
                static /*0x58*/ int ID_PerspectiveFilter;
                static /*0x5c*/ int ID_Sharpness;
                static /*0x60*/ int ID_TextureWidth;
                static /*0x64*/ int ID_TextureHeight;
                static /*0x68*/ int ID_BevelAmount;
                static /*0x6c*/ int ID_GlowColor;
                static /*0x70*/ int ID_GlowOffset;
                static /*0x74*/ int ID_GlowPower;
                static /*0x78*/ int ID_GlowOuter;
                static /*0x7c*/ int ID_GlowInner;
                static /*0x80*/ int ID_LightAngle;
                static /*0x84*/ int ID_EnvMap;
                static /*0x88*/ int ID_EnvMatrix;
                static /*0x8c*/ int ID_EnvMatrixRotation;
                static /*0x90*/ int ID_MaskCoord;
                static /*0x94*/ int ID_ClipRect;
                static /*0x98*/ int ID_MaskSoftnessX;
                static /*0x9c*/ int ID_MaskSoftnessY;
                static /*0xa0*/ int ID_VertexOffsetX;
                static /*0xa4*/ int ID_VertexOffsetY;
                static /*0xa8*/ int ID_UseClipRect;
                static /*0xac*/ int ID_StencilID;
                static /*0xb0*/ int ID_StencilOp;
                static /*0xb4*/ int ID_StencilComp;
                static /*0xb8*/ int ID_StencilReadMask;
                static /*0xbc*/ int ID_StencilWriteMask;
                static /*0xc0*/ int ID_ShaderFlags;
                static /*0xc4*/ int ID_ScaleRatio_A;
                static /*0xc8*/ int ID_ScaleRatio_B;
                static /*0xcc*/ int ID_ScaleRatio_C;
                static /*0xd0*/ string Keyword_Bevel;
                static /*0xd8*/ string Keyword_Glow;
                static /*0xe0*/ string Keyword_Underlay;
                static /*0xe8*/ string Keyword_Ratios;
                static /*0xf0*/ string Keyword_MASK_SOFT;
                static /*0xf8*/ string Keyword_MASK_HARD;
                static /*0x100*/ string Keyword_MASK_TEX;
                static /*0x108*/ string Keyword_Outline;
                static /*0x110*/ string ShaderTag_ZTestMode;
                static /*0x118*/ string ShaderTag_CullMode;
                static /*0x120*/ float m_clamp;
                static /*0x124*/ bool isInitialized;
                static /*0x128*/ UnityEngine.Shader k_ShaderRef_MobileSDF;
                static /*0x130*/ UnityEngine.Shader k_ShaderRef_MobileBitmap;

                static /*0x29647c0*/ TextShaderUtilities();
                static /*0x2964508*/ UnityEngine.Shader get_ShaderRef_MobileSDF();
                static /*0x2964664*/ UnityEngine.Shader get_ShaderRef_MobileBitmap();
                static /*0x2964950*/ void GetShaderPropertyIDs();
                static /*0x29652d8*/ void UpdateShaderRatios(UnityEngine.Material mat);
                static /*0x2965734*/ bool IsMaskingEnabled(UnityEngine.Material material);
                static /*0x29658d0*/ float GetPadding(UnityEngine.Material material, bool enableExtraPadding, bool isBold);
            }

            enum MarkupTag
            {
                BOLD = 66,
                SLASH_BOLD = 1613,
                ITALIC = 73,
                SLASH_ITALIC = 1606,
                UNDERLINE = 85,
                SLASH_UNDERLINE = 1626,
                STRIKETHROUGH = 83,
                SLASH_STRIKETHROUGH = 1628,
                MARK = 2699125,
                SLASH_MARK = 57644506,
                SUBSCRIPT = 92132,
                SLASH_SUBSCRIPT = 1770219,
                SUPERSCRIPT = 92150,
                SLASH_SUPERSCRIPT = 1770233,
                COLOR = 81999901,
                SLASH_COLOR = 1909026194,
                ALPHA = 75165780,
                A = 65,
                SLASH_A = 1614,
                SIZE = 3061285,
                SLASH_SIZE = 58429962,
                SPRITE = -991527447,
                NO_BREAK = 2856657,
                SLASH_NO_BREAK = 57477502,
                STYLE = 100252951,
                SLASH_STYLE = 1927738392,
                FONT = 2586451,
                SLASH_FONT = 57747708,
                SLASH_MATERIAL = -1100708252,
                LINK = 2656128,
                SLASH_LINK = 57686191,
                FONT_WEIGHT = -1889896162,
                SLASH_FONT_WEIGHT = -757976431,
                NO_PARSE = -408011596,
                SLASH_NO_PARSE = -294095813,
                POSITION = 85420,
                SLASH_POSITION = 1777699,
                VERTICAL_OFFSET = 1952379995,
                SLASH_VERTICAL_OFFSET = -11107948,
                SPACE = 100083556,
                SLASH_SPACE = 1927873067,
                PAGE = 2808691,
                SLASH_PAGE = 58683868,
                ALIGN = 75138797,
                SLASH_ALIGN = 1916026786,
                WIDTH = 105793766,
                SLASH_WIDTH = 1923459625,
                GRADIENT = -1999759898,
                SLASH_GRADIENT = -1854491959,
                CHARACTER_SPACE = -1584382009,
                SLASH_CHARACTER_SPACE = -1394426712,
                MONOSPACE = -1340221943,
                SLASH_MONOSPACE = -1638865562,
                CLASS = 82115566,
                INDENT = -1514123076,
                SLASH_INDENT = -1496889389,
                LINE_INDENT = -844305121,
                SLASH_LINE_INDENT = 93886352,
                MARGIN = -1355614050,
                SLASH_MARGIN = -1649644303,
                MARGIN_LEFT = -272933656,
                MARGIN_RIGHT = -447416589,
                LINE_HEIGHT = -799081892,
                SLASH_LINE_HEIGHT = 200452819,
                ACTION = -1827519330,
                SLASH_ACTION = -1187217679,
                SCALE = 100553336,
                SLASH_SCALE = 1928413879,
                ROTATE = -1000007783,
                SLASH_ROTATE = -764695562,
                LOWERCASE = -1506899689,
                SLASH_LOWERCASE = -1451284584,
                ALLCAPS = 218273952,
                SLASH_ALLCAPS = -797437649,
                UPPERCASE = -305409418,
                SLASH_UPPERCASE = -582368199,
                SMALLCAPS = -766062114,
                SLASH_SMALLCAPS = 199921873,
                LIGA = 2655971,
                SLASH_LIGA = 57686604,
                FRAC = 2598518,
                SLASH_FRAC = 57774681,
                NAME = 2875623,
                INDEX = 84268030,
                TINT = 2960519,
                ANIM = 2283339,
                MATERIAL = 825491659,
                HREF = 2535353,
                ANGLE = 75347905,
                RED = 91635,
                GREEN = 87065851,
                BLUE = 2457214,
                YELLOW = -882444668,
                ORANGE = -1108587920,
                BLACK = 81074727,
                WHITE = 105680263,
                PURPLE = -1250222130,
                BR = 2256,
                ZWSP = 3288238,
                NBSP = 2869039,
                SHY = 92674,
                LEFT = 2660507,
                RIGHT = 99937376,
                CENTER = -1591113269,
                JUSTIFIED = 817091359,
                FLUSH = 85552164,
                NONE = 2857034,
                PLUS = 43,
                MINUS = 45,
                PX = 2568,
                PLUS_PX = 49507,
                MINUS_PX = 47461,
                EM = 2216,
                PLUS_EM = 49091,
                MINUS_EM = 46789,
                PCT = 85031,
                PLUS_PCT = 1634348,
                MINUS_PCT = 1567082,
                PERCENTAGE = 37,
                PLUS_PERCENTAGE = 1454,
                MINUS_PERCENTAGE = 1512,
                TRUE = 2932022,
                FALSE = 85422813,
                INVALID = 1585415185,
                NORMAL = -1183493901,
                DEFAULT = -620974005,
            }

            enum TagValueType
            {
                None = 0,
                NumericalValue = 1,
                StringValue = 2,
                ColorValue = 4,
            }

            enum TagUnitType
            {
                Pixels = 0,
                FontUnits = 1,
                Percentage = 2,
            }

            enum TextAlignment
            {
                TopLeft = 257,
                TopCenter = 258,
                TopRight = 260,
                TopJustified = 264,
                TopFlush = 272,
                TopGeoAligned = 288,
                MiddleLeft = 513,
                MiddleCenter = 514,
                MiddleRight = 516,
                MiddleJustified = 520,
                MiddleFlush = 528,
                MiddleGeoAligned = 544,
                BottomLeft = 1025,
                BottomCenter = 1026,
                BottomRight = 1028,
                BottomJustified = 1032,
                BottomFlush = 1040,
                BottomGeoAligned = 1056,
                BaselineLeft = 2049,
                BaselineCenter = 2050,
                BaselineRight = 2052,
                BaselineJustified = 2056,
                BaselineFlush = 2064,
                BaselineGeoAligned = 2080,
                MidlineLeft = 4097,
                MidlineCenter = 4098,
                MidlineRight = 4100,
                MidlineJustified = 4104,
                MidlineFlush = 4112,
                MidlineGeoAligned = 4128,
                CaplineLeft = 8193,
                CaplineCenter = 8194,
                CaplineRight = 8196,
                CaplineJustified = 8200,
                CaplineFlush = 8208,
                CaplineGeoAligned = 8224,
            }

            enum FontStyles
            {
                Normal = 0,
                Bold = 1,
                Italic = 2,
                Underline = 4,
                LowerCase = 8,
                UpperCase = 16,
                SmallCaps = 32,
                Strikethrough = 64,
                Superscript = 128,
                Subscript = 256,
                Highlight = 512,
            }

            class TextResourceManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup;
                static /*0x10*/ System.Collections.Generic.Dictionary<long, UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;
                static /*0x18*/ System.Collections.Generic.List<int> s_FontAssetRemovalList;
                static /*0x20*/ int k_RegularStyleHashCode;

                static /*0x29664dc*/ TextResourceManager();
                static /*0x2965f78*/ void AddFontAsset(UnityEngine.TextCore.Text.FontAsset fontAsset);

                struct FontAssetRef
                {
                    /*0x10*/ int nameHashCode;
                    /*0x14*/ int familyNameHashCode;
                    /*0x18*/ int styleNameHashCode;
                    /*0x20*/ long familyNameAndStyleHashCode;
                    /*0x28*/ UnityEngine.TextCore.Text.FontAsset fontAsset;

                    /*0x29664c4*/ FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, UnityEngine.TextCore.Text.FontAsset fontAsset);
                }
            }

            enum ColorGradientMode
            {
                Single = 0,
                HorizontalGradient = 1,
                VerticalGradient = 2,
                FourCornersGradient = 3,
            }

            class TextColorGradient : UnityEngine.ScriptableObject
            {
                static UnityEngine.TextCore.Text.ColorGradientMode k_DefaultColorMode = 3;
                static /*0x0*/ UnityEngine.Color k_DefaultColor;
                /*0x18*/ UnityEngine.TextCore.Text.ColorGradientMode colorMode;
                /*0x1c*/ UnityEngine.Color topLeft;
                /*0x2c*/ UnityEngine.Color topRight;
                /*0x3c*/ UnityEngine.Color bottomLeft;
                /*0x4c*/ UnityEngine.Color bottomRight;

                static /*0x2966828*/ TextColorGradient();
                /*0x296667c*/ TextColorGradient();
                /*0x2966718*/ TextColorGradient(UnityEngine.Color color);
                /*0x2966784*/ TextColorGradient(UnityEngine.Color color0, UnityEngine.Color color1, UnityEngine.Color color2, UnityEngine.Color color3);
            }

            class TextAsset : UnityEngine.ScriptableObject
            {
                /*0x18*/ string m_Version;
                /*0x20*/ int m_InstanceID;
                /*0x24*/ int m_HashCode;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ int m_MaterialHashCode;

                /*0x296693c*/ TextAsset();
                /*0x2966874*/ string get_version();
                /*0x296687c*/ void set_version(string value);
                /*0x296646c*/ int get_instanceID();
                /*0x2966494*/ int get_hashCode();
                /*0x2966884*/ void set_hashCode(int value);
                /*0x296688c*/ UnityEngine.Material get_material();
                /*0x2966894*/ void set_material(UnityEngine.Material value);
                /*0x296689c*/ int get_materialHashCode();
                /*0x2966934*/ void set_materialHashCode(int value);
            }

            class SpriteCharacter : UnityEngine.TextCore.Text.TextElement
            {
                /*0x30*/ string m_Name;
                /*0x38*/ int m_HashCode;

                /*0x296694c*/ SpriteCharacter();
                /*0x2966944*/ string get_name();
            }

            struct FontStyleStack
            {
                /*0x10*/ byte bold;
                /*0x11*/ byte italic;
                /*0x12*/ byte underline;
                /*0x13*/ byte strikethrough;
                /*0x14*/ byte highlight;
                /*0x15*/ byte superscript;
                /*0x16*/ byte subscript;
                /*0x17*/ byte uppercase;
                /*0x18*/ byte lowercase;
                /*0x19*/ byte smallcaps;

                /*0x296696c*/ void Clear();
                /*0x2966978*/ byte Add(UnityEngine.TextCore.Text.FontStyles style);
                /*0x2966a74*/ byte Remove(UnityEngine.TextCore.Text.FontStyles style);
            }

            struct TextProcessingStack<T>
            {
                /*0x0*/ T[] itemStack;
                /*0x0*/ int index;
                /*0x0*/ T m_DefaultItem;
                /*0x0*/ int m_Capacity;
                /*0x0*/ int m_RolloverSize;
                /*0x0*/ int m_Count;

                TextProcessingStack(T[] stack);
                TextProcessingStack(int capacity);
                void Clear();
                void SetDefault(T item);
                void Add(T item);
                T Remove();
                void Push(T item);
                T Pop();
                T Peek();
                T CurrentItem();
            }

            class FontAssetUtilities
            {
                static /*0x0*/ System.Collections.Generic.HashSet<int> k_SearchedAssets;

                static /*0x2966b94*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x2966c9c*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAsset_Internal(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x2967070*/ UnityEngine.TextCore.Text.Character GetCharacterFromFontAssets(uint unicode, UnityEngine.TextCore.Text.FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, UnityEngine.TextCore.Text.FontStyles fontStyle, UnityEngine.TextCore.Text.TextFontWeight fontWeight, ref bool isAlternativeTypeface);
                static /*0x2967228*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
                static /*0x29674c0*/ UnityEngine.TextCore.Text.SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, UnityEngine.TextCore.Text.SpriteAsset spriteAsset, bool includeFallbacks);
            }

            enum VertexSortingOrder
            {
                Normal = 0,
                Reverse = 1,
            }

            struct MeshInfo
            {
                static /*0x0*/ UnityEngine.Color32 k_DefaultColor;
                /*0x10*/ int vertexCount;
                /*0x18*/ UnityEngine.Vector3[] vertices;
                /*0x20*/ UnityEngine.Vector2[] uvs0;
                /*0x28*/ UnityEngine.Vector2[] uvs2;
                /*0x30*/ UnityEngine.Color32[] colors32;
                /*0x38*/ int[] triangles;
                /*0x40*/ UnityEngine.Material material;

                static /*0x29681f8*/ MeshInfo();
                /*0x2967678*/ MeshInfo(int size);
                /*0x29679cc*/ void ResizeMeshInfo(int size);
                /*0x2964304*/ void Clear(bool uploadChanges);
                /*0x2967bb4*/ void ClearUnusedVertices();
                /*0x2967bf0*/ void SortGeometry(UnityEngine.TextCore.Text.VertexSortingOrder order);
                /*0x2967c6c*/ void SwapVertexData(int src, int dst);
            }

            class ColorUtilities
            {
                static /*0x2968244*/ bool CompareColors(UnityEngine.Color32 a, UnityEngine.Color32 b);
                static /*0x2968254*/ UnityEngine.Color32 MultiplyColors(UnityEngine.Color32 c1, UnityEngine.Color32 c2);
            }

            class TextStyleSheet : UnityEngine.ScriptableObject
            {
                /*0x18*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary;

                /*0x2968604*/ TextStyleSheet();
                /*0x2968314*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles();
                /*0x296831c*/ UnityEngine.TextCore.Text.TextStyle GetStyle(int hashCode);
                /*0x2968568*/ UnityEngine.TextCore.Text.TextStyle GetStyle(string name);
                /*0x2968600*/ void RefreshStyles();
                /*0x29683a4*/ void LoadStyleDictionaryInternal();
            }

            class UnicodeLineBreakingRules
            {
                static /*0x0*/ UnityEngine.TextCore.Text.UnicodeLineBreakingRules s_Instance;
                static /*0x8*/ System.Collections.Generic.HashSet<uint> s_LeadingCharactersLookup;
                static /*0x10*/ System.Collections.Generic.HashSet<uint> s_FollowingCharactersLookup;
                /*0x10*/ UnityEngine.TextAsset m_UnicodeLineBreakingRules;
                /*0x18*/ UnityEngine.TextAsset m_LeadingCharacters;
                /*0x20*/ UnityEngine.TextAsset m_FollowingCharacters;
                /*0x28*/ bool m_UseModernHangulLineBreakingRules;

                static /*0x2968b98*/ UnicodeLineBreakingRules();
                static /*0x296870c*/ void LoadLineBreakingRules();
                static /*0x2968aa8*/ System.Collections.Generic.HashSet<uint> GetCharacters(UnityEngine.TextAsset file);
                /*0x2968b90*/ UnicodeLineBreakingRules();
                /*0x2968684*/ System.Collections.Generic.HashSet<uint> get_leadingCharactersLookup();
                /*0x2968a20*/ System.Collections.Generic.HashSet<uint> get_followingCharactersLookup();
            }

            class SpriteGlyph : UnityEngine.TextCore.Glyph
            {
                /*0x48*/ UnityEngine.Sprite sprite;

                /*0x2968bfc*/ SpriteGlyph();
            }
        }
    }
}
