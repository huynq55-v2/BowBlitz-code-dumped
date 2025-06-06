class <Module>
{
}

namespace RTLTMPro
{
    class Char32Utils
    {
        static /*0x2282ad4*/ bool IsUnicode16Char(int ch);
        static /*0x2282ae4*/ bool IsRTLCharacter(int ch);
        static /*0x2282b68*/ bool IsEnglishLetter(int ch);
        static /*0x2282bd4*/ bool IsNumber(int ch, bool preserveNumbers, bool farsi);
        static /*0x2282c48*/ bool IsSymbol(int ch);
        static /*0x2282cbc*/ bool IsLetter(int ch);
        static /*0x2282d30*/ bool IsPunctuation(int ch);
        static /*0x2282da4*/ bool IsWhiteSpace(int ch);
    }

    class FastStringBuilder
    {
        /*0x10*/ int length;
        /*0x18*/ int[] array;
        /*0x20*/ int capacity;

        static /*0x2283034*/ string op_Implicit(RTLTMPro.FastStringBuilder x);
        static /*0x2283050*/ RTLTMPro.FastStringBuilder op_Implicit(string x);
        static /*0x22831fc*/ void Copy(int[] src, int[] dst);
        /*0x2282e34*/ FastStringBuilder(int capacity);
        /*0x2282ee8*/ FastStringBuilder(string text);
        /*0x2282f1c*/ FastStringBuilder(string text, int capacity);
        /*0x2282e18*/ int get_Length();
        /*0x2282e20*/ void set_Length(int value);
        /*0x22830b0*/ int Get(int index);
        /*0x22830e0*/ void Set(int index, int ch);
        /*0x2282f48*/ void SetValue(string text);
        /*0x22831b8*/ void SetValue(RTLTMPro.FastStringBuilder other);
        /*0x2283260*/ void Append(int ch);
        /*0x22832cc*/ void Append(char ch);
        /*0x228333c*/ void Insert(int pos, RTLTMPro.FastStringBuilder str, int offset, int count);
        /*0x22834a0*/ void Insert(int pos, RTLTMPro.FastStringBuilder str);
        /*0x22834bc*/ void Insert(int pos, int ch);
        /*0x228355c*/ void RemoveAll(int character);
        /*0x22835dc*/ void Remove(int start, int length);
        /*0x228364c*/ void Reverse(int startIndex, int length);
        /*0x22836d4*/ void Reverse();
        /*0x22836e0*/ void Substring(RTLTMPro.FastStringBuilder output, int start, int length);
        /*0x2283768*/ string ToString();
        /*0x2283858*/ string ToDebugString();
        /*0x2283968*/ void Replace(int oldChar, int newChar);
        /*0x22839c4*/ void Replace(RTLTMPro.FastStringBuilder oldStr, RTLTMPro.FastStringBuilder newStr);
        /*0x2283cb8*/ void Clear();
        /*0x2283110*/ void EnsureCapacity(int cap, bool keepValues);
    }

    class GlyphFixer
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<char, char> EnglishToFarsiNumberMap;
        static /*0x8*/ System.Collections.Generic.Dictionary<char, char> EnglishToHinduNumberMap;

