class <Module>
{
}

namespace UnityEngine
{
    namespace TextCore
    {
        struct FaceInfo
        {
            /*0x10*/ int m_FaceIndex;
            /*0x18*/ string m_FamilyName;
            /*0x20*/ string m_StyleName;
            /*0x28*/ int m_PointSize;
            /*0x2c*/ float m_Scale;
            /*0x30*/ int m_UnitsPerEM;
            /*0x34*/ float m_LineHeight;
            /*0x38*/ float m_AscentLine;
            /*0x3c*/ float m_CapLine;
            /*0x40*/ float m_MeanLine;
            /*0x44*/ float m_Baseline;
            /*0x48*/ float m_DescentLine;
            /*0x4c*/ float m_SuperscriptOffset;
            /*0x50*/ float m_SuperscriptSize;
            /*0x54*/ float m_SubscriptOffset;
            /*0x58*/ float m_SubscriptSize;
            /*0x5c*/ float m_UnderlineOffset;
            /*0x60*/ float m_UnderlineThickness;
            /*0x64*/ float m_StrikethroughOffset;
            /*0x68*/ float m_StrikethroughThickness;
            /*0x6c*/ float m_TabWidth;

            /*0x293bdb8*/ int get_faceIndex();
            /*0x293bdc0*/ string get_familyName();
            /*0x293bdc8*/ void set_familyName(string value);
            /*0x293bdd0*/ string get_styleName();
            /*0x293bdd8*/ void set_styleName(string value);
            /*0x293bde0*/ int get_pointSize();
            /*0x293bde8*/ void set_pointSize(int value);
            /*0x293bdf0*/ float get_scale();
            /*0x293bdf8*/ void set_scale(float value);
            /*0x293be00*/ float get_lineHeight();
            /*0x293be08*/ void set_lineHeight(float value);
            /*0x293be10*/ float get_ascentLine();
            /*0x293be18*/ void set_ascentLine(float value);
            /*0x293be20*/ float get_capLine();
            /*0x293be28*/ void set_capLine(float value);
            /*0x293be30*/ float get_meanLine();
            /*0x293be38*/ void set_meanLine(float value);
            /*0x293be40*/ float get_baseline();
            /*0x293be48*/ void set_baseline(float value);
            /*0x293be50*/ float get_descentLine();
            /*0x293be58*/ void set_descentLine(float value);
            /*0x293be60*/ float get_superscriptOffset();
            /*0x293be68*/ void set_superscriptOffset(float value);
            /*0x293be70*/ float get_superscriptSize();
            /*0x293be78*/ void set_superscriptSize(float value);
            /*0x293be80*/ float get_subscriptOffset();
            /*0x293be88*/ void set_subscriptOffset(float value);
            /*0x293be90*/ float get_subscriptSize();
            /*0x293be98*/ void set_subscriptSize(float value);
            /*0x293bea0*/ float get_underlineOffset();
            /*0x293bea8*/ void set_underlineOffset(float value);
            /*0x293beb0*/ float get_underlineThickness();
            /*0x293beb8*/ void set_underlineThickness(float value);
            /*0x293bec0*/ float get_strikethroughOffset();
            /*0x293bec8*/ void set_strikethroughOffset(float value);
            /*0x293bed0*/ void set_strikethroughThickness(float value);
            /*0x293bed8*/ float get_tabWidth();
            /*0x293bee0*/ void set_tabWidth(float value);
        }

        enum GlyphClassDefinitionType
        {
            Undefined = 0,
            Base = 1,
            Ligature = 2,
            Mark = 3,
            Component = 4,
        }

        struct GlyphRect : System.IEquatable<UnityEngine.TextCore.GlyphRect>
        {
            static /*0x0*/ UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;
            /*0x10*/ int m_X;
            /*0x14*/ int m_Y;
            /*0x18*/ int m_Width;
            /*0x1c*/ int m_Height;

            static /*0x293c0dc*/ GlyphRect();
            static /*0x293bf08*/ UnityEngine.TextCore.GlyphRect get_zero();
            /*0x293bf60*/ GlyphRect(int x, int y, int width, int height);
            /*0x293bee8*/ int get_x();
            /*0x293bef0*/ int get_y();
            /*0x293bef8*/ int get_width();
            /*0x293bf00*/ int get_height();
            /*0x293bf6c*/ int GetHashCode();
            /*0x293bfd0*/ bool Equals(object obj);
            /*0x293c048*/ bool Equals(UnityEngine.TextCore.GlyphRect other);
        }

        struct GlyphMetrics : System.IEquatable<UnityEngine.TextCore.GlyphMetrics>
        {
            /*0x10*/ float m_Width;
            /*0x14*/ float m_Height;
            /*0x18*/ float m_HorizontalBearingX;
            /*0x1c*/ float m_HorizontalBearingY;
            /*0x20*/ float m_HorizontalAdvance;

