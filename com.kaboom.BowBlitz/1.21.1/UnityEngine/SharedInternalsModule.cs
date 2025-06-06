class <Module>
{
}

namespace UnityEngine
{
    class AssetFileNameExtensionAttribute : System.Attribute
    {
        /*0x10*/ string <preferredExtension>k__BackingField;
        /*0x18*/ System.Collections.Generic.IEnumerable<string> <otherExtensions>k__BackingField;

        /*0x2939fec*/ AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions);
    }

    class ThreadAndSerializationSafeAttribute : System.Attribute
    {
        /*0x293a018*/ ThreadAndSerializationSafeAttribute();
    }

    class WritableAttribute : System.Attribute
    {
        /*0x293a020*/ WritableAttribute();
    }

    class RejectDragAndDropMaterial : System.Attribute
    {
        /*0x293a028*/ RejectDragAndDropMaterial();
    }

    class UnityEngineModuleAssembly : System.Attribute
    {
        /*0x293a030*/ UnityEngineModuleAssembly();
    }

    class NativeClassAttribute : System.Attribute
    {
        /*0x10*/ string <QualifiedNativeName>k__BackingField;
        /*0x18*/ string <Declaration>k__BackingField;

        /*0x293a048*/ NativeClassAttribute(string qualifiedCppName);
        /*0x293a0b8*/ NativeClassAttribute(string qualifiedCppName, string declaration);
        /*0x293a038*/ void set_QualifiedNativeName(string value);
        /*0x293a040*/ void set_Declaration(string value);
    }

    class UnityString
    {
        static /*0x293a0e4*/ string Format(string fmt, object[] args);
    }

    namespace Scripting
    {
        class UsedByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x293a16c*/ UsedByNativeCodeAttribute();
            /*0x293a174*/ UsedByNativeCodeAttribute(string name);
            /*0x293a19c*/ void set_Name(string value);
        }

        class RequiredByNativeCodeAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <Optional>k__BackingField;
            /*0x19*/ bool <GenerateProxy>k__BackingField;

            /*0x293a1a4*/ RequiredByNativeCodeAttribute();
            /*0x293a1ac*/ RequiredByNativeCodeAttribute(string name);
            /*0x293a1d4*/ void set_Name(string value);
            /*0x293a1dc*/ void set_Optional(bool value);
            /*0x293a1e8*/ void set_GenerateProxy(bool value);
        }
    }

    namespace Bindings
    {
        class VisibleToOtherModulesAttribute : System.Attribute
        {
            /*0x293a1f4*/ VisibleToOtherModulesAttribute();
            /*0x293a1fc*/ VisibleToOtherModulesAttribute(string[] modules);
        }

        class NativeConditionalAttribute : System.Attribute
        {
            /*0x10*/ string <Condition>k__BackingField;
            /*0x18*/ string <StubReturnStatement>k__BackingField;
            /*0x20*/ bool <Enabled>k__BackingField;

            /*0x293a220*/ NativeConditionalAttribute(string condition);
            /*0x293a250*/ NativeConditionalAttribute(string condition, string stubReturnStatement);
            /*0x293a204*/ void set_Condition(string value);
            /*0x293a20c*/ void set_StubReturnStatement(string value);
            /*0x293a214*/ void set_Enabled(bool value);
        }

        class NativeHeaderAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;

            /*0x293a28c*/ NativeHeaderAttribute();
            /*0x293a294*/ NativeHeaderAttribute(string header);
            /*0x293a284*/ void set_Header(string value);
        }

        class NativeNameAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;

            /*0x293a3a0*/ NativeNameAttribute(string name);
            /*0x293a398*/ void set_Name(string value);
        }

        class NativeWritableSelfAttribute : System.Attribute
        {
            /*0x10*/ bool <WritableSelf>k__BackingField;

            /*0x293a4b0*/ NativeWritableSelfAttribute();
            /*0x293a4a4*/ void set_WritableSelf(bool value);
        }

        class NativeMethodAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ bool <IsThreadSafe>k__BackingField;
            /*0x19*/ bool <IsFreeFunction>k__BackingField;
            /*0x1a*/ bool <ThrowsException>k__BackingField;
            /*0x1b*/ bool <HasExplicitThis>k__BackingField;

            /*0x293a508*/ NativeMethodAttribute();
            /*0x293a510*/ NativeMethodAttribute(string name);
            /*0x293a614*/ NativeMethodAttribute(string name, bool isFreeFunction);
            /*0x293a63c*/ NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe);
            /*0x293a4d0*/ void set_Name(string value);
            /*0x293a4d8*/ void set_IsThreadSafe(bool value);
            /*0x293a4e4*/ void set_IsFreeFunction(bool value);
            /*0x293a4f0*/ void set_ThrowsException(bool value);
            /*0x293a4fc*/ void set_HasExplicitThis(bool value);
        }

        enum TargetType
        {
            Function = 0,
            Field = 1,
        }

        class NativePropertyAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x1c*/ UnityEngine.Bindings.TargetType <TargetType>k__BackingField;

            /*0x293a678*/ NativePropertyAttribute();
            /*0x293a680*/ NativePropertyAttribute(string name);
            /*0x293a684*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType);
            /*0x293a6b4*/ NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe);
            /*0x293a670*/ void set_TargetType(UnityEngine.Bindings.TargetType value);
        }

        enum CodegenOptions
        {
            Auto = 0,
            Custom = 1,
            Force = 2,
        }

        class NativeAsStructAttribute : System.Attribute
        {
            /*0x293a6f8*/ NativeAsStructAttribute();
        }

        class NativeTypeAttribute : System.Attribute
        {
            /*0x10*/ string <Header>k__BackingField;
            /*0x18*/ string <IntermediateScriptingStructName>k__BackingField;
            /*0x20*/ UnityEngine.Bindings.CodegenOptions <CodegenOptions>k__BackingField;

            /*0x293a718*/ NativeTypeAttribute();
            /*0x293a734*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions);
            /*0x293a75c*/ NativeTypeAttribute(string header);
            /*0x293a864*/ NativeTypeAttribute(UnityEngine.Bindings.CodegenOptions codegenOptions, string intermediateStructName);
            /*0x293a700*/ void set_Header(string value);
            /*0x293a708*/ void set_IntermediateScriptingStructName(string value);
            /*0x293a710*/ void set_CodegenOptions(UnityEngine.Bindings.CodegenOptions value);
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x10*/ string <Exception>k__BackingField;

            /*0x293a89c*/ NotNullAttribute(string exception);
            /*0x293a894*/ void set_Exception(string value);
        }

        class UnmarshalledAttribute : System.Attribute
        {
            /*0x293a8c4*/ UnmarshalledAttribute();
        }

        class FreeFunctionAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x293a8cc*/ FreeFunctionAttribute();
            /*0x293a8ec*/ FreeFunctionAttribute(string name);
            /*0x293a908*/ FreeFunctionAttribute(string name, bool isThreadSafe);
        }

        class ThreadSafeAttribute : UnityEngine.Bindings.NativeMethodAttribute
        {
            /*0x293a938*/ ThreadSafeAttribute();
        }

        enum StaticAccessorType
        {
            Dot = 0,
            Arrow = 1,
            DoubleColon = 2,
            ArrowWithDefaultReturnIfNull = 3,
        }

        class StaticAccessorAttribute : System.Attribute
        {
            /*0x10*/ string <Name>k__BackingField;
            /*0x18*/ UnityEngine.Bindings.StaticAccessorType <Type>k__BackingField;

            /*0x293a968*/ StaticAccessorAttribute(string name);
            /*0x293a990*/ StaticAccessorAttribute(string name, UnityEngine.Bindings.StaticAccessorType type);
            /*0x293a958*/ void set_Name(string value);
            /*0x293a960*/ void set_Type(UnityEngine.Bindings.StaticAccessorType value);
        }

        class NativeThrowsAttribute : System.Attribute
        {
            /*0x10*/ bool <ThrowsException>k__BackingField;

            /*0x293a9cc*/ NativeThrowsAttribute();
            /*0x293a9c0*/ void set_ThrowsException(bool value);
        }

        class IgnoreAttribute : System.Attribute
        {
            /*0x10*/ bool <DoesNotContributeToSize>k__BackingField;

            /*0x293a9f8*/ IgnoreAttribute();
            /*0x293a9ec*/ void set_DoesNotContributeToSize(bool value);
        }

        class PreventReadOnlyInstanceModificationAttribute : System.Attribute
        {
            /*0x293aa00*/ PreventReadOnlyInstanceModificationAttribute();
        }
    }
}