        static /*0x2284ea8*/ GlyphFixer();
        static /*0x2283cc0*/ void Fix(RTLTMPro.FastStringBuilder input, RTLTMPro.FastStringBuilder output, bool preserveNumbers, bool farsi, bool fixTextTags);
        static /*0x2283fec*/ void FixYah(RTLTMPro.FastStringBuilder text, bool farsi);
        static /*0x228407c*/ bool HandleSpecialLam(RTLTMPro.FastStringBuilder input, RTLTMPro.FastStringBuilder output, int i);
        static /*0x2284d54*/ void FixNumbers(RTLTMPro.FastStringBuilder text, bool farsi);
        static /*0x2284b18*/ void FixNumbersOutsideOfTags(RTLTMPro.FastStringBuilder text, bool farsi);
        static /*0x228490c*/ bool IsLeadingLetter(RTLTMPro.FastStringBuilder letters, int index);
        static /*0x22847d0*/ bool IsFinishingLetter(RTLTMPro.FastStringBuilder letters, int index);
        static /*0x2284594*/ bool IsMiddleLetter(RTLTMPro.FastStringBuilder letters, int index);
    }

    class GlyphTable
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<char, char> MapList;

        static /*0x2285104*/ GlyphTable();
        static /*0x22844f4*/ char Convert(char toBeConverted);
    }

    class LigatureFixer
    {
        static /*0x0*/ System.Collections.Generic.List<int> LtrTextHolder;
        static /*0x8*/ System.Collections.Generic.List<int> TagTextHolder;
        static /*0x10*/ System.Collections.Generic.Dictionary<char, char> MirroredCharsMap;
        static /*0x18*/ System.Collections.Generic.HashSet<char> MirroredCharsSet;

        static /*0x2285d14*/ LigatureFixer();
        static /*0x22853ac*/ void FlushBufferToOutput(System.Collections.Generic.List<int> buffer, RTLTMPro.FastStringBuilder output);
        static /*0x228546c*/ void Fix(RTLTMPro.FastStringBuilder input, RTLTMPro.FastStringBuilder output, bool farsi, bool fixTextTags, bool preserveNumbers);
    }

    class RichTextFixer
    {
        static /*0x2285efc*/ void Fix(RTLTMPro.FastStringBuilder text);
        static /*0x2285f70*/ void FindTag(RTLTMPro.FastStringBuilder str, int start, ref RTLTMPro.RichTextFixer.Tag tag);

        enum TagType
        {
            None = 0,
            Opening = 1,
            Closing = 2,
            SelfContained = 3,
        }

        struct Tag
        {
            /*0x10*/ int Start;
            /*0x14*/ int End;
            /*0x18*/ int HashCode;
            /*0x1c*/ RTLTMPro.RichTextFixer.TagType Type;

            /*0x2286158*/ Tag(int start, int end, RTLTMPro.RichTextFixer.TagType type, int hashCode);
        }
    }

    class RTLSupport
    {
        static int DefaultBufferSize = 2048;
        static /*0x0*/ RTLTMPro.FastStringBuilder inputBuilder;
        static /*0x8*/ RTLTMPro.FastStringBuilder glyphFixerOutput;

        static /*0x2286164*/ RTLSupport();
        static /*0x2286200*/ void FixRTL(string input, RTLTMPro.FastStringBuilder output, bool farsi, bool fixTextTags, bool preserveNumbers);
    }

    class RTLTextMeshPro : TMPro.TextMeshProUGUI
    {
        /*0x795*/ bool preserveNumbers;
        /*0x796*/ bool farsi;
        /*0x798*/ string originalText;
        /*0x7a0*/ bool fixTags;
        /*0x7a1*/ bool forceFix;
        /*0x7a8*/ RTLTMPro.FastStringBuilder finalText;

        /*0x2286c90*/ RTLTextMeshPro();
        /*0x22868fc*/ string get_text();
        /*0x2286904*/ void set_text(string value);
        /*0x22869f4*/ string get_OriginalText();
        /*0x22869fc*/ bool get_PreserveNumbers();
        /*0x2286a04*/ void set_PreserveNumbers(bool value);
        /*0x2286a28*/ bool get_Farsi();
        /*0x2286a30*/ void set_Farsi(bool value);
        /*0x2286a54*/ bool get_FixTags();
        /*0x2286a5c*/ void set_FixTags(bool value);
        /*0x2286a80*/ bool get_ForceFix();
        /*0x2286a88*/ void set_ForceFix(bool value);
        /*0x2286aac*/ void Update();
        /*0x2286944*/ void UpdateText();
        /*0x2286ba0*/ string GetFixedText(string input);
    }

    class RTLTextMeshPro3D : TMPro.TextMeshPro
    {
        /*0x759*/ bool preserveNumbers;
        /*0x75a*/ bool farsi;
        /*0x760*/ string originalText;
        /*0x768*/ bool fixTags;
        /*0x769*/ bool forceFix;
        /*0x770*/ RTLTMPro.FastStringBuilder finalText;

        /*0x2286fd8*/ RTLTextMeshPro3D();
        /*0x2286d28*/ string get_text();
        /*0x2286d30*/ void set_text(string value);
        /*0x2286e20*/ string get_OriginalText();
        /*0x2286e28*/ bool get_PreserveNumbers();
        /*0x2286e30*/ void set_PreserveNumbers(bool value);
        /*0x2286e54*/ bool get_Farsi();
        /*0x2286e5c*/ void set_Farsi(bool value);
        /*0x2286e80*/ bool get_FixTags();
        /*0x2286e88*/ void set_FixTags(bool value);
        /*0x2286eac*/ bool get_ForceFix();
        /*0x2286eb4*/ void set_ForceFix(bool value);
        /*0x2286ed8*/ void Update();
        /*0x2286d70*/ void UpdateText();
        /*0x2286ee8*/ string GetFixedText(string input);
    }

    class TashkeelFixer
    {
        static /*0x0*/ System.Collections.Generic.List<RTLTMPro.TashkeelLocation> TashkeelLocations;
        static /*0x8*/ string ShaddaDammatan;
        static /*0x10*/ string ShaddaKasratan;
        static /*0x18*/ string ShaddaSuperscriptAlef;
        static /*0x20*/ string ShaddaFatha;
        static /*0x28*/ string ShaddaDamma;
        static /*0x30*/ string ShaddaKasra;
        static /*0x38*/ string ShaddaWithFathaIsolatedForm;
        static /*0x40*/ string ShaddaWithDammaIsolatedForm;
        static /*0x48*/ string ShaddaWithKasraIsolatedForm;
        static /*0x50*/ string ShaddaWithDammatanIsolatedForm;
        static /*0x58*/ string ShaddaWithKasratanIsolatedForm;
        static /*0x60*/ string ShaddaWithSuperscriptAlefIsolatedForm;
        static /*0x68*/ System.Collections.Generic.HashSet<char> TashkeelCharactersSet;
        static /*0x70*/ System.Collections.Generic.Dictionary<char, char> ShaddaCombinationMap;

        static /*0x2287080*/ TashkeelFixer();
        static /*0x22863b8*/ void RemoveTashkeel(RTLTMPro.FastStringBuilder input);
        static /*0x22865bc*/ void RestoreTashkeel(RTLTMPro.FastStringBuilder letters);
        static /*0x228674c*/ void FixShaddaCombinations(RTLTMPro.FastStringBuilder input);
    }

    struct TashkeelLocation
    {
        /*0x10*/ char <Tashkeel>k__BackingField;
        /*0x14*/ int <Position>k__BackingField;

        /*0x2287070*/ TashkeelLocation(RTLTMPro.TashkeelCharacters tashkeel, int position);
        /*0x22875f4*/ char get_Tashkeel();
        /*0x22875fc*/ void set_Tashkeel(char value);
        /*0x2287604*/ int get_Position();
        /*0x228760c*/ void set_Position(int value);
    }

    class TextUtils
    {
        static char LowerCaseA = 97;
        static char UpperCaseA = 65;
        static char LowerCaseZ = 122;
        static char UpperCaseZ = 90;
        static char HebrewLow = 1425;
        static char HebrewHigh = 1524;
        static char ArabicBaseBlockLow = 1536;
        static char ArabicBaseBlockHigh = 1791;
        static char ArabicExtendedABlockLow = 2208;
        static char ArabicExtendedABlockHigh = 2303;
        static char ArabicExtendedBBlockLow = 2160;
        static char ArabicExtendedBBlockHigh = 2207;
        static char ArabicPresentationFormsABlockLow = 64336;
        static char ArabicPresentationFormsABlockHigh = 65023;
        static char ArabicPresentationFormsBBlockLow = 65136;
        static char ArabicPresentationFormsBBlockHigh = 65279;

        static /*0x2287614*/ bool IsPunctuation(char ch);
        static /*0x2282c18*/ bool IsNumber(char ch, bool preserveNumbers, bool farsi);
        static /*0x2287654*/ bool IsEnglishNumber(char ch);
        static /*0x2287668*/ bool IsFarsiNumber(char ch);
        static /*0x228767c*/ bool IsHinduNumber(char ch);
        static /*0x2282ba8*/ bool IsEnglishLetter(char ch);
        static /*0x2287690*/ bool IsHebrewCharacter(char ch);
        static /*0x22876a4*/ bool IsArabicCharacter(char ch);
        static /*0x2282afc*/ bool IsRTLCharacter(char ch);
        static /*0x228417c*/ bool IsGlyphFixedArabicCharacter(char ch);
        static /*0x2286abc*/ bool IsRTLInput(string input);
    }

    enum ArabicGeneralLetters
    {
        Hamza = 1569,
        AlefMaddaAbove = 1570,
        AlefHamzaAbove = 1571,
        WawHamzaAbove = 1572,
        AlefHamzaBelow = 1573,
        YehHamzaAbove = 1574,
        Alef = 1575,
        Beh = 1576,
        TehMarbuta = 1577,
        Teh = 1578,
        Theh = 1579,
        Jeem = 1580,
        Hah = 1581,
        Khah = 1582,
        Dal = 1583,
        Thal = 1584,
        Reh = 1585,
        Zain = 1586,
        Seen = 1587,
        Sheen = 1588,
        Sad = 1589,
        Dad = 1590,
        Tah = 1591,
        Zah = 1592,
        Ain = 1593,
        Ghain = 1594,
        Feh = 1601,
        Qaf = 1602,
        Kaf = 1603,
        Lam = 1604,
        Meem = 1605,
        Noon = 1606,
        Heh = 1607,
        Waw = 1608,
        AlefMaksura = 1609,
        Yeh = 1610,
        FarsiYeh = 1740,
        Peh = 1662,
        TCheh = 1670,
        Jeh = 1688,
        Keheh = 1705,
        Gaf = 1711,
        Tatweel = 1600,
    }

    enum ArabicIsolatedLetters
    {
        Hamza = 65152,
        AlefMaddaAbove = 65153,
        AlefHamzaAbove = 65155,
        WawHamzaAbove = 65157,
        AlefHamzaBelow = 65159,
        YehHamzaAbove = 65161,
        Alef = 65165,
        Beh = 65167,
        TehMarbuta = 65171,
        Teh = 65173,
        Theh = 65177,
        Jeem = 65181,
        Hah = 65185,
        Khah = 65189,
        Dal = 65193,
        Thal = 65195,
        Reh = 65197,
        Zain = 65199,
        Seen = 65201,
        Sheen = 65205,
        Sad = 65209,
        Dad = 65213,
        Tah = 65217,
        Zah = 65221,
        Ain = 65225,
        Ghain = 65229,
        Feh = 65233,
        Qaf = 65237,
        Kaf = 65241,
        Lam = 65245,
        Meem = 65249,
        Noon = 65253,
        Heh = 65257,
        Waw = 65261,
        AlefMaksura = 65263,
        Yeh = 65265,
        FarsiYeh = 64508,
        Peh = 64342,
        TCheh = 64378,
        Jeh = 64394,
        Keheh = 64398,
        Gaf = 64402,
    }

    enum EnglishNumbers
    {
        Zero = 48,
        One = 49,
        Two = 50,
        Three = 51,
        Four = 52,
        Five = 53,
        Six = 54,
        Seven = 55,
        Eight = 56,
        Nine = 57,
    }

    enum FarsiNumbers
    {
        Zero = 1776,
        One = 1777,
        Two = 1778,
        Three = 1779,
        Four = 1780,
        Five = 1781,
        Six = 1782,
        Seven = 1783,
        Eight = 1784,
        Nine = 1785,
    }

    enum HinduNumbers
    {
        Zero = 1632,
        One = 1633,
        Two = 1634,
        Three = 1635,
        Four = 1636,
        Five = 1637,
        Six = 1638,
        Seven = 1639,
        Eight = 1640,
        Nine = 1641,
    }

    enum SpecialCharacters
    {
        ZeroWidthNoJoiner = 8204,
    }

    enum TashkeelCharacters
    {
        Fathan = 1611,
        Dammatan = 1612,
        Kasratan = 1613,
        Fatha = 1614,
        Damma = 1615,
        Kasra = 1616,
        Shadda = 1617,
        Sukun = 1618,
        MaddahAbove = 1619,
        SuperscriptAlef = 1648,
        ShaddaWithDammatanIsolatedForm = 64606,
        ShaddaWithKasratanIsolatedForm = 64607,
        ShaddaWithFathaIsolatedForm = 64608,
        ShaddaWithDammaIsolatedForm = 64609,
        ShaddaWithKasraIsolatedForm = 64610,
        ShaddaWithSuperscriptAlefIsolatedForm = 64611,
    }
}
