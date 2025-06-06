class <Module>
{
}

namespace UnityEngine
{
    class AndroidJNISafe
    {
        static /*0x27d57a8*/ void CheckException();
        static /*0x27d5d50*/ void DeleteGlobalRef(nint globalref);
        static /*0x27d5e18*/ void DeleteWeakGlobalRef(nint globalref);
        static /*0x27d5ee0*/ void DeleteLocalRef(nint localref);
        static /*0x27d5fa8*/ nint NewString(string chars);
        static /*0x27d6084*/ string GetStringChars(nint str);
        static /*0x27d6160*/ nint GetObjectClass(nint ptr);
        static /*0x27d623c*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x27d62f4*/ nint GetMethodID(nint obj, string name, string sig);
        static /*0x27d63ac*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x27d64b8*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x27d65c4*/ nint FromReflectedMethod(nint refMethod);
        static /*0x27d66a0*/ nint FindClass(string name);
        static /*0x27d6740*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d684c*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x27d695c*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x27d6a6c*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x27d6b7c*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x27d6c8c*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x27d6d9c*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x27d6eac*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x27d6fbc*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x27d70cc*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x27d71dc*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x27d72ec*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x27d73d8*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x27d74c4*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x27d75b0*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x27d76a8*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x27d77a0*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x27d788c*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x27d7978*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x27d7a64*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x27d7b50*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x27d7c3c*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7d4c*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7e58*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7f10*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d801c*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8134*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d824c*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8358*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8464*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8570*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d867c*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8788*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x27d8898*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x27d89a8*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x27d8ab8*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x27d8bc8*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x27d8cd8*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x27d8de8*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x27d8ef8*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x27d9008*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x27d9118*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x27d9228*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x27d9314*/ string GetStringField(nint obj, nint fieldID);
        static /*0x27d9400*/ char GetCharField(nint obj, nint fieldID);
        static /*0x27d94ec*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x27d95e4*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x27d96dc*/ long GetLongField(nint obj, nint fieldID);
        static /*0x27d97c8*/ short GetShortField(nint obj, nint fieldID);
        static /*0x27d98b4*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x27d99a0*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x27d9a8c*/ int GetIntField(nint obj, nint fieldID);
        static /*0x27d9b78*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9c88*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9d94*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9e4c*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9f58*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da070*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da188*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da294*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da3a0*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da4ac*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da5b8*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da6c4*/ char[] FromCharArray(nint array);
        static /*0x27da7a0*/ double[] FromDoubleArray(nint array);
        static /*0x27da87c*/ float[] FromFloatArray(nint array);
        static /*0x27da958*/ long[] FromLongArray(nint array);
        static /*0x27daa34*/ short[] FromShortArray(nint array);
        static /*0x27dab10*/ byte[] FromByteArray(nint array);
        static /*0x27dabec*/ sbyte[] FromSByteArray(nint array);
        static /*0x27dacc8*/ bool[] FromBooleanArray(nint array);
        static /*0x27dada4*/ int[] FromIntArray(nint array);
        static /*0x27dae80*/ nint ToObjectArray(nint[] array, nint type);
        static /*0x27daf6c*/ nint ToCharArray(char[] array);
        static /*0x27db048*/ nint ToDoubleArray(double[] array);
        static /*0x27db124*/ nint ToFloatArray(float[] array);
        static /*0x27db200*/ nint ToLongArray(long[] array);
        static /*0x27db2dc*/ nint ToShortArray(short[] array);
        static /*0x27db3b8*/ nint ToByteArray(byte[] array);
        static /*0x27db494*/ nint ToSByteArray(sbyte[] array);
        static /*0x27db570*/ nint ToBooleanArray(bool[] array);
        static /*0x27db64c*/ nint ToIntArray(int[] array);
        static /*0x27db728*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x27db814*/ int GetArrayLength(nint array);
    }

    class AndroidJavaRunnable : System.MulticastDelegate
    {
        /*0x27db8f0*/ AndroidJavaRunnable(object object, nint method);
        /*0x27db9ac*/ void Invoke();
    }

