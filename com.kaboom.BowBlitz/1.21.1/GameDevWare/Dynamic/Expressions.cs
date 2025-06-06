class <Module>
{
}

namespace System
{
    namespace Linq
    {
        namespace Expressions
        {
            class ExpressionExtensions
            {
                static System.Func<TResult> CompileAot<TResult>(System.Linq.Expressions.Expression<System.Func<TResult>> expression, bool forceAot);
                static System.Func<TArg1, TResult> CompileAot<TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg1, TResult>> expression, bool forceAot);
                static System.Func<TArg1, TArg2, TResult> CompileAot<TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg1, TArg2, TResult>> expression, bool forceAot);
                static System.Func<TArg1, TArg2, TArg3, TResult> CompileAot<TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg1, TArg2, TArg3, TResult>> expression, bool forceAot);
                static System.Func<TArg1, TArg2, TArg3, TArg4, TResult> CompileAot<TArg1, TArg2, TArg3, TArg4, TResult>(System.Linq.Expressions.Expression<System.Func<TArg1, TArg2, TArg3, TArg4, TResult>> expression, bool forceAot);
                static /*0xe45bd8*/ System.Action CompileAot(System.Linq.Expressions.Expression<System.Action> expression, bool forceAot);
                static System.Action<TArg1> CompileAot<TArg1>(System.Linq.Expressions.Expression<System.Action<TArg1>> expression, bool forceAot);
                static System.Action<TArg1, TArg2> CompileAot<TArg1, TArg2>(System.Linq.Expressions.Expression<System.Action<TArg1, TArg2>> expression, bool forceAot);
                static System.Action<TArg1, TArg2, TArg3> CompileAot<TArg1, TArg2, TArg3>(System.Linq.Expressions.Expression<System.Action<TArg1, TArg2, TArg3>> expression, bool forceAot);
                static System.Action<TArg1, TArg2, TArg3, TArg4> CompileAot<TArg1, TArg2, TArg3, TArg4>(System.Linq.Expressions.Expression<System.Action<TArg1, TArg2, TArg3, TArg4>> expression, bool forceAot);
            }
        }
    }
}

namespace GameDevWare
{
    namespace Dynamic
    {
        namespace Expressions
        {
            class AotCompilation
            {
                static /*0x0*/ bool IsAotRuntime;

                static /*0xe46140*/ AotCompilation();
                static /*0xe46144*/ void StaticConstructor();
                static void RegisterForFastCall<InstanceT, Arg1T, Arg2T, Arg3T, ResultT>();
                static void RegisterForFastCall<InstanceT, Arg1T, Arg2T, ResultT>();
                static void RegisterForFastCall<InstanceT, Arg1T, ResultT>();
                static void RegisterForFastCall<InstanceT, ResultT>();
                static void RegisterFunc<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>();
                static void RegisterFunc<Arg1T, Arg2T, Arg3T, ResultT>();
                static void RegisterFunc<Arg1T, Arg2T, ResultT>();
                static void RegisterFunc<Arg1T, ResultT>();
                static void RegisterFunc<ResultT>();
                static void RegisterAction<Arg1T, Arg2T, Arg3T, Arg4T>();
                static void RegisterAction<Arg1T, Arg2T, Arg3T>();
                static void RegisterAction<Arg1T, Arg2T>();
                static void RegisterAction<Arg1T>();
                static /*0xe45cc0*/ void RegisterAction();
            }

            class ArgumentsTree : System.Collections.Generic.IDictionary<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>, System.Collections.IEnumerable
            {
                static /*0x0*/ GameDevWare.Dynamic.Expressions.ArgumentsTree Empty;
                /*0x10*/ System.Collections.Generic.Dictionary<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> innerDictionary;

                static /*0xe4a8f4*/ ArgumentsTree();
                /*0xe49ebc*/ ArgumentsTree();
                /*0xe49f3c*/ ArgumentsTree(System.Collections.Generic.Dictionary<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> innerDictionary);
                /*0xe49fb4*/ void System.Collections.Generic.IDictionary<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>.Add(string key, GameDevWare.Dynamic.Expressions.SyntaxTreeNode value);
                /*0xe4690c*/ bool ContainsKey(string key);
                /*0xe46964*/ bool ContainsKey(int position);
                /*0xe46af4*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0xe49ff4*/ bool System.Collections.Generic.IDictionary<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>.Remove(string key);
                /*0xe469f4*/ bool TryGetValue(string key, ref GameDevWare.Dynamic.Expressions.SyntaxTreeNode value);
                /*0xe46a5c*/ bool TryGetValue(int position, ref GameDevWare.Dynamic.Expressions.SyntaxTreeNode value);
                /*0xe46b44*/ System.Collections.Generic.ICollection<GameDevWare.Dynamic.Expressions.SyntaxTreeNode> get_Values();
                /*0xe4a034*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode get_Item(string key);
                /*0xe4a08c*/ void set_Item(string key, GameDevWare.Dynamic.Expressions.SyntaxTreeNode value);
                /*0xe4a0cc*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode get_Item(int position);
                /*0xe4a15c*/ void set_Item(int position, GameDevWare.Dynamic.Expressions.SyntaxTreeNode value);
                /*0xe4a19c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.Add(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> item);
                /*0xe4a1dc*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.Clear();
                /*0xe4a21c*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.Contains(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> item);
                /*0xe4a2d8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.CopyTo(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> array, int arrayIndex);
                /*0xe46b94*/ int get_Count();
                /*0xe4a394*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.get_IsReadOnly();
                /*0xe4a438*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.Remove(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode> item);
                /*0xe4a4f4*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.SyntaxTreeNode>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,GameDevWare.Dynamic.Expressions.SyntaxTreeNode>>.GetEnumerator();
                /*0xe4a594*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0xe4a634*/ bool Equals(object obj);
                /*0xe4a654*/ int GetHashCode();
                /*0xe4a674*/ string ToString();
            }

            class ArrayUtils
            {
                static ResultT[] ConvertAll<T, ResultT>(T[] array, System.Converter<T, ResultT> converter);
                static T[] Empty<T>();

                class EmptyArray<T>
                {
                    static /*0x0*/ T[] Value;

                    static EmptyArray();
                    EmptyArray();
                }
            }

            class AssemblyTypeResolver : GameDevWare.Dynamic.Expressions.KnownTypeResolver
            {
                static /*0xe4aa58*/ System.Collections.Generic.IEnumerable<System.Type> GetAssembliesPublicTypes(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
                /*0xe4a954*/ AssemblyTypeResolver(System.Reflection.Assembly[] assemblies);
                /*0xe4aa50*/ AssemblyTypeResolver(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
                /*0xe4a95c*/ AssemblyTypeResolver(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies, GameDevWare.Dynamic.Expressions.ITypeResolver otherTypeResolver);

                class <GetAssembliesPublicTypes>d__3 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Type <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies;
                    /*0x30*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> <>3__assemblies;
                    /*0x38*/ System.Collections.Generic.IEnumerator<System.Reflection.Assembly> <>s__1;
                    /*0x40*/ System.Reflection.Assembly <assembly>5__2;
                    /*0x48*/ System.Type[] <>s__3;
                    /*0x50*/ int <>s__4;
                    /*0x58*/ System.Type <type>5__5;

                    /*0xe4aac4*/ <GetAssembliesPublicTypes>d__3(int <>1__state);
                    /*0xe4ab08*/ void System.IDisposable.Dispose();
                    /*0xe4ab24*/ bool MoveNext();
                    /*0xe4aea8*/ void <>m__Finally1();
                    /*0xe4af58*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                    /*0xe4af60*/ void System.Collections.IEnumerator.Reset();
                    /*0xe4afa0*/ object System.Collections.IEnumerator.get_Current();
                    /*0xe4afa8*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                    /*0xe4b048*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class Binder
            {
                static /*0x0*/ GameDevWare.Dynamic.Expressions.ITypeResolver DefaultTypeResolver;
                /*0x10*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters;
                /*0x18*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription resultType;
                /*0x20*/ System.Type lambdaType;
                /*0x28*/ GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver;

                static /*0xe4b550*/ System.Type[] GetTypes(System.Type resultType, System.Collections.Generic.IList<System.Linq.Expressions.ParameterExpression> parameters);
                /*0xe4b04c*/ Binder(System.Type lambdaType, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                /*0xe4b804*/ Binder(System.Collections.Generic.IList<System.Linq.Expressions.ParameterExpression> parameters, System.Type resultType, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                /*0xe471ec*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Parameters();
                /*0xe471f4*/ System.Type get_ResultType();
                /*0xe46be4*/ System.Linq.Expressions.LambdaExpression Bind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, System.Linq.Expressions.Expression global);
                /*0xe4c1a4*/ string ToString();

                class <>c
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Binder.<> <>9;
                    static /*0x8*/ System.Func<GameDevWare.Dynamic.Expressions.Binding.MemberDescription, bool> <>9__9_0;
                    static /*0x10*/ System.Func<System.Linq.Expressions.ParameterExpression, bool> <>9__10_0;
                    static /*0x18*/ System.Func<System.Linq.Expressions.ParameterExpression, string> <>9__13_0;

                    static /*0xe4c328*/ <>c();
                    /*0xe4c38c*/ <>c();
                    /*0xe4c394*/ bool <.ctor>b__9_0(GameDevWare.Dynamic.Expressions.Binding.MemberDescription m);
                    /*0xe4c3c4*/ bool <.ctor>b__10_0(System.Linq.Expressions.ParameterExpression p);
                    /*0xe4c408*/ string <ToString>b__13_0(System.Linq.Expressions.ParameterExpression p);
                }
            }

            class Constants
            {
                static string EXPRESSION_LINE_NUMBER_OLD = "$lineNum";
                static string EXPRESSION_COLUMN_NUMBER_OLD = "$columnNum";
                static string EXPRESSION_TOKEN_LENGTH_OLD = "$tokenLength";
                static string EXPRESSION_ORIGINAL_OLD = "$originalExpression";
                static string EXPRESSION_ORIGINAL_ALT = "_src";
                static string EXPRESSION_ORIGINAL_C_SHARP = "_cs";
                static string EXPRESSION_POSITION = "_pos";
                static string EXPRESSION_TYPE_ATTRIBUTE = "expressionType";
                static string EXPRESSION_ATTRIBUTE = "expression";
                static string ARGUMENTS_ATTRIBUTE = "arguments";
                static string INITIALIZERS_ATTRIBUTE = "initializers";
                static string MEMBER_ATTRIBUTE = "member";
                static string LEFT_ATTRIBUTE = "left";
                static string RIGHT_ATTRIBUTE = "right";
                static string TEST_ATTRIBUTE = "test";
                static string IF_TRUE_ATTRIBUTE = "ifTrue";
                static string IF_FALSE_ATTRIBUTE = "ifFalse";
                static string TYPE_ATTRIBUTE = "type";
                static string VALUE_ATTRIBUTE = "value";
                static string NEW_ATTRIBUTE = "new";
                static string BINDINGS_ATTRIBUTE = "bindings";
                static string PROPERTY_OR_FIELD_NAME_ATTRIBUTE = "propertyOrFieldName";
                static string NAME_ATTRIBUTE = "name";
                static string USE_NULL_PROPAGATION_ATTRIBUTE = "useNullPropagation";
                static string METHOD_ATTRIBUTE = "method";
                static string CONVERSION_ATTRIBUTE = "conversion";
                static string EXPRESSION_TYPE_TYPE_REFERENCE = "TypeRef";
                static string EXPRESSION_TYPE_MEMBER_REFERENCE = "MemberRef";
                static string EXPRESSION_TYPE_PROPERTY_OR_FIELD = "PropertyOrField";
                static string EXPRESSION_TYPE_MEMBER_RESOLVE = "MemberResolve";
                static string EXPRESSION_TYPE_CONSTANT = "Constant";
                static string EXPRESSION_TYPE_CONVERT = "Convert";
                static string EXPRESSION_TYPE_CONVERT_CHECKED = "ConvertChecked";
                static string EXPRESSION_TYPE_CALL = "Call";
                static string EXPRESSION_TYPE_GROUP = "Group";
                static string EXPRESSION_TYPE_INVOKE = "Invoke";
                static string EXPRESSION_TYPE_LAMBDA = "Lambda";
                static string EXPRESSION_TYPE_INDEX = "Index";
                static string EXPRESSION_TYPE_UNCHECKED_SCOPE = "UncheckedScope";
                static string EXPRESSION_TYPE_CHECKED_SCOPE = "CheckedScope";
                static string EXPRESSION_TYPE_TYPE_OF = "TypeOf";
                static string EXPRESSION_TYPE_DEFAULT = "Default";
                static string EXPRESSION_TYPE_NEW = "New";
                static string EXPRESSION_TYPE_ARRAY_LENGTH = "ArrayLength";
                static string EXPRESSION_TYPE_NEW_ARRAY_BOUNDS = "NewArrayBounds";
                static string EXPRESSION_TYPE_NEW_ARRAY_INIT = "NewArrayInit";
                static string EXPRESSION_TYPE_MEMBER_INIT = "MemberInit";
                static string EXPRESSION_TYPE_LIST_INIT = "ListInit";
                static string EXPRESSION_TYPE_ADD = "Add";
                static string EXPRESSION_TYPE_ADD_CHECKED = "AddChecked";
                static string EXPRESSION_TYPE_SUBTRACT = "Subtract";
                static string EXPRESSION_TYPE_SUBTRACT_CHECKED = "SubtractChecked";
                static string EXPRESSION_TYPE_LEFT_SHIFT = "LeftShift";
                static string EXPRESSION_TYPE_RIGHT_SHIFT = "RightShift";
                static string EXPRESSION_TYPE_GREATER_THAN = "GreaterThan";
                static string EXPRESSION_TYPE_GREATER_THAN_OR_EQUAL = "GreaterThanOrEqual";
                static string EXPRESSION_TYPE_LESS_THAN = "LessThan";
                static string EXPRESSION_TYPE_LESS_THAN_OR_EQUAL = "LessThanOrEqual";
                static string EXPRESSION_TYPE_QUOTE = "Quote";
                static string EXPRESSION_TYPE_NEGATE = "Negate";
                static string EXPRESSION_TYPE_NEGATE_CHECKED = "NegateChecked";
                static string EXPRESSION_TYPE_POWER = "Power";
                static string EXPRESSION_TYPE_COMPLEMENT = "Complement";
                static string EXPRESSION_TYPE_DIVIDE = "Divide";
                static string EXPRESSION_TYPE_MULTIPLY = "Multiply";
                static string EXPRESSION_TYPE_MULTIPLY_CHECKED = "MultiplyChecked";
                static string EXPRESSION_TYPE_MODULO = "Modulo";
                static string EXPRESSION_TYPE_TYPE_IS = "TypeIs";
                static string EXPRESSION_TYPE_TYPE_AS = "TypeAs";
                static string EXPRESSION_TYPE_NOT = "Not";
                static string EXPRESSION_TYPE_EQUAL = "Equal";
                static string EXPRESSION_TYPE_NOT_EQUAL = "NotEqual";
                static string EXPRESSION_TYPE_AND = "And";
                static string EXPRESSION_TYPE_OR = "Or";
                static string EXPRESSION_TYPE_EXCLUSIVE_OR = "ExclusiveOr";
                static string EXPRESSION_TYPE_AND_ALSO = "AndAlso";
                static string EXPRESSION_TYPE_OR_ELSE = "OrElse";
                static string EXPRESSION_TYPE_COALESCE = "Coalesce";
                static string EXPRESSION_TYPE_CONDITION = "Condition";
                static string EXPRESSION_TYPE_PARAMETER = "Parameter";
                static string EXPRESSION_TYPE_UNARY_PLUS = "UnaryPlus";
                static string EXPRESSION_TYPE_CHECKED_SUFFIX = "Checked";
                static string DELEGATE_INVOKE_NAME = "Invoke";
                static string EXECUTE_PREPARE_NAME = "PrepareFunc";
                static string VALUE_TRUE_STRING = "true";
                static string VALUE_FALSE_STRING = "false";
                static string VALUE_NULL_STRING = "null";
                static int MAX_ARGUMENTS_COUNT = 100;
                static /*0x0*/ object TrueObject;
                static /*0x8*/ object FalseObject;
                static /*0x10*/ System.Globalization.CultureInfo DefaultFormatProvider;
                static /*0x18*/ System.Linq.Expressions.ParameterExpression[] EmptyParameters;
                static /*0x20*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> EmptyReadonlyParameters;
                static /*0x28*/ string[] IntToString;

                static /*0xe4c420*/ Constants();
                static /*0xe47250*/ string GetIndexAsString(int index);

                class <>c
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Constants.<> <>9;

                    static /*0xe4c654*/ <>c();
                    /*0xe4c6b8*/ <>c();
                    /*0xe4c6c0*/ string <.cctor>b__95_0(int i);
                }
            }

            class DelegateUtils
            {
                static /*0xe47314*/ System.Delegate CreateDelegate(System.Type delegateType, System.Reflection.MethodInfo method, bool throwOnBindingFailure);
                static /*0xe473a0*/ System.Reflection.MethodInfo GetMethodInfo(System.Delegate delegateInstance);
            }

            class ExpressionKnownTypeAttribute : System.Attribute
            {
                /*0x10*/ System.Type <Type>k__BackingField;

                /*0xe4c6ec*/ ExpressionKnownTypeAttribute(System.Type type);
                /*0xe4c6dc*/ System.Type get_Type();
                /*0xe4c6e4*/ void set_Type(System.Type value);
            }

