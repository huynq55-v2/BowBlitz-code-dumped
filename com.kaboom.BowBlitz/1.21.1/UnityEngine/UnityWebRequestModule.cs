class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x2ac4ec4*/ WebRequestUtils();
        static /*0x2ac453c*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x2ac4630*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x2ac49c8*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x2ac4dbc*/ string URLDecode(string encoded);
    }
}

namespace UnityEngine
{
    class WWWForm
    {
        static /*0x0*/ byte[] dDash;
        static /*0x8*/ byte[] crlf;
        static /*0x10*/ byte[] contentTypeHeader;
        static /*0x18*/ byte[] dispositionHeader;
        static /*0x20*/ byte[] endQuote;
        static /*0x28*/ byte[] fileNameField;
        static /*0x30*/ byte[] ampersand;
        static /*0x38*/ byte[] equal;
        /*0x10*/ System.Collections.Generic.List<System.Byte[]> formData;
        /*0x18*/ System.Collections.Generic.List<string> fieldNames;
        /*0x20*/ System.Collections.Generic.List<string> fileNames;
        /*0x28*/ System.Collections.Generic.List<string> types;
        /*0x30*/ byte[] boundary;
        /*0x38*/ bool containsFiles;

        static /*0x2ac6338*/ WWWForm();
        static /*0x2ac4f54*/ System.Text.Encoding get_DefaultEncoding();
        /*0x2ac4f5c*/ System.Collections.Generic.Dictionary<string, string> get_headers();
        /*0x2ac509c*/ byte[] get_data();
    }

    class WWWTranscoder
    {
        static /*0x0*/ byte[] ucHexChars;
        static /*0x8*/ byte[] lcHexChars;
        static /*0x10*/ byte urlEscapeChar;
        static /*0x18*/ byte[] urlSpace;
        static /*0x20*/ byte[] dataSpace;
        static /*0x28*/ byte[] urlForbidden;
        static /*0x30*/ byte qpEscapeChar;
        static /*0x38*/ byte[] qpSpace;
        static /*0x40*/ byte[] qpForbidden;

        static /*0x2ac6fc0*/ WWWTranscoder();
        static /*0x2ac6570*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x2ac661c*/ void Byte2Hex(byte b, byte[] hexChars, ref byte byte0, ref byte byte1);
        static /*0x2ac6670*/ byte[] URLEncode(byte[] toEncode);
        static /*0x2ac6a88*/ string DataEncode(string toEncode);
        static /*0x2ac6af0*/ string DataEncode(string toEncode, System.Text.Encoding e);
        static /*0x2ac62d0*/ byte[] DataEncode(byte[] toEncode);
        static /*0x2ac61dc*/ string QPEncode(string toEncode, System.Text.Encoding e);
        static /*0x2ac66dc*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x2ac6be4*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x2ac4e60*/ byte[] URLDecode(byte[] toEncode);
        static /*0x2ac6f10*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x2ac6c30*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
        static /*0x2ac609c*/ bool SevenBitClean(string s, System.Text.Encoding e);
        static /*0x2ac6f88*/ bool SevenBitClean(byte* input, int inputLength);
    }

    namespace Networking
    {
        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x2ac71f4*/ UnityWebRequestAsyncOperation();
            /*0x2ac71e4*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x2ac71ec*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);
        }

        class UnityWebRequest : System.IDisposable
        {
            static string kHttpVerbGET = "GET";
            static string kHttpVerbHEAD = "HEAD";
            static string kHttpVerbPOST = "POST";
            static string kHttpVerbPUT = "PUT";
            static string kHttpVerbCREATE = "CREATE";
            static string kHttpVerbDELETE = "DELETE";
            /*0x10*/ nint m_Ptr;
            /*0x18*/ UnityEngine.Networking.DownloadHandler m_DownloadHandler;
            /*0x20*/ UnityEngine.Networking.UploadHandler m_UploadHandler;
            /*0x28*/ UnityEngine.Networking.CertificateHandler m_CertificateHandler;
            /*0x30*/ System.Uri m_Uri;
            /*0x38*/ bool <disposeCertificateHandlerOnDispose>k__BackingField;
            /*0x39*/ bool <disposeDownloadHandlerOnDispose>k__BackingField;
            /*0x3a*/ bool <disposeUploadHandlerOnDispose>k__BackingField;

