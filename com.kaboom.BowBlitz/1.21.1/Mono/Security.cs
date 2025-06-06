class <Module>
{
}

class Locale
{
    static /*0x1e9f1a8*/ string GetText(string msg);
    static /*0x1e9f1ac*/ string GetText(string fmt, object[] args);
}

namespace Mono
{
    namespace Security
    {
        class ASN1
        {
            /*0x10*/ byte m_nTag;
            /*0x18*/ byte[] m_aValue;
            /*0x20*/ System.Collections.ArrayList elist;

            /*0x1e9f1b4*/ ASN1(byte tag);
            /*0x1e9f1e0*/ ASN1(byte tag, byte[] data);
            /*0x1e9f210*/ ASN1(byte[] data);
            /*0x1e9f4ac*/ int get_Count();
            /*0x1e9f4c8*/ byte get_Tag();
            /*0x1e9f4d0*/ int get_Length();
            /*0x1e9f4e8*/ byte[] get_Value();
            /*0x1e9f578*/ void set_Value(byte[] value);
            /*0x1e9f620*/ bool CompareArray(byte[] array1, byte[] array2);
            /*0x1e9f694*/ bool CompareValue(byte[] value);
            /*0x1e9f6a4*/ Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1);
            /*0x1e9f730*/ byte[] GetBytes();
            /*0x1e9f388*/ void Decode(byte[] asn1, ref int anPos, int anLength);
            /*0x1e9fdc8*/ void DecodeTLV(byte[] asn1, ref int pos, ref byte tag, ref int length, ref byte[] content);
            /*0x1e9feec*/ Mono.Security.ASN1 get_Item(int index);
            /*0x1ea001c*/ Mono.Security.ASN1 Element(int index, byte anTag);
            /*0x1ea0170*/ string ToString();
        }

        class ASN1Convert
        {
            static /*0x1ea0400*/ Mono.Security.ASN1 FromInt32(int value);
            static /*0x1ea0568*/ Mono.Security.ASN1 FromOid(string oid);
            static /*0x1ea0650*/ Mono.Security.ASN1 FromUnsignedBigInteger(byte[] big);
            static /*0x1ea076c*/ int ToInt32(Mono.Security.ASN1 asn1);
            static /*0x1ea0884*/ string ToOid(Mono.Security.ASN1 asn1);
            static /*0x1ea0b10*/ System.DateTime ToDateTime(Mono.Security.ASN1 time);
        }

        class BitConverterLE
        {
            static /*0x1ea106c*/ byte[] GetUIntBytes(byte* bytes);
            static /*0x1ea117c*/ byte[] GetULongBytes(byte* bytes);
            static /*0x1ea0550*/ byte[] GetBytes(int value);
            static /*0x1ea130c*/ byte[] GetBytes(long value);
            static /*0x1ea1324*/ void UShortFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x1ea1400*/ void UIntFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x1ea154c*/ int ToInt32(byte[] value, int startIndex);
            static /*0x1ea1570*/ ushort ToUInt16(byte[] value, int startIndex);
            static /*0x1ea1594*/ uint ToUInt32(byte[] value, int startIndex);
        }

        class PKCS7
        {
            class ContentInfo
            {
                /*0x10*/ string contentType;
                /*0x18*/ Mono.Security.ASN1 content;

                /*0x1ea15b8*/ ContentInfo();
                /*0x1ea1630*/ ContentInfo(string oid);
                /*0x1ea1654*/ ContentInfo(byte[] data);
                /*0x1ea16c4*/ ContentInfo(Mono.Security.ASN1 asn1);
                /*0x1ea184c*/ Mono.Security.ASN1 get_ASN1();
                /*0x1ea1904*/ Mono.Security.ASN1 get_Content();
                /*0x1ea190c*/ void set_Content(Mono.Security.ASN1 value);
                /*0x1ea1914*/ string get_ContentType();
                /*0x1ea191c*/ void set_ContentType(string value);
                /*0x1ea1850*/ Mono.Security.ASN1 GetASN1();
            }

            class EncryptedData
            {
                /*0x10*/ byte _version;
                /*0x18*/ Mono.Security.PKCS7.ContentInfo _content;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm;
                /*0x28*/ byte[] _encrypted;

                /*0x1ea1924*/ EncryptedData();
                /*0x1ea1940*/ EncryptedData(Mono.Security.ASN1 asn1);
                /*0x1ea1c18*/ Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm();
                /*0x1ea1c20*/ byte[] get_EncryptedContent();
            }

            class SignedData
            {
                /*0x10*/ byte version;
                /*0x18*/ string hashAlgorithm;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo contentInfo;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection certs;
                /*0x30*/ System.Collections.ArrayList crls;
                /*0x38*/ Mono.Security.PKCS7.SignerInfo signerInfo;
                /*0x40*/ bool mda;

                /*0x1ea1c94*/ SignedData(Mono.Security.ASN1 asn1);
                /*0x1ea2964*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x1ea296c*/ Mono.Security.PKCS7.ContentInfo get_ContentInfo();
                /*0x1ea2944*/ void set_HashName(string value);
                /*0x1ea2974*/ Mono.Security.PKCS7.SignerInfo get_SignerInfo();
                /*0x1ea2790*/ string OidToName(string oid);
            }

            class SignerInfo
            {
                /*0x10*/ byte version;
                /*0x18*/ string hashAlgorithm;
                /*0x20*/ System.Collections.ArrayList authenticatedAttributes;
                /*0x28*/ System.Collections.ArrayList unauthenticatedAttributes;
                /*0x30*/ byte[] signature;
                /*0x38*/ string issuer;
                /*0x40*/ byte[] serial;
                /*0x48*/ byte[] ski;

                /*0x1ea2700*/ SignerInfo();
                /*0x1ea2388*/ SignerInfo(Mono.Security.ASN1 asn1);
                /*0x1ea2ab4*/ string get_IssuerName();
                /*0x1ea2abc*/ byte[] get_SerialNumber();
                /*0x1ea2b30*/ System.Collections.ArrayList get_AuthenticatedAttributes();
                /*0x1ea2b38*/ string get_HashName();
                /*0x1ea2b40*/ void set_HashName(string value);
                /*0x1ea2b48*/ byte[] get_Signature();
                /*0x1ea2bbc*/ System.Collections.ArrayList get_UnauthenticatedAttributes();
                /*0x1ea2bc4*/ byte get_Version();
            }
        }

        namespace X509
        {
            class SafeBag
            {
                /*0x10*/ string _bagOID;
                /*0x18*/ Mono.Security.ASN1 _asn1;

                /*0x1ea2bcc*/ SafeBag(string bagOID, Mono.Security.ASN1 asn1);
                /*0x1ea2bf8*/ string get_BagOID();
                /*0x1ea2c00*/ Mono.Security.ASN1 get_ASN1();
            }

            class PKCS12 : System.ICloneable
            {
                static /*0x0*/ int password_max_length;
                /*0x10*/ byte[] _password;
                /*0x18*/ System.Collections.ArrayList _keyBags;
                /*0x20*/ System.Collections.ArrayList _secretBags;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection _certs;
                /*0x30*/ bool _keyBagsChanged;
                /*0x31*/ bool _secretBagsChanged;
                /*0x32*/ bool _certsChanged;
                /*0x34*/ int _iterations;
                /*0x38*/ System.Collections.ArrayList _safeBags;
                /*0x40*/ System.Security.Cryptography.RandomNumberGenerator _rng;