    class AndroidJavaException : System.Exception
    {
        /*0x90*/ string mJavaStackTrace;

        /*0x27d5cdc*/ AndroidJavaException(string message, string javaStackTrace);
        /*0x27db9c0*/ string get_StackTrace();
    }

    class GlobalJavaObjectRef
    {
        /*0x10*/ bool m_disposed;
        /*0x18*/ nint m_jobject;

        static /*0x27dbbe4*/ nint op_Implicit(UnityEngine.GlobalJavaObjectRef obj);
        /*0x27db9e4*/ GlobalJavaObjectRef(nint jobject);
        /*0x27dbad4*/ void Finalize();
        /*0x27dbb68*/ void Dispose();
    }

    class AndroidJavaRunnableProxy : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ UnityEngine.AndroidJavaRunnable mRunnable;

        /*0x27dbbfc*/ AndroidJavaRunnableProxy(UnityEngine.AndroidJavaRunnable runnable);
        /*0x27dbcf8*/ void run();
    }

    class AndroidJavaProxy
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_JavaLangSystemClass;
        static /*0x8*/ nint s_HashCodeMethodID;
        /*0x10*/ UnityEngine.AndroidJavaClass javaInterface;
        /*0x18*/ nint proxyObject;

        static /*0x27de124*/ AndroidJavaProxy();
        /*0x27dbc7c*/ AndroidJavaProxy(string javaInterface);
        /*0x27dbd48*/ AndroidJavaProxy(UnityEngine.AndroidJavaClass javaInterface);
        /*0x27dbdb4*/ void Finalize();
        /*0x27dbe4c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, object[] args);
        /*0x27dd11c*/ UnityEngine.AndroidJavaObject Invoke(string methodName, UnityEngine.AndroidJavaObject[] javaArgs);
        /*0x27ddbe4*/ bool equals(UnityEngine.AndroidJavaObject obj);
        /*0x27ddd3c*/ int hashCode();
        /*0x27dddec*/ string toString();
        /*0x27dde50*/ UnityEngine.AndroidJavaObject GetProxyObject();
        /*0x27dcecc*/ nint GetRawProxy();
    }

    class AndroidJavaObject : System.IDisposable
    {
        static /*0x0*/ bool enableDebugPrints;
        /*0x10*/ UnityEngine.GlobalJavaObjectRef m_jobject;
        /*0x18*/ UnityEngine.GlobalJavaObjectRef m_jclass;

        static /*0x27dde60*/ UnityEngine.AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject);
        static /*0x27df370*/ UnityEngine.AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass);
        static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(nint jobject);
        /*0x27de220*/ AndroidJavaObject(string className, string[] args);
        /*0x27de4d8*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaObject[] args);
        /*0x27de58c*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaClass[] args);
        /*0x27de640*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaProxy[] args);
        /*0x27de6f4*/ AndroidJavaObject(string className, UnityEngine.AndroidJavaRunnable[] args);
        /*0x27de7a8*/ AndroidJavaObject(string className, object[] args);
        /*0x27df144*/ AndroidJavaObject(nint jobject);
        /*0x27de2d4*/ AndroidJavaObject();
        /*0x27ddb78*/ void Dispose();
        void Call<T>(string methodName, T[] args);
        /*0x27de7dc*/ void Call(string methodName, object[] args);
        void CallStatic<T>(string methodName, T[] args);
        /*0x27de91c*/ void CallStatic(string methodName, object[] args);
        FieldType Get<FieldType>(string fieldName);
        void Set<FieldType>(string fieldName, FieldType val);
        FieldType GetStatic<FieldType>(string fieldName);
        void SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x27ddc9c*/ nint GetRawObject();
        /*0x27deab8*/ nint GetRawClass();
        /*0x27deaf0*/ UnityEngine.AndroidJavaObject CloneReference();
        ReturnType Call<ReturnType, T>(string methodName, T[] args);
        ReturnType Call<ReturnType>(string methodName, object[] args);
        ReturnType CallStatic<ReturnType, T>(string methodName, T[] args);
        ReturnType CallStatic<ReturnType>(string methodName, object[] args);
        /*0x27ded40*/ void DebugPrint(string msg);
        /*0x27dedc8*/ void DebugPrint(string call, string methodName, string signature, object[] args);
        /*0x27de2dc*/ void _AndroidJavaObject(string className, object[] args);
        /*0x27df268*/ void Finalize();
        /*0x27df308*/ void Dispose(bool disposing);
        /*0x27de7e0*/ void _Call(string methodName, object[] args);
        ReturnType _Call<ReturnType>(string methodName, object[] args);
        FieldType _Get<FieldType>(string fieldName);
        void _Set<FieldType>(string fieldName, FieldType val);
        /*0x27de920*/ void _CallStatic(string methodName, object[] args);
        ReturnType _CallStatic<ReturnType>(string methodName, object[] args);
        FieldType _GetStatic<FieldType>(string fieldName);
        void _SetStatic<FieldType>(string fieldName, FieldType val);
        /*0x27dea5c*/ nint _GetRawObject();
        /*0x27dead4*/ nint _GetRawClass();
    }

    class AndroidJavaClass : UnityEngine.AndroidJavaObject
    {
        /*0x27dbd1c*/ AndroidJavaClass(string className);
        /*0x27dec4c*/ AndroidJavaClass(nint jclass);
        /*0x27df438*/ void _AndroidJavaClass(string className);
    }

    class AndroidReflection
    {
        static /*0x0*/ UnityEngine.GlobalJavaObjectRef s_ReflectionHelperClass;
        static /*0x8*/ nint s_ReflectionHelperGetConstructorID;
        static /*0x10*/ nint s_ReflectionHelperGetMethodID;
        static /*0x18*/ nint s_ReflectionHelperGetFieldID;
        static /*0x20*/ nint s_ReflectionHelperGetFieldSignature;
        static /*0x28*/ nint s_ReflectionHelperNewProxyInstance;
        static /*0x30*/ nint s_ReflectionHelperSetNativeExceptionOnProxy;
        static /*0x38*/ nint s_FieldGetDeclaringClass;

        static /*0x27dfde0*/ AndroidReflection();
        static /*0x27df4f8*/ bool IsPrimitive(System.Type t);
        static /*0x27df50c*/ bool IsAssignableFrom(System.Type t, System.Type from);
        static /*0x27df52c*/ nint GetStaticMethodID(string clazz, string methodName, string signature);
        static /*0x27df5c8*/ nint GetMethodID(string clazz, string methodName, string signature);
        static /*0x27df664*/ nint GetConstructorMember(nint jclass, string signature);
        static /*0x27df7f0*/ nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x27df9f0*/ nint GetFieldMember(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x27dfbf0*/ nint GetFieldClass(nint field);
        static /*0x27dfc54*/ string GetFieldSignature(nint field);
        static /*0x27dfcfc*/ nint NewProxyInstance(nint player, nint delegateHandle, nint interfaze);
        static /*0x27dd010*/ void SetNativeExceptionOnProxy(nint proxy, System.Exception e, bool methodNotFound);
    }

    class _AndroidJNIHelper
    {
        static /*0x27e008c*/ nint CreateJavaProxy(nint player, nint delegateHandle, UnityEngine.AndroidJavaProxy proxy);
        static /*0x27e0114*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x27e0174*/ nint InvokeJavaProxyMethod(UnityEngine.AndroidJavaProxy proxy, nint jmethodName, nint jargs);
        static /*0x27e060c*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x27e15d0*/ object UnboxArray(UnityEngine.AndroidJavaObject obj);
        static /*0x27dd280*/ object Unbox(UnityEngine.AndroidJavaObject obj);
        static /*0x27dc574*/ UnityEngine.AndroidJavaObject Box(object obj);
        static /*0x27e1c68*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x27e0c18*/ nint ConvertToJNIArray(System.Array array);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static /*0x27e1e70*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x27e1f88*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<ReturnType>(nint jclass, string fieldName, bool isStatic);
        static /*0x27e1fc0*/ nint GetConstructorID(nint jclass, string signature);
        static /*0x27e21c0*/ nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x27e23d0*/ nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic);
        static /*0x27e24cc*/ nint GetFieldID(nint jclass, string fieldName, string signature, bool isStatic);
        static /*0x27e2820*/ string GetSignature(object obj);
        static /*0x27e1e90*/ string GetSignature(object[] args);
        static string GetSignature<ReturnType>(object[] args);
        /*0x27e3694*/ _AndroidJNIHelper();
    }

    struct jvalue
    {
        /*0x10*/ bool z;
        /*0x10*/ sbyte b;
        /*0x10*/ char c;
        /*0x10*/ short s;
        /*0x10*/ int i;
        /*0x10*/ long j;
        /*0x10*/ float f;
        /*0x10*/ double d;
        /*0x10*/ nint l;
    }

    class AndroidJNIHelper
    {
        static /*0x27e369c*/ bool get_debug();
        static /*0x27e36c4*/ void set_debug(bool value);
        static /*0x27e3700*/ nint GetConstructorID(nint javaClass);
        static /*0x27e1f84*/ nint GetConstructorID(nint javaClass, string signature);
        static /*0x27e3748*/ nint GetMethodID(nint javaClass, string methodName);
        static /*0x27e37a4*/ nint GetMethodID(nint javaClass, string methodName, string signature);
        static /*0x27de218*/ nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic);
        static /*0x27e37ac*/ nint GetFieldID(nint javaClass, string fieldName);
        static /*0x27e3810*/ nint GetFieldID(nint javaClass, string fieldName, string signature);
        static /*0x27e3808*/ nint GetFieldID(nint javaClass, string fieldName, string signature, bool isStatic);
        static /*0x27e15cc*/ nint CreateJavaRunnable(UnityEngine.AndroidJavaRunnable jrunnable);
        static /*0x27ddf64*/ nint CreateJavaProxy(UnityEngine.AndroidJavaProxy proxy);
        static /*0x27e3a30*/ nint ConvertToJNIArray(System.Array array);
        static /*0x27df120*/ UnityEngine.jvalue[] CreateJNIArgArray(object[] args);
        static /*0x27e3a34*/ void DeleteJNIArgArray(object[] args, UnityEngine.jvalue[] jniArgs);
        static /*0x27df124*/ nint GetConstructorID(nint jclass, object[] args);
        static /*0x27df338*/ nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic);
        static /*0x27e3a38*/ string GetSignature(object obj);
        static /*0x27e3a3c*/ string GetSignature(object[] args);
        static ArrayType ConvertFromJNIArray<ArrayType>(nint array);
        static nint GetMethodID<ReturnType>(nint jclass, string methodName, object[] args, bool isStatic);
        static nint GetFieldID<FieldType>(nint jclass, string fieldName, bool isStatic);
        static string GetSignature<ReturnType>(object[] args);
    }

    class AndroidJNI
    {
        static /*0x27e3a40*/ int AttachCurrentThread();
        static /*0x27e3a68*/ int DetachCurrentThread();
        static /*0x27e3a90*/ int GetVersion();
        static /*0x27d5b50*/ nint FindClass(string name);
        static /*0x27d6664*/ nint FromReflectedMethod(nint refMethod);
        static /*0x27e3ab8*/ nint FromReflectedField(nint refField);
        static /*0x27e3af4*/ nint ToReflectedMethod(nint clazz, nint methodID, bool isStatic);
        static /*0x27e3b48*/ nint ToReflectedField(nint clazz, nint fieldID, bool isStatic);
        static /*0x27e3b9c*/ nint GetSuperclass(nint clazz);
        static /*0x27e3bd8*/ bool IsAssignableFrom(nint clazz1, nint clazz2);
        static /*0x27e3c1c*/ int Throw(nint obj);
        static /*0x27e3c58*/ int ThrowNew(nint clazz, string message);
        static /*0x27d5b00*/ nint ExceptionOccurred();
        static /*0x27e3c9c*/ void ExceptionDescribe();
        static /*0x27d5b28*/ void ExceptionClear();
        static /*0x27e3cc4*/ void FatalError(string message);
        static /*0x27e27e4*/ int PushLocalFrame(int capacity);
        static /*0x27e3d00*/ nint PopLocalFrame(nint ptr);
        static /*0x27dba98*/ nint NewGlobalRef(nint obj);
        static /*0x27d5ddc*/ void DeleteGlobalRef(nint obj);
        static /*0x27de0e8*/ nint NewWeakGlobalRef(nint obj);
        static /*0x27d5ea4*/ void DeleteWeakGlobalRef(nint obj);
        static /*0x27ddf28*/ nint NewLocalRef(nint obj);
        static /*0x27d5f6c*/ void DeleteLocalRef(nint obj);
        static /*0x27ddcf8*/ bool IsSameObject(nint obj1, nint obj2);
        static /*0x27e3d3c*/ int EnsureLocalCapacity(int capacity);
        static /*0x27e3d78*/ nint AllocObject(nint clazz);
        static /*0x27d67f8*/ nint NewObject(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d6200*/ nint GetObjectClass(nint obj);
        static /*0x27e3db4*/ bool IsInstanceOf(nint obj, nint clazz);
        static /*0x27d5b8c*/ nint GetMethodID(nint clazz, string name, string sig);
        static /*0x27d6464*/ nint GetFieldID(nint clazz, string name, string sig);
        static /*0x27d5be0*/ nint GetStaticMethodID(nint clazz, string name, string sig);
        static /*0x27d6570*/ nint GetStaticFieldID(nint clazz, string name, string sig);
        static /*0x27d6048*/ nint NewString(string chars);
        static /*0x27e3df8*/ nint NewStringFromStr(string chars);
        static /*0x27e3e34*/ nint NewString(char[] chars);
        static /*0x27e3e70*/ nint NewStringUTF(string bytes);
        static /*0x27d6124*/ string GetStringChars(nint str);
        static /*0x27e3eac*/ int GetStringLength(nint str);
        static /*0x27e3ee8*/ int GetStringUTFLength(nint str);
        static /*0x27e3f24*/ string GetStringUTFChars(nint str);
        static /*0x27d5c34*/ string CallStringMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9d40*/ nint CallObjectMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da670*/ int CallIntMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da564*/ bool CallBooleanMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da34c*/ short CallShortMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27e3f60*/ byte CallByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da458*/ sbyte CallSByteMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9f04*/ char CallCharMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da134*/ float CallFloatMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da01c*/ double CallDoubleMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27da240*/ long CallLongMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d9c34*/ void CallVoidMethod(nint obj, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d93bc*/ string GetStringField(nint obj, nint fieldID);
        static /*0x27d92d0*/ nint GetObjectField(nint obj, nint fieldID);
        static /*0x27d9a48*/ bool GetBooleanField(nint obj, nint fieldID);
        static /*0x27e3fb4*/ byte GetByteField(nint obj, nint fieldID);
        static /*0x27d995c*/ sbyte GetSByteField(nint obj, nint fieldID);
        static /*0x27d94a8*/ char GetCharField(nint obj, nint fieldID);
        static /*0x27d9870*/ short GetShortField(nint obj, nint fieldID);
        static /*0x27d9b34*/ int GetIntField(nint obj, nint fieldID);
        static /*0x27d9784*/ long GetLongField(nint obj, nint fieldID);
        static /*0x27d9698*/ float GetFloatField(nint obj, nint fieldID);
        static /*0x27d95a0*/ double GetDoubleField(nint obj, nint fieldID);
        static /*0x27d8954*/ void SetStringField(nint obj, nint fieldID, string val);
        static /*0x27d8844*/ void SetObjectField(nint obj, nint fieldID, nint val);
        static /*0x27d90c4*/ void SetBooleanField(nint obj, nint fieldID, bool val);
        static /*0x27e3ff8*/ void SetByteField(nint obj, nint fieldID, byte val);
        static /*0x27d8fb4*/ void SetSByteField(nint obj, nint fieldID, sbyte val);
        static /*0x27d8a64*/ void SetCharField(nint obj, nint fieldID, char val);
        static /*0x27d8ea4*/ void SetShortField(nint obj, nint fieldID, short val);
        static /*0x27d91d4*/ void SetIntField(nint obj, nint fieldID, int val);
        static /*0x27d8d94*/ void SetLongField(nint obj, nint fieldID, long val);
        static /*0x27d8c84*/ void SetFloatField(nint obj, nint fieldID, float val);
        static /*0x27d8b74*/ void SetDoubleField(nint obj, nint fieldID, double val);
        static /*0x27d5c88*/ string CallStaticStringMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7e04*/ nint CallStaticObjectMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8734*/ int CallStaticIntMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8628*/ bool CallStaticBooleanMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8410*/ short CallStaticShortMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27e404c*/ byte CallStaticByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d851c*/ sbyte CallStaticSByteMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7fc8*/ char CallStaticCharMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d81f8*/ float CallStaticFloatMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d80e0*/ double CallStaticDoubleMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d8304*/ long CallStaticLongMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7cf8*/ void CallStaticVoidMethod(nint clazz, nint methodID, UnityEngine.jvalue[] args);
        static /*0x27d7480*/ string GetStaticStringField(nint clazz, nint fieldID);
        static /*0x27d7394*/ nint GetStaticObjectField(nint clazz, nint fieldID);
        static /*0x27d7b0c*/ bool GetStaticBooleanField(nint clazz, nint fieldID);
        static /*0x27e40a0*/ byte GetStaticByteField(nint clazz, nint fieldID);
        static /*0x27d7a20*/ sbyte GetStaticSByteField(nint clazz, nint fieldID);
        static /*0x27d756c*/ char GetStaticCharField(nint clazz, nint fieldID);
        static /*0x27d7934*/ short GetStaticShortField(nint clazz, nint fieldID);
        static /*0x27d7bf8*/ int GetStaticIntField(nint clazz, nint fieldID);
        static /*0x27d7848*/ long GetStaticLongField(nint clazz, nint fieldID);
        static /*0x27d775c*/ float GetStaticFloatField(nint clazz, nint fieldID);
        static /*0x27d7664*/ double GetStaticDoubleField(nint clazz, nint fieldID);
        static /*0x27d6a18*/ void SetStaticStringField(nint clazz, nint fieldID, string val);
        static /*0x27d6908*/ void SetStaticObjectField(nint clazz, nint fieldID, nint val);
        static /*0x27d7188*/ void SetStaticBooleanField(nint clazz, nint fieldID, bool val);
        static /*0x27e40e4*/ void SetStaticByteField(nint clazz, nint fieldID, byte val);
        static /*0x27d7078*/ void SetStaticSByteField(nint clazz, nint fieldID, sbyte val);
        static /*0x27d6b28*/ void SetStaticCharField(nint clazz, nint fieldID, char val);
        static /*0x27d6f68*/ void SetStaticShortField(nint clazz, nint fieldID, short val);
        static /*0x27d7298*/ void SetStaticIntField(nint clazz, nint fieldID, int val);
        static /*0x27d6e58*/ void SetStaticLongField(nint clazz, nint fieldID, long val);
        static /*0x27d6d48*/ void SetStaticFloatField(nint clazz, nint fieldID, float val);
        static /*0x27d6c38*/ void SetStaticDoubleField(nint clazz, nint fieldID, double val);
        static /*0x27db610*/ nint ToBooleanArray(bool[] array);
        static /*0x27db458*/ nint ToByteArray(byte[] array);
        static /*0x27db534*/ nint ToSByteArray(sbyte[] array);
        static /*0x27db00c*/ nint ToCharArray(char[] array);
        static /*0x27db37c*/ nint ToShortArray(short[] array);
        static /*0x27db6ec*/ nint ToIntArray(int[] array);
        static /*0x27db2a0*/ nint ToLongArray(long[] array);
        static /*0x27db1c4*/ nint ToFloatArray(float[] array);
        static /*0x27db0e8*/ nint ToDoubleArray(double[] array);
        static /*0x27daf28*/ nint ToObjectArray(nint[] array, nint arrayClass);
        static /*0x27e4138*/ nint ToObjectArray(nint[] array);
        static /*0x27dad68*/ bool[] FromBooleanArray(nint array);
        static /*0x27dabb0*/ byte[] FromByteArray(nint array);
        static /*0x27dac8c*/ sbyte[] FromSByteArray(nint array);
        static /*0x27da764*/ char[] FromCharArray(nint array);
        static /*0x27daad4*/ short[] FromShortArray(nint array);
        static /*0x27dae44*/ int[] FromIntArray(nint array);
        static /*0x27da9f8*/ long[] FromLongArray(nint array);
        static /*0x27da91c*/ float[] FromFloatArray(nint array);
        static /*0x27da840*/ double[] FromDoubleArray(nint array);
        static /*0x27e41ac*/ nint[] FromObjectArray(nint array);
        static /*0x27db8b4*/ int GetArrayLength(nint array);
        static /*0x27e41e8*/ nint NewBooleanArray(int size);
        static /*0x27e4224*/ nint NewByteArray(int size);
        static /*0x27e4260*/ nint NewSByteArray(int size);
        static /*0x27e429c*/ nint NewCharArray(int size);
        static /*0x27e42d8*/ nint NewShortArray(int size);
        static /*0x27e4314*/ nint NewIntArray(int size);
        static /*0x27e4350*/ nint NewLongArray(int size);
        static /*0x27e438c*/ nint NewFloatArray(int size);
        static /*0x27e43c8*/ nint NewDoubleArray(int size);
        static /*0x27e1dc8*/ nint NewObjectArray(int size, nint clazz, nint obj);
        static /*0x27e4404*/ bool GetBooleanArrayElement(nint array, int index);
        static /*0x27e4448*/ byte GetByteArrayElement(nint array, int index);
        static /*0x27e448c*/ sbyte GetSByteArrayElement(nint array, int index);
        static /*0x27e44d0*/ char GetCharArrayElement(nint array, int index);
        static /*0x27e4514*/ short GetShortArrayElement(nint array, int index);
        static /*0x27e4558*/ int GetIntArrayElement(nint array, int index);
        static /*0x27e459c*/ long GetLongArrayElement(nint array, int index);
        static /*0x27e45e0*/ float GetFloatArrayElement(nint array, int index);
        static /*0x27e4624*/ double GetDoubleArrayElement(nint array, int index);
        static /*0x27db7d0*/ nint GetObjectArrayElement(nint array, int index);
        static /*0x27e4668*/ void SetBooleanArrayElement(nint array, int index, byte val);
        static /*0x27e46c0*/ void SetBooleanArrayElement(nint array, int index, bool val);
        static /*0x27e4714*/ void SetByteArrayElement(nint array, int index, sbyte val);
        static /*0x27e4768*/ void SetSByteArrayElement(nint array, int index, sbyte val);
        static /*0x27e47bc*/ void SetCharArrayElement(nint array, int index, char val);
        static /*0x27e4810*/ void SetShortArrayElement(nint array, int index, short val);
        static /*0x27e4864*/ void SetIntArrayElement(nint array, int index, int val);
        static /*0x27e48b8*/ void SetLongArrayElement(nint array, int index, long val);
        static /*0x27e490c*/ void SetFloatArrayElement(nint array, int index, float val);
        static /*0x27e4960*/ void SetDoubleArrayElement(nint array, int index, double val);
        static /*0x27e1e1c*/ void SetObjectArrayElement(nint array, int index, nint obj);
    }

    namespace Android
    {
        enum AndroidAssetPackStatus
        {
            Unknown = 0,
            Pending = 1,
            Downloading = 2,
            Transferring = 3,
            Completed = 4,
            Failed = 5,
            Canceled = 6,
            WaitingForWifi = 7,
            NotInstalled = 8,
        }

        enum AndroidAssetPackError
        {
            NoError = 0,
            AppUnavailable = -1,
            PackUnavailable = -2,
            InvalidRequest = -3,
            DownloadNotFound = -4,
            ApiNotAvailable = -5,
            NetworkError = -6,
            AccessDenied = -7,
            InsufficientStorage = -10,
            PlayStoreNotFound = -11,
            NetworkUnrestricted = -12,
            AppNotOwned = -13,
            InternalError = -100,
        }

        class AndroidAssetPackInfo
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x20*/ ulong <size>k__BackingField;
            /*0x28*/ ulong <bytesDownloaded>k__BackingField;
            /*0x30*/ float <transferProgress>k__BackingField;
            /*0x34*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x27e49b4*/ AndroidAssetPackInfo(string name, UnityEngine.Android.AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackState
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ UnityEngine.Android.AndroidAssetPackStatus <status>k__BackingField;
            /*0x1c*/ UnityEngine.Android.AndroidAssetPackError <error>k__BackingField;

            /*0x27e4a18*/ AndroidAssetPackState(string name, UnityEngine.Android.AndroidAssetPackStatus status, UnityEngine.Android.AndroidAssetPackError error);
        }

        class AndroidAssetPackUseMobileDataRequestResult
        {
            /*0x10*/ bool <allowed>k__BackingField;

            /*0x27e4a54*/ AndroidAssetPackUseMobileDataRequestResult(bool allowed);
        }

        class AndroidAssetPacks
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject s_JavaPlayAssetDeliveryWrapper;
            static /*0x8*/ bool s_ApiMissing;

            static /*0x27e4a7c*/ UnityEngine.AndroidJavaObject GetAssetPackManager();

            class AssetPackManagerDownloadStatusCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackInfo> m_Callback;
                /*0x28*/ string[] m_AssetPacks;

                /*0x27e4d94*/ AssetPackManagerDownloadStatusCallback(System.Action<UnityEngine.Android.AndroidAssetPackInfo> callback, string[] assetPacks);
                /*0x27e4e18*/ void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode);
            }

            class AssetPackManagerMobileDataConfirmationCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> m_Callback;

                /*0x27e4f2c*/ AssetPackManagerMobileDataConfirmationCallback(System.Action<UnityEngine.Android.AndroidAssetPackUseMobileDataRequestResult> callback);
                /*0x27e4fac*/ void onMobileDataConfirmationResult(bool allowed);
            }

            class AssetPackManagerStatusQueryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> m_Callback;
                /*0x28*/ System.Collections.Generic.List<string> m_AssetPackNames;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Android.AndroidAssetPackState> m_States;
                /*0x38*/ long m_Size;

                /*0x27e5038*/ AssetPackManagerStatusQueryCallback(System.Action<ulong, UnityEngine.Android.AndroidAssetPackState[]> callback, string[] assetPacks);
                /*0x27e5130*/ void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes);
            }
        }

        class PermissionCallbacks : UnityEngine.AndroidJavaProxy
        {
            /*0x20*/ System.Action<string> PermissionGranted;
            /*0x28*/ System.Action<string> PermissionDenied;
            /*0x30*/ System.Action<string> PermissionDeniedAndDontAskAgain;

            /*0x27e58cc*/ PermissionCallbacks();
            /*0x27e54ac*/ void add_PermissionGranted(System.Action<string> value);
            /*0x27e555c*/ void remove_PermissionGranted(System.Action<string> value);
            /*0x27e560c*/ void add_PermissionDenied(System.Action<string> value);
            /*0x27e56bc*/ void remove_PermissionDenied(System.Action<string> value);
            /*0x27e576c*/ void add_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x27e581c*/ void remove_PermissionDeniedAndDontAskAgain(System.Action<string> value);
            /*0x27e5938*/ void onPermissionGranted(string permissionName);
            /*0x27e5954*/ void onPermissionDenied(string permissionName);
            /*0x27e5970*/ void onPermissionDeniedAndDontAskAgain(string permissionName);
        }

        struct Permission
        {
            static /*0x0*/ UnityEngine.AndroidJavaObject m_Activity;

            static /*0x27e3818*/ UnityEngine.AndroidJavaObject GetActivity();
        }
    }
}