            static /*0x2ac71fc*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x2ac7238*/ string GetHTTPStatusString(long responseCode);
            static /*0x2ac72b0*/ void ClearCookieCache();
            static /*0x2ac7328*/ void ClearCookieCache(System.Uri uri);
            static /*0x2ac72e4*/ void ClearCookieCache(string domain, string path);
            static /*0x2ac7430*/ nint Create();
            static /*0x2ac9bdc*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x2ac9cd0*/ UnityEngine.Networking.UnityWebRequest Get(System.Uri uri);
            static /*0x2ac9d78*/ UnityEngine.Networking.UnityWebRequest Delete(string uri);
            static /*0x2ac9df0*/ UnityEngine.Networking.UnityWebRequest Delete(System.Uri uri);
            static /*0x2ac9e68*/ UnityEngine.Networking.UnityWebRequest Head(string uri);
            static /*0x2ac9ee0*/ UnityEngine.Networking.UnityWebRequest Head(System.Uri uri);
            static /*0x2ac9f58*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri);
            static /*0x2ac9fa8*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
            static /*0x2ac9ff8*/ UnityEngine.Networking.UnityWebRequest GetAudioClip(string uri, UnityEngine.AudioType audioType);
            static /*0x2aca000*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri);
            static /*0x2aca008*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
            static /*0x2aca010*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint version, uint crc);
            static /*0x2aca018*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.Hash128 hash, uint crc);
            static /*0x2aca020*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
            static /*0x2aca028*/ UnityEngine.Networking.UnityWebRequest Put(string uri, byte[] bodyData);
            static /*0x2aca194*/ UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, byte[] bodyData);
            static /*0x2aca274*/ UnityEngine.Networking.UnityWebRequest Put(string uri, string bodyData);
            static /*0x2aca37c*/ UnityEngine.Networking.UnityWebRequest Put(System.Uri uri, string bodyData);
            static /*0x2aca484*/ UnityEngine.Networking.UnityWebRequest Post(string uri, string postData);
            static /*0x2aca674*/ UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, string postData);
            static /*0x2aca514*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, string postData);
            static /*0x2aca710*/ UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData);
            static /*0x2aca98c*/ UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, UnityEngine.WWWForm formData);
            static /*0x2aca7a0*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData);
            static /*0x2acaa1c*/ UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections);
            static /*0x2acab88*/ UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections);
            static /*0x2acaaf0*/ UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
            static /*0x2acabb4*/ UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
            static /*0x2acac4c*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
            static /*0x2acb568*/ UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.Dictionary<string, string> formFields);
            static /*0x2acb710*/ UnityEngine.Networking.UnityWebRequest Post(System.Uri uri, System.Collections.Generic.Dictionary<string, string> formFields);
            static /*0x2acb5f8*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<string, string> formFields);
            static /*0x2acba0c*/ string EscapeURL(string s);
            static /*0x2acba2c*/ string EscapeURL(string s, System.Text.Encoding e);
            static /*0x2acbb04*/ string UnEscapeURL(string s);
            static /*0x2acbb24*/ string UnEscapeURL(string s, System.Text.Encoding e);
            static /*0x2acad9c*/ byte[] SerializeFormSections(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> multipartFormSections, byte[] boundary);
            static /*0x2acaa48*/ byte[] GenerateBoundary();
            static /*0x2acb7a0*/ byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<string, string> formFields);
            /*0x2ac75a0*/ UnityWebRequest();
            /*0x2ac75f8*/ UnityWebRequest(string url);
            /*0x2ac76e4*/ UnityWebRequest(System.Uri uri);
            /*0x2ac7834*/ UnityWebRequest(string url, string method);
            /*0x2ac7a34*/ UnityWebRequest(System.Uri uri, string method);
            /*0x2ac7ab0*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x2ac7d74*/ UnityWebRequest(System.Uri uri, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x2ac7274*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x2ac727c*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x2ac7288*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x2ac7290*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x2ac729c*/ bool get_disposeUploadHandlerOnDispose();
            /*0x2ac72a4*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x2ac7458*/ void Release();
            /*0x2ac7494*/ void InternalDestroy();
            /*0x2ac758c*/ void InternalSetDefaults();
            /*0x2ac7e18*/ void Finalize();
            /*0x2ac7f14*/ void Dispose();
            /*0x2ac7eb4*/ void DisposeHandlers();
            /*0x2ac8028*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x2ac8064*/ UnityEngine.AsyncOperation Send();
            /*0x2ac80ac*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x2ac7550*/ void Abort();
            /*0x2ac80f4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x2ac8138*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x2ac8280*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x2ac82c4*/ void InternalSetCustomMethod(string customMethodName);
            /*0x2ac83d0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod();
            /*0x2ac840c*/ string GetCustomMethod();
            /*0x2ac8448*/ string get_method();
            /*0x2ac78b0*/ void set_method(string value);
            /*0x2ac8550*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x2ac858c*/ string get_error();
            /*0x2ac87a8*/ bool get_use100Continue();
            /*0x2ac87e4*/ void set_use100Continue(bool value);
            /*0x2ac8828*/ bool get_useHttpContinue();
            /*0x2ac8864*/ void set_useHttpContinue(bool value);
            /*0x2ac8920*/ string get_url();
            /*0x2ac765c*/ void set_url(string value);
            /*0x2ac8aa4*/ System.Uri get_uri();
            /*0x2ac7748*/ void set_uri(System.Uri value);
            /*0x2ac895c*/ string GetUrl();
            /*0x2ac8b38*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x2ac8998*/ void InternalSetUrl(string url);
            /*0x2ac876c*/ long get_responseCode();
            /*0x2ac8b7c*/ float GetUploadProgress();
            /*0x2ac8bb8*/ bool IsExecuting();
            /*0x2ac8bf4*/ float get_uploadProgress();
            /*0x2ac8244*/ bool get_isModifiable();
            /*0x2ac8c98*/ bool get_isDone();
            /*0x2ac8ce0*/ bool get_isNetworkError();
            /*0x2ac8d28*/ bool get_isHttpError();
            /*0x2ac8730*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x2ac8d70*/ float GetDownloadProgress();
            /*0x2ac8dac*/ float get_downloadProgress();
            /*0x2ac8e50*/ ulong get_uploadedBytes();
            /*0x2ac8e8c*/ ulong get_downloadedBytes();
            /*0x2ac8ec8*/ int GetRedirectLimit();
            /*0x2ac8f04*/ void SetRedirectLimitFromScripting(int limit);
            /*0x2ac8f48*/ int get_redirectLimit();
            /*0x2ac8f84*/ void set_redirectLimit(int value);
            /*0x2ac8fc8*/ bool GetChunked();
            /*0x2ac9004*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(bool chunked);
            /*0x2ac9048*/ bool get_chunkedTransfer();
            /*0x2ac9084*/ void set_chunkedTransfer(bool value);
            /*0x2ac9190*/ string GetRequestHeader(string name);
            /*0x2ac91d4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);
            /*0x2ac9228*/ void SetRequestHeader(string name, string value);
            /*0x2ac93b4*/ string GetResponseHeader(string name);
            /*0x2ac93f8*/ string[] GetResponseHeaderKeys();
            /*0x2ac9434*/ System.Collections.Generic.Dictionary<string, string> GetResponseHeaders();
            /*0x2ac9604*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x2ac7f84*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x2ac7c64*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x2ac9648*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x2ac7f7c*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x2ac7b54*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x2ac968c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch);
            /*0x2ac7f8c*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x2ac96d0*/ void set_certificateHandler(UnityEngine.Networking.CertificateHandler value);
            /*0x2ac97e0*/ int GetTimeoutMsec();
            /*0x2ac981c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x2ac9860*/ int get_timeout();
            /*0x2ac98b8*/ void set_timeout(int value);
            /*0x2ac9a14*/ bool GetSuppressErrorsToConsole();
            /*0x2ac9a50*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetSuppressErrorsToConsole(bool suppress);
            /*0x2ac9a94*/ bool get_suppressErrorsToConsole();
            /*0x2ac9ad0*/ void set_suppressErrorsToConsole(bool value);

            enum UnityWebRequestMethod
            {
                Get = 0,
                Post = 1,
                Put = 2,
                Head = 3,
                Custom = 4,
            }

            enum UnityWebRequestError
            {
                OK = 0,
                Unknown = 1,
                SDKError = 2,
                UnsupportedProtocol = 3,
                MalformattedUrl = 4,
                CannotResolveProxy = 5,
                CannotResolveHost = 6,
                CannotConnectToHost = 7,
                AccessDenied = 8,
                GenericHttpError = 9,
                WriteError = 10,
                ReadError = 11,
                OutOfMemory = 12,
                Timeout = 13,
                HTTPPostError = 14,
                SSLCannotConnect = 15,
                Aborted = 16,
                TooManyRedirects = 17,
                ReceivedNoData = 18,
                SSLNotSupported = 19,
                FailedToSendData = 20,
                FailedToReceiveData = 21,
                SSLCertificateError = 22,
                SSLCipherNotAvailable = 23,
                SSLCACertError = 24,
                UnrecognizedContentEncoding = 25,
                LoginFailed = 26,
                SSLShutdownFailed = 27,
                NoInternetConnection = 28,
            }

            enum Result
            {
                InProgress = 0,
                Success = 1,
                ConnectionError = 2,
                ProtocolError = 3,
                DataProcessingError = 4,
            }
        }

        interface IMultipartFormSection
        {
            string get_sectionName();
            byte[] get_sectionData();
            string get_fileName();
            string get_contentType();
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest www);
            static /*0x2acc35c*/ byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, ref int length);
            static /*0x2acbefc*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            static /*0x2acc3a0*/ Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray);
            static /*0x2acc45c*/ void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data);
            static /*0x2acc4b0*/ void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length);
            /*0x2acbc3c*/ DownloadHandler();
            /*0x2acbc00*/ void Release();
            /*0x2acbc44*/ void Finalize();
            /*0x2acbce0*/ void Dispose();
            /*0x2acbd74*/ bool get_isDone();
            /*0x2acbdb0*/ bool IsDone();
            /*0x2acbdec*/ string get_error();
            /*0x2acbe28*/ string GetErrorMsg();
            /*0x2acbe64*/ Unity.Collections.NativeArray.ReadOnly<byte> get_nativeData();
            /*0x2acbed4*/ byte[] get_data();
            /*0x2acbee0*/ string get_text();
            /*0x2acbeec*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x2acbef8*/ byte[] GetData();
            /*0x2acbfa0*/ string GetText();
            /*0x2acc088*/ System.Text.Encoding GetTextEncoder();
            /*0x2acc2fc*/ string GetContentType();
            /*0x2acc338*/ bool ReceiveData(byte[] data, int dataLength);
            /*0x2acc340*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x2acc34c*/ void ReceiveContentLength(int contentLength);
            /*0x2acc350*/ void CompleteContent();
            /*0x2acc354*/ float GetProgress();
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x2acc518*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            static /*0x2acc5bc*/ string GetContent(UnityEngine.Networking.UnityWebRequest www);
            /*0x2ac9c84*/ DownloadHandlerBuffer();
            /*0x2acc554*/ void InternalCreateBuffer();
            /*0x2acc598*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x2acc5a0*/ void Dispose();
        }

        class DownloadHandlerScript : UnityEngine.Networking.DownloadHandler
        {
            static /*0x2acc618*/ nint CreatePreallocated(UnityEngine.Networking.DownloadHandlerScript obj, byte[] preallocatedBuffer);
            /*0x2acc6a8*/ DownloadHandlerScript(byte[] preallocatedBuffer);
            /*0x2acc65c*/ void InternalCreateScript(byte[] preallocatedBuffer);
        }

        class DownloadHandlerFile : UnityEngine.Networking.DownloadHandler
        {
            static /*0x2acc758*/ nint Create(UnityEngine.Networking.DownloadHandlerFile obj, string path, bool append);
            /*0x2acc868*/ DownloadHandlerFile(string path);
            /*0x2acc898*/ DownloadHandlerFile(string path, bool append);
            /*0x2acc7ac*/ void InternalCreateVFS(string path, bool append);
            /*0x2acc8cc*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x2acc91c*/ byte[] GetData();
            /*0x2acc96c*/ string GetText();
            /*0x2acc9bc*/ void set_removeFileOnAbort(bool value);
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            /*0x2acca3c*/ UploadHandler();
            /*0x2acca00*/ void Release();
            /*0x2acca44*/ void Finalize();
            /*0x2accae0*/ void Dispose();
            /*0x2accb74*/ byte[] get_data();
            /*0x2accb80*/ string get_contentType();
            /*0x2aca704*/ void set_contentType(string value);
            /*0x2accb8c*/ float get_progress();
            /*0x2accb98*/ byte[] GetData();
            /*0x2accba0*/ string GetContentType();
            /*0x2accc18*/ void SetContentType(string newContentType);
            /*0x2accca0*/ float GetProgress();
            /*0x2accbdc*/ string InternalGetContentType();
            /*0x2accc5c*/ void InternalSetContentType(string newContentType);
            /*0x2acccdc*/ float InternalGetProgress();
        }

        class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_Payload;

            static /*0x2accd18*/ nint Create(UnityEngine.Networking.UploadHandlerRaw self, byte* data, int dataLength);
            /*0x2aca108*/ UploadHandlerRaw(byte[] data);
            /*0x2accd6c*/ UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership);
            /*0x2acce80*/ UploadHandlerRaw(Unity.Collections.NativeArray.ReadOnly<byte> data);
            /*0x2accfbc*/ byte[] GetData();
            /*0x2acd03c*/ void Dispose();
        }

        class CertificateHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x2acd0b4*/ nint Create(UnityEngine.Networking.CertificateHandler obj);
            /*0x2acd12c*/ CertificateHandler();
            /*0x2acd0f0*/ void Release();
            /*0x2acd178*/ void Finalize();
            /*0x2acd20c*/ bool ValidateCertificate(byte[] certificateData);
            /*0x2acd214*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x2ac7f94*/ void Dispose();
        }
    }
}