            /*0x293c14c*/ GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance);
            /*0x293c124*/ float get_width();
            /*0x293c12c*/ float get_height();
            /*0x293c134*/ float get_horizontalBearingX();
            /*0x293c13c*/ float get_horizontalBearingY();
            /*0x293c144*/ float get_horizontalAdvance();
            /*0x293c15c*/ int GetHashCode();
            /*0x293c1c8*/ bool Equals(object obj);
            /*0x293c248*/ bool Equals(UnityEngine.TextCore.GlyphMetrics other);
        }

        class Glyph
        {
            /*0x10*/ uint m_Index;
            /*0x14*/ UnityEngine.TextCore.GlyphMetrics m_Metrics;
            /*0x28*/ UnityEngine.TextCore.GlyphRect m_GlyphRect;
            /*0x38*/ float m_Scale;
            /*0x3c*/ int m_AtlasIndex;
            /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType;

            /*0x293c358*/ Glyph();
            /*0x293c380*/ Glyph(UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
            /*0x293c40c*/ Glyph(uint index, UnityEngine.TextCore.GlyphMetrics metrics, UnityEngine.TextCore.GlyphRect glyphRect, float scale, int atlasIndex);
            /*0x293c2ec*/ uint get_index();
            /*0x293c2f4*/ void set_index(uint value);
            /*0x293c2fc*/ UnityEngine.TextCore.GlyphMetrics get_metrics();
            /*0x293c310*/ void set_metrics(UnityEngine.TextCore.GlyphMetrics value);
            /*0x293c324*/ UnityEngine.TextCore.GlyphRect get_glyphRect();
            /*0x293c330*/ void set_glyphRect(UnityEngine.TextCore.GlyphRect value);
            /*0x293c338*/ float get_scale();
            /*0x293c340*/ void set_scale(float value);
            /*0x293c348*/ int get_atlasIndex();
            /*0x293c350*/ void set_atlasIndex(int value);
        }

        namespace LowLevel
        {
            struct GlyphMarshallingStruct
            {
                /*0x10*/ uint index;
                /*0x14*/ UnityEngine.TextCore.GlyphMetrics metrics;
                /*0x28*/ UnityEngine.TextCore.GlyphRect glyphRect;
                /*0x38*/ float scale;
                /*0x3c*/ int atlasIndex;
                /*0x40*/ UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType;
            }

            enum GlyphLoadFlags
            {
                LOAD_DEFAULT = 0,
                LOAD_NO_SCALE = 1,
                LOAD_NO_HINTING = 2,
                LOAD_RENDER = 4,
                LOAD_NO_BITMAP = 8,
                LOAD_FORCE_AUTOHINT = 32,
                LOAD_MONOCHROME = 4096,
                LOAD_NO_AUTOHINT = 32768,
                LOAD_COLOR = 1048576,
                LOAD_COMPUTE_METRICS = 2097152,
                LOAD_BITMAP_METRICS_ONLY = 4194304,
            }

            enum FontEngineError
            {
                Success = 0,
                Invalid_File_Path = 1,
                Invalid_File_Format = 2,
                Invalid_File_Structure = 3,
                Invalid_File = 4,
                Invalid_Table = 8,
                Invalid_Glyph_Index = 16,
                Invalid_Character_Code = 17,
                Invalid_Pixel_Size = 23,
                Invalid_Library = 33,
                Invalid_Face = 35,
                Invalid_Library_or_Face = 41,
                Atlas_Generation_Cancelled = 100,
                Invalid_SharedTextureData = 101,
                OpenTypeLayoutLookup_Mismatch = 116,
            }

            enum GlyphRenderMode
            {
                SMOOTH_HINTED = 4121,
                SMOOTH = 4117,
                COLOR_HINTED = 69656,
                COLOR = 69652,
                RASTER_HINTED = 4122,
                RASTER = 4118,
                SDF = 4134,
                SDF8 = 8230,
                SDF16 = 16422,
                SDF32 = 32806,
                SDFAA_HINTED = 4169,
                SDFAA = 4165,
            }

            enum GlyphPackingMode
            {
                BestShortSideFit = 0,
                BestLongSideFit = 1,
                BestAreaFit = 2,
                BottomLeftRule = 3,
                ContactPointRule = 4,
            }

            struct FontReference
            {
                /*0x10*/ string familyName;
                /*0x18*/ string styleName;
                /*0x20*/ int faceIndex;
                /*0x28*/ string filePath;
            }

            class FontEngine
            {
                static /*0x0*/ UnityEngine.TextCore.Glyph[] s_Glyphs;
                static /*0x8*/ uint[] s_GlyphIndexes_MarshallingArray_A;
                static /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN;
                static /*0x18*/ UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT;
                static /*0x20*/ UnityEngine.TextCore.GlyphRect[] s_FreeGlyphRects;
                static /*0x28*/ UnityEngine.TextCore.GlyphRect[] s_UsedGlyphRects;
                static /*0x30*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray;
                static /*0x38*/ System.Collections.Generic.Dictionary<uint, UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary;

