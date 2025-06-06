class <Module>
{
}

namespace Mono
{
    class SystemCertificateProvider : Mono.ISystemCertificateProvider
    {
        static /*0x0*/ int initialized;
        static /*0x8*/ Mono.X509PalImpl x509pal;
        static /*0x10*/ object syncRoot;

        static /*0x23b6c8c*/ SystemCertificateProvider();
        static /*0x23b6590*/ Mono.X509PalImpl GetX509Pal();
        static /*0x23b6640*/ void EnsureInitialized();
        /*0x23b6c84*/ SystemCertificateProvider();
        /*0x23b6794*/ Mono.X509PalImpl get_X509Pal();
        /*0x23b67f0*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data, Mono.CertificateImportFlags importFlags);
        /*0x23b6a58*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x23b6a5c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, Mono.CertificateImportFlags importFlags);
        /*0x23b6b68*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Mono.ISystemCertificateProvider.Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
        /*0x23b6b6c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.CertificateImportFlags importFlags);
    }

    class SystemDependencyProvider : Mono.ISystemDependencyProvider
    {
        static /*0x0*/ Mono.SystemDependencyProvider instance;
        static /*0x8*/ object syncRoot;
        /*0x10*/ Mono.SystemCertificateProvider <CertificateProvider>k__BackingField;

        static /*0x23b6f74*/ SystemDependencyProvider();
        static /*0x23b6d04*/ Mono.SystemDependencyProvider get_Instance();
        static /*0x23b6d60*/ void Initialize();
        /*0x23b6eb4*/ SystemDependencyProvider();
        /*0x23b6f4c*/ Mono.ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider();
        /*0x23b6f54*/ Mono.SystemCertificateProvider get_CertificateProvider();
        /*0x23b6f5c*/ Mono.X509PalImpl get_X509Pal();
    }

    class X509Pal
    {
        static /*0x23b6fec*/ Mono.X509PalImpl get_Instance();
    }

    class X509PalImplMono : Mono.X509PalImpl
    {
        /*0x23b65e8*/ X509PalImplMono();
        /*0x23b704c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        /*0x23b7050*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x23b7054*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
    }

    class X509PalImpl
    {
        static /*0x0*/ byte[] signedData;

        static /*0x23b76b8*/ X509PalImpl();
        static /*0x23b7064*/ byte[] PEM(string type, byte[] data);
        static /*0x23b7198*/ byte[] ConvertData(byte[] data);
        /*0x23b705c*/ X509PalImpl();
        System.Security.Cryptography.X509Certificates.X509CertificateImpl Import(byte[] data);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        System.Security.Cryptography.X509Certificates.X509Certificate2Impl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert);
        /*0x23b685c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data);
        /*0x23b6aec*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl ImportFallback(byte[] data, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
        /*0x23b72a4*/ bool get_SupportsLegacyBasicConstraintsExtension();
        /*0x23b72ac*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
    }

    namespace Util
    {
        class MonoPInvokeCallbackAttribute : System.Attribute
        {
            /*0x23b774c*/ MonoPInvokeCallbackAttribute(System.Type t);
        }
    }

    namespace Unity
    {
        class CertHelper
        {
            static /*0x23b7754*/ void AddCertificatesToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x23b792c*/ void AddCertificateToNativeChain(Mono.Unity.UnityTls.unitytls_x509list* nativeCertificateChain, System.Security.Cryptography.X509Certificates.X509Certificate certificate, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class Debug
        {
            static /*0x23b7bd4*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, string context, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x23b7c74*/ void CheckAndThrow(Mono.Unity.UnityTls.unitytls_errorstate errorState, Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, string context, Mono.Security.Interface.AlertDescription defaultAlert);
        }

        class UnityTls
        {
            static /*0x0*/ Mono.Unity.UnityTls.unitytls_interface_struct marshalledInterface;

            static /*0x23b7da0*/ nint GetUnityTlsInterface();
            static /*0x23b7da4*/ bool get_IsSupported();
            static /*0x23b7af0*/ Mono.Unity.UnityTls.unitytls_interface_struct get_NativeInterface();

            enum unitytls_error_code
            {
                UNITYTLS_SUCCESS = 0,
                UNITYTLS_INVALID_ARGUMENT = 1,
                UNITYTLS_INVALID_FORMAT = 2,
                UNITYTLS_INVALID_PASSWORD = 3,
                UNITYTLS_INVALID_STATE = 4,
                UNITYTLS_BUFFER_OVERFLOW = 5,
                UNITYTLS_OUT_OF_MEMORY = 6,
                UNITYTLS_INTERNAL_ERROR = 7,
                UNITYTLS_NOT_SUPPORTED = 8,
                UNITYTLS_ENTROPY_SOURCE_FAILED = 9,
                UNITYTLS_STREAM_CLOSED = 10,
                UNITYTLS_USER_CUSTOM_ERROR_START = 1048576,
                UNITYTLS_USER_WOULD_BLOCK = 1048577,
                UNITYTLS_USER_READ_FAILED = 1048578,
                UNITYTLS_USER_WRITE_FAILED = 1048579,
                UNITYTLS_USER_UNKNOWN_ERROR = 1048580,
                UNITYTLS_USER_CUSTOM_ERROR_END = 2097152,
            }

            struct unitytls_errorstate
            {
                /*0x10*/ uint magic;
                /*0x14*/ Mono.Unity.UnityTls.unitytls_error_code code;
                /*0x18*/ ulong reserved;
            }

            struct unitytls_key
            {
            }

            struct unitytls_key_ref
            {
                /*0x10*/ ulong handle;
            }

            struct unitytls_x509_ref
            {
                /*0x10*/ ulong handle;
            }

            struct unitytls_x509list
            {
            }

            struct unitytls_x509list_ref
            {
                /*0x10*/ ulong handle;
            }

            enum unitytls_x509verify_result
            {
                UNITYTLS_X509VERIFY_SUCCESS = 0,
                UNITYTLS_X509VERIFY_NOT_DONE = 2147483648,
                UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295,
                UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1,
                UNITYTLS_X509VERIFY_FLAG_REVOKED = 2,
                UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4,
                UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304,
                UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608,
                UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728,
            }

            class unitytls_x509verify_callback : System.MulticastDelegate
            {
                /*0x23b7dbc*/ unitytls_x509verify_callback(object object, nint method);
                /*0x23b7e94*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            struct unitytls_tlsctx
            {
            }

            struct unitytls_x509name
            {
            }

            enum unitytls_ciphersuite
            {
                UNITYTLS_CIPHERSUITE_INVALID = 16777215,
            }

            enum unitytls_protocol
            {
                UNITYTLS_PROTOCOL_TLS_1_0 = 0,
                UNITYTLS_PROTOCOL_TLS_1_1 = 1,
                UNITYTLS_PROTOCOL_TLS_1_2 = 2,
                UNITYTLS_PROTOCOL_INVALID = 3,
            }

            struct unitytls_tlsctx_protocolrange
            {
                /*0x10*/ Mono.Unity.UnityTls.unitytls_protocol min;
                /*0x14*/ Mono.Unity.UnityTls.unitytls_protocol max;
            }

            class unitytls_tlsctx_write_callback : System.MulticastDelegate
            {
                /*0x23b7ea8*/ unitytls_tlsctx_write_callback(object object, nint method);
                /*0x23b7f80*/ nint Invoke(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_read_callback : System.MulticastDelegate
            {
                /*0x23b7f94*/ unitytls_tlsctx_read_callback(object object, nint method);
                /*0x23b806c*/ nint Invoke(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_trace_callback : System.MulticastDelegate
            {
                /*0x23b8080*/ unitytls_tlsctx_trace_callback(object object, nint method);
                /*0x23b8158*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, nint traceMessageLen);
            }

            class unitytls_tlsctx_certificate_callback : System.MulticastDelegate
            {
                /*0x23b816c*/ unitytls_tlsctx_certificate_callback(object object, nint method);
                /*0x23b8244*/ void Invoke(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            class unitytls_tlsctx_x509verify_callback : System.MulticastDelegate
            {
                /*0x23b8260*/ unitytls_tlsctx_x509verify_callback(object object, nint method);
                /*0x23b8338*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            }

            struct unitytls_tlsctx_callbacks
            {
                /*0x10*/ Mono.Unity.UnityTls.unitytls_tlsctx_read_callback read;
                /*0x18*/ Mono.Unity.UnityTls.unitytls_tlsctx_write_callback write;
                /*0x20*/ void* data;
            }

            class unitytls_interface_struct
            {
                /*0x10*/ ulong UNITYTLS_INVALID_HANDLE;
                /*0x18*/ Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT;
                /*0x20*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create;
                /*0x28*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error;
                /*0x30*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref;
                /*0x38*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der;
                /*0x40*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem;
                /*0x48*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free;
                /*0x50*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der;
                /*0x58*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref;
                /*0x60*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509;
                /*0x68*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create;
                /*0x70*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append;
                /*0x78*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der;
                /*0x80*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem;
                /*0x88*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free;
                /*0x90*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca;
                /*0x98*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca;
                /*0xa0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server;
                /*0xa8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client;
                /*0xb0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication;
                /*0xb8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback;
                /*0xc0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback;
                /*0xc8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback;
                /*0xd0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites;
                /*0xd8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite;
                /*0xe0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol;
                /*0xe8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake;
                /*0xf0*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read;
                /*0xf8*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write;
                /*0x100*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close;
                /*0x108*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free;
                /*0x110*/ Mono.Unity.UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes;

                /*0x23b834c*/ unitytls_interface_struct();

                class unitytls_errorstate_create_t : System.MulticastDelegate
                {
                    /*0x23b8354*/ unitytls_errorstate_create_t(object object, nint method);
                    /*0x23b8410*/ Mono.Unity.UnityTls.unitytls_errorstate Invoke();
                }

                class unitytls_errorstate_raise_error_t : System.MulticastDelegate
                {
                    /*0x23b8424*/ unitytls_errorstate_raise_error_t(object object, nint method);
                    /*0x23b84fc*/ void Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState, Mono.Unity.UnityTls.unitytls_error_code errorCode);
                }

                class unitytls_key_get_ref_t : System.MulticastDelegate
                {
                    /*0x23b8510*/ unitytls_key_get_ref_t(object object, nint method);
                    /*0x23b85e8*/ Mono.Unity.UnityTls.unitytls_key_ref Invoke(Mono.Unity.UnityTls.unitytls_key* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_der_t : System.MulticastDelegate
                {
                    /*0x23b85fc*/ unitytls_key_parse_der_t(object object, nint method);
                    /*0x23b86d4*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_parse_pem_t : System.MulticastDelegate
                {
                    /*0x23b86e8*/ unitytls_key_parse_pem_t(object object, nint method);
                    /*0x23b87c0*/ Mono.Unity.UnityTls.unitytls_key* Invoke(byte* buffer, nint bufferLen, byte* password, nint passwordLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_key_free_t : System.MulticastDelegate
                {
                    /*0x23b87d4*/ unitytls_key_free_t(object object, nint method);
                    /*0x23b88a8*/ void Invoke(Mono.Unity.UnityTls.unitytls_key* key);
                }

                class unitytls_x509_export_der_t : System.MulticastDelegate
                {
                    /*0x23b88bc*/ unitytls_x509_export_der_t(object object, nint method);
                    /*0x23b8980*/ nint Invoke(Mono.Unity.UnityTls.unitytls_x509_ref cert, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_ref_t : System.MulticastDelegate
                {
                    /*0x23b8994*/ unitytls_x509list_get_ref_t(object object, nint method);
                    /*0x23b8a6c*/ Mono.Unity.UnityTls.unitytls_x509list_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_get_x509_t : System.MulticastDelegate
                {
                    /*0x23b8a80*/ unitytls_x509list_get_x509_t(object object, nint method);
                    /*0x23b8b44*/ Mono.Unity.UnityTls.unitytls_x509_ref Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref list, nint index, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_create_t : System.MulticastDelegate
                {
                    /*0x23b8b58*/ unitytls_x509list_create_t(object object, nint method);
                    /*0x23b8c2c*/ Mono.Unity.UnityTls.unitytls_x509list* Invoke(Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_t : System.MulticastDelegate
                {
                    /*0x23b8c40*/ unitytls_x509list_append_t(object object, nint method);
                    /*0x23b8d18*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_append_der_t : System.MulticastDelegate
                {
                    /*0x23b8d2c*/ unitytls_x509list_append_der_t(object object, nint method);
                    /*0x23b8e04*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509list_free_t : System.MulticastDelegate
                {
                    /*0x23b8e18*/ unitytls_x509list_free_t(object object, nint method);
                    /*0x23b8eec*/ void Invoke(Mono.Unity.UnityTls.unitytls_x509list* list);
                }

                class unitytls_x509verify_default_ca_t : System.MulticastDelegate
                {
                    /*0x23b8f00*/ unitytls_x509verify_default_ca_t(object object, nint method);
                    /*0x23b8fc4*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_x509verify_explicit_ca_t : System.MulticastDelegate
                {
                    /*0x23b8fd8*/ unitytls_x509verify_explicit_ca_t(object object, nint method);
                    /*0x23b909c*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_x509list_ref trustCA, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_server_t : System.MulticastDelegate
                {
                    /*0x23b90b4*/ unitytls_tlsctx_create_server_t(object object, nint method);
                    /*0x23b9178*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_create_client_t : System.MulticastDelegate
                {
                    /*0x23b91b4*/ unitytls_tlsctx_create_client_t(object object, nint method);
                    /*0x23b9278*/ Mono.Unity.UnityTls.unitytls_tlsctx* Invoke(Mono.Unity.UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, Mono.Unity.UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_server_require_client_authentication_t : System.MulticastDelegate
                {
                    /*0x23b92b4*/ unitytls_tlsctx_server_require_client_authentication_t(object object, nint method);
                    /*0x23b938c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_x509list_ref clientAuthCAList, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_certificate_callback_t : System.MulticastDelegate
                {
                    /*0x23b93a0*/ unitytls_tlsctx_set_certificate_callback_t(object object, nint method);
                    /*0x23b9478*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_trace_callback_t : System.MulticastDelegate
                {
                    /*0x23b948c*/ unitytls_tlsctx_set_trace_callback_t(object object, nint method);
                    /*0x23b9564*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_x509verify_callback_t : System.MulticastDelegate
                {
                    /*0x23b9578*/ unitytls_tlsctx_set_x509verify_callback_t(object object, nint method);
                    /*0x23b9650*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_set_supported_ciphersuites_t : System.MulticastDelegate
                {
                    /*0x23b9664*/ unitytls_tlsctx_set_supported_ciphersuites_t(object object, nint method);
                    /*0x23b973c*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_ciphersuite* supportedCiphersuites, nint supportedCiphersuitesLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_ciphersuite_t : System.MulticastDelegate
                {
                    /*0x23b9750*/ unitytls_tlsctx_get_ciphersuite_t(object object, nint method);
                    /*0x23b9828*/ Mono.Unity.UnityTls.unitytls_ciphersuite Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_get_protocol_t : System.MulticastDelegate
                {
                    /*0x23b983c*/ unitytls_tlsctx_get_protocol_t(object object, nint method);
                    /*0x23b9914*/ Mono.Unity.UnityTls.unitytls_protocol Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_process_handshake_t : System.MulticastDelegate
                {
                    /*0x23b9928*/ unitytls_tlsctx_process_handshake_t(object object, nint method);
                    /*0x23b9a00*/ Mono.Unity.UnityTls.unitytls_x509verify_result Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_read_t : System.MulticastDelegate
                {
                    /*0x23b9a14*/ unitytls_tlsctx_read_t(object object, nint method);
                    /*0x23b9aec*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_write_t : System.MulticastDelegate
                {
                    /*0x23b9b00*/ unitytls_tlsctx_write_t(object object, nint method);
                    /*0x23b9bd8*/ nint Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_notify_close_t : System.MulticastDelegate
                {
                    /*0x23b9bec*/ unitytls_tlsctx_notify_close_t(object object, nint method);
                    /*0x23b9cc4*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }

                class unitytls_tlsctx_free_t : System.MulticastDelegate
                {
                    /*0x23b9cd8*/ unitytls_tlsctx_free_t(object object, nint method);
                    /*0x23b9dac*/ void Invoke(Mono.Unity.UnityTls.unitytls_tlsctx* ctx);
                }

                class unitytls_random_generate_bytes_t : System.MulticastDelegate
                {
                    /*0x23b9dc0*/ unitytls_random_generate_bytes_t(object object, nint method);
                    /*0x23b9e98*/ void Invoke(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
                }
            }
        }

        class UnityTlsContext : Mono.Net.Security.MobileTlsContext
        {
            /*0x58*/ Mono.Unity.UnityTls.unitytls_tlsctx* tlsContext;
            /*0x60*/ Mono.Unity.UnityTls.unitytls_x509list* requestedClientCertChain;
            /*0x68*/ Mono.Unity.UnityTls.unitytls_key* requestedClientKey;
            /*0x70*/ Mono.Unity.UnityTls.unitytls_tlsctx_read_callback readCallback;
            /*0x78*/ Mono.Unity.UnityTls.unitytls_tlsctx_write_callback writeCallback;
            /*0x80*/ Mono.Unity.UnityTls.unitytls_tlsctx_certificate_callback certificateCallback;
            /*0x88*/ Mono.Unity.UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback;
            /*0x90*/ System.Security.Cryptography.X509Certificates.X509Certificate localClientCertificate;
            /*0x98*/ System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate;
            /*0xa0*/ Mono.Security.Interface.MonoTlsConnectionInfo connectioninfo;
            /*0xa8*/ bool isAuthenticated;
            /*0xa9*/ bool hasContext;
            /*0xaa*/ bool closedGraceful;
            /*0xb0*/ byte[] writeBuffer;
            /*0xb8*/ byte[] readBuffer;
            /*0xc0*/ System.Runtime.InteropServices.GCHandle handle;
            /*0xc8*/ System.Exception lastException;

            static /*0x23baa68*/ void ExtractNativeKeyAndChainFromManagedCertificate(System.Security.Cryptography.X509Certificates.X509Certificate cert, Mono.Unity.UnityTls.unitytls_errorstate* errorState, ref Mono.Unity.UnityTls.unitytls_x509list* nativeCertChain, ref Mono.Unity.UnityTls.unitytls_key* nativeKey);
            static /*0x23b9eac*/ nint WriteCallback(void* userData, byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x23b9f74*/ nint ReadCallback(void* userData, byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x23ba03c*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            static /*0x23ba0ec*/ void CertificateCallback(void* userData, Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x23ba1b4*/ UnityTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
            /*0x23bada8*/ bool get_IsAuthenticated();
            /*0x23badb0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
            /*0x23badb8*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
            /*0x23badc0*/ System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
            /*0x23baf68*/ System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
            /*0x23bb108*/ void Renegotiate();
            /*0x23bb148*/ bool PendingRenegotiation();
            /*0x23bb150*/ void Shutdown();
            /*0x23bb264*/ void Dispose(bool disposing);
            /*0x23bb2dc*/ void StartHandshake();
            /*0x23bb45c*/ bool ProcessHandshake();
            /*0x23bb620*/ void FinishHandshake();
            /*0x23bb768*/ nint WriteCallback(byte* data, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x23bbbb8*/ nint ReadCallback(byte* buffer, nint bufferLen, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x23bbfbc*/ Mono.Unity.UnityTls.unitytls_x509verify_result VerifyCallback(Mono.Unity.UnityTls.unitytls_x509list_ref chain, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x23bc44c*/ void CertificateCallback(Mono.Unity.UnityTls.unitytls_tlsctx* ctx, byte* cn, nint cnLen, Mono.Unity.UnityTls.unitytls_x509name* caList, nint caListLen, Mono.Unity.UnityTls.unitytls_x509list_ref* chain, Mono.Unity.UnityTls.unitytls_key_ref* key, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
        }

        class UnityTlsConversions
        {
            static /*0x23ba9f8*/ Mono.Unity.UnityTls.unitytls_protocol GetMinProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x23baa30*/ Mono.Unity.UnityTls.unitytls_protocol GetMaxProtocol(System.Security.Authentication.SslProtocols protocols);
            static /*0x23bb748*/ Mono.Security.Interface.TlsProtocols ConvertProtocolVersion(Mono.Unity.UnityTls.unitytls_protocol protocol);
            static /*0x23b7d4c*/ Mono.Security.Interface.AlertDescription VerifyResultToAlertDescription(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult, Mono.Security.Interface.AlertDescription defaultAlert);
            static /*0x23bcc1c*/ System.Net.Security.SslPolicyErrors VerifyResultToPolicyErrror(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
            static /*0x23bcc4c*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags VerifyResultToChainStatus(Mono.Unity.UnityTls.unitytls_x509verify_result verifyResult);
        }

        class UnityTlsProvider : Mono.Net.Security.MobileTlsProvider
        {
            static /*0x23bcc8c*/ Mono.Unity.UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, Mono.Unity.UnityTls.unitytls_x509_ref cert, Mono.Unity.UnityTls.unitytls_x509verify_result result, Mono.Unity.UnityTls.unitytls_errorstate* errorState);
            /*0x23bd84c*/ UnityTlsProvider();
            /*0x23bccf0*/ string get_Name();
            /*0x23bcd30*/ System.Guid get_ID();
            /*0x23bcd88*/ bool get_SupportsSslStream();
            /*0x23bcd90*/ bool get_SupportsMonoExtensions();
            /*0x23bcd98*/ bool get_SupportsConnectionInfo();
            /*0x23bcda0*/ bool get_SupportsCleanShutdown();
            /*0x23bcda8*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
            /*0x23bcdb0*/ Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x23bced4*/ bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
        }

        class UnityTlsStream : Mono.Net.Security.MobileAuthenticatedStream
        {
            /*0x23bce40*/ UnityTlsStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
            /*0x23bd990*/ Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
        }

        class X509ChainImplUnityTls : System.Security.Cryptography.X509Certificates.X509ChainImpl
        {
            /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
            /*0x18*/ Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain;
            /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
            /*0x28*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList;
            /*0x30*/ bool reverseOrder;

            /*0x23bc3c4*/ X509ChainImplUnityTls(Mono.Unity.UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder);
            /*0x23bda00*/ bool get_IsValid();
            /*0x23bda28*/ nint get_Handle();
            /*0x23bda4c*/ Mono.Unity.UnityTls.unitytls_x509list_ref get_NativeCertificateChain();
            /*0x23bda54*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
            /*0x23bdd30*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
            /*0x23bde3c*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
            /*0x23bde44*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
            /*0x23bde4c*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainStatus();
            /*0x23bdec8*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
            /*0x23bded0*/ void Reset();
            /*0x23bdf10*/ void Dispose(bool disposing);
        }
    }

    namespace Net
    {
        namespace Security
        {
            class BufferOffsetSize
            {
                /*0x10*/ byte[] Buffer;
                /*0x18*/ int Offset;
                /*0x1c*/ int Size;
                /*0x20*/ int TotalBytes;
                /*0x24*/ bool Complete;

                /*0x23bdf80*/ BufferOffsetSize(byte[] buffer, int offset, int size);
                /*0x23bdf4c*/ int get_EndOffset();
                /*0x23bdf58*/ int get_Remaining();
                /*0x23be084*/ string ToString();
            }

            class BufferOffsetSize2 : Mono.Net.Security.BufferOffsetSize
            {
                /*0x28*/ int InitialSize;

                /*0x23be124*/ BufferOffsetSize2(int size);
                /*0x23be194*/ void Reset();
                /*0x23be1f0*/ void MakeRoom(int size);
                /*0x23be2a4*/ void AppendData(byte[] buffer, int offset, int size);
            }

            enum AsyncOperationStatus
            {
                Initialize = 0,
                Continue = 1,
                ReadDone = 2,
                Complete = 3,
            }

            class AsyncProtocolResult
            {
                /*0x10*/ int <UserResult>k__BackingField;
                /*0x18*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;

                /*0x23be314*/ AsyncProtocolResult(int result);
                /*0x23be33c*/ AsyncProtocolResult(System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                /*0x23be304*/ int get_UserResult();
                /*0x23be30c*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
            }

            class AsyncProtocolRequest
            {
                /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;
                /*0x18*/ bool <RunSynchronously>k__BackingField;
                /*0x1c*/ int <UserResult>k__BackingField;
                /*0x20*/ int Started;
                /*0x24*/ int RequestedSize;
                /*0x28*/ int WriteRequested;
                /*0x30*/ object locker;

                /*0x23be3ac*/ AsyncProtocolRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x23be364*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x23be36c*/ bool get_RunSynchronously();
                /*0x23be374*/ string get_Name();
                /*0x23be39c*/ int get_UserResult();
                /*0x23be3a4*/ void set_UserResult(int value);
                /*0x23be434*/ void RequestRead(int size);
                /*0x23be4f8*/ void RequestWrite();
                /*0x23be504*/ System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(System.Threading.CancellationToken cancellationToken);
                /*0x23be5fc*/ System.Threading.Tasks.Task ProcessOperation(System.Threading.CancellationToken cancellationToken);
                /*0x23be6dc*/ System.Threading.Tasks.Task<System.Nullable<int>> InnerRead(System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
                /*0x23be7e0*/ string ToString();

                struct <StartOperation>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x23be838*/ void MoveNext();
                    /*0x23bebd0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessOperation>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x40*/ Mono.Net.Security.AsyncOperationStatus <status>5__2;
                    /*0x44*/ Mono.Net.Security.AsyncOperationStatus <newStatus>5__3;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Nullable<int>> <>u__1;
                    /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    /*0x23bec28*/ void MoveNext();
                    /*0x23bf334*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerRead>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<int>> <>t__builder;
                    /*0x30*/ Mono.Net.Security.AsyncProtocolRequest <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Nullable<int> <totalRead>5__2;
                    /*0x48*/ int <requestedSize>5__3;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0x23bf340*/ void MoveNext();
                    /*0x23bf7ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AsyncHandshakeRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x23bf804*/ AsyncHandshakeRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync);
                /*0x23bf80c*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncReadOrWriteRequest : Mono.Net.Security.AsyncProtocolRequest
            {
                /*0x38*/ Mono.Net.Security.BufferOffsetSize <UserBuffer>k__BackingField;
                /*0x40*/ int <CurrentSize>k__BackingField;

                /*0x23bfc18*/ AsyncReadOrWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x23bfc00*/ Mono.Net.Security.BufferOffsetSize get_UserBuffer();
                /*0x23bfc08*/ int get_CurrentSize();
                /*0x23bfc10*/ void set_CurrentSize(int value);
                /*0x23bfcbc*/ string ToString();
            }

            class AsyncReadRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x23bfd18*/ AsyncReadRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x23bfd20*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class AsyncWriteRequest : Mono.Net.Security.AsyncReadOrWriteRequest
            {
                /*0x23bfee8*/ AsyncWriteRequest(Mono.Net.Security.MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size);
                /*0x23bfef0*/ Mono.Net.Security.AsyncOperationStatus Run(Mono.Net.Security.AsyncOperationStatus status);
            }

            class ChainValidationHelper : Mono.Security.Interface.ICertificateValidator
            {
                /*0x10*/ System.WeakReference<System.Net.Security.SslStream> owner;
                /*0x18*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x20*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x28*/ System.Net.ServerCertValidationCallback certValidationCallback;
                /*0x30*/ System.Net.Security.LocalCertSelectionCallback certSelectionCallback;
                /*0x38*/ Mono.Net.Security.MonoTlsStream tlsStream;
                /*0x40*/ System.Net.HttpWebRequest request;

                static /*0x23c00c8*/ Mono.Net.Security.ChainValidationHelper GetInternalValidator(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x23c041c*/ Mono.Net.Security.ChainValidationHelper Create(Mono.Net.Security.MobileTlsProvider provider, ref Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MonoTlsStream stream);
                static /*0x23c05c4*/ System.Net.ServerCertValidationCallback GetValidationCallback(Mono.Security.Interface.MonoTlsSettings settings);
                static /*0x23c076c*/ System.Security.Cryptography.X509Certificates.X509Certificate DefaultSelectionCallback(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x23c01a8*/ ChainValidationHelper(System.Net.Security.SslStream owner, Mono.Net.Security.MobileTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings, bool cloneSettings, Mono.Net.Security.MonoTlsStream stream);
                /*0x23c07a8*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x23c07b0*/ bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
                /*0x23c07ec*/ Mono.Security.Interface.ValidationResult ValidateCertificate(string host, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x23c08c0*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x23c099c*/ Mono.Security.Interface.ValidationResult ValidateChain(string host, bool server, System.Security.Cryptography.X509Certificates.X509Certificate leaf, ref System.Security.Cryptography.X509Certificates.X509Chain chain, System.Security.Cryptography.X509Certificates.X509CertificateCollection certs, System.Net.Security.SslPolicyErrors errors);
                /*0x23c0dac*/ bool InvokeCallback(System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors);

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Mono.Security.Interface.MonoTlsSettings settings;

                    /*0x23c0764*/ <>c__DisplayClass11_0();
                    /*0x23c0e68*/ bool <GetValidationCallback>b__0(object s, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, System.Net.Security.SslPolicyErrors e);
                }
            }

            class MobileAuthenticatedStream : System.Net.Security.AuthenticatedStream, System.IDisposable
            {
                static /*0x0*/ int uniqueNameInteger;
                static /*0x4*/ int nextId;
                /*0x38*/ Mono.Net.Security.MobileTlsContext xobileTlsContext;
                /*0x40*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo lastException;
                /*0x48*/ Mono.Net.Security.AsyncProtocolRequest asyncHandshakeRequest;
                /*0x50*/ Mono.Net.Security.AsyncProtocolRequest asyncReadRequest;
                /*0x58*/ Mono.Net.Security.AsyncProtocolRequest asyncWriteRequest;
                /*0x60*/ Mono.Net.Security.BufferOffsetSize2 readBuffer;
                /*0x68*/ Mono.Net.Security.BufferOffsetSize2 writeBuffer;
                /*0x70*/ object ioLock;
                /*0x78*/ int closeRequested;
                /*0x7c*/ bool shutdown;
                /*0x80*/ Mono.Net.Security.MobileAuthenticatedStream.Operation operation;
                /*0x88*/ System.Net.Security.SslStream <SslStream>k__BackingField;
                /*0x90*/ Mono.Security.Interface.MonoTlsSettings <Settings>k__BackingField;
                /*0x98*/ Mono.Net.Security.MobileTlsProvider <Provider>k__BackingField;
                /*0xa0*/ string <TargetHost>k__BackingField;
                /*0xa8*/ int ID;

                static /*0x23c253c*/ MobileAuthenticatedStream();
                static /*0x23bf0bc*/ System.Exception GetSSPIException(System.Exception e);
                static /*0x23c10b8*/ System.Exception GetIOException(System.Exception e, string message);
                static /*0x23c123c*/ System.Exception GetInternalError();
                static /*0x23c128c*/ System.Exception GetInvalidNestedCallException();
                /*0x23bd85c*/ MobileAuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.SslStream owner, Mono.Security.Interface.MonoTlsSettings settings, Mono.Net.Security.MobileTlsProvider provider);
                /*0x23c0fc8*/ System.Net.Security.SslStream get_SslStream();
                /*0x23c0fd0*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                /*0x23c0fd8*/ Mono.Net.Security.MobileTlsProvider get_Provider();
                /*0x23c0fe0*/ string get_TargetHost();
                /*0x23c0fe8*/ void set_TargetHost(string value);
                /*0x23c0ff0*/ void CheckThrow(bool authSuccessCheck, bool shutdownCheck);
                /*0x23beb90*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo SetException(System.Exception e);
                /*0x23c12dc*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x23c1614*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x23c1520*/ System.Threading.Tasks.Task ProcessAuthentication(bool runSynchronously, Mono.Net.Security.MonoSslAuthenticationOptions options, System.Threading.CancellationToken cancellationToken);
                Mono.Net.Security.MobileTlsContext CreateContext(Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x23c1730*/ int Read(byte[] buffer, int offset, int count);
                /*0x23c1930*/ void Write(byte[] buffer, int offset, int count);
                /*0x23c1a00*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x23c1a9c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x23c1814*/ System.Threading.Tasks.Task<int> StartOperation(Mono.Net.Security.MobileAuthenticatedStream.OperationType type, Mono.Net.Security.AsyncProtocolRequest asyncRequest, System.Threading.CancellationToken cancellationToken);
                /*0x23bbeb0*/ int InternalRead(byte[] buffer, int offset, int size, ref bool outWantMore);
                /*0x23c1b38*/ System.ValueTuple<int, bool> InternalRead(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size);
                /*0x23bb9c8*/ bool InternalWrite(byte[] buffer, int offset, int size);
                /*0x23c1cb8*/ bool InternalWrite(Mono.Net.Security.AsyncProtocolRequest asyncRequest, Mono.Net.Security.BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size);
                /*0x23bf690*/ System.Threading.Tasks.Task<int> InnerRead(bool sync, int requestedSize, System.Threading.CancellationToken cancellationToken);
                /*0x23bf250*/ System.Threading.Tasks.Task InnerWrite(bool sync, System.Threading.CancellationToken cancellationToken);
                /*0x23bf828*/ Mono.Net.Security.AsyncOperationStatus ProcessHandshake(Mono.Net.Security.AsyncOperationStatus status, bool renegotiate);
                /*0x23bfd88*/ System.ValueTuple<int, bool> ProcessRead(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x23bff68*/ System.ValueTuple<int, bool> ProcessWrite(Mono.Net.Security.BufferOffsetSize userBuffer);
                /*0x23c1db4*/ bool get_IsAuthenticated();
                /*0x23c1e9c*/ void Dispose(bool disposing);
                /*0x23c20f0*/ void Flush();
                /*0x23c2114*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x23c21f0*/ System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
                /*0x23c22f0*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x23c2330*/ void SetLength(long value);
                /*0x23c2354*/ bool get_CanRead();
                /*0x23c2398*/ bool get_CanTimeout();
                /*0x23c23b8*/ bool get_CanWrite();
                /*0x23c241c*/ bool get_CanSeek();
                /*0x23c2424*/ long get_Length();
                /*0x23c2448*/ long get_Position();
                /*0x23c246c*/ void set_Position(long value);
                /*0x23c24ac*/ int get_ReadTimeout();
                /*0x23c24d0*/ void set_ReadTimeout(int value);
                /*0x23c24f4*/ int get_WriteTimeout();
                /*0x23c2518*/ void set_WriteTimeout(int value);
                /*0x23c2588*/ void <InnerWrite>b__67_0();

                enum Operation
                {
                    None = 0,
                    Handshake = 1,
                    Authenticated = 2,
                    Renegotiate = 3,
                    Read = 4,
                    Write = 5,
                    Close = 6,
                }

                enum OperationType
                {
                    Read = 0,
                    Write = 1,
                    Renegotiate = 2,
                    Shutdown = 3,
                }

                struct <ProcessAuthentication>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoSslAuthenticationOptions options;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool runSynchronously;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0x23c25bc*/ void MoveNext();
                    /*0x23c2ec0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StartOperation>d__57 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream.OperationType type;
                    /*0x40*/ Mono.Net.Security.AsyncProtocolRequest asyncRequest;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Mono.Net.Security.AsyncProtocolResult> <>u__1;

                    /*0x23c2ecc*/ void MoveNext();
                    /*0x23c3624*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass66_0
                {
                    /*0x10*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x18*/ int len;

                    /*0x23c367c*/ <>c__DisplayClass66_0();
                    /*0x23c3684*/ int <InnerRead>b__0();
                }

                struct <InnerRead>d__66 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ int requestedSize;
                    /*0x44*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                    /*0x23c36cc*/ void MoveNext();
                    /*0x23c3b10*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InnerWrite>d__67 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ Mono.Net.Security.MobileAuthenticatedStream <>4__this;
                    /*0x40*/ bool sync;
                    /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x23c3b68*/ void MoveNext();
                    /*0x23c3df8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class MobileTlsContext : System.IDisposable
            {
                /*0x10*/ Mono.Net.Security.ChainValidationHelper certificateValidator;
                /*0x18*/ Mono.Net.Security.MonoSslAuthenticationOptions <Options>k__BackingField;
                /*0x20*/ Mono.Net.Security.MobileAuthenticatedStream <Parent>k__BackingField;
                /*0x28*/ bool <IsServer>k__BackingField;
                /*0x30*/ string <TargetHost>k__BackingField;
                /*0x38*/ string <ServerName>k__BackingField;
                /*0x40*/ bool <AskForClientCertificate>k__BackingField;
                /*0x44*/ System.Security.Authentication.SslProtocols <EnabledProtocols>k__BackingField;
                /*0x48*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;
                /*0x50*/ System.Security.Cryptography.X509Certificates.X509Certificate <LocalServerCertificate>k__BackingField;

                /*0x23ba8bc*/ MobileTlsContext(Mono.Net.Security.MobileAuthenticatedStream parent, Mono.Net.Security.MonoSslAuthenticationOptions options);
                /*0x23c3e04*/ Mono.Net.Security.MobileAuthenticatedStream get_Parent();
                /*0x23bb248*/ Mono.Security.Interface.MonoTlsSettings get_Settings();
                bool get_IsAuthenticated();
                /*0x23c3e0c*/ bool get_IsServer();
                /*0x23c3e14*/ string get_TargetHost();
                /*0x23c3e1c*/ string get_ServerName();
                /*0x23c3e24*/ bool get_AskForClientCertificate();
                /*0x23c3e2c*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                void StartHandshake();
                bool ProcessHandshake();
                void FinishHandshake();
                /*0x23c3e34*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalServerCertificate();
                /*0x23c3e3c*/ void set_LocalServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate value);
                System.Security.Cryptography.X509Certificates.X509Certificate get_LocalClientCertificate();
                System.Security.Cryptography.X509Certificates.X509Certificate2 get_RemoteCertificate();
                System.ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);
                System.ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);
                void Shutdown();
                bool PendingRenegotiation();
                /*0x23bb5d0*/ bool ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
                /*0x23bc718*/ System.Security.Cryptography.X509Certificates.X509Certificate SelectClientCertificate(string[] acceptableIssuers);
                void Renegotiate();
                /*0x23c2080*/ void Dispose();
                /*0x23c3e44*/ void Dispose(bool disposing);
                /*0x23c3e48*/ void Finalize();
            }

            class MobileTlsProvider : Mono.Security.Interface.MonoTlsProvider
            {
                /*0x23bd854*/ MobileTlsProvider();
                Mono.Net.Security.MobileAuthenticatedStream CreateSslStream(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Net.Security.ChainValidationHelper validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref System.Net.Security.SslPolicyErrors errors, ref int status11);
            }

            class MonoSslAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;

                /*0x23c3ef4*/ MonoSslAuthenticationOptions();
                bool get_ServerMode();
                System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                string get_TargetHost();
                void set_TargetHost(string value);
                System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
                System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                bool get_ClientCertificateRequired();
                /*0x23c3eec*/ System.Net.Security.ServerCertSelectionCallback get_ServerCertSelectionDelegate();
            }

            class MonoSslClientAuthenticationOptions : Mono.Net.Security.MonoSslAuthenticationOptions
            {
                /*0x18*/ System.Net.Security.SslClientAuthenticationOptions <Options>k__BackingField;

                /*0x23c14b4*/ MonoSslClientAuthenticationOptions();
                /*0x23c3efc*/ System.Net.Security.SslClientAuthenticationOptions get_Options();
                /*0x23c3f04*/ bool get_ServerMode();
                /*0x23c3f0c*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x23c3f28*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x23c3f44*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x23c3f60*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
                /*0x23c3f7c*/ string get_TargetHost();
                /*0x23c3f98*/ void set_TargetHost(string value);
                /*0x23c3fb4*/ bool get_ClientCertificateRequired();
                /*0x23c3ff4*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x23c4010*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x23c402c*/ System.Security.Cryptography.X509Certificates.X509Certificate get_ServerCertificate();
            }

            class MonoTlsProviderFactory
            {
                static /*0x0*/ object locker;
                static /*0x8*/ bool initialized;
                static /*0x10*/ Mono.Net.Security.MobileTlsProvider defaultProvider;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, System.Tuple<System.Guid, string>> providerRegistration;
                static /*0x20*/ System.Collections.Generic.Dictionary<System.Guid, Mono.Net.Security.MobileTlsProvider> providerCache;
                static /*0x28*/ System.Guid UnityTlsId;
                static /*0x38*/ System.Guid AppleTlsId;
                static /*0x48*/ System.Guid BtlsId;

                static /*0x23c4f24*/ MonoTlsProviderFactory();
                static /*0x23c04a8*/ Mono.Net.Security.MobileTlsProvider GetProviderInternal();
                static /*0x23c406c*/ void InitializeInternal();
                static /*0x23c47b8*/ Mono.Net.Security.MobileTlsProvider LookupProvider(string name, bool throwOnError);
                static /*0x23c4418*/ void InitializeProviderRegistration();
                static /*0x23c4d4c*/ void PopulateUnityProviders();
                static /*0x23c4e88*/ void PopulateProviders();
                static /*0x23c4624*/ Mono.Net.Security.MobileTlsProvider CreateDefaultProviderImpl();
                static /*0x23c4ed8*/ Mono.Net.Security.MobileTlsProvider GetProvider();
            }

            class MonoTlsStream : System.IDisposable
            {
                /*0x10*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x18*/ System.Net.Sockets.NetworkStream networkStream;
                /*0x20*/ System.Net.HttpWebRequest request;
                /*0x28*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x30*/ System.Net.Security.SslStream sslStream;
                /*0x38*/ object sslStreamLock;
                /*0x40*/ System.Net.WebExceptionStatus status;
                /*0x44*/ bool <CertificateValidationFailed>k__BackingField;

                /*0x23c5078*/ MonoTlsStream(System.Net.HttpWebRequest request, System.Net.Sockets.NetworkStream networkStream);
                /*0x23c5054*/ System.Net.HttpWebRequest get_Request();
                /*0x23c505c*/ System.Net.WebExceptionStatus get_ExceptionStatus();
                /*0x23c5064*/ bool get_CertificateValidationFailed();
                /*0x23c506c*/ void set_CertificateValidationFailed(bool value);
                /*0x23c514c*/ System.Threading.Tasks.Task<System.IO.Stream> CreateStream(System.Net.WebConnectionTunnel tunnel, System.Threading.CancellationToken cancellationToken);
                /*0x23c5250*/ void Dispose();
                /*0x23c5254*/ void CloseSslStream();

                struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                    /*0x30*/ Mono.Net.Security.MonoTlsStream <>4__this;
                    /*0x38*/ System.Net.WebConnectionTunnel tunnel;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ System.Net.Sockets.Socket <socket>5__2;
                    /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                    /*0x23c5328*/ void MoveNext();
                    /*0x23c59cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NoReflectionHelper
            {
                static /*0x23c5a24*/ object GetProvider();
            }

            class SystemCertificateValidator
            {
                static /*0x0*/ bool is_macosx;
                static /*0x4*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags s_flags;

                static /*0x23c5a70*/ SystemCertificateValidator();
                static /*0x23c0e60*/ bool NeedsChain(Mono.Security.Interface.MonoTlsSettings settings);
            }

            namespace Private
            {
                class CallbackHelpers
                {
                    static /*0x23c5ac0*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback PublicToMono(System.Net.Security.RemoteCertificateValidationCallback callback);
                    static /*0x23c06b4*/ System.Net.Security.LocalCertSelectionCallback MonoToInternal(Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback callback;

                        /*0x23c5b70*/ <>c__DisplayClass0_0();
                        /*0x23c5b80*/ bool <PublicToMono>b__0(string h, System.Security.Cryptography.X509Certificates.X509Certificate c, System.Security.Cryptography.X509Certificates.X509Chain ch, Mono.Security.Interface.MonoSslPolicyErrors e);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback callback;

                        /*0x23c5b78*/ <>c__DisplayClass6_0();
                        /*0x23c5ba4*/ System.Security.Cryptography.X509Certificates.X509Certificate <MonoToInternal>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
                    }
                }
            }
        }
    }

    namespace Http
    {
        class NtlmSession
        {
            /*0x10*/ Mono.Security.Protocol.Ntlm.MessageBase message;

            /*0x23c5bc8*/ NtlmSession();
            /*0x23c5bd0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession> cache;

            static /*0x23c6434*/ NtlmClient();
            /*0x23c642c*/ NtlmClient();
            /*0x23c6060*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x23c63e4*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x23c63ec*/ string get_AuthenticationType();

            class <>c
            {
                static /*0x0*/ Mono.Http.NtlmClient.<> <>9;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<System.Net.HttpWebRequest, Mono.Http.NtlmSession> <>9__1_0;

                static /*0x23c64c0*/ <>c();
                /*0x23c6524*/ <>c();
                /*0x23c652c*/ Mono.Http.NtlmSession <Authenticate>b__1_0(System.Net.HttpWebRequest x);
            }
        }
    }
}

namespace Internal
{
    namespace Cryptography
    {
        class OidLookup
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;
            static /*0x10*/ System.Collections.Generic.Dictionary<string, string> s_friendlyNameToOid;
            static /*0x18*/ System.Collections.Generic.Dictionary<string, string> s_oidToFriendlyName;
            static /*0x20*/ System.Collections.Generic.Dictionary<string, string> s_compatOids;

            static /*0x23c6fa0*/ OidLookup();
            static /*0x23c6588*/ string ToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x23c6aa8*/ string ToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x23c6768*/ bool ShouldUseCache(System.Security.Cryptography.OidGroup oidGroup);
            static /*0x23c6770*/ string NativeOidToFriendlyName(string oid, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);
            static /*0x23c6c5c*/ string NativeFriendlyNameToOid(string friendlyName, System.Security.Cryptography.OidGroup oidGroup, bool fallBackToAllGroups);

            class <>c
            {
                static /*0x0*/ Internal.Cryptography.OidLookup.<> <>9;

                static /*0x23c8c60*/ <>c();
                /*0x23c8cc4*/ <>c();
                /*0x23c8ccc*/ string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<string, string> kvp);
                /*0x23c8d08*/ string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<string, string> kvp);
            }
        }

        namespace Pal
        {
            enum GeneralNameType
            {
                OtherName = 0,
                Rfc822Name = 1,
                Email = 1,
                DnsName = 2,
                X400Address = 3,
                DirectoryName = 4,
                EdiPartyName = 5,
                UniformResourceIdentifier = 6,
                IPAddress = 7,
                RegisteredId = 8,
            }

            struct CertificateData
            {
                /*0x10*/ byte[] RawData;
                /*0x18*/ byte[] SubjectPublicKeyInfo;
                /*0x20*/ int Version;
                /*0x28*/ byte[] SerialNumber;
                /*0x30*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier TbsSignature;
                /*0x40*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName Issuer;
                /*0x48*/ System.DateTime NotBefore;
                /*0x50*/ System.DateTime NotAfter;
                /*0x58*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName Subject;
                /*0x60*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;
                /*0x70*/ byte[] PublicKey;
                /*0x78*/ byte[] IssuerUniqueId;
                /*0x80*/ byte[] SubjectUniqueId;
                /*0x88*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Extension> Extensions;
                /*0x90*/ Internal.Cryptography.Pal.CertificateData.AlgorithmIdentifier SignatureAlgorithm;
                /*0xa0*/ byte[] SignatureValue;

                static /*0x23c9a9c*/ string GetSimpleNameInfo(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                static /*0x23c9ef8*/ string FindAltNameMatch(byte[] extensionBytes, Internal.Cryptography.Pal.GeneralNameType matchType, string otherOid);
                static /*0x23ca0bc*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> ReadReverseRdns(System.Security.Cryptography.X509Certificates.X500DistinguishedName name);
                /*0x23c8d44*/ CertificateData(byte[] rawData);
                /*0x23c945c*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);

                struct AlgorithmIdentifier
                {
                    /*0x10*/ string AlgorithmId;
                    /*0x18*/ byte[] Parameters;
                }

                class <ReadReverseRdns>d__21 : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<string, string> <>2__current;
                    /*0x28*/ int <>l__initialThreadId;
                    /*0x30*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName name;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName <>3__name;
                    /*0x40*/ System.Collections.Generic.Stack<System.Security.Cryptography.DerSequenceReader> <rdnReaders>5__2;
                    /*0x48*/ System.Security.Cryptography.DerSequenceReader <rdnReader>5__3;

                    /*0x23ca134*/ <ReadReverseRdns>d__21(int <>1__state);
                    /*0x23ca168*/ void System.IDisposable.Dispose();
                    /*0x23ca16c*/ bool MoveNext();
                    /*0x23ca400*/ System.Collections.Generic.KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current();
                    /*0x23ca40c*/ void System.Collections.IEnumerator.Reset();
                    /*0x23ca44c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x23ca4a8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator();
                    /*0x23ca54c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }
        }
    }
}

namespace Microsoft
{
    namespace Win32
    {
        namespace SafeHandles
        {
            class SafeX509ChainHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                /*0x23ca550*/ bool ReleaseHandle();
            }
        }
    }
}

namespace System
{
    class IPv4AddressHelper
    {
        static /*0x23ca590*/ int ParseHostNumber(System.ReadOnlySpan<char> str, int start, int end);
        static /*0x23ca64c*/ bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme);
        static /*0x23ca5c0*/ bool ParseCanonical(System.ReadOnlySpan<char> name, byte* numbers, int start, int end);
        static /*0x23ca67c*/ bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile);
        static /*0x23ca7bc*/ long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile);
        static /*0x23caab0*/ string ParseCanonicalName(string str, int start, int end, ref bool isLoopback);
        static /*0x23cacd8*/ bool Parse(string name, byte* numbers, int start, int end);
    }

    class IPv6AddressHelper
    {
        static /*0x23e0bd0*/ System.ValueTuple<int, int> FindCompressionRange(System.ReadOnlySpan<ushort> numbers);
        static /*0x23e0cb0*/ bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<ushort> numbers);
        static /*0x23e0d80*/ bool IsValidStrict(char* name, int start, ref int end);
        static /*0x23e10c4*/ void Parse(System.ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId);
        static /*0x23e15d0*/ string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId);
        static /*0x23e1c0c*/ bool IsLoopback(System.ReadOnlySpan<ushort> numbers);
        static /*0x23e1cec*/ bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress);
        static /*0x23e1fc8*/ bool IsValid(char* name, int start, ref int end);
    }

    class NotImplemented
    {
        static /*0x23e1fd0*/ System.Exception ByDesignWithMessage(string message);
    }

    class UriBuilder
    {
        /*0x10*/ bool _changed;
        /*0x18*/ string _fragment;
        /*0x20*/ string _host;
        /*0x28*/ string _password;
        /*0x30*/ string _path;
        /*0x38*/ int _port;
        /*0x40*/ string _query;
        /*0x48*/ string _scheme;
        /*0x50*/ string _schemeDelimiter;
        /*0x58*/ System.Uri _uri;
        /*0x60*/ string _username;

        /*0x23e2034*/ UriBuilder(System.Uri uri);
        /*0x23e21a8*/ void Init(System.Uri uri);
        /*0x23e2480*/ void set_Path(string value);
        /*0x23e2534*/ System.Uri get_Uri();
        /*0x23e25cc*/ bool Equals(object rparam);
        /*0x23e2628*/ int GetHashCode();
        /*0x23e231c*/ void SetFieldsFromUri(System.Uri uri);
        /*0x23e2648*/ string ToString();
    }

    class IriHelper
    {
        static /*0x23e2c10*/ bool CheckIriUnicodeRange(char unicode, bool isQuery);
        static /*0x23e2c68*/ bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery);
        static /*0x23e3298*/ bool CheckIsReserved(char ch, System.UriComponents component);
        static /*0x23e33dc*/ string EscapeUnescapeIri(char* pInput, int start, int end, System.UriComponents component);
    }

    class Uri : System.Runtime.Serialization.ISerializable
    {
        static /*0x0*/ string UriSchemeFile;
        static /*0x8*/ string UriSchemeFtp;
        static /*0x10*/ string UriSchemeGopher;
        static /*0x18*/ string UriSchemeHttp;
        static /*0x20*/ string UriSchemeHttps;
        static /*0x28*/ string UriSchemeWs;
        static /*0x30*/ string UriSchemeWss;
        static /*0x38*/ string UriSchemeMailto;
        static /*0x40*/ string UriSchemeNews;
        static /*0x48*/ string UriSchemeNntp;
        static /*0x50*/ string UriSchemeNetTcp;
        static /*0x58*/ string UriSchemeNetPipe;
        static /*0x60*/ string SchemeDelimiter;
        static /*0x68*/ bool s_ConfigInitialized;
        static /*0x69*/ bool s_ConfigInitializing;
        static /*0x6c*/ System.UriIdnScope s_IdnScope;
        static /*0x70*/ bool s_IriParsing;
        static /*0x71*/ bool useDotNetRelativeOrAbsolute;
        static /*0x72*/ bool IsWindowsFileSystem;
        static /*0x78*/ object s_initLock;
        static /*0x80*/ char[] HexLowerChars;
        static /*0x88*/ char[] _WSchars;
        /*0x10*/ string m_String;
        /*0x18*/ string m_originalUnicodeString;
        /*0x20*/ System.UriParser m_Syntax;
        /*0x28*/ string m_DnsSafeHost;
        /*0x30*/ System.Uri.Flags m_Flags;
        /*0x38*/ System.Uri.UriInfo m_Info;
        /*0x40*/ bool m_iriParsing;

        static /*0x23e08cc*/ Uri();
        static /*0x23d3ec0*/ bool IriParsingStatic(System.UriParser syntax);
        static /*0x23d40e0*/ bool StaticNotAny(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x23d4180*/ bool StaticInFact(System.Uri.Flags allFlags, System.Uri.Flags checkFlags);
        static /*0x23d64dc*/ System.ParsingError GetCombinedString(System.Uri baseUri, string relativeStr, bool dontEscape, ref string result);
        static /*0x23d72fc*/ System.UriFormatException GetException(System.ParsingError err);
        static /*0x23d86b0*/ bool StaticIsFile(System.UriParser syntax);
        static /*0x23d86c8*/ object get_InitializeLock();
        static /*0x23d879c*/ void InitializeUriConfig();
        static /*0x23d955c*/ bool IsGenDelim(char ch);
        static /*0x23d95a8*/ bool IsHexDigit(char character);
        static /*0x23d95e4*/ int FromHex(char digit);
        static /*0x23d9b50*/ bool op_Equality(System.Uri uri1, System.Uri uri2);
        static /*0x23d6150*/ bool op_Inequality(System.Uri uri1, System.Uri uri2);
        static /*0x23da1c4*/ string InternalEscapeString(string rawString);
        static /*0x23da2a4*/ System.ParsingError ParseScheme(string uriString, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x23dc338*/ string CreateHostStringHelper(string str, ushort idx, ushort end, ref System.Uri.Flags flags, ref string scopeId);
        static /*0x23da384*/ ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, ref System.UriParser syntax);
        static /*0x23de500*/ bool CheckKnownSchemes(long* lptr, ushort nChars, ref System.UriParser syntax);
        static /*0x23d672c*/ System.ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref System.UriParser syntax);
        static /*0x23df220*/ void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3);
        static /*0x23d893c*/ char[] Compress(char[] dest, ushort start, ref int destLength, System.UriParser syntax);
        static /*0x23d97cc*/ int CalculateCaseInsensitiveHashCode(string text);
        static /*0x23d6888*/ string CombineUri(System.Uri basePart, string relativePart, System.UriFormat uriFormat);
        static /*0x23dafb4*/ bool IsLWS(char ch);
        static /*0x23daff4*/ bool IsAsciiLetter(char character);
        static /*0x23df448*/ bool IsAsciiLetterOrDigit(char character);
        static /*0x23df4c4*/ bool IsBidiControlCharacter(char ch);
        static /*0x23df014*/ string StripBidiControlCharacter(char* strToClean, int start, int length);
        static /*0x23da10c*/ bool TryCreate(string uriString, System.UriKind uriKind, ref System.Uri result);
        static /*0x23dffc4*/ bool TryCreate(System.Uri baseUri, string relativeUri, ref System.Uri result);
        static /*0x23e0094*/ bool TryCreate(System.Uri baseUri, System.Uri relativeUri, ref System.Uri result);
        static /*0x23e0428*/ string UnescapeDataString(string stringToUnescape);
        static /*0x23dfd50*/ System.Uri CreateHelper(string uriString, bool dontEscape, System.UriKind uriKind, ref System.UriFormatException e);
        static /*0x23d5c94*/ System.Uri ResolveHelper(System.Uri baseUri, System.Uri relativeUri, ref string newUriString, ref bool userEscaped, ref System.UriFormatException e);
        /*0x23d5768*/ Uri(string uriString);
        /*0x23d59ac*/ Uri(string uriString, System.UriKind uriKind);
        /*0x23d5a34*/ Uri(System.Uri baseUri, string relativeUri);
        /*0x23d62b8*/ Uri(System.Uri baseUri, System.Uri relativeUri);
        /*0x23d749c*/ Uri(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x23e05d0*/ Uri(System.Uri.Flags flags, System.UriParser uriParser, string uri);
        /*0x23d3e68*/ bool get_IsImplicitFile();
        /*0x23d3e74*/ bool get_IsUncOrDosPath();
        /*0x23d3e84*/ bool get_IsDosPath();
        /*0x23d3e90*/ bool get_IsUncPath();
        /*0x23d3e9c*/ System.Uri.Flags get_HostType();
        /*0x23d3ea8*/ System.UriParser get_Syntax();
        /*0x23d3eb0*/ bool get_IsNotAbsoluteUri();
        /*0x23d3f4c*/ bool get_AllowIdn();
        /*0x23d4018*/ bool AllowIdnStatic(System.UriParser syntax, System.Uri.Flags flags);
        /*0x23d40ec*/ bool IsIntranet(string schemeHost);
        /*0x23d40f4*/ bool get_UserDrivenParsing();
        /*0x23d4100*/ void SetUserDrivenParsing();
        /*0x23d4114*/ ushort get_SecuredPathIndex();
        /*0x23d4008*/ bool NotAny(System.Uri.Flags flags);
        /*0x23d4170*/ bool InFact(System.Uri.Flags flags);
        /*0x23d418c*/ System.Uri.UriInfo EnsureUriInfo();
        /*0x23d4744*/ void EnsureParseRemaining();
        /*0x23d530c*/ void EnsureHostString(bool allowDnsOptimization);
        /*0x23d5b0c*/ void CreateUri(System.Uri baseUri, string relativeUri, bool dontEscape);
        /*0x23d75a0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x23d75a4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x23d7680*/ string get_AbsolutePath();
        /*0x23d7748*/ string get_PrivateAbsolutePath();
        /*0x23d77f0*/ string get_AbsoluteUri();
        /*0x23d78f4*/ string get_LocalPath();
        /*0x23d7f5c*/ string get_Authority();
        /*0x23d7fd8*/ System.UriHostNameType get_HostNameType();
        /*0x23d80d8*/ bool get_IsDefaultPort();
        /*0x23d8188*/ bool get_IsFile();
        /*0x23d8250*/ bool get_IsLoopback();
        /*0x23d82d8*/ string get_PathAndQuery();
        /*0x23d83a8*/ string[] get_Segments();
        /*0x23d85b8*/ bool get_IsUnc();
        /*0x23d8634*/ string get_Host();
        /*0x23d7968*/ string GetLocalPath();
        /*0x23d8ee4*/ int get_Port();
        /*0x23d8fb0*/ string get_Query();
        /*0x23d90b8*/ string get_Fragment();
        /*0x23d91c0*/ string get_Scheme();
        /*0x23d9238*/ bool get_OriginalStringSwitched();
        /*0x23d6860*/ string get_OriginalString();
        /*0x23d9280*/ string get_DnsSafeHost();
        /*0x23d5afc*/ bool get_IsAbsoluteUri();
        /*0x23d94d4*/ bool get_UserEscaped();
        /*0x23d94e0*/ string get_UserInfo();
        /*0x23d9694*/ int GetHashCode();
        /*0x23d986c*/ string ToString();
        /*0x23d9b84*/ bool Equals(object comparand);
        /*0x23da8cc*/ System.UriFormatException ParseMinimal();
        /*0x23da94c*/ System.ParsingError PrivateParseMinimal();
        /*0x23dbe24*/ void PrivateParseMinimalIri(string newHost, ushort idx);
        /*0x23d41b0*/ void CreateUriInfo(System.Uri.Flags cF);
        /*0x23d536c*/ void CreateHostString();
        /*0x23dbef8*/ void GetHostViaCustomSyntax();
        /*0x23d767c*/ string GetParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x23dcaf0*/ string GetEscapedParts(System.UriComponents uriParts);
        /*0x23d8e14*/ string GetUnescapedParts(System.UriComponents uriParts, System.UriFormat formatAs);
        /*0x23dd168*/ string ReCreateParts(System.UriComponents parts, ushort nonCanonical, System.UriFormat formatAs);
        /*0x23dcbb8*/ string GetUriPartsFromUserString(System.UriComponents uriParts);
        /*0x23d4754*/ void ParseRemaining();
        /*0x23db020*/ ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref System.ParsingError err, ref System.Uri.Flags flags, System.UriParser syntax, ref string newHost);
        /*0x23dea00*/ void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, System.UriParser syntax, string userInfoString, ref System.Uri.Flags flags, ref bool justNormalized, ref string newHost, ref System.ParsingError err);
        /*0x23ded50*/ void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, System.UriParser syntax, ref System.Uri.Flags flags, ref string newHost, ref System.ParsingError err);
        /*0x23de45c*/ void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim);
        /*0x23df18c*/ void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim);
        /*0x23dc51c*/ System.Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim);
        /*0x23dddf4*/ char[] GetCanonicalPath(char[] dest, ref int pos, System.UriFormat formatAs);
        /*0x23df43c*/ bool get_HasAuthority();
        /*0x23d57ec*/ void CreateThis(string uri, bool dontEscape, System.UriKind uriKind);
        /*0x23df50c*/ void InitializeUri(System.ParsingError err, System.UriKind uriKind, ref System.UriFormatException e);
        /*0x23df9e0*/ bool CheckForConfigLoad(string data);
        /*0x23dfa8c*/ bool CheckForUnicode(string data);
        /*0x23dfba4*/ bool CheckForEscapedUnreserved(string data);
        /*0x23dc914*/ string GetComponents(System.UriComponents components, System.UriFormat format);
        /*0x23de4b0*/ string EscapeUnescapeIri(string input, int start, int end, System.UriComponents component);
        /*0x23e0208*/ string GetRelativeSerializationString(System.UriFormat format);
        /*0x23d9938*/ string GetComponentsHelper(System.UriComponents uriComponents, System.UriFormat uriFormat);
        /*0x23e0610*/ bool IsBaseOf(System.Uri uri);
        /*0x23e06c8*/ bool IsBaseOfHelper(System.Uri uriLink);
        /*0x23d6198*/ void CreateThisFromUri(System.Uri otherUri);

        enum Flags
        {
            Zero = 0,
            SchemeNotCanonical = 1,
            UserNotCanonical = 2,
            HostNotCanonical = 4,
            PortNotCanonical = 8,
            PathNotCanonical = 16,
            QueryNotCanonical = 32,
            FragmentNotCanonical = 64,
            CannotDisplayCanonical = 127,
            E_UserNotCanonical = 128,
            E_HostNotCanonical = 256,
            E_PortNotCanonical = 512,
            E_PathNotCanonical = 1024,
            E_QueryNotCanonical = 2048,
            E_FragmentNotCanonical = 4096,
            E_CannotDisplayCanonical = 8064,
            ShouldBeCompressed = 8192,
            FirstSlashAbsent = 16384,
            BackslashInPath = 32768,
            IndexMask = 65535,
            HostTypeMask = 458752,
            HostNotParsed = 0,
            IPv6HostType = 65536,
            IPv4HostType = 131072,
            DnsHostType = 196608,
            UncHostType = 262144,
            BasicHostType = 327680,
            UnusedHostType = 393216,
            UnknownHostType = 458752,
            UserEscaped = 524288,
            AuthorityFound = 1048576,
            HasUserInfo = 2097152,
            LoopbackHost = 4194304,
            NotDefaultPort = 8388608,
            UserDrivenParsing = 16777216,
            CanonicalDnsHost = 33554432,
            ErrorOrParsingRecursion = 67108864,
            DosPath = 134217728,
            UncPath = 268435456,
            ImplicitFile = 536870912,
            MinimalUriInfoSet = 1073741824,
            AllUriInfoSet = 2147483648,
            IdnHost = 4294967296,
            HasUnicode = 8589934592,
            HostUnicodeNormalized = 17179869184,
            RestUnicodeNormalized = 34359738368,
            UnicodeHost = 68719476736,
            IntranetUri = 137438953472,
            UseOrigUncdStrOffset = 274877906944,
            UserIriCanonical = 549755813888,
            PathIriCanonical = 1099511627776,
            QueryIriCanonical = 2199023255552,
            FragmentIriCanonical = 4398046511104,
            IriCanonical = 8246337208320,
            CompressedSlashes = 17592186044416,
        }

        class UriInfo
        {
            /*0x10*/ string Host;
            /*0x18*/ string ScopeId;
            /*0x20*/ string String;
            /*0x28*/ System.Uri.Offset Offset;
            /*0x38*/ string DnsSafeHost;
            /*0x40*/ System.Uri.MoreInfo MoreInfo;

            /*0x23e4318*/ UriInfo();
        }

        struct Offset
        {
            /*0x10*/ ushort Scheme;
            /*0x12*/ ushort User;
            /*0x14*/ ushort Host;
            /*0x16*/ ushort PortValue;
            /*0x18*/ ushort Path;
            /*0x1a*/ ushort Query;
            /*0x1c*/ ushort Fragment;
            /*0x1e*/ ushort End;
        }

        class MoreInfo
        {
            /*0x10*/ string Path;
            /*0x18*/ string Query;
            /*0x20*/ string Fragment;
            /*0x28*/ string AbsoluteUri;
            /*0x30*/ int Hash;
            /*0x38*/ string RemoteUrl;

            /*0x23e4320*/ MoreInfo();
        }

        enum Check
        {
            None = 0,
            EscapedCanonical = 1,
            DisplayCanonical = 2,
            DotSlashAttn = 4,
            DotSlashEscaped = 128,
            BackslashInPath = 16,
            ReservedFound = 32,
            NotIriCanonical = 64,
            FoundNonAscii = 8,
        }
    }

    class UriFormatException : System.FormatException, System.Runtime.Serialization.ISerializable
    {
        /*0x23e4328*/ UriFormatException();
        /*0x23e2b14*/ UriFormatException(string textString);
        /*0x23e4330*/ UriFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        /*0x23e4338*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
    }

    enum UriKind
    {
        RelativeOrAbsolute = 0,
        Absolute = 1,
        Relative = 2,
    }

    enum UriComponents
    {
        Scheme = 1,
        UserInfo = 2,
        Host = 4,
        Port = 8,
        Path = 16,
        Query = 32,
        Fragment = 64,
        StrongPort = 128,
        NormalizedHost = 256,
        KeepDelimiter = 1073741824,
        SerializationInfoString = -2147483648,
        AbsoluteUri = 127,
        HostAndPort = 132,
        StrongAuthority = 134,
        SchemeAndServer = 13,
        HttpRequestUrl = 61,
        PathAndQuery = 48,
    }

    enum UriFormat
    {
        UriEscaped = 1,
        Unescaped = 2,
        SafeUnescaped = 3,
    }

    enum UriIdnScope
    {
        None = 0,
        AllExceptIntranet = 1,
        All = 2,
    }

    enum ParsingError
    {
        None = 0,
        BadFormat = 1,
        BadScheme = 2,
        BadAuthority = 3,
        EmptyUriString = 4,
        LastRelativeUriOkErrIndex = 4,
        SchemeLimit = 5,
        SizeLimit = 6,
        MustRootedPath = 7,
        BadHostName = 8,
        NonEmptyHost = 9,
        BadPort = 10,
        BadAuthorityTerminator = 11,
        CannotCreateRelative = 12,
    }

    enum UnescapeMode
    {
        CopyOnly = 0,
        Escape = 1,
        Unescape = 2,
        EscapeUnescape = 3,
        V1ToStringFlag = 4,
        UnescapeAll = 8,
        UnescapeAllOrThrow = 24,
    }

    class UriHelper
    {
        static /*0x0*/ char[] HexUpperChars;

        static /*0x23e5888*/ UriHelper();
        static /*0x23e4340*/ bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase);
        static /*0x23e4544*/ char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd);
        static /*0x23e4a80*/ char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos);
        static /*0x23e4d94*/ char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x23e4e74*/ char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, System.UnescapeMode unescapeMode, System.UriParser syntax, bool isQuery);
        static /*0x23e3d28*/ void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing);
        static /*0x23e4210*/ void EscapeAsciiChar(char ch, char[] to, ref int pos);
        static /*0x23e3bdc*/ char EscapedAscii(char digit, char next);
        static /*0x23e3c9c*/ bool IsNotSafeForUnescape(char ch);
        static /*0x23e4c8c*/ bool IsReservedUnreservedOrHash(char c);
        static /*0x23e4bac*/ bool IsUnreserved(char c);
        static /*0x23e57ec*/ bool Is3986Unreserved(char c);
    }

    enum UriHostNameType
    {
        Unknown = 0,
        Basic = 1,
        Dns = 2,
        IPv4 = 3,
        IPv6 = 4,
    }

    class UriParser
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_Table;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, System.UriParser> m_TempTable;
        static /*0x10*/ System.UriParser HttpUri;
        static /*0x18*/ System.UriParser HttpsUri;
        static /*0x20*/ System.UriParser WsUri;
        static /*0x28*/ System.UriParser WssUri;
        static /*0x30*/ System.UriParser FtpUri;
        static /*0x38*/ System.UriParser FileUri;
        static /*0x40*/ System.UriParser GopherUri;
        static /*0x48*/ System.UriParser NntpUri;
        static /*0x50*/ System.UriParser NewsUri;
        static /*0x58*/ System.UriParser MailToUri;
        static /*0x60*/ System.UriParser UuidUri;
        static /*0x68*/ System.UriParser TelnetUri;
        static /*0x70*/ System.UriParser LdapUri;
        static /*0x78*/ System.UriParser NetTcpUri;
        static /*0x80*/ System.UriParser NetPipeUri;
        static /*0x88*/ System.UriParser VsMacrosUri;
        static /*0x90*/ System.UriParser.UriQuirksVersion s_QuirksVersion;
        static /*0x94*/ System.UriSyntaxFlags HttpSyntaxFlags;
        static /*0x98*/ System.UriSyntaxFlags FileSyntaxFlags;
        /*0x10*/ System.UriSyntaxFlags m_Flags;
        /*0x14*/ System.UriSyntaxFlags m_UpdatableFlags;
        /*0x18*/ bool m_UpdatableFlagsUsed;
        /*0x1c*/ int m_Port;
        /*0x20*/ string m_Scheme;

        static /*0x23e5d88*/ UriParser();
        static /*0x23e578c*/ bool get_ShouldUseLegacyV2Quirks();
        static /*0x23e6664*/ System.UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme);
        static /*0x23e2b1c*/ System.UriParser GetSyntax(string lwrCaseScheme);
        /*0x23e65f8*/ UriParser(System.UriSyntaxFlags flags);
        /*0x23e591c*/ string get_SchemeName();
        /*0x23e5924*/ int get_DefaultPort();
        /*0x23e592c*/ System.UriParser OnNewUri();
        /*0x23e5930*/ void InitializeAndValidate(System.Uri uri, ref System.UriFormatException parsingError);
        /*0x23e5958*/ string Resolve(System.Uri baseUri, System.Uri relativeUri, ref System.UriFormatException parsingError);
        /*0x23e5b40*/ bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri);
        /*0x23e5b5c*/ string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format);
        /*0x23e658c*/ System.UriSyntaxFlags get_Flags();
        /*0x23e2c08*/ bool NotAny(System.UriSyntaxFlags flags);
        /*0x23e2bec*/ bool InFact(System.UriSyntaxFlags flags);
        /*0x23e65f0*/ bool IsAllSet(System.UriSyntaxFlags flags);
        /*0x23e6594*/ bool IsFullMatch(System.UriSyntaxFlags flags, System.UriSyntaxFlags expected);
        /*0x23e6954*/ bool get_IsSimple();
        /*0x23e6960*/ System.UriParser InternalOnNewUri();
        /*0x23e69a4*/ void InternalValidate(System.Uri thisUri, ref System.UriFormatException parsingError);
        /*0x23e69b0*/ string InternalResolve(System.Uri thisBaseUri, System.Uri uriLink, ref System.UriFormatException parsingError);
        /*0x23e69bc*/ bool InternalIsBaseOf(System.Uri thisBaseUri, System.Uri uriLink);
        /*0x23e69c8*/ string InternalGetComponents(System.Uri thisUri, System.UriComponents uriComponents, System.UriFormat uriFormat);

        enum UriQuirksVersion
        {
            V2 = 2,
            V3 = 3,
        }

        class BuiltInUriParser : System.UriParser
        {
            /*0x23e650c*/ BuiltInUriParser(string lwrCaseScheme, int defaultPort, System.UriSyntaxFlags syntaxFlags);
        }
    }

    class DomainNameHelper
    {
        static /*0x23e69d4*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x23e6b74*/ bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x23e6da0*/ bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile);
        static /*0x23e6f88*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x23e7204*/ string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost);
        static /*0x23e7444*/ bool IsIdnAce(string input, int index);
        static /*0x23e73f8*/ bool IsIdnAce(char* input, int index);
        static /*0x23e74dc*/ string UnicodeEquivalent(string idnHost, char* hostname, int start, int end);
        static /*0x23e75f8*/ string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn);
        static /*0x23e6cf0*/ bool IsASCIILetterOrDigit(char character, ref bool notCanonical);
        static /*0x23e6d3c*/ bool IsValidDomainLabelCharacter(char character, ref bool notCanonical);
    }

    class UncNameHelper
    {
        static /*0x23e7a50*/ string ParseCanonicalName(string str, int start, int end, ref bool loopback);
        static /*0x23e7a54*/ bool IsValid(char* name, ushort start, ref int returnedEnd, bool notImplicitFile);
    }

    enum UriSyntaxFlags
    {
        None = 0,
        MustHaveAuthority = 1,
        OptionalAuthority = 2,
        MayHaveUserInfo = 4,
        MayHavePort = 8,
        MayHavePath = 16,
        MayHaveQuery = 32,
        MayHaveFragment = 64,
        AllowEmptyHost = 128,
        AllowUncHost = 256,
        AllowDnsHost = 512,
        AllowIPv4Host = 1024,
        AllowIPv6Host = 2048,
        AllowAnInternetHost = 3584,
        AllowAnyOtherHost = 4096,
        FileLikeUri = 8192,
        MailToLikeUri = 16384,
        V1_UnknownUri = 65536,
        SimpleUserSyntax = 131072,
        BuiltInSyntax = 262144,
        ParserSchemeOnly = 524288,
        AllowDOSPath = 1048576,
        PathIsRooted = 2097152,
        ConvertPathSlashes = 4194304,
        CompressPath = 8388608,
        CanonicalizeAsFilePath = 16777216,
        UnEscapeDotsAndSlashes = 33554432,
        AllowIdn = 67108864,
        AllowIriParsing = 268435456,
    }

    enum IOOperation
    {
        Read = 1,
        Write = 2,
    }

    class IOAsyncCallback : System.MulticastDelegate
    {
        /*0x23e7d2c*/ IOAsyncCallback(object object, nint method);
        /*0x23e7e58*/ void Invoke(System.IOAsyncResult ioares);
    }

    class IOAsyncResult : System.IAsyncResult
    {
        /*0x10*/ System.AsyncCallback async_callback;
        /*0x18*/ object async_state;
        /*0x20*/ System.Threading.ManualResetEvent wait_handle;
        /*0x28*/ bool completed_synchronously;
        /*0x29*/ bool completed;

        /*0x23e7e6c*/ IOAsyncResult();
        /*0x23e7e94*/ IOAsyncResult(System.AsyncCallback async_callback, object async_state);
        /*0x23e7e74*/ void Init(System.AsyncCallback async_callback, object async_state);
        /*0x23e7ec0*/ System.AsyncCallback get_AsyncCallback();
        /*0x23e7ec8*/ object get_AsyncState();
        /*0x23e7ed0*/ System.Threading.WaitHandle get_AsyncWaitHandle();
        /*0x23e7ff4*/ bool get_CompletedSynchronously();
        /*0x23e7ffc*/ void set_CompletedSynchronously(bool value);
        /*0x23e8008*/ bool get_IsCompleted();
        /*0x23e8010*/ void set_IsCompleted(bool value);
        void CompleteDisposed();
    }

    class IOSelectorJob : System.Threading.IThreadPoolWorkItem
    {
        /*0x10*/ System.IOOperation operation;
        /*0x18*/ System.IOAsyncCallback callback;
        /*0x20*/ System.IOAsyncResult state;

        /*0x23e80e8*/ IOSelectorJob(System.IOOperation operation, System.IOAsyncCallback callback, System.IOAsyncResult state);
        /*0x23e8124*/ void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem();
        /*0x23e814c*/ void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException tae);
        /*0x23e8150*/ void MarkDisposed();
    }

    class IOSelector
    {
        static /*0x23e8170*/ void Add(nint handle, System.IOSelectorJob job);
    }

    class UriTypeConverter : System.ComponentModel.TypeConverter
    {
        /*0x23e8174*/ UriTypeConverter();
        /*0x23e817c*/ bool CanConvert(System.Type type);
    }

    namespace Text
    {
        namespace RegularExpressions
        {
            class Capture
            {
                /*0x10*/ int <Index>k__BackingField;
                /*0x14*/ int <Length>k__BackingField;
                /*0x18*/ string <Text>k__BackingField;

                /*0x23e8260*/ Capture(string text, int index, int length);
                /*0x23e829c*/ int get_Index();
                /*0x23e82a4*/ void set_Index(int value);
                /*0x23e82ac*/ int get_Length();
                /*0x23e82b4*/ void set_Length(int value);
                /*0x23e82bc*/ string get_Text();
                /*0x23e82c4*/ void set_Text(string value);
                /*0x23e82cc*/ string get_Value();
                /*0x23e82f0*/ string ToString();
                /*0x23e82f4*/ System.ReadOnlySpan<char> GetLeftSubstring();
                /*0x23e837c*/ System.ReadOnlySpan<char> GetRightSubstring();
            }

            class CaptureCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Capture>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Capture>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Group _group;
                /*0x18*/ int _capcount;
                /*0x20*/ System.Text.RegularExpressions.Capture[] _captures;

                /*0x23e840c*/ CaptureCollection(System.Text.RegularExpressions.Group group);
                /*0x23e8444*/ bool get_IsReadOnly();
                /*0x23e844c*/ int get_Count();
                /*0x23e8454*/ System.Text.RegularExpressions.Capture get_Item(int i);
                /*0x23e8520*/ System.Collections.IEnumerator GetEnumerator();
                /*0x23e85bc*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator();
                /*0x23e8458*/ System.Text.RegularExpressions.Capture GetCapture(int i);
                /*0x23e8628*/ void ForceInitialized();
                /*0x23e87a0*/ bool get_IsSynchronized();
                /*0x23e87a8*/ object get_SyncRoot();
                /*0x23e87b0*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x23e886c*/ void CopyTo(System.Text.RegularExpressions.Capture[] array, int arrayIndex);
                /*0x23e89dc*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(System.Text.RegularExpressions.Capture item);
                /*0x23e8a8c*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, System.Text.RegularExpressions.Capture item);
                /*0x23e8adc*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index);
                /*0x23e8b2c*/ System.Text.RegularExpressions.Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index);
                /*0x23e8b30*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, System.Text.RegularExpressions.Capture value);
                /*0x23e8b80*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(System.Text.RegularExpressions.Capture item);
                /*0x23e8bd0*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear();
                /*0x23e8c20*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(System.Text.RegularExpressions.Capture item);
                /*0x23e8cd4*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(System.Text.RegularExpressions.Capture item);
                /*0x23e8d24*/ int System.Collections.IList.Add(object value);
                /*0x23e8d74*/ void System.Collections.IList.Clear();
                /*0x23e8dc4*/ bool System.Collections.IList.Contains(object value);
                /*0x23e8eb8*/ int System.Collections.IList.IndexOf(object value);
                /*0x23e8fac*/ void System.Collections.IList.Insert(int index, object value);
                /*0x23e8ffc*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x23e9004*/ void System.Collections.IList.Remove(object value);
                /*0x23e9054*/ void System.Collections.IList.RemoveAt(int index);
                /*0x23e90a4*/ object System.Collections.IList.get_Item(int index);
                /*0x23e90a8*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Capture>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.CaptureCollection _collection;
                    /*0x18*/ int _index;

                    /*0x23e858c*/ Enumerator(System.Text.RegularExpressions.CaptureCollection collection);
                    /*0x23e90f8*/ bool MoveNext();
                    /*0x23e9138*/ System.Text.RegularExpressions.Capture get_Current();
                    /*0x23e91b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x23e91b4*/ void System.Collections.IEnumerator.Reset();
                    /*0x23e91c0*/ void System.IDisposable.Dispose();
                }
            }

            class CollectionDebuggerProxy<T>
            {
            }

            class Group : System.Text.RegularExpressions.Capture
            {
                static /*0x0*/ System.Text.RegularExpressions.Group s_emptyGroup;
                /*0x20*/ int[] _caps;
                /*0x28*/ int _capcount;
                /*0x30*/ System.Text.RegularExpressions.CaptureCollection _capcoll;
                /*0x38*/ string <Name>k__BackingField;

                static /*0x23e9360*/ Group();
                static /*0x23e92e4*/ System.Text.RegularExpressions.Group Synchronized(System.Text.RegularExpressions.Group inner);
                /*0x23e91c4*/ Group(string text, int[] caps, int capcount, string name);
                /*0x23e945c*/ Group();
                /*0x23e9260*/ bool get_Success();
                /*0x23e9270*/ string get_Name();
                /*0x23e9278*/ System.Text.RegularExpressions.CaptureCollection get_Captures();
            }

            class GroupCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Group>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Group>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Group>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Match _match;
                /*0x18*/ System.Collections.Hashtable _captureMap;
                /*0x20*/ System.Text.RegularExpressions.Group[] _groups;

                /*0x23e9494*/ GroupCollection(System.Text.RegularExpressions.Match match, System.Collections.Hashtable caps);
                /*0x23ea578*/ GroupCollection();
                /*0x23e94c0*/ bool get_IsReadOnly();
                /*0x23e94c8*/ int get_Count();
                /*0x23e94ec*/ System.Text.RegularExpressions.Group get_Item(int groupnum);
                /*0x23e95f4*/ System.Text.RegularExpressions.Group get_Item(string groupname);
                /*0x23e97d0*/ System.Collections.IEnumerator GetEnumerator();
                /*0x23e986c*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator();
                /*0x23e94f0*/ System.Text.RegularExpressions.Group GetGroup(int groupnum);
                /*0x23e98d8*/ System.Text.RegularExpressions.Group GetGroupImpl(int groupnum);
                /*0x23e9c00*/ bool get_IsSynchronized();
                /*0x23e9c08*/ object get_SyncRoot();
                /*0x23e9c10*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x23e9cd0*/ void CopyTo(System.Text.RegularExpressions.Group[] array, int arrayIndex);
                /*0x23e9e54*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(System.Text.RegularExpressions.Group item);
                /*0x23e9f0c*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, System.Text.RegularExpressions.Group item);
                /*0x23e9f5c*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index);
                /*0x23e9fac*/ System.Text.RegularExpressions.Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index);
                /*0x23e9fb0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, System.Text.RegularExpressions.Group value);
                /*0x23ea000*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(System.Text.RegularExpressions.Group item);
                /*0x23ea050*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear();
                /*0x23ea0a0*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(System.Text.RegularExpressions.Group item);
                /*0x23ea154*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(System.Text.RegularExpressions.Group item);
                /*0x23ea1a4*/ int System.Collections.IList.Add(object value);
                /*0x23ea1f4*/ void System.Collections.IList.Clear();
                /*0x23ea244*/ bool System.Collections.IList.Contains(object value);
                /*0x23ea338*/ int System.Collections.IList.IndexOf(object value);
                /*0x23ea42c*/ void System.Collections.IList.Insert(int index, object value);
                /*0x23ea47c*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x23ea484*/ void System.Collections.IList.Remove(object value);
                /*0x23ea4d4*/ void System.Collections.IList.RemoveAt(int index);
                /*0x23ea524*/ object System.Collections.IList.get_Item(int index);
                /*0x23ea528*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.GroupCollection _collection;
                    /*0x18*/ int _index;

                    /*0x23e983c*/ Enumerator(System.Text.RegularExpressions.GroupCollection collection);
                    /*0x23ea5b0*/ bool MoveNext();
                    /*0x23ea5f4*/ System.Text.RegularExpressions.Group get_Current();
                    /*0x23ea684*/ object System.Collections.IEnumerator.get_Current();
                    /*0x23ea688*/ void System.Collections.IEnumerator.Reset();
                    /*0x23ea694*/ void System.IDisposable.Dispose();
                }
            }

            class Match : System.Text.RegularExpressions.Group
            {
                static /*0x0*/ System.Text.RegularExpressions.Match <Empty>k__BackingField;
                /*0x40*/ System.Text.RegularExpressions.GroupCollection _groupcoll;
                /*0x48*/ System.Text.RegularExpressions.Regex _regex;
                /*0x50*/ int _textbeg;
                /*0x54*/ int _textpos;
                /*0x58*/ int _textend;
                /*0x5c*/ int _textstart;
                /*0x60*/ int[][] _matches;
                /*0x68*/ int[] _matchcount;
                /*0x70*/ bool _balancing;

                static /*0x23eb5bc*/ Match();
                static /*0x23ea808*/ System.Text.RegularExpressions.Match get_Empty();
                static /*0x23eae7c*/ System.Text.RegularExpressions.Match Synchronized(System.Text.RegularExpressions.Match inner);
                /*0x23ea698*/ Match(System.Text.RegularExpressions.Regex regex, int capcount, string text, int begpos, int len, int startpos);
                /*0x23eb654*/ Match();
                /*0x23ea860*/ void Reset(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart);
                /*0x23ea8c4*/ System.Text.RegularExpressions.GroupCollection get_Groups();
                /*0x23ea934*/ System.Text.RegularExpressions.Match NextMatch();
                /*0x23eabf4*/ string Result(string replacement);
                /*0x23eacbc*/ System.ReadOnlySpan<char> GroupToStringImpl(int groupnum);
                /*0x23eae54*/ System.ReadOnlySpan<char> LastGroupToStringImpl();
                /*0x23eaf7c*/ void AddMatch(int cap, int start, int len);
                /*0x23eb1a0*/ void BalanceMatch(int cap);
                /*0x23eb278*/ void RemoveMatch(int cap);
                /*0x23eb2b0*/ bool IsMatched(int cap);
                /*0x23eb340*/ int MatchIndex(int cap);
                /*0x23eb3cc*/ int MatchLength(int cap);
                /*0x23eb458*/ void Tidy(int textpos);
            }

            class MatchSparse : System.Text.RegularExpressions.Match
            {
                /*0x78*/ System.Collections.Hashtable _caps;

                /*0x23eb68c*/ MatchSparse(System.Text.RegularExpressions.Regex regex, System.Collections.Hashtable caps, int capcount, string text, int begpos, int len, int startpos);
                /*0x23eb73c*/ System.Text.RegularExpressions.GroupCollection get_Groups();
            }

            class MatchCollection : System.Collections.Generic.IList<System.Text.RegularExpressions.Match>, System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>, System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList<System.Text.RegularExpressions.Match>, System.Collections.Generic.IReadOnlyCollection<System.Text.RegularExpressions.Match>, System.Collections.IList, System.Collections.ICollection
            {
                /*0x10*/ System.Text.RegularExpressions.Regex _regex;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.Match> _matches;
                /*0x20*/ bool _done;
                /*0x28*/ string _input;
                /*0x30*/ int _beginning;
                /*0x34*/ int _length;
                /*0x38*/ int _startat;
                /*0x3c*/ int _prevlen;

                /*0x23eb7b0*/ MatchCollection(System.Text.RegularExpressions.Regex regex, string input, int beginning, int length, int startat);
                /*0x23ec42c*/ MatchCollection();
                /*0x23eb8e0*/ bool get_IsReadOnly();
                /*0x23eb8e8*/ int get_Count();
                /*0x23eb958*/ System.Text.RegularExpressions.Match get_Item(int i);
                /*0x23ebb28*/ System.Collections.IEnumerator GetEnumerator();
                /*0x23ebbc4*/ System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator();
                /*0x23eb9bc*/ System.Text.RegularExpressions.Match GetMatch(int i);
                /*0x23eb944*/ void EnsureInitialized();
                /*0x23ebc30*/ bool get_IsSynchronized();
                /*0x23ebc38*/ object get_SyncRoot();
                /*0x23ebc3c*/ void CopyTo(System.Array array, int arrayIndex);
                /*0x23ebd08*/ void CopyTo(System.Text.RegularExpressions.Match[] array, int arrayIndex);
                /*0x23ebd84*/ int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(System.Text.RegularExpressions.Match item);
                /*0x23ebdf0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, System.Text.RegularExpressions.Match item);
                /*0x23ebe40*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index);
                /*0x23ebe90*/ System.Text.RegularExpressions.Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index);
                /*0x23ebea0*/ void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, System.Text.RegularExpressions.Match value);
                /*0x23ebef0*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(System.Text.RegularExpressions.Match item);
                /*0x23ebf40*/ void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear();
                /*0x23ebf90*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(System.Text.RegularExpressions.Match item);
                /*0x23ebffc*/ bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(System.Text.RegularExpressions.Match item);
                /*0x23ec04c*/ int System.Collections.IList.Add(object value);
                /*0x23ec09c*/ void System.Collections.IList.Clear();
                /*0x23ec0ec*/ bool System.Collections.IList.Contains(object value);
                /*0x23ec1e0*/ int System.Collections.IList.IndexOf(object value);
                /*0x23ec2d4*/ void System.Collections.IList.Insert(int index, object value);
                /*0x23ec324*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x23ec32c*/ void System.Collections.IList.Remove(object value);
                /*0x23ec37c*/ void System.Collections.IList.RemoveAt(int index);
                /*0x23ec3cc*/ object System.Collections.IList.get_Item(int index);
                /*0x23ec3dc*/ void System.Collections.IList.set_Item(int index, object value);

                class Enumerator : System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Text.RegularExpressions.MatchCollection _collection;
                    /*0x18*/ int _index;

                    /*0x23ebb94*/ Enumerator(System.Text.RegularExpressions.MatchCollection collection);
                    /*0x23ec464*/ bool MoveNext();
                    /*0x23ec4b4*/ System.Text.RegularExpressions.Match get_Current();
                    /*0x23ec520*/ object System.Collections.IEnumerator.get_Current();
                    /*0x23ec524*/ void System.Collections.IEnumerator.Reset();
                    /*0x23ec530*/ void System.IDisposable.Dispose();
                }
            }

            class ExclusiveReference
            {
                /*0x10*/ System.Text.RegularExpressions.RegexRunner _ref;
                /*0x18*/ System.Text.RegularExpressions.RegexRunner _obj;
                /*0x20*/ int _locked;

                /*0x23ec648*/ ExclusiveReference();
                /*0x23ec534*/ System.Text.RegularExpressions.RegexRunner Get();
                /*0x23ec58c*/ void Release(System.Text.RegularExpressions.RegexRunner obj);
            }

            class Regex : System.Runtime.Serialization.ISerializable
            {
                static int CacheDictionarySwitchLimit = 10;
                static string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
                static int MaxOptionShift = 10;
                static /*0x0*/ int s_cacheSize;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey, System.Text.RegularExpressions.Regex.CachedCodeEntry> s_cache;
                static /*0x10*/ int s_cacheCount;
                static /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheFirst;
                static /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntry s_cacheLast;
                static /*0x28*/ System.TimeSpan s_maximumMatchTimeout;
                static /*0x30*/ System.TimeSpan s_defaultMatchTimeout;
                static /*0x38*/ System.TimeSpan InfiniteMatchTimeout;
                /*0x10*/ System.TimeSpan internalMatchTimeout;
                /*0x18*/ string pattern;
                /*0x20*/ System.Text.RegularExpressions.RegexOptions roptions;
                /*0x28*/ System.Text.RegularExpressions.RegexRunnerFactory factory;
                /*0x30*/ System.Collections.Hashtable caps;
                /*0x38*/ System.Collections.Hashtable capnames;
                /*0x40*/ string[] capslist;
                /*0x48*/ int capsize;
                /*0x50*/ System.Text.RegularExpressions.ExclusiveReference _runnerref;
                /*0x58*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> _replref;
                /*0x60*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x68*/ bool _refsInitialized;

                static /*0x23ef57c*/ Regex();
                static /*0x23ec650*/ int get_CacheSize();
                static /*0x23ec6a8*/ void set_CacheSize(int value);
                static /*0x23ed37c*/ bool TryGetCacheValue(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x23ed498*/ bool TryGetCacheValueSmall(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, ref System.Text.RegularExpressions.Regex.CachedCodeEntry entry);
                static /*0x23ecf64*/ System.Text.RegularExpressions.Regex.CachedCodeEntry LookupCachedAndPromote(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key);
                static /*0x23ed56c*/ bool IsMatch(string input, string pattern);
                static /*0x23ed66c*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23ed5e0*/ bool IsMatch(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23edb58*/ System.Text.RegularExpressions.Match Match(string input, string pattern);
                static /*0x23edc58*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23edbcc*/ System.Text.RegularExpressions.Match Match(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23ede3c*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern);
                static /*0x23edf3c*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23edeb0*/ System.Text.RegularExpressions.MatchCollection Matches(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23ee0f8*/ string Replace(string input, string pattern, string replacement);
                static /*0x23ee208*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23ee174*/ string Replace(string input, string pattern, string replacement, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23ee454*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator);
                static /*0x23ee564*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23ee4d0*/ string Replace(string input, string pattern, System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23ee7a4*/ string Replace(System.Text.RegularExpressions.MatchEvaluator evaluator, System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x23eebdc*/ string[] Split(string input, string pattern);
                static /*0x23eecdc*/ string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options);
                static /*0x23eec50*/ string[] Split(string input, string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                static /*0x23eef60*/ string[] Split(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
                static /*0x23ef8fc*/ void ValidateMatchTimeout(System.TimeSpan matchTimeout);
                static /*0x23ef6b4*/ System.TimeSpan InitDefaultMatchTimeout();
                static /*0x23eff98*/ string Escape(string str);
                static /*0x23f0040*/ string Unescape(string str);
                static /*0x23f0540*/ void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname);
                static /*0x23f0578*/ void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes);
                static /*0x23f05b0*/ void CompileToAssembly(System.Text.RegularExpressions.RegexCompilationInfo[] regexinfos, System.Reflection.AssemblyName assemblyname, System.Reflection.Emit.CustomAttributeBuilder[] attributes, string resourceFile);
                /*0x23efa58*/ Regex();
                /*0x23efac4*/ Regex(string pattern);
                /*0x23efb3c*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options);
                /*0x23efbb8*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout);
                /*0x23efbc0*/ Regex(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x23ed6e4*/ Regex(string pattern, System.Text.RegularExpressions.RegexOptions options, System.TimeSpan matchTimeout, bool addToCache);
                /*0x23ec984*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCode(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x23ecaac*/ System.Text.RegularExpressions.Regex.CachedCodeEntry GetCachedCodeEntryInternal(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, bool isToAdd);
                /*0x23ed278*/ void FillCacheDictionary();
                /*0x23eda5c*/ bool IsMatch(string input);
                /*0x23edad8*/ bool IsMatch(string input, int startat);
                /*0x23edcd0*/ System.Text.RegularExpressions.Match Match(string input);
                /*0x23edd40*/ System.Text.RegularExpressions.Match Match(string input, int startat);
                /*0x23eddb4*/ System.Text.RegularExpressions.Match Match(string input, int beginning, int length);
                /*0x23edfb4*/ System.Text.RegularExpressions.MatchCollection Matches(string input);
                /*0x23ee024*/ System.Text.RegularExpressions.MatchCollection Matches(string input, int startat);
                /*0x23ee290*/ string Replace(string input, string replacement);
                /*0x23ee3e4*/ string Replace(string input, string replacement, int count);
                /*0x23ee304*/ string Replace(string input, string replacement, int count, int startat);
                /*0x23ee5ec*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator);
                /*0x23ee734*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count);
                /*0x23ee660*/ string Replace(string input, System.Text.RegularExpressions.MatchEvaluator evaluator, int count, int startat);
                /*0x23eed54*/ string[] Split(string input);
                /*0x23eee8c*/ string[] Split(string input, int count);
                /*0x23eedc8*/ string[] Split(string input, int count, int startat);
                /*0x23ef8f4*/ System.TimeSpan get_MatchTimeout();
                /*0x23efc68*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context);
                /*0x23efdb8*/ System.Collections.IDictionary get_Caps();
                /*0x23efdc0*/ void set_Caps(System.Collections.IDictionary value);
                /*0x23efea8*/ System.Collections.IDictionary get_CapNames();
                /*0x23efeb0*/ void set_CapNames(System.Collections.IDictionary value);
                /*0x23f00e8*/ System.Text.RegularExpressions.RegexOptions get_Options();
                /*0x23eebd0*/ bool get_RightToLeft();
                /*0x23f00f0*/ string ToString();
                /*0x23f00f8*/ string[] GetGroupNames();
                /*0x23f0268*/ int[] GetGroupNumbers();
                /*0x23e9ab8*/ string GroupNameFromNumber(int i);
                /*0x23e9684*/ int GroupNumberFromName(string name);
                /*0x23efcb4*/ void InitializeReferences();
                /*0x23ea964*/ System.Text.RegularExpressions.Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat);
                /*0x23f0538*/ bool UseOptionC();
                /*0x23edacc*/ bool UseOptionR();
                /*0x23f052c*/ bool UseOptionInvariant();

                struct CachedCodeEntryKey : System.IEquatable<System.Text.RegularExpressions.Regex.CachedCodeEntryKey>
                {
                    /*0x10*/ System.Text.RegularExpressions.RegexOptions _options;
                    /*0x18*/ string _cultureKey;
                    /*0x20*/ string _pattern;

                    static /*0x23eca7c*/ bool op_Equality(System.Text.RegularExpressions.Regex.CachedCodeEntryKey left, System.Text.RegularExpressions.Regex.CachedCodeEntryKey right);
                    /*0x23efca8*/ CachedCodeEntryKey(System.Text.RegularExpressions.RegexOptions options, string cultureKey, string pattern);
                    /*0x23f05e8*/ bool Equals(object obj);
                    /*0x23f0678*/ bool Equals(System.Text.RegularExpressions.Regex.CachedCodeEntryKey other);
                    /*0x23f06e0*/ int GetHashCode();
                }

                class CachedCodeEntry
                {
                    /*0x10*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Next;
                    /*0x18*/ System.Text.RegularExpressions.Regex.CachedCodeEntry Previous;
                    /*0x20*/ System.Text.RegularExpressions.Regex.CachedCodeEntryKey Key;
                    /*0x38*/ System.Text.RegularExpressions.RegexCode Code;
                    /*0x40*/ System.Collections.Hashtable Caps;
                    /*0x48*/ System.Collections.Hashtable Capnames;
                    /*0x50*/ string[] Capslist;
                    /*0x58*/ int Capsize;
                    /*0x60*/ System.Text.RegularExpressions.ExclusiveReference Runnerref;
                    /*0x68*/ System.WeakReference<System.Text.RegularExpressions.RegexReplacement> ReplRef;

                    /*0x23ed200*/ CachedCodeEntry(System.Text.RegularExpressions.Regex.CachedCodeEntryKey key, System.Collections.Hashtable capnames, string[] capslist, System.Text.RegularExpressions.RegexCode code, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref);
                }
            }

            class MatchEvaluator : System.MulticastDelegate
            {
                /*0x23f0738*/ MatchEvaluator(object object, nint method);
                /*0x23f0864*/ string Invoke(System.Text.RegularExpressions.Match match);
            }

            class RegexBoyerMoore
            {
                /*0x10*/ int[] Positive;
                /*0x18*/ int[] NegativeASCII;
                /*0x20*/ int[][] NegativeUnicode;
                /*0x28*/ string Pattern;
                /*0x30*/ int LowASCII;
                /*0x34*/ int HighASCII;
                /*0x38*/ bool RightToLeft;
                /*0x39*/ bool CaseInsensitive;
                /*0x40*/ System.Globalization.CultureInfo _culture;

                /*0x23f0878*/ RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, System.Globalization.CultureInfo culture);
                /*0x23f0d34*/ bool MatchPattern(string text, int index);
                /*0x23f0e60*/ bool IsMatch(string text, int index, int beglimit, int endlimit);
                /*0x23f0ecc*/ int Scan(string text, int index, int beglimit, int endlimit);
            }

            class RegexCharClass
            {
                static /*0x0*/ string s_internalRegexIgnoreCase;
                static /*0x8*/ string s_space;
                static /*0x10*/ string s_notSpace;
                static /*0x18*/ string s_word;
                static /*0x20*/ string s_notWord;
                static /*0x28*/ string SpaceClass;
                static /*0x30*/ string NotSpaceClass;
                static /*0x38*/ string WordClass;
                static /*0x40*/ string NotWordClass;
                static /*0x48*/ string DigitClass;
                static /*0x50*/ string NotDigitClass;
                static /*0x58*/ System.Collections.Generic.Dictionary<string, string> s_definedCategories;
                static /*0x60*/ string[][] s_propTable;
                static /*0x68*/ System.Text.RegularExpressions.RegexCharClass.LowerCaseMapping[] s_lcTable;
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist;
                /*0x18*/ System.Text.StringBuilder _categories;
                /*0x20*/ bool _canonical;
                /*0x21*/ bool _negate;
                /*0x28*/ System.Text.RegularExpressions.RegexCharClass _subtractor;

                static /*0x23f3440*/ RegexCharClass();
                static /*0x23f2394*/ char SingletonChar(string set);
                static /*0x23f23ac*/ bool IsMergeable(string charClass);
                static /*0x23f24c8*/ bool IsEmpty(string charClass);
                static /*0x23f2588*/ bool IsSingleton(string set);
                static /*0x23f2694*/ bool IsSingletonInverse(string set);
                static /*0x23f2470*/ bool IsSubtraction(string charClass);
                static /*0x23f2448*/ bool IsNegated(string set);
                static /*0x23f27a4*/ bool IsECMAWordChar(char ch);
                static /*0x23f2878*/ bool IsWordChar(char ch);
                static /*0x23f2810*/ bool CharInClass(char ch, string set);
                static /*0x23f28f8*/ bool CharInClassRecursive(char ch, string set, int start);
                static /*0x23f2a20*/ bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x23f2b30*/ bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength);
                static /*0x23f2cb8*/ bool CharInCategoryGroup(char ch, System.Globalization.UnicodeCategory chcategory, string category, ref int i);
                static /*0x23f1a7c*/ string NegateCategory(string category);
                static /*0x23f2d88*/ System.Text.RegularExpressions.RegexCharClass Parse(string charClass);
                static /*0x23f2de0*/ System.Text.RegularExpressions.RegexCharClass ParseRecursive(string charClass, int start);
                static /*0x23f1b04*/ string SetFromProperty(string capname, bool invert, string pattern);
                /*0x23f11c0*/ RegexCharClass();
                /*0x23f127c*/ RegexCharClass(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, System.Text.StringBuilder categories, System.Text.RegularExpressions.RegexCharClass subtraction);
                /*0x23f12c8*/ bool get_CanMerge();
                /*0x23f12e8*/ void set_Negate(bool value);
                /*0x23f12f4*/ void AddChar(char c);
                /*0x23f141c*/ void AddCharClass(System.Text.RegularExpressions.RegexCharClass cc);
                /*0x23f1638*/ void AddSet(string set);
                /*0x23f1864*/ void AddSubtraction(System.Text.RegularExpressions.RegexCharClass sub);
                /*0x23f12fc*/ void AddRange(char first, char last);
                /*0x23f186c*/ void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern);
                /*0x23f1d68*/ void AddCategory(string category);
                /*0x23f1d84*/ void AddLowercase(System.Globalization.CultureInfo culture);
                /*0x23f1ec8*/ void AddLowercaseRange(char chMin, char chMax, System.Globalization.CultureInfo culture);
                /*0x23f20f8*/ void AddWord(bool ecma, bool negate);
                /*0x23f21ec*/ void AddSpace(bool ecma, bool negate);
                /*0x23f22e0*/ void AddDigit(bool ecma, bool negate, string pattern);
                /*0x23f1590*/ int RangeCount();
                /*0x23f3068*/ string ToStringClass();
                /*0x23f15d8*/ System.Text.RegularExpressions.RegexCharClass.SingleRange GetRangeAt(int i);
                /*0x23f3204*/ void Canonicalize();

                struct LowerCaseMapping
                {
                    /*0x10*/ char ChMin;
                    /*0x12*/ char ChMax;
                    /*0x14*/ int LcOp;
                    /*0x18*/ int Data;

                    /*0x23fb674*/ LowerCaseMapping(char chMin, char chMax, int lcOp, int data);
                }

                class SingleRangeComparer : System.Collections.Generic.IComparer<System.Text.RegularExpressions.RegexCharClass.SingleRange>
                {
                    static /*0x0*/ System.Text.RegularExpressions.RegexCharClass.SingleRangeComparer Instance;

                    static /*0x23fb6ac*/ SingleRangeComparer();
                    /*0x23fb684*/ SingleRangeComparer();
                    /*0x23fb68c*/ int Compare(System.Text.RegularExpressions.RegexCharClass.SingleRange x, System.Text.RegularExpressions.RegexCharClass.SingleRange y);
                }

                struct SingleRange
                {
                    /*0x10*/ char First;
                    /*0x12*/ char Last;

                    /*0x23fb710*/ SingleRange(char first, char last);
                }
            }

            class RegexCode
            {
                static int Onerep = 0;
                static int Notonerep = 1;
                static int Setrep = 2;
                static int Oneloop = 3;
                static int Notoneloop = 4;
                static int Setloop = 5;
                static int Onelazy = 6;
                static int Notonelazy = 7;
                static int Setlazy = 8;
                static int One = 9;
                static int Notone = 10;
                static int Set = 11;
                static int Multi = 12;
                static int Ref = 13;
                static int Bol = 14;
                static int Eol = 15;
                static int Boundary = 16;
                static int Nonboundary = 17;
                static int Beginning = 18;
                static int Start = 19;
                static int EndZ = 20;
                static int End = 21;
                static int Nothing = 22;
                static int Lazybranch = 23;
                static int Branchmark = 24;
                static int Lazybranchmark = 25;
                static int Nullcount = 26;
                static int Setcount = 27;
                static int Branchcount = 28;
                static int Lazybranchcount = 29;
                static int Nullmark = 30;
                static int Setmark = 31;
                static int Capturemark = 32;
                static int Getmark = 33;
                static int Setjump = 34;
                static int Backjump = 35;
                static int Forejump = 36;
                static int Testref = 37;
                static int Goto = 38;
                static int Prune = 39;
                static int Stop = 40;
                static int ECMABoundary = 41;
                static int NonECMABoundary = 42;
                static int Mask = 63;
                static int Rtl = 64;
                static int Back = 128;
                static int Back2 = 256;
                static int Ci = 512;
                /*0x10*/ int[] Codes;
                /*0x18*/ string[] Strings;
                /*0x20*/ int TrackCount;
                /*0x28*/ System.Collections.Hashtable Caps;
                /*0x30*/ int CapSize;
                /*0x38*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FCPrefix;
                /*0x50*/ System.Text.RegularExpressions.RegexBoyerMoore BMPrefix;
                /*0x58*/ int Anchors;
                /*0x5c*/ bool RightToLeft;

                static /*0x23fb7ec*/ bool OpcodeBacktracks(int Op);
                /*0x23fb71c*/ RegexCode(int[] codes, System.Collections.Generic.List<string> stringlist, int trackcount, System.Collections.Hashtable caps, int capsize, System.Text.RegularExpressions.RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft);
            }

            class RegexCompilationInfo
            {
            }

            struct RegexFCD
            {
                /*0x10*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack;
                /*0x18*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x38*/ bool _skipAllChildren;
                /*0x39*/ bool _skipchild;
                /*0x3a*/ bool _failed;

                static /*0x23fb8f0*/ System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(System.Text.RegularExpressions.RegexTree t);
                static /*0x23fbc98*/ System.Text.RegularExpressions.RegexPrefix Prefix(System.Text.RegularExpressions.RegexTree tree);
                static /*0x23fbf54*/ int Anchors(System.Text.RegularExpressions.RegexTree tree);
                static /*0x23fc084*/ int AnchorFromType(int type);
                /*0x23fb81c*/ RegexFCD(System.Span<int> intStack);
                /*0x23fc0f4*/ void PushInt(int i);
                /*0x23fc1a8*/ bool IntIsEmpty();
                /*0x23fc1ec*/ int PopInt();
                /*0x23fc248*/ void PushFC(System.Text.RegularExpressions.RegexFC fc);
                /*0x23fc2f0*/ bool FCIsEmpty();
                /*0x23fc340*/ System.Text.RegularExpressions.RegexFC PopFC();
                /*0x23fc3bc*/ System.Text.RegularExpressions.RegexFC TopFC();
                /*0x23fbc08*/ void Dispose();
                /*0x23fba70*/ System.Text.RegularExpressions.RegexFC RegexFCFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x23fc80c*/ void SkipChild();
                /*0x23fc420*/ void CalculateFC(int NodeType, System.Text.RegularExpressions.RegexNode node, int CurIndex);
            }

            class RegexFC
            {
                /*0x10*/ System.Text.RegularExpressions.RegexCharClass _cc;
                /*0x18*/ bool _nullable;
                /*0x19*/ bool <CaseInsensitive>k__BackingField;

                /*0x23fc818*/ RegexFC(bool nullable);
                /*0x23fc944*/ RegexFC(char ch, bool not, bool nullable, bool caseInsensitive);
                /*0x23fca38*/ RegexFC(string charClass, bool nullable, bool caseInsensitive);
                /*0x23fc898*/ bool AddFC(System.Text.RegularExpressions.RegexFC fc, bool concatenate);
                /*0x23fcacc*/ bool get_CaseInsensitive();
                /*0x23fcad4*/ void set_CaseInsensitive(bool value);
                /*0x23fbc50*/ string GetFirstChars(System.Globalization.CultureInfo culture);
            }

            class RegexInterpreter : System.Text.RegularExpressions.RegexRunner
            {
                /*0x80*/ System.Text.RegularExpressions.RegexCode _code;
                /*0x88*/ System.Globalization.CultureInfo _culture;
                /*0x90*/ int _operator;
                /*0x94*/ int _codepos;
                /*0x98*/ bool _rightToLeft;
                /*0x99*/ bool _caseInsensitive;

                /*0x23fcae0*/ RegexInterpreter(System.Text.RegularExpressions.RegexCode code, System.Globalization.CultureInfo culture);
                /*0x23fcb14*/ void InitTrackCount();
                /*0x23fcb34*/ void Advance(int i);
                /*0x23fcbb8*/ void Goto(int newpos);
                /*0x23fcc78*/ void Textto(int newpos);
                /*0x23fcc80*/ void Trackto(int newpos);
                /*0x23fcca4*/ int Textstart();
                /*0x23fccac*/ int Textpos();
                /*0x23fccb4*/ int Trackpos();
                /*0x23fccd8*/ void TrackPush();
                /*0x23fcd18*/ void TrackPush(int I1);
                /*0x23fcd74*/ void TrackPush(int I1, int I2);
                /*0x23fcdec*/ void TrackPush(int I1, int I2, int I3);
                /*0x23fce80*/ void TrackPush2(int I1);
                /*0x23fcee0*/ void TrackPush2(int I1, int I2);
                /*0x23fcf5c*/ void Backtrack();
                /*0x23fcb98*/ void SetOperator(int op);
                /*0x23fd054*/ void TrackPop();
                /*0x23fd064*/ void TrackPop(int framesize);
                /*0x23fd074*/ int TrackPeek();
                /*0x23fd0ac*/ int TrackPeek(int i);
                /*0x23fd0e8*/ void StackPush(int I1);
                /*0x23fd124*/ void StackPush(int I1, int I2);
                /*0x23fd17c*/ void StackPop();
                /*0x23fd18c*/ void StackPop(int framesize);
                /*0x23fd19c*/ int StackPeek();
                /*0x23fd1d4*/ int StackPeek(int i);
                /*0x23fd210*/ int Operator();
                /*0x23fd218*/ int Operand(int i);
                /*0x23fd25c*/ int Leftchars();
                /*0x23fd26c*/ int Rightchars();
                /*0x23fd27c*/ int Bump();
                /*0x23fd290*/ int Forwardchars();
                /*0x23fd2bc*/ char Forwardcharnext();
                /*0x23fd354*/ bool Stringmatch(string str);
                /*0x23fd4c8*/ bool Refmatch(int index, int len);
                /*0x23fd674*/ void Backwardnext();
                /*0x23fd6a4*/ char CharAt(int j);
                /*0x23fd6c0*/ bool FindFirstChar();
                /*0x23fda20*/ void Go();
            }

            class RegexMatchTimeoutException : System.TimeoutException, System.Runtime.Serialization.ISerializable
            {
                /*0x90*/ string <Input>k__BackingField;
                /*0x98*/ string <Pattern>k__BackingField;
                /*0xa0*/ System.TimeSpan <MatchTimeout>k__BackingField;

                /*0x23ff030*/ RegexMatchTimeoutException(string regexInput, string regexPattern, System.TimeSpan matchTimeout);
                /*0x23ff0fc*/ RegexMatchTimeoutException();
                /*0x23ff190*/ RegexMatchTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x23ff2c8*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x23ff39c*/ string get_Input();
                /*0x23ff3a4*/ string get_Pattern();
                /*0x23ff3ac*/ System.TimeSpan get_MatchTimeout();
            }

            class RegexNode
            {
                /*0x10*/ int NType;
                /*0x18*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> Children;
                /*0x20*/ string Str;
                /*0x28*/ char Ch;
                /*0x2c*/ int M;
                /*0x30*/ int N;
                /*0x34*/ System.Text.RegularExpressions.RegexOptions Options;
                /*0x38*/ System.Text.RegularExpressions.RegexNode Next;

                /*0x23ff3b4*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options);
                /*0x23ff3e4*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, char ch);
                /*0x23ff424*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, string str);
                /*0x23ff464*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m);
                /*0x23ff4a4*/ RegexNode(int type, System.Text.RegularExpressions.RegexOptions options, int m, int n);
                /*0x23ff4e8*/ bool UseOptionR();
                /*0x23ff4f4*/ System.Text.RegularExpressions.RegexNode ReverseLeft();
                /*0x23ff570*/ void MakeRep(int type, int min, int max);
                /*0x23ff588*/ System.Text.RegularExpressions.RegexNode Reduce();
                /*0x23fffe4*/ System.Text.RegularExpressions.RegexNode StripEnation(int emptyType);
                /*0x23ffe9c*/ System.Text.RegularExpressions.RegexNode ReduceGroup();
                /*0x23ffd10*/ System.Text.RegularExpressions.RegexNode ReduceRep();
                /*0x23ffec8*/ System.Text.RegularExpressions.RegexNode ReduceSet();
                /*0x23ff5f0*/ System.Text.RegularExpressions.RegexNode ReduceAlternation();
                /*0x23ff9a8*/ System.Text.RegularExpressions.RegexNode ReduceConcatenation();
                /*0x24000a0*/ System.Text.RegularExpressions.RegexNode MakeQuantifier(bool lazy, int min, int max);
                /*0x24001bc*/ void AddChild(System.Text.RegularExpressions.RegexNode newChild);
                /*0x23fbefc*/ System.Text.RegularExpressions.RegexNode Child(int i);
                /*0x23fbeb0*/ int ChildCount();
                /*0x24002d0*/ int Type();
            }

            enum RegexOptions
            {
                None = 0,
                IgnoreCase = 1,
                Multiline = 2,
                ExplicitCapture = 4,
                Compiled = 8,
                Singleline = 16,
                IgnorePatternWhitespace = 32,
                RightToLeft = 64,
                ECMAScript = 256,
                CultureInvariant = 512,
            }

            class RegexParser
            {
                static /*0x0*/ byte[] s_category;
                /*0x10*/ System.Text.RegularExpressions.RegexNode _stack;
                /*0x18*/ System.Text.RegularExpressions.RegexNode _group;
                /*0x20*/ System.Text.RegularExpressions.RegexNode _alternation;
                /*0x28*/ System.Text.RegularExpressions.RegexNode _concatenation;
                /*0x30*/ System.Text.RegularExpressions.RegexNode _unit;
                /*0x38*/ string _pattern;
                /*0x40*/ int _currentPos;
                /*0x48*/ System.Globalization.CultureInfo _culture;
                /*0x50*/ int _autocap;
                /*0x54*/ int _capcount;
                /*0x58*/ int _captop;
                /*0x5c*/ int _capsize;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ System.Collections.Hashtable _capnames;
                /*0x70*/ int[] _capnumlist;
                /*0x78*/ System.Collections.Generic.List<string> _capnamelist;
                /*0x80*/ System.Text.RegularExpressions.RegexOptions _options;
                /*0x88*/ System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions> _optionsStack;
                /*0x90*/ bool _ignoreNextParen;

                static /*0x2406150*/ RegexParser();
                static /*0x24002d8*/ System.Text.RegularExpressions.RegexTree Parse(string re, System.Text.RegularExpressions.RegexOptions op);
                static /*0x240110c*/ System.Text.RegularExpressions.RegexReplacement ParseReplacement(string rep, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions op);
                static /*0x2401874*/ string Escape(string input);
                static /*0x2401b04*/ string Unescape(string input);
                static /*0x240566c*/ int HexDigit(char ch);
                static /*0x2405768*/ System.Text.RegularExpressions.RegexOptions OptionFromCode(char ch);
                static /*0x240248c*/ bool IsSpecial(char ch);
                static /*0x2402254*/ bool IsStopperX(char ch);
                static /*0x2402524*/ bool IsQuantifier(char ch);
                static /*0x2404dc8*/ bool IsSpace(char ch);
                static /*0x2401a6c*/ bool IsMetachar(char ch);
                /*0x2400474*/ RegexParser(System.Globalization.CultureInfo culture);
                /*0x2400534*/ void SetPattern(string Re);
                /*0x24008d0*/ void Reset(System.Text.RegularExpressions.RegexOptions topopts);
                /*0x240095c*/ System.Text.RegularExpressions.RegexNode ScanRegex();
                /*0x2401268*/ System.Text.RegularExpressions.RegexNode ScanReplacement();
                /*0x240289c*/ System.Text.RegularExpressions.RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly);
                /*0x2402fc8*/ System.Text.RegularExpressions.RegexNode ScanGroupOpen();
                /*0x2401f0c*/ void ScanBlank();
                /*0x2403d70*/ System.Text.RegularExpressions.RegexNode ScanBackslash(bool scanOnly);
                /*0x2404ef0*/ System.Text.RegularExpressions.RegexNode ScanBasicBackslash(bool scanOnly);
                /*0x2404514*/ System.Text.RegularExpressions.RegexNode ScanDollar();
                /*0x2404a88*/ string ScanCapname();
                /*0x24054a0*/ char ScanOctal();
                /*0x2404404*/ int ScanDecimal();
                /*0x240553c*/ char ScanHex(int c);
                /*0x24056a4*/ char ScanControl();
                /*0x2405740*/ bool IsOnlyTopOption(System.Text.RegularExpressions.RegexOptions option);
                /*0x2404ccc*/ void ScanOptions();
                /*0x2401ce0*/ char ScanCharEscape();
                /*0x2404918*/ string ParseProperty();
                /*0x2404e60*/ int TypeFromCode(char ch);
                /*0x2400590*/ void CountCaptures();
                /*0x24057c8*/ void NoteCaptureSlot(int i, int pos);
                /*0x2405920*/ void NoteCaptureName(string name, int pos);
                /*0x240125c*/ void NoteCaptures(System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames);
                /*0x2405abc*/ void AssignNameSlots();
                /*0x2404c40*/ int CaptureSlotFromName(string capname);
                /*0x2404b88*/ bool IsCaptureSlot(int i);
                /*0x2404c24*/ bool IsCaptureName(string capname);
                /*0x2404b7c*/ bool UseOptionN();
                /*0x2402890*/ bool UseOptionI();
                /*0x2404254*/ bool UseOptionM();
                /*0x24042d8*/ bool UseOptionS();
                /*0x24021f0*/ bool UseOptionX();
                /*0x240490c*/ bool UseOptionE();
                /*0x24022ec*/ bool IsTrueQuantifier();
                /*0x24025bc*/ void AddConcatenate(int pos, int cch, bool isReplacement);
                /*0x2403914*/ void PushGroup();
                /*0x2403c08*/ void PopGroup();
                /*0x2403a18*/ bool EmptyStack();
                /*0x2401e60*/ void StartGroup(System.Text.RegularExpressions.RegexNode openGroup);
                /*0x2403950*/ void AddAlternate();
                /*0x24043b0*/ void AddConcatenate();
                /*0x24044d0*/ void AddConcatenate(bool lazy, int min, int max);
                /*0x2406130*/ System.Text.RegularExpressions.RegexNode Unit();
                /*0x24027d4*/ void AddUnitOne(char ch);
                /*0x24042e4*/ void AddUnitNotone(char ch);
                /*0x2402ea4*/ void AddUnitSet(string cc);
                /*0x2406138*/ void AddUnitNode(System.Text.RegularExpressions.RegexNode node);
                /*0x2404260*/ void AddUnitType(int type);
                /*0x2403ac8*/ void AddGroup();
                /*0x2402f24*/ void PushOptions();
                /*0x2403cd8*/ void PopOptions();
                /*0x24058d0*/ bool EmptyOptionsStack();
                /*0x24038b0*/ void PopKeepOptions();
                /*0x2403a28*/ System.ArgumentException MakeException(string message);
                /*0x2406140*/ int Textpos();
                /*0x2406148*/ void Textto(int pos);
                /*0x24043d8*/ char RightCharMoveRight();
                /*0x24021fc*/ void MoveRight();
                /*0x2404b6c*/ void MoveRight(int i);
                /*0x24043a0*/ void MoveLeft();
                /*0x24027b8*/ char CharAt(int i);
                /*0x2402230*/ char RightChar();
                /*0x2404b44*/ char RightChar(int i);
                /*0x240220c*/ int CharsRight();
            }

            struct RegexPrefix
            {
                static /*0x0*/ System.Text.RegularExpressions.RegexPrefix <Empty>k__BackingField;
                /*0x10*/ bool <CaseInsensitive>k__BackingField;
                /*0x18*/ string <Prefix>k__BackingField;

                static /*0x240624c*/ RegexPrefix();
                static /*0x24061ec*/ System.Text.RegularExpressions.RegexPrefix get_Empty();
                /*0x23fbc88*/ RegexPrefix(string prefix, bool ci);
                /*0x24061e4*/ bool get_CaseInsensitive();
                /*0x2406244*/ string get_Prefix();
            }

            class RegexReplacement
            {
                static int Specials = 4;
                static int LeftPortion = -1;
                static int RightPortion = -2;
                static int LastGroup = -3;
                static int WholeString = -4;
                /*0x10*/ System.Collections.Generic.List<string> _strings;
                /*0x18*/ System.Collections.Generic.List<int> _rules;
                /*0x20*/ string <Pattern>k__BackingField;

                static /*0x24062b4*/ System.Text.RegularExpressions.RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, System.Collections.Hashtable caps, int capsize, System.Collections.Hashtable capnames, System.Text.RegularExpressions.RegexOptions roptions);
                /*0x240138c*/ RegexReplacement(string rep, System.Text.RegularExpressions.RegexNode concat, System.Collections.Hashtable _caps);
                /*0x24063c8*/ string get_Pattern();
                /*0x24063d0*/ void ReplacementImpl(System.Text.StringBuilder sb, System.Text.RegularExpressions.Match match);
                /*0x2406574*/ void ReplacementImplRTL(System.Collections.Generic.List<string> al, System.Text.RegularExpressions.Match match);
                /*0x24067a4*/ string Replacement(System.Text.RegularExpressions.Match match);
                /*0x24067e8*/ string Replace(System.Text.RegularExpressions.Regex regex, string input, int count, int startat);
            }

            class RegexRunner
            {
                static int TimeoutCheckFrequency = 1000;
                /*0x10*/ int runtextbeg;
                /*0x14*/ int runtextend;
                /*0x18*/ int runtextstart;
                /*0x20*/ string runtext;
                /*0x28*/ int runtextpos;
                /*0x30*/ int[] runtrack;
                /*0x38*/ int runtrackpos;
                /*0x40*/ int[] runstack;
                /*0x48*/ int runstackpos;
                /*0x50*/ int[] runcrawl;
                /*0x58*/ int runcrawlpos;
                /*0x5c*/ int runtrackcount;
                /*0x60*/ System.Text.RegularExpressions.Match runmatch;
                /*0x68*/ System.Text.RegularExpressions.Regex runregex;
                /*0x70*/ int _timeout;
                /*0x74*/ bool _ignoreTimeout;
                /*0x78*/ int _timeoutOccursAt;
                /*0x7c*/ int _timeoutChecksToSkip;

                /*0x23fcb0c*/ RegexRunner();
                /*0x2406b88*/ System.Text.RegularExpressions.Match Scan(System.Text.RegularExpressions.Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, System.TimeSpan timeout);
                /*0x2406e8c*/ void StartTimeoutWatch();
                /*0x23fec00*/ void CheckTimeout();
                /*0x24070e0*/ void DoCheckTimeout();
                void Go();
                bool FindFirstChar();
                void InitTrackCount();
                /*0x2406ec0*/ void InitMatch();
                /*0x240709c*/ System.Text.RegularExpressions.Match TidyMatch(bool quick);
                /*0x23fcc30*/ void EnsureStorage();
                /*0x23fedfc*/ bool IsBoundary(int index, int startpos, int endpos);
                /*0x23feef4*/ bool IsECMABoundary(int index, int startpos, int endpos);
                /*0x2407254*/ void DoubleTrack();
                /*0x24071b4*/ void DoubleStack();
                /*0x24072f4*/ void DoubleCrawl();
                /*0x2407394*/ void Crawl(int i);
                /*0x24073f0*/ int Popcrawl();
                /*0x23fedd8*/ int Crawlpos();
                /*0x23fed48*/ void Capture(int capnum, int start, int end);
                /*0x23fec30*/ void TransferCapture(int capnum, int uncapnum, int start, int end);
                /*0x23feda8*/ void Uncapture();
                /*0x23fec10*/ bool IsMatched(int cap);
                /*0x23fefec*/ int MatchIndex(int cap);
                /*0x23ff00c*/ int MatchLength(int cap);
            }

            class RegexRunnerFactory
            {
                System.Text.RegularExpressions.RegexRunner CreateInstance();
            }

            class RegexTree
            {
                /*0x10*/ System.Text.RegularExpressions.RegexNode Root;
                /*0x18*/ System.Collections.Hashtable Caps;
                /*0x20*/ int[] CapNumList;
                /*0x28*/ int CapTop;
                /*0x30*/ System.Collections.Hashtable CapNames;
                /*0x38*/ string[] CapsList;
                /*0x40*/ System.Text.RegularExpressions.RegexOptions Options;

                /*0x24010a4*/ RegexTree(System.Text.RegularExpressions.RegexNode root, System.Collections.Hashtable caps, int[] capNumList, int capTop, System.Collections.Hashtable capNames, string[] capsList, System.Text.RegularExpressions.RegexOptions options);
            }

            struct RegexWriter
            {
                /*0x10*/ System.Collections.Generic.ValueListBuilder<int> _emitted;
                /*0x30*/ System.Collections.Generic.ValueListBuilder<int> _intStack;
                /*0x50*/ System.Collections.Generic.Dictionary<string, int> _stringHash;
                /*0x58*/ System.Collections.Generic.List<string> _stringTable;
                /*0x60*/ System.Collections.Hashtable _caps;
                /*0x68*/ int _trackCount;

                static /*0x2407574*/ System.Text.RegularExpressions.RegexCode Write(System.Text.RegularExpressions.RegexTree tree);
                /*0x240742c*/ RegexWriter(System.Span<int> emittedSpan, System.Span<int> intStackSpan);
                /*0x2407ad8*/ void Dispose();
                /*0x2407678*/ System.Text.RegularExpressions.RegexCode RegexCodeFromRegexTree(System.Text.RegularExpressions.RegexTree tree);
                /*0x2408688*/ void PatchJump(int offset, int jumpDest);
                /*0x24086ec*/ void Emit(int op);
                /*0x2407b2c*/ void Emit(int op, int opd1);
                /*0x24087d0*/ void Emit(int op, int opd1, int opd2);
                /*0x240897c*/ int StringCode(string str);
                /*0x2408ac8*/ int MapCapnum(int capnum);
                /*0x2407c78*/ void EmitFragment(int nodetype, System.Text.RegularExpressions.RegexNode node, int curIndex);
            }
        }
    }

    namespace CodeDom
    {
        namespace Compiler
        {
            class GeneratedCodeAttribute : System.Attribute
            {
                /*0x10*/ string tool;
                /*0x18*/ string version;

                /*0x2408b7c*/ GeneratedCodeAttribute(string tool, string version);
                /*0x2408ba8*/ string get_Tool();
                /*0x2408bb0*/ string get_Version();
            }
        }
    }

    namespace Diagnostics
    {
        class Stopwatch
        {
            static /*0x0*/ long Frequency;
            static /*0x8*/ bool IsHighResolution;
            /*0x10*/ long elapsed;
            /*0x18*/ long started;
            /*0x20*/ bool is_running;

            static /*0x2409000*/ Stopwatch();
            static /*0x2408bb8*/ long GetTimestamp();
            static /*0x2408bbc*/ System.Diagnostics.Stopwatch StartNew();
            /*0x2408c20*/ Stopwatch();
            /*0x2408c90*/ System.TimeSpan get_Elapsed();
            /*0x2408df8*/ long get_ElapsedMilliseconds();
            /*0x2408d88*/ long get_ElapsedTicks();
            /*0x2408f14*/ bool get_IsRunning();
            /*0x2408f1c*/ void Reset();
            /*0x2408c28*/ void Start();
            /*0x2408f28*/ void Stop();
            /*0x2408fa0*/ void Restart();
        }

        namespace CodeAnalysis
        {
            class ExcludeFromCodeCoverageAttribute : System.Attribute
            {
                /*0x2409058*/ ExcludeFromCodeCoverageAttribute();
            }
        }
    }

    namespace Security
    {
        namespace Authentication
        {
            class AuthenticationException : System.SystemException
            {
                /*0x2409060*/ AuthenticationException();
                /*0x24090b8*/ AuthenticationException(string message, System.Exception innerException);
                /*0x24090c0*/ AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            }

            enum SslProtocols
            {
                None = 0,
                Ssl2 = 12,
                Ssl3 = 48,
                Tls = 192,
                Tls11 = 768,
                Tls12 = 3072,
                Tls13 = 12288,
                Default = 240,
            }
        }

        namespace Cryptography
        {
            class DerSequenceReader
            {
                static /*0x0*/ System.Globalization.DateTimeFormatInfo s_validityDateTimeFormatInfo;
                static /*0x8*/ System.Text.Encoding s_utf8EncodingWithExceptionFallback;
                static /*0x10*/ System.Text.Encoding s_latin1Encoding;
                /*0x10*/ byte[] _data;
                /*0x18*/ int _end;
                /*0x1c*/ int _position;
                /*0x20*/ int <ContentLength>k__BackingField;

                static /*0x2409c78*/ string TrimTrailingNulls(string value);
                static /*0x2409dc8*/ void CheckTag(System.Security.Cryptography.DerSequenceReader.DerTag expected, byte[] data, int position);
                static /*0x2409468*/ int ScanContentLength(byte[] data, int offset, int end, ref int bytesConsumed);
                /*0x24090d0*/ DerSequenceReader(byte[] data);
                /*0x24090f4*/ DerSequenceReader(byte[] data, int offset, int length);
                /*0x2409108*/ DerSequenceReader(System.Security.Cryptography.DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length);
                /*0x24090c8*/ void set_ContentLength(int value);
                /*0x24092b8*/ bool get_HasData();
                /*0x24092c8*/ byte PeekTag();
                /*0x2409360*/ void SkipValue();
                /*0x24093b0*/ byte[] ReadNextEncodedValue();
                /*0x2409588*/ bool ReadBoolean();
                /*0x2409654*/ int ReadInteger();
                /*0x2409708*/ byte[] ReadIntegerBytes();
                /*0x24097d8*/ byte[] ReadBitString();
                /*0x2409920*/ byte[] ReadOctetString();
                /*0x240993c*/ string ReadOidAsString();
                /*0x2409bf8*/ string ReadUtf8String();
                /*0x2409cf0*/ System.Security.Cryptography.DerSequenceReader ReadCollectionWithTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x2409e60*/ System.Security.Cryptography.DerSequenceReader ReadSequence();
                /*0x2409e68*/ System.Security.Cryptography.DerSequenceReader ReadSet();
                /*0x2409e70*/ string ReadPrintableString();
                /*0x2409ef0*/ string ReadIA5String();
                /*0x2409f70*/ string ReadT61String();
                /*0x240a248*/ System.DateTime ReadX509Date();
                /*0x240a2cc*/ System.DateTime ReadUtcTime();
                /*0x240a318*/ System.DateTime ReadGeneralizedTime();
                /*0x240a5a4*/ string ReadBMPString();
                /*0x240a364*/ System.DateTime ReadTime(System.Security.Cryptography.DerSequenceReader.DerTag timeTag, string formatString);
                /*0x2409724*/ byte[] ReadContentAsBytes();
                /*0x24091fc*/ void EatTag(System.Security.Cryptography.DerSequenceReader.DerTag expected);
                /*0x240927c*/ int EatLength();

                enum DerTag
                {
                    Boolean = 1,
                    Integer = 2,
                    BitString = 3,
                    OctetString = 4,
                    Null = 5,
                    ObjectIdentifier = 6,
                    UTF8String = 12,
                    Sequence = 16,
                    Set = 17,
                    PrintableString = 19,
                    T61String = 20,
                    IA5String = 22,
                    UTCTime = 23,
                    GeneralizedTime = 24,
                    BMPString = 30,
                }

                class <>c
                {
                    static /*0x0*/ System.Security.Cryptography.DerSequenceReader.<> <>9;
                    static /*0x8*/ System.Func<System.Text.Encoding> <>9__45_0;
                    static /*0x10*/ System.Func<System.Text.Encoding> <>9__45_1;
                    static /*0x18*/ System.Func<System.Globalization.DateTimeFormatInfo> <>9__51_0;

                    static /*0x240a624*/ <>c();
                    /*0x240a688*/ <>c();
                    /*0x240a690*/ System.Text.Encoding <ReadT61String>b__45_0();
                    /*0x240a6f4*/ System.Text.Encoding <ReadT61String>b__45_1();
                    /*0x240a738*/ System.Globalization.DateTimeFormatInfo <ReadTime>b__51_0();
                }
            }

            class Oid
            {
                /*0x10*/ string _value;
                /*0x18*/ string _friendlyName;
                /*0x20*/ System.Security.Cryptography.OidGroup _group;

                static /*0x240a948*/ System.Security.Cryptography.Oid FromOidValue(string oidValue, System.Security.Cryptography.OidGroup group);
                /*0x240a804*/ Oid();
                /*0x240a80c*/ Oid(string oid);
                /*0x240a898*/ Oid(string value, string friendlyName);
                /*0x240a8c4*/ Oid(System.Security.Cryptography.Oid oid);
                /*0x240aa84*/ Oid(string value, string friendlyName, System.Security.Cryptography.OidGroup group);
                /*0x240aac0*/ string get_Value();
                /*0x240aac8*/ void set_Value(string value);
                /*0x240aad0*/ string get_FriendlyName();
            }

            class OidCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.Oid> _list;

                /*0x240ab54*/ OidCollection();
                /*0x240abd4*/ int Add(System.Security.Cryptography.Oid oid);
                /*0x240ac88*/ System.Security.Cryptography.Oid get_Item(int index);
                /*0x240ace0*/ int get_Count();
                /*0x240ad28*/ System.Security.Cryptography.OidEnumerator GetEnumerator();
                /*0x240adc4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x240adc8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x240af84*/ bool get_IsSynchronized();
                /*0x240af8c*/ object get_SyncRoot();
            }

            class OidEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Security.Cryptography.OidCollection _oids;
                /*0x18*/ int _current;

                /*0x240ad94*/ OidEnumerator(System.Security.Cryptography.OidCollection oids);
                /*0x240af90*/ System.Security.Cryptography.Oid get_Current();
                /*0x240afb0*/ object System.Collections.IEnumerator.get_Current();
                /*0x240afb4*/ bool MoveNext();
                /*0x240b004*/ void Reset();
            }

            enum OidGroup
            {
                All = 0,
                HashAlgorithm = 1,
                EncryptionAlgorithm = 2,
                PublicKeyAlgorithm = 3,
                SignatureAlgorithm = 4,
                Attribute = 5,
                ExtensionOrAttribute = 6,
                EnhancedKeyUsage = 7,
                Policy = 8,
                Template = 9,
                KeyDerivationFunction = 10,
            }

            enum AsnDecodeStatus
            {
                NotDecoded = -1,
                Ok = 0,
                BadAsn = 1,
                BadTag = 2,
                BadLength = 3,
                InformationNotAvailable = 4,
            }

            class AsnEncodedData
            {
                /*0x10*/ System.Security.Cryptography.Oid _oid;
                /*0x18*/ byte[] _raw;

                /*0x240b010*/ AsnEncodedData();
                /*0x240b018*/ AsnEncodedData(string oid, byte[] rawData);
                /*0x240b190*/ AsnEncodedData(System.Security.Cryptography.Oid oid, byte[] rawData);
                /*0x240b23c*/ AsnEncodedData(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x240b31c*/ System.Security.Cryptography.Oid get_Oid();
                /*0x240b1cc*/ void set_Oid(System.Security.Cryptography.Oid value);
                /*0x240b324*/ byte[] get_RawData();
                /*0x240b09c*/ void set_RawData(byte[] value);
                /*0x240b32c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                /*0x240b428*/ string Format(bool multiLine);
                /*0x240b5cc*/ string ToString(bool multiLine);
                /*0x240b4b8*/ string Default(bool multiLine);
                /*0x240b77c*/ string BasicConstraintsExtension(bool multiLine);
                /*0x240b888*/ string EnhancedKeyUsageExtension(bool multiLine);
                /*0x240b994*/ string KeyUsageExtension(bool multiLine);
                /*0x240baa0*/ string SubjectKeyIdentifierExtension(bool multiLine);
                /*0x240bbac*/ string SubjectAltName(bool multiLine);
                /*0x240bf6c*/ string NetscapeCertType(bool multiLine);
            }

            namespace X509Certificates
            {
                enum OpenFlags
                {
                    ReadOnly = 0,
                    ReadWrite = 1,
                    MaxAllowed = 2,
                    OpenExistingOnly = 4,
                    IncludeArchived = 8,
                }

                enum StoreLocation
                {
                    CurrentUser = 1,
                    LocalMachine = 2,
                }

                enum StoreName
                {
                    AddressBook = 1,
                    AuthRoot = 2,
                    CertificateAuthority = 3,
                    Disallowed = 4,
                    My = 5,
                    Root = 6,
                    TrustedPeople = 7,
                    TrustedPublisher = 8,
                }

                enum X500DistinguishedNameFlags
                {
                    None = 0,
                    Reversed = 1,
                    UseSemicolons = 16,
                    DoNotUsePlusSign = 32,
                    DoNotUseQuotes = 64,
                    UseCommas = 128,
                    UseNewLines = 256,
                    UseUTF8Encoding = 4096,
                    UseT61Encoding = 8192,
                    ForceUTF8Encoding = 16384,
                }

                enum X509ChainStatusFlags
                {
                    NoError = 0,
                    NotTimeValid = 1,
                    NotTimeNested = 2,
                    Revoked = 4,
                    NotSignatureValid = 8,
                    NotValidForUsage = 16,
                    UntrustedRoot = 32,
                    RevocationStatusUnknown = 64,
                    Cyclic = 128,
                    InvalidExtension = 256,
                    InvalidPolicyConstraints = 512,
                    InvalidBasicConstraints = 1024,
                    InvalidNameConstraints = 2048,
                    HasNotSupportedNameConstraint = 4096,
                    HasNotDefinedNameConstraint = 8192,
                    HasNotPermittedNameConstraint = 16384,
                    HasExcludedNameConstraint = 32768,
                    PartialChain = 65536,
                    CtlNotTimeValid = 131072,
                    CtlNotSignatureValid = 262144,
                    CtlNotValidForUsage = 524288,
                    OfflineRevocation = 16777216,
                    NoIssuanceChainPolicy = 33554432,
                    ExplicitDistrust = 67108864,
                    HasNotSupportedCriticalExtension = 134217728,
                    HasWeakSignature = 1048576,
                }

                enum X509FindType
                {
                    FindByThumbprint = 0,
                    FindBySubjectName = 1,
                    FindBySubjectDistinguishedName = 2,
                    FindByIssuerName = 3,
                    FindByIssuerDistinguishedName = 4,
                    FindBySerialNumber = 5,
                    FindByTimeValid = 6,
                    FindByTimeNotYetValid = 7,
                    FindByTimeExpired = 8,
                    FindByTemplateName = 9,
                    FindByApplicationPolicy = 10,
                    FindByCertificatePolicy = 11,
                    FindByExtension = 12,
                    FindByKeyUsage = 13,
                    FindBySubjectKeyIdentifier = 14,
                }

                enum X509KeyUsageFlags
                {
                    None = 0,
                    EncipherOnly = 1,
                    CrlSign = 2,
                    KeyCertSign = 4,
                    KeyAgreement = 8,
                    DataEncipherment = 16,
                    KeyEncipherment = 32,
                    NonRepudiation = 64,
                    DigitalSignature = 128,
                    DecipherOnly = 32768,
                }

                enum X509NameType
                {
                    SimpleName = 0,
                    EmailName = 1,
                    UpnName = 2,
                    DnsName = 3,
                    DnsFromAlternativeName = 4,
                    UrlName = 5,
                }

                enum X509RevocationFlag
                {
                    EndCertificateOnly = 0,
                    EntireChain = 1,
                    ExcludeRoot = 2,
                }

                enum X509RevocationMode
                {
                    NoCheck = 0,
                    Online = 1,
                    Offline = 2,
                }

                enum X509SubjectKeyIdentifierHashAlgorithm
                {
                    Sha1 = 0,
                    ShortSha1 = 1,
                    CapiSha1 = 2,
                }

                enum X509VerificationFlags
                {
                    NoFlag = 0,
                    IgnoreNotTimeValid = 1,
                    IgnoreCtlNotTimeValid = 2,
                    IgnoreNotTimeNested = 4,
                    IgnoreInvalidBasicConstraints = 8,
                    AllowUnknownCertificateAuthority = 16,
                    IgnoreWrongUsage = 32,
                    IgnoreInvalidName = 64,
                    IgnoreInvalidPolicy = 128,
                    IgnoreEndRevocationUnknown = 256,
                    IgnoreCtlSignerRevocationUnknown = 512,
                    IgnoreCertificateAuthorityRevocationUnknown = 1024,
                    IgnoreRootRevocationUnknown = 2048,
                    AllFlags = 4095,
                }

                class PublicKey
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Security.Cryptography.AsnEncodedData _keyValue;
                    /*0x18*/ System.Security.Cryptography.AsnEncodedData _params;
                    /*0x20*/ System.Security.Cryptography.Oid _oid;

                    static /*0x240d288*/ PublicKey();
                    static /*0x240d1f4*/ byte[] GetUnsignedBigInteger(byte[] integer);
                    static /*0x240cd40*/ System.Security.Cryptography.DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters);
                    static /*0x240c988*/ System.Security.Cryptography.RSA DecodeRSA(byte[] rawPublicKey);
                    /*0x240c660*/ PublicKey(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedData parameters, System.Security.Cryptography.AsnEncodedData keyValue);
                    /*0x240c7d4*/ System.Security.Cryptography.AsnEncodedData get_EncodedKeyValue();
                    /*0x240c7dc*/ System.Security.Cryptography.AsnEncodedData get_EncodedParameters();
                    /*0x240c7e4*/ System.Security.Cryptography.AsymmetricAlgorithm get_Key();
                    /*0x240d1ec*/ System.Security.Cryptography.Oid get_Oid();
                }

                class X500DistinguishedName : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ string name;
                    /*0x28*/ byte[] canonEncoding;

                    static /*0x240d658*/ string GetSeparator(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    static /*0x240d728*/ string Canonize(string s);
                    static /*0x240d8f4*/ bool AreEqual(System.Security.Cryptography.X509Certificates.X500DistinguishedName name1, System.Security.Cryptography.X509Certificates.X500DistinguishedName name2);
                    /*0x240d2f0*/ X500DistinguishedName(byte[] encodedDistinguishedName);
                    /*0x240d4f8*/ string get_Name();
                    /*0x240d500*/ string Decode(System.Security.Cryptography.X509Certificates.X500DistinguishedNameFlags flag);
                    /*0x240d6cc*/ string Format(bool multiLine);
                    /*0x240d400*/ void DecodeRawData();
                }

                class X509BasicConstraintsExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.19";
                    static string friendlyName = "Basic Constraints";
                    /*0x21*/ bool _certificateAuthority;
                    /*0x22*/ bool _hasPathLengthConstraint;
                    /*0x24*/ int _pathLengthConstraint;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x240dae8*/ X509BasicConstraintsExtension();
                    /*0x240c300*/ X509BasicConstraintsExtension(System.Security.Cryptography.AsnEncodedData encodedBasicConstraints, bool critical);
                    /*0x240dd5c*/ X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical);
                    /*0x240dff4*/ bool get_CertificateAuthority();
                    /*0x240e060*/ bool get_HasPathLengthConstraint();
                    /*0x240e0cc*/ int get_PathLengthConstraint();
                    /*0x240e138*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x240db98*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x240de9c*/ byte[] Encode();
                    /*0x240e314*/ string ToString(bool multiLine);
                }

                class X509Certificate2 : System.Security.Cryptography.X509Certificates.X509Certificate
                {
                    /*0x60*/ byte[] lazyRawData;
                    /*0x68*/ System.Security.Cryptography.Oid lazySignatureAlgorithm;
                    /*0x70*/ int lazyVersion;
                    /*0x78*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName lazySubjectName;
                    /*0x80*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName lazyIssuerName;
                    /*0x88*/ System.Security.Cryptography.X509Certificates.PublicKey lazyPublicKey;
                    /*0x90*/ System.Security.Cryptography.AsymmetricAlgorithm lazyPrivateKey;
                    /*0x98*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection lazyExtensions;

                    static /*0x240f530*/ System.Security.Cryptography.X509Certificates.X509ContentType GetCertContentType(byte[] rawData);
                    static /*0x240ede4*/ System.Security.Cryptography.X509Certificates.X509Extension CreateCustomExtensionIfAny(System.Security.Cryptography.Oid oid);
                    /*0x240e710*/ X509Certificate2();
                    /*0x240e718*/ X509Certificate2(byte[] rawData);
                    /*0x240e8e0*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate2Impl impl);
                    /*0x240e8e8*/ X509Certificate2(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
                    /*0x240e8f0*/ X509Certificate2(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    /*0x240e6b8*/ void Reset();
                    /*0x240e938*/ System.Security.Cryptography.X509Certificates.X509ExtensionCollection get_Extensions();
                    /*0x240f02c*/ bool get_HasPrivateKey();
                    /*0x240f060*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x240f1bc*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x240f218*/ System.DateTime get_NotAfter();
                    /*0x240f220*/ System.DateTime get_NotBefore();
                    /*0x240f228*/ System.Security.Cryptography.X509Certificates.PublicKey get_PublicKey();
                    /*0x240f384*/ byte[] get_RawData();
                    /*0x240f3e4*/ string get_SerialNumber();
                    /*0x240f3f4*/ System.Security.Cryptography.Oid get_SignatureAlgorithm();
                    /*0x240f458*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x240f4b4*/ string get_Thumbprint();
                    /*0x240f4d4*/ int get_Version();
                    /*0x240f5cc*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x240f608*/ string ToString();
                    /*0x240f614*/ string ToString(bool verbose);
                    /*0x24106a4*/ void Import(byte[] rawData);
                    /*0x24106ac*/ void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x24106b4*/ void Import(byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x24106bc*/ void Import(string fileName);
                    /*0x24106c4*/ void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x24106cc*/ void Import(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x24106d4*/ bool Verify();
                    /*0x240ed58*/ System.Security.Cryptography.X509Certificates.X509Certificate2Impl get_Impl();
                }

                class X509Certificate2Collection : System.Security.Cryptography.X509Certificates.X509CertificateCollection
                {
                    static /*0x0*/ string[] newline_split;

                    static /*0x2412a60*/ X509Certificate2Collection();
                    /*0x24108f8*/ X509Certificate2Collection();
                    /*0x2410908*/ X509Certificate2Collection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x24109a8*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Item(int index);
                    /*0x2410ad4*/ int Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2410934*/ void AddRange(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates);
                    /*0x2410b48*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2410ecc*/ string GetKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 x);
                    /*0x241178c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection Find(System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, bool validOnly);
                    /*0x241294c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator GetEnumerator();
                }

                class X509Certificate2Enumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x24129ac*/ X509Certificate2Enumerator(System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection);
                    /*0x2412b14*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Current();
                    /*0x2412c04*/ bool MoveNext();
                    /*0x2412ca4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2412d48*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x2412de8*/ void System.Collections.IEnumerator.Reset();
                }

                class X509Certificate2Impl : System.Security.Cryptography.X509Certificates.X509CertificateImpl
                {
                    /*0x2412f9c*/ X509Certificate2Impl();
                    System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    string get_SignatureAlgorithm();
                    System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    int get_Version();
                    System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                    /*0x2412e8c*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl CopyWithPrivateKey(System.Security.Cryptography.RSA privateKey);
                    /*0x2412f38*/ System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate();
                }

                class X509Certificate2ImplMono : System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix
                {
                    static /*0x0*/ string empty_error;
                    static /*0x8*/ byte[] signedData;
                    /*0xb0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts;
                    /*0xb8*/ Mono.Security.X509.X509Certificate _cert;

                    static /*0x2414500*/ X509Certificate2ImplMono();
                    /*0x2413044*/ X509Certificate2ImplMono(Mono.Security.X509.X509Certificate cert);
                    /*0x2413074*/ X509Certificate2ImplMono(System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono other);
                    /*0x2413118*/ X509Certificate2ImplMono(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags);
                    /*0x2412fa4*/ bool get_IsValid();
                    /*0x2412fb4*/ nint get_Handle();
                    /*0x2412ffc*/ nint GetNativeAppleCertificate();
                    /*0x24132cc*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl Clone();
                    /*0x2413338*/ Mono.Security.X509.X509Certificate get_Cert();
                    /*0x2413354*/ byte[] GetRawCertData();
                    /*0x241338c*/ bool Equals(System.Security.Cryptography.X509Certificates.X509CertificateImpl other, ref bool result);
                    /*0x2413398*/ bool get_HasPrivateKey();
                    /*0x24133bc*/ System.Security.Cryptography.AsymmetricAlgorithm get_PrivateKey();
                    /*0x24137f0*/ void set_PrivateKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                    /*0x2413988*/ System.Security.Cryptography.RSA GetRSAPrivateKey();
                    /*0x2413a14*/ System.Security.Cryptography.DSA GetDSAPrivateKey();
                    /*0x2413274*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x2413aa0*/ Mono.Security.X509.X509Certificate ImportPkcs12(byte[] rawData, string password);
                    /*0x24143b8*/ bool Verify(System.Security.Cryptography.X509Certificates.X509Certificate2 thisCertificate);
                    /*0x24144f0*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection get_IntermediateCertificates();
                    /*0x24144f8*/ Mono.Security.X509.X509Certificate get_MonoCertificate();
                }

                class X509Certificate2ImplUnix : System.Security.Cryptography.X509Certificates.X509Certificate2Impl
                {
                    /*0x10*/ bool readCertData;
                    /*0x18*/ Internal.Cryptography.Pal.CertificateData certData;

                    /*0x241306c*/ X509Certificate2ImplUnix();
                    /*0x24145c0*/ void EnsureCertData();
                    byte[] GetRawCertData();
                    /*0x2414640*/ string get_KeyAlgorithm();
                    /*0x2414658*/ byte[] get_KeyAlgorithmParameters();
                    /*0x2414670*/ byte[] get_PublicKeyValue();
                    /*0x2414688*/ byte[] get_SerialNumber();
                    /*0x24146a0*/ string get_SignatureAlgorithm();
                    /*0x24146b8*/ int get_Version();
                    /*0x24146d4*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_SubjectName();
                    /*0x24146ec*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName get_IssuerName();
                    /*0x2414704*/ string get_Subject();
                    /*0x241472c*/ string get_Issuer();
                    /*0x2414754*/ string get_LegacySubject();
                    /*0x241477c*/ string get_LegacyIssuer();
                    /*0x24147a4*/ byte[] get_RawData();
                    /*0x24147bc*/ byte[] get_Thumbprint();
                    /*0x2414950*/ string GetNameInfo(System.Security.Cryptography.X509Certificates.X509NameType nameType, bool forIssuer);
                    /*0x2414984*/ System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions();
                    /*0x241499c*/ System.DateTime get_NotAfter();
                    /*0x24149b8*/ System.DateTime get_NotBefore();
                    /*0x24149d4*/ void AppendPrivateKeyInfo(System.Text.StringBuilder sb);
                    /*0x2414a68*/ byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x2414b70*/ byte[] ExportPkcs12(Microsoft.Win32.SafeHandles.SafePasswordHandle password);
                    /*0x2414bc0*/ byte[] ExportPkcs12(string password);
                }

                class X509CertificateCollection : System.Collections.CollectionBase
                {
                    /*0x2410900*/ X509CertificateCollection();
                    /*0x2415010*/ X509CertificateCollection(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x2415110*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Item(int index);
                    /*0x241503c*/ void AddRange(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                    /*0x24151a8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                    /*0x24152bc*/ int GetHashCode();

                    class X509CertificateEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.IEnumerator enumerator;

                        /*0x2415208*/ X509CertificateEnumerator(System.Security.Cryptography.X509Certificates.X509CertificateCollection mappings);
                        /*0x24152dc*/ System.Security.Cryptography.X509Certificates.X509Certificate get_Current();
                        /*0x24153cc*/ object System.Collections.IEnumerator.get_Current();
                        /*0x2415470*/ bool System.Collections.IEnumerator.MoveNext();
                        /*0x2415510*/ void System.Collections.IEnumerator.Reset();
                        /*0x24155b4*/ bool MoveNext();
                    }
                }

                class X509CertificateImplCollection : System.IDisposable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list;

                    /*0x2414264*/ X509CertificateImplCollection();
                    /*0x2415654*/ X509CertificateImplCollection(System.Security.Cryptography.X509Certificates.X509CertificateImplCollection other);
                    /*0x2414fc8*/ int get_Count();
                    /*0x2414f70*/ System.Security.Cryptography.X509Certificates.X509CertificateImpl get_Item(int index);
                    /*0x24142e4*/ void Add(System.Security.Cryptography.X509Certificates.X509CertificateImpl impl, bool takeOwnership);
                    /*0x24130b8*/ System.Security.Cryptography.X509Certificates.X509CertificateImplCollection Clone();
                    /*0x2415884*/ void Dispose();
                    /*0x24158f0*/ void Dispose(bool disposing);
                    /*0x2415b10*/ void Finalize();
                }

                class X509Chain : System.IDisposable
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainImpl impl;

                    static /*0x241444c*/ System.Security.Cryptography.X509Certificates.X509Chain Create();
                    /*0x2415c40*/ X509Chain();
                    /*0x2415c64*/ X509Chain(bool useMachineContext);
                    /*0x2415cf4*/ X509Chain(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    /*0x2415d24*/ X509Chain(nint chainContext);
                    /*0x2415bb0*/ System.Security.Cryptography.X509Certificates.X509ChainImpl get_Impl();
                    /*0x2415c0c*/ bool get_IsValid();
                    /*0x2415c38*/ void ThrowIfContextInvalid();
                    /*0x2415d6c*/ nint get_ChainContext();
                    /*0x2415df0*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x2415e1c*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x2415e48*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    /*0x2415e84*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainStatus();
                    /*0x2415eb0*/ Microsoft.Win32.SafeHandles.SafeX509ChainHandle get_SafeHandle();
                    /*0x24144b4*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2415ef0*/ void Reset();
                    /*0x2415f20*/ void Dispose();
                    /*0x2415f8c*/ void Dispose(bool disposing);
                    /*0x241601c*/ void Finalize();
                }

                class X509ChainElement
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509Certificate2 certificate;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x20*/ string info;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags compressed_status_flags;

                    /*0x24160bc*/ X509ChainElement(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2416128*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_Certificate();
                    /*0x2416130*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainElementStatus();
                    /*0x2416138*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_StatusFlags();
                    /*0x2416140*/ void set_StatusFlags(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x2416148*/ int Count(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x241616c*/ void Set(System.Security.Cryptography.X509Certificates.X509ChainStatus[] status, ref int position, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags, System.Security.Cryptography.X509Certificates.X509ChainStatusFlags mask);
                    /*0x2416378*/ void UncompressFlags();
                }

                class X509ChainElementCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.ArrayList _list;

                    /*0x24165c0*/ X509ChainElementCollection();
                    /*0x241662c*/ int get_Count();
                    /*0x2416650*/ bool get_IsSynchronized();
                    /*0x2416674*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Item(int index);
                    /*0x241670c*/ object get_SyncRoot();
                    /*0x2416730*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x2416754*/ System.Security.Cryptography.X509Certificates.X509ChainElementEnumerator GetEnumerator();
                    /*0x241686c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x24168d0*/ void Add(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2416954*/ void Clear();
                    /*0x2416978*/ bool Contains(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                }

                class X509ChainElementEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x24167b8*/ X509ChainElementEnumerator(System.Collections.IEnumerable enumerable);
                    /*0x2416a88*/ System.Security.Cryptography.X509Certificates.X509ChainElement get_Current();
                    /*0x2416b78*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2416c1c*/ bool MoveNext();
                    /*0x2416cbc*/ void Reset();
                }

                class X509ChainImpl : System.IDisposable
                {
                    /*0x2416ecc*/ X509ChainImpl();
                    bool get_IsValid();
                    nint get_Handle();
                    /*0x2416d60*/ void ThrowIfContextInvalid();
                    System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainStatus();
                    bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags errorCode);
                    void Reset();
                    /*0x2415fac*/ void Dispose();
                    /*0x2416e24*/ void Dispose(bool disposing);
                    /*0x2416e28*/ void Finalize();
                }

                class X509ChainImplMono : System.Security.Cryptography.X509Certificates.X509ChainImpl
                {
                    static /*0x0*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] Empty;
                    /*0x10*/ System.Security.Cryptography.X509Certificates.StoreLocation location;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy policy;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] status;
                    /*0x30*/ int max_path_length;
                    /*0x38*/ System.Security.Cryptography.X509Certificates.X500DistinguishedName working_issuer_name;
                    /*0x40*/ System.Security.Cryptography.AsymmetricAlgorithm working_public_key;
                    /*0x48*/ System.Security.Cryptography.X509Certificates.X509ChainElement bce_restriction;
                    /*0x50*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection roots;
                    /*0x58*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection cas;
                    /*0x60*/ System.Security.Cryptography.X509Certificates.X509Store root_store;
                    /*0x68*/ System.Security.Cryptography.X509Certificates.X509Store ca_store;
                    /*0x70*/ System.Security.Cryptography.X509Certificates.X509Store user_root_store;
                    /*0x78*/ System.Security.Cryptography.X509Certificates.X509Store user_ca_store;
                    /*0x80*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection collection;

                    static /*0x241a540*/ X509ChainImplMono();
                    static /*0x2418ad8*/ string GetAuthorityKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x24196bc*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Crl crl);
                    static /*0x2419560*/ string GetAuthorityKeyIdentifier(Mono.Security.X509.X509Extension ext);
                    static /*0x241a1ac*/ Mono.Security.X509.X509Crl CheckCrls(string subject, string ski, Mono.Security.X509.X509Store store);
                    /*0x2416ed4*/ X509ChainImplMono(bool useMachineContext);
                    /*0x2416fa8*/ bool get_IsValid();
                    /*0x2416fb0*/ nint get_Handle();
                    /*0x2416ff8*/ System.Security.Cryptography.X509Certificates.X509ChainElementCollection get_ChainElements();
                    /*0x2417000*/ System.Security.Cryptography.X509Certificates.X509ChainPolicy get_ChainPolicy();
                    /*0x2417008*/ void set_ChainPolicy(System.Security.Cryptography.X509Certificates.X509ChainPolicy value);
                    /*0x2417010*/ System.Security.Cryptography.X509Certificates.X509ChainStatus[] get_ChainStatus();
                    /*0x2417074*/ void AddStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags error);
                    /*0x2417078*/ bool Build(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2417854*/ void Reset();
                    /*0x241796c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Roots();
                    /*0x2417c84*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateAuthorities();
                    /*0x2417a24*/ System.Security.Cryptography.X509Certificates.X509Store get_LMRootStore();
                    /*0x2417b10*/ System.Security.Cryptography.X509Certificates.X509Store get_UserRootStore();
                    /*0x2417d3c*/ System.Security.Cryptography.X509Certificates.X509Store get_LMCAStore();
                    /*0x2417e28*/ System.Security.Cryptography.X509Certificates.X509Store get_UserCAStore();
                    /*0x241843c*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_CertificateCollection();
                    /*0x2417638*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags BuildChainFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x241894c*/ System.Security.Cryptography.X509Certificates.X509Certificate2 SelectBestFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2 child, System.Security.Cryptography.X509Certificates.X509Certificate2Collection c);
                    /*0x2418770*/ System.Security.Cryptography.X509Certificates.X509Certificate2 FindParent(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2418884*/ bool IsChainComplete(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2418c1c*/ bool IsSelfIssued(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x2417720*/ void ValidateChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x2418c64*/ void Process(int n);
                    /*0x2418f04*/ void PrepareForNextCertificate(int n);
                    /*0x24192e8*/ void WrapUp();
                    /*0x2419478*/ void ProcessCertificateExtensions(System.Security.Cryptography.X509Certificates.X509ChainElement element);
                    /*0x2419440*/ bool IsSignedWith(System.Security.Cryptography.X509Certificates.X509Certificate2 signed, System.Security.Cryptography.AsymmetricAlgorithm pubkey);
                    /*0x2418b6c*/ string GetSubjectKeyIdentifier(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    /*0x24190f8*/ void CheckRevocationOnChain(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x2419748*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, int ca, bool online);
                    /*0x2419814*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags CheckRevocation(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Cryptography.X509Certificates.X509Certificate2 ca_cert, bool online);
                    /*0x24199e0*/ Mono.Security.X509.X509Crl FindCrl(System.Security.Cryptography.X509Certificates.X509Certificate2 caCertificate);
                    /*0x2419e64*/ bool ProcessCrlExtensions(Mono.Security.X509.X509Crl crl);
                    /*0x2419b54*/ bool ProcessCrlEntryExtensions(Mono.Security.X509.X509Crl.X509CrlEntry entry);
                }

                class X509ChainPolicy
                {
                    /*0x10*/ System.Security.Cryptography.OidCollection apps;
                    /*0x18*/ System.Security.Cryptography.OidCollection cert;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection store;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection store2;
                    /*0x30*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag rflag;
                    /*0x34*/ System.Security.Cryptography.X509Certificates.X509RevocationMode mode;
                    /*0x38*/ System.TimeSpan timeout;
                    /*0x40*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags vflags;
                    /*0x48*/ System.DateTime vtime;

                    /*0x2416f8c*/ X509ChainPolicy();
                    /*0x2418504*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_ExtraStore();
                    /*0x241a69c*/ System.Security.Cryptography.X509Certificates.X509RevocationFlag get_RevocationFlag();
                    /*0x241a6a4*/ System.Security.Cryptography.X509Certificates.X509RevocationMode get_RevocationMode();
                    /*0x241a6ac*/ void set_RevocationMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                    /*0x241a710*/ System.Security.Cryptography.X509Certificates.X509VerificationFlags get_VerificationFlags();
                    /*0x241a718*/ void set_VerificationFlags(System.Security.Cryptography.X509Certificates.X509VerificationFlags value);
                    /*0x241a77c*/ System.DateTime get_VerificationTime();
                    /*0x241a5a8*/ void Reset();
                }

                struct X509ChainStatus
                {
                    /*0x10*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags status;
                    /*0x18*/ string info;

                    static /*0x24161e0*/ string GetInformation(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flags);
                    /*0x2417834*/ X509ChainStatus(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags flag);
                    /*0x241a784*/ System.Security.Cryptography.X509Certificates.X509ChainStatusFlags get_Status();
                    /*0x241a78c*/ void set_Status(System.Security.Cryptography.X509Certificates.X509ChainStatusFlags value);
                    /*0x241a794*/ void set_StatusInformation(string value);
                }

                class X509EnhancedKeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    /*0x28*/ System.Security.Cryptography.OidCollection _enhKeyUsage;
                    /*0x30*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x24107a8*/ X509EnhancedKeyUsageExtension();
                    /*0x240c3d8*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedEnhancedKeyUsages, bool critical);
                    /*0x241a9fc*/ X509EnhancedKeyUsageExtension(System.Security.Cryptography.OidCollection enhancedKeyUsages, bool critical);
                    /*0x241ac3c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x241a79c*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x241ab84*/ byte[] Encode();
                    /*0x241ae18*/ string ToString(bool multiLine);
                }

                class X509Extension : System.Security.Cryptography.AsnEncodedData
                {
                    /*0x20*/ bool _critical;

                    /*0x240db90*/ X509Extension();
                    /*0x241b0e4*/ X509Extension(string oid, byte[] rawData, bool critical);
                    /*0x241b108*/ bool get_Critical();
                    /*0x241b110*/ void set_Critical(bool value);
                    /*0x241b11c*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x240e5a4*/ string FormatUnkownData(byte[] data);
                }

                class X509ExtensionCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    static /*0x0*/ byte[] Empty;
                    /*0x10*/ System.Collections.ArrayList _list;

                    static /*0x241b41c*/ X509ExtensionCollection();
                    /*0x240ecec*/ X509ExtensionCollection();
                    /*0x241048c*/ int get_Count();
                    /*0x241b248*/ bool get_IsSynchronized();
                    /*0x241b26c*/ object get_SyncRoot();
                    /*0x2410f8c*/ System.Security.Cryptography.X509Certificates.X509Extension get_Item(string oid);
                    /*0x240efb8*/ int Add(System.Security.Cryptography.X509Certificates.X509Extension extension);
                    /*0x241b270*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x24104b0*/ System.Security.Cryptography.X509Certificates.X509ExtensionEnumerator GetEnumerator();
                    /*0x241b3b8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class X509ExtensionEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x241b374*/ X509ExtensionEnumerator(System.Collections.ArrayList list);
                    /*0x2410514*/ System.Security.Cryptography.X509Certificates.X509Extension get_Current();
                    /*0x241b484*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2410604*/ bool MoveNext();
                    /*0x241b528*/ void Reset();
                }

                class X509Helper2
                {
                    static /*0x2419374*/ Mono.Security.X509.X509Certificate GetMonoCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
                    static /*0x2415c94*/ System.Security.Cryptography.X509Certificates.X509ChainImpl CreateChainImpl(bool useMachineContext);
                    static /*0x2415c24*/ bool IsValid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x2415bcc*/ void ThrowIfContextInvalid(System.Security.Cryptography.X509Certificates.X509ChainImpl impl);
                    static /*0x2416d9c*/ System.Exception GetInvalidChainContextException();
                }

                class X509KeyUsageExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.15";
                    static string friendlyName = "Key Usage";
                    static System.Security.Cryptography.X509Certificates.X509KeyUsageFlags all = 33023;
                    /*0x24*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags _keyUsages;
                    /*0x28*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    /*0x2410700*/ X509KeyUsageExtension();
                    /*0x240c4b0*/ X509KeyUsageExtension(System.Security.Cryptography.AsnEncodedData encodedKeyUsage, bool critical);
                    /*0x241b780*/ X509KeyUsageExtension(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags keyUsages, bool critical);
                    /*0x24128e0*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags get_KeyUsages();
                    /*0x241b9d8*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x241b860*/ System.Security.Cryptography.X509Certificates.X509KeyUsageFlags GetValidFlags(System.Security.Cryptography.X509Certificates.X509KeyUsageFlags flags);
                    /*0x241b5cc*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x241b870*/ byte[] Encode();
                    /*0x241bbb4*/ string ToString(bool multiLine);
                }

                class X509Store : System.IDisposable
                {
                    /*0x10*/ string _name;
                    /*0x18*/ System.Security.Cryptography.X509Certificates.StoreLocation _location;
                    /*0x20*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection list;
                    /*0x28*/ System.Security.Cryptography.X509Certificates.OpenFlags _flags;
                    /*0x30*/ Mono.Security.X509.X509Store store;

                    /*0x2417f14*/ X509Store(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation);
                    /*0x2417bfc*/ System.Security.Cryptography.X509Certificates.X509Certificate2Collection get_Certificates();
                    /*0x241c0e4*/ Mono.Security.X509.X509Stores get_Factory();
                    /*0x241c100*/ Mono.Security.X509.X509Store get_Store();
                    /*0x2417950*/ void Close();
                    /*0x241c108*/ void Dispose();
                    /*0x241804c*/ void Open(System.Security.Cryptography.X509Certificates.OpenFlags flags);
                }

                class X509SubjectKeyIdentifierExtension : System.Security.Cryptography.X509Certificates.X509Extension
                {
                    static string oid = "2.5.29.14";
                    static string friendlyName = "Subject Key Identifier";
                    /*0x28*/ byte[] _subjectKeyIdentifier;
                    /*0x30*/ string _ski;
                    /*0x38*/ System.Security.Cryptography.AsnDecodeStatus _status;

                    static /*0x241c904*/ byte FromHexChar(char c);
                    static /*0x241c94c*/ byte FromHexChars(char c1, char c2);
                    static /*0x241c62c*/ byte[] FromHex(string hex);
                    /*0x2410850*/ X509SubjectKeyIdentifierExtension();
                    /*0x240c588*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.AsnEncodedData encodedSubjectKeyIdentifier, bool critical);
                    /*0x241c288*/ X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical);
                    /*0x241c4bc*/ X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical);
                    /*0x241c71c*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, bool critical);
                    /*0x2411338*/ X509SubjectKeyIdentifierExtension(System.Security.Cryptography.X509Certificates.PublicKey key, System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical);
                    /*0x2411704*/ string get_SubjectKeyIdentifier();
                    /*0x241c728*/ void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData);
                    /*0x241c124*/ System.Security.Cryptography.AsnDecodeStatus Decode(byte[] extension);
                    /*0x241c448*/ byte[] Encode();
                    /*0x241c9e8*/ string ToString(bool multiLine);
                }
            }
        }
    }

    namespace Net
    {
        class ContextAwareResult : System.Net.LazyAsyncResult
        {
            /*0x40*/ System.Threading.ExecutionContext _context;
            /*0x48*/ object _lock;
            /*0x50*/ System.Net.ContextAwareResult.StateFlags _flags;

            /*0x241cc1c*/ ContextAwareResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x241cc24*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x241cc74*/ ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x241cc14*/ void SafeCaptureIdentity();
            /*0x241cc18*/ void CleanupInternal();
            /*0x241ccec*/ object StartPostingAsyncOp();
            /*0x241ccf4*/ object StartPostingAsyncOp(bool lockCapture);
            /*0x241cec0*/ bool FinishPostingAsyncOp();
            /*0x241d2dc*/ void Cleanup();
            /*0x241cf04*/ bool CaptureOrComplete(ref System.Threading.ExecutionContext cachedContext, bool returnContext);
            /*0x241d5a0*/ void Complete(nint userToken);
            /*0x241d888*/ void CompleteCallback();

            enum StateFlags
            {
                None = 0,
                CaptureIdentity = 1,
                CaptureContext = 2,
                ThreadSafeContextCopy = 4,
                PostBlockStarted = 8,
                PostBlockFinished = 16,
            }

            class <>c
            {
                static /*0x0*/ System.Net.ContextAwareResult.<> <>9;
                static /*0x8*/ System.Threading.ContextCallback <>9__17_0;

                static /*0x241d958*/ <>c();
                /*0x241d9bc*/ <>c();
                /*0x241d9c4*/ void <Complete>b__17_0(object s);
            }
        }

        class HttpStatusDescription
        {
            static /*0x241da44*/ string Get(System.Net.HttpStatusCode code);
            static /*0x241da48*/ string Get(int code);
        }

        class HttpValidationHelpers
        {
            static /*0x0*/ char[] s_httpTrimCharacters;

            static /*0x241e3cc*/ HttpValidationHelpers();
            static /*0x241e0e0*/ string CheckBadHeaderValueChars(string value);
            static /*0x241e2cc*/ bool IsInvalidMethodOrHeaderString(string stringValue);
        }

        class NetEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Net.NetEventSource Log;

            static /*0x241f8a8*/ NetEventSource();
            static /*0x241e460*/ void Enter(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x241e9fc*/ void Enter(object thisOrContextObject, object arg0, string memberName);
            static /*0x241eecc*/ void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName);
            static /*0x241efe8*/ void Exit(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x241f154*/ void Exit(object thisOrContextObject, object arg0, string memberName);
            static /*0x241d3e0*/ void Info(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x241d4d0*/ void Info(object thisOrContextObject, object message, string memberName);
            static /*0x241f2a0*/ void Error(object thisOrContextObject, object message, string memberName);
            static /*0x241f3ec*/ void Fail(object thisOrContextObject, System.FormattableString formattableString, string memberName);
            static /*0x241cdf0*/ void Fail(object thisOrContextObject, object message, string memberName);
            static /*0x241f528*/ void Associate(object first, object second, string memberName);
            static /*0x241d37c*/ bool get_IsEnabled();
            static /*0x241e550*/ string IdOf(object value);
            static /*0x241f88c*/ int GetHashCode(object value);
            static /*0x241eae4*/ object Format(object value);
            static /*0x241e640*/ string Format(System.FormattableString s);
            /*0x241f8a0*/ NetEventSource();
            /*0x241e980*/ void Enter(string thisOrContextObject, string memberName, string parameters);
            /*0x241f0d8*/ void Exit(string thisOrContextObject, string memberName, string result);
            /*0x241f224*/ void Info(string thisOrContextObject, string memberName, string message);
            /*0x241f370*/ void ErrorMessage(string thisOrContextObject, string memberName, string message);
            /*0x241f4ac*/ void CriticalFailure(string thisOrContextObject, string memberName, string message);
            /*0x241f5f8*/ void Associate(string thisOrContextObject, string memberName, string first, string second);
            /*0x241f680*/ void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4);

            class Keywords
            {
                static System.Diagnostics.Tracing.EventKeywords Default = 1;
                static System.Diagnostics.Tracing.EventKeywords Debug = 2;
                static System.Diagnostics.Tracing.EventKeywords EnterExit = 4;
            }
        }

        class RangeValidationHelpers
        {
            static /*0x242090c*/ void ValidateSegment(System.ArraySegment<byte> segment);
        }

        class TcpValidationHelpers
        {
            static /*0x2420a04*/ bool ValidatePortNumber(int port);
        }

        class TlsStream : System.Net.Sockets.NetworkStream
        {
            /*0x48*/ System.Net.Security.SslStream _sslStream;
            /*0x50*/ string _host;
            /*0x58*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;

            /*0x2420a10*/ TlsStream(System.Net.Sockets.NetworkStream stream, System.Net.Sockets.Socket socket, string host, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates);
            /*0x2420ae4*/ void AuthenticateAsClient();
            /*0x2420be4*/ System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object state);
            /*0x2420cfc*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
            /*0x2420d20*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x2420d44*/ void EndWrite(System.IAsyncResult result);
            /*0x2420d68*/ void Write(byte[] buffer, int offset, int size);
            /*0x2420d8c*/ int Read(byte[] buffer, int offset, int size);
            /*0x2420db0*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x2420dd4*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x2420df8*/ void Close();
        }

        enum HttpStatusCode
        {
            Continue = 100,
            SwitchingProtocols = 101,
            Processing = 102,
            EarlyHints = 103,
            OK = 200,
            Created = 201,
            Accepted = 202,
            NonAuthoritativeInformation = 203,
            NoContent = 204,
            ResetContent = 205,
            PartialContent = 206,
            MultiStatus = 207,
            AlreadyReported = 208,
            IMUsed = 226,
            MultipleChoices = 300,
            Ambiguous = 300,
            MovedPermanently = 301,
            Moved = 301,
            Found = 302,
            Redirect = 302,
            SeeOther = 303,
            RedirectMethod = 303,
            NotModified = 304,
            UseProxy = 305,
            Unused = 306,
            TemporaryRedirect = 307,
            RedirectKeepVerb = 307,
            PermanentRedirect = 308,
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            NotAcceptable = 406,
            ProxyAuthenticationRequired = 407,
            RequestTimeout = 408,
            Conflict = 409,
            Gone = 410,
            LengthRequired = 411,
            PreconditionFailed = 412,
            RequestEntityTooLarge = 413,
            RequestUriTooLong = 414,
            UnsupportedMediaType = 415,
            RequestedRangeNotSatisfiable = 416,
            ExpectationFailed = 417,
            MisdirectedRequest = 421,
            UnprocessableEntity = 422,
            Locked = 423,
            FailedDependency = 424,
            UpgradeRequired = 426,
            PreconditionRequired = 428,
            TooManyRequests = 429,
            RequestHeaderFieldsTooLarge = 431,
            UnavailableForLegalReasons = 451,
            InternalServerError = 500,
            NotImplemented = 501,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504,
            HttpVersionNotSupported = 505,
            VariantAlsoNegotiates = 506,
            InsufficientStorage = 507,
            LoopDetected = 508,
            NotExtended = 510,
            NetworkAuthenticationRequired = 511,
        }

        class HttpVersion
        {
            static /*0x0*/ System.Version Unknown;
            static /*0x8*/ System.Version Version10;
            static /*0x10*/ System.Version Version11;
            static /*0x18*/ System.Version Version20;

            static /*0x2420e2c*/ HttpVersion();
        }

        class IPAddress
        {
            static long LoopbackMask = 255;
            static int NumberOfLabels = 8;
            static /*0x0*/ System.Net.IPAddress Any;
            static /*0x8*/ System.Net.IPAddress Loopback;
            static /*0x10*/ System.Net.IPAddress Broadcast;
            static /*0x18*/ System.Net.IPAddress None;
            static /*0x20*/ System.Net.IPAddress IPv6Any;
            static /*0x28*/ System.Net.IPAddress IPv6Loopback;
            static /*0x30*/ System.Net.IPAddress IPv6None;
            /*0x10*/ uint _addressOrScopeId;
            /*0x18*/ ushort[] _numbers;
            /*0x20*/ string _toString;
            /*0x28*/ int _hashCode;

            static /*0x2422bf0*/ IPAddress();
            static /*0x242152c*/ bool TryParse(string ipString, ref System.Net.IPAddress address);
            static /*0x2421794*/ bool TryParse(System.ReadOnlySpan<char> ipSpan, ref System.Net.IPAddress address);
            static /*0x24217bc*/ System.Net.IPAddress Parse(string ipString);
            static /*0x2421858*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan);
            static /*0x2421f70*/ long HostToNetworkOrder(long host);
            static /*0x2421fe4*/ int HostToNetworkOrder(int host);
            static /*0x242204c*/ short HostToNetworkOrder(short host);
            static /*0x24220b8*/ long NetworkToHostOrder(long network);
            static /*0x242210c*/ int NetworkToHostOrder(int network);
            static /*0x2422160*/ short NetworkToHostOrder(short network);
            static /*0x24221b4*/ bool IsLoopback(System.Net.IPAddress address);
            static /*0x2421080*/ byte[] ThrowAddressNullException();
            /*0x2420f80*/ IPAddress(long newAddress);
            /*0x2421004*/ IPAddress(byte[] address, long scopeid);
            /*0x24210d0*/ IPAddress(System.ReadOnlySpan<byte> address, long scopeid);
            /*0x2421254*/ IPAddress(ushort* numbers, int numbersLength, uint scopeid);
            /*0x242130c*/ IPAddress(ushort[] numbers, uint scopeid);
            /*0x2421340*/ IPAddress(byte[] address);
            /*0x24213ac*/ IPAddress(System.ReadOnlySpan<byte> address);
            /*0x24214fc*/ IPAddress(int newAddress);
            /*0x2420f30*/ bool get_IsIPv4();
            /*0x2420f40*/ bool get_IsIPv6();
            /*0x2420f50*/ uint get_PrivateAddress();
            /*0x2420f58*/ void set_PrivateAddress(uint value);
            /*0x2420f68*/ uint get_PrivateScopeId();
            /*0x2420f70*/ void set_PrivateScopeId(uint value);
            /*0x2421860*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten);
            /*0x2421978*/ void WriteIPv6Bytes(System.Span<byte> destination);
            /*0x2421a04*/ void WriteIPv4Bytes(System.Span<byte> destination);
            /*0x2421a50*/ byte[] GetAddressBytes();
            /*0x2421ba4*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x2421bbc*/ long get_ScopeId();
            /*0x2421c14*/ void set_ScopeId(long value);
            /*0x2421cb4*/ string ToString();
            /*0x2421dc0*/ bool TryFormat(System.Span<char> destination, ref int charsWritten);
            /*0x242227c*/ bool get_IsIPv6Multicast();
            /*0x24222b0*/ bool get_IsIPv6LinkLocal();
            /*0x24222ec*/ bool get_IsIPv6SiteLocal();
            /*0x2422328*/ bool get_IsIPv6Teredo();
            /*0x2422374*/ bool get_IsIPv4MappedToIPv6();
            /*0x24223d0*/ long get_Address();
            /*0x2422428*/ void set_Address(long value);
            /*0x24224dc*/ bool Equals(object comparandObj, bool compareScopeId);
            /*0x2422610*/ bool Equals(object comparand);
            /*0x2422618*/ int GetHashCode();
            /*0x2422a80*/ System.Net.IPAddress MapToIPv6();
            /*0x2422b60*/ System.Net.IPAddress MapToIPv4();

            class ReadOnlyIPAddress : System.Net.IPAddress
            {
                /*0x2422d9c*/ ReadOnlyIPAddress(long newAddress);
            }
        }

        class IPAddressParser
        {
            static /*0x2421598*/ System.Net.IPAddress Parse(System.ReadOnlySpan<char> ipSpan, bool tryParse);
            static /*0x2421d60*/ string IPv4AddressToString(uint address);
            static /*0x24230d4*/ void IPv4AddressToString(uint address, System.Text.StringBuilder destination);
            static /*0x2421ed4*/ bool IPv4AddressToString(uint address, System.Span<char> formatted, ref int charsWritten);
            static /*0x2423038*/ int IPv4AddressToStringHelper(uint address, char* addressString);
            static /*0x2421d4c*/ string IPv6AddressToString(ushort[] address, uint scopeId);
            static /*0x2421df4*/ bool IPv6AddressToString(ushort[] address, uint scopeId, System.Span<char> destination, ref int charsWritten);
            static /*0x24231fc*/ System.Text.StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId);
            static /*0x2423144*/ void FormatIPv4AddressNumber(int number, char* addressString, ref int offset);
            static /*0x2422f64*/ bool Ipv4StringToAddress(System.ReadOnlySpan<char> ipSpan, ref long address);
            static /*0x2422e00*/ bool Ipv6StringToAddress(System.ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, ref uint scope);
            static /*0x242331c*/ void AppendSections(ushort[] address, int fromInclusive, int toExclusive, System.Text.StringBuilder buffer);
            static /*0x2423510*/ void AppendHex(ushort value, System.Text.StringBuilder buffer);
            static /*0x24234d4*/ uint ExtractIPv4Address(ushort[] address);
            static /*0x2423578*/ ushort Reverse(ushort number);
        }

        class IPEndPoint : System.Net.EndPoint
        {
            static int MinPort = 0;
            static int MaxPort = 65535;
            static int AnyPort = 0;
            static /*0x0*/ System.Net.IPEndPoint Any;
            static /*0x8*/ System.Net.IPEndPoint IPv6Any;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ int _port;

            static /*0x2423cf8*/ IPEndPoint();
            /*0x24235b0*/ IPEndPoint(long address, int port);
            /*0x242368c*/ IPEndPoint(System.Net.IPAddress address, int port);
            /*0x2423584*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x242374c*/ System.Net.IPAddress get_Address();
            /*0x2423754*/ void set_Address(System.Net.IPAddress value);
            /*0x242375c*/ int get_Port();
            /*0x2423764*/ void set_Port(int value);
            /*0x24237c8*/ string ToString();
            /*0x2423888*/ System.Net.SocketAddress Serialize();
            /*0x2423950*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
            /*0x2423c14*/ bool Equals(object comparand);
            /*0x2423cc8*/ int GetHashCode();
        }

        class CommandStream : System.Net.NetworkStreamWrapper
        {
            static /*0x0*/ System.AsyncCallback s_writeCallbackDelegate;
            static /*0x8*/ System.AsyncCallback s_readCallbackDelegate;
            /*0x38*/ bool _recoverableFailure;
            /*0x40*/ System.Net.WebRequest _request;
            /*0x48*/ bool _isAsync;
            /*0x49*/ bool _aborted;
            /*0x50*/ System.Net.CommandStream.PipelineEntry[] _commands;
            /*0x58*/ int _index;
            /*0x5c*/ bool _doRead;
            /*0x5d*/ bool _doSend;
            /*0x60*/ System.Net.ResponseDescription _currentResponseDescription;
            /*0x68*/ string _abortReason;
            /*0x70*/ string _buffer;
            /*0x78*/ System.Text.Encoding _encoding;
            /*0x80*/ System.Text.Decoder _decoder;

            static /*0x2425cfc*/ CommandStream();
            static /*0x24250fc*/ void ReadCallback(System.IAsyncResult asyncResult);
            static /*0x2425960*/ void WriteCallback(System.IAsyncResult asyncResult);
            /*0x2423dcc*/ CommandStream(System.Net.Sockets.TcpClient client);
            /*0x2423ee4*/ void Abort(System.Exception e);
            /*0x2424114*/ void Dispose(bool disposing);
            /*0x24241b0*/ void InvokeRequestCallback(object obj);
            /*0x2424230*/ bool get_RecoverableFailure();
            /*0x2424238*/ void MarkAsRecoverableFailure();
            /*0x2424250*/ System.IO.Stream SubmitRequest(System.Net.WebRequest request, bool isAsync, bool readInitalResponseOnConnect);
            /*0x242483c*/ void ClearState();
            /*0x242484c*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest request);
            /*0x2424854*/ System.Exception GenerateException(string message, System.Net.WebExceptionStatus status, System.Exception innerException);
            /*0x24248e8*/ System.Exception GenerateException(System.Net.FtpStatusCode code, string statusDescription, System.Exception innerException);
            /*0x24242d0*/ void InitCommandPipeline(System.Net.WebRequest request, System.Net.CommandStream.PipelineEntry[] commands, bool isAsync);
            /*0x24249b0*/ void CheckContinuePipeline();
            /*0x2424360*/ System.IO.Stream ContinueCommandPipeline();
            /*0x2424a7c*/ bool PostSendCommandProcessing(ref System.IO.Stream stream);
            /*0x2424ed4*/ bool PostReadCommandProcessing(ref System.IO.Stream stream);
            /*0x24250f4*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x2425c14*/ System.Text.Encoding get_Encoding();
            /*0x2425c1c*/ void set_Encoding(System.Text.Encoding value);
            /*0x2425c54*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x2424bac*/ System.Net.ResponseDescription ReceiveCommandResponse();
            /*0x2425404*/ void ReceiveCommandResponseCallback(System.Net.ReceiveState state, int bytesRead);

            enum PipelineInstruction
            {
                Abort = 0,
                Advance = 1,
                Pause = 2,
                Reread = 3,
                GiveStream = 4,
            }

            enum PipelineEntryFlags
            {
                UserCommand = 1,
                GiveDataStream = 2,
                CreateDataConnection = 4,
                DontLogParameter = 8,
            }

            class PipelineEntry
            {
                /*0x10*/ string Command;
                /*0x18*/ System.Net.CommandStream.PipelineEntryFlags Flags;

                /*0x2425dd0*/ PipelineEntry(string command);
                /*0x2425df8*/ PipelineEntry(string command, System.Net.CommandStream.PipelineEntryFlags flags);
                /*0x2424a6c*/ bool HasFlag(System.Net.CommandStream.PipelineEntryFlags flags);
            }
        }

        class ResponseDescription
        {
            /*0x10*/ bool Multiline;
            /*0x14*/ int Status;
            /*0x18*/ string StatusDescription;
            /*0x20*/ System.Text.StringBuilder StatusBuffer;
            /*0x28*/ string StatusCodeString;

            /*0x2425e8c*/ ResponseDescription();
            /*0x2425e28*/ bool get_PositiveIntermediate();
            /*0x2425e3c*/ bool get_PositiveCompletion();
            /*0x2425e50*/ bool get_TransientFailure();
            /*0x2425e64*/ bool get_PermanentFailure();
            /*0x2425e78*/ bool get_InvalidStatusCode();
        }

        class ReceiveState
        {
            /*0x10*/ System.Net.ResponseDescription Resp;
            /*0x18*/ int ValidThrough;
            /*0x20*/ byte[] Buffer;
            /*0x28*/ System.Net.CommandStream Connection;

            /*0x2425c5c*/ ReceiveState(System.Net.CommandStream connection);
        }

        enum FtpLoginState
        {
            NotLoggedIn = 0,
            LoggedIn = 1,
            LoggedInButNeedsRelogin = 2,
            ReloginFailed = 3,
        }

        class FtpControlStream : System.Net.CommandStream
        {
            static /*0x0*/ System.AsyncCallback s_acceptCallbackDelegate;
            static /*0x8*/ System.AsyncCallback s_connectCallbackDelegate;
            static /*0x10*/ System.AsyncCallback s_SSLHandshakeCallback;
            /*0x88*/ System.Net.Sockets.Socket _dataSocket;
            /*0x90*/ System.Net.IPEndPoint _passiveEndPoint;
            /*0x98*/ System.Net.TlsStream _tlsStream;
            /*0xa0*/ System.Text.StringBuilder _bannerMessage;
            /*0xa8*/ System.Text.StringBuilder _welcomeMessage;
            /*0xb0*/ System.Text.StringBuilder _exitMessage;
            /*0xb8*/ System.WeakReference _credentials;
            /*0xc0*/ string _currentTypeSetting;
            /*0xc8*/ long _contentLength;
            /*0xd0*/ System.DateTime _lastModified;
            /*0xd8*/ bool _dataHandshakeStarted;
            /*0xe0*/ string _loginDirectory;
            /*0xe8*/ string _establishedServerDirectory;
            /*0xf0*/ string _requestedServerDirectory;
            /*0xf8*/ System.Uri _responseUri;
            /*0x100*/ System.Net.FtpLoginState _loginState;
            /*0x104*/ System.Net.FtpStatusCode StatusCode;
            /*0x108*/ string StatusLine;

            static /*0x242a6bc*/ FtpControlStream();
            static /*0x242613c*/ void AcceptCallback(System.IAsyncResult asyncResult);
            static /*0x2426554*/ void ConnectCallback(System.IAsyncResult asyncResult);
            static /*0x2426704*/ void SSLHandshakeCallback(System.IAsyncResult asyncResult);
            static /*0x2429678*/ void GetPathInfo(System.Net.FtpControlStream.GetPathOption pathOption, System.Uri uri, ref string path, ref string directory, ref string filename);
            /*0x2426024*/ FtpControlStream(System.Net.Sockets.TcpClient client);
            /*0x2425efc*/ System.Net.NetworkCredential get_Credentials();
            /*0x2425fa4*/ void set_Credentials(System.Net.NetworkCredential value);
            /*0x24260b0*/ void AbortConnect();
            /*0x24268c8*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref System.IO.Stream stream);
            /*0x2426e64*/ void ClearState();
            /*0x2426ef4*/ System.Net.CommandStream.PipelineInstruction PipelineCallback(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream);
            /*0x242876c*/ System.Net.CommandStream.PipelineEntry[] BuildCommandsList(System.Net.WebRequest req);
            /*0x2427730*/ System.Net.CommandStream.PipelineInstruction QueueOrCreateDataConection(System.Net.CommandStream.PipelineEntry entry, System.Net.ResponseDescription response, bool timeout, ref System.IO.Stream stream, ref bool isSocketReady);
            /*0x242a054*/ string FormatAddress(System.Net.IPAddress address, int Port);
            /*0x242a178*/ string FormatAddressV6(System.Net.IPAddress address, int port);
            /*0x242a288*/ long get_ContentLength();
            /*0x242a290*/ System.DateTime get_LastModified();
            /*0x242a298*/ System.Uri get_ResponseUri();
            /*0x242a2a0*/ string get_BannerMessage();
            /*0x242a2b8*/ string get_WelcomeMessage();
            /*0x242a2d0*/ string get_ExitMessage();
            /*0x242821c*/ long GetContentLengthFrom213Response(string responseString);
            /*0x242835c*/ System.DateTime GetLastModifiedFrom213Response(string str);
            /*0x2427ea4*/ void TryUpdateResponseUri(string str, System.Net.FtpWebRequest request);
            /*0x2427dac*/ void TryUpdateContentLength(string str);
            /*0x24286bc*/ string GetLoginDirectory(string str);
            /*0x2429b88*/ int GetPortV4(string responseString);
            /*0x2429d7c*/ int GetPortV6(string responseString);
            /*0x242981c*/ void CreateFtpListenerSocket(System.Net.FtpWebRequest request);
            /*0x2429994*/ string GetPortCommandLine(System.Net.FtpWebRequest request);
            /*0x242954c*/ string FormatFtpCommand(string command, string parameter);
            /*0x2429f3c*/ System.Net.Sockets.Socket CreateFtpDataSocket(System.Net.FtpWebRequest request, System.Net.Sockets.Socket templateSocket);
            /*0x242a2e8*/ bool CheckValid(System.Net.ResponseDescription response, ref int validThrough, ref int completeLength);
            /*0x2426b64*/ System.Net.TriState IsFtpDataStreamWriteable();

            enum GetPathOption
            {
                Normal = 0,
                AssumeFilename = 1,
                AssumeNoFilename = 2,
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ System.Net.FtpControlStream <>4__this;
                /*0x18*/ System.Net.TlsStream tlsStream;

                /*0x2427728*/ <>c__DisplayClass31_0();
                /*0x242a7d0*/ void <PipelineCallback>b__0(System.IAsyncResult ar);
            }
        }

        class FtpDataStream : System.IO.Stream, System.Net.ICloseEx
        {
            /*0x28*/ System.Net.FtpWebRequest _request;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;
            /*0x38*/ bool _writeable;
            /*0x39*/ bool _readable;
            /*0x3a*/ bool _isFullyRead;
            /*0x3b*/ bool _closing;

            /*0x2426be8*/ FtpDataStream(System.Net.Sockets.NetworkStream networkStream, System.Net.FtpWebRequest request, System.Net.TriState writeOnly);
            /*0x242a8c8*/ void Dispose(bool disposing);
            /*0x242aa50*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x242ae3c*/ void CheckError();
            /*0x242ae7c*/ bool get_CanRead();
            /*0x242ae84*/ bool get_CanSeek();
            /*0x242aea4*/ bool get_CanWrite();
            /*0x242aeac*/ long get_Length();
            /*0x242aed0*/ long get_Position();
            /*0x242aef4*/ void set_Position(long value);
            /*0x242af18*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x242afe4*/ int Read(byte[] buffer, int offset, int size);
            /*0x242b0e8*/ void Write(byte[] buffer, int offset, int size);
            /*0x242b1c0*/ void AsyncReadCallback(System.IAsyncResult ar);
            /*0x242b470*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x242b61c*/ int EndRead(System.IAsyncResult ar);
            /*0x242b7bc*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x242b8b0*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x242b950*/ void Flush();
            /*0x242b974*/ void SetLength(long value);
            /*0x242b998*/ bool get_CanTimeout();
            /*0x242b9b8*/ int get_ReadTimeout();
            /*0x242b9dc*/ void set_ReadTimeout(int value);
            /*0x242ba00*/ int get_WriteTimeout();
            /*0x242ba24*/ void set_WriteTimeout(int value);
            /*0x242ba48*/ void SetSocketTimeoutOption(int timeout);
        }

        enum FtpOperation
        {
            DownloadFile = 0,
            ListDirectory = 1,
            ListDirectoryDetails = 2,
            UploadFile = 3,
            UploadFileUnique = 4,
            AppendFile = 5,
            DeleteFile = 6,
            GetDateTimestamp = 7,
            GetFileSize = 8,
            Rename = 9,
            MakeDirectory = 10,
            RemoveDirectory = 11,
            PrintWorkingDirectory = 12,
            Other = 13,
        }

        enum FtpMethodFlags
        {
            None = 0,
            IsDownload = 1,
            IsUpload = 2,
            TakesParameter = 4,
            MayTakeParameter = 8,
            DoesNotTakeParameter = 16,
            ParameterIsDirectory = 32,
            ShouldParseForResponseUri = 64,
            HasHttpCommand = 128,
            MustChangeWorkingDirectoryToPath = 256,
        }

        class FtpMethodInfo
        {
            static /*0x0*/ System.Net.FtpMethodInfo[] s_knownMethodInfo;
            /*0x10*/ string Method;
            /*0x18*/ System.Net.FtpOperation Operation;
            /*0x1c*/ System.Net.FtpMethodFlags Flags;
            /*0x20*/ string HttpCommand;

            static /*0x242bc40*/ FtpMethodInfo();
            static /*0x242badc*/ System.Net.FtpMethodInfo GetMethodInfo(string method);
            /*0x242ba98*/ FtpMethodInfo(string method, System.Net.FtpOperation operation, System.Net.FtpMethodFlags flags, string httpCommand);
            /*0x2429668*/ bool HasFlag(System.Net.FtpMethodFlags flags);
            /*0x242980c*/ bool get_IsCommandOnly();
            /*0x242a6a4*/ bool get_IsUpload();
            /*0x242a6b0*/ bool get_IsDownload();
            /*0x2427e98*/ bool get_ShouldParseForResponseUri();
        }

        class FtpWebRequest : System.Net.WebRequest
        {
            static /*0x0*/ System.Net.NetworkCredential s_defaultFtpNetworkCredential;
            static /*0x8*/ System.Net.TimerThread.Queue s_DefaultTimerQueue;
            /*0x38*/ object _syncObject;
            /*0x40*/ System.Net.ICredentials _authInfo;
            /*0x48*/ System.Uri _uri;
            /*0x50*/ System.Net.FtpMethodInfo _methodInfo;
            /*0x58*/ string _renameTo;
            /*0x60*/ bool _getRequestStreamStarted;
            /*0x61*/ bool _getResponseStarted;
            /*0x68*/ System.DateTime _startTime;
            /*0x70*/ int _timeout;
            /*0x74*/ int _remainingTimeout;
            /*0x78*/ long _contentLength;
            /*0x80*/ long _contentOffset;
            /*0x88*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCertificates;
            /*0x90*/ bool _passive;
            /*0x91*/ bool _binary;
            /*0x98*/ string _connectionGroupName;
            /*0xa0*/ bool _async;
            /*0xa1*/ bool _aborted;
            /*0xa2*/ bool _timedOut;
            /*0xa8*/ System.Exception _exception;
            /*0xb0*/ System.Net.TimerThread.Queue _timerQueue;
            /*0xb8*/ System.Net.TimerThread.Callback _timerCallback;
            /*0xc0*/ bool _enableSsl;
            /*0xc8*/ System.Net.FtpControlStream _connection;
            /*0xd0*/ System.IO.Stream _stream;
            /*0xd8*/ System.Net.FtpWebRequest.RequestStage _requestStage;
            /*0xdc*/ bool _onceFailed;
            /*0xe0*/ System.Net.WebHeaderCollection _ftpRequestHeaders;
            /*0xe8*/ System.Net.FtpWebResponse _ftpWebResponse;
            /*0xf0*/ int _readWriteTimeout;
            /*0xf8*/ System.Net.ContextAwareResult _writeAsyncResult;
            /*0x100*/ System.Net.LazyAsyncResult _readAsyncResult;
            /*0x108*/ System.Net.LazyAsyncResult _requestCompleteAsyncResult;

            static /*0x2432470*/ FtpWebRequest();
            static /*0x242c244*/ System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy();
            /*0x242c7d0*/ FtpWebRequest(System.Uri uri);
            /*0x242c23c*/ System.Net.FtpMethodInfo get_MethodInfo();
            /*0x242c294*/ string get_Method();
            /*0x242c2b0*/ void set_Method(string value);
            /*0x242c474*/ string get_RenameTo();
            /*0x242c47c*/ System.Net.ICredentials get_Credentials();
            /*0x242c484*/ void set_Credentials(System.Net.ICredentials value);
            /*0x242c5d4*/ System.Uri get_RequestUri();
            /*0x242c5dc*/ int get_Timeout();
            /*0x242c5e4*/ void set_Timeout(int value);
            /*0x242c6bc*/ int get_RemainingTimeout();
            /*0x242c6c4*/ int get_ReadWriteTimeout();
            /*0x242c6cc*/ long get_ContentOffset();
            /*0x242c6d4*/ long get_ContentLength();
            /*0x242c6dc*/ void set_ContentLength(long value);
            /*0x242c6e4*/ System.Net.IWebProxy get_Proxy();
            /*0x242c6ec*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x242c754*/ string get_ConnectionGroupName();
            /*0x242c75c*/ void set_ConnectionGroupName(string value);
            /*0x242c7c8*/ bool get_Aborted();
            /*0x242cbfc*/ System.Net.WebResponse GetResponse();
            /*0x242e5fc*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x242ece8*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x242f114*/ System.IO.Stream GetRequestStream();
            /*0x242f6e4*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x242fc48*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x242d8a8*/ void SubmitRequest(bool isAsync);
            /*0x24309cc*/ System.Exception TranslateConnectException(System.Exception e);
            /*0x24300d8*/ void CreateConnectionAsync();
            /*0x243016c*/ System.Net.FtpControlStream CreateConnection();
            /*0x2430320*/ System.IO.Stream TimedSubmitRequestHelper(bool isAsync);
            /*0x2430b44*/ void TimerCallback(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            /*0x2430ad8*/ System.Net.TimerThread.Queue get_TimerQueue();
            /*0x2430744*/ bool AttemptedRecovery(System.Exception e);
            /*0x242e2a0*/ void SetException(System.Exception exception);
            /*0x242d3d8*/ void CheckError();
            /*0x2424220*/ void RequestCallback(object obj);
            /*0x24316b4*/ void SyncRequestCallback(object obj);
            /*0x2430c70*/ void AsyncRequestCallback(object obj);
            /*0x242d46c*/ System.Net.FtpWebRequest.RequestStage FinishRequestStage(System.Net.FtpWebRequest.RequestStage stage);
            /*0x2431a94*/ void Abort();
            /*0x2431f3c*/ System.Net.Cache.RequestCachePolicy get_CachePolicy();
            /*0x2431f88*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x2431ff0*/ bool get_UseBinary();
            /*0x2431ff8*/ bool get_UsePassive();
            /*0x2426d68*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x2432000*/ bool get_EnableSsl();
            /*0x2432008*/ System.Net.WebHeaderCollection get_Headers();
            /*0x24320d4*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x24320dc*/ string get_ContentType();
            /*0x2432188*/ void set_ContentType(string value);
            /*0x24321ac*/ bool get_UseDefaultCredentials();
            /*0x24321d0*/ void set_UseDefaultCredentials(bool value);
            /*0x24321f4*/ bool get_PreAuthenticate();
            /*0x2432218*/ void set_PreAuthenticate(bool value);
            /*0x242c45c*/ bool get_InUse();
            /*0x242dda0*/ void EnsureFtpWebResponse(System.Exception exception);
            /*0x24323f4*/ void DataStreamClosed(System.Net.CloseExState closeState);

            enum RequestStage
            {
                CheckForError = 0,
                RequestStarted = 1,
                WriteReady = 2,
                ReadReady = 3,
                ReleaseConnection = 4,
            }

            struct <CreateConnectionAsync>d__86 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.FtpWebRequest <>4__this;
                /*0x40*/ System.Net.Sockets.TcpClient <client>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x2432644*/ void MoveNext();
                /*0x2432950*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ System.Net.FtpWebRequest.<> <>9;
                static /*0x8*/ System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0;

                static /*0x243295c*/ <>c();
                /*0x24329c0*/ <>c();
                /*0x24329c8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <get_ClientCertificates>b__114_0();
            }
        }

        class FtpWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x2432a24*/ FtpWebRequestCreator();
            /*0x2432a2c*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FtpWebResponse : System.Net.WebResponse, System.IDisposable
        {
            /*0x20*/ System.IO.Stream _responseStream;
            /*0x28*/ long _contentLength;
            /*0x30*/ System.Uri _responseUri;
            /*0x38*/ System.Net.FtpStatusCode _statusCode;
            /*0x40*/ string _statusLine;
            /*0x48*/ System.Net.WebHeaderCollection _ftpRequestHeaders;
            /*0x50*/ System.DateTime _lastModified;
            /*0x58*/ string _bannerMessage;
            /*0x60*/ string _welcomeMessage;
            /*0x68*/ string _exitMessage;

            /*0x24322d0*/ FtpWebResponse(System.IO.Stream responseStream, long contentLength, System.Uri responseUri, System.Net.FtpStatusCode statusCode, string statusLine, System.DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage);
            /*0x2430c60*/ void UpdateStatus(System.Net.FtpStatusCode statusCode, string statusLine, string exitMessage);
            /*0x2432a8c*/ System.IO.Stream GetResponseStream();
            /*0x243223c*/ void SetResponseStream(System.IO.Stream stream);
            /*0x2432b80*/ void Close();
            /*0x2432c74*/ long get_ContentLength();
            /*0x2432c7c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x2432d98*/ bool get_SupportsHeaders();
            /*0x2432da0*/ System.Uri get_ResponseUri();
            /*0x2432da8*/ System.Net.FtpStatusCode get_StatusCode();

            class EmptyStream : System.IO.MemoryStream
            {
                /*0x2432af4*/ EmptyStream();
            }
        }

        class NetworkStreamWrapper : System.IO.Stream
        {
            /*0x28*/ System.Net.Sockets.TcpClient _client;
            /*0x30*/ System.Net.Sockets.NetworkStream _networkStream;

            /*0x2423e60*/ NetworkStreamWrapper(System.Net.Sockets.TcpClient client);
            /*0x2426cec*/ bool get_UsingSecureStream();
            /*0x24264ac*/ System.Net.IPAddress get_ServerAddress();
            /*0x2428200*/ System.Net.Sockets.Socket get_Socket();
            /*0x2432db0*/ System.Net.Sockets.NetworkStream get_NetworkStream();
            /*0x2432db8*/ void set_NetworkStream(System.Net.Sockets.NetworkStream value);
            /*0x2432dc0*/ bool get_CanRead();
            /*0x2432de0*/ bool get_CanSeek();
            /*0x2432e00*/ bool get_CanWrite();
            /*0x2432e20*/ bool get_CanTimeout();
            /*0x2432e40*/ int get_ReadTimeout();
            /*0x2432e64*/ void set_ReadTimeout(int value);
            /*0x2432e88*/ int get_WriteTimeout();
            /*0x2432eac*/ void set_WriteTimeout(int value);
            /*0x2432ed0*/ long get_Length();
            /*0x2432ef4*/ long get_Position();
            /*0x2432f18*/ void set_Position(long value);
            /*0x2432f3c*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x2432f60*/ int Read(byte[] buffer, int offset, int size);
            /*0x2432f84*/ void Write(byte[] buffer, int offset, int size);
            /*0x2432fa8*/ void Dispose(bool disposing);
            /*0x24253cc*/ void CloseSocket();
            /*0x24240e4*/ void Close(int timeout);
            /*0x2433054*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x2433078*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x243309c*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x24330c0*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x24330e4*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x2433108*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x243312c*/ void Flush();
            /*0x2433150*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x2433174*/ void SetLength(long value);
            /*0x24302d0*/ void SetSocketTimeoutOption(int timeout);
        }

        enum SecurityProtocolType
        {
            SystemDefault = 0,
            Ssl3 = 48,
            Tls = 192,
            Tls11 = 768,
            Tls12 = 3072,
            Tls13 = 12288,
        }

        class Authorization
        {
            /*0x10*/ string m_Message;
            /*0x18*/ bool m_Complete;
            /*0x20*/ string ModuleAuthenticationType;

            /*0x2433198*/ Authorization(string token);
            /*0x243323c*/ Authorization(string token, bool finished);
            /*0x24332d0*/ string get_Message();
            /*0x24332d8*/ bool get_Complete();
        }

        class CredentialCache
        {
            static /*0x24332e0*/ System.Net.ICredentials get_DefaultCredentials();
            static /*0x2433338*/ System.Net.NetworkCredential get_DefaultNetworkCredentials();
        }

        class SystemNetworkCredential : System.Net.NetworkCredential
        {
            static /*0x0*/ System.Net.SystemNetworkCredential defaultCredential;

            static /*0x24333e8*/ SystemNetworkCredential();
            /*0x2433390*/ SystemNetworkCredential();
        }

        class DnsEndPoint : System.Net.EndPoint
        {
            /*0x10*/ string m_Host;
            /*0x18*/ int m_Port;
            /*0x1c*/ System.Net.Sockets.AddressFamily m_Family;

            /*0x2433448*/ DnsEndPoint(string host, int port);
            /*0x2433450*/ DnsEndPoint(string host, int port, System.Net.Sockets.AddressFamily addressFamily);
            /*0x243364c*/ bool Equals(object comparand);
            /*0x2433708*/ int GetHashCode();
            /*0x24337bc*/ string ToString();
            /*0x2433980*/ string get_Host();
            /*0x2433988*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x2433990*/ int get_Port();
        }

        class EndPoint
        {
            /*0x2423684*/ EndPoint();
            /*0x2433998*/ System.Net.Sockets.AddressFamily get_AddressFamily();
            /*0x2433a44*/ System.Net.SocketAddress Serialize();
            /*0x2433af0*/ System.Net.EndPoint Create(System.Net.SocketAddress socketAddress);
        }

        enum FtpStatusCode
        {
            Undefined = 0,
            RestartMarker = 110,
            ServiceTemporarilyNotAvailable = 120,
            DataAlreadyOpen = 125,
            OpeningData = 150,
            CommandOK = 200,
            CommandExtraneous = 202,
            DirectoryStatus = 212,
            FileStatus = 213,
            SystemType = 215,
            SendUserCommand = 220,
            ClosingControl = 221,
            ClosingData = 226,
            EnteringPassive = 227,
            LoggedInProceed = 230,
            ServerWantsSecureSession = 234,
            FileActionOK = 250,
            PathnameCreated = 257,
            SendPasswordCommand = 331,
            NeedLoginAccount = 332,
            FileCommandPending = 350,
            ServiceNotAvailable = 421,
            CantOpenData = 425,
            ConnectionClosed = 426,
            ActionNotTakenFileUnavailableOrBusy = 450,
            ActionAbortedLocalProcessingError = 451,
            ActionNotTakenInsufficientSpace = 452,
            CommandSyntaxError = 500,
            ArgumentSyntaxError = 501,
            CommandNotImplemented = 502,
            BadCommandSequence = 503,
            NotLoggedIn = 530,
            AccountNeeded = 532,
            ActionNotTakenFileUnavailable = 550,
            ActionAbortedUnknownPageType = 551,
            FileActionAborted = 552,
            ActionNotTakenFilenameNotAllowed = 553,
        }

        enum HttpRequestHeader
        {
            CacheControl = 0,
            Connection = 1,
            Date = 2,
            KeepAlive = 3,
            Pragma = 4,
            Trailer = 5,
            TransferEncoding = 6,
            Upgrade = 7,
            Via = 8,
            Warning = 9,
            Allow = 10,
            ContentLength = 11,
            ContentType = 12,
            ContentEncoding = 13,
            ContentLanguage = 14,
            ContentLocation = 15,
            ContentMd5 = 16,
            ContentRange = 17,
            Expires = 18,
            LastModified = 19,
            Accept = 20,
            AcceptCharset = 21,
            AcceptEncoding = 22,
            AcceptLanguage = 23,
            Authorization = 24,
            Cookie = 25,
            Expect = 26,
            From = 27,
            Host = 28,
            IfMatch = 29,
            IfModifiedSince = 30,
            IfNoneMatch = 31,
            IfRange = 32,
            IfUnmodifiedSince = 33,
            MaxForwards = 34,
            ProxyAuthorization = 35,
            Referer = 36,
            Range = 37,
            Te = 38,
            Translate = 39,
            UserAgent = 40,
        }

        interface IAuthenticationModule
        {
            System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
            string get_AuthenticationType();
        }

        interface ICertificatePolicy
        {
            bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        interface ICredentials
        {
            System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class IPHostEntry
        {
            /*0x10*/ string hostName;
            /*0x18*/ string[] aliases;
            /*0x20*/ System.Net.IPAddress[] addressList;
            /*0x28*/ bool isTrustedHost;

            /*0x2433b3c*/ IPHostEntry();
            /*0x2433b14*/ string get_HostName();
            /*0x2433b1c*/ void set_HostName(string value);
            /*0x2433b24*/ void set_Aliases(string[] value);
            /*0x2433b2c*/ System.Net.IPAddress[] get_AddressList();
            /*0x2433b34*/ void set_AddressList(System.Net.IPAddress[] value);
        }

        interface IWebRequestCreate
        {
            System.Net.WebRequest Create(System.Uri uri);
        }

        class InternalException : System.SystemException
        {
            /*0x2424a64*/ InternalException();
        }

        class NclUtilities
        {
            static /*0x0*/ System.Net.IPAddress[] _LocalAddresses;
            static /*0x8*/ object _LocalAddressesLock;
            static /*0x10*/ string _LocalDomainName;

            static /*0x2433b4c*/ bool IsFatal(System.Exception exception);
            static /*0x2433c0c*/ bool IsAddressLocal(System.Net.IPAddress ipAddress);
            static /*0x2434144*/ System.Net.IPHostEntry GetLocalHost();
            static /*0x2433c94*/ System.Net.IPAddress[] get_LocalAddresses();
            static /*0x243419c*/ object get_LocalAddressesLock();
        }

        class ValidationHelper
        {
            static /*0x0*/ string[] EmptyArray;
            static /*0x8*/ char[] InvalidMethodChars;
            static /*0x10*/ char[] InvalidParamChars;

            static /*0x2434268*/ ValidationHelper();
            static /*0x2433228*/ string MakeStringNull(string stringValue);
            static /*0x2434240*/ bool IsBlankString(string stringValue);
            static /*0x243425c*/ bool ValidateTcpPort(int port);
        }

        class ExceptionHelper
        {
            static /*0x2433a68*/ System.NotImplementedException get_MethodNotImplementedException();
            static /*0x24339bc*/ System.NotImplementedException get_PropertyNotImplementedException();
            static /*0x242d3ec*/ System.Net.WebException get_TimeoutException();
            static /*0x2432100*/ System.NotSupportedException get_PropertyNotSupportedException();
            static /*0x2429fbc*/ System.Net.WebException get_RequestAbortedException();
        }

        class WebRequestPrefixElement
        {
            /*0x10*/ string Prefix;
            /*0x18*/ System.Net.IWebRequestCreate creator;
            /*0x20*/ System.Type creatorType;

            /*0x2434570*/ WebRequestPrefixElement(string P, System.Net.IWebRequestCreate C);
            /*0x243436c*/ System.Net.IWebRequestCreate get_Creator();
            /*0x2434568*/ void set_Creator(System.Net.IWebRequestCreate value);
        }

        class HttpContinueDelegate : System.MulticastDelegate
        {
            /*0x243459c*/ HttpContinueDelegate(object object, nint method);
            /*0x2434660*/ void Invoke(int StatusCode, System.Net.WebHeaderCollection httpHeaders);
        }

        class KnownHttpVerb
        {
            static /*0x0*/ System.Collections.Specialized.ListDictionary NamedHeaders;
            static /*0x8*/ System.Net.KnownHttpVerb Get;
            static /*0x10*/ System.Net.KnownHttpVerb Connect;
            static /*0x18*/ System.Net.KnownHttpVerb Head;
            static /*0x20*/ System.Net.KnownHttpVerb Put;
            static /*0x28*/ System.Net.KnownHttpVerb Post;
            static /*0x30*/ System.Net.KnownHttpVerb MkCol;
            /*0x10*/ string Name;
            /*0x18*/ bool RequireContentBody;
            /*0x19*/ bool ContentBodyNotAllowed;
            /*0x1a*/ bool ConnectRequest;
            /*0x1b*/ bool ExpectNoContentResponse;

            static /*0x24346cc*/ KnownHttpVerb();
            static /*0x24349e4*/ System.Net.KnownHttpVerb Parse(string name);
            /*0x2434674*/ KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse);
        }

        class HttpProtocolUtils
        {
            static /*0x2434aac*/ string date2string(System.DateTime D);
        }

        enum TriState
        {
            Unspecified = -1,
            False = 0,
            True = 1,
        }

        class NetworkCredential : System.Net.ICredentials
        {
            /*0x10*/ string m_domain;
            /*0x18*/ string m_userName;
            /*0x20*/ System.Security.SecureString m_password;

            /*0x242cb94*/ NetworkCredential(string userName, string password);
            /*0x2432580*/ NetworkCredential(string userName, string password, string domain);
            /*0x242964c*/ string get_UserName();
            /*0x2434b48*/ void set_UserName(string value);
            /*0x242965c*/ string get_Password();
            /*0x2434ba8*/ void set_Password(string value);
            /*0x2429654*/ string get_Domain();
            /*0x2434bc8*/ void set_Domain(string value);
            /*0x2434c34*/ string InternalGetUserName();
            /*0x2434c28*/ string InternalGetPassword();
            /*0x2434c3c*/ string InternalGetDomain();
            /*0x2434c44*/ System.Net.NetworkCredential GetCredential(System.Uri uri, string authType);
        }

        class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x2434c48*/ ProtocolViolationException();
            /*0x242f6dc*/ ProtocolViolationException(string message);
            /*0x2434c50*/ ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2434c58*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2434c60*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class SocketAddress
        {
            /*0x10*/ int m_Size;
            /*0x18*/ byte[] m_Buffer;
            /*0x20*/ bool m_changed;
            /*0x24*/ int m_hash;

            /*0x2434cec*/ SocketAddress(System.Net.Sockets.AddressFamily family, int size);
            /*0x2434e0c*/ SocketAddress(System.Net.IPAddress ipAddress);
            /*0x24238f4*/ SocketAddress(System.Net.IPAddress ipaddress, int port);
            /*0x2423b38*/ System.Net.Sockets.AddressFamily get_Family();
            /*0x2434c68*/ int get_Size();
            /*0x2434c70*/ byte get_Item(int offset);
            /*0x243506c*/ System.Net.IPAddress GetIPAddress();
            /*0x2423b70*/ System.Net.IPEndPoint GetIPEndPoint();
            /*0x2435258*/ bool Equals(object comparand);
            /*0x2435344*/ int GetHashCode();
            /*0x2435474*/ string ToString();
        }

        class TransportContext
        {
        }

        class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ System.Net.WebExceptionStatus m_Status;
            /*0x90*/ System.Net.WebResponse m_Response;
            /*0x98*/ System.Net.WebExceptionInternalStatus m_InternalStatus;

            /*0x2435760*/ WebException();
            /*0x24250e0*/ WebException(string message);
            /*0x2430c50*/ WebException(string message, System.Exception innerException);
            /*0x2426540*/ WebException(string message, System.Net.WebExceptionStatus status);
            /*0x2435770*/ WebException(string message, System.Net.WebExceptionStatus status, System.Net.WebExceptionInternalStatus internalStatus, System.Exception innerException);
            /*0x24248d4*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x24357a4*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response);
            /*0x243578c*/ WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x2435884*/ WebException(string message, string data, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response, System.Net.WebExceptionInternalStatus internalStatus);
            /*0x2435974*/ WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2435984*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2435994*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x243599c*/ System.Net.WebExceptionStatus get_Status();
            /*0x24359a4*/ System.Net.WebResponse get_Response();
        }

        enum WebExceptionInternalStatus
        {
            RequestFatal = 0,
            ServicePointFatal = 1,
            Recoverable = 2,
            Isolated = 3,
        }

        enum WebExceptionStatus
        {
            Success = 0,
            NameResolutionFailure = 1,
            ConnectFailure = 2,
            ReceiveFailure = 3,
            SendFailure = 4,
            PipelineFailure = 5,
            RequestCanceled = 6,
            ProtocolError = 7,
            ConnectionClosed = 8,
            TrustFailure = 9,
            SecureChannelFailure = 10,
            ServerProtocolViolation = 11,
            KeepAliveFailure = 12,
            Pending = 13,
            Timeout = 14,
            ProxyNameResolutionFailure = 15,
            UnknownError = 16,
            MessageLengthLimitExceeded = 17,
            CacheEntryNotFound = 18,
            RequestProhibitedByCachePolicy = 19,
            RequestProhibitedByProxy = 20,
        }

        class WebExceptionMapping
        {
            static /*0x0*/ string[] s_Mapping;

            static /*0x2435b44*/ WebExceptionMapping();
            static /*0x24359ac*/ string GetWebStatusString(System.Net.WebExceptionStatus status);
        }

        enum WebHeaderCollectionType
        {
            Unknown = 0,
            WebRequest = 1,
            WebResponse = 2,
            HttpWebRequest = 3,
            HttpWebResponse = 4,
            HttpListenerRequest = 5,
            HttpListenerResponse = 6,
            FtpWebRequest = 7,
            FtpWebResponse = 8,
            FileWebRequest = 9,
            FileWebResponse = 10,
        }

        class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Net.HeaderInfoTable HInfo;
            static /*0x8*/ string[] s_CommonHeaderNames;
            static /*0x10*/ sbyte[] s_CommonHeaderHints;
            static /*0x18*/ char[] HttpTrimCharacters;
            static /*0x20*/ System.Net.WebHeaderCollection.RfcChar[] RfcCharMap;
            /*0x60*/ string[] m_CommonHeaders;
            /*0x68*/ int m_NumCommonHeaders;
            /*0x70*/ System.Collections.Specialized.NameValueCollection m_InnerCollection;
            /*0x78*/ System.Net.WebHeaderCollectionType m_Type;

            static /*0x2437ed8*/ WebHeaderCollection();
            static /*0x2435d50*/ bool AllowMultiValues(string name);
            static /*0x24360a8*/ string CheckBadChars(string name, bool isHeaderValue);
            static /*0x24364c0*/ bool IsValidToken(string token);
            static /*0x243643c*/ bool ContainsNonAsciiChars(string token);
            static /*0x2437378*/ string GetAsString(System.Collections.Specialized.NameValueCollection cc, bool winInetCompat, bool forTrace);
            /*0x2432070*/ WebHeaderCollection();
            /*0x243761c*/ WebHeaderCollection(System.Net.WebHeaderCollectionType type);
            /*0x2437700*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2435bac*/ void NormalizeCommonHeaders();
            /*0x2435cac*/ System.Collections.Specialized.NameValueCollection get_InnerCollection();
            /*0x2435dfc*/ bool get_AllowHttpRequestHeader();
            /*0x2435e34*/ void Remove(System.Net.HttpRequestHeader header);
            /*0x2435f2c*/ void AddInternal(string name, string value);
            /*0x2435f80*/ void ChangeInternal(string name, string value);
            /*0x2435fd4*/ void RemoveInternal(string name);
            /*0x2436030*/ void CheckUpdate(string name, string value);
            /*0x2436580*/ void ThrowOnRestrictedHeader(string headerName);
            /*0x24366f0*/ void Add(string name, string value);
            /*0x24368a4*/ void Add(string header);
            /*0x2436b80*/ void Set(string name, string value);
            /*0x2436db0*/ void SetInternal(string name, string value);
            /*0x2436fd4*/ void Remove(string name);
            /*0x2437110*/ string[] GetValues(string header);
            /*0x243731c*/ string ToString();
            /*0x24378c4*/ void OnDeserialization(object sender);
            /*0x24378c8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2437a48*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2437a54*/ string Get(string name);
            /*0x2437d7c*/ System.Collections.IEnumerator GetEnumerator();
            /*0x2437df8*/ int get_Count();
            /*0x2437e28*/ string Get(int index);
            /*0x2437e68*/ string GetKey(int index);
            /*0x2437ea8*/ string[] get_AllKeys();

            enum RfcChar
            {
                High = 0,
                Reg = 1,
                Ctl = 2,
                CR = 3,
                LF = 4,
                WS = 5,
                Colon = 6,
                Delim = 7,
            }
        }

        class CaseInsensitiveAscii : System.Collections.IEqualityComparer, System.Collections.IComparer
        {
            static /*0x0*/ System.Net.CaseInsensitiveAscii StaticInstance;
            static /*0x8*/ byte[] AsciiToLower;

            static /*0x2438a48*/ CaseInsensitiveAscii();
            /*0x2438a40*/ CaseInsensitiveAscii();
            /*0x2438550*/ int GetHashCode(object myObject);
            /*0x2438668*/ int Compare(object firstObject, object secondObject);
            /*0x24387d8*/ int FastGetHashCode(string myString);
            /*0x24388c8*/ bool Equals(object firstObject, object secondObject);
        }

        class WebRequest : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
        {
            static int DefaultTimeout = 100000;
            static /*0x0*/ System.Collections.ArrayList s_PrefixList;
            static /*0x8*/ object s_InternalSyncObject;
            static /*0x10*/ System.Net.TimerThread.Queue s_DefaultTimerQueue;
            static /*0x18*/ System.Net.WebRequest.DesignerWebRequestCreate webRequestCreate;
            static /*0x20*/ System.Net.IWebProxy s_DefaultWebProxy;
            static /*0x28*/ bool s_DefaultWebProxyInitialized;
            /*0x18*/ System.Net.Security.AuthenticationLevel m_AuthenticationLevel;
            /*0x1c*/ System.Security.Principal.TokenImpersonationLevel m_ImpersonationLevel;
            /*0x20*/ System.Net.Cache.RequestCachePolicy m_CachePolicy;
            /*0x28*/ System.Net.Cache.RequestCacheProtocol m_CacheProtocol;
            /*0x30*/ System.Net.Cache.RequestCacheBinding m_CacheBinding;

            static /*0x243af0c*/ WebRequest();
            static /*0x2438b5c*/ void RegisterPortableWebRequestCreator(System.Net.IWebRequestCreate creator);
            static /*0x2438b60*/ object get_InternalSyncObject();
            static /*0x2438c34*/ System.Net.TimerThread.Queue get_DefaultTimerQueue();
            static /*0x2438c8c*/ System.Net.WebRequest Create(System.Uri requestUri, bool useUriBase);
            static /*0x24390a0*/ System.Net.WebRequest Create(string requestUriString);
            static /*0x243917c*/ System.Net.WebRequest Create(System.Uri requestUri);
            static /*0x2439258*/ System.Net.WebRequest CreateDefault(System.Uri requestUri);
            static /*0x2439334*/ System.Net.HttpWebRequest CreateHttp(string requestUriString);
            static /*0x243940c*/ System.Net.HttpWebRequest CreateHttp(System.Uri requestUri);
            static /*0x2439610*/ bool RegisterPrefix(string prefix, System.Net.IWebRequestCreate creator);
            static /*0x2438f0c*/ System.Collections.ArrayList get_PrefixList();
            static /*0x2439a98*/ void set_PrefixList(System.Collections.ArrayList value);
            static /*0x2439af8*/ System.Collections.ArrayList PopulatePrefixList();
            static /*0x2439d68*/ System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy();
            static /*0x2439dec*/ void set_DefaultCachePolicy(System.Net.Cache.RequestCachePolicy value);
            static /*0x243a990*/ System.Net.IWebProxy get_InternalDefaultWebProxy();
            static /*0x243ab5c*/ void set_InternalDefaultWebProxy(System.Net.IWebProxy value);
            static /*0x243ace0*/ System.Net.IWebProxy get_DefaultWebProxy();
            static /*0x243ad2c*/ void set_DefaultWebProxy(System.Net.IWebProxy value);
            static /*0x243ad80*/ System.Net.IWebProxy GetSystemWebProxy();
            static /*0x243adcc*/ System.Net.IWebProxy InternalGetSystemWebProxy();
            /*0x2439d2c*/ WebRequest();
            /*0x2439d50*/ WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2438b04*/ System.Net.IWebRequestCreate get_CreatorInstance();
            /*0x2439d58*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2439d64*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2439ecc*/ System.Net.Cache.RequestCachePolicy get_CachePolicy();
            /*0x2439ed4*/ void set_CachePolicy(System.Net.Cache.RequestCachePolicy value);
            /*0x2439ed8*/ void InternalSetCachePolicy(System.Net.Cache.RequestCachePolicy policy);
            /*0x2439f90*/ string get_Method();
            /*0x2439fb8*/ void set_Method(string value);
            /*0x2439fe0*/ System.Uri get_RequestUri();
            /*0x243a008*/ string get_ConnectionGroupName();
            /*0x243a030*/ void set_ConnectionGroupName(string value);
            /*0x243a058*/ System.Net.WebHeaderCollection get_Headers();
            /*0x243a080*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x243a0a8*/ long get_ContentLength();
            /*0x243a0d0*/ void set_ContentLength(long value);
            /*0x243a0f8*/ string get_ContentType();
            /*0x243a120*/ void set_ContentType(string value);
            /*0x243a148*/ System.Net.ICredentials get_Credentials();
            /*0x243a170*/ void set_Credentials(System.Net.ICredentials value);
            /*0x243a198*/ bool get_UseDefaultCredentials();
            /*0x243a1c0*/ void set_UseDefaultCredentials(bool value);
            /*0x243a1e8*/ System.Net.IWebProxy get_Proxy();
            /*0x243a210*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x243a238*/ bool get_PreAuthenticate();
            /*0x243a260*/ void set_PreAuthenticate(bool value);
            /*0x243a288*/ int get_Timeout();
            /*0x243a2b0*/ void set_Timeout(int value);
            /*0x243a2d8*/ System.IO.Stream GetRequestStream();
            /*0x243a300*/ System.Net.WebResponse GetResponse();
            /*0x243a328*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x243a350*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x243a378*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x243a3a0*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x243a3c8*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync();
            /*0x243a6a8*/ System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync();
            /*0x243a658*/ System.Security.Principal.WindowsIdentity SafeCaptureIdenity();
            /*0x243a938*/ void Abort();
            /*0x243a960*/ System.Net.Cache.RequestCacheProtocol get_CacheProtocol();
            /*0x243a968*/ void set_CacheProtocol(System.Net.Cache.RequestCacheProtocol value);
            /*0x243a970*/ System.Net.Security.AuthenticationLevel get_AuthenticationLevel();
            /*0x243a978*/ void set_AuthenticationLevel(System.Net.Security.AuthenticationLevel value);
            /*0x243a980*/ System.Security.Principal.TokenImpersonationLevel get_ImpersonationLevel();
            /*0x243a988*/ void set_ImpersonationLevel(System.Security.Principal.TokenImpersonationLevel value);
            /*0x243ae38*/ void SetupCacheProtocol(System.Uri uri);
            /*0x243b22c*/ System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__78_0();
            /*0x243b328*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0();

            class DesignerWebRequestCreate : System.Net.IWebRequestCreate
            {
                /*0x243b224*/ DesignerWebRequestCreate();
                /*0x243b424*/ System.Net.WebRequest Create(System.Uri uri);
            }

            class <>c__DisplayClass78_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x243a650*/ <>c__DisplayClass78_0();
                /*0x243b478*/ System.Threading.Tasks.Task<System.IO.Stream> <GetRequestStreamAsync>b__1();
            }

            class <>c__DisplayClass79_0
            {
                /*0x10*/ System.Security.Principal.WindowsIdentity currentUser;
                /*0x18*/ System.Net.WebRequest <>4__this;

                /*0x243a930*/ <>c__DisplayClass79_0();
                /*0x243b82c*/ System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1();
            }
        }

        class WebResponse : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x18*/ bool m_IsCacheFresh;
            /*0x19*/ bool m_IsFromCache;

            /*0x243bbe0*/ WebResponse();
            /*0x243bbe8*/ WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x243bbf0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x243bbfc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x243bc00*/ void Close();
            /*0x243bc04*/ void Dispose();
            /*0x243bc70*/ void Dispose(bool disposing);
            /*0x243bcfc*/ bool get_IsFromCache();
            /*0x243bd04*/ void set_InternalSetFromCache(bool value);
            /*0x243bd10*/ bool get_IsCacheFresh();
            /*0x243bd18*/ void set_InternalSetIsCacheFresh(bool value);
            /*0x243bd24*/ bool get_IsMutuallyAuthenticated();
            /*0x243bd2c*/ long get_ContentLength();
            /*0x243bd54*/ void set_ContentLength(long value);
            /*0x243bd7c*/ string get_ContentType();
            /*0x243bda4*/ void set_ContentType(string value);
            /*0x243bdcc*/ System.IO.Stream GetResponseStream();
            /*0x243bdf4*/ System.Uri get_ResponseUri();
            /*0x243be1c*/ System.Net.WebHeaderCollection get_Headers();
            /*0x243be44*/ bool get_SupportsHeaders();
        }

        class BufferOffsetSize
        {
            /*0x10*/ byte[] Buffer;
            /*0x18*/ int Offset;
            /*0x1c*/ int Size;

            /*0x243be4c*/ BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer);
            /*0x243bef8*/ BufferOffsetSize(byte[] buffer, bool copyBuffer);
        }

        class HeaderParser : System.MulticastDelegate
        {
            /*0x243bf18*/ HeaderParser(object object, nint method);
            /*0x243bfec*/ string[] Invoke(string value);
        }

        class HeaderInfo
        {
            /*0x10*/ bool IsRequestRestricted;
            /*0x11*/ bool IsResponseRestricted;
            /*0x18*/ System.Net.HeaderParser Parser;
            /*0x20*/ string HeaderName;
            /*0x28*/ bool AllowMultiValues;

            /*0x243c000*/ HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, System.Net.HeaderParser p);
        }

        class HeaderInfoTable
        {
            static /*0x0*/ System.Collections.Hashtable HeaderHashTable;
            static /*0x8*/ System.Net.HeaderInfo UnknownHeaderInfo;
            static /*0x10*/ System.Net.HeaderParser SingleParser;
            static /*0x18*/ System.Net.HeaderParser MultiParser;

            static /*0x243c2dc*/ HeaderInfoTable();
            static /*0x243c054*/ string[] ParseSingleValue(string value);
            static /*0x243c0e4*/ string[] ParseMultiValue(string value);
            /*0x243dc9c*/ HeaderInfoTable();
            /*0x243dbc0*/ System.Net.HeaderInfo get_Item(string name);
        }

        enum CloseExState
        {
            Normal = 0,
            Abort = 1,
            Silent = 2,
        }

        interface ICloseEx
        {
            void CloseEx(System.Net.CloseExState closeState);
        }

        class LazyAsyncResult : System.IAsyncResult
        {
            [ThreadStatic] static System.Net.LazyAsyncResult.ThreadContext t_ThreadContext;
            /*0x10*/ object m_AsyncObject;
            /*0x18*/ object m_AsyncState;
            /*0x20*/ System.AsyncCallback m_AsyncCallback;
            /*0x28*/ object m_Result;
            /*0x30*/ int m_IntCompleted;
            /*0x34*/ bool m_EndCalled;
            /*0x35*/ bool m_UserEvent;
            /*0x38*/ object m_Event;

            static /*0x243dca4*/ System.Net.LazyAsyncResult.ThreadContext get_CurrentThreadContext();
            /*0x243dd40*/ LazyAsyncResult(object myObject, object myState, System.AsyncCallback myCallBack);
            /*0x243ddd0*/ object get_AsyncObject();
            /*0x243ddd8*/ object get_AsyncState();
            /*0x243dde0*/ System.AsyncCallback get_AsyncCallback();
            /*0x243dde8*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x243de8c*/ bool LazilyCreateEvent(ref System.Threading.ManualResetEvent waitHandle);
            /*0x243e050*/ bool get_CompletedSynchronously();
            /*0x243e080*/ bool get_IsCompleted();
            /*0x243e040*/ bool get_InternalPeekCompleted();
            /*0x243e0b0*/ bool get_EndCalled();
            /*0x243e0b8*/ void set_EndCalled(bool value);
            /*0x243e0c4*/ void ProtectedInvokeCallback(object result, nint userToken);
            /*0x243e29c*/ void InvokeCallback(object result);
            /*0x243e2fc*/ void InvokeCallback();
            /*0x243e350*/ void Complete(nint userToken);
            /*0x243e4e8*/ void WorkerThreadComplete(object state);
            /*0x243e594*/ void Cleanup();
            /*0x243e598*/ object InternalWaitForCompletion();
            /*0x243e5a0*/ object WaitForCompletion(bool snap);

            class ThreadContext
            {
                /*0x10*/ int m_NestedIOCount;

                /*0x243dd38*/ ThreadContext();
            }
        }

        class NetRes
        {
            static /*0x243e858*/ string GetWebStatusString(string Res, System.Net.WebExceptionStatus Status);
            static /*0x243e918*/ string GetWebStatusString(System.Net.WebExceptionStatus Status);
            static /*0x243e978*/ string GetWebStatusCodeString(System.Net.FtpStatusCode statusCode, string statusDescription);
        }

        class TimerThread
        {
            static /*0x0*/ System.Collections.Generic.LinkedList<System.WeakReference> s_Queues;
            static /*0x8*/ System.Collections.Generic.LinkedList<System.WeakReference> s_NewQueues;
            static /*0x10*/ int s_ThreadState;
            static /*0x18*/ System.Threading.AutoResetEvent s_ThreadReadyEvent;
            static /*0x20*/ System.Threading.ManualResetEvent s_ThreadShutdownEvent;
            static /*0x28*/ System.Threading.WaitHandle[] s_ThreadEvents;
            static /*0x30*/ int s_CacheScanIteration;
            static /*0x38*/ System.Collections.Hashtable s_QueuesCache;

            static /*0x243eb54*/ TimerThread();
            static /*0x243afc0*/ System.Net.TimerThread.Queue CreateQueue(int durationMilliseconds);
            static /*0x243ee88*/ System.Net.TimerThread.Queue GetOrCreateQueue(int durationMilliseconds);
            static /*0x243f824*/ void Prod();
            static /*0x243f938*/ void ThreadProc();
            static /*0x24402f0*/ void StopTimerThread();
            static /*0x24402cc*/ bool IsTickBetween(int start, int end, int comparand);
            static /*0x244036c*/ void OnDomainUnload(object sender, System.EventArgs e);

            class Queue
            {
                /*0x10*/ int m_DurationMilliseconds;

                /*0x2440430*/ Queue(int durationMilliseconds);
                /*0x2440458*/ int get_Duration();
                System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class Timer : System.IDisposable
            {
                /*0x10*/ int m_StartTimeMilliseconds;
                /*0x14*/ int m_DurationMilliseconds;

                /*0x2440460*/ Timer(int durationMilliseconds);
                /*0x2440494*/ int get_StartTime();
                /*0x244049c*/ int get_Expiration();
                bool Cancel();
                bool get_HasExpired();
                /*0x24404a8*/ void Dispose();
            }

            class Callback : System.MulticastDelegate
            {
                /*0x24404b4*/ Callback(object object, nint method);
                /*0x24405e4*/ void Invoke(System.Net.TimerThread.Timer timer, int timeNoticed, object context);
            }

            class TimerQueue : System.Net.TimerThread.Queue
            {
                /*0x18*/ nint m_ThisHandle;
                /*0x20*/ System.Net.TimerThread.TimerNode m_Timers;

                /*0x243edf0*/ TimerQueue(int durationMilliseconds);
                /*0x2440628*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
                /*0x24400fc*/ bool Fire(ref int nextExpiration);
            }

            class InfiniteTimerQueue : System.Net.TimerThread.Queue
            {
                /*0x243edd0*/ InfiniteTimerQueue();
                /*0x2440b00*/ System.Net.TimerThread.Timer CreateTimer(System.Net.TimerThread.Callback callback, object context);
            }

            class TimerNode : System.Net.TimerThread.Timer
            {
                /*0x18*/ System.Net.TimerThread.TimerNode.TimerState m_TimerState;
                /*0x20*/ System.Net.TimerThread.Callback m_Callback;
                /*0x28*/ object m_Context;
                /*0x30*/ object m_QueueLock;
                /*0x38*/ System.Net.TimerThread.TimerNode next;
                /*0x40*/ System.Net.TimerThread.TimerNode prev;

                /*0x2440834*/ TimerNode(System.Net.TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock);
                /*0x24405f8*/ TimerNode();
                /*0x2440b9c*/ bool get_HasExpired();
                /*0x2440bac*/ System.Net.TimerThread.TimerNode get_Next();
                /*0x2440bb4*/ void set_Next(System.Net.TimerThread.TimerNode value);
                /*0x2440bbc*/ System.Net.TimerThread.TimerNode get_Prev();
                /*0x2440bc4*/ void set_Prev(System.Net.TimerThread.TimerNode value);
                /*0x2440bcc*/ bool Cancel();
                /*0x244088c*/ bool Fire();

                enum TimerState
                {
                    Ready = 0,
                    Fired = 1,
                    Cancelled = 2,
                    Sentinel = 3,
                }
            }

            class InfiniteTimer : System.Net.TimerThread.Timer
            {
                /*0x18*/ int cancelled;

                /*0x2440b70*/ InfiniteTimer();
                /*0x2440d04*/ bool get_HasExpired();
                /*0x2440d0c*/ bool Cancel();
            }
        }

        enum CookieVariant
        {
            Unknown = 0,
            Plain = 1,
            Rfc2109 = 2,
            Rfc2965 = 3,
            Default = 2,
        }

        class Cookie
        {
            static /*0x0*/ char[] PortSplitDelimiters;
            static /*0x8*/ char[] Reserved2Name;
            static /*0x10*/ char[] Reserved2Value;
            static /*0x18*/ System.Net.Comparer staticComparer;
            /*0x10*/ string m_comment;
            /*0x18*/ System.Uri m_commentUri;
            /*0x20*/ System.Net.CookieVariant m_cookieVariant;
            /*0x24*/ bool m_discard;
            /*0x28*/ string m_domain;
            /*0x30*/ bool m_domain_implicit;
            /*0x38*/ System.DateTime m_expires;
            /*0x40*/ string m_name;
            /*0x48*/ string m_path;
            /*0x50*/ bool m_path_implicit;
            /*0x58*/ string m_port;
            /*0x60*/ bool m_port_implicit;
            /*0x68*/ int[] m_port_list;
            /*0x70*/ bool m_secure;
            /*0x71*/ bool m_httpOnly;
            /*0x78*/ System.DateTime m_timeStamp;
            /*0x80*/ string m_value;
            /*0x88*/ int m_version;
            /*0x90*/ string m_domainKey;
            /*0x98*/ bool IsQuotedVersion;
            /*0x99*/ bool IsQuotedDomain;

            static /*0x2442b40*/ Cookie();
            static /*0x24412c8*/ bool IsDomainEqualToHost(string domain, string host);
            static /*0x2441d18*/ bool DomainCharsTest(string name);
            static /*0x24424a0*/ System.Collections.IComparer GetComparer();
            /*0x2440d30*/ Cookie();
            /*0x2440e10*/ string get_Comment();
            /*0x2440e18*/ void set_Comment(string value);
            /*0x2440e70*/ void set_CommentUri(System.Uri value);
            /*0x2440e78*/ void set_HttpOnly(bool value);
            /*0x2440e84*/ void set_Discard(bool value);
            /*0x2440e90*/ string get_Domain();
            /*0x2440e98*/ void set_Domain(string value);
            /*0x2440f0c*/ string get__Domain();
            /*0x2440fe8*/ bool get_Expired();
            /*0x24410a0*/ void set_Expires(System.DateTime value);
            /*0x24410a8*/ string get_Name();
            /*0x24410b0*/ bool InternalSetName(string value);
            /*0x24411b8*/ string get_Path();
            /*0x24411c0*/ void set_Path(string value);
            /*0x244122c*/ string get__Path();
            /*0x2440fd8*/ bool get_Plain();
            /*0x2441320*/ bool VerifySetDefaults(System.Net.CookieVariant variant, System.Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow);
            /*0x2441e78*/ void set_Port(string value);
            /*0x24421ac*/ int[] get_PortList();
            /*0x24421b4*/ string get__Port();
            /*0x244227c*/ bool get_Secure();
            /*0x2442284*/ void set_Secure(bool value);
            /*0x2442290*/ string get_Value();
            /*0x2442298*/ void set_Value(string value);
            /*0x2442300*/ System.Net.CookieVariant get_Variant();
            /*0x2442308*/ string get_DomainKey();
            /*0x2442324*/ int get_Version();
            /*0x244232c*/ void set_Version(int value);
            /*0x24423a4*/ string get__Version();
            /*0x24424f8*/ bool Equals(object comparand);
            /*0x24425c8*/ int GetHashCode();
            /*0x2442830*/ string ToString();
        }

        enum CookieToken
        {
            Nothing = 0,
            NameValuePair = 1,
            Attribute = 2,
            EndToken = 3,
            EndCookie = 4,
            End = 5,
            Equals = 6,
            Comment = 7,
            CommentUrl = 8,
            CookieName = 9,
            Discard = 10,
            Domain = 11,
            Expires = 12,
            MaxAge = 13,
            Path = 14,
            Port = 15,
            Secure = 16,
            HttpOnly = 17,
            Unknown = 18,
            Version = 19,
        }

        class CookieTokenizer
        {
            static /*0x0*/ System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;
            static /*0x8*/ System.Net.CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;
            /*0x10*/ bool m_eofCookie;
            /*0x14*/ int m_index;
            /*0x18*/ int m_length;
            /*0x20*/ string m_name;
            /*0x28*/ bool m_quoted;
            /*0x2c*/ int m_start;
            /*0x30*/ System.Net.CookieToken m_token;
            /*0x34*/ int m_tokenLength;
            /*0x38*/ string m_tokenStream;
            /*0x40*/ string m_value;

            static /*0x24433a8*/ CookieTokenizer();
            /*0x2442c94*/ CookieTokenizer(string tokenStream);
            /*0x2442ccc*/ bool get_EndOfCookie();
            /*0x2442cd4*/ void set_EndOfCookie(bool value);
            /*0x2442ce0*/ bool get_Eof();
            /*0x2442cf0*/ string get_Name();
            /*0x2442cf8*/ void set_Name(string value);
            /*0x2442d00*/ bool get_Quoted();
            /*0x2442d08*/ void set_Quoted(bool value);
            /*0x2442d14*/ System.Net.CookieToken get_Token();
            /*0x2442d1c*/ void set_Token(System.Net.CookieToken value);
            /*0x2442d24*/ string get_Value();
            /*0x2442d2c*/ void set_Value(string value);
            /*0x2442d34*/ string Extract();
            /*0x2442dbc*/ System.Net.CookieToken FindNext(bool ignoreComma, bool ignoreEquals);
            /*0x2443060*/ System.Net.CookieToken Next(bool first, bool parseResponseCookies);
            /*0x2443160*/ void Reset();
            /*0x24431c8*/ System.Net.CookieToken TokenFromName(bool parseResponseCookies);

            struct RecognizedAttribute
            {
                /*0x10*/ string m_name;
                /*0x18*/ System.Net.CookieToken m_token;

                /*0x24436b8*/ RecognizedAttribute(string name, System.Net.CookieToken token);
                /*0x24436c4*/ System.Net.CookieToken get_Token();
                /*0x2443384*/ bool IsEqualTo(string value);
            }
        }

        class CookieParser
        {
            /*0x10*/ System.Net.CookieTokenizer m_tokenizer;

            static /*0x2441db4*/ string CheckQuoted(string value);
            /*0x24436cc*/ CookieParser(string cookieString);
            /*0x2443744*/ System.Net.Cookie Get();
        }

        class Comparer : System.Collections.IComparer
        {
            /*0x2442c8c*/ Comparer();
            /*0x2443ca0*/ int System.Collections.IComparer.Compare(object ol, object or);
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ int m_version;
            /*0x18*/ System.Collections.ArrayList m_list;
            /*0x20*/ System.DateTime m_TimeStamp;
            /*0x28*/ bool m_has_other_versions;
            /*0x29*/ bool m_IsReadOnly;

            /*0x2443d7c*/ CookieCollection();
            /*0x2443e24*/ System.Net.Cookie get_Item(int index);
            /*0x2443f10*/ void Add(System.Net.Cookie cookie);
            /*0x2444398*/ void Add(System.Net.CookieCollection cookies);
            /*0x24446f8*/ int get_Count();
            /*0x244471c*/ bool get_IsSynchronized();
            /*0x2444724*/ object get_SyncRoot();
            /*0x2444728*/ void CopyTo(System.Array array, int index);
            /*0x244474c*/ System.DateTime TimeStamp(System.Net.CookieCollection.Stamp how);
            /*0x244480c*/ bool get_IsOtherVersionSeen();
            /*0x2444814*/ int InternalAdd(System.Net.Cookie cookie, bool isStrict);
            /*0x2443fd4*/ int IndexOf(System.Net.Cookie cookie);
            /*0x2444ccc*/ void RemoveAt(int idx);
            /*0x2444698*/ System.Collections.IEnumerator GetEnumerator();

            enum Stamp
            {
                Check = 0,
                Set = 1,
                SetToUnused = 2,
                SetToMaxUsed = 3,
            }

            class CookieCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Net.CookieCollection m_cookies;
                /*0x18*/ int m_count;
                /*0x1c*/ int m_index;
                /*0x20*/ int m_version;

                /*0x2444cf0*/ CookieCollectionEnumerator(System.Net.CookieCollection cookies);
                /*0x2444d4c*/ object System.Collections.IEnumerator.get_Current();
                /*0x2444df8*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x2444e9c*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct HeaderVariantInfo
        {
            /*0x10*/ string m_name;
            /*0x18*/ System.Net.CookieVariant m_variant;

            /*0x2444ea8*/ HeaderVariantInfo(string name, System.Net.CookieVariant variant);
            /*0x2444eb4*/ string get_Name();
            /*0x2444ebc*/ System.Net.CookieVariant get_Variant();
        }

        class CookieContainer
        {
            static /*0x0*/ System.Net.HeaderVariantInfo[] HeaderInfo;
            /*0x10*/ System.Collections.Hashtable m_domainTable;
            /*0x18*/ int m_maxCookieSize;
            /*0x1c*/ int m_maxCookies;
            /*0x20*/ int m_maxCookiesPerDomain;
            /*0x24*/ int m_count;
            /*0x28*/ string m_fqdnMyDomain;

            static /*0x24492f0*/ CookieContainer();
            /*0x2444ec4*/ CookieContainer();
            /*0x2444fb8*/ void AddRemoveDomain(string key, System.Net.PathList value);
            /*0x24450e0*/ void Add(System.Net.Cookie cookie, bool throwOnError);
            /*0x2445f34*/ bool AgeCookies(string domain);
            /*0x244749c*/ int ExpireCollection(System.Net.CookieCollection cc);
            /*0x244762c*/ bool IsLocalDomain(string host);
            /*0x24478c8*/ System.Net.CookieCollection CookieCutter(System.Uri uri, string headerName, string setCookieHeader, bool isThrow);
            /*0x2447fa8*/ System.Net.CookieCollection InternalGetCookies(System.Uri uri);
            /*0x2448454*/ void BuildCookieCollectionFromDomainMatches(System.Uri uri, bool isSecure, int port, System.Net.CookieCollection cookies, System.Collections.Generic.List<string> domainAttribute, bool matchOnlyPlainCookie);
            /*0x2448c7c*/ void MergeUpdateCollections(System.Net.CookieCollection destination, System.Net.CookieCollection source, int port, bool isSecure, bool isPlainOnly);
            /*0x2448e88*/ string GetCookieHeader(System.Uri uri);
            /*0x2448f58*/ string GetCookieHeader(System.Uri uri, ref string optCookie2);
        }

        class PathList
        {
            /*0x10*/ System.Collections.SortedList m_list;

            /*0x2445900*/ PathList();
            /*0x2447608*/ int get_Count();
            /*0x24459a8*/ int GetCookiesCount();
            /*0x2447478*/ System.Collections.ICollection get_Values();
            /*0x2445e10*/ object get_Item(string s);
            /*0x2445e34*/ void set_Item(string s, object value);
            /*0x2448c58*/ System.Collections.IEnumerator GetEnumerator();
            /*0x2445dec*/ object get_SyncRoot();

            class PathListComparer : System.Collections.IComparer
            {
                static /*0x0*/ System.Net.PathList.PathListComparer StaticInstance;

                static /*0x2449524*/ PathListComparer();
                /*0x244951c*/ PathListComparer();
                /*0x24493b4*/ int System.Collections.IComparer.Compare(object ol, object or);
            }
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x2449588*/ CookieException();
            /*0x2441d10*/ CookieException(string message);
            /*0x2447470*/ CookieException(string message, System.Exception inner);
            /*0x2449590*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2449598*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x24495a0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Threading.WaitCallback s_GetRequestStreamCallback;
            static /*0x8*/ System.Threading.WaitCallback s_GetResponseCallback;
            /*0x38*/ string m_connectionGroupName;
            /*0x40*/ long m_contentLength;
            /*0x48*/ System.Net.ICredentials m_credentials;
            /*0x50*/ System.IO.FileAccess m_fileAccess;
            /*0x58*/ System.Net.WebHeaderCollection m_headers;
            /*0x60*/ string m_method;
            /*0x68*/ bool m_preauthenticate;
            /*0x70*/ System.Net.IWebProxy m_proxy;
            /*0x78*/ System.Threading.ManualResetEvent m_readerEvent;
            /*0x80*/ bool m_readPending;
            /*0x88*/ System.Net.WebResponse m_response;
            /*0x90*/ System.IO.Stream m_stream;
            /*0x98*/ bool m_syncHint;
            /*0x9c*/ int m_timeout;
            /*0xa0*/ System.Uri m_uri;
            /*0xa8*/ bool m_writePending;
            /*0xa9*/ bool m_writing;
            /*0xb0*/ System.Net.LazyAsyncResult m_WriteAResult;
            /*0xb8*/ System.Net.LazyAsyncResult m_ReadAResult;
            /*0xc0*/ int m_Aborted;

            static /*0x244c1d0*/ FileWebRequest();
            static /*0x244b440*/ void GetRequestStreamCallback(object state);
            static /*0x244b708*/ void GetResponseCallback(object state);
            /*0x24495a8*/ FileWebRequest(System.Uri uri);
            /*0x2449724*/ FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2449ac0*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2449acc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x2449d5c*/ bool get_Aborted();
            /*0x2449d6c*/ string get_ConnectionGroupName();
            /*0x2449d74*/ void set_ConnectionGroupName(string value);
            /*0x2449d7c*/ long get_ContentLength();
            /*0x2449d84*/ void set_ContentLength(long value);
            /*0x2449e08*/ string get_ContentType();
            /*0x2449e5c*/ void set_ContentType(string value);
            /*0x2449eb8*/ System.Net.ICredentials get_Credentials();
            /*0x2449ec0*/ void set_Credentials(System.Net.ICredentials value);
            /*0x2449ec8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x2449ed0*/ string get_Method();
            /*0x2449ed8*/ void set_Method(string value);
            /*0x2449fb0*/ bool get_PreAuthenticate();
            /*0x2449fb8*/ void set_PreAuthenticate(bool value);
            /*0x2449fc4*/ System.Net.IWebProxy get_Proxy();
            /*0x2449fcc*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x2449fd4*/ int get_Timeout();
            /*0x2449fdc*/ void set_Timeout(int value);
            /*0x244a064*/ System.Uri get_RequestUri();
            /*0x244a06c*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x244a4b0*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x244a43c*/ bool CanGetRequestStream();
            /*0x244a78c*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x244aa88*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x244ad84*/ System.IO.Stream GetRequestStream();
            /*0x244b0e0*/ System.Net.WebResponse GetResponse();
            /*0x244bd0c*/ void UnblockReader();
            /*0x244bde4*/ bool get_UseDefaultCredentials();
            /*0x244be0c*/ void set_UseDefaultCredentials(bool value);
            /*0x244be34*/ void Abort();
        }

        class FileWebRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x2439d24*/ FileWebRequestCreator();
            /*0x244c2a4*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class FileWebStream : System.IO.FileStream, System.Net.ICloseEx
        {
            /*0x70*/ System.Net.FileWebRequest m_request;

            /*0x244b66c*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing);
            /*0x244c304*/ FileWebStream(System.Net.FileWebRequest request, string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare sharing, int length, bool async);
            /*0x244c3b8*/ void Dispose(bool disposing);
            /*0x244c468*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x244c4a4*/ int Read(byte[] buffer, int offset, int size);
            /*0x244c5f0*/ void Write(byte[] buffer, int offset, int size);
            /*0x244c6b8*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x244c798*/ int EndRead(System.IAsyncResult ar);
            /*0x244c838*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
            /*0x244c918*/ void EndWrite(System.IAsyncResult ar);
            /*0x244c56c*/ void CheckError();
        }

        class FileWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.Net.ICloseEx
        {
            /*0x1a*/ bool m_closed;
            /*0x20*/ long m_contentLength;
            /*0x28*/ System.IO.FileAccess m_fileAccess;
            /*0x30*/ System.Net.WebHeaderCollection m_headers;
            /*0x38*/ System.IO.Stream m_stream;
            /*0x40*/ System.Uri m_uri;

            /*0x244ba28*/ FileWebResponse(System.Net.FileWebRequest request, System.Uri uri, System.IO.FileAccess access, bool asyncHint);
            /*0x244c9b8*/ FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244cbec*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244cbf8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244cd88*/ long get_ContentLength();
            /*0x244ce24*/ string get_ContentType();
            /*0x244ce70*/ System.Net.WebHeaderCollection get_Headers();
            /*0x244ce88*/ bool get_SupportsHeaders();
            /*0x244ce90*/ System.Uri get_ResponseUri();
            /*0x244cda0*/ void CheckDisposed();
            /*0x244cea8*/ void Close();
            /*0x244cf40*/ void System.Net.ICloseEx.CloseEx(System.Net.CloseExState closeState);
            /*0x244d0ac*/ System.IO.Stream GetResponseStream();
        }

        interface IWebProxy
        {
            System.Uri GetProxy(System.Uri destination);
            bool IsBypassed(System.Uri host);
            System.Net.ICredentials get_Credentials();
        }

        class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable
        {
            /*0x10*/ bool _UseRegistry;
            /*0x11*/ bool _BypassOnLocal;
            /*0x12*/ bool m_EnableAutoproxy;
            /*0x18*/ System.Uri _ProxyAddress;
            /*0x20*/ System.Collections.ArrayList _BypassList;
            /*0x28*/ System.Net.ICredentials _Credentials;
            /*0x30*/ System.Text.RegularExpressions.Regex[] _RegExBypassList;
            /*0x38*/ System.Collections.Hashtable _ProxyHostAddresses;
            /*0x40*/ System.Net.AutoWebProxyScriptEngine m_ScriptEngine;

            static /*0x243add0*/ System.Net.IWebProxy CreateDefaultProxy();
            static /*0x244e1a0*/ bool AreAllBypassed(System.Collections.Generic.IEnumerable<string> proxies, bool checkFirstOnly);
            static /*0x244e4a8*/ System.Uri ProxyUri(string proxyName);
            /*0x244d100*/ WebProxy();
            /*0x244d114*/ WebProxy(System.Uri Address, bool BypassOnLocal, string[] BypassList, System.Net.ICredentials Credentials);
            /*0x244dcc0*/ WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244e164*/ WebProxy(bool enableAutoproxy);
            /*0x244d400*/ System.Net.ICredentials get_Credentials();
            /*0x244d408*/ bool get_UseDefaultCredentials();
            /*0x244d484*/ void set_UseDefaultCredentials(bool value);
            /*0x244d4fc*/ System.Uri GetProxy(System.Uri destination);
            /*0x244d1c8*/ void UpdateRegExList(bool canThrow);
            /*0x244d7ac*/ bool IsMatchInBypassList(System.Uri input);
            /*0x244d944*/ bool IsLocal(System.Uri host);
            /*0x244daa8*/ bool IsLocalInProxyHash(System.Uri host);
            /*0x244db98*/ bool IsBypassed(System.Uri host);
            /*0x244d6e4*/ bool IsBypassedManual(System.Uri host);
            /*0x244e02c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244e038*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x244e15c*/ System.Net.AutoWebProxyScriptEngine get_ScriptEngine();
            /*0x244e020*/ void UnsafeUpdateFromRegistry();
            /*0x244d698*/ bool GetProxyAuto(System.Uri destination, ref System.Uri proxyUri);
            /*0x244dc7c*/ bool IsBypassedAuto(System.Uri destination, ref bool isBypassed);
        }

        class AutoWebProxyScriptEngine
        {
            /*0x244e194*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList);
            /*0x244e54c*/ bool GetProxies(System.Uri destination, ref System.Collections.Generic.IList<string> proxyList, ref int syncStatus);
        }

        class UnsafeNclNativeMethods
        {
            class HttpApi
            {
                static /*0x0*/ string[] m_Strings;

                static /*0x244e558*/ HttpApi();

                class HTTP_REQUEST_HEADER_ID
                {
                    static /*0x0*/ string[] m_Strings;

                    static /*0x244edd8*/ HTTP_REQUEST_HEADER_ID();
                    static /*0x244ed5c*/ string ToString(int position);
                }
            }

            class SecureStringHelper
            {
                static /*0x244f89c*/ string CreateString(System.Security.SecureString secureString);
                static /*0x244fa4c*/ System.Security.SecureString CreateSecureString(string plainString);
            }
        }

        class Logging
        {
            static /*0x2438f04*/ bool get_On();
        }

        class ServerCertValidationCallback
        {
            /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback m_ValidationCallback;
            /*0x18*/ System.Threading.ExecutionContext m_Context;

            /*0x244faf8*/ ServerCertValidationCallback(System.Net.Security.RemoteCertificateValidationCallback validationCallback);
            /*0x244fb70*/ System.Net.Security.RemoteCertificateValidationCallback get_ValidationCallback();
            /*0x244fb78*/ void Callback(object state);
            /*0x244fc24*/ bool Invoke(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);

            class CallbackContext
            {
                /*0x10*/ object request;
                /*0x18*/ System.Security.Cryptography.X509Certificates.X509Certificate certificate;
                /*0x20*/ System.Security.Cryptography.X509Certificates.X509Chain chain;
                /*0x28*/ System.Net.Security.SslPolicyErrors sslPolicyErrors;
                /*0x2c*/ bool result;

                /*0x244fd8c*/ CallbackContext(object request, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            }
        }

        class AuthenticationManager
        {
            static /*0x0*/ System.Collections.ArrayList modules;
            static /*0x8*/ object locker;
            static /*0x10*/ System.Net.ICredentialPolicy credential_policy;

            static /*0x2450bac*/ AuthenticationManager();
            static /*0x244fdd0*/ void EnsureModules();
            static /*0x2450080*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x245018c*/ System.Net.Authorization DoAuthenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
            static /*0x2450674*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
        }

        class BasicClient : System.Net.IAuthenticationModule
        {
            static /*0x245107c*/ byte[] GetBytes(string str);
            static /*0x2450cd0*/ System.Net.Authorization InternalAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2450078*/ BasicClient();
            /*0x2450c24*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2451124*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2451130*/ string get_AuthenticationType();
        }

        class BindIPEndPoint : System.MulticastDelegate
        {
            /*0x2451170*/ BindIPEndPoint(object object, nint method);
            /*0x24512a0*/ System.Net.IPEndPoint Invoke(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);
        }

        class BufferedReadStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.BufferOffsetSize readBuffer;

            /*0x24512b4*/ BufferedReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.BufferOffsetSize readBuffer);
            /*0x24512dc*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x2451404*/ bool TryReadFromBuffer(byte[] buffer, int offset, int size, ref int result);

            struct <ProcessReadAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.BufferedReadStream <>4__this;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x2451494*/ void MoveNext();
                /*0x2451744*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ContentDecodeStream : System.Net.WebReadStream
        {
            /*0x40*/ System.IO.Stream <OriginalInnerStream>k__BackingField;

            static /*0x245179c*/ System.Net.ContentDecodeStream Create(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.ContentDecodeStream.Mode mode);
            /*0x2451888*/ ContentDecodeStream(System.Net.WebOperation operation, System.IO.Stream decodeStream, System.IO.Stream originalInnerStream);
            /*0x24518b0*/ System.IO.Stream get_OriginalInnerStream();
            /*0x24518b8*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x24518dc*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);

            enum Mode
            {
                GZip = 0,
                Deflate = 1,
            }
        }

        enum DecompressionMethods
        {
            None = 0,
            GZip = 1,
            Deflate = 2,
        }

        class DefaultCertificatePolicy : System.Net.ICertificatePolicy
        {
            /*0x2451a48*/ DefaultCertificatePolicy();
            /*0x24519cc*/ bool CheckValidationResult(System.Net.ServicePoint point, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
        }

        class DigestHeaderParser
        {
            static /*0x0*/ string[] keywords;
            /*0x10*/ string header;
            /*0x18*/ int length;
            /*0x1c*/ int pos;
            /*0x20*/ string[] values;

            static /*0x2452058*/ DigestHeaderParser();
            /*0x2451a50*/ DigestHeaderParser(string header);
            /*0x2451b04*/ string get_Realm();
            /*0x2451b2c*/ string get_Opaque();
            /*0x2451b58*/ string get_Nonce();
            /*0x2451b84*/ string get_Algorithm();
            /*0x2451bb0*/ string get_QOP();
            /*0x2451bdc*/ bool Parse();
            /*0x2451f48*/ void SkipWhitespace();
            /*0x2451fc8*/ string GetKey();
            /*0x2451db8*/ bool GetKeywordAndValue(ref string key, ref string value);
        }

        class DigestSession
        {
            static /*0x0*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ System.DateTime lastUse;
            /*0x18*/ int _nc;
            /*0x20*/ System.Security.Cryptography.HashAlgorithm hash;
            /*0x28*/ System.Net.DigestHeaderParser parser;
            /*0x30*/ string _cnonce;

            static /*0x2452218*/ DigestSession();
            /*0x2452268*/ DigestSession();
            /*0x24522d8*/ string get_Algorithm();
            /*0x24522f0*/ string get_Realm();
            /*0x2452308*/ string get_Nonce();
            /*0x2452320*/ string get_Opaque();
            /*0x2452338*/ string get_QOP();
            /*0x2452350*/ string get_CNonce();
            /*0x2452444*/ bool Parse(string challenge);
            /*0x2452524*/ string HashToHexString(string toBeHashed);
            /*0x2452674*/ string HA1(string username, string password);
            /*0x2452798*/ string HA2(System.Net.HttpWebRequest webRequest);
            /*0x245286c*/ string Response(string username, string password, System.Net.HttpWebRequest webRequest);
            /*0x24529cc*/ System.Net.Authorization Authenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2452fb0*/ System.DateTime get_LastUse();
        }

        class DigestClient : System.Net.IAuthenticationModule
        {
            static /*0x0*/ System.Collections.Hashtable cache;

            static /*0x2453de4*/ DigestClient();
            static /*0x2452fb8*/ System.Collections.Hashtable get_Cache();
            static /*0x2453120*/ void CheckExpired(int count);
            /*0x2450070*/ DigestClient();
            /*0x2453968*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2453c10*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2453da4*/ string get_AuthenticationType();
        }

        class Dns
        {
            static /*0x2453e68*/ Dns();
            static /*0x2453e6c*/ System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject);
            static /*0x2454054*/ System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject);
            static /*0x245423c*/ System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state);
            static /*0x24544c0*/ System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject);
            static /*0x2454744*/ System.IAsyncResult BeginGetHostEntry(System.Net.IPAddress address, System.AsyncCallback requestCallback, object stateObject);
            static /*0x2454984*/ System.Net.IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult);
            static /*0x2454a9c*/ System.Net.IPHostEntry EndResolve(System.IAsyncResult asyncResult);
            static /*0x2454bb4*/ System.Net.IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult);
            static /*0x2454ccc*/ System.Net.IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult);
            static /*0x2454e44*/ bool GetHostByName_icall(string host, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x2454e48*/ bool GetHostByAddr_icall(string addr, ref string h_name, ref string[] h_aliases, ref string[] h_addr_list, int hint);
            static /*0x2454e4c*/ bool GetHostName_icall(ref string h_name);
            static /*0x2454e50*/ void Error_11001(string hostName);
            static /*0x2454ebc*/ System.Net.IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist);
            static /*0x24551ec*/ System.Net.IPHostEntry GetHostByAddress(System.Net.IPAddress address);
            static /*0x2455428*/ System.Net.IPHostEntry GetHostByAddress(string address);
            static /*0x24552ac*/ System.Net.IPHostEntry GetHostByAddressFromString(string address, bool parse);
            static /*0x24554d0*/ System.Net.IPHostEntry GetHostEntry(string hostNameOrAddress);
            static /*0x245567c*/ System.Net.IPHostEntry GetHostEntry(System.Net.IPAddress address);
            static /*0x2455880*/ System.Net.IPAddress[] GetHostAddresses(string hostNameOrAddress);
            static /*0x245573c*/ System.Net.IPHostEntry GetHostByName(string hostName);
            static /*0x2455a80*/ string GetHostName();
            static /*0x2455af8*/ System.Net.IPHostEntry Resolve(string hostName);
            static /*0x2455c34*/ System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);
            static /*0x2455d50*/ System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(System.Net.IPAddress address);
            static /*0x2455e6c*/ System.Threading.Tasks.Task<System.Net.IPHostEntry> GetHostEntryAsync(string hostNameOrAddress);

            class GetHostByNameCallback : System.MulticastDelegate
            {
                /*0x2453f60*/ GetHostByNameCallback(object object, nint method);
                /*0x2455f88*/ System.Net.IPHostEntry Invoke(string hostName);
                /*0x2454034*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x2454a90*/ System.Net.IPHostEntry EndInvoke(System.IAsyncResult result);
            }

            class ResolveCallback : System.MulticastDelegate
            {
                /*0x2454148*/ ResolveCallback(object object, nint method);
                /*0x2455f9c*/ System.Net.IPHostEntry Invoke(string hostName);
                /*0x245421c*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x2454ba8*/ System.Net.IPHostEntry EndInvoke(System.IAsyncResult result);
            }

            class GetHostEntryNameCallback : System.MulticastDelegate
            {
                /*0x2454650*/ GetHostEntryNameCallback(object object, nint method);
                /*0x2455fb0*/ System.Net.IPHostEntry Invoke(string hostName);
                /*0x2454724*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x2454e38*/ System.Net.IPHostEntry EndInvoke(System.IAsyncResult result);
            }

            class GetHostEntryIPCallback : System.MulticastDelegate
            {
                /*0x2454838*/ GetHostEntryIPCallback(object object, nint method);
                /*0x2455fc4*/ System.Net.IPHostEntry Invoke(System.Net.IPAddress hostAddress);
                /*0x2454964*/ System.IAsyncResult BeginInvoke(System.Net.IPAddress hostAddress, System.AsyncCallback callback, object object);
                /*0x2454e2c*/ System.Net.IPHostEntry EndInvoke(System.IAsyncResult result);
            }

            class GetHostAddressesCallback : System.MulticastDelegate
            {
                /*0x24543cc*/ GetHostAddressesCallback(object object, nint method);
                /*0x2455fd8*/ System.Net.IPAddress[] Invoke(string hostName);
                /*0x24544a0*/ System.IAsyncResult BeginInvoke(string hostName, System.AsyncCallback callback, object object);
                /*0x2454cc0*/ System.Net.IPAddress[] EndInvoke(System.IAsyncResult result);
            }
        }

        class FixedSizeReadStream : System.Net.WebReadStream
        {
            /*0x40*/ long <ContentLength>k__BackingField;
            /*0x48*/ long position;

            /*0x2455ff4*/ FixedSizeReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream, long contentLength);
            /*0x2455fec*/ long get_ContentLength();
            /*0x245601c*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);

            struct <ProcessReadAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.FixedSizeReadStream <>4__this;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x2456144*/ void MoveNext();
                /*0x24563f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpRequestCreator : System.Net.IWebRequestCreate
        {
            /*0x245644c*/ HttpRequestCreator();
            /*0x2456454*/ System.Net.WebRequest Create(System.Uri uri);
        }

        class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ int defaultMaxResponseHeadersLength;
            static /*0x4*/ int defaultMaximumErrorResponseLength;
            static /*0x8*/ System.Net.Cache.RequestCachePolicy defaultCachePolicy;
            /*0x38*/ System.Uri requestUri;
            /*0x40*/ System.Uri actualUri;
            /*0x48*/ bool hostChanged;
            /*0x49*/ bool allowAutoRedirect;
            /*0x4a*/ bool allowBuffering;
            /*0x4b*/ bool allowReadStreamBuffering;
            /*0x50*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates;
            /*0x58*/ string connectionGroup;
            /*0x60*/ bool haveContentLength;
            /*0x68*/ long contentLength;
            /*0x70*/ System.Net.HttpContinueDelegate continueDelegate;
            /*0x78*/ System.Net.CookieContainer cookieContainer;
            /*0x80*/ System.Net.ICredentials credentials;
            /*0x88*/ bool haveResponse;
            /*0x89*/ bool requestSent;
            /*0x90*/ System.Net.WebHeaderCollection webHeaders;
            /*0x98*/ bool keepAlive;
            /*0x9c*/ int maxAutoRedirect;
            /*0xa0*/ string mediaType;
            /*0xa8*/ string method;
            /*0xb0*/ string initialMethod;
            /*0xb8*/ bool pipelined;
            /*0xb9*/ bool preAuthenticate;
            /*0xba*/ bool usedPreAuth;
            /*0xc0*/ System.Version version;
            /*0xc8*/ bool force_version;
            /*0xd0*/ System.Version actualVersion;
            /*0xd8*/ System.Net.IWebProxy proxy;
            /*0xe0*/ bool sendChunked;
            /*0xe8*/ System.Net.ServicePoint servicePoint;
            /*0xf0*/ int timeout;
            /*0xf4*/ int continueTimeout;
            /*0xf8*/ System.Net.WebRequestStream writeStream;
            /*0x100*/ System.Net.HttpWebResponse webResponse;
            /*0x108*/ System.Net.WebCompletionSource responseTask;
            /*0x110*/ System.Net.WebOperation currentOperation;
            /*0x118*/ int aborted;
            /*0x11c*/ bool gotRequestStream;
            /*0x120*/ int redirects;
            /*0x124*/ bool expectContinue;
            /*0x125*/ bool getResponseCalled;
            /*0x128*/ object locker;
            /*0x130*/ bool finished_reading;
            /*0x134*/ System.Net.DecompressionMethods auto_decomp;
            /*0x138*/ int maxResponseHeadersLength;
            /*0x13c*/ int readWriteTimeout;
            /*0x140*/ Mono.Net.Security.MobileTlsProvider tlsProvider;
            /*0x148*/ Mono.Security.Interface.MonoTlsSettings tlsSettings;
            /*0x150*/ System.Net.ServerCertValidationCallback certValidationCallback;
            /*0x158*/ bool hostHasPort;
            /*0x160*/ System.Uri hostUri;
            /*0x168*/ System.Net.HttpWebRequest.AuthorizationState auth_state;
            /*0x178*/ System.Net.HttpWebRequest.AuthorizationState proxy_auth_state;
            /*0x188*/ System.Func<System.IO.Stream, System.Threading.Tasks.Task> ResendContentFactory;
            /*0x190*/ int ID;
            /*0x194*/ bool <ThrowOnError>k__BackingField;
            /*0x195*/ bool unsafe_auth_blah;
            /*0x196*/ bool <ReuseConnection>k__BackingField;

            static /*0x245665c*/ HttpWebRequest();
            static /*0x2456a90*/ System.Exception GetMustImplement();
            static /*0x2457298*/ int get_DefaultMaximumErrorResponseLength();
            static /*0x24572f0*/ void set_DefaultMaximumErrorResponseLength(int value);
            static /*0x2457d34*/ int get_DefaultMaximumResponseHeadersLength();
            static /*0x2457d8c*/ void set_DefaultMaximumResponseHeadersLength(int value);
            static System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationToken cancellationToken);
            static System.Threading.Tasks.Task<T> RunWithTimeoutWorker<T>(System.Threading.Tasks.Task<T> workerTask, int timeout, System.Action abort, System.Func<bool> aborted, System.Threading.CancellationTokenSource cts);
            static /*0x245a5b4*/ System.Exception FlattenException(System.Exception e);
            static /*0x245a674*/ System.Net.WebException GetWebException(System.Exception e, bool aborted);
            static /*0x2459ea4*/ System.Net.WebException CreateRequestAbortedException();
            static /*0x245cc2c*/ System.Text.StringBuilder GenerateConnectionGroup(string connectionGroupName, bool unsafeConnectionGroup, bool isInternalGroup);
            /*0x24564b4*/ HttpWebRequest(System.Uri uri);
            /*0x24566f8*/ HttpWebRequest(System.Uri uri, Mono.Net.Security.MobileTlsProvider tlsProvider, Mono.Security.Interface.MonoTlsSettings settings);
            /*0x2456720*/ HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x245cdfc*/ HttpWebRequest();
            /*0x24566e8*/ void ResetAuthorization();
            /*0x2456870*/ void SetSpecialHeaders(string HeaderName, string value);
            /*0x2456930*/ string get_Accept();
            /*0x2456984*/ void set_Accept(string value);
            /*0x2456a44*/ System.Uri get_Address();
            /*0x2456a4c*/ void set_Address(System.Uri value);
            /*0x2456a54*/ bool get_AllowAutoRedirect();
            /*0x2456a5c*/ void set_AllowAutoRedirect(bool value);
            /*0x2456a68*/ bool get_AllowWriteStreamBuffering();
            /*0x2456a70*/ void set_AllowWriteStreamBuffering(bool value);
            /*0x2456a7c*/ bool get_AllowReadStreamBuffering();
            /*0x2456a84*/ void set_AllowReadStreamBuffering(bool value);
            /*0x2456aec*/ System.Net.DecompressionMethods get_AutomaticDecompression();
            /*0x2456af4*/ void set_AutomaticDecompression(System.Net.DecompressionMethods value);
            /*0x2456b18*/ bool get_InternalAllowBuffering();
            /*0x2456b2c*/ bool get_MethodWithBuffer();
            /*0x2456c28*/ Mono.Net.Security.MobileTlsProvider get_TlsProvider();
            /*0x2456c30*/ Mono.Security.Interface.MonoTlsSettings get_TlsSettings();
            /*0x2456c38*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x2456ca4*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
            /*0x2456d04*/ string get_Connection();
            /*0x2456d58*/ void set_Connection(string value);
            /*0x2456eec*/ string get_ConnectionGroupName();
            /*0x2456ef4*/ void set_ConnectionGroupName(string value);
            /*0x2456efc*/ long get_ContentLength();
            /*0x2456f04*/ void set_ContentLength(long value);
            /*0x2456f94*/ void set_InternalContentLength(long value);
            /*0x2456f9c*/ bool get_ThrowOnError();
            /*0x2456fa4*/ void set_ThrowOnError(bool value);
            /*0x2456fb0*/ string get_ContentType();
            /*0x2457004*/ void set_ContentType(string value);
            /*0x245705c*/ System.Net.HttpContinueDelegate get_ContinueDelegate();
            /*0x2457064*/ void set_ContinueDelegate(System.Net.HttpContinueDelegate value);
            /*0x245706c*/ System.Net.CookieContainer get_CookieContainer();
            /*0x2457074*/ void set_CookieContainer(System.Net.CookieContainer value);
            /*0x245707c*/ System.Net.ICredentials get_Credentials();
            /*0x2457084*/ void set_Credentials(System.Net.ICredentials value);
            /*0x245708c*/ System.DateTime get_Date();
            /*0x24571a8*/ void set_Date(System.DateTime value);
            /*0x2457200*/ void SetDateHeaderHelper(string headerName, System.DateTime dateTime);
            /*0x245734c*/ string get_Expect();
            /*0x24573a0*/ void set_Expect(string value);
            /*0x24574cc*/ bool get_HaveResponse();
            /*0x24574d4*/ System.Net.WebHeaderCollection get_Headers();
            /*0x24574dc*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x24575e0*/ string get_Host();
            /*0x24576ec*/ void set_Host(string value);
            /*0x245785c*/ bool TryGetHostUri(string hostName, ref System.Uri hostUri);
            /*0x245792c*/ System.DateTime get_IfModifiedSince();
            /*0x2457b58*/ void set_IfModifiedSince(System.DateTime value);
            /*0x2457c04*/ bool get_KeepAlive();
            /*0x2457c0c*/ void set_KeepAlive(bool value);
            /*0x2457c18*/ int get_MaximumAutomaticRedirections();
            /*0x2457c20*/ void set_MaximumAutomaticRedirections(int value);
            /*0x2457ca0*/ int get_MaximumResponseHeadersLength();
            /*0x2457ca8*/ void set_MaximumResponseHeadersLength(int value);
            /*0x2457de8*/ int get_ReadWriteTimeout();
            /*0x2457df0*/ void set_ReadWriteTimeout(int value);
            /*0x2457e84*/ int get_ContinueTimeout();
            /*0x2457e8c*/ void set_ContinueTimeout(int value);
            /*0x2457f18*/ string get_MediaType();
            /*0x2457f20*/ void set_MediaType(string value);
            /*0x2457f28*/ string get_Method();
            /*0x2457f30*/ void set_Method(string value);
            /*0x245815c*/ bool get_Pipelined();
            /*0x2458164*/ void set_Pipelined(bool value);
            /*0x2458170*/ bool get_PreAuthenticate();
            /*0x2458178*/ void set_PreAuthenticate(bool value);
            /*0x2458184*/ System.Version get_ProtocolVersion();
            /*0x245818c*/ void set_ProtocolVersion(System.Version value);
            /*0x245829c*/ System.Net.IWebProxy get_Proxy();
            /*0x24582a4*/ void set_Proxy(System.Net.IWebProxy value);
            /*0x24583fc*/ string get_Referer();
            /*0x2458450*/ void set_Referer(string value);
            /*0x24584ec*/ System.Uri get_RequestUri();
            /*0x24584f4*/ bool get_SendChunked();
            /*0x24584fc*/ void set_SendChunked(bool value);
            /*0x2458520*/ System.Net.ServicePoint get_ServicePoint();
            /*0x2458524*/ System.Net.ServicePoint get_ServicePointNoLock();
            /*0x245852c*/ bool get_SupportsCookieContainer();
            /*0x2458534*/ int get_Timeout();
            /*0x245853c*/ void set_Timeout(int value);
            /*0x24585a0*/ string get_TransferEncoding();
            /*0x24585f4*/ void set_TransferEncoding(string value);
            /*0x2458790*/ bool get_UseDefaultCredentials();
            /*0x2458808*/ void set_UseDefaultCredentials(bool value);
            /*0x245888c*/ string get_UserAgent();
            /*0x24588e0*/ void set_UserAgent(string value);
            /*0x245893c*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x2458944*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);
            /*0x2458950*/ bool get_GotRequestStream();
            /*0x2458958*/ bool get_ExpectContinue();
            /*0x2458960*/ void set_ExpectContinue(bool value);
            /*0x245896c*/ System.Uri get_AuthUri();
            /*0x2458974*/ bool get_ProxyQuery();
            /*0x24589a8*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            /*0x24589b0*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            /*0x24589c8*/ void set_ServerCertificateValidationCallback(System.Net.Security.RemoteCertificateValidationCallback value);
            /*0x24582d0*/ System.Net.ServicePoint GetServicePoint();
            /*0x24590a4*/ void AddRange(int range);
            /*0x245939c*/ void AddRange(int from, int to);
            /*0x2459684*/ void AddRange(string rangeSpecifier, int range);
            /*0x245968c*/ void AddRange(string rangeSpecifier, int from, int to);
            /*0x2459698*/ void AddRange(long range);
            /*0x24596f0*/ void AddRange(long from, long to);
            /*0x24590fc*/ void AddRange(string rangeSpecifier, long range);
            /*0x24593fc*/ void AddRange(string rangeSpecifier, long from, long to);
            /*0x2459750*/ System.Net.WebOperation SendRequest(bool redirecting, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x2459b04*/ System.Threading.Tasks.Task<System.IO.Stream> MyGetRequestStreamAsync(System.Threading.CancellationToken cancellationToken);
            /*0x2459f68*/ System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state);
            /*0x245a020*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult);
            /*0x245a1c8*/ System.IO.Stream GetRequestStream();
            /*0x245a2c8*/ System.IO.Stream GetRequestStream(ref System.Net.TransportContext context);
            /*0x245a308*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync();
            System.Threading.Tasks.Task<T> RunWithTimeout<T>(System.Func<System.Threading.CancellationToken, System.Threading.Tasks.Task<T>> func);
            /*0x245a3a0*/ System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(System.Threading.CancellationToken cancellationToken);
            /*0x245a4ac*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> GetResponseFromData(System.Net.WebResponseStream stream, System.Threading.CancellationToken cancellationToken);
            /*0x245a144*/ System.Net.WebException GetWebException(System.Exception e);
            /*0x245a828*/ System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state);
            /*0x245a9a4*/ System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult);
            /*0x245aac8*/ System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult, ref System.Net.TransportContext context);
            /*0x245ab34*/ System.Net.WebResponse GetResponse();
            /*0x245ac34*/ bool get_FinishedReading();
            /*0x245ac3c*/ void set_FinishedReading(bool value);
            /*0x2459e7c*/ bool get_Aborted();
            /*0x245ac48*/ void Abort();
            /*0x245ad58*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x245ad98*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x24569e4*/ void CheckRequestStarted();
            /*0x245add8*/ void DoContinueDelegate(int statusCode, System.Net.WebHeaderCollection headers);
            /*0x245adf4*/ void RewriteRedirectToGet();
            /*0x245ae6c*/ bool Redirect(System.Net.HttpStatusCode code, System.Net.WebResponse response);
            /*0x245b34c*/ string GetHeaders();
            /*0x245ba34*/ void DoPreAuthenticate();
            /*0x245bc34*/ byte[] GetRequestHeaders();
            /*0x245bf4c*/ System.ValueTuple<System.Net.WebOperation, bool> HandleNtlmAuth(System.Net.WebResponseStream stream, System.Net.HttpWebResponse response, System.Net.BufferOffsetSize writeBuffer, System.Threading.CancellationToken cancellationToken);
            /*0x245c1dc*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
            /*0x245c510*/ System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> GetRewriteHandler(System.Net.HttpWebResponse response, bool redirect);
            /*0x245c708*/ System.ValueTuple<bool, bool, System.Threading.Tasks.Task<System.Net.BufferOffsetSize>, System.Net.WebException> CheckFinalStatus(System.Net.HttpWebResponse response);
            /*0x245cc18*/ bool get_ReuseConnection();
            /*0x245cc20*/ void set_ReuseConnection(bool value);
            bool <RunWithTimeout>b__242_0<T>();
            /*0x245cd10*/ System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0();

            enum NtlmAuthState
            {
                None = 0,
                Challenge = 1,
                Response = 2,
            }

            struct AuthorizationState
            {
                /*0x10*/ System.Net.HttpWebRequest request;
                /*0x18*/ bool isProxy;
                /*0x19*/ bool isCompleted;
                /*0x1c*/ System.Net.HttpWebRequest.NtlmAuthState ntlm_auth_state;

                /*0x2456858*/ AuthorizationState(System.Net.HttpWebRequest request, bool isProxy);
                /*0x245ce34*/ bool get_IsCompleted();
                /*0x245ce3c*/ System.Net.HttpWebRequest.NtlmAuthState get_NtlmAuthState();
                /*0x245ce44*/ bool get_IsNtlmAuthenticated();
                /*0x245c1f4*/ bool CheckAuthorization(System.Net.WebResponse response, System.Net.HttpStatusCode code);
                /*0x245cb94*/ void Reset();
                /*0x245ce64*/ string ToString();
            }

            class <>c__24<T>
            {
                static /*0x0*/ System.Net.HttpWebRequest.<>c__241<T> <>9;
                static /*0x0*/ System.Func<System.Threading.Tasks.Task<T>, System.Nullable<int>> <>9__241_0;

                static <>c__24();
                <>c__24();
                System.Nullable<int> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t);
            }

            struct <RunWithTimeoutWorker>d__24<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Threading.Tasks.Task<T> workerTask;
                /*0x0*/ int timeout;
                /*0x0*/ System.Threading.CancellationTokenSource cts;
                /*0x0*/ System.Action abort;
                /*0x0*/ System.Func<bool> aborted;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <MyGetResponseAsync>d__243 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.HttpWebResponse> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x48*/ System.Net.WebOperation <operation>5__3;
                /*0x50*/ System.Net.WebException <throwMe>5__4;
                /*0x58*/ System.Net.HttpWebResponse <response>5__5;
                /*0x60*/ System.Net.WebResponseStream <stream>5__6;
                /*0x68*/ bool <redirect>5__7;
                /*0x69*/ bool <mustReadAll>5__8;
                /*0x70*/ System.Net.WebOperation <ntlm>5__9;
                /*0x78*/ System.Net.BufferOffsetSize <writeBuffer>5__10;
                /*0x80*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x90*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
                /*0xa0*/ System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebResponseStream> <>u__3;
                /*0xa8*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>u__4;

                /*0x245cf64*/ void MoveNext();
                /*0x245dda0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <GetResponseFromData>d__244 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.HttpWebResponse, bool, bool, System.Net.BufferOffsetSize, System.Net.WebOperation>> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.Net.WebResponseStream stream;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Net.HttpWebResponse <response>5__2;
                /*0x50*/ System.Net.WebException <throwMe>5__3;
                /*0x58*/ bool <redirect>5__4;
                /*0x59*/ bool <mustReadAll>5__5;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.BufferOffsetSize> <>u__2;

                /*0x245ddf8*/ void MoveNext();
                /*0x245e854*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <<GetRewriteHandler>b__271_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder;
                /*0x30*/ System.Net.HttpWebRequest <>4__this;
                /*0x38*/ System.IO.MemoryStream <ms>5__2;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x245e8ac*/ void MoveNext();
                /*0x245ecc4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class HttpWebResponse : System.Net.WebResponse, System.Runtime.Serialization.ISerializable, System.IDisposable
        {
            /*0x20*/ System.Uri uri;
            /*0x28*/ System.Net.WebHeaderCollection webHeaders;
            /*0x30*/ System.Net.CookieCollection cookieCollection;
            /*0x38*/ string method;
            /*0x40*/ System.Version version;
            /*0x48*/ System.Net.HttpStatusCode statusCode;
            /*0x50*/ string statusDescription;
            /*0x58*/ long contentLength;
            /*0x60*/ string contentType;
            /*0x68*/ System.Net.CookieContainer cookie_container;
            /*0x70*/ bool disposed;
            /*0x78*/ System.IO.Stream stream;

            static /*0x245f6bc*/ System.Exception GetMustImplement();
            /*0x245ed1c*/ HttpWebResponse();
            /*0x245ed24*/ HttpWebResponse(System.Uri uri, string method, System.Net.HttpStatusCode status, System.Net.WebHeaderCollection headers);
            /*0x245e568*/ HttpWebResponse(System.Uri uri, string method, System.Net.WebResponseStream stream, System.Net.CookieContainer container);
            /*0x245efec*/ HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x245f388*/ string get_CharacterSet();
            /*0x245f47c*/ string get_ContentEncoding();
            /*0x245f580*/ long get_ContentLength();
            /*0x245f588*/ string get_ContentType();
            /*0x245f61c*/ System.Net.CookieCollection get_Cookies();
            /*0x245f690*/ void set_Cookies(System.Net.CookieCollection value);
            /*0x245f6b4*/ System.Net.WebHeaderCollection get_Headers();
            /*0x245f718*/ bool get_IsMutuallyAuthenticated();
            /*0x245f73c*/ System.DateTime get_LastModified();
            /*0x245f868*/ string get_Method();
            /*0x245f880*/ System.Version get_ProtocolVersion();
            /*0x245f898*/ System.Uri get_ResponseUri();
            /*0x245f8b0*/ string get_Server();
            /*0x245f930*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x245f938*/ string get_StatusDescription();
            /*0x245f950*/ bool get_SupportsHeaders();
            /*0x245f958*/ string GetResponseHeader(string headerName);
            /*0x245f9c8*/ System.IO.Stream GetResponseStream();
            /*0x245fa64*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x245fa70*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x245fc30*/ void Close();
            /*0x245fc60*/ void System.IDisposable.Dispose();
            /*0x245fc70*/ void Dispose(bool disposing);
            /*0x245f4fc*/ void CheckDisposed();
            /*0x245edd8*/ void FillCookies();
        }

        interface ICredentialPolicy
        {
        }

        class MonoChunkParser
        {
            /*0x10*/ System.Net.WebHeaderCollection headers;
            /*0x18*/ int chunkSize;
            /*0x1c*/ int chunkRead;
            /*0x20*/ int totalWritten;
            /*0x24*/ System.Net.MonoChunkParser.State state;
            /*0x28*/ System.Text.StringBuilder saved;
            /*0x30*/ bool sawCR;
            /*0x31*/ bool gotit;
            /*0x34*/ int trailerState;
            /*0x38*/ System.Collections.ArrayList chunks;

            static /*0x2460bd4*/ string RemoveChunkExtension(string input);
            static /*0x2460b7c*/ void ThrowProtocolViolation(string message);
            /*0x245fc84*/ MonoChunkParser(System.Net.WebHeaderCollection headers);
            /*0x245fd3c*/ int Read(byte[] buffer, int offset, int size);
            /*0x245fd40*/ int ReadFromChunks(byte[] buffer, int offset, int size);
            /*0x24600b8*/ void Write(byte[] buffer, int offset, int size);
            /*0x24600d8*/ void InternalWrite(byte[] buffer, ref int offset, int size);
            /*0x2460a20*/ bool get_WantMore();
            /*0x2460a48*/ bool get_DataAvailable();
            /*0x2460b48*/ int get_ChunkLeft();
            /*0x246051c*/ System.Net.MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size);
            /*0x2460214*/ System.Net.MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size);
            /*0x2460654*/ System.Net.MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size);
            /*0x2460754*/ System.Net.MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size);

            enum State
            {
                None = 0,
                PartialSize = 1,
                Body = 2,
                BodyFinished = 3,
                Trailer = 4,
            }

            class Chunk
            {
                /*0x10*/ byte[] Bytes;
                /*0x18*/ int Offset;

                /*0x2460b54*/ Chunk(byte[] chunk);
                /*0x2460058*/ int Read(byte[] buffer, int offset, int size);
            }
        }

        class MonoChunkStream : System.Net.WebReadStream
        {
            /*0x40*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x48*/ System.Net.MonoChunkParser <Decoder>k__BackingField;

            static /*0x2460ebc*/ void ThrowExpectingChunkTrailer();
            /*0x2460c24*/ MonoChunkStream(System.Net.WebOperation operation, System.IO.Stream innerStream, System.Net.WebHeaderCollection headers);
            /*0x2460c1c*/ System.Net.MonoChunkParser get_Decoder();
            /*0x2460cb8*/ System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x2460ddc*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x2460f18*/ System.Threading.Tasks.Task <>n__0(System.Threading.CancellationToken cancellationToken);

            struct <ProcessReadAsync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.MonoChunkStream <>4__this;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ byte[] <moreBytes>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x2460f20*/ void MoveNext();
                /*0x246128c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <FinishReading>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.MonoChunkStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ byte[] <buffer>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2;

                /*0x24612e4*/ void MoveNext();
                /*0x24616b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class MonoHttpDate
        {
            static /*0x0*/ string rfc1123_date;
            static /*0x8*/ string rfc850_date;
            static /*0x10*/ string asctime_date;
            static /*0x18*/ string[] formats;

            static /*0x24616c4*/ MonoHttpDate();
            static /*0x2457a6c*/ System.DateTime Parse(string dateStr);
        }

        class NtlmClient : System.Net.IAuthenticationModule
        {
            /*0x10*/ System.Net.IAuthenticationModule authObject;

            /*0x2461854*/ NtlmClient();
            /*0x24618c0*/ System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2461990*/ System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials);
            /*0x2461998*/ string get_AuthenticationType();
        }

        class ServicePoint
        {
            /*0x10*/ System.Uri uri;
            /*0x18*/ System.DateTime lastDnsResolve;
            /*0x20*/ System.Version protocolVersion;
            /*0x28*/ System.Net.IPHostEntry host;
            /*0x30*/ bool usesProxy;
            /*0x31*/ bool sendContinue;
            /*0x32*/ bool useConnect;
            /*0x38*/ object hostE;
            /*0x40*/ bool useNagle;
            /*0x48*/ System.Net.BindIPEndPoint endPointCallback;
            /*0x50*/ bool tcp_keepalive;
            /*0x54*/ int tcp_keepalive_time;
            /*0x58*/ int tcp_keepalive_interval;
            /*0x5c*/ bool disposed;
            /*0x60*/ int connectionLeaseTimeout;
            /*0x64*/ int receiveBufferSize;
            /*0x68*/ System.Net.ServicePointManager.SPKey <Key>k__BackingField;
            /*0x70*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
            /*0x78*/ int connectionLimit;
            /*0x7c*/ int maxIdleTime;
            /*0x80*/ object m_ServerCertificateOrBytes;
            /*0x88*/ object m_ClientCertificateOrBytes;

            static /*0x2461e58*/ void PutBytes(byte[] bytes, uint v, int offset);
            /*0x24619d8*/ ServicePoint(System.Net.ServicePointManager.SPKey key, System.Uri uri, int connectionLimit, int maxIdleTime);
            /*0x2461c90*/ System.Net.ServicePointManager.SPKey get_Key();
            /*0x2461c98*/ System.Net.ServicePointScheduler get_Scheduler();
            /*0x2461ca0*/ void set_Scheduler(System.Net.ServicePointScheduler value);
            /*0x2461ca8*/ System.Uri get_Address();
            /*0x2461cb0*/ int get_ConnectionLimit();
            /*0x2461cb8*/ System.Version get_ProtocolVersion();
            /*0x2461cc0*/ void set_Expect100Continue(bool value);
            /*0x2461ccc*/ bool get_UseNagleAlgorithm();
            /*0x2461cd4*/ void set_UseNagleAlgorithm(bool value);
            /*0x245b998*/ bool get_SendContinue();
            /*0x2461ce0*/ void set_SendContinue(bool value);
            /*0x2461cec*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            /*0x2461da4*/ void KeepAliveSetup(System.Net.Sockets.Socket socket);
            /*0x2461f9c*/ bool get_UsesProxy();
            /*0x2461fa4*/ void set_UsesProxy(bool value);
            /*0x2461fb0*/ bool get_UseConnect();
            /*0x2461fb8*/ void set_UseConnect(bool value);
            /*0x2461fc4*/ bool get_HasTimedOut();
            /*0x24620f0*/ System.Net.IPHostEntry get_HostEntry();
            /*0x246249c*/ void SetVersion(System.Version version);
            /*0x2459988*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x246258c*/ bool CloseConnectionGroup(string connectionGroupName);
            /*0x2462788*/ void FreeServicePoint();
            /*0x2462798*/ void UpdateServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x24627d0*/ void UpdateClientCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate);
            /*0x2462808*/ bool CallEndPointDelegate(System.Net.Sockets.Socket sock, System.Net.IPEndPoint remote);
        }

        class ServicePointManager
        {
            static int DefaultNonPersistentConnectionLimit = 4;
            static int DefaultPersistentConnectionLimit = 10;
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Net.ServicePointManager.SPKey, System.Net.ServicePoint> servicePoints;
            static /*0x8*/ System.Net.ICertificatePolicy policy;
            static /*0x10*/ int defaultConnectionLimit;
            static /*0x14*/ int maxServicePointIdleTime;
            static /*0x18*/ int maxServicePoints;
            static /*0x1c*/ int dnsRefreshTimeout;
            static /*0x20*/ bool _checkCRL;
            static /*0x24*/ System.Net.SecurityProtocolType _securityProtocol;
            static /*0x28*/ bool expectContinue;
            static /*0x29*/ bool useNagle;
            static /*0x30*/ System.Net.ServerCertValidationCallback server_cert_cb;
            static /*0x38*/ bool tcp_keepalive;
            static /*0x3c*/ int tcp_keepalive_time;
            static /*0x40*/ int tcp_keepalive_interval;
            static /*0x48*/ System.Net.CipherSuitesCallback <ClientCipherSuitesCallback>k__BackingField;
            static /*0x50*/ System.Net.CipherSuitesCallback <ServerCipherSuitesCallback>k__BackingField;

            static /*0x24629ac*/ ServicePointManager();
            static /*0x2462a64*/ System.Net.ICertificatePolicy get_CertificatePolicy();
            static /*0x2462b30*/ void set_CertificatePolicy(System.Net.ICertificatePolicy value);
            static /*0x2462b8c*/ System.Net.ICertificatePolicy GetLegacyCertificatePolicy();
            static /*0x2462be4*/ bool get_CheckCertificateRevocationList();
            static /*0x2462c3c*/ void set_CheckCertificateRevocationList(bool value);
            static /*0x2462c94*/ int get_DefaultConnectionLimit();
            static /*0x2462cec*/ void set_DefaultConnectionLimit(int value);
            static /*0x2462d9c*/ System.Exception GetMustImplement();
            static /*0x2462df8*/ int get_DnsRefreshTimeout();
            static /*0x2462e50*/ void set_DnsRefreshTimeout(int value);
            static /*0x2462ee8*/ bool get_EnableDnsRoundRobin();
            static /*0x2462f1c*/ void set_EnableDnsRoundRobin(bool value);
            static /*0x2462f50*/ int get_MaxServicePointIdleTime();
            static /*0x2462fa8*/ void set_MaxServicePointIdleTime(int value);
            static /*0x2463058*/ int get_MaxServicePoints();
            static /*0x24630b0*/ void set_MaxServicePoints(int value);
            static /*0x246315c*/ bool get_ReusePort();
            static /*0x2463164*/ void set_ReusePort(bool value);
            static /*0x24631a4*/ System.Net.SecurityProtocolType get_SecurityProtocol();
            static /*0x24631fc*/ void set_SecurityProtocol(System.Net.SecurityProtocolType value);
            static /*0x2463258*/ System.Net.ServerCertValidationCallback get_ServerCertValidationCallback();
            static /*0x24632b0*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            static /*0x2463338*/ void set_ServerCertificateValidationCallback(System.Net.Security.RemoteCertificateValidationCallback value);
            static /*0x24633ec*/ System.Net.Security.EncryptionPolicy get_EncryptionPolicy();
            static /*0x24633f4*/ bool get_Expect100Continue();
            static /*0x246344c*/ void set_Expect100Continue(bool value);
            static /*0x24634a8*/ bool get_UseNagleAlgorithm();
            static /*0x2463500*/ void set_UseNagleAlgorithm(bool value);
            static /*0x246355c*/ bool get_DisableStrongCrypto();
            static /*0x2463564*/ bool get_DisableSendAuxRecord();
            static /*0x246356c*/ void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval);
            static /*0x2463678*/ System.Net.ServicePoint FindServicePoint(System.Uri address);
            static /*0x24636d0*/ System.Net.ServicePoint FindServicePoint(string uriString, System.Net.IWebProxy proxy);
            static /*0x2458a3c*/ System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy);
            static /*0x24637a4*/ void CloseConnectionGroup(string connectionGroupName);
            static /*0x2463bac*/ void RemoveServicePoint(System.Net.ServicePoint sp);
            static /*0x2463c44*/ System.Net.CipherSuitesCallback get_ClientCipherSuitesCallback();
            static /*0x2463c9c*/ void set_ClientCipherSuitesCallback(System.Net.CipherSuitesCallback value);
            static /*0x2463cf8*/ System.Net.CipherSuitesCallback get_ServerCipherSuitesCallback();
            static /*0x2463d50*/ void set_ServerCipherSuitesCallback(System.Net.CipherSuitesCallback value);
            /*0x2462a5c*/ ServicePointManager();

            class SPKey
            {
                /*0x10*/ System.Uri uri;
                /*0x18*/ System.Uri proxy;
                /*0x20*/ bool use_connect;

                /*0x2463768*/ SPKey(System.Uri uri, System.Uri proxy, bool use_connect);
                /*0x2463dac*/ bool get_UsesProxy();
                /*0x2463e0c*/ int GetHashCode();
                /*0x2463edc*/ bool Equals(object obj);
            }
        }

        class CipherSuitesCallback : System.MulticastDelegate
        {
            /*0x2463fd0*/ CipherSuitesCallback(object object, nint method);
            /*0x2464094*/ System.Collections.Generic.IEnumerable<string> Invoke(System.Net.SecurityProtocolType protocol, System.Collections.Generic.IEnumerable<string> allCiphers);
        }

        class ServicePointScheduler
        {
            static /*0x0*/ int nextId;
            /*0x10*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x18*/ int running;
            /*0x1c*/ int maxIdleTime;
            /*0x20*/ System.Net.ServicePointScheduler.AsyncManualResetEvent schedulerEvent;
            /*0x28*/ System.Net.ServicePointScheduler.ConnectionGroup defaultGroup;
            /*0x30*/ System.Collections.Generic.Dictionary<string, System.Net.ServicePointScheduler.ConnectionGroup> groups;
            /*0x38*/ System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebOperation>> operations;
            /*0x40*/ System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebConnection, System.Threading.Tasks.Task>> idleConnections;
            /*0x48*/ int currentConnections;
            /*0x4c*/ int connectionLimit;
            /*0x50*/ System.DateTime idleSince;
            /*0x58*/ int ID;

            static /*0x2465b18*/ System.Threading.Tasks.Task<bool> WaitAsync(System.Threading.Tasks.Task workerTask, int millisecondTimeout);
            /*0x2461ab8*/ ServicePointScheduler(System.Net.ServicePoint servicePoint, int connectionLimit, int maxIdleTime);
            /*0x24640a8*/ System.Net.ServicePoint get_ServicePoint();
            /*0x24640b0*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x24640b8*/ int get_MaxIdleTime();
            /*0x2464274*/ void Run();
            /*0x246456c*/ System.Threading.Tasks.Task RunScheduler();
            /*0x246463c*/ void Cleanup();
            /*0x2464870*/ void RunSchedulerIteration();
            /*0x2464ba0*/ bool OperationCompleted(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebOperation operation);
            /*0x246530c*/ void CloseIdleConnection(System.Net.ServicePointScheduler.ConnectionGroup group, System.Net.WebConnection connection);
            /*0x2464ac0*/ bool SchedulerIteration(System.Net.ServicePointScheduler.ConnectionGroup group);
            /*0x2465434*/ void RemoveOperation(System.Net.WebOperation operation);
            /*0x2464fb0*/ void RemoveIdleConnection(System.Net.WebConnection connection);
            /*0x2465500*/ void FinalCleanup();
            /*0x24624a4*/ void SendRequest(System.Net.WebOperation operation, string groupName);
            /*0x2462678*/ bool CloseConnectionGroup(string groupName);
            /*0x2465580*/ System.Net.ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name);
            /*0x2465af0*/ void OnConnectionCreated(System.Net.WebConnection connection);
            /*0x2465afc*/ void OnConnectionClosed(System.Net.WebConnection connection);
            /*0x2465c20*/ System.Threading.Tasks.Task <Run>b__31_0();

            class ConnectionGroup
            {
                static /*0x0*/ int nextId;
                /*0x10*/ System.Net.ServicePointScheduler <Scheduler>k__BackingField;
                /*0x18*/ string <Name>k__BackingField;
                /*0x20*/ int ID;
                /*0x28*/ System.Collections.Generic.LinkedList<System.Net.WebConnection> connections;
                /*0x30*/ System.Collections.Generic.LinkedList<System.Net.WebOperation> queue;

                /*0x2464168*/ ConnectionGroup(System.Net.ServicePointScheduler scheduler, string name);
                /*0x2465c24*/ System.Net.ServicePointScheduler get_Scheduler();
                /*0x24647fc*/ bool IsEmpty();
                /*0x2464f28*/ void RemoveConnection(System.Net.WebConnection connection);
                /*0x246507c*/ void Cleanup();
                /*0x24657d4*/ void Close();
                /*0x246577c*/ void EnqueueOperation(System.Net.WebOperation operation);
                /*0x2465344*/ System.Net.WebOperation GetNextOperation();
                /*0x2465c44*/ System.Net.WebConnection FindIdleConnection(System.Net.WebOperation operation);
                /*0x246516c*/ System.ValueTuple<System.Net.WebConnection, bool> CreateOrReuseConnection(System.Net.WebOperation operation, bool force);
            }

            class AsyncManualResetEvent
            {
                /*0x10*/ System.Threading.Tasks.TaskCompletionSource<bool> m_tcs;

                /*0x24640c0*/ AsyncManualResetEvent(bool state);
                /*0x24665b0*/ System.Threading.Tasks.Task<bool> WaitAsync(int millisecondTimeout);
                /*0x246433c*/ void Set();
                /*0x24649fc*/ void Reset();

                class <>c
                {
                    static /*0x0*/ System.Net.ServicePointScheduler.AsyncManualResetEvent.<> <>9;
                    static /*0x8*/ System.Func<object, bool> <>9__4_0;

                    static /*0x2466604*/ <>c();
                    /*0x2466668*/ <>c();
                    /*0x2466670*/ bool <Set>b__4_0(object s);
                }
            }

            struct <RunScheduler>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.ServicePointScheduler <>4__this;
                /*0x38*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebOperation> <operationArray>5__2;
                /*0x40*/ System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup, System.Net.WebConnection, System.Threading.Tasks.Task> <idleArray>5__3;
                /*0x48*/ System.Collections.Generic.List<System.Threading.Tasks.Task> <taskList>5__4;
                /*0x50*/ System.Threading.Tasks.Task<bool> <schedulerTask>5__5;
                /*0x58*/ bool <finalCleanup>5__6;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0x246670c*/ void MoveNext();
                /*0x2467200*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WaitAsync>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ int millisecondTimeout;
                /*0x38*/ System.Threading.Tasks.Task workerTask;
                /*0x40*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x48*/ System.Threading.Tasks.Task <timeoutTask>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0x246720c*/ void MoveNext();
                /*0x2467658*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource<T>
        {
            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion;
            /*0x0*/ System.Net.WebCompletionSource.Result<T> currentResult;

            WebCompletionSource(bool runAsync);
            System.Net.WebCompletionSource.Result<T> get_CurrentResult();
            System.Threading.Tasks.Task get_Task();
            bool TrySetCompleted(T argument);
            bool TrySetCompleted();
            bool TrySetCanceled();
            bool TrySetCanceled(System.OperationCanceledException error);
            bool TrySetException(System.Exception error);
            void ThrowOnError();
            System.Threading.Tasks.Task<T> WaitForCompletion();

            enum Status<T>
            {
                Running = 0,
                Completed = 1,
                Canceled = 2,
                Faulted = 3,
            }

            class Result<T>
            {
                /*0x0*/ System.Net.WebCompletionSource.Status<T> <Status>k__BackingField;
                /*0x0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo <Error>k__BackingField;
                /*0x0*/ T <Argument>k__BackingField;

                Result(T argument);
                Result(System.Net.WebCompletionSource.Status<T> state, System.Runtime.ExceptionServices.ExceptionDispatchInfo error);
                System.Net.WebCompletionSource.Status<T> get_Status();
                bool get_Success();
                System.Runtime.ExceptionServices.ExceptionDispatchInfo get_Error();
                T get_Argument();
            }

            struct <WaitForCompletion>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ System.Net.WebCompletionSource<T> <>4__this;
                /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebCompletionSource.Result<T>> <>u__1;

                void MoveNext();
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebCompletionSource : System.Net.WebCompletionSource<object>
        {
            /*0x245dd54*/ WebCompletionSource();
        }

        enum ReadState
        {
            None = 0,
            Status = 1,
            Headers = 2,
            Content = 3,
            Aborted = 4,
        }

        class WebConnection : System.IDisposable
        {
            /*0x10*/ System.Net.NetworkCredential ntlm_credentials;
            /*0x18*/ bool ntlm_authenticated;
            /*0x19*/ bool unsafe_sharing;
            /*0x20*/ System.IO.Stream networkStream;
            /*0x28*/ System.Net.Sockets.Socket socket;
            /*0x30*/ Mono.Net.Security.MonoTlsStream monoTlsStream;
            /*0x38*/ System.Net.WebConnectionTunnel tunnel;
            /*0x40*/ int disposed;
            /*0x48*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x50*/ System.DateTime idleSince;
            /*0x58*/ System.Net.WebOperation currentOperation;

            static /*0x2467a8c*/ System.Net.WebException GetException(System.Net.WebExceptionStatus status, System.Exception error);
            static /*0x2467c18*/ bool ReadLine(byte[] buffer, ref int start, int max, ref string output);
            /*0x2466588*/ WebConnection(System.Net.ServicePoint sPoint);
            /*0x24676b0*/ System.Net.ServicePoint get_ServicePoint();
            /*0x24676b8*/ bool CanReuse();
            /*0x24676e8*/ bool CheckReusable();
            /*0x2467784*/ System.Threading.Tasks.Task Connect(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x2467868*/ System.Threading.Tasks.Task<bool> CreateStream(System.Net.WebOperation operation, bool reused, System.Threading.CancellationToken cancellationToken);
            /*0x2467988*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(System.Net.WebOperation operation, System.Threading.CancellationToken cancellationToken);
            /*0x2465f58*/ bool CanReuseConnection(System.Net.WebOperation operation);
            /*0x2467e00*/ bool PrepareSharingNtlm(System.Net.WebOperation operation);
            /*0x2468124*/ void Reset();
            /*0x24681e8*/ void Close(bool reset);
            /*0x24682b0*/ void CloseSocket();
            /*0x2465c34*/ bool get_Closed();
            /*0x246851c*/ System.DateTime get_IdleSince();
            /*0x246638c*/ bool StartOperation(System.Net.WebOperation operation, bool reused);
            /*0x2464dc0*/ bool Continue(System.Net.WebOperation next);
            /*0x2468524*/ void Dispose(bool disposing);
            /*0x2465c2c*/ void Dispose();
            /*0x24681dc*/ void ResetNtlm();
            /*0x246855c*/ bool get_NtlmAuthenticated();
            /*0x2468564*/ void set_NtlmAuthenticated(bool value);
            /*0x2468570*/ System.Net.NetworkCredential get_NtlmCredential();
            /*0x2468578*/ void set_NtlmCredential(System.Net.NetworkCredential value);
            /*0x2468580*/ bool get_UnsafeAuthenticatedConnectionSharing();
            /*0x2468588*/ void set_UnsafeAuthenticatedConnectionSharing(bool value);

            class <>c
            {
                static /*0x0*/ System.Net.WebConnection.<> <>9;
                static /*0x8*/ System.Func<System.Net.IPEndPoint, System.AsyncCallback, object, System.IAsyncResult> <>9__16_0;
                static /*0x10*/ System.Action<System.IAsyncResult> <>9__16_1;

                static /*0x2468594*/ <>c();
                /*0x24685f8*/ <>c();
                /*0x2468600*/ System.IAsyncResult <Connect>b__16_0(System.Net.IPEndPoint targetEndPoint, System.AsyncCallback callback, object state);
                /*0x24686a0*/ void <Connect>b__16_1(System.IAsyncResult asyncResult);
            }

            struct <Connect>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ System.Exception <connectException>5__2;
                /*0x50*/ System.Net.IPAddress[] <>7__wrap2;
                /*0x58*/ int <>7__wrap3;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x2468794*/ void MoveNext();
                /*0x246905c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <CreateStream>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ System.Net.WebConnection <>4__this;
                /*0x38*/ System.Net.WebOperation operation;
                /*0x40*/ bool reused;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.Sockets.NetworkStream <stream>5__2;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__2;

                /*0x2469068*/ void MoveNext();
                /*0x24696dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitConnection>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.WebRequestStream> <>t__builder;
                /*0x30*/ System.Net.WebOperation operation;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.WebConnection <>4__this;
                /*0x48*/ bool <reused>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;

                /*0x2469734*/ void MoveNext();
                /*0x2469c08*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebConnectionStream : System.IO.Stream
        {
            /*0x28*/ bool closed;
            /*0x29*/ bool disposed;
            /*0x30*/ object locker;
            /*0x38*/ int read_timeout;
            /*0x3c*/ int write_timeout;
            /*0x40*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x48*/ System.Net.WebConnection <Connection>k__BackingField;
            /*0x50*/ System.Net.WebOperation <Operation>k__BackingField;

            /*0x2469c60*/ WebConnectionStream(System.Net.WebConnection cnc, System.Net.WebOperation operation);
            /*0x2469d1c*/ System.Net.HttpWebRequest get_Request();
            /*0x2469d24*/ System.Net.WebConnection get_Connection();
            /*0x2469d2c*/ System.Net.WebOperation get_Operation();
            /*0x2469d34*/ System.Net.ServicePoint get_ServicePoint();
            /*0x2469d50*/ bool get_CanTimeout();
            /*0x2469d58*/ int get_ReadTimeout();
            /*0x2469d60*/ void set_ReadTimeout(int value);
            /*0x2469dc4*/ int get_WriteTimeout();
            /*0x2469dcc*/ void set_WriteTimeout(int value);
            /*0x2469e30*/ System.Exception GetException(System.Exception e);
            bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x2469f94*/ int Read(byte[] buffer, int offset, int count);
            /*0x246a23c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x246a410*/ int EndRead(System.IAsyncResult r);
            /*0x246a534*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cb, object state);
            /*0x246a708*/ void EndWrite(System.IAsyncResult r);
            /*0x246a800*/ void Write(byte[] buffer, int offset, int count);
            /*0x246a9fc*/ void Flush();
            /*0x246aa00*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
            /*0x245cb88*/ void InternalClose();
            void Close_internal(ref bool disposed);
            /*0x246aac0*/ void Close();
            /*0x246aad4*/ long Seek(long a, System.IO.SeekOrigin b);
            /*0x246ab24*/ void SetLength(long a);
            /*0x246ab74*/ bool get_CanSeek();
            /*0x246ab7c*/ long get_Length();
            /*0x246abcc*/ long get_Position();
            /*0x246ac1c*/ void set_Position(long value);
        }

        class WebConnectionTunnel
        {
            /*0x10*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x18*/ System.Uri <ConnectUri>k__BackingField;
            /*0x20*/ System.Net.HttpWebRequest connectRequest;
            /*0x28*/ System.Net.WebConnectionTunnel.NtlmAuthState ntlmAuthState;
            /*0x2c*/ bool <Success>k__BackingField;
            /*0x2d*/ bool <CloseConnection>k__BackingField;
            /*0x30*/ int <StatusCode>k__BackingField;
            /*0x38*/ string <StatusDescription>k__BackingField;
            /*0x40*/ string[] <Challenge>k__BackingField;
            /*0x48*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x50*/ System.Version <ProxyVersion>k__BackingField;
            /*0x58*/ byte[] <Data>k__BackingField;

            /*0x246ac7c*/ WebConnectionTunnel(System.Net.HttpWebRequest request, System.Uri connectUri);
            /*0x246ac6c*/ System.Net.HttpWebRequest get_Request();
            /*0x246ac74*/ System.Uri get_ConnectUri();
            /*0x246aca8*/ bool get_Success();
            /*0x246acb0*/ void set_Success(bool value);
            /*0x246acbc*/ bool get_CloseConnection();
            /*0x246acc4*/ void set_CloseConnection(bool value);
            /*0x246acd0*/ int get_StatusCode();
            /*0x246acd8*/ void set_StatusCode(int value);
            /*0x246ace0*/ void set_StatusDescription(string value);
            /*0x246ace8*/ string[] get_Challenge();
            /*0x246acf0*/ void set_Challenge(string[] value);
            /*0x246acf8*/ System.Net.WebHeaderCollection get_Headers();
            /*0x246ad00*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x246ad08*/ System.Version get_ProxyVersion();
            /*0x246ad10*/ void set_ProxyVersion(System.Version value);
            /*0x246ad18*/ byte[] get_Data();
            /*0x246ad20*/ void set_Data(byte[] value);
            /*0x246ad28*/ System.Threading.Tasks.Task Initialize(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x246ae0c*/ System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> ReadHeaders(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            /*0x246af14*/ void FlushContents(System.IO.Stream stream, int contentLength);

            enum NtlmAuthState
            {
                None = 0,
                Challenge = 1,
                Response = 2,
            }

            struct <Initialize>d__42 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebConnectionTunnel <>4__this;
                /*0x38*/ System.IO.Stream stream;
                /*0x40*/ System.Threading.CancellationToken cancellationToken;
                /*0x48*/ bool <have_auth>5__2;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>u__2;

                /*0x246afa8*/ void MoveNext();
                /*0x246bd84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadHeaders>d__43 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.WebHeaderCollection, System.Byte[], int>> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.IO.Stream stream;
                /*0x40*/ System.Net.WebConnectionTunnel <>4__this;
                /*0x48*/ byte[] <retBuffer>5__2;
                /*0x50*/ int <status>5__3;
                /*0x58*/ byte[] <buffer>5__4;
                /*0x60*/ System.IO.MemoryStream <ms>5__5;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x246bd90*/ void MoveNext();
                /*0x246c578*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebOperation
        {
            /*0x10*/ System.Net.HttpWebRequest <Request>k__BackingField;
            /*0x18*/ System.Net.WebConnection <Connection>k__BackingField;
            /*0x20*/ System.Net.ServicePoint <ServicePoint>k__BackingField;
            /*0x28*/ System.Net.BufferOffsetSize <WriteBuffer>k__BackingField;
            /*0x30*/ bool <IsNtlmChallenge>k__BackingField;
            /*0x38*/ System.Threading.CancellationTokenSource cts;
            /*0x40*/ System.Net.WebCompletionSource<System.Net.WebRequestStream> requestTask;
            /*0x48*/ System.Net.WebCompletionSource<System.Net.WebRequestStream> requestWrittenTask;
            /*0x50*/ System.Net.WebCompletionSource<System.Net.WebResponseStream> responseTask;
            /*0x58*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> finishedTask;
            /*0x60*/ System.Net.WebRequestStream writeStream;
            /*0x68*/ System.Net.WebResponseStream responseStream;
            /*0x70*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo disposedInfo;
            /*0x78*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo closedInfo;
            /*0x80*/ System.Net.WebOperation priorityRequest;
            /*0x88*/ int requestSent;
            /*0x8c*/ int finished;

            /*0x246c608*/ WebOperation(System.Net.HttpWebRequest request, System.Net.BufferOffsetSize writeBuffer, bool isNtlmChallenge, System.Threading.CancellationToken cancellationToken);
            /*0x246c5d0*/ System.Net.HttpWebRequest get_Request();
            /*0x246c5d8*/ System.Net.WebConnection get_Connection();
            /*0x246c5e0*/ void set_Connection(System.Net.WebConnection value);
            /*0x246c5e8*/ System.Net.ServicePoint get_ServicePoint();
            /*0x246c5f0*/ void set_ServicePoint(System.Net.ServicePoint value);
            /*0x246c5f8*/ System.Net.BufferOffsetSize get_WriteBuffer();
            /*0x246c600*/ bool get_IsNtlmChallenge();
            /*0x246c79c*/ bool get_Aborted();
            /*0x246c7ec*/ bool get_Closed();
            /*0x246c818*/ void Abort();
            /*0x246ca14*/ void Close();
            /*0x246c948*/ void SetCanceled();
            /*0x246cd04*/ void SetError(System.Exception error);
            /*0x246c858*/ System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo, bool> SetDisposed(ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x246cda8*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x246ce4c*/ void ThrowIfDisposed();
            /*0x246ceac*/ void ThrowIfDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x246cef0*/ void ThrowIfClosedOrDisposed();
            /*0x246cf50*/ void ThrowIfClosedOrDisposed(System.Threading.CancellationToken cancellationToken);
            /*0x246cdf4*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref System.Runtime.ExceptionServices.ExceptionDispatchInfo field);
            /*0x246cf9c*/ void RegisterRequest(System.Net.ServicePoint servicePoint, System.Net.WebConnection connection);
            /*0x246d1f0*/ void SetPriorityRequest(System.Net.WebOperation operation);
            /*0x246d37c*/ System.Threading.Tasks.Task<System.IO.Stream> GetRequestStream();
            /*0x246d46c*/ System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal();
            /*0x246d4bc*/ System.Net.WebRequestStream get_WriteStream();
            /*0x246d4d4*/ System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream();
            /*0x246d524*/ System.Net.WebCompletionSource<System.ValueTuple<bool, System.Net.WebOperation>> get_Finished();
            /*0x246d52c*/ void Run();
            /*0x246d5c0*/ void CompleteRequestWritten(System.Net.WebRequestStream stream, System.Exception error);
            /*0x246cac0*/ void Finish(bool ok, System.Exception error);
            /*0x246d640*/ void <RegisterRequest>b__48_0();

            struct <GetRequestStream>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Net.WebOperation <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;

                /*0x246d664*/ void MoveNext();
                /*0x246d880*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Run>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ System.Net.WebOperation <>4__this;
                /*0x40*/ System.Net.WebRequestStream <requestStream>5__2;
                /*0x48*/ System.Net.WebResponseStream <stream>5__3;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebRequestStream> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x246d8d8*/ void MoveNext();
                /*0x246e09c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebReadStream : System.IO.Stream
        {
            /*0x28*/ System.Net.WebOperation <Operation>k__BackingField;
            /*0x30*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x38*/ bool disposed;

            /*0x246e0b8*/ WebReadStream(System.Net.WebOperation operation, System.IO.Stream innerStream);
            /*0x246e0a8*/ System.Net.WebOperation get_Operation();
            /*0x246e0b0*/ System.IO.Stream get_InnerStream();
            /*0x246e128*/ long get_Length();
            /*0x246e168*/ long get_Position();
            /*0x246e1a8*/ void set_Position(long value);
            /*0x246e1e8*/ bool get_CanSeek();
            /*0x246e1f0*/ bool get_CanRead();
            /*0x246e1f8*/ bool get_CanWrite();
            /*0x246e200*/ void SetLength(long value);
            /*0x246e240*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x246e280*/ void Write(byte[] buffer, int offset, int count);
            /*0x246e2c0*/ void Flush();
            /*0x246e300*/ System.Exception GetException(System.Exception e);
            /*0x246e468*/ int Read(byte[] buffer, int offset, int size);
            /*0x246e6d0*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback cb, object state);
            /*0x246e8a0*/ int EndRead(System.IAsyncResult r);
            /*0x246e9c4*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            System.Threading.Tasks.Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x246eae4*/ System.Threading.Tasks.Task FinishReading(System.Threading.CancellationToken cancellationToken);
            /*0x246ebe8*/ void Dispose(bool disposing);

            struct <ReadAsync>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Net.WebReadStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ byte[] buffer;
                /*0x48*/ int offset;
                /*0x4c*/ int size;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x246ec34*/ void MoveNext();
                /*0x246f1b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebRequestStream : System.Net.WebConnectionStream
        {
            static /*0x0*/ byte[] crlf;
            /*0x58*/ System.IO.MemoryStream writeBuffer;
            /*0x60*/ bool requestWritten;
            /*0x61*/ bool allowBuffering;
            /*0x62*/ bool sendChunked;
            /*0x68*/ System.Net.WebCompletionSource pendingWrite;
            /*0x70*/ long totalWritten;
            /*0x78*/ byte[] headers;
            /*0x80*/ bool headersSent;
            /*0x84*/ int completeRequestWritten;
            /*0x88*/ int chunkTrailerWritten;
            /*0x90*/ System.IO.Stream <InnerStream>k__BackingField;
            /*0x98*/ bool <KeepAlive>k__BackingField;

            static /*0x24700ac*/ WebRequestStream();
            /*0x246f210*/ WebRequestStream(System.Net.WebConnection connection, System.Net.WebOperation operation, System.IO.Stream stream, System.Net.WebConnectionTunnel tunnel);
            /*0x246f374*/ System.IO.Stream get_InnerStream();
            /*0x246f37c*/ bool get_KeepAlive();
            /*0x246f384*/ bool get_CanRead();
            /*0x246f38c*/ bool get_CanWrite();
            /*0x246f394*/ bool get_HasWriteBuffer();
            /*0x246f3c8*/ int get_WriteBufferLength();
            /*0x246f410*/ System.Net.BufferOffsetSize GetWriteBuffer();
            /*0x246f4f4*/ System.Threading.Tasks.Task FinishWriting(System.Threading.CancellationToken cancellationToken);
            /*0x246f5cc*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x246f828*/ System.Threading.Tasks.Task WriteAsyncInner(byte[] buffer, int offset, int size, System.Net.WebCompletionSource completion, System.Threading.CancellationToken cancellationToken);
            /*0x246f92c*/ System.Threading.Tasks.Task ProcessWrite(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x246fa2c*/ void CheckWriteOverflow(long contentLength, long totalWritten, long size);
            /*0x246de60*/ System.Threading.Tasks.Task Initialize(System.Threading.CancellationToken cancellationToken);
            /*0x246fad0*/ System.Threading.Tasks.Task SetHeadersAsync(bool setInternalLength, System.Threading.CancellationToken cancellationToken);
            /*0x246fbb4*/ System.Threading.Tasks.Task WriteRequestAsync(System.Threading.CancellationToken cancellationToken);
            /*0x246fc90*/ System.Threading.Tasks.Task WriteChunkTrailer_inner(System.Threading.CancellationToken cancellationToken);
            /*0x246fd68*/ System.Threading.Tasks.Task WriteChunkTrailer();
            /*0x246fac8*/ void KillBuffer();
            /*0x246fe3c*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x246feec*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x246ff2c*/ void Close_internal(ref bool disposed);

            struct <FinishWriting>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x2470140*/ void MoveNext();
                /*0x2470420*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteAsyncInner>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int offset;
                /*0x44*/ int size;
                /*0x48*/ System.Threading.CancellationToken cancellationToken;
                /*0x50*/ System.Net.WebCompletionSource completion;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x68*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x247042c*/ void MoveNext();
                /*0x24708d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessWrite>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ int size;
                /*0x48*/ byte[] buffer;
                /*0x50*/ int offset;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x24708e4*/ void MoveNext();
                /*0x2470e18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Initialize>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x2470e24*/ void MoveNext();
                /*0x247112c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SetHeadersAsync>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool setInternalLength;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x2471138*/ void MoveNext();
                /*0x24717d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteRequestAsync>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__2;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                /*0x24717dc*/ void MoveNext();
                /*0x2471c88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer_inner>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0x2471c94*/ void MoveNext();
                /*0x2471ec4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <WriteChunkTrailer>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebRequestStream <>4__this;
                /*0x38*/ System.Threading.CancellationTokenSource <cts>5__2;
                /*0x40*/ System.Threading.Tasks.Task <timeoutTask>5__3;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                /*0x2471ed0*/ void MoveNext();
                /*0x247258c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebResponseStream : System.Net.WebConnectionStream
        {
            /*0x58*/ System.Net.WebReadStream innerStream;
            /*0x60*/ bool nextReadCalled;
            /*0x61*/ bool bufferedEntireContent;
            /*0x68*/ System.Net.WebCompletionSource pendingRead;
            /*0x70*/ object locker;
            /*0x78*/ int nestedRead;
            /*0x7c*/ bool read_eof;
            /*0x80*/ System.Net.WebRequestStream <RequestStream>k__BackingField;
            /*0x88*/ System.Net.WebHeaderCollection <Headers>k__BackingField;
            /*0x90*/ System.Net.HttpStatusCode <StatusCode>k__BackingField;
            /*0x98*/ string <StatusDescription>k__BackingField;
            /*0xa0*/ System.Version <Version>k__BackingField;
            /*0xa8*/ bool <KeepAlive>k__BackingField;
            /*0xa9*/ bool <ChunkedRead>k__BackingField;

            /*0x246df3c*/ WebResponseStream(System.Net.WebRequestStream request);
            /*0x2472598*/ System.Net.WebRequestStream get_RequestStream();
            /*0x24725a0*/ System.Net.WebHeaderCollection get_Headers();
            /*0x24725a8*/ void set_Headers(System.Net.WebHeaderCollection value);
            /*0x24725b0*/ System.Net.HttpStatusCode get_StatusCode();
            /*0x24725b8*/ void set_StatusCode(System.Net.HttpStatusCode value);
            /*0x24725c0*/ string get_StatusDescription();
            /*0x24725c8*/ void set_StatusDescription(string value);
            /*0x24725d0*/ System.Version get_Version();
            /*0x24725d8*/ void set_Version(System.Version value);
            /*0x24725e0*/ bool get_KeepAlive();
            /*0x24725e8*/ void set_KeepAlive(bool value);
            /*0x24725f4*/ bool get_CanRead();
            /*0x24725fc*/ bool get_CanWrite();
            /*0x2472604*/ bool get_ChunkedRead();
            /*0x247260c*/ void set_ChunkedRead(bool value);
            /*0x2472618*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x247274c*/ System.Threading.Tasks.Task<int> ProcessRead(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
            /*0x24729d4*/ bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, ref int result);
            /*0x2472aa0*/ bool get_ExpectContent();
            /*0x2472b30*/ void Initialize(System.Net.BufferOffsetSize buffer);
            /*0x2473058*/ System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(System.Threading.CancellationToken cancellationToken);
            /*0x2473158*/ System.Threading.Tasks.Task ReadAllAsync(bool resending, System.Threading.CancellationToken cancellationToken);
            /*0x247324c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
            /*0x24732e8*/ void Close_internal(ref bool disposed);
            /*0x2473370*/ System.Net.WebException GetReadException(System.Net.WebExceptionStatus status, System.Exception error, string where);
            /*0x246dfc0*/ System.Threading.Tasks.Task InitReadAsync(System.Threading.CancellationToken cancellationToken);
            /*0x247360c*/ bool GetResponse(System.Net.BufferOffsetSize buffer, ref int pos, ref System.Net.ReadState state);

            struct <ReadAsync>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int offset;
                /*0x44*/ int count;
                /*0x48*/ System.Net.WebResponseStream <>4__this;
                /*0x50*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x58*/ int <nbytes>5__3;
                /*0x60*/ System.Exception <throwMe>5__4;
                /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1;
                /*0x78*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2;

                /*0x2473dc4*/ void MoveNext();
                /*0x24746a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Net.WebResponseStream <>4__this;
                /*0x18*/ byte[] buffer;
                /*0x20*/ int offset;
                /*0x24*/ int size;

                /*0x24729cc*/ <>c__DisplayClass41_0();
                /*0x24746f8*/ System.Threading.Tasks.Task<int> <ProcessRead>b__0(System.Threading.CancellationToken ct);
                /*0x2474734*/ void <ProcessRead>b__1();
                /*0x2474770*/ bool <ProcessRead>b__2();
            }

            struct <ReadAllAsyncInner>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Byte[]> <>t__builder;
                /*0x30*/ System.Threading.CancellationToken cancellationToken;
                /*0x38*/ System.Net.WebResponseStream <>4__this;
                /*0x40*/ long <maximumSize>5__2;
                /*0x48*/ System.IO.MemoryStream <ms>5__3;
                /*0x50*/ byte[] <buffer>5__4;
                /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x2474790*/ void MoveNext();
                /*0x2474cfc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadAllAsync>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ bool resending;
                /*0x48*/ System.Net.WebCompletionSource <completion>5__2;
                /*0x50*/ System.Threading.CancellationTokenSource <timeoutCts>5__3;
                /*0x58*/ System.Threading.Tasks.Task <timeoutTask>5__4;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;
                /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Byte[]> <>u__2;

                /*0x2474d54*/ void MoveNext();
                /*0x24756a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitReadAsync>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Net.WebResponseStream <>4__this;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.Net.BufferOffsetSize <buffer>5__2;
                /*0x48*/ System.Net.ReadState <state>5__3;
                /*0x4c*/ int <position>5__4;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

                /*0x24756b4*/ void MoveNext();
                /*0x2475d6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace NetworkInformation
        {
            class IPGlobalProperties
            {
                static /*0x2475d78*/ System.Net.NetworkInformation.IPGlobalProperties GetIPGlobalProperties();
                static /*0x2475dcc*/ System.Net.NetworkInformation.IPGlobalProperties InternalGetIPGlobalProperties();
                /*0x2475dd0*/ IPGlobalProperties();
                string get_DomainName();
            }

            class NetworkInformationException : System.ComponentModel.Win32Exception
            {
                /*0x2475dd8*/ NetworkInformationException();
                /*0x2475e3c*/ NetworkInformationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x2475e44*/ int get_ErrorCode();
            }

            enum NetworkInterfaceComponent
            {
                IPv4 = 0,
                IPv6 = 1,
            }

            class IPGlobalPropertiesFactoryPal
            {
                static /*0x2475d7c*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }

            class CommonUnixIPGlobalProperties : System.Net.NetworkInformation.IPGlobalProperties
            {
                static /*0x2475ef8*/ int getdomainname(byte[] name, int len);
                /*0x2476100*/ CommonUnixIPGlobalProperties();
                /*0x2475f84*/ string get_DomainName();
            }

            class UnixIPGlobalProperties : System.Net.NetworkInformation.CommonUnixIPGlobalProperties
            {
                /*0x2476108*/ UnixIPGlobalProperties();
            }

            class UnixNoLibCIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                /*0x2476158*/ UnixNoLibCIPGlobalProperties();
                /*0x2476110*/ string get_DomainName();
            }

            class MibIPGlobalProperties : System.Net.NetworkInformation.UnixIPGlobalProperties
            {
                static /*0x0*/ char[] wsChars;
                /*0x10*/ string StatisticsFile;
                /*0x18*/ string StatisticsFileIPv6;
                /*0x20*/ string TcpFile;
                /*0x28*/ string Tcp6File;
                /*0x30*/ string UdpFile;
                /*0x38*/ string Udp6File;

                static /*0x24762c8*/ MibIPGlobalProperties();
                /*0x2476160*/ MibIPGlobalProperties(string procDir);
            }

            class UnixIPGlobalPropertiesFactoryPal
            {
                static /*0x0*/ bool <PlatformNeedsLibCWorkaround>k__BackingField;

                static /*0x247635c*/ bool get_PlatformNeedsLibCWorkaround();
                static /*0x2475e4c*/ System.Net.NetworkInformation.IPGlobalProperties Create();
            }
        }

        namespace Configuration
        {
            class DefaultProxySectionInternal
            {
                static /*0x0*/ object classSyncObject;
                /*0x10*/ System.Net.IWebProxy webProxy;

                static /*0x24763a4*/ System.Net.IWebProxy GetDefaultProxy_UsingOldMonoCode();
                static /*0x24763ac*/ System.Net.IWebProxy GetSystemWebProxy();
                static /*0x24763b4*/ object get_ClassSyncObject();
                static /*0x2476454*/ System.Net.Configuration.DefaultProxySectionInternal GetSection();
                /*0x2476568*/ DefaultProxySectionInternal();
                /*0x2476570*/ System.Net.IWebProxy get_WebProxy();
            }

            class SettingsSectionInternal
            {
                static /*0x0*/ System.Net.Configuration.SettingsSectionInternal instance;
                /*0x10*/ bool HttpListenerUnescapeRequestUrl;
                /*0x14*/ System.Net.Sockets.IPProtectionLevel IPProtectionLevel;

                static /*0x24765f0*/ SettingsSectionInternal();
                static /*0x2476578*/ System.Net.Configuration.SettingsSectionInternal get_Section();
                /*0x24765d8*/ SettingsSectionInternal();
                /*0x24765d0*/ bool get_Ipv6Enabled();
            }
        }

        namespace Cache
        {
            class RequestCache
            {
                static /*0x0*/ char[] LineSplits;

                static /*0x2476664*/ RequestCache();
            }

            class RequestCacheManager
            {
                static /*0x0*/ System.Net.Cache.RequestCachingSectionInternal s_CacheConfigSettings;
                static /*0x8*/ System.Net.Cache.RequestCacheBinding s_BypassCacheBinding;
                static /*0x10*/ System.Net.Cache.RequestCacheBinding s_DefaultGlobalBinding;
                static /*0x18*/ System.Net.Cache.RequestCacheBinding s_DefaultHttpBinding;
                static /*0x20*/ System.Net.Cache.RequestCacheBinding s_DefaultFtpBinding;

                static /*0x2476c94*/ RequestCacheManager();
                static /*0x24766f8*/ System.Net.Cache.RequestCacheBinding GetBinding(string internedScheme);
                static /*0x2476a78*/ void SetBinding(string uriScheme, System.Net.Cache.RequestCacheBinding binding);
                static /*0x24768f4*/ void LoadConfigSettings();
            }

            class RequestCacheValidator
            {
                /*0x2476e00*/ object CreateValidator();
            }

            class RequestCachingSectionInternal
            {
                /*0x10*/ bool DisableAllCaching;

                /*0x2476c84*/ RequestCachingSectionInternal();
            }

            class RequestCacheBinding
            {
                /*0x10*/ System.Net.Cache.RequestCache m_RequestCache;
                /*0x18*/ System.Net.Cache.RequestCacheValidator m_CacheValidator;
                /*0x20*/ System.Net.Cache.RequestCachePolicy m_Policy;

                /*0x2476dc4*/ RequestCacheBinding(System.Net.Cache.RequestCache requestCache, System.Net.Cache.RequestCacheValidator cacheValidator, System.Net.Cache.RequestCachePolicy policy);
                /*0x2476e40*/ System.Net.Cache.RequestCache get_Cache();
                /*0x2476e48*/ System.Net.Cache.RequestCacheValidator get_Validator();
                /*0x2476e50*/ System.Net.Cache.RequestCachePolicy get_Policy();
            }

            enum RequestCacheLevel
            {
                Default = 0,
                BypassCache = 1,
                CacheOnly = 2,
                CacheIfAvailable = 3,
                Revalidate = 4,
                Reload = 5,
                NoCacheNoStore = 6,
            }

            class RequestCachePolicy
            {
                /*0x10*/ System.Net.Cache.RequestCacheLevel m_Level;

                /*0x2476d48*/ RequestCachePolicy(System.Net.Cache.RequestCacheLevel level);
                /*0x2476e58*/ System.Net.Cache.RequestCacheLevel get_Level();
                /*0x2476e60*/ string ToString();
            }

            class RequestCacheProtocol
            {
                /*0x2476ef8*/ RequestCacheProtocol(object arg1, object arg2);
            }
        }

        namespace Sockets
        {
            class MultipleConnectAsync
            {
                /*0x10*/ System.Net.Sockets.SocketAsyncEventArgs _userArgs;
                /*0x18*/ System.Net.Sockets.SocketAsyncEventArgs _internalArgs;
                /*0x20*/ System.Net.DnsEndPoint _endPoint;
                /*0x28*/ System.Net.IPAddress[] _addressList;
                /*0x30*/ int _nextAddress;
                /*0x34*/ System.Net.Sockets.MultipleConnectAsync.State _state;
                /*0x38*/ object _lockObject;

                /*0x24784b4*/ MultipleConnectAsync();
                /*0x2476f40*/ bool StartConnectAsync(System.Net.Sockets.SocketAsyncEventArgs args, System.Net.DnsEndPoint endPoint);
                /*0x24777f4*/ void DnsCallback(System.IAsyncResult result);
                /*0x2477458*/ bool DoDnsCallback(System.IAsyncResult result, bool sync);
                /*0x2477af4*/ void InternalConnectCallback(object sender, System.Net.Sockets.SocketAsyncEventArgs args);
                /*0x24778b8*/ System.Exception AttemptConnection();
                /*0x2477e10*/ System.Exception AttemptConnection(System.Net.Sockets.Socket attemptSocket, System.Net.Sockets.SocketAsyncEventArgs args);
                void OnSucceed();
                /*0x2477d4c*/ void Succeed();
                void OnFail(bool abortive);
                /*0x2477ac8*/ bool Fail(bool sync, System.Exception e);
                /*0x2477390*/ void SyncFail(System.Exception e);
                /*0x2477db8*/ void AsyncFail(System.Exception e);
                System.Net.IPAddress GetNextAddress(ref System.Net.Sockets.Socket attemptSocket);

                enum State
                {
                    NotStarted = 0,
                    DnsQuery = 1,
                    ConnectAttempt = 2,
                    Completed = 3,
                    Canceled = 4,
                }
            }

            class SingleSocketMultipleConnectAsync : System.Net.Sockets.MultipleConnectAsync
            {
                /*0x40*/ System.Net.Sockets.Socket _socket;
                /*0x48*/ bool _userSocket;

                /*0x247851c*/ SingleSocketMultipleConnectAsync(System.Net.Sockets.Socket socket, bool userSocket);
                /*0x2478548*/ System.Net.IPAddress GetNextAddress(ref System.Net.Sockets.Socket attemptSocket);
                /*0x2478648*/ void OnFail(bool abortive);
                /*0x24786e0*/ void OnSucceed();
            }

            class DualSocketMultipleConnectAsync : System.Net.Sockets.MultipleConnectAsync
            {
                /*0x40*/ System.Net.Sockets.Socket _socket4;
                /*0x48*/ System.Net.Sockets.Socket _socket6;

                /*0x24786e4*/ DualSocketMultipleConnectAsync(System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x2478ad4*/ System.Net.IPAddress GetNextAddress(ref System.Net.Sockets.Socket attemptSocket);
                /*0x2478b84*/ void OnSucceed();
                /*0x2478bc0*/ void OnFail(bool abortive);
            }

            class NetworkStream : System.IO.Stream
            {
                /*0x28*/ System.Net.Sockets.Socket _streamSocket;
                /*0x30*/ bool _ownsSocket;
                /*0x31*/ bool _readable;
                /*0x32*/ bool _writeable;
                /*0x34*/ int _closeTimeout;
                /*0x38*/ bool _cleanedUp;
                /*0x3c*/ int _currentReadTimeout;
                /*0x40*/ int _currentWriteTimeout;

                /*0x2478bec*/ NetworkStream(System.Net.Sockets.Socket socket);
                /*0x2478da8*/ NetworkStream(System.Net.Sockets.Socket socket, bool ownsSocket);
                /*0x2478bf8*/ NetworkStream(System.Net.Sockets.Socket socket, System.IO.FileAccess access, bool ownsSocket);
                /*0x2478db4*/ bool get_CanRead();
                /*0x2478dbc*/ bool get_CanSeek();
                /*0x2478dc4*/ bool get_CanWrite();
                /*0x2478dcc*/ bool get_CanTimeout();
                /*0x2478dd4*/ int get_ReadTimeout();
                /*0x2479000*/ void set_ReadTimeout(int value);
                /*0x2479254*/ int get_WriteTimeout();
                /*0x24792dc*/ void set_WriteTimeout(int value);
                /*0x2479364*/ long get_Length();
                /*0x24793b4*/ long get_Position();
                /*0x2479404*/ void set_Position(long value);
                /*0x2479454*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x24794a4*/ int Read(byte[] buffer, int offset, int size);
                /*0x247981c*/ int Read(System.Span<byte> destination);
                /*0x2479b84*/ int ReadByte();
                /*0x2479c08*/ void Write(byte[] buffer, int offset, int size);
                /*0x2479f80*/ void Write(System.ReadOnlySpan<byte> source);
                /*0x247a284*/ void WriteByte(byte value);
                /*0x247a2fc*/ void Close(int timeout);
                /*0x247a364*/ void Dispose(bool disposing);
                /*0x247a46c*/ void Finalize();
                /*0x247a510*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x247a8b8*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x247ab40*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state);
                /*0x247aee8*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x247b170*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x247b7f8*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x247ba54*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int size, System.Threading.CancellationToken cancellationToken);
                /*0x247c090*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x247c2e8*/ void Flush();
                /*0x247c2ec*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x247c374*/ void SetLength(long value);
                /*0x2479088*/ void SetSocketTimeoutOption(System.Net.Sockets.SocketShutdown mode, int timeout, bool silent);
                /*0x247c514*/ System.Net.Sockets.Socket get_InternalSocket();
            }

            class Socket : System.IDisposable
            {
                static int DefaultCloseTimeout = -1;
                static int SOCKET_CLOSED_CODE = 10004;
                static string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
                static /*0x0*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> AcceptCompletedHandler;
                static /*0x8*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> ReceiveCompletedHandler;
                static /*0x10*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> SendCompletedHandler;
                static /*0x18*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> s_rentedSocketSentinel;
                static /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;
                static /*0x28*/ System.Threading.Tasks.Task<int> s_zeroTask;
                static /*0x30*/ object s_InternalSyncObject;
                static /*0x38*/ bool s_SupportsIPv4;
                static /*0x39*/ bool s_SupportsIPv6;
                static /*0x3a*/ bool s_OSSupportsIPv6;
                static /*0x3b*/ bool s_Initialized;
                static /*0x3c*/ bool s_LoggingEnabled;
                static /*0x3d*/ bool s_PerfCountersEnabled;
                static /*0x40*/ System.AsyncCallback AcceptAsyncCallback;
                static /*0x48*/ System.IOAsyncCallback BeginAcceptCallback;
                static /*0x50*/ System.IOAsyncCallback BeginAcceptReceiveCallback;
                static /*0x58*/ System.AsyncCallback ConnectAsyncCallback;
                static /*0x60*/ System.IOAsyncCallback BeginConnectCallback;
                static /*0x68*/ System.AsyncCallback DisconnectAsyncCallback;
                static /*0x70*/ System.IOAsyncCallback BeginDisconnectCallback;
                static /*0x78*/ System.AsyncCallback ReceiveAsyncCallback;
                static /*0x80*/ System.IOAsyncCallback BeginReceiveCallback;
                static /*0x88*/ System.IOAsyncCallback BeginReceiveGenericCallback;
                static /*0x90*/ System.AsyncCallback ReceiveFromAsyncCallback;
                static /*0x98*/ System.IOAsyncCallback BeginReceiveFromCallback;
                static /*0xa0*/ System.AsyncCallback SendAsyncCallback;
                static /*0xa8*/ System.IOAsyncCallback BeginSendGenericCallback;
                static /*0xb0*/ System.AsyncCallback SendToAsyncCallback;
                /*0x10*/ System.Net.Sockets.Socket.CachedEventArgs _cachedTaskEventArgs;
                /*0x18*/ bool is_closed;
                /*0x19*/ bool is_listening;
                /*0x1a*/ bool useOverlappedIO;
                /*0x1c*/ int linger_timeout;
                /*0x20*/ System.Net.Sockets.AddressFamily addressFamily;
                /*0x24*/ System.Net.Sockets.SocketType socketType;
                /*0x28*/ System.Net.Sockets.ProtocolType protocolType;
                /*0x30*/ System.Net.Sockets.SafeSocketHandle m_Handle;
                /*0x38*/ System.Net.EndPoint seed_endpoint;
                /*0x40*/ System.Threading.SemaphoreSlim ReadSem;
                /*0x48*/ System.Threading.SemaphoreSlim WriteSem;
                /*0x50*/ bool is_blocking;
                /*0x51*/ bool is_bound;
                /*0x52*/ bool is_connected;
                /*0x54*/ int m_IntCleanedUp;
                /*0x58*/ bool connect_in_progress;
                /*0x5c*/ int ID;

                static /*0x248c3dc*/ Socket();
                static /*0x247dec8*/ void ValidateBuffer(System.ArraySegment<byte> buffer);
                static /*0x247e488*/ void ValidateBuffersList(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers);
                static /*0x247e7e4*/ void ConfigureBufferList(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                static /*0x2480568*/ void CompleteAccept(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                static /*0x2480684*/ void CompleteSendReceive(System.Net.Sockets.Socket s, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                static /*0x247cc1c*/ System.Exception GetException(System.Net.Sockets.SocketError error, bool wrapExceptionsInIOExceptions);
                static /*0x2480e0c*/ bool get_SupportsIPv4();
                static /*0x24787b8*/ bool get_OSSupportsIPv4();
                static /*0x2480e70*/ bool get_SupportsIPv6();
                static /*0x2480ed4*/ bool get_LegacySupportsIPv6();
                static /*0x2478a70*/ bool get_OSSupportsIPv6();
                static /*0x24846ac*/ object get_InternalSyncObject();
                static /*0x24809e0*/ void InitializeSockets();
                static /*0x2484874*/ bool ConnectAsync(System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType, System.Net.Sockets.SocketAsyncEventArgs e);
                static /*0x2480c44*/ nint Socket_icall(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, ref int error);
                static /*0x2485784*/ int Available_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error);
                static /*0x24858ac*/ int Available_icall(nint socket, ref int error);
                static /*0x2485d04*/ System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x2485e34*/ System.Net.SocketAddress LocalEndPoint_icall(nint socket, int family, ref int error);
                static /*0x2485f10*/ void Blocking_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool block, ref int error);
                static /*0x2486030*/ void Blocking_icall(nint socket, bool block, ref int error);
                static /*0x2486234*/ System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int family, ref int error);
                static /*0x2486364*/ System.Net.SocketAddress RemoteEndPoint_icall(nint socket, int family, ref int error);
                static /*0x2486370*/ void Select(System.Collections.IList checkRead, System.Collections.IList checkWrite, System.Collections.IList checkError, int microSeconds);
                static /*0x248699c*/ void AddSockets(System.Collections.Generic.List<System.Net.Sockets.Socket> sockets, System.Collections.IList list, string name);
                static /*0x2486e0c*/ void Select_icall(ref System.Net.Sockets.Socket[] sockets, int microSeconds, ref int error);
                static /*0x2486fb0*/ bool Poll_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x24870f0*/ bool Poll_icall(nint socket, System.Net.Sockets.SelectMode mode, int timeout, ref int error);
                static /*0x2487228*/ System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle safeHandle, ref int error, bool blocking);
                static /*0x24879e8*/ nint Accept_icall(nint sock, ref int error, bool blocking);
                static /*0x2487c28*/ void Bind_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error);
                static /*0x2487d48*/ void Bind_icall(nint sock, System.Net.SocketAddress sa, ref int error);
                static /*0x2487e44*/ void Listen_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int backlog, ref int error);
                static /*0x2487f64*/ void Listen_icall(nint sock, int backlog, ref int error);
                static /*0x2488a7c*/ void CancelConnectAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                static /*0x24887c4*/ bool BeginMConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x2488368*/ bool BeginSConnect(System.Net.Sockets.SocketAsyncResult sockares);
                static /*0x248805c*/ void Connect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x2488b1c*/ void Connect_icall(nint sock, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x2488c1c*/ void Disconnect_internal(System.Net.Sockets.SafeSocketHandle safeHandle, bool reuse, ref int error);
                static /*0x2489014*/ void Disconnect_icall(nint sock, bool reuse, ref int error);
                static /*0x24894fc*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x248972c*/ int Receive_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x24891a8*/ int Receive_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x2489734*/ int Receive_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x24898b8*/ int ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x248a080*/ int ReceiveFrom_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref System.Net.SocketAddress sockaddr, ref int error, bool blocking);
                static /*0x248a540*/ void BeginSendCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x248a380*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x248a8dc*/ int Send_array_icall(nint sock, System.Net.Sockets.Socket.WSABUF* bufarray, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x248a23c*/ int Send_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x248a8e4*/ int Send_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, ref int error, bool blocking);
                static /*0x248af78*/ void BeginSendToCallback(System.Net.Sockets.SocketAsyncResult sockares, int sent_so_far);
                static /*0x248a8ec*/ int SendTo_internal(System.Net.Sockets.SafeSocketHandle safeHandle, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x248b26c*/ int SendTo_icall(nint sock, byte* buffer, int count, System.Net.Sockets.SocketFlags flags, System.Net.SocketAddress sa, ref int error, bool blocking);
                static /*0x248b274*/ bool SendFile_internal(System.Net.Sockets.SafeSocketHandle safeHandle, string filename, byte[] pre_buffer, byte[] post_buffer, System.Net.Sockets.TransmitFileOptions flags, ref int error, bool blocking);
                static /*0x248b4d4*/ bool SendFile_icall(nint sock, string filename, byte[] pre_buffer, byte[] post_buffer, System.Net.Sockets.TransmitFileOptions flags, ref int error, bool blocking);
                static /*0x248b520*/ bool Duplicate_icall(nint handle, int targetProcessId, ref nint duplicateHandle, ref System.IO.MonoIOError error);
                static /*0x248b964*/ void GetSocketOption_arr_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref byte[] byte_val, ref int error);
                static /*0x248bce4*/ void GetSocketOption_arr_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref byte[] byte_val, ref int error);
                static /*0x248bbac*/ void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x248bce8*/ void GetSocketOption_obj_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, ref object obj_val, ref int error);
                static /*0x2484f2c*/ void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x248be60*/ void SetSocketOption_icall(nint socket, System.Net.Sockets.SocketOptionLevel level, System.Net.Sockets.SocketOptionName name, object obj_val, byte[] byte_val, int int_val, ref int error);
                static /*0x248be64*/ int IOControl_internal(System.Net.Sockets.SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x248bfac*/ int IOControl_icall(nint sock, int ioctl_code, byte[] input, byte[] output, ref int error);
                static /*0x248bfb0*/ void Close_icall(nint socket, ref int error);
                static /*0x2484bc0*/ void Shutdown_internal(System.Net.Sockets.SafeSocketHandle safeHandle, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x248c0cc*/ void Shutdown_icall(nint socket, System.Net.Sockets.SocketShutdown how, ref int error);
                static /*0x248c348*/ void cancel_blocking_socket_operation(System.Threading.Thread thread);
                static /*0x248c34c*/ bool SupportsPortReuse(System.Net.Sockets.ProtocolType proto);
                static /*0x248c350*/ int get_FamilyHint();
                static /*0x248c3d8*/ bool IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                static /*0x2484780*/ bool IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent networkInterface);
                /*0x2480930*/ Socket(System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x247881c*/ Socket(System.Net.Sockets.AddressFamily addressFamily, System.Net.Sockets.SocketType socketType, System.Net.Sockets.ProtocolType protocolType);
                /*0x248507c*/ Socket(System.Net.Sockets.SocketInformation socketInformation);
                /*0x2485500*/ Socket(System.Net.Sockets.AddressFamily family, System.Net.Sockets.SocketType type, System.Net.Sockets.ProtocolType proto, System.Net.Sockets.SafeSocketHandle safe_handle);
                /*0x247c5b0*/ System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(System.Net.Sockets.Socket acceptSocket);
                /*0x247c83c*/ System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsyncApm(System.Net.Sockets.Socket acceptSocket);
                /*0x247cf6c*/ System.Threading.Tasks.Task ConnectAsync(System.Net.EndPoint remoteEP);
                /*0x247d200*/ System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress address, int port);
                /*0x247d5e4*/ System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[] addresses, int port);
                /*0x247d974*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x247ddd0*/ System.Threading.Tasks.Task<int> ReceiveAsync(System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream);
                /*0x247b534*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, bool fromNetworkStream, System.Threading.CancellationToken cancellationToken);
                /*0x247dfe8*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Memory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247e3b0*/ System.Threading.Tasks.Task<int> ReceiveAsync(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247ec6c*/ System.Threading.Tasks.Task<int> ReceiveAsyncApm(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247ee3c*/ System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult> ReceiveFromAsync(System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint);
                /*0x247f1cc*/ System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult> ReceiveMessageFromAsync(System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEndPoint);
                /*0x247f400*/ System.Threading.Tasks.Task<int> SendAsync(System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247f4f0*/ System.Threading.Tasks.ValueTask<int> SendAsync(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x247bdcc*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Threading.CancellationToken cancellationToken);
                /*0x247f7d0*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.ReadOnlyMemory<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247fbf0*/ System.Threading.Tasks.Task<int> SendAsync(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247ffa8*/ System.Threading.Tasks.Task<int> SendAsyncApm(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2480178*/ System.Threading.Tasks.Task<int> SendToAsync(System.ArraySegment<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP);
                /*0x247ea98*/ System.Threading.Tasks.Task<int> GetTaskForSendReceive(bool pending, System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool fromNetworkStream, bool isReceive);
                /*0x247e5f4*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs RentSocketAsyncEventArgs(bool isReceive);
                /*0x248051c*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive);
                /*0x247cbdc*/ void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea);
                /*0x24807c8*/ void DisposeCachedTaskSocketAsyncEventArgs();
                /*0x2480f38*/ nint get_Handle();
                /*0x2480f54*/ bool get_UseOnlyOverlappedIO();
                /*0x2480f5c*/ void set_UseOnlyOverlappedIO(bool value);
                /*0x2480f68*/ System.Net.Sockets.AddressFamily get_AddressFamily();
                /*0x2480f70*/ System.Net.Sockets.SocketType get_SocketType();
                /*0x2480f78*/ System.Net.Sockets.ProtocolType get_ProtocolType();
                /*0x2480f80*/ bool get_ExclusiveAddressUse();
                /*0x2481004*/ void set_ExclusiveAddressUse(bool value);
                /*0x24811b0*/ int get_ReceiveBufferSize();
                /*0x248122c*/ void set_ReceiveBufferSize(int value);
                /*0x2481290*/ int get_SendBufferSize();
                /*0x248130c*/ void set_SendBufferSize(int value);
                /*0x2481370*/ int get_ReceiveTimeout();
                /*0x24813ec*/ void set_ReceiveTimeout(int value);
                /*0x2481458*/ int get_SendTimeout();
                /*0x24814d4*/ void set_SendTimeout(int value);
                /*0x2481540*/ System.Net.Sockets.LingerOption get_LingerState();
                /*0x24815c4*/ void set_LingerState(System.Net.Sockets.LingerOption value);
                /*0x2481938*/ short get_Ttl();
                /*0x2481a30*/ void set_Ttl(short value);
                /*0x2481b20*/ bool get_DontFragment();
                /*0x2481c08*/ void set_DontFragment(bool value);
                /*0x2481c8c*/ bool get_DualMode();
                /*0x2480958*/ void set_DualMode(bool value);
                /*0x2481d74*/ bool get_IsDualMode();
                /*0x2478610*/ bool CanTryAddressFamily(System.Net.Sockets.AddressFamily family);
                /*0x2481d8c*/ void Connect(System.Net.IPAddress[] addresses, int port);
                /*0x24824f8*/ int Send(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2482508*/ int Send(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2482534*/ int Send(byte[] buffer);
                /*0x2482560*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers);
                /*0x2482568*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2482b04*/ void SendFile(string fileName);
                /*0x2479f18*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2482e04*/ int SendTo(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP);
                /*0x2482fc0*/ int SendTo(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP);
                /*0x2482ff0*/ int SendTo(byte[] buffer, System.Net.EndPoint remoteEP);
                /*0x2483020*/ int Receive(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2483030*/ int Receive(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x248305c*/ int Receive(byte[] buffer);
                /*0x24797b4*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2483194*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers);
                /*0x248319c*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x24836ec*/ int ReceiveFrom(byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP);
                /*0x2483818*/ int ReceiveFrom(byte[] buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP);
                /*0x2483848*/ int ReceiveFrom(byte[] buffer, ref System.Net.EndPoint remoteEP);
                /*0x2483878*/ int IOControl(System.Net.Sockets.IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x2480c48*/ void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel level);
                /*0x2483a0c*/ System.IAsyncResult BeginSendFile(string fileName, System.AsyncCallback callback, object state);
                /*0x247d358*/ System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state);
                /*0x247ae68*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x2480100*/ System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x247b108*/ int EndSend(System.IAsyncResult asyncResult);
                /*0x247a838*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x247edc4*/ System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x247aad8*/ int EndReceive(System.IAsyncResult asyncResult);
                /*0x24844fc*/ System.IAsyncResult BeginAccept(int receiveSize, System.AsyncCallback callback, object state);
                /*0x2484510*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, System.IAsyncResult asyncResult);
                /*0x2482188*/ bool get_CleanedUp();
                /*0x2478674*/ void Dispose();
                /*0x24847d4*/ void Finalize();
                /*0x247a3dc*/ void InternalShutdown(System.Net.Sockets.SocketShutdown how);
                /*0x2484ce0*/ System.IAsyncResult UnsafeBeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x2484ce4*/ System.IAsyncResult UnsafeBeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x2484ce8*/ System.IAsyncResult UnsafeBeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x2484cec*/ System.IAsyncResult BeginMultipleSend(System.Net.BufferOffsetSize[] buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x2484e14*/ System.IAsyncResult UnsafeBeginMultipleSend(System.Net.BufferOffsetSize[] buffers, System.Net.Sockets.SocketFlags socketFlags, System.AsyncCallback callback, object state);
                /*0x2484e18*/ int EndMultipleSend(System.IAsyncResult asyncResult);
                /*0x2484e1c*/ void MultipleSend(System.Net.BufferOffsetSize[] buffers, System.Net.Sockets.SocketFlags socketFlags);
                /*0x247c3c4*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue, bool silent);
                /*0x2480d38*/ void SocketDefaults();
                /*0x248563c*/ int get_Available();
                /*0x24858b0*/ bool get_EnableBroadcast();
                /*0x2485988*/ void set_EnableBroadcast(bool value);
                /*0x2485a04*/ bool get_IsBound();
                /*0x2485a0c*/ bool get_MulticastLoopback();
                /*0x2485b40*/ void set_MulticastLoopback(bool value);
                /*0x2485c10*/ System.Net.EndPoint get_LocalEndPoint();
                /*0x2485e38*/ bool get_Blocking();
                /*0x2485e40*/ void set_Blocking(bool value);
                /*0x2486038*/ bool get_Connected();
                /*0x2486040*/ void set_Connected(bool value);
                /*0x248604c*/ bool get_NoDelay();
                /*0x24855fc*/ void set_NoDelay(bool value);
                /*0x2486138*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x2486368*/ System.Runtime.InteropServices.SafeHandle get_SafeHandle();
                /*0x2486e10*/ bool Poll(int microSeconds, System.Net.Sockets.SelectMode mode);
                /*0x24870f4*/ System.Net.Sockets.Socket Accept();
                /*0x2487388*/ void Accept(System.Net.Sockets.Socket acceptSocket);
                /*0x247c990*/ bool AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x2487660*/ System.IAsyncResult BeginAccept(System.AsyncCallback callback, object state);
                /*0x247cd0c*/ System.IAsyncResult BeginAccept(System.Net.Sockets.Socket acceptSocket, int receiveSize, System.AsyncCallback callback, object state);
                /*0x2487874*/ System.Net.Sockets.Socket EndAccept(System.IAsyncResult asyncResult);
                /*0x24845b8*/ System.Net.Sockets.Socket EndAccept(ref byte[] buffer, ref int bytesTransferred, System.IAsyncResult asyncResult);
                /*0x24879f0*/ void Bind(System.Net.EndPoint localEP);
                /*0x2487d4c*/ void Listen(int backlog);
                /*0x2487f68*/ void Connect(System.Net.IPAddress address, int port);
                /*0x2487fe4*/ void Connect(string host, int port);
                /*0x2482198*/ void Connect(System.Net.EndPoint remoteEP);
                /*0x2477fa4*/ bool ConnectAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x247dacc*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback callback, object state);
                /*0x247d0bc*/ System.IAsyncResult BeginConnect(System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x247d73c*/ System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state);
                /*0x24889cc*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x2488180*/ bool GetCheckedIPs(System.Net.Sockets.SocketAsyncEventArgs e, ref System.Net.IPAddress[] addresses);
                /*0x2488b24*/ void Disconnect(bool reuseSocket);
                /*0x2488d3c*/ bool DisconnectAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x2488e3c*/ System.IAsyncResult BeginDisconnect(bool reuseSocket, System.AsyncCallback callback, object state);
                /*0x2488f64*/ void EndDisconnect(System.IAsyncResult asyncResult);
                /*0x2483088*/ int Receive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x24892ec*/ int Receive(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x2483204*/ int Receive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x2479a94*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x247a1f8*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x2489640*/ int Receive(System.Span<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x2489728*/ int Receive(System.Span<byte> buffer);
                /*0x247e894*/ bool ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x24840e8*/ System.IAsyncResult BeginReceive(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x2484278*/ System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x248440c*/ int EndReceive(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x2483700*/ int ReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP);
                /*0x248973c*/ int ReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x2489a0c*/ int ReceiveFrom(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.SocketError errorCode);
                /*0x2489c94*/ bool ReceiveFromAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x247efe4*/ System.IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x2489e98*/ int EndReceiveFrom(System.IAsyncResult asyncResult, ref System.Net.EndPoint endPoint);
                /*0x2489fb0*/ int EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult sockares, System.Net.Sockets.SocketAsyncEventArgs ares);
                /*0x248a088*/ int ReceiveMessageFrom(byte[] buffer, int offset, int size, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, ref System.Net.Sockets.IPPacketInformation ipPacketInformation);
                /*0x248a13c*/ bool ReceiveMessageFromAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x247f34c*/ System.IAsyncResult BeginReceiveMessageFrom(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x248a180*/ int EndReceiveMessageFrom(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketFlags socketFlags, ref System.Net.EndPoint endPoint, ref System.Net.Sockets.IPPacketInformation ipPacketInformation);
                /*0x2482cc0*/ int Send(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x24825d0*/ int Send(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode);
                /*0x248a4c4*/ int Send(System.ReadOnlySpan<byte> buffer, System.Net.Sockets.SocketFlags socketFlags);
                /*0x248a538*/ int Send(System.ReadOnlySpan<byte> buffer);
                /*0x247fcc8*/ bool SendAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x2483c30*/ System.IAsyncResult BeginSend(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x2483e4c*/ System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<byte>> buffers, System.Net.Sockets.SocketFlags socketFlags, ref System.Net.Sockets.SocketError errorCode, System.AsyncCallback callback, object state);
                /*0x2483ff8*/ int EndSend(System.IAsyncResult asyncResult, ref System.Net.Sockets.SocketError errorCode);
                /*0x2482e18*/ int SendTo(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP);
                /*0x248aa40*/ int SendTo(System.Memory<byte> buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP);
                /*0x248acdc*/ bool SendToAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x2480318*/ System.IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, System.Net.Sockets.SocketFlags socketFlags, System.Net.EndPoint remoteEP, System.AsyncCallback callback, object state);
                /*0x248b1b4*/ int EndSendTo(System.IAsyncResult asyncResult);
                /*0x2482b14*/ void SendFile(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags);
                /*0x2483a24*/ System.IAsyncResult BeginSendFile(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags, System.AsyncCallback callback, object state);
                /*0x248b3c8*/ void EndSendFile(System.IAsyncResult asyncResult);
                /*0x248b4dc*/ bool SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x248b524*/ System.Net.Sockets.SocketInformation DuplicateAndClose(int targetProcessId);
                /*0x248b830*/ void GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, byte[] optionValue);
                /*0x248ba9c*/ byte[] GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionLength);
                /*0x2478e5c*/ object GetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName);
                /*0x248bcec*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, byte[] optionValue);
                /*0x24815d4*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, object optionValue);
                /*0x248be58*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, bool optionValue);
                /*0x2481084*/ void SetSocketOption(System.Net.Sockets.SocketOptionLevel optionLevel, System.Net.Sockets.SocketOptionName optionName, int optionValue);
                /*0x248387c*/ int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue);
                /*0x2488b14*/ void Close();
                /*0x247a464*/ void Close(int timeout);
                /*0x248bfb4*/ void Shutdown(System.Net.Sockets.SocketShutdown how);
                /*0x248c0d0*/ void Dispose(bool disposing);
                /*0x248c130*/ void Linger(nint handle);
                /*0x24877d0*/ void ThrowIfDisposedAndClosed(System.Net.Sockets.Socket socket);
                /*0x24856f8*/ void ThrowIfDisposedAndClosed();
                /*0x248901c*/ void ThrowIfBufferNull(byte[] buffer);
                /*0x2489074*/ void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size);
                /*0x24860e0*/ void ThrowIfUdp();
                /*0x248789c*/ System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult ares, string methodName, string argName);
                /*0x2487520*/ void QueueIOSelectorJob(System.Threading.SemaphoreSlim sem, nint handle, System.IOSelectorJob job);
                /*0x24874a4*/ void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs e, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x248c29c*/ System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation op);
                /*0x2487b6c*/ System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint input);
                /*0x247860c*/ void ReplaceHandleIfNecessaryAfterFailedConnect();

                class StateTaskCompletionSource<TField1, TResult> : System.Threading.Tasks.TaskCompletionSource<TResult>
                {
                    /*0x0*/ TField1 _field1;

                    StateTaskCompletionSource(object baseState);
                }

                class StateTaskCompletionSource<TField1, TField2, TResult> : System.Net.Sockets.Socket.StateTaskCompletionSource<TField1, TResult>
                {
                    /*0x0*/ TField2 _field2;

                    StateTaskCompletionSource(object baseState);
                }

                class CachedEventArgs
                {
                    /*0x10*/ System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept;
                    /*0x18*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskReceive;
                    /*0x20*/ System.Net.Sockets.Socket.Int32TaskSocketAsyncEventArgs TaskSend;
                    /*0x28*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;
                    /*0x30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;

                    /*0x248dab8*/ CachedEventArgs();
                }

                class TaskSocketAsyncEventArgs<TResult> : System.Net.Sockets.SocketAsyncEventArgs
                {
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder;
                    /*0x0*/ bool _accessed;

                    TaskSocketAsyncEventArgs();
                    System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(ref bool responsibleForReturningToPool);
                }

                class Int32TaskSocketAsyncEventArgs : System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<int>
                {
                    /*0xd1*/ bool _wrapExceptionsInIOExceptions;

                    /*0x248dac0*/ Int32TaskSocketAsyncEventArgs();
                }

                class AwaitableSocketAsyncEventArgs : System.Net.Sockets.SocketAsyncEventArgs, System.Threading.Tasks.Sources.IValueTaskSource, System.Threading.Tasks.Sources.IValueTaskSource<int>
                {
                    static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs Reserved;
                    static /*0x8*/ System.Action<object> s_completedSentinel;
                    static /*0x10*/ System.Action<object> s_availableSentinel;
                    /*0xb8*/ System.Action<object> _continuation;
                    /*0xc0*/ System.Threading.ExecutionContext _executionContext;
                    /*0xc8*/ object _scheduler;
                    /*0xd0*/ short _token;
                    /*0xd2*/ bool <WrapExceptionsInIOExceptions>k__BackingField;

                    static /*0x248ea48*/ AwaitableSocketAsyncEventArgs();
                    /*0x248db08*/ AwaitableSocketAsyncEventArgs();
                    /*0x248dbfc*/ bool get_WrapExceptionsInIOExceptions();
                    /*0x248dc04*/ void set_WrapExceptionsInIOExceptions(bool value);
                    /*0x248dc10*/ bool Reserve();
                    /*0x248dc90*/ void Release();
                    /*0x248dd00*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs _);
                    /*0x248e1e0*/ System.Threading.Tasks.ValueTask<int> ReceiveAsync(System.Net.Sockets.Socket socket);
                    /*0x248e410*/ System.Threading.Tasks.ValueTask<int> SendAsync(System.Net.Sockets.Socket socket);
                    /*0x248e53c*/ System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket socket);
                    /*0x248e620*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    /*0x248e704*/ void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x248df00*/ void InvokeContinuation(System.Action<object> continuation, object state, bool forceAsync);
                    /*0x248e964*/ int GetResult(short token);
                    /*0x248e9d0*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x248e6b4*/ void ThrowIncorrectTokenException();
                    /*0x248e914*/ void ThrowMultipleContinuationsException();
                    /*0x248e9ac*/ void ThrowException(System.Net.Sockets.SocketError error);
                    /*0x248e30c*/ System.Exception CreateException(System.Net.Sockets.SocketError error);

                    class <>c
                    {
                        static /*0x0*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<> <>9;
                        static /*0x8*/ System.Threading.ContextCallback <>9__14_0;
                        static /*0x10*/ System.Threading.SendOrPostCallback <>9__20_0;

                        static /*0x248eb84*/ <>c();
                        /*0x248ebe8*/ <>c();
                        /*0x248ebf0*/ void <OnCompleted>b__14_0(object runState);
                        /*0x248eca0*/ void <InvokeContinuation>b__20_0(object s);
                        /*0x248ed4c*/ void <.cctor>b__27_0(object state);
                        /*0x248ed9c*/ void <.cctor>b__27_1(object state);
                    }
                }

                class SendFileHandler : System.MulticastDelegate
                {
                    /*0x248edec*/ SendFileHandler(object object, nint method);
                    /*0x248eec4*/ void Invoke(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags);
                    /*0x248eed8*/ System.IAsyncResult BeginInvoke(string fileName, byte[] preBuffer, byte[] postBuffer, System.Net.Sockets.TransmitFileOptions flags, System.AsyncCallback callback, object object);
                    /*0x248ef80*/ void EndInvoke(System.IAsyncResult result);
                }

                class SendFileAsyncResult : System.IAsyncResult
                {
                    /*0x10*/ System.IAsyncResult ares;
                    /*0x18*/ System.Net.Sockets.Socket.SendFileHandler d;

                    /*0x248ef8c*/ SendFileAsyncResult(System.Net.Sockets.Socket.SendFileHandler d, System.IAsyncResult ares);
                    /*0x248efb8*/ object get_AsyncState();
                    /*0x248f05c*/ System.Threading.WaitHandle get_AsyncWaitHandle();
                    /*0x248f100*/ bool get_CompletedSynchronously();
                    /*0x248f1a4*/ bool get_IsCompleted();
                    /*0x248f244*/ System.Net.Sockets.Socket.SendFileHandler get_Delegate();
                    /*0x248f24c*/ System.IAsyncResult get_Original();
                }

                struct WSABUF
                {
                    /*0x10*/ int len;
                    /*0x18*/ nint buf;
                }

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.Socket.<> <>9;
                    static /*0x8*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__7_0;
                    static /*0x10*/ System.AsyncCallback <>9__8_0;
                    static /*0x18*/ System.AsyncCallback <>9__9_0;
                    static /*0x20*/ System.AsyncCallback <>9__10_0;
                    static /*0x28*/ System.AsyncCallback <>9__11_0;
                    static /*0x30*/ System.AsyncCallback <>9__12_0;
                    static /*0x38*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__14_0;
                    static /*0x40*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__14_1;
                    static /*0x48*/ System.AsyncCallback <>9__15_0;
                    static /*0x50*/ System.AsyncCallback <>9__15_1;
                    static /*0x58*/ System.AsyncCallback <>9__17_0;
                    static /*0x60*/ System.AsyncCallback <>9__18_0;
                    static /*0x68*/ System.AsyncCallback <>9__19_0;
                    static /*0x70*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__21_0;
                    static /*0x78*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__21_1;
                    static /*0x80*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__22_0;
                    static /*0x88*/ System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__22_1;
                    static /*0x90*/ System.AsyncCallback <>9__23_0;
                    static /*0x98*/ System.AsyncCallback <>9__23_1;
                    static /*0xa0*/ System.AsyncCallback <>9__25_0;
                    static /*0xa8*/ System.AsyncCallback <>9__26_0;
                    static /*0xb0*/ System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__34_0;
                    static /*0xb8*/ System.IOAsyncCallback <>9__295_0;
                    static /*0xc0*/ System.IOAsyncCallback <>9__297_0;
                    static /*0xc8*/ System.IOAsyncCallback <>9__308_0;
                    static /*0xd0*/ System.IOAsyncCallback <>9__310_0;

                    static /*0x248f254*/ <>c();
                    /*0x248f2b8*/ <>c();
                    /*0x248f2c0*/ System.Net.Sockets.Socket.CachedEventArgs <AcceptAsync>b__7_0();
                    /*0x248f31c*/ void <AcceptAsyncApm>b__8_0(System.IAsyncResult iar);
                    /*0x248f554*/ void <ConnectAsync>b__9_0(System.IAsyncResult iar);
                    /*0x248f788*/ void <ConnectAsync>b__10_0(System.IAsyncResult iar);
                    /*0x248f9bc*/ void <ConnectAsync>b__11_0(System.IAsyncResult iar);
                    /*0x248fbf0*/ void <ConnectAsync>b__12_0(System.IAsyncResult iar);
                    /*0x248fe24*/ System.Net.Sockets.Socket.CachedEventArgs <ReceiveAsync>b__14_0();
                    /*0x248fe80*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1();
                    /*0x248fed8*/ void <ReceiveAsyncApm>b__15_0(System.IAsyncResult iar);
                    /*0x2490110*/ void <ReceiveAsyncApm>b__15_1(System.IAsyncResult iar);
                    /*0x2490544*/ void <ReceiveAsyncApm>b__17_0(System.IAsyncResult iar);
                    /*0x249077c*/ void <ReceiveFromAsync>b__18_0(System.IAsyncResult iar);
                    /*0x24909bc*/ void <ReceiveMessageFromAsync>b__19_0(System.IAsyncResult iar);
                    /*0x2490c20*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsync>b__21_0();
                    /*0x2490c7c*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsync>b__21_1();
                    /*0x2490cd4*/ System.Net.Sockets.Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0();
                    /*0x2490d30*/ System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1();
                    /*0x2490d88*/ void <SendAsyncApm>b__23_0(System.IAsyncResult iar);
                    /*0x2490fc0*/ void <SendAsyncApm>b__23_1(System.IAsyncResult iar);
                    /*0x24912c4*/ void <SendAsyncApm>b__25_0(System.IAsyncResult iar);
                    /*0x24914fc*/ void <SendToAsync>b__26_0(System.IAsyncResult iar);
                    /*0x2491734*/ System.Net.Sockets.Socket.CachedEventArgs <RentSocketAsyncEventArgs>b__34_0();
                    /*0x2491790*/ void <SendAsync>b__295_0(System.IOAsyncResult s);
                    /*0x2491824*/ void <BeginSend>b__297_0(System.IOAsyncResult s);
                    /*0x24918b8*/ void <SendToAsync>b__308_0(System.IOAsyncResult s);
                    /*0x249194c*/ void <BeginSendTo>b__310_0(System.IOAsyncResult s);
                    /*0x24919e0*/ void <.cctor>b__367_0(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x2491ad8*/ void <.cctor>b__367_1(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x2491bb8*/ void <.cctor>b__367_2(object s, System.Net.Sockets.SocketAsyncEventArgs e);
                    /*0x2491c98*/ void <.cctor>b__367_3(System.IAsyncResult ares);
                    /*0x2491f24*/ void <.cctor>b__367_4(System.IOAsyncResult ares);
                    /*0x2492060*/ void <.cctor>b__367_5(System.IOAsyncResult ares);
                    /*0x24922b0*/ void <.cctor>b__367_6(System.IAsyncResult ares);
                    /*0x2492540*/ void <.cctor>b__367_7(System.IOAsyncResult ares);
                    /*0x24929f8*/ void <.cctor>b__367_8(System.IAsyncResult ares);
                    /*0x2492c88*/ void <.cctor>b__367_9(System.IOAsyncResult ares);
                    /*0x2492d88*/ void <.cctor>b__367_10(System.IAsyncResult ares);
                    /*0x2493020*/ void <.cctor>b__367_11(System.IOAsyncResult ares);
                    /*0x24932d0*/ void <.cctor>b__367_12(System.IOAsyncResult ares);
                    /*0x24933dc*/ void <.cctor>b__367_13(System.IAsyncResult ares);
                    /*0x2493690*/ void <.cctor>b__367_14(System.IOAsyncResult ares);
                    /*0x2493850*/ void <.cctor>b__367_15(System.IAsyncResult ares);
                    /*0x2493ae0*/ void <.cctor>b__367_16(System.IOAsyncResult ares);
                    /*0x2493bec*/ void <.cctor>b__367_17(System.IAsyncResult ares);
                }

                class <>c__DisplayClass240_0
                {
                    /*0x10*/ System.Net.Sockets.SocketAsyncResult sockares;

                    /*0x2493e7c*/ <>c__DisplayClass240_0();
                    /*0x2493e84*/ void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t);
                }

                class <>c__DisplayClass298_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x2493fa4*/ <>c__DisplayClass298_0();
                    /*0x2493fac*/ void <BeginSendCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass311_0
                {
                    /*0x10*/ int sent_so_far;

                    /*0x2494050*/ <>c__DisplayClass311_0();
                    /*0x2494058*/ void <BeginSendToCallback>b__0(System.IOAsyncResult s);
                }

                class <>c__DisplayClass316_0
                {
                    /*0x10*/ System.AsyncCallback callback;
                    /*0x18*/ System.Net.Sockets.Socket.SendFileHandler handler;

                    /*0x24940fc*/ <>c__DisplayClass316_0();
                    /*0x2494104*/ void <BeginSendFile>b__0(System.IAsyncResult ar);
                }

                class <>c__DisplayClass355_0
                {
                    /*0x10*/ System.Net.Sockets.Socket <>4__this;
                    /*0x18*/ System.IOSelectorJob job;
                    /*0x20*/ nint handle;

                    /*0x2494188*/ <>c__DisplayClass355_0();
                    /*0x2494190*/ void <QueueIOSelectorJob>b__0(System.Threading.Tasks.Task t);
                }
            }

            class SocketException : System.ComponentModel.Win32Exception
            {
                /*0x90*/ System.Net.EndPoint m_EndPoint;

                static /*0x24941d4*/ int WSAGetLastError_icall();
                /*0x24941d8*/ SocketException();
                /*0x2494248*/ SocketException(int error, string message);
                /*0x248ea10*/ SocketException(int errorCode);
                /*0x2493818*/ SocketException(System.Net.Sockets.SocketError socketError);
                /*0x24942a0*/ SocketException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
                /*0x249432c*/ int get_ErrorCode();
                /*0x2494334*/ string get_Message();
                /*0x2491f1c*/ System.Net.Sockets.SocketError get_SocketErrorCode();
            }

            enum AddressFamily
            {
                Unknown = -1,
                Unspecified = 0,
                Unix = 1,
                InterNetwork = 2,
                ImpLink = 3,
                Pup = 4,
                Chaos = 5,
                NS = 6,
                Ipx = 6,
                Iso = 7,
                Osi = 7,
                Ecma = 8,
                DataKit = 9,
                Ccitt = 10,
                Sna = 11,
                DecNet = 12,
                DataLink = 13,
                Lat = 14,
                HyperChannel = 15,
                AppleTalk = 16,
                NetBios = 17,
                VoiceView = 18,
                FireFox = 19,
                Banyan = 21,
                Atm = 22,
                InterNetworkV6 = 23,
                Cluster = 24,
                Ieee12844 = 25,
                Irda = 26,
                NetworkDesigners = 28,
                Max = 29,
            }

            enum IOControlCode
            {
                AsyncIO = 2147772029,
                NonBlockingIO = 2147772030,
                DataToRead = 1074030207,
                OobDataRead = 1074033415,
                AssociateHandle = 2281701377,
                EnableCircularQueuing = 671088642,
                Flush = 671088644,
                GetBroadcastAddress = 1207959557,
                GetExtensionFunctionPointer = 3355443206,
                GetQos = 3355443207,
                GetGroupQos = 3355443208,
                MultipointLoopback = 2281701385,
                MulticastScope = 2281701386,
                SetQos = 2281701387,
                SetGroupQos = 2281701388,
                TranslateHandle = 3355443213,
                RoutingInterfaceQuery = 3355443220,
                RoutingInterfaceChange = 2281701397,
                AddressListQuery = 1207959574,
                AddressListChange = 671088663,
                QueryTargetPnpHandle = 1207959576,
                NamespaceChange = 2281701401,
                AddressListSort = 3355443225,
                ReceiveAll = 2550136833,
                ReceiveAllMulticast = 2550136834,
                ReceiveAllIgmpMulticast = 2550136835,
                KeepAliveValues = 2550136836,
                AbsorbRouterAlert = 2550136837,
                UnicastInterface = 2550136838,
                LimitBroadcasts = 2550136839,
                BindToInterface = 2550136840,
                MulticastInterface = 2550136841,
                AddMulticastGroupOnInterface = 2550136842,
                DeleteMulticastGroupFromInterface = 2550136843,
            }

            struct IPPacketInformation
            {
                /*0x10*/ System.Net.IPAddress address;
                /*0x18*/ int networkInterface;

                /*0x24943c4*/ bool Equals(object comparand);
                /*0x2494460*/ int GetHashCode();
            }

            enum IPProtectionLevel
            {
                Unspecified = -1,
                Unrestricted = 10,
                EdgeRestricted = 20,
                Restricted = 30,
            }

            class LingerOption
            {
                /*0x10*/ bool enabled;
                /*0x14*/ int lingerTime;

                /*0x24944a4*/ LingerOption(bool enable, int seconds);
                /*0x24944d8*/ void set_Enabled(bool value);
                /*0x24944e4*/ void set_LingerTime(int value);
            }

            class MulticastOption
            {
            }

            class IPv6MulticastOption
            {
            }

            enum ProtocolType
            {
                IP = 0,
                IPv6HopByHopOptions = 0,
                Icmp = 1,
                Igmp = 2,
                Ggp = 3,
                IPv4 = 4,
                Tcp = 6,
                Pup = 12,
                Udp = 17,
                Idp = 22,
                IPv6 = 41,
                IPv6RoutingHeader = 43,
                IPv6FragmentHeader = 44,
                IPSecEncapsulatingSecurityPayload = 50,
                IPSecAuthenticationHeader = 51,
                IcmpV6 = 58,
                IPv6NoNextHeader = 59,
                IPv6DestinationOptions = 60,
                ND = 77,
                Raw = 255,
                Unspecified = 0,
                Ipx = 1000,
                Spx = 1256,
                SpxII = 1257,
                Unknown = -1,
            }

            enum SelectMode
            {
                SelectRead = 0,
                SelectWrite = 1,
                SelectError = 2,
            }

            enum SocketAsyncOperation
            {
                None = 0,
                Accept = 1,
                Connect = 2,
                Disconnect = 3,
                Receive = 4,
                ReceiveFrom = 5,
                ReceiveMessageFrom = 6,
                Send = 7,
                SendPackets = 8,
                SendTo = 9,
            }

            class SendPacketsElement
            {
            }

            enum SocketClientAccessPolicyProtocol
            {
                Tcp = 0,
                Http = 1,
            }

            enum SocketError
            {
                Success = 0,
                SocketError = -1,
                Interrupted = 10004,
                AccessDenied = 10013,
                Fault = 10014,
                InvalidArgument = 10022,
                TooManyOpenSockets = 10024,
                WouldBlock = 10035,
                InProgress = 10036,
                AlreadyInProgress = 10037,
                NotSocket = 10038,
                DestinationAddressRequired = 10039,
                MessageSize = 10040,
                ProtocolType = 10041,
                ProtocolOption = 10042,
                ProtocolNotSupported = 10043,
                SocketNotSupported = 10044,
                OperationNotSupported = 10045,
                ProtocolFamilyNotSupported = 10046,
                AddressFamilyNotSupported = 10047,
                AddressAlreadyInUse = 10048,
                AddressNotAvailable = 10049,
                NetworkDown = 10050,
                NetworkUnreachable = 10051,
                NetworkReset = 10052,
                ConnectionAborted = 10053,
                ConnectionReset = 10054,
                NoBufferSpaceAvailable = 10055,
                IsConnected = 10056,
                NotConnected = 10057,
                Shutdown = 10058,
                TimedOut = 10060,
                ConnectionRefused = 10061,
                HostDown = 10064,
                HostUnreachable = 10065,
                ProcessLimit = 10067,
                SystemNotReady = 10091,
                VersionNotSupported = 10092,
                NotInitialized = 10093,
                Disconnecting = 10101,
                TypeNotFound = 10109,
                HostNotFound = 11001,
                TryAgain = 11002,
                NoRecovery = 11003,
                NoData = 11004,
                IOPending = 997,
                OperationAborted = 995,
            }

            enum SocketFlags
            {
                None = 0,
                OutOfBand = 1,
                Peek = 2,
                DontRoute = 4,
                MaxIOVectorLength = 16,
                Truncated = 256,
                ControlDataTruncated = 512,
                Broadcast = 1024,
                Multicast = 2048,
                Partial = 32768,
            }

            struct SocketInformation
            {
                /*0x10*/ byte[] protocolInformation;
                /*0x18*/ System.Net.Sockets.SocketInformationOptions options;
                /*0x20*/ System.Net.EndPoint remoteEndPoint;

                /*0x24944ec*/ byte[] get_ProtocolInformation();
                /*0x24944f4*/ void set_ProtocolInformation(byte[] value);
                /*0x24944fc*/ System.Net.Sockets.SocketInformationOptions get_Options();
                /*0x2494504*/ void set_Options(System.Net.Sockets.SocketInformationOptions value);
            }

            enum SocketInformationOptions
            {
                NonBlocking = 1,
                Connected = 2,
                Listening = 4,
                UseOnlyOverlappedIO = 8,
            }

            enum SocketOptionLevel
            {
                Socket = 65535,
                IP = 0,
                IPv6 = 41,
                Tcp = 6,
                Udp = 17,
            }

            enum SocketOptionName
            {
                Debug = 1,
                AcceptConnection = 2,
                ReuseAddress = 4,
                KeepAlive = 8,
                DontRoute = 16,
                Broadcast = 32,
                UseLoopback = 64,
                Linger = 128,
                OutOfBandInline = 256,
                DontLinger = -129,
                ExclusiveAddressUse = -5,
                SendBuffer = 4097,
                ReceiveBuffer = 4098,
                SendLowWater = 4099,
                ReceiveLowWater = 4100,
                SendTimeout = 4101,
                ReceiveTimeout = 4102,
                Error = 4103,
                Type = 4104,
                ReuseUnicastPort = 12295,
                MaxConnections = 2147483647,
                IPOptions = 1,
                HeaderIncluded = 2,
                TypeOfService = 3,
                IpTimeToLive = 4,
                MulticastInterface = 9,
                MulticastTimeToLive = 10,
                MulticastLoopback = 11,
                AddMembership = 12,
                DropMembership = 13,
                DontFragment = 14,
                AddSourceMembership = 15,
                DropSourceMembership = 16,
                BlockSource = 17,
                UnblockSource = 18,
                PacketInformation = 19,
                HopLimit = 21,
                IPProtectionLevel = 23,
                IPv6Only = 27,
                NoDelay = 1,
                BsdUrgent = 2,
                Expedited = 2,
                NoChecksum = 1,
                ChecksumCoverage = 20,
                UpdateAcceptContext = 28683,
                UpdateConnectContext = 28688,
            }

            enum SocketShutdown
            {
                Receive = 0,
                Send = 1,
                Both = 2,
            }

            enum SocketType
            {
                Stream = 1,
                Dgram = 2,
                Raw = 3,
                Rdm = 4,
                Seqpacket = 5,
                Unknown = -1,
            }

            class TcpClient : System.IDisposable
            {
                /*0x10*/ System.Net.Sockets.Socket m_ClientSocket;
                /*0x18*/ bool m_Active;
                /*0x20*/ System.Net.Sockets.NetworkStream m_DataStream;
                /*0x28*/ System.Net.Sockets.AddressFamily m_Family;
                /*0x2c*/ bool m_CleanedUp;

                /*0x249450c*/ TcpClient();
                /*0x249452c*/ TcpClient(System.Net.Sockets.AddressFamily family);
                /*0x24946b0*/ System.Net.Sockets.Socket get_Client();
                /*0x24946b8*/ void set_Client(System.Net.Sockets.Socket value);
                /*0x24946c0*/ void Connect(string hostname, int port);
                /*0x2494db4*/ void Connect(System.Net.IPEndPoint remoteEP);
                /*0x2494ec0*/ System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state);
                /*0x2494f2c*/ void EndConnect(System.IAsyncResult asyncResult);
                /*0x2494f74*/ System.Threading.Tasks.Task ConnectAsync(string host, int port);
                /*0x24950e0*/ System.Net.Sockets.NetworkStream GetStream();
                /*0x249522c*/ void Dispose(bool disposing);
                /*0x24953c0*/ void Dispose();
                /*0x24953d0*/ void Finalize();
                /*0x249463c*/ void initialize();
            }

            enum TransmitFileOptions
            {
                UseDefaultWorkerThread = 0,
                Disconnect = 1,
                ReuseSocket = 2,
                WriteBehind = 4,
                UseSystemThread = 16,
                UseKernelApc = 32,
            }

            class SafeSocketHandle : Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid
            {
                static /*0x0*/ bool THROW_ON_ABORT_RETRIES;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> blocking_threads;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Threading.Thread, System.Diagnostics.StackTrace> threads_stacktraces;
                /*0x30*/ bool in_cleanup;

                static /*0x2495e40*/ SafeSocketHandle();
                /*0x2495470*/ SafeSocketHandle(nint preexistingHandle, bool ownsHandle);
                /*0x249553c*/ bool ReleaseHandle();
                /*0x2495b08*/ void RegisterForBlockingSyscall();
                /*0x2495c50*/ void UnRegisterForBlockingSyscall();
            }

            class SocketAsyncEventArgs : System.EventArgs, System.IDisposable
            {
                /*0x10*/ bool disposed;
                /*0x14*/ int in_progress;
                /*0x18*/ System.Net.EndPoint remote_ep;
                /*0x20*/ System.Net.Sockets.Socket current_socket;
                /*0x28*/ System.Net.Sockets.SocketAsyncResult socket_async_result;
                /*0x30*/ System.Exception <ConnectByNameError>k__BackingField;
                /*0x38*/ System.Net.Sockets.Socket <AcceptSocket>k__BackingField;
                /*0x40*/ int <BytesTransferred>k__BackingField;
                /*0x44*/ bool <DisconnectReuseSocket>k__BackingField;
                /*0x48*/ System.Net.Sockets.SocketAsyncOperation <LastOperation>k__BackingField;
                /*0x50*/ System.Net.Sockets.IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField;
                /*0x60*/ System.Net.Sockets.SendPacketsElement[] <SendPacketsElements>k__BackingField;
                /*0x68*/ System.Net.Sockets.TransmitFileOptions <SendPacketsFlags>k__BackingField;
                /*0x6c*/ int <SendPacketsSendSize>k__BackingField;
                /*0x70*/ System.Net.Sockets.SocketError <SocketError>k__BackingField;
                /*0x74*/ System.Net.Sockets.SocketFlags <SocketFlags>k__BackingField;
                /*0x78*/ object <UserToken>k__BackingField;
                /*0x80*/ System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed;
                /*0x88*/ System.Memory<byte> _buffer;
                /*0x98*/ int _offset;
                /*0x9c*/ int _count;
                /*0xa0*/ bool _bufferIsExplicitArray;
                /*0xa8*/ System.Collections.Generic.IList<System.ArraySegment<byte>> _bufferList;
                /*0xb0*/ System.Collections.Generic.List<System.ArraySegment<byte>> _bufferListInternal;

                /*0x249612c*/ SocketAsyncEventArgs();
                /*0x248db70*/ SocketAsyncEventArgs(bool flowExecutionContext);
                /*0x2495ed4*/ System.Exception get_ConnectByNameError();
                /*0x2495edc*/ void set_ConnectByNameError(System.Exception value);
                /*0x2495ee4*/ System.Net.Sockets.Socket get_AcceptSocket();
                /*0x2495eec*/ void set_AcceptSocket(System.Net.Sockets.Socket value);
                /*0x2495ef4*/ int get_BytesTransferred();
                /*0x2495efc*/ void set_BytesTransferred(int value);
                /*0x2495f04*/ bool get_DisconnectReuseSocket();
                /*0x2495f0c*/ void set_DisconnectReuseSocket(bool value);
                /*0x2495f18*/ System.Net.Sockets.SocketAsyncOperation get_LastOperation();
                /*0x2495f20*/ void set_LastOperation(System.Net.Sockets.SocketAsyncOperation value);
                /*0x2495f28*/ System.Net.EndPoint get_RemoteEndPoint();
                /*0x2495f30*/ void set_RemoteEndPoint(System.Net.EndPoint value);
                /*0x2495f38*/ System.Net.Sockets.IPPacketInformation get_ReceiveMessageFromPacketInfo();
                /*0x2495f44*/ void set_ReceiveMessageFromPacketInfo(System.Net.Sockets.IPPacketInformation value);
                /*0x2495f4c*/ System.Net.Sockets.SendPacketsElement[] get_SendPacketsElements();
                /*0x2495f54*/ void set_SendPacketsElements(System.Net.Sockets.SendPacketsElement[] value);
                /*0x2495f5c*/ System.Net.Sockets.TransmitFileOptions get_SendPacketsFlags();
                /*0x2495f64*/ void set_SendPacketsFlags(System.Net.Sockets.TransmitFileOptions value);
                /*0x2495f6c*/ int get_SendPacketsSendSize();
                /*0x2495f74*/ void set_SendPacketsSendSize(int value);
                /*0x2495f7c*/ System.Net.Sockets.SocketError get_SocketError();
                /*0x2495f84*/ void set_SocketError(System.Net.Sockets.SocketError value);
                /*0x2495f8c*/ System.Net.Sockets.SocketFlags get_SocketFlags();
                /*0x2495f94*/ void set_SocketFlags(System.Net.Sockets.SocketFlags value);
                /*0x2495f9c*/ object get_UserToken();
                /*0x2495fa4*/ void set_UserToken(object value);
                /*0x2495fac*/ System.Net.Sockets.Socket get_ConnectSocket();
                /*0x2495fcc*/ void add_Completed(System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> value);
                /*0x249607c*/ void remove_Completed(System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> value);
                /*0x24961cc*/ void Finalize();
                /*0x24961dc*/ void Dispose(bool disposing);
                /*0x24961f0*/ void Dispose();
                /*0x2496254*/ void SetConnectByNameError(System.Exception error);
                /*0x2493018*/ void SetBytesTransferred(int value);
                /*0x249625c*/ System.Net.Sockets.Socket get_CurrentSocket();
                /*0x2496264*/ void SetCurrentSocket(System.Net.Sockets.Socket socket);
                /*0x249626c*/ void SetLastOperation(System.Net.Sockets.SocketAsyncOperation op);
                /*0x2496334*/ void Complete_internal();
                /*0x249635c*/ void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs e);
                /*0x2496384*/ void StartOperationCommon(System.Net.Sockets.Socket socket);
                /*0x249638c*/ void StartOperationWrapperConnect(System.Net.Sockets.MultipleConnectAsync args);
                /*0x2496394*/ void FinishConnectByNameSyncFailure(System.Exception exception, int bytesTransferred, System.Net.Sockets.SocketFlags flags);
                /*0x2496474*/ void FinishOperationAsyncFailure(System.Exception exception, int bytesTransferred, System.Net.Sockets.SocketFlags flags);
                /*0x24964ac*/ void FinishWrapperConnectSuccess(System.Net.Sockets.Socket connectSocket, int bytesTransferred, System.Net.Sockets.SocketFlags flags);
                /*0x24964e4*/ void SetResults(System.Net.Sockets.SocketError socketError, int bytesTransferred, System.Net.Sockets.SocketFlags flags);
                /*0x24963cc*/ void SetResults(System.Exception exception, int bytesTransferred, System.Net.Sockets.SocketFlags flags);
                /*0x24964f4*/ byte[] get_Buffer();
                /*0x249658c*/ System.Memory<byte> get_MemoryBuffer();
                /*0x2496598*/ int get_Offset();
                /*0x24965a0*/ int get_Count();
                /*0x24965a8*/ System.Collections.Generic.IList<System.ArraySegment<byte>> get_BufferList();
                /*0x24965b0*/ void set_BufferList(System.Collections.Generic.IList<System.ArraySegment<byte>> value);
                /*0x24968d0*/ void SetBuffer(int offset, int count);
                /*0x2496a38*/ void CopyBufferFrom(System.Net.Sockets.SocketAsyncEventArgs source);
                /*0x2496a64*/ void SetBuffer(byte[] buffer, int offset, int count);
                /*0x2496bf0*/ void SetBuffer(System.Memory<byte> buffer);
                /*0x2496ce4*/ bool get_HasMultipleBuffers();
                /*0x2496cf4*/ System.Net.Sockets.SocketClientAccessPolicyProtocol get_SocketClientAccessPolicyProtocol();
                /*0x2496d2c*/ void set_SocketClientAccessPolicyProtocol(System.Net.Sockets.SocketClientAccessPolicyProtocol value);
            }

            class SocketAsyncResult : System.IOAsyncResult
            {
                /*0x30*/ System.Net.Sockets.Socket socket;
                /*0x38*/ System.Net.Sockets.SocketOperation operation;
                /*0x40*/ System.Exception DelayedException;
                /*0x48*/ System.Net.EndPoint EndPoint;
                /*0x50*/ System.Memory<byte> Buffer;
                /*0x60*/ int Offset;
                /*0x64*/ int Size;
                /*0x68*/ System.Net.Sockets.SocketFlags SockFlags;
                /*0x70*/ System.Net.Sockets.Socket AcceptSocket;
                /*0x78*/ System.Net.IPAddress[] Addresses;
                /*0x80*/ int Port;
                /*0x88*/ System.Collections.Generic.IList<System.ArraySegment<byte>> Buffers;
                /*0x90*/ bool ReuseSocket;
                /*0x94*/ int CurrentAddress;
                /*0x98*/ System.Net.Sockets.Socket AcceptedSocket;
                /*0xa0*/ int Total;
                /*0xa4*/ int error;
                /*0xa8*/ int EndCalled;

                /*0x24961c4*/ SocketAsyncResult();
                /*0x2496e7c*/ SocketAsyncResult(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x2496d64*/ nint get_Handle();
                /*0x2496dc8*/ void Init(System.Net.Sockets.Socket socket, System.AsyncCallback callback, object state, System.Net.Sockets.SocketOperation operation);
                /*0x2496eb4*/ System.Net.Sockets.SocketError get_ErrorCode();
                /*0x2496f34*/ void CheckIfThrowDelayedException();
                /*0x2496fdc*/ void CompleteDisposed();
                /*0x2492808*/ void Complete();
                /*0x2496fe0*/ void Complete(bool synch);
                /*0x24932c8*/ void Complete(int total);
                /*0x2496fec*/ void Complete(System.Exception e, bool synch);
                /*0x2492050*/ void Complete(System.Exception e);
                /*0x2492058*/ void Complete(System.Net.Sockets.Socket s);
                /*0x24922a4*/ void Complete(System.Net.Sockets.Socket s, int total);

                class <>c
                {
                    static /*0x0*/ System.Net.Sockets.SocketAsyncResult.<> <>9;
                    static /*0x8*/ System.Threading.WaitCallback <>9__27_0;

                    static /*0x2496ffc*/ <>c();
                    /*0x2497060*/ <>c();
                    /*0x2497068*/ void <Complete>b__27_0(object state);
                }
            }

            enum SocketOperation
            {
                Accept = 0,
                Connect = 1,
                Receive = 2,
                ReceiveFrom = 3,
                Send = 4,
                SendTo = 5,
                RecvJustCallback = 6,
                SendJustCallback = 7,
                Disconnect = 8,
                AcceptReceive = 9,
                ReceiveGeneric = 10,
                SendGeneric = 11,
            }

            struct SocketReceiveFromResult
            {
                /*0x10*/ int ReceivedBytes;
                /*0x18*/ System.Net.EndPoint RemoteEndPoint;
            }

            struct SocketReceiveMessageFromResult
            {
                /*0x10*/ int ReceivedBytes;
                /*0x14*/ System.Net.Sockets.SocketFlags SocketFlags;
                /*0x18*/ System.Net.EndPoint RemoteEndPoint;
                /*0x20*/ System.Net.Sockets.IPPacketInformation PacketInformation;
            }
        }

        namespace Security
        {
            class SslClientAuthenticationOptions
            {
                /*0x10*/ System.Net.Security.EncryptionPolicy _encryptionPolicy;
                /*0x14*/ System.Security.Cryptography.X509Certificates.X509RevocationMode _checkCertificateRevocation;
                /*0x18*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
                /*0x1c*/ bool _allowRenegotiation;
                /*0x20*/ string <TargetHost>k__BackingField;
                /*0x28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <ClientCertificates>k__BackingField;

                /*0x2497250*/ SslClientAuthenticationOptions();
                /*0x24970e0*/ string get_TargetHost();
                /*0x24970e8*/ void set_TargetHost(string value);
                /*0x24970f0*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
                /*0x24970f8*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x2497100*/ void set_CertificateRevocationCheckMode(System.Security.Cryptography.X509Certificates.X509RevocationMode value);
                /*0x24971a0*/ void set_EncryptionPolicy(System.Net.Security.EncryptionPolicy value);
                /*0x2497240*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
                /*0x2497248*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            }

            class AuthenticatedStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream _InnerStream;
                /*0x30*/ bool _LeaveStreamOpen;

                /*0x2497260*/ AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen);
                /*0x24973f8*/ System.IO.Stream get_InnerStream();
                /*0x2497400*/ void Dispose(bool disposing);
                bool get_IsAuthenticated();
            }

            enum AuthenticationLevel
            {
                None = 0,
                MutualAuthRequested = 1,
                MutualAuthRequired = 2,
            }

            enum EncryptionPolicy
            {
                RequireEncryption = 0,
                AllowNoEncryption = 1,
                NoEncryption = 2,
            }

            class LocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x24974e8*/ LocalCertificateSelectionCallback(object object, nint method);
                /*0x2497618*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class RemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x249762c*/ RemoteCertificateValidationCallback(object object, nint method);
                /*0x249775c*/ bool Invoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
                /*0x2497770*/ System.IAsyncResult BeginInvoke(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors, System.AsyncCallback callback, object object);
                /*0x2497818*/ bool EndInvoke(System.IAsyncResult result);
            }

            enum SslPolicyErrors
            {
                None = 0,
                RemoteCertificateNotAvailable = 1,
                RemoteCertificateNameMismatch = 2,
                RemoteCertificateChainErrors = 4,
            }

            class LocalCertSelectionCallback : System.MulticastDelegate
            {
                /*0x2497840*/ LocalCertSelectionCallback(object object, nint method);
                /*0x2497918*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class ServerCertSelectionCallback : System.MulticastDelegate
            {
                /*0x249792c*/ ServerCertSelectionCallback(object object, nint method);
                /*0x2497a00*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string hostName);
            }

            class SslStream : System.Net.Security.AuthenticatedStream
            {
                /*0x38*/ Mono.Net.Security.MobileTlsProvider provider;
                /*0x40*/ Mono.Security.Interface.MonoTlsSettings settings;
                /*0x48*/ System.Net.Security.RemoteCertificateValidationCallback validationCallback;
                /*0x50*/ System.Net.Security.LocalCertificateSelectionCallback selectionCallback;
                /*0x58*/ Mono.Net.Security.MobileAuthenticatedStream impl;
                /*0x60*/ bool explicitSettings;

                static /*0x2497ab0*/ Mono.Net.Security.MobileTlsProvider GetProvider();
                /*0x2497b20*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback);
                /*0x2497b2c*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback);
                /*0x2497e14*/ SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsProvider provider, Mono.Security.Interface.MonoTlsSettings settings);
                /*0x2497a14*/ Mono.Net.Security.MobileAuthenticatedStream get_Impl();
                /*0x2497a8c*/ string get_InternalTargetHost();
                /*0x2497bbc*/ void SetAndVerifyValidationCallback(System.Net.Security.RemoteCertificateValidationCallback callback);
                /*0x2497c9c*/ void SetAndVerifySelectionCallback(System.Net.Security.LocalCertificateSelectionCallback callback);
                /*0x2497f40*/ void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x2497f94*/ System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState);
                /*0x2498008*/ void EndAuthenticateAsClient(System.IAsyncResult asyncResult);
                /*0x2498014*/ System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                /*0x2498068*/ bool get_IsAuthenticated();
                /*0x2498094*/ System.Security.Cryptography.X509Certificates.X509Certificate get_LocalCertificate();
                /*0x24980b8*/ bool get_CanSeek();
                /*0x24980c0*/ bool get_CanRead();
                /*0x24980d8*/ bool get_CanTimeout();
                /*0x24980f8*/ bool get_CanWrite();
                /*0x2498110*/ int get_ReadTimeout();
                /*0x249813c*/ void set_ReadTimeout(int value);
                /*0x2498178*/ int get_WriteTimeout();
                /*0x24981a4*/ void set_WriteTimeout(int value);
                /*0x24981e0*/ long get_Length();
                /*0x249820c*/ long get_Position();
                /*0x2498238*/ void set_Position(long value);
                /*0x2498298*/ void SetLength(long value);
                /*0x24982d4*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x2498334*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x2498358*/ void Flush();
                /*0x2497a2c*/ void CheckDisposed();
                /*0x249837c*/ void Dispose(bool disposing);
                /*0x2498428*/ int Read(byte[] buffer, int offset, int count);
                /*0x249847c*/ void Write(byte[] buffer, int offset, int count);
                /*0x24984d0*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x249852c*/ System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x2498588*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x24985f4*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x249863c*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
                /*0x24986a8*/ void EndWrite(System.IAsyncResult asyncResult);

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ System.Net.Security.LocalCertificateSelectionCallback callback;
                    /*0x18*/ System.Net.Security.SslStream <>4__this;

                    /*0x2497f38*/ <>c__DisplayClass21_0();
                    /*0x24986b4*/ System.Security.Cryptography.X509Certificates.X509Certificate <SetAndVerifySelectionCallback>b__0(string t, System.Security.Cryptography.X509Certificates.X509CertificateCollection lc, System.Security.Cryptography.X509Certificates.X509Certificate rc, string[] ai);
                }
            }
        }
    }

    namespace ComponentModel
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object _value;

            /*0x24986ec*/ DefaultValueAttribute(string value);
            /*0x2498714*/ object get_Value();
            /*0x249871c*/ bool Equals(object obj);
            /*0x2498828*/ int GetHashCode();
        }

        class EditorBrowsableAttribute : System.Attribute
        {
            /*0x10*/ System.ComponentModel.EditorBrowsableState browsableState;

            /*0x2498830*/ EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState state);
            /*0x2498858*/ bool Equals(object obj);
            /*0x24988e4*/ int GetHashCode();
        }

        enum EditorBrowsableState
        {
            Always = 0,
            Never = 1,
            Advanced = 2,
        }

        class ArrayConverter : System.ComponentModel.CollectionConverter
        {
            /*0x24988ec*/ ArrayConverter();
        }

        class BaseNumberConverter : System.ComponentModel.TypeConverter
        {
            /*0x24988fc*/ BaseNumberConverter();
        }

        class BooleanConverter : System.ComponentModel.TypeConverter
        {
            static /*0x0*/ System.ComponentModel.TypeConverter.StandardValuesCollection s_values;

            /*0x249890c*/ BooleanConverter();
        }

        class DecimalConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x2498914*/ DecimalConverter();
        }

        class DoubleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x249891c*/ DoubleConverter();
        }

        class Int16Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x2498924*/ Int16Converter();
        }

        class Int32Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x249892c*/ Int32Converter();
        }

        class Int64Converter : System.ComponentModel.BaseNumberConverter
        {
            /*0x2498934*/ Int64Converter();
        }

        class SingleConverter : System.ComponentModel.BaseNumberConverter
        {
            /*0x249893c*/ SingleConverter();
        }

        class StringConverter : System.ComponentModel.TypeConverter
        {
            /*0x2498944*/ StringConverter();
        }

        class TimeSpanConverter : System.ComponentModel.TypeConverter
        {
            /*0x249894c*/ TimeSpanConverter();
        }

        class TypeConverterAttribute : System.Attribute
        {
            static /*0x0*/ System.ComponentModel.TypeConverterAttribute Default;
            /*0x10*/ string <ConverterTypeName>k__BackingField;

            static /*0x2498a9c*/ TypeConverterAttribute();
            /*0x2498954*/ TypeConverterAttribute();
            /*0x24989b0*/ TypeConverterAttribute(System.Type type);
            /*0x24989f4*/ string get_ConverterTypeName();
            /*0x24989fc*/ bool Equals(object obj);
            /*0x2498a7c*/ int GetHashCode();
        }

        class CollectionConverter : System.ComponentModel.TypeConverter
        {
            /*0x24988f4*/ CollectionConverter();
        }

        class EnumConverter : System.ComponentModel.TypeConverter
        {
            /*0x10*/ System.ComponentModel.TypeConverter.StandardValuesCollection values;
            /*0x18*/ System.Type type;

            /*0x2498afc*/ EnumConverter(System.Type type);
        }

        class TypeConverter
        {
            static string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
            static /*0x0*/ bool useCompatibleTypeConversion;

            /*0x2498904*/ TypeConverter();

            class StandardValuesCollection
            {
            }
        }

        class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable
        {
            /*0x8c*/ int nativeErrorCode;

            static /*0x2498b98*/ string GetErrorMessage(int error);
            /*0x2498b24*/ Win32Exception();
            /*0x2494210*/ Win32Exception(int error);
            /*0x2494274*/ Win32Exception(int error, string message);
            /*0x24942a4*/ Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x249948c*/ int get_NativeErrorCode();
            /*0x2499494*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }
    }

    namespace Collections
    {
        class HashtableExtensions
        {
            static bool TryGetValue<T>(System.Collections.Hashtable table, object key, ref T value);
        }

        namespace Specialized
        {
            interface IOrderedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                object get_Item(int index);
                void set_Item(int index, object value);
                System.Collections.IDictionaryEnumerator GetEnumerator();
                void Insert(int index, object key, object value);
                void RemoveAt(int index);
            }

            class ListDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Specialized.ListDictionary.DictionaryNode head;
                /*0x18*/ int version;
                /*0x1c*/ int count;
                /*0x20*/ System.Collections.IComparer comparer;
                /*0x28*/ object _syncRoot;

                /*0x2499560*/ ListDictionary();
                /*0x2499568*/ ListDictionary(System.Collections.IComparer comparer);
                /*0x2499590*/ object get_Item(object key);
                /*0x24996f4*/ void set_Item(object key, object value);
                /*0x24998c0*/ int get_Count();
                /*0x24998c8*/ System.Collections.ICollection get_Keys();
                /*0x2499964*/ bool get_IsReadOnly();
                /*0x249996c*/ bool get_IsFixedSize();
                /*0x2499974*/ bool get_IsSynchronized();
                /*0x249997c*/ object get_SyncRoot();
                /*0x24999f8*/ System.Collections.ICollection get_Values();
                /*0x2499a60*/ void Add(object key, object value);
                /*0x2499c78*/ void Clear();
                /*0x2499c8c*/ bool Contains(object key);
                /*0x2499de0*/ void CopyTo(System.Array array, int index);
                /*0x2499fb0*/ System.Collections.IDictionaryEnumerator GetEnumerator();
                /*0x249a054*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x249a0b4*/ void Remove(object key);

                class NodeEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                    /*0x20*/ int _version;
                    /*0x24*/ bool _start;

                    /*0x249a010*/ NodeEnumerator(System.Collections.Specialized.ListDictionary list);
                    /*0x249a24c*/ object get_Current();
                    /*0x249a2b0*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x249a330*/ object get_Key();
                    /*0x249a394*/ object get_Value();
                    /*0x249a3f8*/ bool MoveNext();
                    /*0x249a498*/ void Reset();
                }

                class NodeKeyValueCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                    /*0x18*/ bool _isKeys;

                    /*0x2499934*/ NodeKeyValueCollection(System.Collections.Specialized.ListDictionary list, bool isKeys);
                    /*0x249a518*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    /*0x249a664*/ int System.Collections.ICollection.get_Count();
                    /*0x249a69c*/ bool System.Collections.ICollection.get_IsSynchronized();
                    /*0x249a6a4*/ object System.Collections.ICollection.get_SyncRoot();
                    /*0x249a6bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class NodeKeyValueEnumerator : System.Collections.IEnumerator
                    {
                        /*0x10*/ System.Collections.Specialized.ListDictionary _list;
                        /*0x18*/ System.Collections.Specialized.ListDictionary.DictionaryNode _current;
                        /*0x20*/ int _version;
                        /*0x24*/ bool _isKeys;
                        /*0x25*/ bool _start;

                        /*0x249a734*/ NodeKeyValueEnumerator(System.Collections.Specialized.ListDictionary list, bool isKeys);
                        /*0x249a780*/ object get_Current();
                        /*0x249a7f8*/ bool MoveNext();
                        /*0x249a898*/ void Reset();
                    }
                }

                class DictionaryNode
                {
                    /*0x10*/ object key;
                    /*0x18*/ object value;
                    /*0x20*/ System.Collections.Specialized.ListDictionary.DictionaryNode next;

                    /*0x24998b8*/ DictionaryNode();
                }
            }

            class NameValueCollection : System.Collections.Specialized.NameObjectCollectionBase
            {
                /*0x50*/ string[] _all;
                /*0x58*/ string[] _allKeys;

                static /*0x249ab08*/ string GetAsOneString(System.Collections.ArrayList list);
                static /*0x249aca8*/ string[] GetAsStringArray(System.Collections.ArrayList list);
                /*0x249a918*/ NameValueCollection();
                /*0x249a9cc*/ NameValueCollection(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x249aa6c*/ NameValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x249b7f0*/ NameValueCollection(System.DBNull dummy);
                /*0x249ab00*/ void InvalidateCachedArrays();
                /*0x249ad48*/ void Add(string name, string value);
                /*0x249b030*/ string Get(string name);
                /*0x249b0bc*/ string[] GetValues(string name);
                /*0x249b148*/ void Set(string name, string value);
                /*0x249b2e4*/ void Remove(string name);
                /*0x249b4f8*/ string get_Item(string name);
                /*0x249b508*/ void set_Item(string name, string value);
                /*0x249b518*/ string Get(int index);
                /*0x249b638*/ string GetKey(int index);
                /*0x249b6d8*/ string[] get_AllKeys();
            }

            class StringCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.ArrayList data;

                /*0x249bdc4*/ StringCollection();
                /*0x249b850*/ string get_Item(int index);
                /*0x249b8cc*/ void set_Item(int index, string value);
                /*0x249b8f0*/ int get_Count();
                /*0x249b914*/ bool System.Collections.IList.get_IsReadOnly();
                /*0x249b91c*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x249b924*/ int Add(string value);
                /*0x249b948*/ void Clear();
                /*0x249b96c*/ bool Contains(string value);
                /*0x249b990*/ void CopyTo(string[] array, int index);
                /*0x249b9b4*/ int IndexOf(string value);
                /*0x249b9d8*/ void Insert(int index, string value);
                /*0x249b9fc*/ bool get_IsSynchronized();
                /*0x249ba04*/ void Remove(string value);
                /*0x249ba28*/ void RemoveAt(int index);
                /*0x249ba4c*/ object get_SyncRoot();
                /*0x249ba70*/ object System.Collections.IList.get_Item(int index);
                /*0x249ba74*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x249bb00*/ int System.Collections.IList.Add(object value);
                /*0x249bb7c*/ bool System.Collections.IList.Contains(object value);
                /*0x249bbf8*/ int System.Collections.IList.IndexOf(object value);
                /*0x249bc74*/ void System.Collections.IList.Insert(int index, object value);
                /*0x249bd00*/ void System.Collections.IList.Remove(object value);
                /*0x249bd7c*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x249bda0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class NameObjectCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                static /*0x0*/ System.StringComparer defaultComparer;
                /*0x10*/ bool _readOnly;
                /*0x18*/ System.Collections.ArrayList _entriesArray;
                /*0x20*/ System.Collections.IEqualityComparer _keyComparer;
                /*0x28*/ System.Collections.Hashtable _entriesTable;
                /*0x30*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry _nullKeyEntry;
                /*0x38*/ System.Runtime.Serialization.SerializationInfo _serializationInfo;
                /*0x40*/ int _version;
                /*0x48*/ object _syncRoot;

                static /*0x249d4c4*/ NameObjectCollectionBase();
                /*0x249a96c*/ NameObjectCollectionBase();
                /*0x249be2c*/ NameObjectCollectionBase(System.Collections.IEqualityComparer equalityComparer);
                /*0x249aa40*/ NameObjectCollectionBase(int capacity, System.Collections.IEqualityComparer equalityComparer);
                /*0x249b848*/ NameObjectCollectionBase(System.DBNull dummy);
                /*0x249aad8*/ NameObjectCollectionBase(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x249c028*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x249c764*/ void OnDeserialization(object sender);
                /*0x249beac*/ void Reset();
                /*0x249bf64*/ void Reset(int capacity);
                /*0x249cf74*/ System.Collections.Specialized.NameObjectCollectionBase.NameObjectEntry FindEntry(string key);
                /*0x249d02c*/ bool get_IsReadOnly();
                /*0x249aecc*/ void BaseAdd(string name, object value);
                /*0x249b2ec*/ void BaseRemove(string name);
                /*0x249aeb4*/ object BaseGet(string name);
                /*0x249b234*/ void BaseSet(string name, object value);
                /*0x249b59c*/ object BaseGet(int index);
                /*0x249b63c*/ string BaseGetKey(int index);
                /*0x249d060*/ System.Collections.IEnumerator GetEnumerator();
                /*0x249d100*/ int get_Count();
                /*0x249d124*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x249d440*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x249d4bc*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x249b6fc*/ string[] BaseGetAllKeys();

                class NameObjectEntry
                {
                    /*0x10*/ string Key;
                    /*0x18*/ object Value;

                    /*0x249d034*/ NameObjectEntry(string name, object value);
                }

                class NameObjectKeysEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ int _pos;
                    /*0x18*/ System.Collections.Specialized.NameObjectCollectionBase _coll;
                    /*0x20*/ int _version;

                    /*0x249d0c0*/ NameObjectKeysEnumerator(System.Collections.Specialized.NameObjectCollectionBase coll);
                    /*0x249d56c*/ bool MoveNext();
                    /*0x249d64c*/ void Reset();
                    /*0x249d6dc*/ object get_Current();
                }
            }

            class CompatibleComparer : System.Collections.IEqualityComparer
            {
                static /*0x0*/ System.Collections.IComparer defaultComparer;
                static /*0x8*/ System.Collections.IHashCodeProvider defaultHashProvider;
                /*0x10*/ System.Collections.IComparer _comparer;
                /*0x18*/ System.Collections.IHashCodeProvider _hcp;

                static /*0x249c688*/ System.Collections.IComparer get_DefaultComparer();
                static /*0x249c5a8*/ System.Collections.IHashCodeProvider get_DefaultHashCodeProvider();
                /*0x249cf48*/ CompatibleComparer(System.Collections.IComparer comparer, System.Collections.IHashCodeProvider hashCodeProvider);
                /*0x249d784*/ bool Equals(object a, object b);
                /*0x249d984*/ int GetHashCode(object obj);
                /*0x249da90*/ System.Collections.IComparer get_Comparer();
                /*0x249da98*/ System.Collections.IHashCodeProvider get_HashCodeProvider();
            }
        }

        namespace Generic
        {
            struct ValueListBuilder<T>
            {
                /*0x0*/ System.Span<T> _span;
                /*0x0*/ T[] _arrayFromPool;
                /*0x0*/ int _pos;

                ValueListBuilder(System.Span<T> initialSpan);
                int get_Length();
                ref T get_Item(int index);
                void Append(T item);
                System.ReadOnlySpan<T> AsSpan();
                void Dispose();
                void Grow();
                T Pop();
            }

            class ICollectionDebugView<T>
            {
            }

            class IDictionaryDebugView<K, V>
            {
            }

            class DictionaryKeyCollectionDebugView<TKey, TValue>
            {
            }

            class DictionaryValueCollectionDebugView<TKey, TValue>
            {
            }

            class LinkedList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> head;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo _siInfo;

                LinkedList();
                LinkedList(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                int get_Count();
                System.Collections.Generic.LinkedListNode<T> get_First();
                bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                void System.Collections.Generic.ICollection<T>.Add(T value);
                System.Collections.Generic.LinkedListNode<T> AddBefore(System.Collections.Generic.LinkedListNode<T> node, T value);
                System.Collections.Generic.LinkedListNode<T> AddFirst(T value);
                System.Collections.Generic.LinkedListNode<T> AddLast(T value);
                void AddLast(System.Collections.Generic.LinkedListNode<T> node);
                void Clear();
                bool Contains(T value);
                void CopyTo(T[] array, int index);
                System.Collections.Generic.LinkedListNode<T> Find(T value);
                System.Collections.Generic.LinkedList.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                bool Remove(T value);
                void Remove(System.Collections.Generic.LinkedListNode<T> node);
                void RemoveFirst();
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void OnDeserialization(object sender);
                void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode);
                void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode);
                void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node);
                void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node);
                void ValidateNode(System.Collections.Generic.LinkedListNode<T> node);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    /*0x0*/ System.Collections.Generic.LinkedList<T> _list;
                    /*0x0*/ System.Collections.Generic.LinkedListNode<T> _node;
                    /*0x0*/ int _version;
                    /*0x0*/ T _current;
                    /*0x0*/ int _index;

                    Enumerator(System.Collections.Generic.LinkedList<T> list);
                    Enumerator(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    T get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    bool MoveNext();
                    void System.Collections.IEnumerator.Reset();
                    void Dispose();
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                }
            }

            class LinkedListNode<T>
            {
                /*0x0*/ System.Collections.Generic.LinkedList<T> list;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> next;
                /*0x0*/ System.Collections.Generic.LinkedListNode<T> prev;
                /*0x0*/ T item;

                LinkedListNode(System.Collections.Generic.LinkedList<T> list, T value);
                System.Collections.Generic.LinkedList<T> get_List();
                System.Collections.Generic.LinkedListNode<T> get_Next();
                T get_Value();
                void set_Value(T value);
                void Invalidate();
            }

            class SortedDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> _keys;
                /*0x0*/ System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> _values;
                /*0x0*/ System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey, TValue>> _set;

                static bool IsCompatibleKey(object key);
                SortedDictionary();
                SortedDictionary(System.Collections.Generic.IComparer<TKey> comparer);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                int get_Count();
                System.Collections.Generic.SortedDictionary.KeyCollection<TKey, TValue> get_Keys();
                System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.SortedDictionary.ValueCollection<TKey, TValue> get_Values();
                System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                void Add(TKey key, TValue value);
                void Clear();
                bool ContainsKey(TKey key);
                bool ContainsValue(TValue value);
                void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int index);
                System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetEnumerator();
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                bool Remove(TKey key);
                bool TryGetValue(TKey key, ref TValue value);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                bool System.Collections.IDictionary.get_IsFixedSize();
                bool System.Collections.IDictionary.get_IsReadOnly();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                System.Collections.ICollection System.Collections.IDictionary.get_Values();
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                void System.Collections.IDictionary.Add(object key, object value);
                bool System.Collections.IDictionary.Contains(object key);
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                void System.Collections.IDictionary.Remove(object key);
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedSet.Enumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> _treeEnum;
                    /*0x0*/ int _getEnumeratorRetType;

                    Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
                    bool MoveNext();
                    void Dispose();
                    System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    bool get_NotStartedOrEnded();
                    void Reset();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                    object System.Collections.IDictionaryEnumerator.get_Key();
                    object System.Collections.IDictionaryEnumerator.get_Value();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                }

                class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TKey>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    KeyCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    void CopyTo(TKey[] array, int index);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    int get_Count();
                    bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly();
                    void System.Collections.Generic.ICollection<TKey>.Add(TKey item);
                    void System.Collections.Generic.ICollection<TKey>.Clear();
                    bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item);
                    bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item);
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        void Dispose();
                        bool MoveNext();
                        TKey get_Current();
                        object System.Collections.IEnumerator.get_Current();
                        void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TKey[] array;
                        /*0x0*/ int index;

                        <>c__DisplayClass5_0();
                        bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        <>c__DisplayClass6_0();
                        bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<TValue>
                {
                    /*0x0*/ System.Collections.Generic.SortedDictionary<TKey, TValue> _dictionary;

                    ValueCollection(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                    System.Collections.Generic.SortedDictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator();
                    System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    void CopyTo(TValue[] array, int index);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    int get_Count();
                    bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly();
                    void System.Collections.Generic.ICollection<TValue>.Add(TValue item);
                    void System.Collections.Generic.ICollection<TValue>.Clear();
                    bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item);
                    bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item);
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x0*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> _dictEnum;

                        Enumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> dictionary);
                        void Dispose();
                        bool MoveNext();
                        TValue get_Current();
                        object System.Collections.IEnumerator.get_Current();
                        void System.Collections.IEnumerator.Reset();
                    }

                    class <>c__DisplayClass5_0<TKey, TValue>
                    {
                        /*0x0*/ TValue[] array;
                        /*0x0*/ int index;

                        <>c__DisplayClass5_0();
                        bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }

                    class <>c__DisplayClass6_0<TKey, TValue>
                    {
                        /*0x0*/ int index;
                        /*0x0*/ object[] objects;

                        <>c__DisplayClass6_0();
                        bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                    }
                }

                class KeyValuePairComparer<TKey, TValue> : System.Collections.Generic.Comparer<System.Collections.Generic.KeyValuePair<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.IComparer<TKey> keyComparer;

                    KeyValuePairComparer(System.Collections.Generic.IComparer<TKey> keyComparer);
                    int Compare(System.Collections.Generic.KeyValuePair<TKey, TValue> x, System.Collections.Generic.KeyValuePair<TKey, TValue> y);
                }

                class <>c__DisplayClass34_0<TKey, TValue>
                {
                    /*0x0*/ bool found;
                    /*0x0*/ TValue value;

                    <>c__DisplayClass34_0();
                    bool <ContainsValue>b__0(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }

                class <>c__DisplayClass34_1<TKey, TValue>
                {
                    /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> valueComparer;
                    /*0x0*/ System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1;

                    <>c__DisplayClass34_1();
                    bool <ContainsValue>b__1(System.Collections.Generic.SortedSet.Node<System.Collections.Generic.KeyValuePair<TKey, TValue>> node);
                }
            }

            class TreeSet<T> : System.Collections.Generic.SortedSet<T>
            {
                TreeSet();
                TreeSet(System.Collections.Generic.IComparer<T> comparer);
                TreeSet(System.Runtime.Serialization.SerializationInfo siInfo, System.Runtime.Serialization.StreamingContext context);
                bool AddIfNotPresent(T item);
            }

            class SortedList<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ TKey[] keys;
                /*0x0*/ TValue[] values;
                /*0x0*/ int _size;
                /*0x0*/ int version;
                /*0x0*/ System.Collections.Generic.IComparer<TKey> comparer;
                /*0x0*/ System.Collections.Generic.SortedList.KeyList<TKey, TValue> keyList;
                /*0x0*/ System.Collections.Generic.SortedList.ValueList<TKey, TValue> valueList;
                /*0x0*/ object _syncRoot;

                static bool IsCompatibleKey(object key);
                SortedList();
                void Add(TKey key, TValue value);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> keyValuePair);
                void set_Capacity(int value);
                void System.Collections.IDictionary.Add(object key, object value);
                int get_Count();
                System.Collections.Generic.IList<TKey> get_Keys();
                System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys();
                System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                System.Collections.Generic.IList<TValue> get_Values();
                System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values();
                System.Collections.ICollection System.Collections.IDictionary.get_Values();
                System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();
                System.Collections.Generic.SortedList.KeyList<TKey, TValue> GetKeyListHelper();
                System.Collections.Generic.SortedList.ValueList<TKey, TValue> GetValueListHelper();
                bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
                bool System.Collections.IDictionary.get_IsReadOnly();
                bool System.Collections.IDictionary.get_IsFixedSize();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void Clear();
                bool System.Collections.IDictionary.Contains(object key);
                bool ContainsKey(TKey key);
                bool ContainsValue(TValue value);
                void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                void EnsureCapacity(int min);
                TValue GetByIndex(int index);
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
                System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                TKey GetKey(int index);
                TValue get_Item(TKey key);
                void set_Item(TKey key, TValue value);
                object System.Collections.IDictionary.get_Item(object key);
                void System.Collections.IDictionary.set_Item(object key, object value);
                int IndexOfKey(TKey key);
                int IndexOfValue(TValue value);
                void Insert(int index, TKey key, TValue value);
                bool TryGetValue(TKey key, ref TValue value);
                void RemoveAt(int index);
                bool Remove(TKey key);
                void System.Collections.IDictionary.Remove(object key);

                struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.IDisposable, System.Collections.IEnumerator, System.Collections.IDictionaryEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ TKey _key;
                    /*0x0*/ TValue _value;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ int _getEnumeratorRetType;

                    Enumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList, int getEnumeratorRetType);
                    void Dispose();
                    object System.Collections.IDictionaryEnumerator.get_Key();
                    bool MoveNext();
                    System.Collections.DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry();
                    System.Collections.Generic.KeyValuePair<TKey, TValue> get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    object System.Collections.IDictionaryEnumerator.get_Value();
                    void System.Collections.IEnumerator.Reset();
                }

                class SortedListKeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TKey _currentKey;

                    SortedListKeyEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    void Dispose();
                    bool MoveNext();
                    TKey get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }

                class SortedListValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _sortedList;
                    /*0x0*/ int _index;
                    /*0x0*/ int _version;
                    /*0x0*/ TValue _currentValue;

                    SortedListValueEnumerator(System.Collections.Generic.SortedList<TKey, TValue> sortedList);
                    void Dispose();
                    bool MoveNext();
                    TValue get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    void System.Collections.IEnumerator.Reset();
                }

                class KeyList<TKey, TValue> : System.Collections.Generic.IList<TKey>, System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    KeyList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    int get_Count();
                    bool get_IsReadOnly();
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();
                    void Add(TKey key);
                    void Clear();
                    bool Contains(TKey key);
                    void CopyTo(TKey[] array, int arrayIndex);
                    void System.Collections.ICollection.CopyTo(System.Array array, int arrayIndex);
                    void Insert(int index, TKey value);
                    TKey get_Item(int index);
                    void set_Item(int index, TKey value);
                    System.Collections.Generic.IEnumerator<TKey> GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    int IndexOf(TKey key);
                    bool Remove(TKey key);
                    void RemoveAt(int index);
                }

                class ValueList<TKey, TValue> : System.Collections.Generic.IList<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ System.Collections.Generic.SortedList<TKey, TValue> _dict;

                    ValueList(System.Collections.Generic.SortedList<TKey, TValue> dictionary);
                    int get_Count();
                    bool get_IsReadOnly();
                    bool System.Collections.ICollection.get_IsSynchronized();
                    object System.Collections.ICollection.get_SyncRoot();
                    void Add(TValue key);
                    void Clear();
                    bool Contains(TValue value);
                    void CopyTo(TValue[] array, int arrayIndex);
                    void System.Collections.ICollection.CopyTo(System.Array array, int index);
                    void Insert(int index, TValue value);
                    TValue get_Item(int index);
                    void set_Item(int index, TValue value);
                    System.Collections.Generic.IEnumerator<TValue> GetEnumerator();
                    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    int IndexOf(TValue value);
                    bool Remove(TValue value);
                    void RemoveAt(int index);
                }
            }

            class SortedSet<T> : System.Collections.Generic.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection, System.Collections.Generic.IReadOnlyCollection<T>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
            {
                /*0x0*/ System.Collections.Generic.SortedSet.Node<T> root;
                /*0x0*/ System.Collections.Generic.IComparer<T> comparer;
                /*0x0*/ int count;
                /*0x0*/ int version;
                /*0x0*/ object _syncRoot;
                /*0x0*/ System.Runtime.Serialization.SerializationInfo siInfo;

                static int Log2(int value);
                SortedSet();
                SortedSet(System.Collections.Generic.IComparer<T> comparer);
                SortedSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action);
                int get_Count();
                bool System.Collections.Generic.ICollection<T>.get_IsReadOnly();
                bool System.Collections.ICollection.get_IsSynchronized();
                object System.Collections.ICollection.get_SyncRoot();
                void VersionCheck();
                bool IsWithinRange(T item);
                bool Add(T item);
                void System.Collections.Generic.ICollection<T>.Add(T item);
                bool AddIfNotPresent(T item);
                bool Remove(T item);
                bool DoRemove(T item);
                void Clear();
                bool Contains(T item);
                void CopyTo(T[] array, int index);
                void CopyTo(T[] array, int index, int count);
                void System.Collections.ICollection.CopyTo(System.Array array, int index);
                System.Collections.Generic.SortedSet.Enumerator<T> GetEnumerator();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                void InsertionBalance(System.Collections.Generic.SortedSet.Node<T> current, ref System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> grandParent, System.Collections.Generic.SortedSet.Node<T> greatGrandParent);
                void ReplaceChildOrRoot(System.Collections.Generic.SortedSet.Node<T> parent, System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                void ReplaceNode(System.Collections.Generic.SortedSet.Node<T> match, System.Collections.Generic.SortedSet.Node<T> parentOfMatch, System.Collections.Generic.SortedSet.Node<T> successor, System.Collections.Generic.SortedSet.Node<T> parentOfSuccessor);
                System.Collections.Generic.SortedSet.Node<T> FindNode(T item);
                void UpdateVersion();
                void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                void OnDeserialization(object sender);

                class Node<T>
                {
                    /*0x0*/ T <Item>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Left>k__BackingField;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> <Right>k__BackingField;
                    /*0x0*/ System.Collections.Generic.NodeColor <Color>k__BackingField;

                    static bool IsNonNullRed(System.Collections.Generic.SortedSet.Node<T> node);
                    static bool IsNullOrBlack(System.Collections.Generic.SortedSet.Node<T> node);
                    Node(T item, System.Collections.Generic.NodeColor color);
                    T get_Item();
                    void set_Item(T value);
                    System.Collections.Generic.SortedSet.Node<T> get_Left();
                    void set_Left(System.Collections.Generic.SortedSet.Node<T> value);
                    System.Collections.Generic.SortedSet.Node<T> get_Right();
                    void set_Right(System.Collections.Generic.SortedSet.Node<T> value);
                    System.Collections.Generic.NodeColor get_Color();
                    void set_Color(System.Collections.Generic.NodeColor value);
                    bool get_IsBlack();
                    bool get_IsRed();
                    bool get_Is2Node();
                    bool get_Is4Node();
                    void ColorBlack();
                    void ColorRed();
                    System.Collections.Generic.TreeRotation GetRotation(System.Collections.Generic.SortedSet.Node<T> current, System.Collections.Generic.SortedSet.Node<T> sibling);
                    System.Collections.Generic.SortedSet.Node<T> GetSibling(System.Collections.Generic.SortedSet.Node<T> node);
                    void Split4Node();
                    System.Collections.Generic.SortedSet.Node<T> Rotate(System.Collections.Generic.TreeRotation rotation);
                    System.Collections.Generic.SortedSet.Node<T> RotateLeft();
                    System.Collections.Generic.SortedSet.Node<T> RotateLeftRight();
                    System.Collections.Generic.SortedSet.Node<T> RotateRight();
                    System.Collections.Generic.SortedSet.Node<T> RotateRightLeft();
                    void Merge2Nodes();
                    void ReplaceChild(System.Collections.Generic.SortedSet.Node<T> child, System.Collections.Generic.SortedSet.Node<T> newChild);
                }

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
                {
                    static /*0x0*/ System.Collections.Generic.SortedSet.Node<T> s_dummyNode;
                    /*0x0*/ System.Collections.Generic.SortedSet<T> _tree;
                    /*0x0*/ int _version;
                    /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack;
                    /*0x0*/ System.Collections.Generic.SortedSet.Node<T> _current;
                    /*0x0*/ bool _reverse;

                    static Enumerator();
                    Enumerator(System.Collections.Generic.SortedSet<T> set);
                    Enumerator(System.Collections.Generic.SortedSet<T> set, bool reverse);
                    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender);
                    void Initialize();
                    bool MoveNext();
                    void Dispose();
                    T get_Current();
                    object System.Collections.IEnumerator.get_Current();
                    bool get_NotStartedOrEnded();
                    void Reset();
                    void System.Collections.IEnumerator.Reset();
                }

                class <>c__DisplayClass52_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ int count;
                    /*0x0*/ T[] array;

                    <>c__DisplayClass52_0();
                    bool <CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }

                class <>c__DisplayClass53_0<T>
                {
                    /*0x0*/ int index;
                    /*0x0*/ object[] objects;

                    <>c__DisplayClass53_0();
                    bool <System.Collections.ICollection.CopyTo>b__0(System.Collections.Generic.SortedSet.Node<T> node);
                }
            }

            enum NodeColor
            {
                Black = 0,
                Red = 1,
            }

            class TreeWalkPredicate<T> : System.MulticastDelegate
            {
                TreeWalkPredicate(object object, nint method);
                bool Invoke(System.Collections.Generic.SortedSet.Node<T> node);
            }

            enum TreeRotation
            {
                Left = 0,
                LeftRight = 1,
                Right = 2,
                RightLeft = 3,
            }

            interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
            }
        }
    }

    namespace IO
    {
        namespace Compression
        {
            enum CompressionMode
            {
                Decompress = 0,
                Compress = 1,
            }

            class GZipStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Compression.DeflateStream _deflateStream;

                static /*0x249e654*/ void ThrowStreamClosedException();
                /*0x249daa0*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x249daa8*/ GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen);
                /*0x249db6c*/ bool get_CanRead();
                /*0x249db84*/ bool get_CanWrite();
                /*0x249db9c*/ bool get_CanSeek();
                /*0x249dbb4*/ long get_Length();
                /*0x249dc04*/ long get_Position();
                /*0x249dc54*/ void set_Position(long value);
                /*0x249dca4*/ void Flush();
                /*0x249dce0*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x249dd30*/ void SetLength(long value);
                /*0x249dd80*/ int ReadByte();
                /*0x249dda4*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x249de58*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x249dea0*/ int Read(byte[] array, int offset, int count);
                /*0x249dec4*/ int Read(System.Span<byte> buffer);
                /*0x249e0cc*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x249e180*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x249e18c*/ void Write(byte[] array, int offset, int count);
                /*0x249e1b0*/ void Write(System.ReadOnlySpan<byte> buffer);
                /*0x249e320*/ void CopyTo(System.IO.Stream destination, int bufferSize);
                /*0x249e344*/ void Dispose(bool disposing);
                /*0x249e3fc*/ System.Threading.Tasks.Task<int> ReadAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x249e420*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x249e504*/ System.Threading.Tasks.Task WriteAsync(byte[] array, int offset, int count, System.Threading.CancellationToken cancellationToken);
                /*0x249e528*/ System.Threading.Tasks.ValueTask WriteAsync(System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
                /*0x249e60c*/ System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken);
                /*0x249e630*/ System.Threading.Tasks.Task CopyToAsync(System.IO.Stream destination, int bufferSize, System.Threading.CancellationToken cancellationToken);
                /*0x249dcc8*/ void CheckDeflateStream();
            }

            class DeflateStream : System.IO.Stream
            {
                /*0x28*/ System.IO.Stream base_stream;
                /*0x30*/ System.IO.Compression.CompressionMode mode;
                /*0x34*/ bool leaveOpen;
                /*0x35*/ bool disposed;
                /*0x38*/ System.IO.Compression.DeflateStreamNative native;

                /*0x249e6a8*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode);
                /*0x249db60*/ DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen, int windowsBits);
                /*0x249e6b4*/ DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen, bool gzip);
                /*0x249e954*/ void Finalize();
                /*0x249e9f8*/ void Dispose(bool disposing);
                /*0x249ebb4*/ int ReadInternal(byte[] array, int offset, int count);
                /*0x249e4fc*/ System.Threading.Tasks.ValueTask<int> ReadAsyncMemory(System.Memory<byte> destination, System.Threading.CancellationToken cancellationToken);
                /*0x249dfb0*/ int ReadCore(System.Span<byte> destination);
                /*0x249ec74*/ int Read(byte[] array, int offset, int count);
                /*0x249ee60*/ void WriteInternal(byte[] array, int offset, int count);
                /*0x249e604*/ System.Threading.Tasks.ValueTask WriteAsyncMemory(System.ReadOnlyMemory<byte> source, System.Threading.CancellationToken cancellationToken);
                /*0x249e29c*/ void WriteCore(System.ReadOnlySpan<byte> source);
                /*0x249ef10*/ void Write(byte[] array, int offset, int count);
                /*0x249f108*/ void Flush();
                /*0x249f214*/ System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x249f614*/ System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                /*0x249fa14*/ int EndRead(System.IAsyncResult asyncResult);
                /*0x249fb80*/ void EndWrite(System.IAsyncResult asyncResult);
                /*0x249fcd4*/ long Seek(long offset, System.IO.SeekOrigin origin);
                /*0x249fd14*/ void SetLength(long value);
                /*0x249fd54*/ bool get_CanRead();
                /*0x249fd90*/ bool get_CanSeek();
                /*0x249fd98*/ bool get_CanWrite();
                /*0x249fdd8*/ long get_Length();
                /*0x249fe18*/ long get_Position();
                /*0x249fe58*/ void set_Position(long value);

                class ReadMethod : System.MulticastDelegate
                {
                    /*0x249f494*/ ReadMethod(object object, nint method);
                    /*0x249fe98*/ int Invoke(byte[] array, int offset, int count);
                    /*0x249f56c*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x249fb58*/ int EndInvoke(System.IAsyncResult result);
                }

                class WriteMethod : System.MulticastDelegate
                {
                    /*0x249f894*/ WriteMethod(object object, nint method);
                    /*0x249feac*/ void Invoke(byte[] array, int offset, int count);
                    /*0x249f96c*/ System.IAsyncResult BeginInvoke(byte[] array, int offset, int count, System.AsyncCallback callback, object object);
                    /*0x249fcc8*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DeflateStreamNative
            {
                /*0x10*/ System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder;
                /*0x18*/ System.IO.Stream base_stream;
                /*0x20*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle z_stream;
                /*0x28*/ System.Runtime.InteropServices.GCHandle data;
                /*0x30*/ bool disposed;
                /*0x38*/ byte[] io_buffer;
                /*0x40*/ System.Exception last_error;

                static /*0x249e820*/ System.IO.Compression.DeflateStreamNative Create(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool gzip);
                static /*0x249fec0*/ int UnmanagedRead(nint buffer, int length, nint data);
                static /*0x249ff7c*/ int UnmanagedWrite(nint buffer, int length, nint data);
                static /*0x24a0104*/ System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(System.IO.Compression.CompressionMode compress, bool gzip, System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite feeder, nint data);
                static /*0x24a0894*/ int CloseZStream(nint stream);
                static /*0x24a0234*/ int Flush(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream);
                static /*0x24a03cc*/ int ReadZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                static /*0x24a0448*/ int WriteZStream(System.IO.Compression.DeflateStreamNative.SafeDeflateStreamHandle stream, nint buffer, int length);
                /*0x24a0038*/ DeflateStreamNative();
                /*0x24a019c*/ void Finalize();
                /*0x249eab0*/ void Dispose(bool disposing);
                /*0x249f1c0*/ void Flush();
                /*0x249ebfc*/ int ReadZStream(nint buffer, int length);
                /*0x249eea4*/ void WriteZStream(nint buffer, int length);
                /*0x24a04c4*/ int UnmanagedRead(nint buffer, int length);
                /*0x24a0668*/ int UnmanagedWrite(nint buffer, int length);
                /*0x24a0298*/ void CheckResult(int result, string where);

                class UnmanagedReadOrWrite : System.MulticastDelegate
                {
                    /*0x24a0040*/ UnmanagedReadOrWrite(object object, nint method);
                    /*0x24a0898*/ int Invoke(nint buffer, int length, nint data);
                }

                class SafeDeflateStreamHandle : System.Runtime.InteropServices.SafeHandle
                {
                    /*0x24a083c*/ SafeDeflateStreamHandle();
                    /*0x24a08ac*/ bool get_IsInvalid();
                    /*0x24a0900*/ bool ReleaseHandle();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A;
    static /*0x100*/ <PrivateImplementationDetails> 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5;
    static /*0x120*/ <PrivateImplementationDetails> 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374;
    static /*0x140*/ long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B;
    static /*0x148*/ <PrivateImplementationDetails> 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811;
    static /*0x151*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;
    static /*0x178*/ long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C;
    static /*0x180*/ <PrivateImplementationDetails> 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF;
    static /*0x190*/ long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885;
    static /*0x198*/ <PrivateImplementationDetails> 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3;
    static /*0x218*/ <PrivateImplementationDetails> 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8;
    static /*0x244*/ <PrivateImplementationDetails> 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A;
    static /*0x24a*/ <PrivateImplementationDetails> B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C;
    static /*0x2d0*/ long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859;
    static /*0x2d8*/ <PrivateImplementationDetails> DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5;

    static /*0x249cecc*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=9
    {
    }

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=14
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=128
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }
}

namespace System
{
    namespace Configuration
    {
        interface IConfigurationSectionHandler
        {
        }
    }

    namespace Net
    {
        namespace Configuration
        {
            class BypassElement : System.Configuration.ConfigurationElement
            {
            }

            class BypassElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x24a0988*/ BypassElementCollection();
            }

            class ConnectionManagementElement : System.Configuration.ConfigurationElement
            {
            }

            class ConnectionManagementElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x24a09c0*/ ConnectionManagementElementCollection();
            }

            class ConnectionManagementSection : System.Configuration.ConfigurationSection
            {
                /*0x24a09f8*/ ConnectionManagementSection();
                /*0x24a0a30*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class DefaultProxySection : System.Configuration.ConfigurationSection
            {
                /*0x24a0a68*/ DefaultProxySection();
                /*0x24a0aa0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
                /*0x24a0ad8*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            }

            class ProxyElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0b10*/ ProxyElement();
                /*0x24a0b48*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class HttpWebRequestElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0b80*/ HttpWebRequestElement();
                /*0x24a0bb8*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class Ipv6Element : System.Configuration.ConfigurationElement
            {
                /*0x24a0bf0*/ Ipv6Element();
                /*0x24a0c28*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
            {
                /*0x24a0c60*/ NetSectionGroup();
            }

            class SettingsSection : System.Configuration.ConfigurationSection
            {
                /*0x24a0c98*/ SettingsSection();
                /*0x24a0cd0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class PerformanceCountersElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0d08*/ PerformanceCountersElement();
                /*0x24a0d40*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class ServicePointManagerElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0d78*/ ServicePointManagerElement();
                /*0x24a0db0*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class SocketElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0de8*/ SocketElement();
                /*0x24a0e20*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebProxyScriptElement : System.Configuration.ConfigurationElement
            {
                /*0x24a0e58*/ WebProxyScriptElement();
                /*0x24a0e90*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModulesSection : System.Configuration.ConfigurationSection
            {
                /*0x24a0ec8*/ WebRequestModulesSection();
                /*0x24a0f00*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            }

            class WebRequestModuleElementCollection : System.Configuration.ConfigurationElementCollection
            {
                /*0x24a0f38*/ WebRequestModuleElementCollection();
            }

            class WebRequestModuleElement : System.Configuration.ConfigurationElement
            {
            }
        }
    }

    namespace Diagnostics
    {
        class DiagnosticsConfigurationHandler : System.Configuration.IConfigurationSectionHandler
        {
            /*0x24a0f70*/ DiagnosticsConfigurationHandler();
            /*0x24a0fa8*/ object Create(object parent, object configContext, System.Xml.XmlNode section);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x24a0fe0*/ void ThrowNotSupportedException();
    }
}