            class ExpressionLookupVisitor : GameDevWare.Dynamic.Expressions.ExpressionVisitor
            {
                /*0x10*/ System.Collections.Generic.List<System.Linq.Expressions.Expression> lookupList;
                /*0x18*/ int found;

                static /*0xe473fc*/ bool Lookup(System.Linq.Expressions.Expression expression, System.Collections.Generic.List<System.Linq.Expressions.Expression> lookupList);
                /*0xe4c764*/ ExpressionLookupVisitor(System.Collections.Generic.List<System.Linq.Expressions.Expression> lookupList);
                /*0xe4c7e8*/ System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression binaryExpression);
                /*0xe4ca44*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression conditionalExpression);
                /*0xe4cba8*/ System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression constantExpression);
                /*0xe4cc20*/ System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression invocationExpression);
                /*0xe4cd60*/ System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.LambdaExpression lambda);
                /*0xe4cea0*/ System.Linq.Expressions.Expression VisitListInit(System.Linq.Expressions.ListInitExpression listInitExpression);
                /*0xe4cfd8*/ System.Linq.Expressions.Expression VisitMemberAccess(System.Linq.Expressions.MemberExpression memberExpression);
                /*0xe4d0f4*/ System.Linq.Expressions.Expression VisitMemberInit(System.Linq.Expressions.MemberInitExpression memberInitExpression);
                /*0xe4d22c*/ System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression methodCallExpression);
                /*0xe4d388*/ System.Linq.Expressions.NewExpression VisitNew(System.Linq.Expressions.NewExpression newExpression);
                /*0xe4d4d8*/ System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression newArrayExpression);
                /*0xe4d640*/ System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression parameterExpression);
                /*0xe4d6b8*/ System.Linq.Expressions.Expression VisitTypeIs(System.Linq.Expressions.TypeBinaryExpression typeBinaryExpression);
                /*0xe4d7c4*/ System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression unaryExpression);
            }

            class ExpressionPacker
            {
                static /*0xe47490*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.Expression expression);
                static /*0xe474ec*/ System.Linq.Expressions.Expression Unpack(System.Collections.Generic.IDictionary<string, object> packedExpression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global, System.Type expectedType);
                static /*0xe47714*/ System.Linq.Expressions.LambdaExpression UnpackLambda(System.Type delegateType, System.Collections.Generic.IDictionary<string, object> packedExpression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                static System.Linq.Expressions.Expression<DelegateT> UnpackLambda<DelegateT>(System.Collections.Generic.IDictionary<string, object> expressionTree, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
            }

            class ExpressionParserException : System.Exception, GameDevWare.Dynamic.Expressions.ILineInfo
            {
                /*0x8c*/ int <LineNumber>k__BackingField;
                /*0x90*/ int <ColumnNumber>k__BackingField;
                /*0x94*/ int <TokenLength>k__BackingField;

                /*0xe4d940*/ ExpressionParserException();
                /*0xe4d998*/ ExpressionParserException(string message, int lineNumber, int columnNumber, int tokenLength);
                /*0xe4da20*/ ExpressionParserException(string message, System.Exception innerException, int lineNumber, int columnNumber, int tokenLength);
                /*0xe4c000*/ ExpressionParserException(string message, GameDevWare.Dynamic.Expressions.ILineInfo lineInfo);
                /*0xe4dab8*/ ExpressionParserException(string message, System.Exception innerException, GameDevWare.Dynamic.Expressions.ILineInfo lineInfo);
                /*0xe4dc6c*/ ExpressionParserException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xe4d910*/ int get_LineNumber();
                /*0xe4d918*/ void set_LineNumber(int value);
                /*0xe4d920*/ int get_ColumnNumber();
                /*0xe4d928*/ void set_ColumnNumber(int value);
                /*0xe4d930*/ int get_TokenLength();
                /*0xe4d938*/ void set_TokenLength(int value);
                /*0xe4dd70*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xe4de4c*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetLineNumber();
                /*0xe4de54*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetColumnNumber();
                /*0xe4de5c*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetTokenLength();
                /*0xe4de64*/ string ToString();
            }

            struct ExpressionPosition : GameDevWare.Dynamic.Expressions.ILineInfo, System.IEquatable<GameDevWare.Dynamic.Expressions.ExpressionPosition>, System.IEquatable<GameDevWare.Dynamic.Expressions.ILineInfo>
            {
                /*0x10*/ int LineNumber;
                /*0x14*/ int ColumnNumber;
                /*0x18*/ int TokenLength;

                static /*0xe47844*/ GameDevWare.Dynamic.Expressions.ExpressionPosition Parse(string positionString);
                /*0xe4e008*/ ExpressionPosition(int lineNumber, int columnNumber, int tokenLength);
                /*0xe479e0*/ bool Equals(object obj);
                /*0xe47ad8*/ bool Equals(GameDevWare.Dynamic.Expressions.ExpressionPosition other);
                /*0xe47b0c*/ bool Equals(GameDevWare.Dynamic.Expressions.ILineInfo other);
                /*0xe47c98*/ int GetHashCode();
                /*0xe4e014*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetLineNumber();
                /*0xe4e01c*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetColumnNumber();
                /*0xe4e024*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetTokenLength();
                /*0xe47cb8*/ string ToString();
            }

            class ExpressionSubstitutor : GameDevWare.Dynamic.Expressions.ExpressionVisitor
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Linq.Expressions.Expression, System.Linq.Expressions.Expression> substitutions;

                static /*0xe47e40*/ System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression expression, System.Collections.Generic.Dictionary<System.Linq.Expressions.Expression, System.Linq.Expressions.Expression> substitutions);
                /*0xe4e02c*/ ExpressionSubstitutor(System.Collections.Generic.Dictionary<System.Linq.Expressions.Expression, System.Linq.Expressions.Expression> substitutions);
                /*0xe4e0a4*/ System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression parameterExpression);
                /*0xe4e11c*/ System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression constantExpression);
            }

            class ExpressionUtils
            {
                static /*0x0*/ System.Linq.Expressions.Expression NullConstant;
                static /*0x8*/ System.Linq.Expressions.Expression TrueConstant;
                static /*0x10*/ System.Linq.Expressions.Expression FalseConstant;
                static /*0x18*/ System.Linq.Expressions.Expression NegativeSingle;
                static /*0x20*/ System.Linq.Expressions.Expression NegativeDouble;

                static /*0xe50344*/ ExpressionUtils();
                static /*0xe47f20*/ bool TryPromoteBinaryOperation(ref System.Linq.Expressions.Expression leftOperand, ref System.Linq.Expressions.Expression rightOperand, System.Linq.Expressions.ExpressionType type, ref System.Linq.Expressions.Expression operation);
                static /*0xe4e9b4*/ bool TryPromoteNumberBinaryOperation(ref System.Linq.Expressions.Expression leftOperand, GameDevWare.Dynamic.Expressions.Binding.TypeDescription leftType, ref System.Linq.Expressions.Expression rightOperand, GameDevWare.Dynamic.Expressions.Binding.TypeDescription rightType, System.Linq.Expressions.ExpressionType type, ref System.Linq.Expressions.Expression operation);
                static /*0xe4e194*/ bool TryPromoteEnumBinaryOperation(ref System.Linq.Expressions.Expression leftOperand, GameDevWare.Dynamic.Expressions.Binding.TypeDescription leftType, ref System.Linq.Expressions.Expression rightOperand, GameDevWare.Dynamic.Expressions.Binding.TypeDescription rightType, System.Linq.Expressions.ExpressionType type, ref System.Linq.Expressions.Expression operation);
                static /*0xe48220*/ bool TryPromoteUnaryOperation(ref System.Linq.Expressions.Expression operand, System.Linq.Expressions.ExpressionType type, ref System.Linq.Expressions.Expression operation);
                static /*0xe48464*/ bool IsNull(System.Linq.Expressions.Expression expression, bool unwrapConversions);
                static /*0xe485f4*/ void MorphType(ref System.Linq.Expressions.Expression expression, System.Type toType);
                static /*0xe48758*/ bool TryMorphType(ref System.Linq.Expressions.Expression expression, System.Type toType, ref float quality);
                static /*0xe4fb44*/ bool TryFindConversion(ref System.Linq.Expressions.Expression expression, GameDevWare.Dynamic.Expressions.Binding.TypeDescription actualType, GameDevWare.Dynamic.Expressions.Binding.TypeDescription targetType, ref float quality);
                static /*0xe4f6c0*/ bool TryConvertInPlace(ref System.Linq.Expressions.Expression expression, GameDevWare.Dynamic.Expressions.Binding.TypeDescription targetType, ref float quality);
                static /*0xe4f3a0*/ System.Linq.Expressions.Expression ConvertToNullable(System.Linq.Expressions.Expression notNullableExpression, GameDevWare.Dynamic.Expressions.Binding.TypeDescription typeDescription);
                static /*0xe48904*/ System.Linq.Expressions.Expression MakeNullPropagationExpression(System.Collections.Generic.List<System.Linq.Expressions.Expression> nullTestExpressions, System.Linq.Expressions.Expression ifNotNullExpression);
                static /*0xe48df4*/ bool ExtractNullPropagationExpression(System.Linq.Expressions.ConditionalExpression conditionalExpression, ref System.Collections.Generic.List<System.Linq.Expressions.Expression> nullTestExpressions, ref System.Linq.Expressions.Expression ifNotNullExpression);
                static /*0xe50054*/ bool TryExtractTestTargets(System.Linq.Expressions.Expression testExpression, ref System.Collections.Generic.List<System.Linq.Expressions.Expression> nullTestExpressions);
                static /*0xe4f5d0*/ bool TryExposeConstant(System.Linq.Expressions.Expression expression, ref System.Linq.Expressions.ConstantExpression constantExpression);
                static /*0xe4fee4*/ bool IsInRange(object value, System.TypeCode valueTypeCode, long minValue, ulong maxValue);
            }

            class ExpressionVisitor
            {
                /*0xe4c7e0*/ ExpressionVisitor();
                /*0xe50500*/ System.Exception UnhandledBindingType(System.Linq.Expressions.MemberBindingType memberBindingType);
                /*0xe50580*/ System.Exception UnhandledExpressionType(System.Linq.Expressions.ExpressionType expressionType);
                /*0xe48fbc*/ System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression exp);
                /*0xe4c85c*/ System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression binaryExpression);
                /*0xe50600*/ System.Linq.Expressions.MemberBinding VisitBinding(System.Linq.Expressions.MemberBinding binding);
                /*0xe50708*/ System.Collections.Generic.IEnumerable<System.Linq.Expressions.MemberBinding> VisitBindingList(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> original);
                /*0xe4cab8*/ System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression conditionalExpression);
                /*0xe4cc18*/ System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression constantExpression);
                /*0xe50940*/ System.Linq.Expressions.ElementInit VisitElementInitializer(System.Linq.Expressions.ElementInit initializer);
                /*0xe509e0*/ System.Collections.Generic.IEnumerable<System.Linq.Expressions.ElementInit> VisitElementInitializerList(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> original);
                /*0xe50c18*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> VisitExpressionList(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> original);
                /*0xe4cc94*/ System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression invocationExpression);
                /*0xe4cdd4*/ System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.LambdaExpression lambda);
                /*0xe4cf14*/ System.Linq.Expressions.Expression VisitListInit(System.Linq.Expressions.ListInitExpression listInitExpression);
                /*0xe4d04c*/ System.Linq.Expressions.Expression VisitMemberAccess(System.Linq.Expressions.MemberExpression memberExpression);
                /*0xe50e84*/ System.Linq.Expressions.MemberAssignment VisitMemberAssignment(System.Linq.Expressions.MemberAssignment assignment);
                /*0xe4d168*/ System.Linq.Expressions.Expression VisitMemberInit(System.Linq.Expressions.MemberInitExpression memberInitExpression);
                /*0xe50f1c*/ System.Linq.Expressions.MemberListBinding VisitMemberListBinding(System.Linq.Expressions.MemberListBinding binding);
                /*0xe50fbc*/ System.Linq.Expressions.MemberMemberBinding VisitMemberMemberBinding(System.Linq.Expressions.MemberMemberBinding binding);
                /*0xe4d2a0*/ System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression methodCallExpression);
                /*0xe4d3fc*/ System.Linq.Expressions.NewExpression VisitNew(System.Linq.Expressions.NewExpression newExpression);
                /*0xe4d54c*/ System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression newArrayExpression);
                /*0xe4d6b0*/ System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression parameterExpression);
                /*0xe4d72c*/ System.Linq.Expressions.Expression VisitTypeIs(System.Linq.Expressions.TypeBinaryExpression typeBinaryExpression);
                /*0xe4d838*/ System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression unaryExpression);
            }

            interface ILineInfo
            {
                int GetLineNumber();
                int GetColumnNumber();
                int GetTokenLength();
            }

            interface ITypeResolver
            {
                bool TryGetType(GameDevWare.Dynamic.Expressions.TypeReference typeReference, ref System.Type foundType);
                bool IsKnownType(System.Type type);
            }

            class JitSupportDetector
            {
                static /*0x0*/ System.Nullable<bool> IsDynamicCompilationResult;

                static /*0xe45e24*/ bool IsDynamicCompilationAvailable();
                /*0xe5105c*/ JitSupportDetector();
            }

            class KnownTypeResolver : GameDevWare.Dynamic.Expressions.ITypeResolver
            {
                static /*0x0*/ GameDevWare.Dynamic.Expressions.KnownTypeResolver Default;
                static /*0x8*/ System.Collections.Generic.HashSet<System.Type> BuildInTypes;
                static /*0x10*/ string ArrayName;
                static /*0x18*/ string ArrayFullName;
                /*0x10*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Type>> knownTypesByFullName;
                /*0x18*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Type>> knownTypesByName;
                /*0x20*/ System.Collections.Generic.HashSet<System.Type> knownTypes;
                /*0x28*/ GameDevWare.Dynamic.Expressions.ITypeResolver otherTypeResolver;

                static /*0xe51064*/ KnownTypeResolver();
                static /*0xe51d24*/ System.Collections.Generic.HashSet<System.Type> GetKnownTypes(System.Collections.Generic.IEnumerable<System.Type> types, System.Collections.Generic.HashSet<System.Type> collection, GameDevWare.Dynamic.Expressions.TypeDiscoveryOptions options);
                /*0xe516d4*/ KnownTypeResolver(System.Type[] knownTypes);
                /*0xe516e0*/ KnownTypeResolver(System.Collections.Generic.IEnumerable<System.Type> knownTypes);
                /*0xe4aabc*/ KnownTypeResolver(System.Collections.Generic.IEnumerable<System.Type> knownTypes, GameDevWare.Dynamic.Expressions.ITypeResolver otherTypeResolver);
                /*0xe516ec*/ KnownTypeResolver(System.Collections.Generic.IEnumerable<System.Type> knownTypes, GameDevWare.Dynamic.Expressions.ITypeResolver otherTypeResolver, GameDevWare.Dynamic.Expressions.TypeDiscoveryOptions options);
                /*0xe49440*/ bool TryGetType(GameDevWare.Dynamic.Expressions.TypeReference typeReference, ref System.Type foundType);
                /*0xe49d7c*/ bool IsKnownType(System.Type type);
                /*0xe5257c*/ string ToString();

                class <>c
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.KnownTypeResolver.<> <>9;
                    static /*0x8*/ System.Func<GameDevWare.Dynamic.Expressions.ExpressionKnownTypeAttribute, System.Type> <>9__15_0;

                    static /*0xe526d8*/ <>c();
                    /*0xe5273c*/ <>c();
                    /*0xe52744*/ System.Type <GetKnownTypes>b__15_0(GameDevWare.Dynamic.Expressions.ExpressionKnownTypeAttribute a);
                }
            }

            class MethodCallSignature
            {
                /*0x10*/ int hashCode;
                /*0x18*/ System.Type Parameter1Type;
                /*0x20*/ System.Type Parameter2Type;
                /*0x28*/ System.Type Parameter3Type;
                /*0x30*/ System.Type Parameter4Type;
                /*0x38*/ string Parameter1Name;
                /*0x40*/ string Parameter2Name;
                /*0x48*/ string Parameter3Name;
                /*0x50*/ string Parameter4Name;
                /*0x58*/ System.Type ReturnType;
                /*0x60*/ int Count;

                /*0xe5275c*/ MethodCallSignature(System.Type returnType);
                /*0xe5294c*/ MethodCallSignature(System.Type parameter1Type, string parameter1Name, System.Type returnType);
                /*0xe52a40*/ MethodCallSignature(System.Type parameter1Type, string parameter1Name, System.Type parameter2Type, string parameter2Name, System.Type returnType);
                /*0xe52b94*/ MethodCallSignature(System.Type parameter1Type, string parameter1Name, System.Type parameter2Type, string parameter2Name, System.Type parameter3Type, string parameter3Name, System.Type returnType);
                /*0xe52d50*/ MethodCallSignature(System.Type parameter1Type, string parameter1Name, System.Type parameter2Type, string parameter2Name, System.Type parameter3Type, string parameter3Name, System.Type parameter4Type, string parameter4Name, System.Type returnType);
                /*0xe52f64*/ MethodCallSignature(System.Reflection.MethodInfo method, bool includeParameterNames);
                /*0xe532f4*/ bool Equals(object obj);
                /*0xe5342c*/ int GetHashCode();
                /*0xe527e4*/ int ComputeHashCode();
                /*0xe53434*/ string ToString();
            }

            class ReflectionUtils
            {
                static /*0xe536d4*/ bool IsStatic(System.Reflection.MemberInfo memberInfo);
                static /*0xe538fc*/ bool IsStatic(System.Reflection.PropertyInfo propertyInfo);
                static /*0xe5399c*/ System.Reflection.MethodInfo GetAnyGetter(System.Reflection.PropertyInfo propertyInfo);
                static /*0xe539c0*/ System.Reflection.MethodInfo GetPublicGetter(System.Reflection.PropertyInfo propertyInfo);
                static /*0xe539e4*/ System.Reflection.MethodInfo GetPublicSetter(System.Reflection.PropertyInfo propertyInfo);
                static /*0xe53a08*/ System.Reflection.MethodInfo GetAnySetter(System.Reflection.PropertyInfo propertyInfo);
                static /*0xe53a2c*/ bool IsIndexer(System.Reflection.MethodInfo methodInfo);
                static /*0xe53f00*/ System.Type GetTypeInfo(System.Type type);
                static /*0xe53f58*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetDeclaredFields(System.Type type);
                static /*0xe53e94*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetDeclaredProperties(System.Type type);
                static /*0xe53fc4*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(System.Type type);
                static /*0xe54030*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetAllMethods(System.Type type);
                static /*0xe5409c*/ System.TypeCode GetTypeCode(System.Type type);
                static /*0xe54144*/ System.Collections.Generic.IEnumerable<System.Type> GetAllNestedTypes(System.Type type);
                static /*0xe541b0*/ System.Reflection.MethodInfo GetDeclaredMethod(System.Type type, string name);
                static /*0xe5423c*/ System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> GetPublicInstanceConstructors(System.Type type);
                static /*0xe542a8*/ System.Collections.Generic.IEnumerable<System.Type> GetImplementedInterfaces(System.Type type);
                static /*0xe54310*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetDeclaredMembers(System.Type type);
                static /*0xe5437c*/ System.Reflection.MethodInfo FindConversion(GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] conversionOperators, System.Type fromType, System.Type toType);
            }

            class SyntaxTreeNode : System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, GameDevWare.Dynamic.Expressions.ILineInfo
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, object> innerDictionary;

                static /*0xe54510*/ System.Collections.Generic.Dictionary<string, object> PrepareNode(System.Collections.Generic.IDictionary<string, object> node);
                /*0xe544e0*/ SyntaxTreeNode(System.Collections.Generic.IDictionary<string, object> node);
                T GetValueOrDefault<T>(string key, T defaultValue);
                /*0xe549d8*/ string GetExpressionType(bool throwOnError);
                /*0xe54bf4*/ object GetTypeName(bool throwOnError);
                /*0xe54d94*/ object GetValue(bool throwOnError);
                /*0xe54ed8*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetExpression(bool throwOnError);
                /*0xe55074*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetLeftExpression(bool throwOnError);
                /*0xe550cc*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetRightExpression(bool throwOnError);
                /*0xe55124*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetTestExpression(bool throwOnError);
                /*0xe5517c*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetIfTrueExpression(bool throwOnError);
                /*0xe551d4*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetIfFalseExpression(bool throwOnError);
                /*0xe5522c*/ GameDevWare.Dynamic.Expressions.ArgumentsTree GetArguments(bool throwOnError);
                /*0xe55a50*/ System.Collections.Generic.Dictionary<string, string> GetArgumentNames(bool throwOnError);
                /*0xe560b8*/ string GetMemberName(bool throwOnError);
                /*0xe5623c*/ object GetName(bool throwOnError);
                /*0xe56374*/ object GetMethodName(bool throwOnError);
                /*0xe564b8*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetConversion(bool throwOnError);
                /*0xe56510*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetBindings(bool throwOnError);
                /*0xe56568*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetMember(bool throwOnError);
                /*0xe565c0*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetNewExpression(bool throwOnError);
                /*0xe56618*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetInitializers(bool throwOnError);
                /*0xe56670*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetTypeArguments(bool throwOnError);
                /*0xe566c8*/ bool GetUseNullPropagation(bool throwOnError);
                /*0xe54f30*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode GetExpression(string attributeName, bool throwOnError);
                /*0xe56870*/ int GetLineNumber(bool throwOnError);
                /*0xe56f40*/ int GetColumnNumber(bool throwOnError);
                /*0xe5710c*/ int GetTokenLength(bool throwOnError);
                /*0xe572d8*/ string GetPosition(bool throwOnError);
                /*0xe56a38*/ GameDevWare.Dynamic.Expressions.ExpressionPosition GetExpressionPosition(bool throwOnError);
                /*0xe57360*/ string GetCSharpExpression(bool throwOnError);
                /*0xe57550*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetLineNumber();
                /*0xe57558*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetColumnNumber();
                /*0xe57560*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetTokenLength();
                /*0xe57568*/ void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(string key, object value);
                /*0xe57308*/ bool ContainsKey(string key);
                /*0xe575a8*/ System.Collections.Generic.ICollection<string> get_Keys();
                /*0xe575f8*/ bool System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(string key);
                /*0xe54b00*/ bool TryGetValue(string key, ref object value);
                /*0xe57638*/ System.Collections.Generic.ICollection<object> get_Values();
                /*0xe57688*/ object get_Item(string key);
                /*0xe576e0*/ void set_Item(string key, object value);
                /*0xe57720*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> item);
                /*0xe57760*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear();
                /*0xe577a0*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> item);
                /*0xe5785c*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object> array, int arrayIndex);
                /*0xe558e8*/ int get_Count();
                /*0xe57918*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly();
                /*0xe579bc*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> item);
                /*0xe57a78*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator();
                /*0xe57b18*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0xe57bb8*/ bool Equals(object obj);
                /*0xe57bd8*/ int GetHashCode();
                /*0xe57bf8*/ string ToCSharpExpression();
                /*0xe57c44*/ string ToString();
            }

            enum TypeDiscoveryOptions
            {
                Default = 0,
                Interfaces = 2,
                GenericArguments = 4,
                KnownTypes = 8,
                DeclaringTypes = 16,
                All = 30,
            }

            enum TypeNameFormatOptions
            {
                None = 0,
                IncludeDeclaringType = 1,
                IncludeNamespace = 3,
                IncludeGenericArguments = 4,
                IncludeGenericSuffix = 8,
                UseAliases = 16,
            }

            class TypeNameUtils
            {
                static /*0x0*/ string[] EmptyNames;

                static /*0xe59944*/ TypeNameUtils();
                static /*0xe58110*/ string[] GetTypeNames(System.Type typeInfo);
                static /*0xe58608*/ string[] GetTypeFullNames(System.Type typeInfo);
                static /*0xe58920*/ System.Text.StringBuilder GetCSharpFullName(System.Type typeInfo, System.Text.StringBuilder builder, GameDevWare.Dynamic.Expressions.TypeNameFormatOptions options);
                static /*0xe584c0*/ System.Text.StringBuilder GetCSharpName(System.Type typeInfo, System.Text.StringBuilder builder, GameDevWare.Dynamic.Expressions.TypeNameFormatOptions options);
                static /*0xe591a0*/ System.Text.StringBuilder GetCSharpNameOnly(System.Type typeInfo, System.Text.StringBuilder builder, GameDevWare.Dynamic.Expressions.TypeNameFormatOptions options);
                static /*0xe592e4*/ string RemoveGenericSuffix(string name);
                static /*0xe59474*/ System.Text.StringBuilder RemoveGenericSuffix(System.Text.StringBuilder builder);
                static /*0xe58f74*/ System.Text.StringBuilder RemoveGenericSuffix(System.Text.StringBuilder builder, int startIndex, int count);
                static /*0xe5964c*/ GameDevWare.Dynamic.Expressions.TypeNameUtils.TypeNestingEnumerator GetDeclaringTypes(System.Type typeInfo);
                static /*0xe58a64*/ void WriteName(System.Type typeInfo, System.Text.StringBuilder builder, GameDevWare.Dynamic.Expressions.TypeNameFormatOptions options);
                static /*0xe59670*/ void WriteNamePart(System.Type type, System.Text.StringBuilder builder, System.ArraySegment<System.Type> genericArguments, GameDevWare.Dynamic.Expressions.TypeNameFormatOptions options);
                static /*0xe594ec*/ int IndexOf(System.Text.StringBuilder builder, char character, int startIndex, int count);

                struct TypeNestingEnumerator : System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator, System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Type typeInfo;
                    /*0x18*/ System.Type current;

                    static /*0xe599d8*/ System.Type GetDeclaringType(System.Type type);
                    /*0xe59654*/ TypeNestingEnumerator(System.Type typeInfo);
                    /*0xe598a0*/ bool MoveNext();
                    /*0xe599ac*/ void Reset();
                    /*0xe59668*/ System.Type get_Current();
                    /*0xe59a4c*/ object System.Collections.IEnumerator.get_Current();
                    /*0xe5965c*/ GameDevWare.Dynamic.Expressions.TypeNameUtils.TypeNestingEnumerator GetEnumerator();
                    /*0xe59a54*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                    /*0xe59ab0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0xe59b0c*/ void Dispose();
                }

                class <>c
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.TypeNameUtils.<> <>9;
                    static /*0x8*/ System.Converter<System.Type, System.Type> <>9__10_0;

                    static /*0xe59b10*/ <>c();
                    /*0xe59b74*/ <>c();
                    /*0xe59b7c*/ System.Type <WriteName>b__10_0(System.Type t);
                }
            }

            class TypeReference : System.IEquatable<GameDevWare.Dynamic.Expressions.TypeReference>
            {
                static /*0x0*/ GameDevWare.Dynamic.Expressions.TypeReference Empty;
                static /*0x8*/ System.Collections.Generic.IList<GameDevWare.Dynamic.Expressions.TypeReference> EmptyTypeArguments;
                /*0x10*/ string fullName;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Collections.ObjectModel.ReadOnlyCollection<string> typeName;
                /*0x28*/ System.Collections.ObjectModel.ReadOnlyCollection<GameDevWare.Dynamic.Expressions.TypeReference> typeArguments;

                static /*0xe5acdc*/ TypeReference();
                static /*0xe5a6c4*/ bool op_Equality(GameDevWare.Dynamic.Expressions.TypeReference x, GameDevWare.Dynamic.Expressions.TypeReference y);
                static /*0xe5abe4*/ bool op_Inequality(GameDevWare.Dynamic.Expressions.TypeReference x, GameDevWare.Dynamic.Expressions.TypeReference y);
                static /*0xe5a6dc*/ int ComputeHashCode(GameDevWare.Dynamic.Expressions.TypeReference typeReference);
                /*0xe59f54*/ TypeReference();
                /*0xe5a0e4*/ TypeReference(System.Collections.Generic.IList<string> typeName, System.Collections.Generic.IList<GameDevWare.Dynamic.Expressions.TypeReference> typeArguments);
                /*0xe59b84*/ string get_FullName();
                /*0xe59e18*/ string get_Name();
                /*0xe59e90*/ string get_Namespace();
                /*0xe59ef0*/ System.Collections.ObjectModel.ReadOnlyCollection<GameDevWare.Dynamic.Expressions.TypeReference> get_TypeArguments();
                /*0xe59ef8*/ bool get_IsGenericType();
                /*0xe59bf4*/ string CombineParts(int count, System.Text.StringBuilder builder);
                /*0xe5a8a8*/ void Format(System.Text.StringBuilder builder);
                /*0xe5aa04*/ bool Equals(object obj);
                /*0xe5aa68*/ bool Equals(GameDevWare.Dynamic.Expressions.TypeReference other);
                /*0xe5abdc*/ int GetHashCode();
                /*0xe5ac00*/ string ToString();
            }

            class UnboundExpression
            {
                /*0x10*/ System.Collections.Generic.Dictionary<GameDevWare.Dynamic.Expressions.MethodCallSignature, System.Linq.Expressions.Expression> compiledExpressions;
                /*0x18*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree;

                static /*0xe5aea0*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> CreateParameters(System.Type[] types, string[] names);
                /*0xe5ad5c*/ UnboundExpression(System.Collections.Generic.IDictionary<string, object> node);
                /*0xe5ad54*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode get_SyntaxTree();
                System.Func<ResultT> Bind<ResultT>();
                System.Func<Arg1T, ResultT> Bind<Arg1T, ResultT>(string arg1Name);
                System.Func<Arg1T, Arg2T, ResultT> Bind<Arg1T, Arg2T, ResultT>(string arg1Name, string arg2Name);
                System.Func<Arg1T, Arg2T, Arg3T, ResultT> Bind<Arg1T, Arg2T, Arg3T, ResultT>(string arg1Name, string arg2Name, string arg3Name);
                System.Func<Arg1T, Arg2T, Arg3T, Arg4T, ResultT> Bind<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(string arg1Name, string arg2Name, string arg3Name, string arg4Name);
                /*0xe5b2b4*/ bool Equals(object obj);
                /*0xe5b348*/ int GetHashCode();
                /*0xe5b368*/ string ToString();
            }

            namespace Properties
            {
                class Resources
                {
                    static /*0x0*/ string[] supportedLanguages;
                    [ThreadStatic] static int currentLanguageIdx;

                    static /*0xe5ec08*/ Resources();
                    static /*0xe5b608*/ string[] get_SupportedLanguages();
                    static /*0xe5b6a8*/ string get_CurrentLanguage();
                    static /*0xe5b728*/ void set_CurrentLanguage(string value);
                    static /*0xe5b89c*/ System.Collections.Generic.Dictionary<string, string> get_All();
                    static /*0xe5c64c*/ string get_EXCEPTION_BIND_UNABLETOBINDINDEXER();
                    static /*0xe5c6d8*/ string get_EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED();
                    static /*0xe5c764*/ string get_EXCEPTION_BIND_INVALIDLAMBDAPARAMETERTYPE();
                    static /*0xe5c7f0*/ string get_EXCEPTION_BIND_MISSINGMETHOD();
                    static /*0xe5c87c*/ string get_EXCEPTION_BIND_UNABLETOINVOKENONDELEG();
                    static /*0xe5c908*/ string get_EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED();
                    static /*0xe5c994*/ string get_EXCEPTION_PARSER_OPREQUIRESOPERAND();
                    static /*0xe5ca20*/ string get_EXCEPTION_BIND_UNABLETORESOLVENAME();
                    static /*0xe5caac*/ string get_EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT();
                    static /*0xe5cb38*/ string get_EXCEPTION_BOUNDEXPR_CANTCONVERTARG();
                    static /*0xe5cbc4*/ string get_EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS();
                    static /*0xe5cc50*/ string get_EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE();
                    static /*0xe5ccdc*/ string get_EXCEPTION_PARSER_BINARYOPREQOPERAND();
                    static /*0xe5cd68*/ string get_EXCEPTION_COMPIL_UNKNOWNEXPRTYPE();
                    static /*0xe5cdf4*/ string get_EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR();
                    static /*0xe5ce80*/ string get_EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE();
                    static /*0xe5cf0c*/ string get_EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE();
                    static /*0xe5cf98*/ string get_EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND();
                    static /*0xe54b68*/ string get_EXCEPTION_BIND_MISSINGATTRONNODE();
                    static /*0xe5d024*/ string get_EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED();
                    static /*0xe5d0b0*/ string get_EXCEPTION_BIND_UNABLETOBINDDELEG();
                    static /*0xe5d13c*/ string get_EXCEPTION_COMPIL_NOBINARYOPONTYPE();
                    static /*0xe5d1c8*/ string get_EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE();
                    static /*0xe5d254*/ string get_EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE();
                    static /*0xe5d2e0*/ string get_EXCEPTION_TOKENIZER_INVALIDCHARLITERAL();
                    static /*0xe5d36c*/ string get_EXCEPTION_PARSER_TYPENAMEEXPECTED();
                    static /*0xe5d3f8*/ string get_EXCEPTION_BIND_RENDERFAILED();
                    static /*0xe5d484*/ string get_EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE();
                    static /*0xe5d510*/ string get_EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE();
                    static /*0xe5d59c*/ string get_EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL();
                    static /*0xe5d628*/ string get_EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE();
                    static /*0xe5d6b4*/ string get_EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED();
                    static /*0xe53268*/ string get_EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT();
                    static /*0xe5d740*/ string get_EXCEPTION_PARSER_UNEXPECTEDTOKEN();
                    static /*0xe5d7cc*/ string get_EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE();
                    static /*0xe5d858*/ string get_EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES();
                    static /*0xe5d8e4*/ string get_EXCEPTION_BIND_RESTRICTED_MEMBER_INVOCATION();
                    static /*0xe5d970*/ string get_EXCEPTION_LIST_LISTISEMPTY();
                    static /*0xe5d9fc*/ string get_EXCEPTION_BIND_CALLMEMBERISNOTMETHOD();
                    static /*0xe5da88*/ string get_EXCEPTION_BIND_FAILEDTOBINDMEMBERBINDINGS();
                    static /*0xe5db14*/ string get_EXCEPTION_BIND_UNABLETOBINDMETHOD();
                    static /*0xe5b228*/ string get_EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME();
                    static /*0xe5dba0*/ string get_EXCEPTION_PARSER_COLONISEXPRECTED();
                    static /*0xe5dc2c*/ string get_EXCEPTION_BIND_UNABLETOBINDCALL();
                    static /*0xe5dcb8*/ string get_EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS();
                    static /*0xe5dd44*/ string get_EXCEPTION_BIND_UNKNOWNEXPRTYPE();
                    static /*0xe5ddd0*/ string get_EXCEPTION_BIND_FAILEDTOBINDNEWEXPRESSION();
                    static /*0xe5de5c*/ string get_EXCEPTION_BIND_FAILEDTOBIND();
                    static /*0xe5dee8*/ string get_EXCEPTION_BIND_UNABLETOBINDMEMBER();
                    static /*0xe5df74*/ string get_EXCEPTION_BIND_MISSINGMETHODPARAMETER();
                    static /*0xe55938*/ string get_EXCEPTION_BIND_MISSINGORWRONGARGUMENT();
                    static /*0xe5e000*/ string get_EXCEPTION_BIND_MEMBERISNOTMETHOD();
                    static /*0xe5e08c*/ string get_EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE();
                    static /*0xe5e118*/ string get_EXCEPTION_EXECUTION_CANTDONULLVALUE();
                    static /*0xe5e1a4*/ string get_EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ();
                    static /*0xe5e230*/ string get_EXCEPTION_PARSER_MISSING_OPERATOR();
                    static /*0xe5e2bc*/ string get_EXCEPTION_BIND_INVALIDLAMBDABODYTYPE();
                    static /*0xe5e348*/ string get_EXCEPTION_BIND_FAILEDTOBINDLISTINITIALIZERS();
                    static /*0xe5e3d4*/ string get_EXCEPTION_BIND_INVALIDCHARLITERAL();
                    static /*0xe5e460*/ string get_EXCEPTION_PARSER_EXPRESSIONISEMPTY();
                    static /*0xe5e4ec*/ string get_EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH();
                    static /*0xe5e578*/ string get_EXCEPTION_BIND_UNABLETORESOLVETYPE();
                    static /*0xe5b19c*/ string get_EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES();
                    static /*0xe5e604*/ string get_EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE();
                    static /*0xe5e690*/ string get_EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF();
                    static /*0xe5e71c*/ string get_EXCEPTION_PARSER_UNARYOPREQOPERAND();
                    static /*0xe5e7a8*/ string get_EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS();
                    static /*0xe5e834*/ string get_EXCEPTION_BIND_UNABLETORESOLVEMETHODONTYPE();
                    static /*0xe5e8c0*/ string get_EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS();
                    static /*0xe5e94c*/ string get_EXCEPTION_PARSER_TERNARYOPREQOPERAND();
                    static /*0xe5e9d8*/ string get_EXCEPTION_COMPIL_NOUNARYOPONTYPE();
                    static /*0xe5ea64*/ string get_EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION();
                    static /*0xe559c4*/ string get_EXCEPTION_BIND_TOOMANYARGUMENTS();
                    static /*0xe5eaf0*/ string get_EXCEPTION_EXECUTION_MULTIPARAMETERINDEXERNOTSUPPORTED();
                    static /*0xe5eb7c*/ string get_EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION();
                }
            }

            namespace Packing
            {
                class AnyPacker
                {
                    static /*0xe5ecc8*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.Expression expression);
                    static /*0xe61b20*/ object Pack(System.Type type);
                    static /*0xe62010*/ object Pack(System.Reflection.MemberInfo member);
                    static /*0xe62474*/ object Pack(System.Linq.Expressions.Expression[] arguments, string[] names);
                    static /*0xe61ea0*/ object Pack(System.Type[] typeArguments);
                }

                class ArrayIndexPacker
                {
                    static /*0xe5fc28*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.Expression expression);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Packing.ArrayIndexPacker.<> <>9;
                        static /*0x8*/ System.Converter<System.Reflection.ParameterInfo, string> <>9__0_0;

                        static /*0xe6265c*/ <>c();
                        /*0xe626c0*/ <>c();
                        /*0xe626c8*/ string <Pack>b__0_0(System.Reflection.ParameterInfo p);
                    }
                }

                class ArrayLengthPacker
                {
                    static /*0xe5fad0*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.UnaryExpression expression);
                }

                class BinaryPacker
                {
                    static /*0xe5f468*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.BinaryExpression expression);
                }

                class CallPacker
                {
                    static /*0xe60010*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MethodCallExpression expression);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Packing.CallPacker.<> <>9;
                        static /*0x8*/ System.Converter<System.Reflection.ParameterInfo, string> <>9__0_0;

                        static /*0xe626ec*/ <>c();
                        /*0xe62750*/ <>c();
                        /*0xe62758*/ string <Pack>b__0_0(System.Reflection.ParameterInfo p);
                    }
                }

                class ConditionPacker
                {
                    static /*0xe5f908*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.ConditionalExpression expression);
                }

                class ConstantPacker
                {
                    static /*0xe60304*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.ConstantExpression expression);
                }

                class ConvertPacker
                {
                    static /*0xe60490*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.UnaryExpression expression);
                }

                class InvokePacker
                {
                    static /*0xe60658*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.InvocationExpression expression);
                }

                class LambdaPacker
                {
                    static /*0xe6081c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.LambdaExpression expression);
                }

                class ListInitPacker
                {
                    static /*0xe60b00*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.ListInitExpression expression);
                }

                class MemberAccessPacker
                {
                    static /*0xe60c88*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MemberExpression expression);
                }

                class MemberInitPacker
                {
                    static /*0xe60e7c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MemberInitExpression expression);
                    static /*0xe62920*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> expressionBindings);
                    static /*0xe62eb4*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MemberListBinding memberListBinding);
                    static /*0xe62d2c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MemberMemberBinding memberMemberBinding);
                    static /*0xe62ba8*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.MemberAssignment memberAssignment);
                    static /*0xe6303c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.ElementInit elementInit);
                    static /*0xe6277c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> elementInitializers);
                }

                class NewArrayPacker
                {
                    static /*0xe612b8*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.NewArrayExpression expression);
                }

                class NewPacker
                {
                    static /*0xe61004*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.NewExpression expression);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Packing.NewPacker.<> <>9;
                        static /*0x8*/ System.Converter<System.Reflection.ParameterInfo, string> <>9__0_0;

                        static /*0xe631b4*/ <>c();
                        /*0xe63218*/ <>c();
                        /*0xe63220*/ string <Pack>b__0_0(System.Reflection.ParameterInfo p);
                    }
                }

                class ParameterPacker
                {
                    static /*0xe61520*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.ParameterExpression expression);
                }

                class QuotePacker
                {
                    static /*0xe616ac*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.UnaryExpression expression);
                }

                class TypeAsPacker
                {
                    static /*0xe61804*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.UnaryExpression expression);
                }

                class TypeIsPacker
                {
                    static /*0xe61998*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.TypeBinaryExpression expression);
                }

                class UnaryPacker
                {
                    static /*0xe5f21c*/ System.Collections.Generic.Dictionary<string, object> Pack(System.Linq.Expressions.UnaryExpression expression);
                }
            }

            namespace Execution
            {
                class AotCompiler
                {
                    static System.Func<ResultT> PrepareFunc<ResultT>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Func<Arg1T, ResultT> PrepareFunc<Arg1T, ResultT>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Func<Arg1T, Arg2T, ResultT> PrepareFunc<Arg1T, Arg2T, ResultT>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Func<Arg1T, Arg2T, Arg3T, ResultT> PrepareFunc<Arg1T, Arg2T, Arg3T, ResultT>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Func<Arg1T, Arg2T, Arg3T, Arg4T, ResultT> PrepareFunc<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static /*0xe63244*/ System.Action PrepareAction(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Action<Arg1T> PrepareAction<Arg1T>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Action<Arg1T, Arg2T> PrepareAction<Arg1T, Arg2T>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Action<Arg1T, Arg2T, Arg3T> PrepareAction<Arg1T, Arg2T, Arg3T>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static System.Action<Arg1T, Arg2T, Arg3T, Arg4T> PrepareAction<Arg1T, Arg2T, Arg3T, Arg4T>(System.Linq.Expressions.Expression body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters);
                    static /*0xe63534*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode Compile(System.Linq.Expressions.Expression expression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<> <>9;
                        static /*0x8*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__5_0;

                        static /*0xe64e58*/ <>c();
                        /*0xe64ebc*/ <>c();
                        /*0xe64ec4*/ object <PrepareAction>b__5_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__0<ResultT>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__0<ResultT> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__0_0;

                        static <>c__0();
                        <>c__0();
                        object <PrepareFunc>b__0_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__1<Arg1T, ResultT>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__1<Arg1T, ResultT> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__1_0;

                        static <>c__1();
                        <>c__1();
                        object <PrepareFunc>b__1_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__2<Arg1T, Arg2T, ResultT>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__2<Arg1T, Arg2T, ResultT> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__2_0;

                        static <>c__2();
                        <>c__2();
                        object <PrepareFunc>b__2_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__3<Arg1T, Arg2T, Arg3T, ResultT>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__3<Arg1T, Arg2T, Arg3T, ResultT> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__3_0;

                        static <>c__3();
                        <>c__3();
                        object <PrepareFunc>b__3_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__4<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__4<Arg1T, Arg2T, Arg3T, Arg4T, ResultT> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__4_0;

                        static <>c__4();
                        <>c__4();
                        object <PrepareFunc>b__4_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__6<Arg1T>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__6<Arg1T> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__6_0;

                        static <>c__6();
                        <>c__6();
                        object <PrepareAction>b__6_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__7<Arg1T, Arg2T>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__7<Arg1T, Arg2T> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__7_0;

                        static <>c__7();
                        <>c__7();
                        object <PrepareAction>b__7_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__8<Arg1T, Arg2T, Arg3T>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__8<Arg1T, Arg2T, Arg3T> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__8_0;

                        static <>c__8();
                        <>c__8();
                        object <PrepareAction>b__8_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__9<Arg1T, Arg2T, Arg3T, Arg4T>
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.AotCompiler.<>c__9<Arg1T, Arg2T, Arg3T, Arg4T> <>9;
                        static /*0x0*/ System.Converter<System.Linq.Expressions.ConstantExpression, object> <>9__9_0;

                        static <>c__9();
                        <>c__9();
                        object <PrepareAction>b__9_0(System.Linq.Expressions.ConstantExpression c);
                    }

                    class <>c__DisplayClass0_0<ResultT>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass0_0();
                        ResultT <PrepareFunc>b__1();
                    }

                    class <>c__DisplayClass1_0<Arg1T, ResultT>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass1_0();
                        ResultT <PrepareFunc>b__1(Arg1T arg1);
                    }

                    class <>c__DisplayClass2_0<Arg1T, Arg2T, ResultT>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass2_0();
                        ResultT <PrepareFunc>b__1(Arg1T arg1, Arg2T arg2);
                    }

                    class <>c__DisplayClass3_0<Arg1T, Arg2T, Arg3T, ResultT>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass3_0();
                        ResultT <PrepareFunc>b__1(Arg1T arg1, Arg2T arg2, Arg3T arg3);
                    }

                    class <>c__DisplayClass4_0<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass4_0();
                        ResultT <PrepareFunc>b__1(Arg1T arg1, Arg2T arg2, Arg3T arg3, Arg4T arg4);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ object[] constants;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        /*0xe634b0*/ <>c__DisplayClass5_0();
                        /*0xe64edc*/ void <PrepareAction>b__1();
                    }

                    class <>c__DisplayClass6_0<Arg1T>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass6_0();
                        void <PrepareAction>b__1(Arg1T arg1);
                    }

                    class <>c__DisplayClass7_0<Arg1T, Arg2T>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass7_0();
                        void <PrepareAction>b__1(Arg1T arg1, Arg2T arg2);
                    }

                    class <>c__DisplayClass8_0<Arg1T, Arg2T, Arg3T>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass8_0();
                        void <PrepareAction>b__1(Arg1T arg1, Arg2T arg2, Arg3T arg3);
                    }

                    class <>c__DisplayClass9_0<Arg1T, Arg2T, Arg3T, Arg4T>
                    {
                        /*0x0*/ object[] constants;
                        /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode compiledBody;

                        <>c__DisplayClass9_0();
                        void <PrepareAction>b__1(Arg1T arg1, Arg2T arg2, Arg3T arg3, Arg4T arg4);
                    }
                }

                class ArrayIndexNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.Expression expression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode indexNode;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Execution.CallNode methodCallNode;

                    /*0xe63f1c*/ ArrayIndexNode(System.Linq.Expressions.Expression expression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65048*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe651f8*/ string ToString();
                }

                class ArrayLengthNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.UnaryExpression unaryExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;

                    /*0xe645ec*/ ArrayLengthNode(System.Linq.Expressions.UnaryExpression unaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65218*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65330*/ string ToString();
                }

                class BinaryNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.BinaryExpression binaryExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode leftNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode rightNode;
                    /*0x28*/ bool isNullable;
                    /*0x30*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.BinaryOperation operation;
                    /*0x38*/ object shortcutLeftValue;

                    static /*0xe64208*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode Create(System.Linq.Expressions.BinaryExpression unaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65350*/ BinaryNode(System.Linq.Expressions.BinaryExpression binaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions, string binaryOperationMethodName);
                    /*0xe65704*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65a40*/ string ToString();
                }

                class CallNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.MethodCallExpression methodCallExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentNodes;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker fastCallInvoker;
                    /*0x30*/ bool isStatic;

                    /*0xe646d8*/ CallNode(System.Linq.Expressions.MethodCallExpression methodCallExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65b28*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65d58*/ string ToString();
                }

                class Closure
                {
                    /*0x10*/ object[] Constants;
                    /*0x18*/ object[] Locals;

                    /*0xe64f9c*/ Closure(object[] constants, object[] locals);
                    object Box<T>(T value);
                    T Unbox<T>(object boxed);
                    bool Is<T>(object boxed);
                    /*0xe65d78*/ System.Type GetType(object left);
                }

                class CoalesceNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.BinaryExpression binaryExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode leftNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode rightNode;

                    /*0xe64108*/ CoalesceNode(System.Linq.Expressions.BinaryExpression binaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65e00*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65e98*/ string ToString();
                }

                class ConditionalNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.ConditionalExpression conditionalExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode trueBranchNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode falseBranchNode;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode conditionTestNode;

                    /*0xe64940*/ ConditionalNode(System.Linq.Expressions.ConditionalExpression conditionalExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe65eb8*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65f4c*/ string ToString();
                }

                class ConstantNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.ConstantExpression constantExpression;
                    /*0x18*/ int constantIndex;

                    /*0xe64a5c*/ ConstantNode(System.Linq.Expressions.ConstantExpression constantExpression, System.Linq.Expressions.ConstantExpression[] constExpressions);
                    /*0xe65f6c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe65fa4*/ string ToString();
                }

                class ConstantsCollector : GameDevWare.Dynamic.Expressions.ExpressionVisitor
                {
                    /*0x10*/ System.Collections.Generic.List<System.Linq.Expressions.ConstantExpression> Constants;

                    /*0xe634b8*/ ConstantsCollector();
                    /*0xe65fc4*/ System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression constantExpression);
                }

                class ConvertNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.UnaryExpression convertExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode operandNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation operation;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription targetType;
                    /*0x30*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription sourceType;
                    /*0x38*/ bool isTargetTypeNullable;
                    /*0x39*/ bool isSourceTypeNullable;

                    /*0xe64b98*/ ConvertNode(System.Linq.Expressions.UnaryExpression convertExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe6606c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe66d64*/ string ToString();
                }

                class ExecutionNode
                {
                    static int LOCAL_OPERAND1 = 0;
                    static int LOCAL_OPERAND2 = 1;
                    static int LOCAL_SLOT1 = 2;
                    static int LOCAL_FIRST_PARAMETER = 3;

                    static /*0xe655bc*/ bool IsNullable(System.Linq.Expressions.Expression expression);
                    static /*0xe66d84*/ bool IsNullable(System.Type type);
                    /*0xe65040*/ ExecutionNode();
                    object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                }

                class FastCall
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker> StaticMethods;
                    static /*0x8*/ System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker> InstanceMethods;
                    static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<GameDevWare.Dynamic.Expressions.MethodCallSignature, GameDevWare.Dynamic.Expressions.Execution.FastCall.InvokeOperationCreator>[]> InstanceMethodCreators;
                    /*0x10*/ System.Delegate fn;

                    static /*0xe69410*/ FastCall();
                    static /*0xe65a60*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate(System.Reflection.MethodInfo method);
                    static /*0xe66e84*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreateStaticMethod(System.Reflection.MethodInfo method);
                    static /*0xe68f64*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreateInstanceMethod(System.Reflection.MethodInfo method);
                    static void RegisterInstanceMethod<InstanceT, Arg1T, Arg2T, Arg3T, ResultT>();
                    static void RegisterInstanceMethod<InstanceT, Arg1T, Arg2T, ResultT>();
                    static void RegisterInstanceMethod<InstanceT, Arg1T, ResultT>();
                    static void RegisterInstanceMethod<InstanceT, ResultT>();
                    static GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate<ResultT>(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    static GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate<Arg1T, ResultT>(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    static GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate<Arg1T, Arg2T, ResultT>(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    static GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate<Arg1T, Arg2T, Arg3T, ResultT>(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    static GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker TryCreate<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    /*0xe66df0*/ FastCall(System.Type delegateType, System.Reflection.MethodInfo method);
                    object FuncInvoker<ResultT>(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);
                    object FuncInvoker<Arg1T, ResultT>(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);
                    object FuncInvoker<Arg1T, Arg2T, ResultT>(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);
                    object FuncInvoker<Arg1T, Arg2T, Arg3T, ResultT>(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);
                    object FuncInvoker<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);

                    class Invoker : System.MulticastDelegate
                    {
                        /*0xe6a514*/ Invoker(object object, nint method);
                        /*0xe6a5ec*/ object Invoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns);
                        /*0xe6a600*/ System.IAsyncResult BeginInvoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentFns, System.AsyncCallback callback, object object);
                        /*0xe6a628*/ object EndInvoke(System.IAsyncResult result);
                    }

                    class InvokeOperationCreator : System.MulticastDelegate
                    {
                        /*0xe6a634*/ InvokeOperationCreator(object object, nint method);
                        /*0xe6a764*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker Invoke(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                        /*0xe6a778*/ System.IAsyncResult BeginInvoke(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.AsyncCallback callback, object object);
                        /*0xe6a7a0*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker EndInvoke(System.IAsyncResult result);
                    }
                }

                class Intrinsic
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<int, System.Delegate>> Operations;
                    static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<System.Type, System.Delegate>> Conversions;
                    static /*0x10*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] UnaryOperationArgumentNodes;
                    static /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] BinaryOperationArgumentNodes;

                    static /*0xe6a7ac*/ Intrinsic();
                    static /*0xe6bf58*/ object InvokeBinaryOperation(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right, System.Linq.Expressions.ExpressionType binaryOperationType, GameDevWare.Dynamic.Expressions.Execution.Intrinsic.BinaryOperation userDefinedBinaryOperation);
                    static /*0xe6c308*/ object InvokeUnaryOperation(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand, System.Linq.Expressions.ExpressionType unaryOperationType, GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation userDefinedUnaryOperation);
                    static /*0xe6c558*/ object InvokeConversion(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object value, System.Type toType, System.Linq.Expressions.ExpressionType convertType, GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation userDefinedConvertOperation);
                    static /*0xe6bd58*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation CreateUnaryOperationFn(System.Reflection.MethodInfo method);
                    static /*0xe6be58*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.BinaryOperation CreateBinaryOperationFn(System.Reflection.MethodInfo method);
                    static /*0xe6c81c*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation WrapUnaryOperation(System.Type type, string methodName);
                    static /*0xe6c918*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation WrapUnaryOperation(System.Reflection.MethodInfo method);
                    static /*0xe6cb00*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.BinaryOperation WrapBinaryOperation(System.Type type, string methodName);
                    static /*0xe6cbfc*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.BinaryOperation WrapBinaryOperation(System.Reflection.MethodInfo method);

                    class BinaryOperation : System.MulticastDelegate
                    {
                        /*0xe6cd0c*/ BinaryOperation(object object, nint method);
                        /*0xe6cde4*/ object Invoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        /*0xe6cdf8*/ System.IAsyncResult BeginInvoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right, System.AsyncCallback callback, object object);
                        /*0xe6ce24*/ object EndInvoke(System.IAsyncResult result);
                    }

                    class UnaryOperation : System.MulticastDelegate
                    {
                        /*0xe6ca28*/ UnaryOperation(object object, nint method);
                        /*0xe6ce30*/ object Invoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        /*0xe6ce44*/ System.IAsyncResult BeginInvoke(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand, System.AsyncCallback callback, object object);
                        /*0xe6ce6c*/ object EndInvoke(System.IAsyncResult result);
                    }

                    class op_Object
                    {
                        static /*0xe6ce78*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe6cecc*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6cf78*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6d028*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d080*/ object ToBoolean(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d0fc*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d178*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d1f4*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d270*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d2ec*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d368*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d3e4*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d460*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d4dc*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d554*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6d5cc*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Boolean
                    {
                        static /*0xe6d654*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe6d6a8*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6d728*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6d824*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6d924*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6d9c4*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6da64*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6db04*/ object AndAlso(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6dba8*/ object OrElse(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6dc4c*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe6dca4*/ object ToBoolean(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                    }

                    class op_Byte
                    {
                        static /*0xe6dd20*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe6dd74*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6ddf0*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6de78*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6def4*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6df70*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e00c*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e0b4*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e150*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e1f0*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e290*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e32c*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e3cc*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e46c*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e520*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e624*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e6d8*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e778*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e818*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e8bc*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6e958*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6ea00*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6eaa0*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6eb3c*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6ebd8*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6ec80*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6ecd8*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6edbc*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6ee64*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6ef0c*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6efb4*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f05c*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f104*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f1ac*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f254*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f300*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe6f3ac*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_SByte
                    {
                        static /*0xe6f498*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe6f4ec*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6f568*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6f5f0*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6f66c*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe6f6e8*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6f784*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6f82c*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6f8c8*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6f96c*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fa0c*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6faa8*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fb48*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fbe8*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fc9c*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fda8*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fe5c*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6fefc*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe6ff9c*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe70044*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe700e0*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe701b0*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe70250*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe702ec*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe70388*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7045c*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe704b4*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7055c*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70610*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe706b8*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7076c*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70814*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe708c8*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70970*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70a24*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70ad0*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe70b7c*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Int16
                    {
                        static /*0xe70c68*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe70cbc*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe70d38*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe70dc0*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe70e3c*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe70eb8*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe70f54*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe70ffc*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71098*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7113c*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe711dc*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71278*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71318*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe713b8*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7146c*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71578*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7162c*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe716cc*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7176c*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71814*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe718b0*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71980*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71a20*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71abc*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71b58*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe71c2c*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe71c84*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe71d6c*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe71e54*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe71efc*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe71fb0*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe72058*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7210c*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe721b4*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe72268*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe72314*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe723c0*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_UInt16
                    {
                        static /*0xe724ac*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe72500*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7257c*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe72604*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe72680*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe726fc*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72798*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72840*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe728dc*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7297c*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72a1c*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72ab8*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72b58*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72bf8*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72cac*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72db0*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72e64*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72f04*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe72fa4*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe73048*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe730e4*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe731b4*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe73254*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe732f0*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7338c*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe73434*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe7348c*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73578*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73664*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73748*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe737f0*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73898*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73940*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe739e8*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73a90*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73b3c*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe73be8*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Int32
                    {
                        static /*0xe73cd4*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe73d28*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe73da4*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe73e4c*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe73ec8*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe73f44*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe73fe0*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe740a4*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74140*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe741dc*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7427c*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74318*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe743b8*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74458*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe744f4*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74600*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7469c*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7473c*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe747dc*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7487c*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74918*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe749e0*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74a80*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74b1c*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74bb8*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe74c8c*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe74ce4*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe74dcc*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe74eb4*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe74f9c*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe75084*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7512c*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe751e0*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe75288*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7533c*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe753e4*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7548c*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_UInt32
                    {
                        static /*0xe75578*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe755cc*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe75648*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe756d0*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7574c*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe757c8*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75864*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75930*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe759cc*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75a68*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75b08*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75ba4*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75c44*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75ce4*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75d94*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75e98*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75f48*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe75fe8*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe76088*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe76128*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe761c4*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7628c*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7632c*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe763c8*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe76464*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe76530*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe76588*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76670*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76758*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76840*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76928*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76a0c*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76ab4*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76b5c*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76c04*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76cb0*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe76d58*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Int64
                    {
                        static /*0xe76e44*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe76e98*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe76f14*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe76fbc*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe77038*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe770b4*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77150*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77234*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe772d0*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7736c*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7740c*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe774a8*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77548*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe775e8*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77698*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe777a4*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77854*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe778f4*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77994*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77a38*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77ad4*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77bd0*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77c70*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77d0c*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77da8*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe77e88*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe77ee0*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe77fc8*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe780b0*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe78198*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe78280*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7836c*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe78458*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe78500*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe785b4*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7865c*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe78704*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_UInt64
                    {
                        static /*0xe787f0*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe78844*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe788c0*/ object Not(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7893c*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe789d8*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78aa0*/ object And(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78b3c*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78bd8*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78c78*/ object ExclusiveOr(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78d14*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78db4*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78e54*/ object LeftShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe78f04*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe79008*/ object RightShift(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe790b8*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe79158*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe791f8*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7929c*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe79338*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe79408*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe794a8*/ object Or(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe79544*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe795e0*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe796a0*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe796f8*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe797e0*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe798c8*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe799b0*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79a98*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79b80*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79c68*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79d4c*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79df4*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79ea0*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe79f48*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Single
                    {
                        static /*0xe7a034*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe7a088*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7a104*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7a180*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7a1f8*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a29c*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a340*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a3e4*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a48c*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a534*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a5dc*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a6d4*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a77c*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a824*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a8d0*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7a974*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7aa18*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7aac0*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7ab64*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7ac08*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7ac60*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7ad60*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7ae60*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7af60*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b060*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b168*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b270*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b374*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b478*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b51c*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7b5c4*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Double
                    {
                        static /*0xe7b6b4*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe7b708*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7b784*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7b800*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7b878*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7b91c*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7b9c0*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7ba64*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bb0c*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bbb4*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bc5c*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bd3c*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bde4*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7be8c*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bf38*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7bfdc*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7c080*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7c128*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7c1cc*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7c270*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object _);
                        static /*0xe7c2c8*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c3c8*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c4c8*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c5c8*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c6c8*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c7cc*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c8d0*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7c9d4*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7cad8*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7cb80*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7cc24*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class op_Decimal
                    {
                        static /*0xe7cd14*/ object Default(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                        static /*0xe7cd94*/ object Negate(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7ce60*/ object NegateChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7cf2c*/ object UnaryPlus(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        static /*0xe7cfb4*/ object Add(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d0ac*/ object AddChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d1a4*/ object Divide(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d29c*/ object Equal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d388*/ object GreaterThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d474*/ object GreaterThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d560*/ object Power(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d6a8*/ object LessThan(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d794*/ object LessThanOrEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d880*/ object Modulo(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7d978*/ object Multiply(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7da70*/ object MultiplyChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7db68*/ object NotEqual(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7dc54*/ object Subtract(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7dd4c*/ object SubtractChecked(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        static /*0xe7de44*/ object ToObject(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7de9c*/ object ToSByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7df80*/ object ToByte(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e064*/ object ToInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e148*/ object ToUInt16(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e22c*/ object ToInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e310*/ object ToUInt32(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e3f4*/ object ToInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e4d8*/ object ToUInt64(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e5bc*/ object ToSingle(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e69c*/ object ToDouble(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                        static /*0xe7e77c*/ object ToDecimal(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object isChecked);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker invoker;
                        /*0x18*/ System.Reflection.MethodInfo method;

                        /*0xe6ca20*/ <>c__DisplayClass13_0();
                        /*0xe7e830*/ object <WrapUnaryOperation>b__0(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                        /*0xe7e910*/ object <WrapUnaryOperation>b__1(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object operand);
                    }

                    class <>c__DisplayClass15_0
                    {
                        /*0x10*/ GameDevWare.Dynamic.Expressions.Execution.FastCall.Invoker invoker;
                        /*0x18*/ System.Reflection.MethodInfo method;

                        /*0xe6cd04*/ <>c__DisplayClass15_0();
                        /*0xe7e9c0*/ object <WrapBinaryOperation>b__0(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                        /*0xe7eaec*/ object <WrapBinaryOperation>b__1(GameDevWare.Dynamic.Expressions.Execution.Closure closure, object left, object right);
                    }
                }

                class InvocationNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.InvocationExpression invocationExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode target;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] argumentNodes;

                    /*0xe7ebc8*/ InvocationNode(System.Linq.Expressions.InvocationExpression invocationExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe7eddc*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe7efdc*/ string ToString();
                }

                class LambdaNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.LambdaExpression lambdaExpression;
                    /*0x18*/ System.Linq.Expressions.ParameterExpression[] parameterExpressions;
                    /*0x20*/ System.Reflection.MethodInfo prepareMethod;

                    /*0xe7effc*/ LambdaNode(System.Linq.Expressions.LambdaExpression lambdaExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe7f3e8*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe7f664*/ string ToString();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ System.Type[] funcArguments;

                        /*0xe7f3e0*/ <>c__DisplayClass3_0();
                        /*0xe7f684*/ bool <.ctor>b__0(System.Reflection.MethodInfo m);
                    }
                }

                class ListInitNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.ListInitExpression listInitExpression;
                    /*0x18*/ System.Collections.Generic.KeyValuePair<System.Reflection.MethodInfo, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[]> initializationNodes;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.NewNode newNode;

                    /*0xe7f72c*/ ListInitNode(System.Linq.Expressions.ListInitExpression listInitExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe7fca4*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe7fe78*/ string ToString();
                }

                class LocalNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.LocalNode Operand1;
                    static /*0x8*/ GameDevWare.Dynamic.Expressions.Execution.LocalNode Operand2;
                    /*0x10*/ int localIndex;

                    static /*0xe7ff68*/ LocalNode();
                    /*0xe7fe98*/ LocalNode(int localIndex);
                    /*0xe7ff10*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe7ff48*/ string ToString();
                }

                class MemberAccessNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.MemberExpression memberExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;
                    /*0x20*/ System.Reflection.FieldInfo fieldInfo;
                    /*0x28*/ System.Reflection.MethodInfo propertyGetter;
                    /*0x30*/ bool isStatic;

                    /*0xe7fffc*/ MemberAccessNode(System.Linq.Expressions.MemberExpression memberExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe801f4*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe80398*/ string ToString();
                }

                class MemberAssignmentsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode Empty;
                    /*0x10*/ GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode.PreparedMemberAssignment[] memberAssignments;

                    static /*0xe80c24*/ MemberAssignmentsNode();
                    /*0xe803b8*/ MemberAssignmentsNode(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> bindings, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe8086c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe80ae4*/ string ToString();

                    struct PreparedMemberAssignment
                    {
                        /*0x10*/ System.Reflection.MemberInfo Member;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode ValueNode;

                        /*0xe80864*/ PreparedMemberAssignment(System.Reflection.MemberInfo member, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode valueNode);
                    }

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode.<> <>9;
                        static /*0x8*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__3_0;
                        static /*0x10*/ System.Func<GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode.PreparedMemberAssignment, string> <>9__5_0;

                        static /*0xe80d54*/ <>c();
                        /*0xe80db8*/ <>c();
                        /*0xe80dc0*/ bool <.ctor>b__3_0(System.Linq.Expressions.MemberBinding b);
                        /*0xe80e1c*/ string <ToString>b__5_0(GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode.PreparedMemberAssignment m);
                    }
                }

                class MemberInitNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.MemberInitExpression memberInitExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.NewNode newNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode memberAssignmentNode;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode listBindingNode;
                    /*0x30*/ GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode memberMemberBindingNode;

                    /*0xe80e40*/ MemberInitNode(System.Linq.Expressions.MemberInitExpression memberInitExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe825dc*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe82808*/ string ToString();

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberInitNode.<> <>9;
                        static /*0x8*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__5_0;
                        static /*0x10*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__5_1;
                        static /*0x18*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__5_2;

                        static /*0xe82828*/ <>c();
                        /*0xe8288c*/ <>c();
                        /*0xe82894*/ bool <.ctor>b__5_0(System.Linq.Expressions.MemberBinding b);
                        /*0xe828f0*/ bool <.ctor>b__5_1(System.Linq.Expressions.MemberBinding b);
                        /*0xe8294c*/ bool <.ctor>b__5_2(System.Linq.Expressions.MemberBinding b);
                    }
                }

                class MemberListBindingsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode Empty;
                    /*0x10*/ System.Linq.ILookup<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.PreparedListBinding> bindingsByMember;

                    static /*0xe83530*/ MemberListBindingsNode();
                    /*0xe81288*/ MemberListBindingsNode(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> bindings, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe829b4*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe833f0*/ string ToString();

                    struct PreparedListBinding
                    {
                        /*0x10*/ System.Reflection.MemberInfo Member;
                        /*0x18*/ System.Reflection.MethodInfo AddMethod;
                        /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] AddMethodArguments;

                        /*0xe829a8*/ PreparedListBinding(System.Reflection.MemberInfo member, System.Reflection.MethodInfo addMethod, GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] addArguments);
                    }

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.<> <>9;
                        static /*0x8*/ System.Func<System.Linq.Expressions.MemberBinding, int> <>9__3_0;
                        static /*0x10*/ System.Func<GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.PreparedListBinding, System.Reflection.MemberInfo> <>9__3_1;
                        static /*0x18*/ System.Func<System.Linq.IGrouping<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.PreparedListBinding>, string> <>9__5_0;

                        static /*0xe83660*/ <>c();
                        /*0xe836c4*/ <>c();
                        /*0xe836cc*/ int <.ctor>b__3_0(System.Linq.Expressions.MemberBinding b);
                        /*0xe83754*/ System.Reflection.MemberInfo <.ctor>b__3_1(GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.PreparedListBinding b);
                        /*0xe8375c*/ string <ToString>b__5_0(System.Linq.IGrouping<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode.PreparedListBinding> m);
                    }
                }

                class MemberMemberBindingsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode Empty;
                    /*0x10*/ System.Linq.ILookup<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.PreparedMemberBinding> bindingsByMember;

                    static /*0xe844a0*/ MemberMemberBindingsNode();
                    /*0xe81bf4*/ MemberMemberBindingsNode(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> bindings, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe83818*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe84360*/ string ToString();

                    struct PreparedMemberBinding
                    {
                        /*0x10*/ System.Reflection.MemberInfo Member;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode MemberAssignments;
                        /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode MemberListBindings;
                        /*0x28*/ GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode MemberMemberBindings;

                        /*0xe8380c*/ PreparedMemberBinding(System.Reflection.MemberInfo member, GameDevWare.Dynamic.Expressions.Execution.MemberAssignmentsNode memberAssignments, GameDevWare.Dynamic.Expressions.Execution.MemberListBindingsNode memberListBindings, GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode memberMemberBindings);
                    }

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.<> <>9;
                        static /*0x8*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__3_0;
                        static /*0x10*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__3_2;
                        static /*0x18*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__3_3;
                        static /*0x20*/ System.Func<System.Linq.Expressions.MemberBinding, bool> <>9__3_4;
                        static /*0x28*/ System.Func<GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.PreparedMemberBinding, System.Reflection.MemberInfo> <>9__3_1;
                        static /*0x30*/ System.Func<System.Linq.IGrouping<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.PreparedMemberBinding>, string> <>9__5_0;

                        static /*0xe845d0*/ <>c();
                        /*0xe84634*/ <>c();
                        /*0xe8463c*/ bool <.ctor>b__3_0(System.Linq.Expressions.MemberBinding b);
                        /*0xe84698*/ bool <.ctor>b__3_2(System.Linq.Expressions.MemberBinding b);
                        /*0xe846f4*/ bool <.ctor>b__3_3(System.Linq.Expressions.MemberBinding b);
                        /*0xe84750*/ bool <.ctor>b__3_4(System.Linq.Expressions.MemberBinding b);
                        /*0xe847ac*/ System.Reflection.MemberInfo <.ctor>b__3_1(GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.PreparedMemberBinding b);
                        /*0xe847b4*/ string <ToString>b__5_0(System.Linq.IGrouping<System.Reflection.MemberInfo, GameDevWare.Dynamic.Expressions.Execution.MemberMemberBindingsNode.PreparedMemberBinding> m);
                    }
                }

                class NewArrayBoundsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.NewArrayExpression newArrayExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] rankNodes;

                    /*0xe84864*/ NewArrayBoundsNode(System.Linq.Expressions.NewArrayExpression newArrayExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe84a50*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe84b80*/ string ToString();
                }

                class NewArrayInitNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.NewArrayExpression newArrayExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] initializationValueNodes;

                    /*0xe84ba0*/ NewArrayInitNode(System.Linq.Expressions.NewArrayExpression newArrayExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe84d8c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe84e98*/ string ToString();
                }

                class NewNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ object[] EmptyArguments;
                    /*0x10*/ System.Linq.Expressions.NewExpression newExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode[] initializationValueNodes;
                    /*0x20*/ int constructorParametersCount;
                    /*0x24*/ bool isNullableType;

                    static /*0xe85100*/ NewNode();
                    /*0xe7fa64*/ NewNode(System.Linq.Expressions.NewExpression newExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe84eb8*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe850e0*/ string ToString();
                }

                class NullNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Execution.NullNode Instance;

                    static /*0xe851b8*/ NullNode();
                    /*0xe851b0*/ NullNode();
                    /*0xe85168*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe85170*/ string ToString();
                }

                class ParameterNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.ParameterExpression parameterExpression;
                    /*0x18*/ int parameterIndex;

                    /*0xe8521c*/ ParameterNode(System.Linq.Expressions.ParameterExpression parameterExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe85358*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe85394*/ string ToString();
                }

                class QuoteNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.UnaryExpression unaryExpression;

                    /*0xe853b4*/ QuoteNode(System.Linq.Expressions.UnaryExpression unaryExpression);
                    /*0xe8542c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe85448*/ string ToString();
                }

                class TypeAsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.UnaryExpression typeAsExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ConvertNode convertNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;
                    /*0x28*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription targetType;

                    /*0xe85468*/ TypeAsNode(System.Linq.Expressions.UnaryExpression typeAsExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe8560c*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe856d0*/ string ToString();
                }

                class TypeIsNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.TypeBinaryExpression typeBinaryExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode targetNode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription targetType;

                    /*0xe856f0*/ TypeIsNode(System.Linq.Expressions.TypeBinaryExpression typeBinaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe85830*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe8592c*/ string ToString();
                }

                class UnaryNode : GameDevWare.Dynamic.Expressions.Execution.ExecutionNode
                {
                    /*0x10*/ System.Linq.Expressions.UnaryExpression unaryExpression;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Execution.Intrinsic.UnaryOperation operation;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode operandNode;
                    /*0x28*/ bool isNullable;

                    static /*0xe85bc0*/ GameDevWare.Dynamic.Expressions.Execution.ExecutionNode Create(System.Linq.Expressions.UnaryExpression unaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
                    /*0xe8594c*/ UnaryNode(System.Linq.Expressions.UnaryExpression unaryExpression, System.Linq.Expressions.ConstantExpression[] constExpressions, System.Linq.Expressions.ParameterExpression[] parameterExpressions, string unaryOperationMethodName);
                    /*0xe85af4*/ object Run(GameDevWare.Dynamic.Expressions.Execution.Closure closure);
                    /*0xe85d5c*/ string ToString();
                }
            }

            namespace CSharp
            {
                class CSharpExpression
                {
                    static bool DEFAULT_CHECKED_SCOPE = true;
                    static string ARG1_DEFAULT_NAME = "arg1";
                    static string ARG2_DEFAULT_NAME = "arg2";
                    static string ARG3_DEFAULT_NAME = "arg3";
                    static string ARG4_DEFAULT_NAME = "arg4";

                    static ResultT Evaluate<ResultT>(string expression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static ResultT Evaluate<Arg1T, ResultT>(string expression, Arg1T arg1, string arg1Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static ResultT Evaluate<Arg1T, Arg2T, ResultT>(string expression, Arg1T arg1, Arg2T arg2, string arg1Name, string arg2Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static ResultT Evaluate<Arg1T, Arg2T, Arg3T, ResultT>(string expression, Arg1T arg1, Arg2T arg2, Arg3T arg3, string arg1Name, string arg2Name, string arg3Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static ResultT Evaluate<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(string expression, Arg1T arg1, Arg2T arg2, Arg3T arg3, Arg4T arg4, string arg1Name, string arg2Name, string arg3Name, string arg4Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static /*0xe85d7c*/ void Execute(string expression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static void Execute<Arg1T>(string expression, Arg1T arg1, string arg1Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static void Execute<Arg1T, Arg2T>(string expression, Arg1T arg1, Arg2T arg2, string arg1Name, string arg2Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static void Execute<Arg1T, Arg2T, Arg3T>(string expression, Arg1T arg1, Arg2T arg2, Arg3T arg3, string arg1Name, string arg2Name, string arg3Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static void Execute<Arg1T, Arg2T, Arg3T, Arg4T>(string expression, Arg1T arg1, Arg2T arg2, Arg3T arg3, Arg4T arg4, string arg1Name, string arg2Name, string arg3Name, string arg4Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Func<ResultT>> Parse<ResultT>(string expression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, ResultT>> Parse<Arg1T, ResultT>(string expression, string arg1Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, ResultT>> Parse<Arg1T, Arg2T, ResultT>(string expression, string arg1Name, string arg2Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, Arg3T, ResultT>> Parse<Arg1T, Arg2T, Arg3T, ResultT>(string expression, string arg1Name, string arg2Name, string arg3Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>> Parse<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(string expression, string arg1Name, string arg2Name, string arg3Name, string arg4Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver);
                    static System.Linq.Expressions.Expression<System.Func<ResultT>> ParseFunc<ResultT>(string expression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, ResultT>> ParseFunc<Arg1T, ResultT>(string expression, string arg1Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, ResultT>> ParseFunc<Arg1T, Arg2T, ResultT>(string expression, string arg1Name, string arg2Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, Arg3T, ResultT>> ParseFunc<Arg1T, Arg2T, Arg3T, ResultT>(string expression, string arg1Name, string arg2Name, string arg3Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Func<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>> ParseFunc<Arg1T, Arg2T, Arg3T, Arg4T, ResultT>(string expression, string arg1Name, string arg2Name, string arg3Name, string arg4Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static /*0xe85db0*/ System.Linq.Expressions.Expression<System.Action> ParseAction(string expression, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Action<Arg1T>> ParseAction<Arg1T>(string expression, string arg1Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Action<Arg1T, Arg2T>> ParseAction<Arg1T, Arg2T>(string expression, string arg1Name, string arg2Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Action<Arg1T, Arg2T, Arg3T>> ParseAction<Arg1T, Arg2T, Arg3T>(string expression, string arg1Name, string arg2Name, string arg3Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static System.Linq.Expressions.Expression<System.Action<Arg1T, Arg2T, Arg3T, Arg4T>> ParseAction<Arg1T, Arg2T, Arg3T, Arg4T>(string expression, string arg1Name, string arg2Name, string arg3Name, string arg4Name, GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Linq.Expressions.Expression global);
                    static /*0xe86038*/ string Format(System.Linq.Expressions.Expression expression, bool checkedScope);
                    static /*0xe86110*/ string Format(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, bool checkedScope);
                }

                class CSharpExpressionFormatter
                {
                    static /*0xe8611c*/ string Render(System.Linq.Expressions.Expression expression, bool checkedScope);
                    static /*0xe86040*/ string Format(System.Linq.Expressions.Expression expression, bool checkedScope);
                    static /*0xe86124*/ void Render(System.Linq.Expressions.Expression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe87918*/ void RenderCondition(System.Linq.Expressions.ConditionalExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8a818*/ void RenderNullPropagationExpression(System.Linq.Expressions.Expression expression, System.Text.StringBuilder builder, System.Collections.Generic.List<System.Linq.Expressions.Expression> nullPropagationExpressions, bool checkedScope);
                    static /*0xe87ab0*/ void RenderConvert(System.Linq.Expressions.UnaryExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8a17c*/ void RenderNewArray(System.Linq.Expressions.NewArrayExpression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe89d7c*/ void RenderMemberInit(System.Linq.Expressions.MemberInitExpression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8997c*/ void RenderListInit(System.Linq.Expressions.ListInitExpression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe88e80*/ void RenderLambda(System.Linq.Expressions.LambdaExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8935c*/ void RenderNew(System.Linq.Expressions.NewExpression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe88b58*/ void RenderMemberAccess(System.Linq.Expressions.MemberExpression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8736c*/ void RenderCall(System.Linq.Expressions.MethodCallExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe87064*/ void RenderArrayIndex(System.Linq.Expressions.Expression expression, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe88018*/ void RenderConstant(System.Linq.Expressions.ConstantExpression expression, System.Text.StringBuilder builder);
                    static /*0xe86d54*/ void RenderUnary(System.Linq.Expressions.UnaryExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe86934*/ void RenderBinary(System.Linq.Expressions.BinaryExpression expression, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe87cc8*/ void RenderArguments(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> arguments, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8ad68*/ void RenderMemberBinding(System.Linq.Expressions.MemberBinding memberBinding, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8b4e0*/ void RenderListInitializer(System.Linq.Expressions.ElementInit initializer, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe88da4*/ void RenderType(System.Type type, System.Text.StringBuilder builder);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.CSharp.CSharpExpressionFormatter.<> <>9;
                        static /*0x8*/ System.Func<System.Linq.Expressions.Expression, bool> <>9__12_0;

                        static /*0xe8c920*/ <>c();
                        /*0xe8c984*/ <>c();
                        /*0xe8c98c*/ bool <RenderCall>b__12_0(System.Linq.Expressions.Expression a);
                    }
                }

                class CSharpSyntaxTreeFormatter
                {
                    static /*0xe8ca8c*/ string Render(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, bool checkedScope);
                    static /*0xe8ca94*/ string Format(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, bool checkedScope);
                    static /*0xe8cb64*/ void Render(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8dc50*/ void RenderArrayLength(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe908e4*/ void RenderTypeBinary(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe90410*/ void RenderCondition(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8f88c*/ void RenderBinary(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8f3ec*/ void RenderUnary(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8f1f4*/ void RenderNew(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8f0e0*/ void RenderDefault(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder);
                    static /*0xe8efcc*/ void RenderTypeOf(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder);
                    static /*0xe8ed64*/ void RenderPropertyOrField(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe8e2dc*/ void RenderConstant(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder);
                    static /*0xe8df54*/ void RenderGroup(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe8dd44*/ void RenderInvokeOrIndex(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe90c8c*/ void RenderLambda(GameDevWare.Dynamic.Expressions.SyntaxTreeNode syntaxTree, System.Text.StringBuilder builder, bool wrapped, bool checkedScope);
                    static /*0xe912fc*/ void RenderArguments(GameDevWare.Dynamic.Expressions.ArgumentsTree arguments, System.Text.StringBuilder builder, bool checkedScope);
                    static /*0xe91178*/ void RenderTypeName(object typeName, System.Text.StringBuilder builder);
                    static /*0xe91c60*/ void RenderTextLiteral(string value, System.Text.StringBuilder builder, bool isChar);
                    static /*0xe91b4c*/ bool IsObjectType(object typeObj);
                }

                class CSharpTypeNameAlias
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<string, string> TypeNameByAlias;
                    static /*0x8*/ System.Collections.Generic.Dictionary<string, string> AliasByTypeName;

                    static /*0xe91ee8*/ CSharpTypeNameAlias();
                    static /*0xe92678*/ bool TryGetTypeName(string alias, ref string typeName);
                    static /*0xe92750*/ bool TryGetAlias(string typeName, ref string alias);
                    static /*0xe92828*/ bool TryGetAlias(System.Type typeInfo, ref string alias);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.CSharp.CSharpTypeNameAlias.<> <>9;

                        static /*0xe928f0*/ <>c();
                        /*0xe92954*/ <>c();
                        /*0xe9295c*/ string <.cctor>b__2_0(System.Collections.Generic.KeyValuePair<string, string> kv);
                        /*0xe92998*/ string <.cctor>b__2_1(System.Collections.Generic.KeyValuePair<string, string> kv);
                    }
                }

                class ListExtensions
                {
                    static T Dequeue<T>(System.Collections.Generic.List<T> list);
                    static T Pop<T>(System.Collections.Generic.List<T> list);
                }

                class Parser
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, int> UnaryReplacement;
                    static /*0x8*/ System.Collections.Generic.Dictionary<int, int> TokenPrecedence;
                    static /*0x10*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] ConditionTerm;
                    static /*0x18*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] NewTerm;
                    static /*0x20*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] GeneticArgumentsTerm;
                    static /*0x28*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] CommonTerm;
                    static /*0x30*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] NullableTerm;
                    /*0x10*/ System.Collections.Generic.List<GameDevWare.Dynamic.Expressions.CSharp.Token> tokens;
                    /*0x18*/ System.Collections.Generic.Stack<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode> stack;

                    static /*0xe929d4*/ Parser();
                    static /*0xe93418*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode Parse(System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.Token> tokens);
                    static /*0xe953d0*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType[] UnionTerminators(GameDevWare.Dynamic.Expressions.CSharp.TokenType[] first, GameDevWare.Dynamic.Expressions.CSharp.TokenType[] second);
                    /*0xe932a8*/ Parser(System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.Token> tokens);
                    /*0xe935f8*/ bool Expression(GameDevWare.Dynamic.Expressions.CSharp.TokenType operator, GameDevWare.Dynamic.Expressions.CSharp.TokenType[] terminator);
                    /*0xe957b4*/ bool TryMakeGenericArguments(GameDevWare.Dynamic.Expressions.CSharp.Token currentToken);
                    /*0xe96000*/ bool TryMakeNullableType(GameDevWare.Dynamic.Expressions.CSharp.Token currentToken);
                    /*0xe962ec*/ int FindConditionClosingToken();
                    /*0xe96574*/ int FindGenericArgClosingToken();
                    /*0xe95550*/ void CheckAndConsumeToken(GameDevWare.Dynamic.Expressions.CSharp.TokenType expectedType1, GameDevWare.Dynamic.Expressions.CSharp.TokenType expectedType2);
                    /*0xe95288*/ void CombineUnary(GameDevWare.Dynamic.Expressions.CSharp.Token operation);
                    /*0xe95dd0*/ void CombineBinary(GameDevWare.Dynamic.Expressions.CSharp.Token operation);
                    /*0xe963dc*/ void CombineTernary(GameDevWare.Dynamic.Expressions.CSharp.Token operation);
                    /*0xe95cdc*/ int ComputePrecedence(GameDevWare.Dynamic.Expressions.CSharp.TokenType tokenType1, GameDevWare.Dynamic.Expressions.CSharp.TokenType tokenType2);

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node;

                        /*0xe94f28*/ <>c__DisplayClass12_0();
                        /*0xe96684*/ bool <Expression>b__0(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode n);
                    }
                }

                class ParseTreeNode : GameDevWare.Dynamic.Expressions.ILineInfo, System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode>, System.Collections.IEnumerable
                {
                    /*0x10*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode.ParseTreeNodes nodes;
                    /*0x38*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType Type;
                    /*0x40*/ GameDevWare.Dynamic.Expressions.CSharp.Token Token;
                    /*0x60*/ string Value;

                    /*0xe96790*/ ParseTreeNode(GameDevWare.Dynamic.Expressions.CSharp.TokenType type, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode otherNode);
                    /*0xe94f44*/ ParseTreeNode(GameDevWare.Dynamic.Expressions.CSharp.Token token, System.Nullable<GameDevWare.Dynamic.Expressions.CSharp.TokenType> type, string value, System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode> nodes);
                    /*0xe95f4c*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode get_Item(int index);
                    /*0xe95f44*/ int get_Count();
                    /*0xe96778*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetLineNumber();
                    /*0xe96780*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetColumnNumber();
                    /*0xe96788*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetTokenLength();
                    /*0xe95fc4*/ void Add(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node);
                    /*0xe95fcc*/ void Replace(int index, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node);
                    /*0xe95f54*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode WithOtherType(GameDevWare.Dynamic.Expressions.CSharp.TokenType newType);
                    /*0xe97090*/ void Write(System.Text.StringBuilder sb, int depth);
                    /*0xe971dc*/ System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode> System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode>.GetEnumerator();
                    /*0xe9726c*/ string ToString();
                    /*0xe972e4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    struct ParseTreeNodes
                    {
                        /*0x10*/ int Count;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item0;
                        /*0x20*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item1;
                        /*0x28*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item2;
                        /*0x30*/ System.Collections.Generic.List<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode> items;

                        static /*0xe9682c*/ void Add(ref GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode.ParseTreeNodes nodes, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node);
                        static /*0xe96cc8*/ void Insert(ref GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode.ParseTreeNodes nodes, int index, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node);
                        static /*0xe96ba0*/ void RemoveAt(ref GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode.ParseTreeNodes nodes, int index);
                        static /*0xe974cc*/ bool Remove(ref GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode.ParseTreeNodes nodes, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode node);
                        /*0xe97378*/ ParseTreeNodes(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item0, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item1, GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode item2);
                        /*0xe97430*/ ParseTreeNodes(System.Collections.Generic.List<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode> items);
                        /*0xe96694*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode get_Item(int index);
                        /*0xe97604*/ string ToString();
                    }

                    class <System-Collections-Generic-IEnumerable<GameDevWare-Dynamic-Expressions-CSharp-ParseTreeNode>-GetEnumerator>d__18 : System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode <>2__current;
                        /*0x20*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode <>4__this;
                        /*0x28*/ int <i>5__1;

                        /*0xe97244*/ <System-Collections-Generic-IEnumerable<GameDevWare-Dynamic-Expressions-CSharp-ParseTreeNode>-GetEnumerator>d__18(int <>1__state);
                        /*0xe97624*/ void System.IDisposable.Dispose();
                        /*0xe97628*/ bool MoveNext();
                        /*0xe976a4*/ GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode>.get_Current();
                        /*0xe976ac*/ void System.Collections.IEnumerator.Reset();
                        /*0xe976ec*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class StringUtils
                {
                    static /*0xe976f4*/ string UnescapeAndUnquote(string stringToUnescape);
                    static /*0xe97c00*/ int StringToInt32(string value, int offset, int count, System.IFormatProvider formatProvider);
                    static /*0xe97b18*/ uint HexStringToUInt32(string value, int offset, int count);
                    /*0xe97d58*/ StringUtils();
                }

                class SyntaxTreeBuilder
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, string> ExpressionTypeByToken;

                    static /*0xe97d60*/ SyntaxTreeBuilder();
                    static /*0xe98474*/ GameDevWare.Dynamic.Expressions.SyntaxTreeNode ToSyntaxTree(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, string cSharpExpression);
                    static /*0xe9ab88*/ void ToNewNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe9a910*/ void ToCallNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe9a800*/ void ToLambdaNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe9a69c*/ void ToConditionalNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe9a4c0*/ void ToBinaryNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe998a0*/ void ToConvertNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe995d4*/ void ToNumberNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe99148*/ void ToIdentifierNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe98f4c*/ void ToResolveNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, bool checkedScope, System.Collections.Generic.Dictionary<string, object> syntaxNode);
                    static /*0xe99e14*/ object ToTypeName(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, GameDevWare.Dynamic.Expressions.CSharp.SyntaxTreeBuilder.TypeNameOptions options);
                    static /*0xe9add8*/ System.Collections.Generic.Dictionary<string, object> PrepareArguments(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, int argumentChildIndex, bool checkedScope);
                    static /*0xe9b008*/ System.Collections.Generic.Dictionary<string, object> PrepareTypeArguments(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, int argumentChildIndex);
                    static /*0xe99a48*/ void CheckNode(GameDevWare.Dynamic.Expressions.CSharp.ParseTreeNode parseNode, int childCount, GameDevWare.Dynamic.Expressions.CSharp.TokenType childType0, GameDevWare.Dynamic.Expressions.CSharp.TokenType childType1, GameDevWare.Dynamic.Expressions.CSharp.TokenType childType2);
                    static /*0xe994ac*/ object UnescapeAndUnquote(string value, GameDevWare.Dynamic.Expressions.CSharp.Token token);

                    enum TypeNameOptions
                    {
                        None = 0,
                        Aliases = 1,
                        ShortNames = 2,
                        Arrays = 4,
                        All = 7,
                    }
                }

                struct Token : GameDevWare.Dynamic.Expressions.ILineInfo
                {
                    /*0x10*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType Type;
                    /*0x18*/ string Value;
                    /*0x20*/ int LineNumber;
                    /*0x24*/ int ColumnNumber;
                    /*0x28*/ int TokenLength;

                    /*0xe94f30*/ Token(GameDevWare.Dynamic.Expressions.CSharp.TokenType type, string value, int line, int col, int len);
                    /*0xe9b1b4*/ bool get_IsValid();
                    /*0xe9ad30*/ string get_Position();
                    /*0xe9b1c4*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetLineNumber();
                    /*0xe9b1cc*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetColumnNumber();
                    /*0xe9b1d4*/ int GameDevWare.Dynamic.Expressions.ILineInfo.GetTokenLength();
                    /*0xe9b1dc*/ string ToString();
                }

                class TokenAttribute : System.Attribute
                {
                    /*0x10*/ string <Value>k__BackingField;

                    /*0xe9b2d0*/ TokenAttribute(string value);
                    /*0xe9b2c0*/ string get_Value();
                    /*0xe9b2c8*/ void set_Value(string value);
                }

                class Tokenizer
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<string, GameDevWare.Dynamic.Expressions.CSharp.TokenType> TokensBySymbols;
                    static /*0x8*/ string[] Symbols;
                    static /*0x10*/ bool[] IsLiteralSymbol;
                    static /*0x18*/ short[] TerminationCharacter;

                    static /*0xe9b2f8*/ Tokenizer();
                    static /*0xe9b83c*/ System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.Token> Tokenize(string expression);
                    static /*0xe9b8e4*/ bool IsMatching(string expression, int offset, string tokenToMatch, bool isLiteralToken);
                    static /*0xe9ba10*/ GameDevWare.Dynamic.Expressions.CSharp.Token LookForIdentifier(string expression, int offset, int line, int col);
                    static /*0xe9c0d4*/ GameDevWare.Dynamic.Expressions.CSharp.Token LookForLiteral(string expression, char termChar, int offset, int line, int col);
                    static /*0xe9c1e4*/ GameDevWare.Dynamic.Expressions.CSharp.Token LookForNumber(string expression, int offset, int line, int col);
                    static /*0xe9c00c*/ bool IsTerminationCharacter(char value);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.CSharp.Tokenizer.<> <>9;

                        static /*0xe9c6a4*/ <>c();
                        /*0xe9c708*/ <>c();
                        /*0xe9c710*/ System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.TokenAttribute> <.cctor>b__4_0(System.Reflection.FieldInfo field);
                        /*0xe9c7c8*/ System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.CSharp.TokenType> <.cctor>b__4_1(System.Reflection.FieldInfo field, GameDevWare.Dynamic.Expressions.CSharp.TokenAttribute tokenAttribute);
                        /*0xe9c91c*/ string <.cctor>b__4_2(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.CSharp.TokenType> kv);
                        /*0xe9c958*/ GameDevWare.Dynamic.Expressions.CSharp.TokenType <.cctor>b__4_3(System.Collections.Generic.KeyValuePair<string, GameDevWare.Dynamic.Expressions.CSharp.TokenType> kv);
                        /*0xe9c994*/ bool <.cctor>b__4_4(string s);
                        /*0xe9ca2c*/ char <.cctor>b__4_5(string s);
                        /*0xe9ca48*/ bool <.cctor>b__4_6(char c);
                        /*0xe9caac*/ short <.cctor>b__4_7(char c);
                    }

                    class <Tokenize>d__5 : System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.Token>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.Token>, System.IDisposable, System.Collections.IEnumerator
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ GameDevWare.Dynamic.Expressions.CSharp.Token <>2__current;
                        /*0x38*/ int <>l__initialThreadId;
                        /*0x40*/ string expression;
                        /*0x48*/ string <>3__expression;
                        /*0x50*/ int <line>5__1;
                        /*0x54*/ int <col>5__2;
                        /*0x58*/ int <i>5__3;
                        /*0x5c*/ char <charValue>5__4;
                        /*0x60*/ GameDevWare.Dynamic.Expressions.CSharp.Token <current>5__5;
                        /*0x80*/ int <t>5__6;
                        /*0x88*/ string <token>5__7;

                        /*0xe9b8a0*/ <Tokenize>d__5(int <>1__state);
                        /*0xe9cab4*/ void System.IDisposable.Dispose();
                        /*0xe9cab8*/ bool MoveNext();
                        /*0xe9d060*/ GameDevWare.Dynamic.Expressions.CSharp.Token System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.Token>.get_Current();
                        /*0xe9d070*/ void System.Collections.IEnumerator.Reset();
                        /*0xe9d0b0*/ object System.Collections.IEnumerator.get_Current();
                        /*0xe9d110*/ System.Collections.Generic.IEnumerator<GameDevWare.Dynamic.Expressions.CSharp.Token> System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.CSharp.Token>.GetEnumerator();
                        /*0xe9d1b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                enum TokenType
                {
                    None = 0,
                    Number = 1,
                    Literal = 2,
                    Identifier = 3,
                    Add = 4,
                    Plus = 5,
                    Subtract = 6,
                    Minus = 7,
                    Division = 8,
                    Multiplication = 9,
                    Power = 10,
                    Modulo = 11,
                    And = 12,
                    Or = 13,
                    Xor = 14,
                    Complement = 15,
                    LeftShift = 16,
                    RightShift = 17,
                    AndAlso = 18,
                    OrElse = 19,
                    Not = 20,
                    GreaterThan = 21,
                    GreaterThanOrEquals = 22,
                    LesserThan = 23,
                    LesserThanOrEquals = 24,
                    EqualsTo = 25,
                    NotEqualsTo = 26,
                    Conditional = 27,
                    Is = 28,
                    As = 29,
                    Colon = 30,
                    Comma = 31,
                    Coalesce = 32,
                    New = 33,
                    Resolve = 34,
                    NullResolve = 35,
                    LeftParentheses = 36,
                    RightParentheses = 37,
                    LeftBracket = 38,
                    NullIndex = 39,
                    RightBracket = 40,
                    Lambda = 41,
                    Call = 42,
                    Arguments = 43,
                    Convert = 44,
                    Typeof = 45,
                    Default = 46,
                    Group = 47,
                    CheckedScope = 48,
                    UncheckedScope = 49,
                }
            }

            namespace Binding
            {
                class AnyBinder
                {
                    static /*0xe9d1b4*/ bool TryBindInNewScope(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xe9d22c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class BinaryBinder
                {
                    static /*0x0*/ System.Func<object, object, string> StringConcat;

                    static /*0xea18fc*/ BinaryBinder();
                    static /*0xe9f64c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class BindingContext
                {
                    /*0x10*/ System.Linq.Expressions.Expression global;
                    /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters;
                    /*0x20*/ System.Collections.Generic.List<System.Linq.Expressions.Expression> nullPropagationTargets;
                    /*0x28*/ System.Type resultType;
                    /*0x30*/ GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver;

                    static /*0xea1b80*/ bool TryGetTypeReference(object value, ref GameDevWare.Dynamic.Expressions.TypeReference typeReference);
                    static /*0xea2814*/ bool TryGetMethodReference(object value, ref GameDevWare.Dynamic.Expressions.TypeReference methodReference);
                    static /*0xea24c0*/ bool TryMakeGenericMethod(ref GameDevWare.Dynamic.Expressions.Binding.MemberDescription methodDescription, System.Type[] typeArguments);
                    /*0xea19a8*/ BindingContext(GameDevWare.Dynamic.Expressions.ITypeResolver typeResolver, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Type resultType, System.Linq.Expressions.Expression global);
                    /*0xea1990*/ System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Parameters();
                    /*0xea1998*/ System.Type get_ResultType();
                    /*0xea19a0*/ System.Linq.Expressions.Expression get_Global();
                    /*0xea1a88*/ bool TryResolveType(object typeName, ref System.Type type);
                    /*0xea0de8*/ bool TryResolveMember(object memberName, ref GameDevWare.Dynamic.Expressions.Binding.MemberDescription member);
                    /*0xea25a8*/ bool TryGetParameter(string parameterName, ref System.Linq.Expressions.Expression parameter);
                    /*0xea2718*/ bool IsKnownType(System.Type type);
                    /*0xea2c88*/ GameDevWare.Dynamic.Expressions.Binding.BindingContext CreateNestedContext();
                    /*0xea2d04*/ GameDevWare.Dynamic.Expressions.Binding.BindingContext CreateNestedContext(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> newParameters, System.Type resultType);
                    /*0xea2e00*/ void RegisterNullPropagationTarget(System.Linq.Expressions.Expression target);
                    /*0xea2f40*/ void CompleteNullPropagation(ref System.Linq.Expressions.Expression expression);
                }

                class CallBinder
                {
                    static /*0xea3314*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xea4930*/ bool TryBindTarget(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, ref System.Linq.Expressions.Expression target, ref System.Type type, ref System.Exception bindingError);
                }

                class ConditionBinder
                {
                    static /*0xea4c98*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class ConstantBinder
                {
                    static /*0xea5018*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xea52b4*/ object ChangeType(object value, System.Type toType);
                }

                class DefaultBinder
                {
                    static /*0xea542c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class GroupBinder
                {
                    static /*0xea5628*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class IndexBinder
                {
                    static /*0xea5764*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class InvokeBinder
                {
                    static /*0xea5cb4*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xea6174*/ bool TryBindMethodCall(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.InvokeBinder.<> <>9;
                        static /*0x8*/ System.Func<GameDevWare.Dynamic.Expressions.Binding.MemberDescription, bool> <>9__0_0;

                        static /*0xea6754*/ <>c();
                        /*0xea67b8*/ <>c();
                        /*0xea67c0*/ bool <TryBind>b__0_0(GameDevWare.Dynamic.Expressions.Binding.MemberDescription m);
                    }
                }

                class LambdaBinder
                {
                    static /*0xea67f0*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xea73d4*/ string[] ExtractArgumentNames(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.LambdaBinder.<> <>9;
                        static /*0x8*/ System.Func<GameDevWare.Dynamic.Expressions.Binding.MemberDescription, bool> <>9__0_0;

                        static /*0xea7664*/ <>c();
                        /*0xea76c8*/ <>c();
                        /*0xea76d0*/ bool <TryBind>b__0_0(GameDevWare.Dynamic.Expressions.Binding.MemberDescription m);
                    }
                }

                class ListInitBinder
                {
                    static /*0xea7700*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xea7a00*/ bool TryGetListInitializers(GameDevWare.Dynamic.Expressions.SyntaxTreeNode listNode, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, ref System.Linq.Expressions.ElementInit[] initializers, ref System.Exception bindingError);
                    /*0xea7e24*/ ListInitBinder();
                }

                class MemberBinder
                {
                    static /*0xea7e2c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.MemberBinder.<> <>9;
                        static /*0x8*/ System.Func<GameDevWare.Dynamic.Expressions.Binding.MemberDescription, bool> <>9__0_0;

                        static /*0xea8980*/ <>c();
                        /*0xea89e4*/ <>c();
                        /*0xea89ec*/ bool <TryBind>b__0_0(GameDevWare.Dynamic.Expressions.Binding.MemberDescription m);
                    }
                }

                class MemberDescription : System.IEquatable<GameDevWare.Dynamic.Expressions.Binding.MemberDescription>, System.IEquatable<System.Reflection.MemberInfo>, System.IComparable<GameDevWare.Dynamic.Expressions.Binding.MemberDescription>
                {
                    static float QUALITY_EXACT_MATCH = 1;
                    static float QUALITY_INCOMPATIBLE = 0;
                    /*0x10*/ int hashCode;
                    /*0x18*/ System.Reflection.MemberInfo member;
                    /*0x20*/ System.Reflection.ParameterInfo[] parameters;
                    /*0x28*/ System.Collections.Generic.Dictionary<string, System.Reflection.ParameterInfo> parametersByName;
                    /*0x30*/ System.Reflection.ParameterInfo returnParameter;
                    /*0x38*/ System.Collections.Generic.Dictionary<GameDevWare.Dynamic.Expressions.Binding.TypeTuple, GameDevWare.Dynamic.Expressions.Binding.MemberDescription> methodInstantiations;
                    /*0x40*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription genericDefinition;
                    /*0x48*/ string Name;
                    /*0x50*/ System.Type ResultType;
                    /*0x58*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription DeclaringType;
                    /*0x60*/ bool IsMethod;
                    /*0x61*/ bool IsConstructor;
                    /*0x62*/ bool IsPropertyOrField;
                    /*0x63*/ bool IsStatic;
                    /*0x64*/ bool IsImplicitOperator;
                    /*0x65*/ bool HasByRefLikeParameters;
                    /*0x68*/ System.Type[] GenericArguments;
                    /*0x70*/ int GenericArgumentsCount;
                    /*0x78*/ System.Linq.Expressions.Expression ConstantValueExpression;
                    /*0x80*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription GetAccessor;

                    static /*0xea9c70*/ bool HasDigitsOnly(string argName);
                    static /*0xea982c*/ string GetParameterName(System.Reflection.ParameterInfo parameter);
                    static /*0xea86e8*/ System.Reflection.MemberInfo op_Implicit(GameDevWare.Dynamic.Expressions.Binding.MemberDescription memberDescription);
                    static /*0xea1268*/ System.Reflection.MethodInfo op_Implicit(GameDevWare.Dynamic.Expressions.Binding.MemberDescription memberDescription);
                    static /*0xea2fcc*/ bool op_Equality(GameDevWare.Dynamic.Expressions.Binding.MemberDescription member1, GameDevWare.Dynamic.Expressions.Binding.MemberDescription member2);
                    static /*0xea8934*/ bool op_Inequality(GameDevWare.Dynamic.Expressions.Binding.MemberDescription type1, GameDevWare.Dynamic.Expressions.Binding.MemberDescription type2);
                    /*0xea8a04*/ MemberDescription(GameDevWare.Dynamic.Expressions.Binding.TypeDescription declaringType, System.Reflection.PropertyInfo property);
                    /*0xea90f4*/ MemberDescription(GameDevWare.Dynamic.Expressions.Binding.TypeDescription declaringType, System.Reflection.FieldInfo field);
                    /*0xea8c20*/ MemberDescription(GameDevWare.Dynamic.Expressions.Binding.TypeDescription declaringType, System.Reflection.MethodInfo method, GameDevWare.Dynamic.Expressions.Binding.MemberDescription genericMethodDefinition);
                    /*0xea9358*/ MemberDescription(GameDevWare.Dynamic.Expressions.Binding.TypeDescription declaringType, System.Reflection.ConstructorInfo constructor);
                    /*0xea2410*/ System.Reflection.ParameterInfo GetParameter(int parameterIndex);
                    /*0xea96b0*/ System.Type GetParameterType(int parameterIndex);
                    /*0xea9774*/ string GetParameterName(int parameterIndex);
                    /*0xea23f8*/ int GetParametersCount();
                    /*0xea2ff4*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription MakeGenericMethod(System.Type[] genericArguments);
                    /*0xea86f4*/ bool TryMakeAccessor(System.Linq.Expressions.Expression target, ref System.Linq.Expressions.Expression expression);
                    /*0xea9a84*/ bool TryMakeConversion(System.Linq.Expressions.Expression valueExpression, ref System.Linq.Expressions.Expression expression, bool checkedConversion);
                    /*0xea3d84*/ bool TryMakeCall(System.Linq.Expressions.Expression target, GameDevWare.Dynamic.Expressions.ArgumentsTree argumentsTree, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, ref System.Linq.Expressions.Expression expression, ref float expressionQuality);
                    /*0xea9d24*/ bool Equals(object obj);
                    /*0xea9e58*/ int GetHashCode();
                    /*0xea9e28*/ bool Equals(System.Reflection.MemberInfo other);
                    /*0xea9df4*/ bool Equals(GameDevWare.Dynamic.Expressions.Binding.MemberDescription other);
                    /*0xea9e60*/ int CompareTo(GameDevWare.Dynamic.Expressions.Binding.MemberDescription other);
                    /*0xea9ed0*/ string ToString();

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription.<> <>9;
                        static /*0x8*/ System.Func<System.Reflection.ParameterInfo, bool> <>9__24_0;
                        static /*0x10*/ System.Func<System.Reflection.ParameterInfo, bool> <>9__25_0;
                        static /*0x18*/ System.Func<System.Reflection.ParameterInfo, bool> <>9__33_0;

                        static /*0xea9ef0*/ <>c();
                        /*0xea9f54*/ <>c();
                        /*0xea9f5c*/ bool <.ctor>b__24_0(System.Reflection.ParameterInfo parameter);
                        /*0xeaa0fc*/ bool <.ctor>b__25_0(System.Reflection.ParameterInfo parameter);
                        /*0xeaa174*/ bool <TryMakeCall>b__33_0(System.Reflection.ParameterInfo p);
                    }
                }

                class MemberInitBinder
                {
                    static /*0xeaa18c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xeaa470*/ bool TryGetBindings(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, ref System.Linq.Expressions.MemberBinding[] bindings, ref System.Exception bindingError);
                    static /*0xeaa6a4*/ bool TryGetBinding(object bindingNode, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, ref System.Linq.Expressions.MemberBinding memberBinding, ref System.Exception bindingError);
                }

                class NewArrayBoundsBinder
                {
                    static /*0xeaaa4c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class NewArrayInitBinder
                {
                    static /*0xeaad80*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class NewBinder
                {
                    static /*0xeab0b8*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xeab48c*/ bool TryBindToType(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, object typeName, GameDevWare.Dynamic.Expressions.ArgumentsTree arguments, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                    static /*0xeab244*/ bool TryBindToMethod(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, object methodName, GameDevWare.Dynamic.Expressions.ArgumentsTree arguments, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class NumberUtils
                {
                    static /*0x0*/ int[] SignedIntegerTypes;
                    static /*0x8*/ int[] UnsignedIntegerTypes;
                    static /*0x10*/ int[] NumberTypes;

                    static /*0xeab7f8*/ NumberUtils();
                    static /*0xeab950*/ bool IsNumber(System.Type type);
                    static /*0xeaba08*/ bool IsNumber(System.TypeCode type);
                    static /*0xeaba8c*/ bool IsSignedInteger(System.Type type);
                    static /*0xeabb44*/ bool IsSignedInteger(System.TypeCode type);
                    static /*0xeabbc8*/ bool IsUnsignedInteger(System.Type type);
                    static /*0xeabc80*/ bool IsUnsignedInteger(System.TypeCode type);
                }

                class ParameterBinder
                {
                    static /*0xeabd04*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class QuoteBinder
                {
                    static /*0xeabf3c*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class TypeBinaryBinder
                {
                    static /*0xeac044*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                class TypeCache
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<System.Type, GameDevWare.Dynamic.Expressions.Binding.TypeDescription> types;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Binding.TypeCache parentCache;

                    /*0xeac474*/ TypeCache(GameDevWare.Dynamic.Expressions.Binding.TypeCache parentCache);
                    /*0xeac424*/ System.Collections.Generic.Dictionary.ValueCollection<System.Type, GameDevWare.Dynamic.Expressions.Binding.TypeDescription> get_Values();
                    /*0xeac504*/ bool TryGetValue(System.Type type, ref GameDevWare.Dynamic.Expressions.Binding.TypeDescription typeDescription);
                    /*0xeac67c*/ bool TryAdd(System.Type type, ref GameDevWare.Dynamic.Expressions.Binding.TypeDescription typeDescription);
                    /*0xeac7b8*/ void Add(System.Type type, GameDevWare.Dynamic.Expressions.Binding.TypeDescription typeDescription);
                    /*0xeac918*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription GetOrCreateTypeDescription(System.Type type);
                    /*0xead8e0*/ void Merge(GameDevWare.Dynamic.Expressions.Binding.TypeCache otherCache);
                    /*0xeadabc*/ string ToString();
                }

                class TypeConversion
                {
                    static float QUALITY_SAME_TYPE = 1;
                    static float QUALITY_INHERITANCE_HIERARCHY = 0.8999999761581421;
                    static float QUALITY_IN_PLACE_CONVERSION = 0.699999988079071;
                    static float QUALITY_IMPLICIT_CONVERSION = 0.5;
                    static float QUALITY_NUMBER_EXPANSION = 0.5;
                    static float QUALITY_PRECISION_CONVERSION = 0.4000000059604645;
                    static float QUALITY_EXPLICIT_CONVERSION = 0;
                    static float QUALITY_NO_CONVERSION = 0;
                    static /*0x0*/ System.Collections.Generic.Dictionary<GameDevWare.Dynamic.Expressions.Binding.TypeTuple2, GameDevWare.Dynamic.Expressions.Binding.TypeConversion> Conversions;
                    /*0x10*/ float Quality;
                    /*0x14*/ bool IsNatural;
                    /*0x18*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription Implicit;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription Explicit;

                    static /*0xeadadc*/ TypeConversion();
                    static /*0xeafd3c*/ bool TryGetTypeConversion(System.Type fromType, System.Type toType, ref GameDevWare.Dynamic.Expressions.Binding.TypeConversion typeConversion);
                    static /*0xeaff40*/ void UpdateConversions(System.Collections.Generic.IEnumerable<GameDevWare.Dynamic.Expressions.Binding.TypeDescription> typeDescriptions);
                    static /*0xeaf9d4*/ void SetNaturalConversion(float quality, System.Type fromType, System.Type[] toTypes);
                    /*0xeafb9c*/ TypeConversion(float quality, bool isNatural, GameDevWare.Dynamic.Expressions.Binding.MemberDescription implicitConversion, GameDevWare.Dynamic.Expressions.Binding.MemberDescription explicitConversion);
                    /*0xeafbe8*/ GameDevWare.Dynamic.Expressions.Binding.TypeConversion Expand(GameDevWare.Dynamic.Expressions.Binding.MemberDescription implicitConversion, GameDevWare.Dynamic.Expressions.Binding.MemberDescription explicitConversion);
                    /*0xeb0b54*/ string ToString();
                }

                class TypeDescription : System.IComparable<GameDevWare.Dynamic.Expressions.Binding.TypeDescription>, System.IComparable, System.IEquatable<GameDevWare.Dynamic.Expressions.Binding.TypeDescription>, System.IEquatable<System.Type>
                {
                    static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.TypeCache Types;
                    static /*0x8*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] EmptyMembers;
                    static /*0x10*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription[] EmptyTypes;
                    static /*0x18*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription ObjectType;
                    static /*0x20*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription Int32Type;
                    static /*0x28*/ System.Linq.Expressions.Expression NullObjectDefaultExpression;
                    /*0x10*/ System.Type type;
                    /*0x18*/ int hashCode;
                    /*0x20*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription nullableType;
                    /*0x28*/ System.Linq.Expressions.Expression defaultExpression;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, GameDevWare.Dynamic.Expressions.Binding.MemberDescription[]> MembersByName;
                    /*0x38*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] ImplicitConvertTo;
                    /*0x40*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] ImplicitConvertFrom;
                    /*0x48*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] ExplicitConvertTo;
                    /*0x50*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] ExplicitConvertFrom;
                    /*0x58*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Conversions;
                    /*0x60*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Addition;
                    /*0x68*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Division;
                    /*0x70*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Equality;
                    /*0x78*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] GreaterThan;
                    /*0x80*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] GreaterThanOrEqual;
                    /*0x88*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Inequality;
                    /*0x90*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] LessThan;
                    /*0x98*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] LessThanOrEqual;
                    /*0xa0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Modulus;
                    /*0xa8*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Multiply;
                    /*0xb0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Subtraction;
                    /*0xb8*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] UnaryNegation;
                    /*0xc0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] UnaryPlus;
                    /*0xc8*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] BitwiseAnd;
                    /*0xd0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] BitwiseOr;
                    /*0xd8*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Indexers;
                    /*0xe0*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] Constructors;
                    /*0xe8*/ string Name;
                    /*0xf0*/ System.TypeCode TypeCode;
                    /*0xf4*/ bool IsNullable;
                    /*0xf5*/ bool CanBeNull;
                    /*0xf6*/ bool IsEnum;
                    /*0xf7*/ bool IsVoid;
                    /*0xf8*/ bool IsNumber;
                    /*0xf9*/ bool IsDelegate;
                    /*0xfa*/ bool IsInterface;
                    /*0xfb*/ bool IsByRefLike;
                    /*0xfc*/ bool IsValueType;
                    /*0xfd*/ bool HasGenericParameters;
                    /*0x100*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription BaseType;
                    /*0x108*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription UnderlyingType;
                    /*0x110*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription[] BaseTypes;
                    /*0x118*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription[] Interfaces;
                    /*0x120*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription[] GenericArguments;

                    static /*0xeb0e58*/ TypeDescription();
                    static /*0xeb23d4*/ System.Collections.Generic.List<System.Reflection.MemberInfo> GetDeclaredMembers(System.Type type);
                    static /*0xeb1530*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription[] GetBaseTypes(GameDevWare.Dynamic.Expressions.Binding.TypeDescription type, int depth);
                    static void Add<T>(ref T[] array, T element);
                    static T[] Combine<T>(T[][] arrays);
                    static /*0xea9fd4*/ bool HasByRefLikeAttribute(System.Type type);
                    static /*0xeb2764*/ bool IsByRefLikeAttributeType(System.Type attributeType);
                    static /*0xea0dc0*/ bool op_Equality(GameDevWare.Dynamic.Expressions.Binding.TypeDescription type1, GameDevWare.Dynamic.Expressions.Binding.TypeDescription type2);
                    static /*0xeb2348*/ bool op_Inequality(GameDevWare.Dynamic.Expressions.Binding.TypeDescription type1, GameDevWare.Dynamic.Expressions.Binding.TypeDescription type2);
                    static /*0xeb2a10*/ bool op_Equality(GameDevWare.Dynamic.Expressions.Binding.TypeDescription type1, System.Type type2);
                    static /*0xeb2a24*/ bool op_Inequality(System.Type type1, GameDevWare.Dynamic.Expressions.Binding.TypeDescription type2);
                    static /*0xeb2a9c*/ bool op_Equality(System.Type type1, GameDevWare.Dynamic.Expressions.Binding.TypeDescription type2);
                    static /*0xea1664*/ bool op_Inequality(GameDevWare.Dynamic.Expressions.Binding.TypeDescription type1, System.Type type2);
                    static /*0xea1898*/ System.Type op_Implicit(GameDevWare.Dynamic.Expressions.Binding.TypeDescription typeDescription);
                    static /*0xea1390*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription GetTypeDescription(System.Type type);
                    /*0xeaca00*/ TypeDescription(System.Type type, GameDevWare.Dynamic.Expressions.Binding.TypeCache cache);
                    /*0xea5624*/ System.Linq.Expressions.Expression get_DefaultExpression();
                    /*0xeb1fcc*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] GetOperators(System.Collections.Generic.List<System.Reflection.MethodInfo> methods, GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] methodsDescriptions, string operatorName, System.Nullable<int> compareParameterIndex);
                    /*0xeb0cc0*/ System.Linq.Expressions.Expression GetOrCreateDefaultExpression();
                    /*0xeb1630*/ System.Collections.Generic.Dictionary<string, GameDevWare.Dynamic.Expressions.Binding.MemberDescription[]> GetMembersByName(ref GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] indexers);
                    /*0xea22fc*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription[] GetMembers(string memberName);
                    /*0xea16dc*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription GetNullableType();
                    /*0xea4c48*/ bool IsAssignableFrom(System.Type operandType);
                    /*0xeb2810*/ bool Equals(object obj);
                    /*0xeb2900*/ int GetHashCode();
                    /*0xeb2908*/ int CompareTo(GameDevWare.Dynamic.Expressions.Binding.TypeDescription other);
                    /*0xeb2990*/ int CompareTo(object obj);
                    /*0xeb2874*/ bool Equals(GameDevWare.Dynamic.Expressions.Binding.TypeDescription other);
                    /*0xeb29f4*/ bool Equals(System.Type other);
                    /*0xeb2adc*/ string ToString();
                    /*0xeb2afc*/ GameDevWare.Dynamic.Expressions.Binding.MemberDescription <.ctor>b__53_1(System.Reflection.ConstructorInfo ctr);

                    class <>c
                    {
                        static /*0x0*/ GameDevWare.Dynamic.Expressions.Binding.TypeDescription.<> <>9;
                        static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__53_0;
                        static /*0x10*/ System.Func<GameDevWare.Dynamic.Expressions.Binding.MemberDescription, bool> <>9__53_2;
                        static /*0x18*/ System.Func<object, bool> <>9__61_0;

                        static /*0xeb2b6c*/ <>c();
                        /*0xeb2bd0*/ <>c();
                        /*0xeb2bd8*/ bool <.ctor>b__53_0(System.Reflection.MethodInfo m);
                        /*0xeb2c14*/ bool <.ctor>b__53_2(GameDevWare.Dynamic.Expressions.Binding.MemberDescription ctr);
                        /*0xeb2c34*/ bool <HasByRefLikeAttribute>b__61_0(object attribute);
                    }
                }

                class TypeOfBinder
                {
                    static /*0xeb2ca4*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }

                struct TypeTuple : System.IEquatable<GameDevWare.Dynamic.Expressions.Binding.TypeTuple>
                {
                    /*0x10*/ int hashCode;
                    /*0x18*/ System.Type[] Types;

                    /*0xea995c*/ TypeTuple(System.Type[] types);
                    /*0xeb2f00*/ bool Equals(GameDevWare.Dynamic.Expressions.Binding.TypeTuple other);
                    /*0xeb2f80*/ int GetHashCode();
                    /*0xeb2f88*/ bool Equals(object obj);
                    /*0xeb3000*/ string ToString();
                }

                struct TypeTuple2 : System.IEquatable<GameDevWare.Dynamic.Expressions.Binding.TypeTuple2>
                {
                    /*0x10*/ int hashCode;
                    /*0x18*/ System.Type Type1;
                    /*0x20*/ System.Type Type2;

                    /*0xeb4154*/ TypeTuple2(System.Type type1, System.Type type2);
                    /*0xeb4234*/ bool Equals(GameDevWare.Dynamic.Expressions.Binding.TypeTuple2 other);
                    /*0xeb4260*/ int GetHashCode();
                    /*0xeb4268*/ bool Equals(object obj);
                    /*0xeb42f0*/ string ToString();
                }

                class UnaryBinder
                {
                    static /*0xeb43a8*/ bool TryBind(GameDevWare.Dynamic.Expressions.SyntaxTreeNode node, GameDevWare.Dynamic.Expressions.Binding.BindingContext bindingContext, GameDevWare.Dynamic.Expressions.Binding.TypeDescription expectedType, ref System.Linq.Expressions.Expression boundExpression, ref System.Exception bindingError);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 19151594FCE0E23138F4B6B9F03F4CCD785271B5772FF24BFE787C96ED5193A6;
    static /*0x2c*/ <PrivateImplementationDetails> 7F84499A787DAD593ABDB4624034F984D6F7E7E0258A7ECD5EE822B34F74FBCC;
    static /*0x3c*/ <PrivateImplementationDetails> 860C22A3D8A6730AAF002337FA6BA46809077DB52EE20EDA3C7EC3A21CD94BBB;
    static /*0x50*/ <PrivateImplementationDetails> 86100769DA22BD7BC4FC5600C15CD8C22A2998041B247B1A9E0F272FAF60029E;

    static /*0xeb4ab8*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }
}