                static /*0x293e0a8*/ FontEngine();
                static /*0x293c47c*/ UnityEngine.TextCore.LowLevel.FontEngineError InitializeFontEngine();
                static /*0x293c4e4*/ int InitializeFontEngine_Internal();
                static /*0x293c50c*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex);
                static /*0x293c598*/ int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex);
                static /*0x293c5ec*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize);
                static /*0x293c670*/ int LoadFontFace_With_Size_FromFont_Internal(UnityEngine.Font font, int pointSize);
                static /*0x293c6b4*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x293c740*/ int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(UnityEngine.Font font, int pointSize, int faceIndex);
                static /*0x293c794*/ UnityEngine.TextCore.LowLevel.FontEngineError LoadFontFace(string familyName, string styleName, int pointSize);
                static /*0x293c820*/ int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize);
                static /*0x293c874*/ bool TryGetSystemFontReference(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x293c900*/ bool TryGetSystemFontReference_Internal(string familyName, string styleName, ref UnityEngine.TextCore.LowLevel.FontReference fontRef);
                static /*0x293c954*/ UnityEngine.TextCore.FaceInfo GetFaceInfo();
                static /*0x293c9f4*/ int GetFaceInfo_Internal(ref UnityEngine.TextCore.FaceInfo faceInfo);
                static /*0x293ca30*/ uint GetGlyphIndex(uint unicode);
                static /*0x293ca6c*/ bool TryGetGlyphWithUnicodeValue(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x293cbc0*/ bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x293cc14*/ bool TryGetGlyphWithIndexValue(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags flags, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x293cd68*/ bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, UnityEngine.TextCore.LowLevel.GlyphLoadFlags loadFlags, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyphStruct);
                static /*0x293cdbc*/ void SetTextureUploadMode(bool shouldUploadImmediately);
                static /*0x293cdf8*/ bool TryAddGlyphToTexture(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph glyph);
                static /*0x293d328*/ bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct glyph);
                static /*0x293d3c4*/ bool TryAddGlyphsToTexture(System.Collections.Generic.List<uint> glyphIndexes, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, ref UnityEngine.TextCore.Glyph[] glyphs);
                static /*0x293dc6c*/ bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, UnityEngine.TextCore.LowLevel.GlyphPackingMode packingMode, UnityEngine.TextCore.GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, UnityEngine.TextCore.GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, UnityEngine.TextCore.LowLevel.GlyphRenderMode renderMode, UnityEngine.Texture2D texture, UnityEngine.TextCore.LowLevel.GlyphMarshallingStruct[] glyphs, ref int glyphCount);
                static /*0x293dd14*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes);
                static /*0x293dee4*/ UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<uint> glyphIndexes, ref int recordCount);
                static /*0x293de64*/ int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, ref int recordCount);
                static /*0x293dea8*/ int GetPairAdjustmentRecordsFromMarshallingArray(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords);
                static void GenericListToMarshallingArray<T>(ref System.Collections.Generic.List<T> srcList, ref T[] dstArray);
                static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount);
                static /*0x293e06c*/ void ResetAtlasTexture(UnityEngine.Texture2D texture);
            }

            struct FontEngineUtilities
            {
                static /*0x293dc4c*/ int MaxValue(int a, int b, int c);
            }

            enum FontFeatureLookupFlags
            {
                None = 0,
                IgnoreLigatures = 4,
                IgnoreSpacingAdjustments = 256,
            }

            struct GlyphValueRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphValueRecord>
            {
                /*0x10*/ float m_XPlacement;
                /*0x14*/ float m_YPlacement;
                /*0x18*/ float m_XAdvance;
                /*0x1c*/ float m_YAdvance;

                static /*0x293e218*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord op_Addition(UnityEngine.TextCore.LowLevel.GlyphValueRecord a, UnityEngine.TextCore.LowLevel.GlyphValueRecord b);
                /*0x293e1f8*/ float get_xPlacement();
                /*0x293e200*/ float get_yPlacement();
                /*0x293e208*/ float get_xAdvance();
                /*0x293e210*/ float get_yAdvance();
                /*0x293e22c*/ int GetHashCode();
                /*0x293e290*/ bool Equals(object obj);
                /*0x293e308*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphValueRecord other);
            }

            struct GlyphAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord>
            {
                /*0x10*/ uint m_GlyphIndex;
                /*0x14*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

                /*0x293e3b0*/ uint get_glyphIndex();
                /*0x293e3b8*/ UnityEngine.TextCore.LowLevel.GlyphValueRecord get_glyphValueRecord();
                /*0x293e3c4*/ int GetHashCode();
                /*0x293e430*/ bool Equals(object obj);
                /*0x293e4b0*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord other);
            }

            struct GlyphPairAdjustmentRecord : System.IEquatable<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>
            {
                /*0x10*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;
                /*0x24*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;
                /*0x38*/ UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

                /*0x293e554*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_firstAdjustmentRecord();
                /*0x293e568*/ UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord get_secondAdjustmentRecord();
                /*0x293e57c*/ int GetHashCode();
                /*0x293e5e8*/ bool Equals(object obj);
                /*0x293e668*/ bool Equals(UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord other);
            }
        }
    }
}