                static /*0x1eaacf8*/ PKCS12();
                static /*0x1eaaca0*/ int get_MaximumPasswordLength();
                /*0x1ea2c08*/ PKCS12();
                /*0x1ea2cf4*/ PKCS12(byte[] data);
                /*0x1ea358c*/ PKCS12(byte[] data, string password);
                /*0x1ea2edc*/ void Decode(byte[] data);
                /*0x1ea3f1c*/ void Finalize();
                /*0x1ea2d28*/ void set_Password(string value);
                /*0x1ea3fc8*/ int get_IterationCount();
                /*0x1ea3fd0*/ void set_IterationCount(int value);
                /*0x1ea3fd8*/ System.Collections.ArrayList get_Keys();
                /*0x1ea488c*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x1ea4cdc*/ System.Security.Cryptography.RandomNumberGenerator get_RNG();
                /*0x1ea3718*/ bool Compare(byte[] expected, byte[] actual);
                /*0x1ea4cfc*/ System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount);
                /*0x1ea46d8*/ byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData);
                /*0x1ea3e8c*/ byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed);
                /*0x1ea54d8*/ byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data);
                /*0x1ea572c*/ System.Security.Cryptography.DSAParameters GetExistingParameters(ref bool found);
                /*0x1ea5e4c*/ void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki);
                /*0x1ea378c*/ void ReadSafeBag(Mono.Security.ASN1 safeBag);
                /*0x1ea60c8*/ Mono.Security.ASN1 Pkcs8ShroudedKeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x1ea6e9c*/ Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes);
                /*0x1ea35c4*/ byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data);
                /*0x1ea7b04*/ byte[] GetBytes();
                /*0x1ea9d54*/ Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, string algorithmOid);
                /*0x1ea9d4c*/ void AddCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x1eaa064*/ void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes);
                /*0x1ea9d44*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x1eaa2b4*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs);
                /*0x1eaa7c0*/ bool CompareAsymmetricAlgorithm(System.Security.Cryptography.AsymmetricAlgorithm a1, System.Security.Cryptography.AsymmetricAlgorithm a2);
                /*0x1eaa85c*/ void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x1eaabcc*/ object Clone();

                class DeriveBytes
                {
                    static /*0x0*/ byte[] keyDiversifier;
                    static /*0x8*/ byte[] ivDiversifier;
                    static /*0x10*/ byte[] macDiversifier;
                    /*0x10*/ string _hashName;
                    /*0x18*/ int _iterations;
                    /*0x20*/ byte[] _password;
                    /*0x28*/ byte[] _salt;

                    static /*0x1eab260*/ DeriveBytes();
                    /*0x1ea528c*/ DeriveBytes();
                    /*0x1eaad44*/ void set_HashName(string value);
                    /*0x1eaad4c*/ void set_IterationCount(int value);
                    /*0x1ea5294*/ void set_Password(byte[] value);
                    /*0x1ea5350*/ void set_Salt(byte[] value);
                    /*0x1eaad54*/ void Adjust(byte[] a, int aOff, byte[] b);
                    /*0x1eaae30*/ byte[] Derive(byte[] diversifier, int n);
                    /*0x1ea53f8*/ byte[] DeriveKey(int size);
                    /*0x1ea5468*/ byte[] DeriveIV(int size);
                    /*0x1ea7a94*/ byte[] DeriveMAC(int size);
                }
            }

            class X501
            {
                static /*0x0*/ byte[] countryName;
                static /*0x8*/ byte[] organizationName;
                static /*0x10*/ byte[] organizationalUnitName;
                static /*0x18*/ byte[] commonName;
                static /*0x20*/ byte[] localityName;
                static /*0x28*/ byte[] stateOrProvinceName;
                static /*0x30*/ byte[] streetAddress;
                static /*0x38*/ byte[] serialNumber;
                static /*0x40*/ byte[] domainComponent;
                static /*0x48*/ byte[] userid;
                static /*0x50*/ byte[] email;
                static /*0x58*/ byte[] dnQualifier;
                static /*0x60*/ byte[] title;
                static /*0x68*/ byte[] surname;
                static /*0x70*/ byte[] givenName;
                static /*0x78*/ byte[] initial;

                static /*0x1eabce0*/ X501();
                static /*0x1ea297c*/ string ToString(Mono.Security.ASN1 seq);
                static /*0x1eabb38*/ string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes);
                static /*0x1eab374*/ void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, bool quotes);
            }

            class X509Crl
            {
                /*0x10*/ string issuer;
                /*0x18*/ byte version;
                /*0x20*/ System.DateTime thisUpdate;
                /*0x28*/ System.DateTime nextUpdate;
                /*0x30*/ System.Collections.ArrayList entries;
                /*0x38*/ string signatureOID;
                /*0x40*/ byte[] signature;
                /*0x48*/ Mono.Security.X509.X509ExtensionCollection extensions;
                /*0x50*/ byte[] encoded;
                /*0x58*/ byte[] hash_value;

                /*0x1eac110*/ X509Crl(byte[] crl);
                /*0x1eac208*/ void Parse(byte[] crl);
                /*0x1eacacc*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x1eacad4*/ byte[] get_Hash();
                /*0x1eacce8*/ string get_IssuerName();
                /*0x1eaccf0*/ System.DateTime get_NextUpdate();
                /*0x1eaccf8*/ bool Compare(byte[] array1, byte[] array2);
                /*0x1eacd74*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509);
                /*0x1eacdf4*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber);
                /*0x1eacfb4*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x1ead280*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x1ead354*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);

                class X509CrlEntry
                {
                    /*0x10*/ byte[] sn;
                    /*0x18*/ System.DateTime revocationDate;
                    /*0x20*/ Mono.Security.X509.X509ExtensionCollection extensions;

                    /*0x1eac8b8*/ X509CrlEntry(Mono.Security.ASN1 entry);
                    /*0x1eacf3c*/ byte[] get_SerialNumber();
                    /*0x1ead4e0*/ System.DateTime get_RevocationDate();
                    /*0x1ead4e8*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                }
            }

            class X509Certificate : System.Runtime.Serialization.ISerializable
            {
                static /*0x0*/ string encoding_error;
                /*0x10*/ Mono.Security.ASN1 decoder;
                /*0x18*/ byte[] m_encodedcert;
                /*0x20*/ System.DateTime m_from;
                /*0x28*/ System.DateTime m_until;
                /*0x30*/ Mono.Security.ASN1 issuer;
                /*0x38*/ string m_issuername;
                /*0x40*/ string m_keyalgo;
                /*0x48*/ byte[] m_keyalgoparams;
                /*0x50*/ Mono.Security.ASN1 subject;
                /*0x58*/ string m_subject;
                /*0x60*/ byte[] m_publickey;
                /*0x68*/ byte[] signature;
                /*0x70*/ string m_signaturealgo;
                /*0x78*/ byte[] m_signaturealgoparams;
                /*0x80*/ byte[] certhash;
                /*0x88*/ System.Security.Cryptography.RSA _rsa;
                /*0x90*/ System.Security.Cryptography.DSA _dsa;
                /*0x98*/ int version;
                /*0xa0*/ byte[] serialnumber;
                /*0xa8*/ byte[] issuerUniqueID;
                /*0xb0*/ byte[] subjectUniqueID;
                /*0xb8*/ Mono.Security.X509.X509ExtensionCollection extensions;

                static /*0x1eaf064*/ X509Certificate();
                static /*0x1eaddf8*/ byte[] PEM(string type, byte[] data);
                /*0x1ea2180*/ X509Certificate(byte[] data);
                /*0x1ead4f0*/ void Parse(byte[] data);
                /*0x1eadf2c*/ byte[] GetUnsignedBigInteger(byte[] integer);
                /*0x1ea5b10*/ System.Security.Cryptography.DSA get_DSA();
                /*0x1eadfc0*/ void set_DSA(System.Security.Cryptography.DSA value);
                /*0x1eadfd0*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x1eadfd8*/ byte[] get_Hash();
                /*0x1eae26c*/ string get_IssuerName();
                /*0x1eae274*/ string get_KeyAlgorithm();
                /*0x1eae27c*/ byte[] get_KeyAlgorithmParameters();
                /*0x1eae2f0*/ void set_KeyAlgorithmParameters(byte[] value);
                /*0x1eae2f8*/ byte[] get_PublicKey();
                /*0x1eae36c*/ System.Security.Cryptography.RSA get_RSA();
                /*0x1eae4f8*/ void set_RSA(System.Security.Cryptography.RSA value);
                /*0x1eae508*/ byte[] get_RawData();
                /*0x1eae57c*/ byte[] get_SerialNumber();
                /*0x1eae5f0*/ byte[] get_Signature();
                /*0x1eaea2c*/ string get_SubjectName();
                /*0x1eaea34*/ System.DateTime get_ValidFrom();
                /*0x1eaea3c*/ System.DateTime get_ValidUntil();
                /*0x1eaea44*/ int get_Version();
                /*0x1eaea4c*/ bool get_IsCurrent();
                /*0x1eaeaac*/ bool WasCurrent(System.DateTime instant);
                /*0x1eaeb84*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x1eaec4c*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x1eaed74*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x1eaef00*/ bool get_IsSelfSigned();
                /*0x1eaf008*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x1ea2178*/ X509CertificateCollection();
                /*0x1eaf0c4*/ Mono.Security.X509.X509Certificate get_Item(int index);
                /*0x1ea2314*/ int Add(Mono.Security.X509.X509Certificate value);
                /*0x1eaf15c*/ void AddRange(Mono.Security.X509.X509CertificateCollection value);
                /*0x1eaf230*/ bool Contains(Mono.Security.X509.X509Certificate value);
                /*0x1ea59c0*/ Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                /*0x1eaf448*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1eaf46c*/ int GetHashCode();
                /*0x1eaf248*/ int IndexOf(Mono.Security.X509.X509Certificate value);
                /*0x1eaf48c*/ bool Compare(byte[] array1, byte[] array2);

                class X509CertificateEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x1eaf394*/ X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings);
                    /*0x1ea5a20*/ Mono.Security.X509.X509Certificate get_Current();
                    /*0x1eaf508*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1eaf5ac*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x1eaf64c*/ void System.Collections.IEnumerator.Reset();
                    /*0x1ea5dac*/ bool MoveNext();
                }
            }

            class X509Chain
            {
                /*0x10*/ Mono.Security.X509.X509CertificateCollection roots;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection certs;
                /*0x20*/ Mono.Security.X509.X509Certificate _root;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection _chain;
                /*0x30*/ Mono.Security.X509.X509ChainStatusFlags _status;

                /*0x1eaf6f0*/ X509Chain();
                /*0x1eaf75c*/ Mono.Security.X509.X509CertificateCollection get_TrustAnchors();
                /*0x1eaf8a4*/ void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection);
                /*0x1eaf8bc*/ bool Build(Mono.Security.X509.X509Certificate leaf);
                /*0x1eb0284*/ void Reset();
                /*0x1eb01d8*/ bool IsValid(Mono.Security.X509.X509Certificate cert);
                /*0x1eafc64*/ Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child);
                /*0x1eafe54*/ Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot);
                /*0x1eb02c4*/ bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted);
                /*0x1eb0094*/ bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent);
            }

            enum X509ChainStatusFlags
            {
                InvalidBasicConstraints = 1024,
                NoError = 0,
                NotSignatureValid = 8,
                NotTimeNested = 2,
                NotTimeValid = 1,
                PartialChain = 65536,
                UntrustedRoot = 32,
            }

            class X509Extension
            {
                /*0x10*/ string extnOid;
                /*0x18*/ bool extnCritical;
                /*0x20*/ Mono.Security.ASN1 extnValue;

                /*0x1eb03a4*/ X509Extension(Mono.Security.ASN1 asn1);
                /*0x1eb0670*/ X509Extension(Mono.Security.X509.X509Extension extension);
                /*0x1eb07e8*/ void Decode();
                /*0x1eb07ec*/ void Encode();
                /*0x1eb07f0*/ string get_Oid();
                /*0x1eb07f8*/ bool get_Critical();
                /*0x1eb07bc*/ Mono.Security.ASN1 get_Value();
                /*0x1eb0800*/ bool Equals(object obj);
                /*0x1eb0944*/ int GetHashCode();
                /*0x1eb0964*/ void WriteLine(System.Text.StringBuilder sb, int n, int pos);
                /*0x1eb0b8c*/ string ToString();
            }

            class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x18*/ bool readOnly;

                /*0x1eb0c64*/ X509ExtensionCollection();
                /*0x1eac990*/ X509ExtensionCollection(Mono.Security.ASN1 asn1);
                /*0x1eb0c6c*/ int IndexOf(string oid);
                /*0x1eb0da8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1eb02f0*/ Mono.Security.X509.X509Extension get_Item(string oid);
            }

            class X509Store
            {
                /*0x10*/ string _storePath;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection _certificates;
                /*0x20*/ System.Collections.ArrayList _crls;
                /*0x28*/ bool _crl;
                /*0x29*/ bool _newFormat;

                /*0x1eb0dcc*/ X509Store(string path, bool crl, bool newFormat);
                /*0x1eb0e0c*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x1eb1008*/ System.Collections.ArrayList get_Crls();
                /*0x1eb1258*/ byte[] Load(string filename);
                /*0x1eb1468*/ Mono.Security.X509.X509Certificate LoadCertificate(string filename);
                /*0x1eb14d8*/ Mono.Security.X509.X509Crl LoadCrl(string filename);
                /*0x1eb1548*/ bool CheckStore(string path, bool throwException);
                /*0x1eb0e34*/ Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName);
                /*0x1eb1098*/ System.Collections.ArrayList BuildCrlsCollection(string storeName);
            }

            class X509StoreManager
            {
                static /*0x0*/ string _userPath;
                static /*0x8*/ string _localMachinePath;
                static /*0x10*/ Mono.Security.X509.X509Stores _userStore;
                static /*0x18*/ Mono.Security.X509.X509Stores _machineStore;

                static /*0x1eb1624*/ string get_CurrentUserPath();
                static /*0x1eb1724*/ string get_LocalMachinePath();
                static /*0x1eb180c*/ Mono.Security.X509.X509Stores get_CurrentUser();
                static /*0x1eb18dc*/ Mono.Security.X509.X509Stores get_LocalMachine();
                static /*0x1eaf7d8*/ Mono.Security.X509.X509CertificateCollection get_TrustedRootCertificates();
            }

            class X509Stores
            {
                /*0x10*/ string _storePath;
                /*0x18*/ bool _newFormat;
                /*0x20*/ Mono.Security.X509.X509Store _trusted;

                /*0x1eb18ac*/ X509Stores(string path, bool newFormat);
                /*0x1eb197c*/ Mono.Security.X509.X509Store get_TrustedRoot();
                /*0x1eb1a58*/ Mono.Security.X509.X509Store Open(string storeName, bool create);
            }

            namespace Extensions
            {
                class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ byte[] aki;

                    /*0x1eb1b78*/ AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension);
                    /*0x1eb1b7c*/ void Decode();
                    /*0x1eb1c94*/ void Encode();
                    /*0x1eb1db8*/ byte[] get_Identifier();
                    /*0x1eb1e2c*/ string ToString();
                }

                class BasicConstraintsExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ bool cA;
                    /*0x2c*/ int pathLenConstraint;

                    /*0x1eb03a0*/ BasicConstraintsExtension(Mono.Security.X509.X509Extension extension);
                    /*0x1eb1f94*/ void Decode();
                    /*0x1eb20cc*/ void Encode();
                    /*0x1eb2200*/ bool get_CertificateAuthority();
                    /*0x1eb2208*/ string ToString();
                }
            }
        }

        namespace Protocol
        {
            namespace Ntlm
            {
                class ChallengeResponse : System.IDisposable
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;
                    /*0x10*/ bool _disposed;
                    /*0x18*/ byte[] _challenge;
                    /*0x20*/ byte[] _lmpwd;
                    /*0x28*/ byte[] _ntpwd;

                    static /*0x1eb31fc*/ ChallengeResponse();
                    /*0x1eb23b0*/ ChallengeResponse();
                    /*0x1eb2420*/ ChallengeResponse(string password, byte[] challenge);
                    /*0x1eb29a0*/ void Finalize();
                    /*0x1eb2458*/ void set_Password(string value);
                    /*0x1eb286c*/ void set_Challenge(byte[] value);
                    /*0x1eb2be8*/ byte[] get_LM();
                    /*0x1eb2f34*/ byte[] get_NT();
                    /*0x1eb2a40*/ void Dispose();
                    /*0x1eb2f98*/ void Dispose(bool disposing);
                    /*0x1eb2c4c*/ byte[] GetResponse(byte[] pwd);
                    /*0x1eb3004*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    /*0x1eb2aa4*/ byte[] PasswordToKey(string password, int position);
                }

                class ChallengeResponse2
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;

                    static /*0x1eb46a8*/ ChallengeResponse2();
                    static /*0x1eb32cc*/ byte[] Compute_LM(string password, byte[] challenge);
                    static /*0x1eb3a68*/ byte[] Compute_NTLM_Password(string password);
                    static /*0x1eb3b6c*/ byte[] Compute_NTLM(string password, byte[] challenge);
                    static /*0x1eb3bd8*/ void Compute_NTLMv2_Session(string password, byte[] challenge, ref byte[] lm, ref byte[] ntlm);
                    static /*0x1eb3da4*/ byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, string username, string password, string domain);
                    static /*0x1eb42c8*/ void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, ref byte[] lm, ref byte[] ntlm);
                    static /*0x1eb3768*/ byte[] GetResponse(byte[] challenge, byte[] pwd);
                    static /*0x1eb44b0*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    static /*0x1eb3600*/ byte[] PasswordToKey(string password, int position);
                }

                class MessageBase
                {
                    static /*0x0*/ byte[] header;
                    /*0x10*/ int _type;
                    /*0x14*/ Mono.Security.Protocol.Ntlm.NtlmFlags _flags;

                    static /*0x1eb4b70*/ MessageBase();
                    /*0x1eb4778*/ MessageBase(int messageType);
                    /*0x1eb47a0*/ Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags();
                    /*0x1eb47a8*/ void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value);
                    /*0x1eb47b0*/ int get_Type();
                    /*0x1eb47b8*/ byte[] PrepareMessage(int messageSize);
                    /*0x1eb48b8*/ void Decode(byte[] message);
                    /*0x1eb4a5c*/ bool CheckHeader(byte[] message);
                    byte[] GetBytes();
                }

                enum NtlmAuthLevel
                {
                    LM_and_NTLM = 0,
                    LM_and_NTLM_and_try_NTLMv2_Session = 1,
                    NTLM_only = 2,
                    NTLMv2_only = 3,
                }

                enum NtlmFlags
                {
                    NegotiateUnicode = 1,
                    NegotiateOem = 2,
                    RequestTarget = 4,
                    NegotiateNtlm = 512,
                    NegotiateDomainSupplied = 4096,
                    NegotiateWorkstationSupplied = 8192,
                    NegotiateAlwaysSign = 32768,
                    NegotiateNtlm2Key = 524288,
                    Negotiate128 = 536870912,
                    Negotiate56 = -2147483648,
                }

                class NtlmSettings
                {
                    static /*0x0*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel defaultAuthLevel;

                    static /*0x1eb4c5c*/ NtlmSettings();
                    static /*0x1eb4c04*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel();
                }

                class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ string _host;
                    /*0x20*/ string _domain;

                    /*0x1eb4ca8*/ Type1Message();
                    /*0x1eb4d2c*/ void set_Domain(string value);
                    /*0x1eb4dac*/ void set_Host(string value);
                    /*0x1eb4e2c*/ void Decode(byte[] message);
                    /*0x1eb4f1c*/ byte[] GetBytes();
                }

                class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ byte[] _nonce;
                    /*0x20*/ string _targetName;
                    /*0x28*/ byte[] _targetInfo;

                    /*0x1eb5168*/ Type2Message(byte[] message);
                    /*0x1eb520c*/ void Finalize();
                    /*0x1eb4250*/ byte[] get_Nonce();
                    /*0x1eb52b4*/ string get_TargetName();
                    /*0x1eb41d8*/ byte[] get_TargetInfo();
                    /*0x1eb52bc*/ void Decode(byte[] message);
                    /*0x1eb543c*/ byte[] GetBytes();
                }

                class Type3Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel _level;
                    /*0x20*/ byte[] _challenge;
                    /*0x28*/ string _host;
                    /*0x30*/ string _domain;
                    /*0x38*/ string _username;
                    /*0x40*/ string _password;
                    /*0x48*/ Mono.Security.Protocol.Ntlm.Type2Message _type2;
                    /*0x50*/ byte[] _lm;
                    /*0x58*/ byte[] _nt;

                    /*0x1eb54f4*/ Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2);
                    /*0x1eb56e0*/ void Finalize();
                    /*0x1eb57c0*/ void set_Domain(string value);
                    /*0x1eb5840*/ void set_Password(string value);
                    /*0x1eb5848*/ void set_Username(string value);
                    /*0x1eb5850*/ void Decode(byte[] message);
                    /*0x1eb5a70*/ string DecodeString(byte[] buffer, int offset, int len);
                    /*0x1eb5ac8*/ byte[] EncodeString(string text);
                    /*0x1eb5b58*/ byte[] GetBytes();
                }
            }
        }

        namespace Interface
        {
            enum AlertLevel
            {
                Warning = 1,
                Fatal = 2,
            }

            enum AlertDescription
            {
                CloseNotify = 0,
                UnexpectedMessage = 10,
                BadRecordMAC = 20,
                DecryptionFailed_RESERVED = 21,
                RecordOverflow = 22,
                DecompressionFailure = 30,
                HandshakeFailure = 40,
                NoCertificate_RESERVED = 41,
                BadCertificate = 42,
                UnsupportedCertificate = 43,
                CertificateRevoked = 44,
                CertificateExpired = 45,
                CertificateUnknown = 46,
                IlegalParameter = 47,
                UnknownCA = 48,
                AccessDenied = 49,
                DecodeError = 50,
                DecryptError = 51,
                ExportRestriction = 60,
                ProtocolVersion = 70,
                InsuficientSecurity = 71,
                InternalError = 80,
                UserCancelled = 90,
                NoRenegotiation = 100,
                UnsupportedExtension = 110,
            }

            class Alert
            {
                /*0x10*/ Mono.Security.Interface.AlertLevel level;
                /*0x11*/ Mono.Security.Interface.AlertDescription description;

                /*0x1eb6190*/ Alert(Mono.Security.Interface.AlertDescription description);
                /*0x1eb6180*/ Mono.Security.Interface.AlertLevel get_Level();
                /*0x1eb6188*/ Mono.Security.Interface.AlertDescription get_Description();
                /*0x1eb61fc*/ void inferAlertLevel();
                /*0x1eb623c*/ string ToString();
            }

            class ValidationResult
            {
                /*0x10*/ bool trusted;
                /*0x11*/ bool user_denied;
                /*0x14*/ int error_code;
                /*0x18*/ System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors;

                /*0x1eb62f8*/ ValidationResult(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors);
                /*0x1eb6340*/ bool get_Trusted();
                /*0x1eb6348*/ bool get_UserDenied();
            }

            interface ICertificateValidator
            {
            }

            enum CipherSuiteCode
            {
                TLS_NULL_WITH_NULL_NULL = 0,
                TLS_RSA_WITH_NULL_MD5 = 1,
                TLS_RSA_WITH_NULL_SHA = 2,
                TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
                TLS_RSA_WITH_RC4_128_MD5 = 4,
                TLS_RSA_WITH_RC4_128_SHA = 5,
                TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
                TLS_RSA_WITH_IDEA_CBC_SHA = 7,
                TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
                TLS_RSA_WITH_DES_CBC_SHA = 9,
                TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
                TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
                TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
                TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
                TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
                TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
                TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
                TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
                TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
                TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
                TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
                TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
                TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
                TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
                TLS_DH_anon_WITH_RC4_128_MD5 = 24,
                TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
                TLS_DH_anon_WITH_DES_CBC_SHA = 26,
                TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
                TLS_RSA_WITH_AES_128_CBC_SHA = 47,
                TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
                TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
                TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
                TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
                TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
                TLS_RSA_WITH_AES_256_CBC_SHA = 53,
                TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
                TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
                TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
                TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
                TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
                TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
                TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
                TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
                TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
                TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
                TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
                TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
                TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
                TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
                TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
                TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
                TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
                TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
                TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
                TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
                TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
                TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
                TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
                TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
                TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
                TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
                TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
                TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
                TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
                TLS_RSA_WITH_SEED_CBC_SHA = 150,
                TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
                TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
                TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
                TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
                TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
                TLS_PSK_WITH_RC4_128_SHA = 138,
                TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
                TLS_PSK_WITH_AES_128_CBC_SHA = 140,
                TLS_PSK_WITH_AES_256_CBC_SHA = 141,
                TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
                TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
                TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
                TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
                TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
                TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
                TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
                TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
                TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
                TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
                TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
                TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
                TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
                TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
                TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
                TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
                TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
                TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
                TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
                TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
                TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
                TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
                TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
                TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
                TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
                TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
                TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
                TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
                TLS_ECDH_anon_WITH_NULL_SHA = 49173,
                TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
                TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
                TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
                TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
                TLS_PSK_WITH_NULL_SHA = 44,
                TLS_DHE_PSK_WITH_NULL_SHA = 45,
                TLS_RSA_PSK_WITH_NULL_SHA = 46,
                TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
                TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
                TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
                TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
                TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
                TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
                TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
                TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
                TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
                TLS_RSA_WITH_NULL_SHA256 = 59,
                TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
                TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
                TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
                TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
                TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
                TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
                TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
                TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
                TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
                TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
                TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
                TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
                TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
                TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
                TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
                TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
                TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
                TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
                TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
                TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
                TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
                TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
                TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
                TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
                TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
                TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
                TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
                TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
                TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
                TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
                TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
                TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
                TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
                TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
                TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
                TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
                TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
                TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
                TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
                TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
                TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
                TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
                TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
                TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
                TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
                TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
                TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
                TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
                TLS_PSK_WITH_NULL_SHA256 = 176,
                TLS_PSK_WITH_NULL_SHA384 = 177,
                TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
                TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
                TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
                TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
                TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
                TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
                TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
                TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
                TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
                TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
                TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
                TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
                TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
                TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
                TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
                TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
                TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
                TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
                TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
                TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
                TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
                TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
                TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
                TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
                TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
                TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
                TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
                TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
                TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
                TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
                TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
                TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
                TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
                TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
                TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
                TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
                TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
                TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
                TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
                TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
                TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
                TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
                TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
                TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
                TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
                TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
                TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
                TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
                TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
                TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
                TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
                TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
                TLS_RSA_WITH_AES_128_CCM = 49308,
                TLS_RSA_WITH_AES_256_CCM = 49309,
                TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
                TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
                TLS_RSA_WITH_AES_128_CCM_8 = 49312,
                TLS_RSA_WITH_AES_256_CCM_8 = 49313,
                TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
                TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
                TLS_PSK_WITH_AES_128_CCM = 49316,
                TLS_PSK_WITH_AES_256_CCM = 49317,
                TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
                TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
                TLS_PSK_WITH_AES_128_CCM_8 = 49320,
                TLS_PSK_WITH_AES_256_CCM_8 = 49321,
                TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
                TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
                TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
                TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
                TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
                TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
                TLS_RSA_WITH_SALSA20_SHA1 = 58385,
                TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
                TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
                TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
                TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
                TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
                TLS_PSK_WITH_SALSA20_SHA1 = 58391,
                TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
                TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
                TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
                TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
                TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
                TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
                TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
                TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399,
                TLS_FALLBACK_SCSV = 22016,
            }

            class MonoTlsConnectionInfo
            {
                /*0x10*/ Mono.Security.Interface.CipherSuiteCode <CipherSuiteCode>k__BackingField;
                /*0x14*/ Mono.Security.Interface.TlsProtocols <ProtocolVersion>k__BackingField;
                /*0x18*/ string <PeerDomainName>k__BackingField;

                /*0x1eb6434*/ MonoTlsConnectionInfo();
                /*0x1eb6350*/ Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode();
                /*0x1eb6358*/ void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value);
                /*0x1eb6360*/ Mono.Security.Interface.TlsProtocols get_ProtocolVersion();
                /*0x1eb6368*/ void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value);
                /*0x1eb6370*/ void set_PeerDomainName(string value);
                /*0x1eb6378*/ string ToString();
            }

            enum MonoSslPolicyErrors
            {
                None = 0,
                RemoteCertificateNotAvailable = 1,
                RemoteCertificateNameMismatch = 2,
                RemoteCertificateChainErrors = 4,
            }

            class MonoRemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x1eb643c*/ MonoRemoteCertificateValidationCallback(object object, nint method);
                /*0x1eb6514*/ bool Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors);
            }

            class MonoLocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x1eb6528*/ MonoLocalCertificateSelectionCallback(object object, nint method);
                /*0x1eb6600*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class MonoTlsProvider
            {
                /*0x1eb6614*/ MonoTlsProvider();
                System.Guid get_ID();
                string get_Name();
                bool get_SupportsSslStream();
                bool get_SupportsConnectionInfo();
                bool get_SupportsMonoExtensions();
                System.Security.Authentication.SslProtocols get_SupportedProtocols();
                bool get_SupportsCleanShutdown();
            }

            class MonoTlsProviderFactory
            {
                static /*0x1eb661c*/ Mono.Security.Interface.MonoTlsProvider GetProvider();
            }

            class MonoTlsSettings
            {
                static /*0x0*/ Mono.Security.Interface.MonoTlsSettings defaultSettings;
                /*0x10*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;
                /*0x18*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;
                /*0x20*/ System.Nullable<System.DateTime> <CertificateValidationTime>k__BackingField;
                /*0x30*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <TrustAnchors>k__BackingField;
                /*0x38*/ object <UserSettings>k__BackingField;
                /*0x40*/ string[] <CertificateSearchPaths>k__BackingField;
                /*0x48*/ bool <SendCloseNotify>k__BackingField;
                /*0x50*/ string[] <ClientCertificateIssuers>k__BackingField;
                /*0x58*/ bool <DisallowUnauthenticatedCertificateRequest>k__BackingField;
                /*0x5c*/ System.Nullable<Mono.Security.Interface.TlsProtocols> <EnabledProtocols>k__BackingField;
                /*0x68*/ Mono.Security.Interface.CipherSuiteCode[] <EnabledCiphers>k__BackingField;
                /*0x70*/ bool cloned;
                /*0x71*/ bool checkCertName;
                /*0x72*/ bool checkCertRevocationStatus;
                /*0x73*/ System.Nullable<bool> useServicePointManagerCallback;
                /*0x75*/ bool skipSystemValidators;
                /*0x76*/ bool callbackNeedsChain;
                /*0x78*/ Mono.Security.Interface.ICertificateValidator certificateValidator;

                static /*0x1eb6774*/ Mono.Security.Interface.MonoTlsSettings get_DefaultSettings();
                static /*0x1eb6808*/ Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings();
                /*0x1eb6760*/ MonoTlsSettings();
                /*0x1eb6908*/ MonoTlsSettings(Mono.Security.Interface.MonoTlsSettings other);
                /*0x1eb668c*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback();
                /*0x1eb6694*/ void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value);
                /*0x1eb669c*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback();
                /*0x1eb66a4*/ void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value);
                /*0x1eb66ac*/ System.Nullable<bool> get_UseServicePointManagerCallback();
                /*0x1eb66b4*/ void set_UseServicePointManagerCallback(System.Nullable<bool> value);
                /*0x1eb66bc*/ bool get_CallbackNeedsCertificateChain();
                /*0x1eb66c4*/ System.Nullable<System.DateTime> get_CertificateValidationTime();
                /*0x1eb66d0*/ void set_CertificateValidationTime(System.Nullable<System.DateTime> value);
                /*0x1eb66d8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors();
                /*0x1eb66e0*/ void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x1eb66e8*/ object get_UserSettings();
                /*0x1eb66f0*/ void set_UserSettings(object value);
                /*0x1eb66f8*/ string[] get_CertificateSearchPaths();
                /*0x1eb6700*/ void set_CertificateSearchPaths(string[] value);
                /*0x1eb6708*/ bool get_SendCloseNotify();
                /*0x1eb6710*/ void set_SendCloseNotify(bool value);
                /*0x1eb671c*/ string[] get_ClientCertificateIssuers();
                /*0x1eb6724*/ void set_ClientCertificateIssuers(string[] value);
                /*0x1eb672c*/ bool get_DisallowUnauthenticatedCertificateRequest();
                /*0x1eb6734*/ void set_DisallowUnauthenticatedCertificateRequest(bool value);
                /*0x1eb6740*/ System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols();
                /*0x1eb6748*/ void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value);
                /*0x1eb6750*/ Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers();
                /*0x1eb6758*/ void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value);
                /*0x1eb6880*/ Mono.Security.Interface.ICertificateValidator get_CertificateValidator();
                /*0x1eb6888*/ Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator);
                /*0x1eb6820*/ Mono.Security.Interface.MonoTlsSettings Clone();
            }

            class TlsException : System.Exception
            {
                /*0x90*/ Mono.Security.Interface.Alert alert;

                /*0x1eb6a50*/ TlsException(Mono.Security.Interface.Alert alert, string message);
                /*0x1eb6ac4*/ TlsException(Mono.Security.Interface.AlertDescription description, string message);
            }

            enum TlsProtocols
            {
                Zero = 0,
                Tls10Client = 128,
                Tls10Server = 64,
                Tls10 = 192,
                Tls11Client = 512,
                Tls11Server = 256,
                Tls11 = 768,
                Tls12Client = 2048,
                Tls12Server = 1024,
                Tls12 = 3072,
                ClientMask = 2688,
                ServerMask = 1344,
            }
        }

        namespace Cryptography
        {
            class CryptoConvert
            {
                static /*0x1eb6b3c*/ string ToHex(byte[] input);
            }

            class MD2 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x1eb6c90*/ Mono.Security.Cryptography.MD2 Create();
                /*0x1eb6c70*/ MD2();
            }

            class MD2Managed : Mono.Security.Cryptography.MD2
            {
                static /*0x0*/ byte[] PI_SUBST;
                /*0x28*/ byte[] state;
                /*0x30*/ byte[] checksum;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int count;
                /*0x48*/ byte[] x;

                static /*0x1eb72ac*/ MD2Managed();
                /*0x1eb6ce8*/ MD2Managed();
                /*0x1eb6d8c*/ byte[] Padding(int nLength);
                /*0x1eb6e28*/ void Initialize();
                /*0x1eb6e88*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x1eb71bc*/ byte[] HashFinal();
                /*0x1eb6f64*/ void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index);
            }

            class MD4 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x1eb7360*/ Mono.Security.Cryptography.MD4 Create();
                /*0x1eb7340*/ MD4();
            }

            class MD4Managed : Mono.Security.Cryptography.MD4
            {
                /*0x28*/ uint[] state;
                /*0x30*/ byte[] buffer;
                /*0x38*/ uint[] count;
                /*0x40*/ uint[] x;
                /*0x48*/ byte[] digest;

                /*0x1eb73b8*/ MD4Managed();
                /*0x1eb7488*/ void Initialize();
                /*0x1eb753c*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x1eb7cd8*/ byte[] HashFinal();
                /*0x1eb7ecc*/ byte[] Padding(int nLength);
                /*0x1eb7f44*/ uint F(uint x, uint y, uint z);
                /*0x1eb7f54*/ uint G(uint x, uint y, uint z);
                /*0x1eb7f68*/ uint H(uint x, uint y, uint z);
                /*0x1eb7f74*/ uint ROL(uint x, byte n);
                /*0x1eb7f84*/ void FF(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x1eb7fb0*/ void GG(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x1eb7fec*/ void HH(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x1eb7dd4*/ void Encode(byte[] output, uint[] input);
                /*0x1eb8020*/ void Decode(uint[] output, byte[] input, int index);
                /*0x1eb7660*/ void MD4Transform(uint[] state, byte[] block, int index);
            }

            class PKCS1
            {
                static /*0x0*/ byte[] emptySHA1;
                static /*0x8*/ byte[] emptySHA256;
                static /*0x10*/ byte[] emptySHA384;
                static /*0x18*/ byte[] emptySHA512;

                static /*0x1eb9054*/ PKCS1();
                static /*0x1eb80d4*/ bool Compare(byte[] array1, byte[] array2);
                static /*0x1eb8148*/ byte[] I2OSP(byte[] x, int size);
                static /*0x1eb81d4*/ byte[] OS2IP(byte[] x);
                static /*0x1eb8290*/ byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s);
                static /*0x1eb82b0*/ bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding);
                static /*0x1eb8494*/ byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength);
                static /*0x1eb87dc*/ string HashNameFromOid(string oid, bool throwOnError);
                static /*0x1eb8bec*/ System.Security.Cryptography.HashAlgorithm CreateFromOid(string oid);
                static /*0x1eb8c48*/ System.Security.Cryptography.HashAlgorithm CreateFromName(string name);
            }

            class PKCS8
            {
                class PrivateKeyInfo
                {
                    /*0x10*/ int _version;
                    /*0x18*/ string _algorithm;
                    /*0x20*/ byte[] _key;
                    /*0x28*/ System.Collections.ArrayList _list;

                    static /*0x1eb9ab0*/ byte[] RemoveLeadingZero(byte[] bigInt);
                    static /*0x1eb9b4c*/ byte[] Normalize(byte[] bigInt, int length);
                    static /*0x1eb9bec*/ System.Security.Cryptography.RSA DecodeRSA(byte[] keypair);
                    static /*0x1eb9fbc*/ byte[] Encode(System.Security.Cryptography.RSA rsa);
                    static /*0x1eba1bc*/ System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters);
                    static /*0x1eba2e8*/ byte[] Encode(System.Security.Cryptography.DSA dsa);
                    static /*0x1eba338*/ byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa);
                    /*0x1eb91a4*/ PrivateKeyInfo();
                    /*0x1eb9214*/ PrivateKeyInfo(byte[] data);
                    /*0x1eb94a4*/ string get_Algorithm();
                    /*0x1eb94ac*/ void set_Algorithm(string value);
                    /*0x1eb94b4*/ byte[] get_PrivateKey();
                    /*0x1eb9528*/ void set_PrivateKey(byte[] value);
                    /*0x1eb923c*/ void Decode(byte[] data);
                    /*0x1eb961c*/ byte[] GetBytes();
                }

                class EncryptedPrivateKeyInfo
                {
                    /*0x10*/ string _algorithm;
                    /*0x18*/ byte[] _salt;
                    /*0x20*/ int _iterations;
                    /*0x28*/ byte[] _data;

                    /*0x1eba460*/ EncryptedPrivateKeyInfo();
                    /*0x1eba468*/ EncryptedPrivateKeyInfo(byte[] data);
                    /*0x1eba75c*/ string get_Algorithm();
                    /*0x1eba764*/ void set_Algorithm(string value);
                    /*0x1eba76c*/ byte[] get_EncryptedData();
                    /*0x1eba7e0*/ void set_EncryptedData(byte[] value);
                    /*0x1eba868*/ byte[] get_Salt();
                    /*0x1eba91c*/ int get_IterationCount();
                    /*0x1eba924*/ void set_IterationCount(int value);
                    /*0x1eba494*/ void Decode(byte[] data);
                    /*0x1eba9a0*/ byte[] GetBytes();
                }
            }

            class RSAManaged : System.Security.Cryptography.RSA
            {
                /*0x20*/ bool isCRTpossible;
                /*0x21*/ bool keyBlinding;
                /*0x22*/ bool keypairGenerated;
                /*0x23*/ bool m_disposed;
                /*0x28*/ Mono.Math.BigInteger d;
                /*0x30*/ Mono.Math.BigInteger p;
                /*0x38*/ Mono.Math.BigInteger q;
                /*0x40*/ Mono.Math.BigInteger dp;
                /*0x48*/ Mono.Math.BigInteger dq;
                /*0x50*/ Mono.Math.BigInteger qInv;
                /*0x58*/ Mono.Math.BigInteger n;
                /*0x60*/ Mono.Math.BigInteger e;
                /*0x68*/ Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated;

                /*0x1ebab80*/ RSAManaged();
                /*0x1ebab88*/ RSAManaged(int keySize);
                /*0x1ebac78*/ void Finalize();
                /*0x1ebad18*/ void GenerateKeyPair();
                /*0x1ebb590*/ int get_KeySize();
                /*0x1ebb634*/ string get_KeyExchangeAlgorithm();
                /*0x1ebb674*/ bool get_PublicOnly();
                /*0x1ebb7c4*/ string get_SignatureAlgorithm();
                /*0x1ebb804*/ byte[] DecryptValue(byte[] rgb);
                /*0x1ebc02c*/ byte[] EncryptValue(byte[] rgb);
                /*0x1ebc138*/ System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
                /*0x1ebc598*/ void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
                /*0x1ebca04*/ void Dispose(bool disposing);
                /*0x1ebcc08*/ string ToXmlString(bool includePrivateParameters);
                /*0x1ebbf7c*/ byte[] GetPaddedValue(Mono.Math.BigInteger value, int length);

                class KeyGeneratedEventHandler : System.MulticastDelegate
                {
                    /*0x1ebd290*/ KeyGeneratedEventHandler(object object, nint method);
                    /*0x1ebd3c0*/ void Invoke(object sender, System.EventArgs e);
                }
            }
        }

        namespace Authenticode
        {
            class AuthenticodeBase
            {
                /*0x10*/ byte[] fileblock;
                /*0x18*/ System.IO.Stream fs;
                /*0x20*/ int blockNo;
                /*0x24*/ int blockLength;
                /*0x28*/ int peOffset;
                /*0x2c*/ int dirSecurityOffset;
                /*0x30*/ int dirSecuritySize;
                /*0x34*/ int coffSymbolTableOffset;
                /*0x38*/ bool pe64;

                /*0x1ebd3d4*/ AuthenticodeBase();
                /*0x1ebd430*/ int get_PEOffset();
                /*0x1ebd530*/ void Open(string filename);
                /*0x1ebd5f0*/ void Open(byte[] rawdata);
                /*0x1ebd5c4*/ void Close();
                /*0x1ebd458*/ void ReadFirstBlock();
                /*0x1ebd67c*/ int ProcessFirstBlock();
                /*0x1ebd8c0*/ byte[] GetSecurityEntry();
                /*0x1ebd990*/ byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash);
            }

            class AuthenticodeDeformatter : Mono.Security.Authenticode.AuthenticodeBase
            {
                /*0x40*/ string filename;
                /*0x48*/ byte[] rawdata;
                /*0x50*/ byte[] hash;
                /*0x58*/ Mono.Security.X509.X509CertificateCollection coll;
                /*0x60*/ Mono.Security.ASN1 signedHash;
                /*0x68*/ System.DateTime timestamp;
                /*0x70*/ Mono.Security.X509.X509Certificate signingCertificate;
                /*0x78*/ int reason;
                /*0x7c*/ bool trustedRoot;
                /*0x7d*/ bool trustedTimestampRoot;
                /*0x80*/ byte[] entry;
                /*0x88*/ Mono.Security.X509.X509Chain signerChain;
                /*0x90*/ Mono.Security.X509.X509Chain timestampChain;

                /*0x1ebde20*/ AuthenticodeDeformatter();
                /*0x1ebdeac*/ AuthenticodeDeformatter(byte[] rawData);
                /*0x1ebded4*/ void set_RawData(byte[] value);
                /*0x1ebe33c*/ Mono.Security.X509.X509Certificate get_SigningCertificate();
                /*0x1ebe048*/ bool CheckSignature();
                /*0x1ebed8c*/ bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509);
                /*0x1ebe344*/ bool VerifySignature(Mono.Security.PKCS7.SignedData sd, byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha);
                /*0x1ebee80*/ bool VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, byte[] signature);
                /*0x1ebdfa4*/ void Reset();
            }
        }
    }

    namespace Math
    {
        class BigInteger
        {
            static /*0x0*/ uint[] smallPrimes;
            static /*0x8*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ uint length;
            /*0x18*/ uint[] data;

            static /*0x1ec19a8*/ BigInteger();
            static /*0x1ebaf80*/ Mono.Math.BigInteger op_Implicit(uint value);
            static /*0x1ebb330*/ Mono.Math.BigInteger op_Implicit(int value);
            static /*0x1ebbe4c*/ Mono.Math.BigInteger op_Addition(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebb3e0*/ Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebb04c*/ uint op_Modulus(Mono.Math.BigInteger bi, uint ui);
            static /*0x1ebb564*/ Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ec0534*/ Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebb100*/ Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ec0658*/ Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x1ec082c*/ Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x1ec09ac*/ System.Security.Cryptography.RandomNumberGenerator get_Rng();
            static /*0x1ec0a54*/ Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng);
            static /*0x1ebbd60*/ Mono.Math.BigInteger GenerateRandom(int bits);
            static /*0x1ebfb6c*/ bool op_Equality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x1ec0d30*/ bool op_Inequality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x1ebb714*/ bool op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebb050*/ bool op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebbe34*/ bool op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebb31c*/ bool op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ec0d9c*/ bool op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ec0db4*/ bool op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1ebafe0*/ Mono.Math.BigInteger GeneratePseudoPrime(int bits);
            /*0x1ebf884*/ BigInteger(Mono.Math.BigInteger.Sign sign, uint len);
            /*0x1ebf8f8*/ BigInteger(Mono.Math.BigInteger bi);
            /*0x1ebf9b8*/ BigInteger(Mono.Math.BigInteger bi, uint len);
            /*0x1ebbb24*/ BigInteger(byte[] inData);
            /*0x1ebfae4*/ BigInteger(uint ui);
            /*0x1ebb2b0*/ int BitCount();
            /*0x1ec0bb8*/ bool TestBit(int bitNum);
            /*0x1ec0c50*/ void SetBit(uint bitNum);
            /*0x1ec0c58*/ void SetBit(uint bitNum, bool value);
            /*0x1ec0cb4*/ int LowestSetBit();
            /*0x1ebc46c*/ byte[] GetBytes();
            /*0x1ec0dcc*/ string ToString(uint radix);
            /*0x1ec0e24*/ string ToString(uint radix, string characterSet);
            /*0x1ebfa8c*/ void Normalize();
            /*0x1ebbf2c*/ void Clear();
            /*0x1ec10b4*/ int GetHashCode();
            /*0x1ec110c*/ string ToString();
            /*0x1ec1114*/ bool Equals(object o);
            /*0x1ebb560*/ Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus);
            /*0x1ebbdbc*/ Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n);
            /*0x1ec1924*/ void Incr2();

            enum Sign
            {
                Negative = -1,
                Zero = 0,
                Positive = 1,
            }

            class ModulusRing
            {
                /*0x10*/ Mono.Math.BigInteger mod;
                /*0x18*/ Mono.Math.BigInteger constant;

                /*0x1ec1744*/ ModulusRing(Mono.Math.BigInteger modulus);
                /*0x1ec1a3c*/ void BarrettReduction(Mono.Math.BigInteger x);
                /*0x1ec2040*/ Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x1ec21bc*/ Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x1ec1814*/ Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k);
                /*0x1ec2378*/ Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp);
            }

            class Kernel
            {
                static /*0x1ebfbd8*/ Mono.Math.BigInteger AddSameSign(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1ebfed0*/ Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x1ec1dc8*/ void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x1ec1ec8*/ void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1ebfd8c*/ Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1ec1038*/ uint SingleByteDivideInPlace(Mono.Math.BigInteger n, uint d);
                static /*0x1ec0074*/ uint DwordMod(Mono.Math.BigInteger n, uint d);
                static /*0x1ec23f0*/ Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, uint d);
                static /*0x1ec00e0*/ Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1ec065c*/ Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, int n);
                static /*0x1ec0830*/ Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, int n);
                static /*0x1ec055c*/ void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset);
                static /*0x1ec1c98*/ void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod);
                static /*0x1ec2580*/ uint modInverse(Mono.Math.BigInteger bi, uint modulus);
                static /*0x1ec1254*/ Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus);
            }
        }

        namespace Prime
        {
            enum ConfidenceFactor
            {
                ExtraLow = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                ExtraHigh = 4,
                Provable = 5,
            }

            class PrimalityTest : System.MulticastDelegate
            {
                /*0x1ec2640*/ PrimalityTest(object object, nint method);
                /*0x1ec2770*/ bool Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            class PrimalityTests
            {
                static /*0x1ec2784*/ int GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
                static /*0x1ec2918*/ bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            namespace Generator
            {
                class PrimeGeneratorBase
                {
                    /*0x1ec2c2c*/ PrimeGeneratorBase();
                    /*0x1ec2ba8*/ Mono.Math.Prime.ConfidenceFactor get_Confidence();
                    /*0x1ec2bb0*/ Mono.Math.Prime.PrimalityTest get_PrimalityTest();
                    /*0x1ec2c24*/ int get_TrialDivisionBounds();
                    Mono.Math.BigInteger GenerateNewPrime(int bits);
                }

                class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase
                {
                    /*0x1ec191c*/ SequentialSearchPrimeGeneratorBase();
                    /*0x1ec2c34*/ Mono.Math.BigInteger GenerateSearchBase(int bits, object context);
                    /*0x1ec2ca8*/ Mono.Math.BigInteger GenerateNewPrime(int bits);
                    /*0x1ec2cb8*/ Mono.Math.BigInteger GenerateNewPrime(int bits, object context);
                    /*0x1ec2f9c*/ bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2;
    static /*0x40*/ <PrivateImplementationDetails> 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5;
    static /*0xc80*/ long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88;
    static /*0xc88*/ <PrivateImplementationDetails> 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950;
    static /*0xc8b*/ <PrivateImplementationDetails> 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB;
    static /*0xc8e*/ <PrivateImplementationDetails> 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D;
    static /*0xc91*/ <PrivateImplementationDetails> 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174;
    static /*0xc94*/ <PrivateImplementationDetails> 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6;
    static /*0xcc4*/ <PrivateImplementationDetails> 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA;
    static /*0xcd8*/ <PrivateImplementationDetails> 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329;
    static /*0xdd8*/ <PrivateImplementationDetails> 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE;
    static /*0xddb*/ <PrivateImplementationDetails> 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456;
    static /*0xdfb*/ <PrivateImplementationDetails> 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B;
    static /*0xdfe*/ <PrivateImplementationDetails> 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B;
    static /*0xe08*/ <PrivateImplementationDetails> 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7;
    static /*0xe18*/ long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426;
    static /*0xe20*/ <PrivateImplementationDetails> 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6;
    static /*0xe29*/ <PrivateImplementationDetails> 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31;
    static /*0xe69*/ <PrivateImplementationDetails> 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B;
    static /*0xe6c*/ <PrivateImplementationDetails> 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5;
    static /*0xeac*/ <PrivateImplementationDetails> 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE;
    static /*0xeb0*/ long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24;
    static /*0xeb8*/ <PrivateImplementationDetails> 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925;
    static /*0xebb*/ <PrivateImplementationDetails> 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047;
    static /*0xecd*/ <PrivateImplementationDetails> B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75;
    static /*0xed0*/ <PrivateImplementationDetails> C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B;
    static /*0xed3*/ <PrivateImplementationDetails> E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F;
    static /*0xed6*/ <PrivateImplementationDetails> F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD;
    static /*0xf16*/ <PrivateImplementationDetails> FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064;

    static /*0x1eb8b70*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=9
    {
    }

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=18
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=48
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=3132
    {
    }
}
