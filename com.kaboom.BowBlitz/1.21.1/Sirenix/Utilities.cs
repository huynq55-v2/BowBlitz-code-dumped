class <Module>
{
}

namespace Sirenix
{
    namespace Utilities
    {
        class ColorExtensions
        {
            static /*0x0*/ char[] trimRGBStart;

            static /*0x23192cc*/ ColorExtensions();
            static /*0x231888c*/ UnityEngine.Color Lerp(UnityEngine.Color[] colors, float t);
            static /*0x231893c*/ UnityEngine.Color MoveTowards(UnityEngine.Color from, UnityEngine.Color to, float maxDelta);
            static /*0x23189dc*/ bool TryParseString(string colorStr, ref UnityEngine.Color color);
            static /*0x2318dc4*/ string ToCSharpColor(UnityEngine.Color color);
            static /*0x2319178*/ UnityEngine.Color Pow(UnityEngine.Color color, float factor);
            static /*0x23191f4*/ UnityEngine.Color NormalizeRGB(UnityEngine.Color color);
            static /*0x2319058*/ string TrimFloat(float value);
        }

        class DelegateExtensions
        {
            static System.Func<TResult> Memoize<TResult>(System.Func<TResult> getValue);
            static System.Func<T, TResult> Memoize<T, TResult>(System.Func<T, TResult> func);

            class <>c__DisplayClass0_0<TResult>
            {
                /*0x0*/ bool hasValue;
                /*0x0*/ TResult value;
                /*0x0*/ System.Func<TResult> getValue;

                <>c__DisplayClass0_0();
                TResult <Memoize>b__0();
            }

            class <>c__DisplayClass1_0<T, TResult>
            {
                /*0x0*/ System.Collections.Generic.Dictionary<T, TResult> dic;
                /*0x0*/ System.Func<T, TResult> func;

                <>c__DisplayClass1_0();
                TResult <Memoize>b__0(T n);
            }
        }

        class FieldInfoExtensions
        {
            static /*0x2319360*/ bool IsAliasField(System.Reflection.FieldInfo fieldInfo);
            static /*0x23193bc*/ System.Reflection.FieldInfo DeAliasField(System.Reflection.FieldInfo fieldInfo, bool throwOnNotAliased);
        }

        class GarbageFreeIterators
        {
            static Sirenix.Utilities.GarbageFreeIterators.ListIterator<T> GFIterator<T>(System.Collections.Generic.List<T> list);
            static Sirenix.Utilities.GarbageFreeIterators.DictionaryIterator<T1, T2> GFIterator<T1, T2>(System.Collections.Generic.Dictionary<T1, T2> dictionary);
            static Sirenix.Utilities.GarbageFreeIterators.DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(System.Collections.Generic.Dictionary<T1, T2> dictionary);
            static Sirenix.Utilities.GarbageFreeIterators.HashsetIterator<T> GFIterator<T>(System.Collections.Generic.HashSet<T> hashset);

            struct ListIterator<T> : System.IDisposable
            {
                /*0x0*/ bool isNull;
                /*0x0*/ System.Collections.Generic.List<T> list;
                /*0x0*/ System.Collections.Generic.List.Enumerator<T> enumerator;

                ListIterator(System.Collections.Generic.List<T> list);
                Sirenix.Utilities.GarbageFreeIterators.ListIterator<T> GetEnumerator();
                T get_Current();
                bool MoveNext();
                void Dispose();
            }

            struct HashsetIterator<T> : System.IDisposable
            {
                /*0x0*/ bool isNull;
                /*0x0*/ System.Collections.Generic.HashSet<T> hashset;
                /*0x0*/ System.Collections.Generic.HashSet.Enumerator<T> enumerator;

                HashsetIterator(System.Collections.Generic.HashSet<T> hashset);
                Sirenix.Utilities.GarbageFreeIterators.HashsetIterator<T> GetEnumerator();
                T get_Current();
                bool MoveNext();
                void Dispose();
            }

            struct DictionaryIterator<T1, T2> : System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.Dictionary<T1, T2> dictionary;
                /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<T1, T2> enumerator;
                /*0x0*/ bool isNull;

                DictionaryIterator(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                Sirenix.Utilities.GarbageFreeIterators.DictionaryIterator<T1, T2> GetEnumerator();
                System.Collections.Generic.KeyValuePair<T1, T2> get_Current();
                bool MoveNext();
                void Dispose();
            }

            struct DictionaryValueIterator<T1, T2> : System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.Dictionary<T1, T2> dictionary;
                /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<T1, T2> enumerator;
                /*0x0*/ bool isNull;

                DictionaryValueIterator(System.Collections.Generic.Dictionary<T1, T2> dictionary);
                Sirenix.Utilities.GarbageFreeIterators.DictionaryValueIterator<T1, T2> GetEnumerator();
                T2 get_Current();
                bool MoveNext();
                void Dispose();
            }
        }

        class LinqExtensions
        {
            static System.Collections.Generic.IEnumerable<T> Examine<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> action);
            static System.Collections.Generic.IEnumerable<T> ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T> action);
            static System.Collections.Generic.IEnumerable<T> ForEach<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<T, int> action);
            static System.Collections.Generic.IEnumerable<T> Convert<T>(System.Collections.IEnumerable source, System.Func<object, T> converter);
            static Sirenix.Utilities.ImmutableList<T> ToImmutableList<T>(System.Collections.Generic.IEnumerable<T> source);
            static System.Collections.Generic.IEnumerable<T> PrependWith<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependWith<T>(System.Collections.Generic.IEnumerable<T> source, T prepend);
            static System.Collections.Generic.IEnumerable<T> PrependWith<T>(System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEnumerable<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, System.Func<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, T prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, System.Collections.Generic.IEnumerable<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, System.Func<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, T prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, System.Collections.Generic.IEnumerable<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition, System.Func<T> prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition, T prepend);
            static System.Collections.Generic.IEnumerable<T> PrependIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition, System.Collections.Generic.IEnumerable<T> prepend);
            static System.Collections.Generic.IEnumerable<T> AppendWith<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T> append);
            static System.Collections.Generic.IEnumerable<T> AppendWith<T>(System.Collections.Generic.IEnumerable<T> source, T append);
            static System.Collections.Generic.IEnumerable<T> AppendWith<T>(System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.IEnumerable<T> append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, System.Func<T> append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, T append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, bool condition, System.Collections.Generic.IEnumerable<T> append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, System.Func<T> append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, T append);
            static System.Collections.Generic.IEnumerable<T> AppendIf<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<bool> condition, System.Collections.Generic.IEnumerable<T> append);
            static System.Collections.Generic.IEnumerable<T> FilterCast<T>(System.Collections.IEnumerable source);
            static void AddRange<T>(System.Collections.Generic.HashSet<T> hashSet, System.Collections.Generic.IEnumerable<T> range);
            static bool IsNullOrEmpty<T>(System.Collections.Generic.IList<T> list);
            static void Populate<T>(System.Collections.Generic.IList<T> list, T item);
            static void AddRange<T>(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<T> collection);
            static void Sort<T>(System.Collections.Generic.IList<T> list, System.Comparison<T> comparison);
            static void Sort<T>(System.Collections.Generic.IList<T> list);

            class <AppendIf>d__20<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ System.Func<T> append;
                /*0x0*/ System.Func<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__20(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendIf>d__2<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ T append;
                /*0x0*/ T <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__2(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendIf>d__22<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> append;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__22(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendIf>d__23<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ System.Func<T> append;
                /*0x0*/ System.Func<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__23(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendIf>d__24<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ T append;
                /*0x0*/ T <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__24(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendIf>d__25<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> append;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendIf>d__25(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendWith>d__17<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Func<T> append;
                /*0x0*/ System.Func<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendWith>d__17(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendWith>d__18<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ T append;
                /*0x0*/ T <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendWith>d__18(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <AppendWith>d__19<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> append;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__append;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <AppendWith>d__19(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <Convert>d__3<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.IEnumerable source;
                /*0x0*/ System.Collections.IEnumerable <>3__source;
                /*0x0*/ System.Func<object, T> converter;
                /*0x0*/ System.Func<object, T> <>3__converter;
                /*0x0*/ System.Collections.IEnumerator <>7__wrap1;

                <Convert>d__3(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <Examine>d__0<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Action<T> action;
                /*0x0*/ System.Action<T> <>3__action;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <Examine>d__0(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <FilterCast>d__26<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.IEnumerable source;
                /*0x0*/ System.Collections.IEnumerable <>3__source;
                /*0x0*/ System.Collections.IEnumerator <>7__wrap1;

                <FilterCast>d__26(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__10<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__10(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ System.Func<T> prepend;
                /*0x0*/ System.Func<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__12<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ T prepend;
                /*0x0*/ T <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__12(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__13<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<bool> condition;
                /*0x0*/ System.Func<bool> <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__13(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__14<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Func<T> prepend;
                /*0x0*/ System.Func<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__14(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__15<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ T prepend;
                /*0x0*/ T <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__15(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__16<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> condition;
                /*0x0*/ System.Func<System.Collections.Generic.IEnumerable<T>, bool> <>3__condition;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__16(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__8<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ System.Func<T> prepend;
                /*0x0*/ System.Func<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__8(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependIf>d__9<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ bool condition;
                /*0x0*/ bool <>3__condition;
                /*0x0*/ T prepend;
                /*0x0*/ T <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependIf>d__9(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependWith>d__5<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Func<T> prepend;
                /*0x0*/ System.Func<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependWith>d__5(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependWith>d__6<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ T prepend;
                /*0x0*/ T <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependWith>d__6(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <PrependWith>d__7<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__prepend;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap1;

                <PrependWith>d__7(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                void <>m__Finally2();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ListExtensions
        {
            static void SetLength<T>(ref System.Collections.Generic.IList<T> list, int length);
            static void SetLength<T>(ref System.Collections.Generic.IList<T> list, int length, System.Func<T> newElement);
            static void SetLength<T>(System.Collections.Generic.IList<T> list, int length);
            static void SetLength<T>(System.Collections.Generic.IList<T> list, int length, System.Func<T> newElement);
        }

        class MemberInfoExtensions
        {
            static bool IsDefined<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
            static bool IsDefined<T>(System.Reflection.ICustomAttributeProvider member);
            static T GetAttribute<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
            static T GetAttribute<T>(System.Reflection.ICustomAttributeProvider member);
            static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(System.Reflection.ICustomAttributeProvider member);
            static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(System.Reflection.ICustomAttributeProvider member, bool inherit);
            static /*0x231959c*/ System.Attribute[] GetAttributes(System.Reflection.ICustomAttributeProvider member);
            static /*0x2319690*/ System.Attribute[] GetAttributes(System.Reflection.ICustomAttributeProvider member, bool inherit);
            static /*0x23194e8*/ string GetNiceName(System.Reflection.MemberInfo member);
            static /*0x2319964*/ bool IsStatic(System.Reflection.MemberInfo member);
            static /*0x2319d64*/ bool IsAlias(System.Reflection.MemberInfo memberInfo);
            static /*0x2319e04*/ System.Reflection.MemberInfo DeAlias(System.Reflection.MemberInfo memberInfo, bool throwOnNotAliased);
            static /*0x2319f98*/ bool SignaturesAreEqual(System.Reflection.MemberInfo a, System.Reflection.MemberInfo b);
        }

        class MethodInfoExtensions
        {
            static /*0x231a658*/ string GetFullName(System.Reflection.MethodBase method, string extensionMethodPrefix);
            static /*0x231aa84*/ string GetParamsNames(System.Reflection.MethodBase method);
            static /*0x2319798*/ string GetFullName(System.Reflection.MethodBase method);
            static /*0x231a89c*/ bool IsExtensionMethod(System.Reflection.MethodBase method);
            static /*0x231ac80*/ bool IsAliasMethod(System.Reflection.MethodInfo methodInfo);
            static /*0x231acdc*/ System.Reflection.MethodInfo DeAliasMethod(System.Reflection.MethodInfo methodInfo, bool throwOnNotAliased);
        }

        enum Operator
        {
            Equality = 0,
            Inequality = 1,
            Addition = 2,
            Subtraction = 3,
            Multiply = 4,
            Division = 5,
            LessThan = 6,
            GreaterThan = 7,
            LessThanOrEqual = 8,
            GreaterThanOrEqual = 9,
            Modulus = 10,
            RightShift = 11,
            LeftShift = 12,
            BitwiseAnd = 13,
            BitwiseOr = 14,
            ExclusiveOr = 15,
            BitwiseComplement = 16,
            LogicalAnd = 17,
            LogicalOr = 18,
            LogicalNot = 19,
        }

        class PathUtilities
        {
            static /*0x231ae08*/ string GetDirectoryName(string x);
            static /*0x231aeb4*/ bool HasSubDirectory(System.IO.DirectoryInfo parentDir, System.IO.DirectoryInfo subDir);
            static /*0x231b008*/ System.IO.DirectoryInfo FindParentDirectoryWithName(System.IO.DirectoryInfo dir, string folderName);
            static /*0x231b07c*/ bool CanMakeRelative(string absoluteParentPath, string absolutePath);
            static /*0x231b21c*/ string MakeRelative(string absoluteParentPath, string absolutePath);
            static /*0x231b59c*/ bool TryMakeRelative(string absoluteParentPath, string absolutePath, ref string relativePath);
            static /*0x231b5e8*/ string Combine(string a, string b);
        }

        class PropertyInfoExtensions
        {
            static /*0x231b720*/ bool IsAutoProperty(System.Reflection.PropertyInfo propInfo, bool allowVirtual);
            static /*0x231b928*/ bool IsAliasProperty(System.Reflection.PropertyInfo propertyInfo);
            static /*0x231b984*/ System.Reflection.PropertyInfo DeAliasProperty(System.Reflection.PropertyInfo propertyInfo, bool throwOnNotAliased);
        }

        enum Direction
        {
            Left = 0,
            Right = 1,
            Top = 2,
            Bottom = 3,
        }

        class RectExtensions
        {
            static /*0x231bab0*/ UnityEngine.Rect TakeFromDir(ref UnityEngine.Rect rect, float width, Sirenix.Utilities.Direction direction);
            static /*0x231bb5c*/ UnityEngine.Rect TakeFromLeft(ref UnityEngine.Rect rect, float width);
            static /*0x231bc40*/ UnityEngine.Rect TakeFromRight(ref UnityEngine.Rect rect, float width);
            static /*0x231bd20*/ UnityEngine.Rect TakeFromTop(ref UnityEngine.Rect rect, float height);
            static /*0x231be04*/ UnityEngine.Rect TakeFromBottom(ref UnityEngine.Rect rect, float height);
            static /*0x231bfc4*/ UnityEngine.Rect SetWidth(UnityEngine.Rect rect, float width);
            static /*0x231bff8*/ UnityEngine.Rect SetHeight(UnityEngine.Rect rect, float height);
            static /*0x231c02c*/ UnityEngine.Rect SetSize(UnityEngine.Rect rect, float width, float height);
            static /*0x231c07c*/ UnityEngine.Rect SetSize(UnityEngine.Rect rect, float widthAndHeight);
            static /*0x231c0cc*/ UnityEngine.Rect SetSize(UnityEngine.Rect rect, UnityEngine.Vector2 size);
            static /*0x231c104*/ UnityEngine.Rect HorizontalPadding(UnityEngine.Rect rect, float padding);
            static /*0x231c170*/ UnityEngine.Rect HorizontalPadding(UnityEngine.Rect rect, float left, float right);
            static /*0x231c1e0*/ UnityEngine.Rect VerticalPadding(UnityEngine.Rect rect, float padding);
            static /*0x231c24c*/ UnityEngine.Rect VerticalPadding(UnityEngine.Rect rect, float top, float bottom);
            static /*0x231c2bc*/ UnityEngine.Rect Padding(UnityEngine.Rect rect, float padding);
            static /*0x231c330*/ UnityEngine.Rect Padding(UnityEngine.Rect rect, float horizontal, float vertical);
            static /*0x231c3ac*/ UnityEngine.Rect Padding(UnityEngine.Rect rect, float left, float right, float top, float bottom);
            static /*0x231c438*/ UnityEngine.Rect AlignLeft(UnityEngine.Rect rect, float width);
            static /*0x231c46c*/ UnityEngine.Rect AlignCenter(UnityEngine.Rect rect, float width);
            static /*0x231c4e8*/ UnityEngine.Rect AlignCenter(UnityEngine.Rect rect, float width, float height);
            static /*0x231bee4*/ UnityEngine.Rect AlignRight(UnityEngine.Rect rect, float width);
            static /*0x231c5b8*/ UnityEngine.Rect AlignRight(UnityEngine.Rect rect, float width, bool clamp);
            static /*0x231c664*/ UnityEngine.Rect AlignTop(UnityEngine.Rect rect, float height);
            static /*0x231c698*/ UnityEngine.Rect AlignMiddle(UnityEngine.Rect rect, float height);
            static /*0x231bf54*/ UnityEngine.Rect AlignBottom(UnityEngine.Rect rect, float height);
            static /*0x231c714*/ UnityEngine.Rect AlignCenterX(UnityEngine.Rect rect, float width);
            static /*0x231c790*/ UnityEngine.Rect AlignCenterY(UnityEngine.Rect rect, float height);
            static /*0x231c80c*/ UnityEngine.Rect AlignCenterXY(UnityEngine.Rect rect, float size);
            static /*0x231c8d4*/ UnityEngine.Rect AlignCenterXY(UnityEngine.Rect rect, float width, float height);
            static /*0x231c9a4*/ UnityEngine.Rect Expand(UnityEngine.Rect rect, float expand);
            static /*0x231ca48*/ UnityEngine.Rect Expand(UnityEngine.Rect rect, float horizontal, float vertical);
            static /*0x231cac4*/ UnityEngine.Rect Expand(UnityEngine.Rect rect, float left, float right, float top, float bottom);
            static /*0x231cb50*/ UnityEngine.Rect Split(UnityEngine.Rect rect, int index, int count);
            static /*0x231cbd4*/ UnityEngine.Rect SplitVertical(UnityEngine.Rect rect, int index, int count);
            static /*0x231cc58*/ UnityEngine.Rect SplitGrid(UnityEngine.Rect rect, float width, float height, int index);
            static /*0x231cd38*/ UnityEngine.Rect SplitTableGrid(UnityEngine.Rect rect, int columnCount, float rowHeight, int index);
            static /*0x231cdf8*/ UnityEngine.Rect SetCenterX(UnityEngine.Rect rect, float x);
            static /*0x231ce44*/ UnityEngine.Rect SetCenterY(UnityEngine.Rect rect, float y);
            static /*0x231ce90*/ UnityEngine.Rect SetCenter(UnityEngine.Rect rect, float x, float y);
            static /*0x231cec8*/ UnityEngine.Rect SetCenter(UnityEngine.Rect rect, UnityEngine.Vector2 center);
            static /*0x231cf00*/ UnityEngine.Rect SetPosition(UnityEngine.Rect rect, UnityEngine.Vector2 position);
            static /*0x231cf38*/ UnityEngine.Rect ResetPosition(UnityEngine.Rect rect);
            static /*0x231cf9c*/ UnityEngine.Rect AddPosition(UnityEngine.Rect rect, UnityEngine.Vector2 move);
            static /*0x231cff0*/ UnityEngine.Rect AddPosition(UnityEngine.Rect rect, float x, float y);
            static /*0x231d05c*/ UnityEngine.Rect SetX(UnityEngine.Rect rect, float x);
            static /*0x231d090*/ UnityEngine.Rect AddX(UnityEngine.Rect rect, float x);
            static /*0x231d0dc*/ UnityEngine.Rect SubX(UnityEngine.Rect rect, float x);
            static /*0x231d128*/ UnityEngine.Rect SetY(UnityEngine.Rect rect, float y);
            static /*0x231d15c*/ UnityEngine.Rect AddY(UnityEngine.Rect rect, float y);
            static /*0x231d1a8*/ UnityEngine.Rect SubY(UnityEngine.Rect rect, float y);
            static /*0x231d1f4*/ UnityEngine.Rect SetMin(UnityEngine.Rect rect, UnityEngine.Vector2 min);
            static /*0x231d22c*/ UnityEngine.Rect AddMin(UnityEngine.Rect rect, UnityEngine.Vector2 value);
            static /*0x231d280*/ UnityEngine.Rect SubMin(UnityEngine.Rect rect, UnityEngine.Vector2 value);
            static /*0x231d2d4*/ UnityEngine.Rect SetMax(UnityEngine.Rect rect, UnityEngine.Vector2 max);
            static /*0x231d30c*/ UnityEngine.Rect AddMax(UnityEngine.Rect rect, UnityEngine.Vector2 value);
            static /*0x231d360*/ UnityEngine.Rect SubMax(UnityEngine.Rect rect, UnityEngine.Vector2 value);
            static /*0x231d3b4*/ UnityEngine.Rect SetXMin(UnityEngine.Rect rect, float xMin);
            static /*0x231d3e8*/ UnityEngine.Rect AddXMin(UnityEngine.Rect rect, float value);
            static /*0x231d434*/ UnityEngine.Rect SubXMin(UnityEngine.Rect rect, float value);
            static /*0x231d480*/ UnityEngine.Rect SetXMax(UnityEngine.Rect rect, float xMax);
            static /*0x231d4b4*/ UnityEngine.Rect AddXMax(UnityEngine.Rect rect, float value);
            static /*0x231d500*/ UnityEngine.Rect SubXMax(UnityEngine.Rect rect, float value);
            static /*0x231d54c*/ UnityEngine.Rect SetYMin(UnityEngine.Rect rect, float yMin);
            static /*0x231d580*/ UnityEngine.Rect AddYMin(UnityEngine.Rect rect, float value);
            static /*0x231d5cc*/ UnityEngine.Rect SubYMin(UnityEngine.Rect rect, float value);
            static /*0x231d618*/ UnityEngine.Rect SetYMax(UnityEngine.Rect rect, float yMax);
            static /*0x231d64c*/ UnityEngine.Rect AddYMax(UnityEngine.Rect rect, float value);
            static /*0x231d698*/ UnityEngine.Rect SubYMax(UnityEngine.Rect rect, float value);
            static /*0x231d6e4*/ UnityEngine.Rect MinWidth(UnityEngine.Rect rect, float minWidth);
            static /*0x231d734*/ UnityEngine.Rect MaxWidth(UnityEngine.Rect rect, float maxWidth);
            static /*0x231d784*/ UnityEngine.Rect MinHeight(UnityEngine.Rect rect, float minHeight);
            static /*0x231d7d4*/ UnityEngine.Rect MaxHeight(UnityEngine.Rect rect, float maxHeight);
            static /*0x231d824*/ UnityEngine.Rect ExpandTo(UnityEngine.Rect rect, UnityEngine.Vector2 pos);
        }

        class StringExtensions
        {
            static /*0x23197e0*/ string ToTitleCase(string input);
            static /*0x231d8e8*/ bool Contains(string source, string toCheck, System.StringComparison comparisonType);
            static /*0x231d90c*/ string SplitPascalCase(string input);
            static /*0x231daf0*/ bool IsNullOrWhitespace(string str);
        }

        class TypeExtensions
        {
            static /*0x0*/ System.Func<float, float, bool> FloatEqualityComparerFunc;
            static /*0x8*/ System.Func<double, double, bool> DoubleEqualityComparerFunc;
            static /*0x10*/ System.Func<UnityEngine.Quaternion, UnityEngine.Quaternion, bool> QuaternionEqualityComparerFunc;
            static /*0x18*/ object GenericConstraintsSatisfaction_LOCK;
            static /*0x20*/ System.Collections.Generic.Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionInferredParameters;
            static /*0x28*/ System.Collections.Generic.Dictionary<System.Type, System.Type> GenericConstraintsSatisfactionResolvedMap;
            static /*0x30*/ System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionProcessedParams;
            static /*0x38*/ System.Collections.Generic.HashSet<System.Type> GenericConstraintsSatisfactionTypesToCheck;
            static /*0x40*/ System.Collections.Generic.List<System.Type> GenericConstraintsSatisfactionTypesToCheck_ToAdd;
            static /*0x48*/ System.Type GenericListInterface;
            static /*0x50*/ System.Type GenericCollectionInterface;
            static /*0x58*/ object WeaklyTypedTypeCastDelegates_LOCK;
            static /*0x60*/ object StronglyTypedTypeCastDelegates_LOCK;
            static /*0x68*/ Sirenix.Utilities.DoubleLookupDictionary<System.Type, System.Type, System.Func<object, object>> WeaklyTypedTypeCastDelegates;
            static /*0x70*/ Sirenix.Utilities.DoubleLookupDictionary<System.Type, System.Type, System.Delegate> StronglyTypedTypeCastDelegates;
            static /*0x78*/ System.Type[] TwoLengthTypeArray_Cached;
            static /*0x80*/ System.Collections.Generic.Stack<System.Type> GenericArgumentsContainsTypes_ArgsToCheckCached;
            static /*0x88*/ System.Collections.Generic.HashSet<string> ReservedCSharpKeywords;
            static /*0x90*/ System.Collections.Generic.Dictionary<string, string> TypeNameAlternatives;
            static /*0x98*/ object CachedNiceNames_LOCK;
            static /*0xa0*/ System.Collections.Generic.Dictionary<System.Type, string> CachedNiceNames;
            static /*0xa8*/ System.Type VoidPointerType;
            static /*0xb0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.HashSet<System.Type>> PrimitiveImplicitCasts;
            static /*0xb8*/ System.Collections.Generic.HashSet<System.Type> ExplicitCastIntegrals;

            static /*0x232572c*/ TypeExtensions();
            static /*0x231dbb4*/ string GetCachedNiceName(System.Type type);
            static /*0x231dd80*/ string CreateNiceName(System.Type type);
            static /*0x231e42c*/ bool HasCastDefined(System.Type from, System.Type to, bool requireImplicitCast);
            static /*0x231f29c*/ bool IsValidIdentifier(string identifier);
            static /*0x231f488*/ bool IsValidIdentifierStartCharacter(char c);
            static /*0x231f518*/ bool IsValidIdentifierPartCharacter(char c);
            static /*0x231e858*/ bool IsCastableTo(System.Type from, System.Type to, bool requireImplicitCast);
            static /*0x231f5bc*/ System.Func<object, object> GetCastMethodDelegate(System.Type from, System.Type to, bool requireImplicitCast);
            static System.Func<TFrom, TTo> GetCastMethodDelegate<TFrom, TTo>(bool requireImplicitCast);
            static /*0x231e9ec*/ System.Reflection.MethodInfo GetCastMethod(System.Type from, System.Type to, bool requireImplicitCast);
            static /*0x231f858*/ bool FloatEqualityComparer(float a, float b);
            static /*0x231f91c*/ bool DoubleEqualityComparer(double a, double b);
            static /*0x231f9e0*/ bool QuaternionEqualityComparer(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
            static System.Func<T, T, bool> GetEqualityComparerDelegate<T>();
            static T GetAttribute<T>(System.Type type, bool inherit);
            static /*0x231fa10*/ bool ImplementsOrInherits(System.Type type, System.Type to);
            static /*0x231fa3c*/ bool ImplementsOpenGenericType(System.Type candidateType, System.Type openGenericType);
            static /*0x231fac4*/ bool ImplementsOpenGenericInterface(System.Type candidateType, System.Type openGenericInterfaceType);
            static /*0x231fc30*/ bool ImplementsOpenGenericClass(System.Type candidateType, System.Type openGenericType);
            static /*0x231fd5c*/ System.Type[] GetArgumentsOfInheritedOpenGenericType(System.Type candidateType, System.Type openGenericType);
            static /*0x2320098*/ System.Type[] GetArgumentsOfInheritedOpenGenericClass(System.Type candidateType, System.Type openGenericType);
            static /*0x231fde4*/ System.Type[] GetArgumentsOfInheritedOpenGenericInterface(System.Type candidateType, System.Type openGenericInterfaceType);
            static /*0x23201d4*/ System.Reflection.MethodInfo GetOperatorMethod(System.Type type, Sirenix.Utilities.Operator op, System.Type leftOperand, System.Type rightOperand);
            static /*0x23208e4*/ System.Reflection.MethodInfo GetOperatorMethod(System.Type type, Sirenix.Utilities.Operator op);
            static /*0x2320c30*/ System.Reflection.MethodInfo[] GetOperatorMethods(System.Type type, Sirenix.Utilities.Operator op);
            static /*0x2320f98*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetAllMembers(System.Type type, System.Reflection.BindingFlags flags);
            static /*0x2321054*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetAllMembers(System.Type type, string name, System.Reflection.BindingFlags flags);
            static System.Collections.Generic.IEnumerable<T> GetAllMembers<T>(System.Type type, System.Reflection.BindingFlags flags);
            static /*0x2321118*/ System.Type GetGenericBaseType(System.Type type, System.Type baseType);
            static /*0x2321188*/ System.Type GetGenericBaseType(System.Type type, System.Type baseType, ref int depthCount);
            static /*0x2321630*/ System.Collections.Generic.IEnumerable<System.Type> GetBaseTypes(System.Type type, bool includeSelf);
            static /*0x2321760*/ System.Collections.Generic.IEnumerable<System.Type> GetBaseClasses(System.Type type, bool includeSelf);
            static /*0x231e348*/ string TypeNameGauntlet(System.Type type);
            static /*0x231a990*/ string GetNiceName(System.Type type);
            static /*0x2321820*/ string GetNiceFullName(System.Type type);
            static /*0x2321958*/ string GetCompilableNiceName(System.Type type);
            static /*0x2321a2c*/ string GetCompilableNiceFullName(System.Type type);
            static T GetCustomAttribute<T>(System.Type type, bool inherit);
            static T GetCustomAttribute<T>(System.Type type);
            static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(System.Type type);
            static System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(System.Type type, bool inherit);
            static bool IsDefined<T>(System.Type type);
            static bool IsDefined<T>(System.Type type, bool inherit);
            static bool InheritsFrom<TBase>(System.Type type);
            static /*0x231e178*/ bool InheritsFrom(System.Type type, System.Type baseType);
            static /*0x2321b00*/ int GetInheritanceDistance(System.Type type, System.Type baseType);
            static /*0x2321f2c*/ bool HasParamaters(System.Reflection.MethodInfo methodInfo, System.Collections.Generic.IList<System.Type> paramTypes, bool inherit);
            static /*0x231a444*/ System.Type GetReturnType(System.Reflection.MemberInfo memberInfo);
            static /*0x23221ec*/ object GetMemberValue(System.Reflection.MemberInfo member, object obj);
            static /*0x232236c*/ void SetMemberValue(System.Reflection.MemberInfo member, object obj, object value);
            static /*0x23225c4*/ bool TryInferGenericParameters(System.Type genericTypeDefinition, ref System.Type[] inferredParams, System.Type[] knownParameters);
            static /*0x23236e8*/ bool AreGenericConstraintsSatisfiedBy(System.Type genericType, System.Type[] parameters);
            static /*0x2323a88*/ bool AreGenericConstraintsSatisfiedBy(System.Reflection.MethodBase genericMethod, System.Type[] parameters);
            static /*0x232386c*/ bool AreGenericConstraintsSatisfiedBy(System.Type[] definitions, System.Type[] parameters);
            static /*0x2324480*/ bool GenericParameterIsFulfilledBy(System.Type genericParameterDefinition, System.Type parameterType);
            static /*0x2323be0*/ bool GenericParameterIsFulfilledBy(System.Type genericParameterDefinition, System.Type parameterType, System.Collections.Generic.Dictionary<System.Type, System.Type> resolvedMap, System.Collections.Generic.HashSet<System.Type> processedParams);
            static /*0x23245ec*/ string GetGenericConstraintsString(System.Type type, bool useFullTypeNames);
            static /*0x2324874*/ string GetGenericParameterConstraintsString(System.Type type, bool useFullTypeNames);
            static /*0x2324d04*/ bool GenericArgumentsContainsTypes(System.Type type, System.Type[] types);
            static /*0x23234f4*/ bool IsFullyConstructedGenericType(System.Type type);
            static /*0x2325274*/ bool IsNullableType(System.Type type);
            static /*0x23252cc*/ ulong GetEnumBitmask(object value, System.Type enumType);
            static /*0x2325494*/ bool IsCSharpKeyword(string identifier);
            static /*0x2325514*/ System.Type[] SafeGetTypes(System.Reflection.Assembly assembly);
            static /*0x23255d8*/ bool SafeIsDefined(System.Reflection.Assembly assembly, System.Type attribute, bool inherit);
            static /*0x232567c*/ object[] SafeGetCustomAttributes(System.Reflection.Assembly assembly, System.Type type, bool inherit);

            class <>c__37<T>
            {
                static /*0x0*/ Sirenix.Utilities.TypeExtensions.<>c__37<T> <>9;
                static /*0x0*/ System.Func<T, T, bool> <>9__37_0;
                static /*0x0*/ System.Func<T, T, bool> <>9__37_1;

                static <>c__37();
                <>c__37();
                bool <GetEqualityComparerDelegate>b__37_0(T a, T b);
                bool <GetEqualityComparerDelegate>b__37_1(T a, T b);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ System.Reflection.MethodInfo method;

                /*0x231f850*/ <>c__DisplayClass31_0();
                /*0x2327d70*/ object <GetCastMethodDelegate>b__0(object obj);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ string methodName;

                /*0x2320c28*/ <>c__DisplayClass47_0();
                /*0x2327e20*/ bool <GetOperatorMethod>b__0(System.Reflection.MethodInfo m);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ string methodName;

                /*0x2320f90*/ <>c__DisplayClass48_0();
                /*0x2327e58*/ bool <GetOperatorMethods>b__0(System.Reflection.MethodInfo x);
            }

            class <GetAllMembers>d__49 : System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.MemberInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Reflection.BindingFlags flags;
                /*0x3c*/ System.Reflection.BindingFlags <>3__flags;
                /*0x40*/ System.Type <currentType>5__2;
                /*0x48*/ System.Reflection.MemberInfo[] <>7__wrap2;
                /*0x50*/ int <>7__wrap3;

                /*0x2321020*/ <GetAllMembers>d__49(int <>1__state);
                /*0x2327e90*/ void System.IDisposable.Dispose();
                /*0x2327e94*/ bool MoveNext();
                /*0x2328054*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                /*0x232805c*/ void System.Collections.IEnumerator.Reset();
                /*0x232809c*/ object System.Collections.IEnumerator.get_Current();
                /*0x23280a4*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                /*0x2328150*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetAllMembers>d__50 : System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.MemberInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Reflection.BindingFlags flags;
                /*0x3c*/ System.Reflection.BindingFlags <>3__flags;
                /*0x40*/ string name;
                /*0x48*/ string <>3__name;
                /*0x50*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>7__wrap1;

                /*0x23210e4*/ <GetAllMembers>d__50(int <>1__state);
                /*0x2328154*/ void System.IDisposable.Dispose();
                /*0x2328170*/ bool MoveNext();
                /*0x2328474*/ void <>m__Finally1();
                /*0x2328524*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                /*0x232852c*/ void System.Collections.IEnumerator.Reset();
                /*0x232856c*/ object System.Collections.IEnumerator.get_Current();
                /*0x2328574*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                /*0x2328628*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetAllMembers>d__5<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Type type;
                /*0x0*/ System.Type <>3__type;
                /*0x0*/ System.Reflection.BindingFlags flags;
                /*0x0*/ System.Reflection.BindingFlags <>3__flags;
                /*0x0*/ System.Type <currentType>5__2;
                /*0x0*/ System.Reflection.MemberInfo[] <>7__wrap2;
                /*0x0*/ int <>7__wrap3;

                <GetAllMembers>d__5(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetBaseClasses>d__55 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Type <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ bool includeSelf;
                /*0x39*/ bool <>3__includeSelf;
                /*0x40*/ System.Type <current>5__2;

                /*0x23217ec*/ <GetBaseClasses>d__55(int <>1__state);
                /*0x232862c*/ void System.IDisposable.Dispose();
                /*0x2328630*/ bool MoveNext();
                /*0x2328790*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                /*0x2328798*/ void System.Collections.IEnumerator.Reset();
                /*0x23287d8*/ object System.Collections.IEnumerator.get_Current();
                /*0x23287e0*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                /*0x232888c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetCustomAttributes>d__64<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Type type;
                /*0x0*/ System.Type <>3__type;
                /*0x0*/ bool inherit;
                /*0x0*/ bool <>3__inherit;
                /*0x0*/ object[] <attrs>5__2;
                /*0x0*/ int <i>5__3;

                <GetCustomAttributes>d__64(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class UnityExtensions
        {
            static /*0x0*/ Sirenix.Utilities.ValueGetter<UnityEngine.Object, nint> UnityObjectCachedPtrFieldGetter;

            static /*0x2328890*/ UnityExtensions();
            static /*0x23289ac*/ bool SafeIsUnityNull(UnityEngine.Object obj);
        }

        class ArrayUtilities
        {
            static T[] CreateNewArrayWithAddedElement<T>(T[] array, T value);
            static T[] CreateNewArrayWithInsertedElement<T>(T[] array, int index, T value);
            static T[] CreateNewArrayWithRemovedElement<T>(T[] array, int index);
        }

        class DeepReflection
        {
            static /*0x0*/ System.Reflection.MethodInfo WeakListGetItem;
            static /*0x8*/ System.Reflection.MethodInfo WeakListSetItem;
            static /*0x10*/ System.Reflection.MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo;
            static /*0x18*/ System.Reflection.MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo;
            static /*0x20*/ System.Reflection.MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo;
            static /*0x28*/ System.Reflection.MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo;

            static /*0x232ae40*/ DeepReflection();
            static /*0x2328ac8*/ System.Func<object> CreateWeakStaticValueGetter(System.Type rootType, System.Type resultType, string path, bool allowEmit);
            static /*0x2329874*/ System.Func<object, object> CreateWeakInstanceValueGetter(System.Type rootType, System.Type resultType, string path, bool allowEmit);
            static /*0x2329a7c*/ System.Action<object, object> CreateWeakInstanceValueSetter(System.Type rootType, System.Type argType, string path, bool allowEmit);
            static System.Func<object, TResult> CreateWeakInstanceValueGetter<TResult>(System.Type rootType, string path, bool allowEmit);
            static System.Func<TResult> CreateValueGetter<TResult>(System.Type rootType, string path, bool allowEmit);
            static System.Func<TTarget, TResult> CreateValueGetter<TTarget, TResult>(string path, bool allowEmit);
            static System.Func<object, object> CreateWeakAliasForInstanceGetDelegate1<TTarget, TResult>(System.Func<TTarget, TResult> func);
            static System.Func<object, TResult> CreateWeakAliasForInstanceGetDelegate2<TTarget, TResult>(System.Func<TTarget, TResult> func);
            static System.Func<object> CreateWeakAliasForStaticGetDelegate<TResult>(System.Func<TResult> func);
            static System.Action<object, object> CreateWeakAliasForInstanceSetDelegate1<TTarget, TArg1>(System.Action<TTarget, TArg1> func);
            static System.Action<object, TArg1> CreateWeakAliasForInstanceSetDelegate2<TTarget, TArg1>(System.Action<TTarget, TArg1> func);
            static System.Action<object> CreateWeakAliasForStaticSetDelegate<TArg1>(System.Action<TArg1> func);
            static /*0x2329c84*/ System.Delegate CreateEmittedDeepValueGetterDelegate(string path, System.Type rootType, System.Type resultType, System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath, bool rootIsStatic);
            static /*0x23297c8*/ System.Func<object> CreateSlowDeepStaticValueGetterDelegate(System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath);
            static /*0x23299d0*/ System.Func<object, object> CreateSlowDeepInstanceValueGetterDelegate(System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath);
            static /*0x2329bd8*/ System.Action<object, object> CreateSlowDeepInstanceValueSetterDelegate(System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath);
            static /*0x2329cec*/ object SlowGetMemberValue(Sirenix.Utilities.DeepReflection.PathStep step, object instance);
            static /*0x232a140*/ void SlowSetMemberValue(Sirenix.Utilities.DeepReflection.PathStep step, object instance, object value);
            static /*0x2328c24*/ System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> GetMemberPath(System.Type rootType, ref System.Type resultType, string path, ref bool rootIsStatic, bool isSet);
            static /*0x232a78c*/ System.Reflection.MemberInfo GetStepMember(System.Type owningType, string name, bool expectMethod);

            enum PathStepType
            {
                Member = 0,
                WeakListElement = 1,
                StrongListElement = 2,
                ArrayElement = 3,
            }

            struct PathStep
            {
                /*0x10*/ Sirenix.Utilities.DeepReflection.PathStepType StepType;
                /*0x18*/ System.Reflection.MemberInfo Member;
                /*0x20*/ int ElementIndex;
                /*0x28*/ System.Type ElementType;
                /*0x30*/ System.Reflection.MethodInfo StrongListGetItemMethod;

                /*0x232ae28*/ PathStep(System.Reflection.MemberInfo member);
                /*0x232a774*/ PathStep(int elementIndex);
                /*0x232a61c*/ PathStep(int elementIndex, System.Type strongListElementType, bool isArray);
            }

            class <>c__DisplayClass11_0<TResult>
            {
                /*0x0*/ System.Func<object, object> del;

                <>c__DisplayClass11_0();
                TResult <CreateWeakInstanceValueGetter>b__0(object obj);
            }

            class <>c__DisplayClass12_0<TResult>
            {
                /*0x0*/ System.Func<object> slowDelegate;

                <>c__DisplayClass12_0();
                TResult <CreateValueGetter>b__0();
            }

            class <>c__DisplayClass13_0<TTarget, TResult>
            {
                /*0x0*/ System.Func<object, object> slowDelegate;

                <>c__DisplayClass13_0();
                TResult <CreateValueGetter>b__0(TTarget target);
            }

            class <>c__DisplayClass14_0<TTarget, TResult>
            {
                /*0x0*/ System.Func<TTarget, TResult> func;

                <>c__DisplayClass14_0();
                object <CreateWeakAliasForInstanceGetDelegate1>b__0(object obj);
            }

            class <>c__DisplayClass15_0<TTarget, TResult>
            {
                /*0x0*/ System.Func<TTarget, TResult> func;

                <>c__DisplayClass15_0();
                TResult <CreateWeakAliasForInstanceGetDelegate2>b__0(object obj);
            }

            class <>c__DisplayClass16_0<TResult>
            {
                /*0x0*/ System.Func<TResult> func;

                <>c__DisplayClass16_0();
                object <CreateWeakAliasForStaticGetDelegate>b__0();
            }

            class <>c__DisplayClass17_0<TTarget, TArg1>
            {
                /*0x0*/ System.Action<TTarget, TArg1> func;

                <>c__DisplayClass17_0();
                void <CreateWeakAliasForInstanceSetDelegate1>b__0(object obj, object arg);
            }

            class <>c__DisplayClass18_0<TTarget, TArg1>
            {
                /*0x0*/ System.Action<TTarget, TArg1> func;

                <>c__DisplayClass18_0();
                void <CreateWeakAliasForInstanceSetDelegate2>b__0(object obj, TArg1 arg);
            }

            class <>c__DisplayClass19_0<TArg1>
            {
                /*0x0*/ System.Action<TArg1> func;

                <>c__DisplayClass19_0();
                void <CreateWeakAliasForStaticSetDelegate>b__0(object arg);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath;

                /*0x2329cd4*/ <>c__DisplayClass21_0();
                /*0x232b048*/ object <CreateSlowDeepStaticValueGetterDelegate>b__0();
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath;

                /*0x2329cdc*/ <>c__DisplayClass22_0();
                /*0x232b13c*/ object <CreateSlowDeepInstanceValueGetterDelegate>b__0(object instance);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ System.Collections.Generic.List<Sirenix.Utilities.DeepReflection.PathStep> memberPath;

                /*0x2329ce4*/ <>c__DisplayClass23_0();
                /*0x232b230*/ void <CreateSlowDeepInstanceValueSetterDelegate>b__0(object instance, object arg);
            }
        }

        class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : System.Collections.Generic.Dictionary<TFirstKey, System.Collections.Generic.Dictionary<TSecondKey, TValue>>
        {
            /*0x0*/ System.Collections.Generic.IEqualityComparer<TSecondKey> secondKeyComparer;

            DoubleLookupDictionary();
            DoubleLookupDictionary(System.Collections.Generic.IEqualityComparer<TFirstKey> firstKeyComparer, System.Collections.Generic.IEqualityComparer<TSecondKey> secondKeyComparer);
            System.Collections.Generic.Dictionary<TSecondKey, TValue> get_Item(TFirstKey firstKey);
            int InnerCount(TFirstKey firstKey);
            int TotalInnerCount();
            bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey);
            bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, ref TValue value);
            TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value);
            bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey);
            void RemoveWhere(System.Func<TValue, bool> predicate);
        }

        class WeakValueGetter : System.MulticastDelegate
        {
            /*0x232b388*/ WeakValueGetter(object object, nint method);
            /*0x232b45c*/ object Invoke(ref object instance);
            /*0x232b470*/ System.IAsyncResult BeginInvoke(ref object instance, System.AsyncCallback callback, object object);
            /*0x232b494*/ object EndInvoke(ref object instance, System.IAsyncResult result);
        }

        class WeakValueSetter : System.MulticastDelegate
        {
            /*0x232b4b0*/ WeakValueSetter(object object, nint method);
            /*0x232b588*/ void Invoke(ref object instance, object value);
            /*0x232b59c*/ System.IAsyncResult BeginInvoke(ref object instance, object value, System.AsyncCallback callback, object object);
            /*0x232b5c8*/ void EndInvoke(ref object instance, System.IAsyncResult result);
        }

        class WeakValueGetter<FieldType> : System.MulticastDelegate
        {
            WeakValueGetter(object object, nint method);
            FieldType Invoke(ref object instance);
            System.IAsyncResult BeginInvoke(ref object instance, System.AsyncCallback callback, object object);
            FieldType EndInvoke(ref object instance, System.IAsyncResult result);
        }

        class WeakValueSetter<FieldType> : System.MulticastDelegate
        {
            WeakValueSetter(object object, nint method);
            void Invoke(ref object instance, FieldType value);
            System.IAsyncResult BeginInvoke(ref object instance, FieldType value, System.AsyncCallback callback, object object);
            void EndInvoke(ref object instance, System.IAsyncResult result);
        }

        class ValueGetter<InstanceType, FieldType> : System.MulticastDelegate
        {
            ValueGetter(object object, nint method);
            FieldType Invoke(ref InstanceType instance);
            System.IAsyncResult BeginInvoke(ref InstanceType instance, System.AsyncCallback callback, object object);
            FieldType EndInvoke(ref InstanceType instance, System.IAsyncResult result);
        }

        class ValueSetter<InstanceType, FieldType> : System.MulticastDelegate
        {
            ValueSetter(object object, nint method);
            void Invoke(ref InstanceType instance, FieldType value);
            System.IAsyncResult BeginInvoke(ref InstanceType instance, FieldType value, System.AsyncCallback callback, object object);
            void EndInvoke(ref InstanceType instance, System.IAsyncResult result);
        }

        class EmitUtilities
        {
            static /*0x0*/ System.Reflection.Assembly EngineAssembly;

            static /*0x232c648*/ EmitUtilities();
            static /*0x232b5e4*/ bool get_CanEmit();
            static /*0x232b5ec*/ bool EmitIsIllegalForMember(System.Reflection.MemberInfo member);
            static System.Func<FieldType> CreateStaticFieldGetter<FieldType>(System.Reflection.FieldInfo fieldInfo);
            static /*0x232b6ec*/ System.Func<object> CreateWeakStaticFieldGetter(System.Reflection.FieldInfo fieldInfo);
            static System.Action<FieldType> CreateStaticFieldSetter<FieldType>(System.Reflection.FieldInfo fieldInfo);
            static /*0x232b85c*/ System.Action<object> CreateWeakStaticFieldSetter(System.Reflection.FieldInfo fieldInfo);
            static Sirenix.Utilities.ValueGetter<InstanceType, FieldType> CreateInstanceFieldGetter<InstanceType, FieldType>(System.Reflection.FieldInfo fieldInfo);
            static Sirenix.Utilities.WeakValueGetter<FieldType> CreateWeakInstanceFieldGetter<FieldType>(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
            static /*0x232b9cc*/ Sirenix.Utilities.WeakValueGetter CreateWeakInstanceFieldGetter(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
            static Sirenix.Utilities.ValueSetter<InstanceType, FieldType> CreateInstanceFieldSetter<InstanceType, FieldType>(System.Reflection.FieldInfo fieldInfo);
            static Sirenix.Utilities.WeakValueSetter<FieldType> CreateWeakInstanceFieldSetter<FieldType>(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
            static /*0x232bba0*/ Sirenix.Utilities.WeakValueSetter CreateWeakInstanceFieldSetter(System.Type instanceType, System.Reflection.FieldInfo fieldInfo);
            static /*0x232bd74*/ Sirenix.Utilities.WeakValueGetter CreateWeakInstancePropertyGetter(System.Type instanceType, System.Reflection.PropertyInfo propertyInfo);
            static /*0x232bfe0*/ Sirenix.Utilities.WeakValueSetter CreateWeakInstancePropertySetter(System.Type instanceType, System.Reflection.PropertyInfo propertyInfo);
            static System.Action<PropType> CreateStaticPropertySetter<PropType>(System.Reflection.PropertyInfo propertyInfo);
            static System.Func<PropType> CreateStaticPropertyGetter<PropType>(System.Reflection.PropertyInfo propertyInfo);
            static Sirenix.Utilities.ValueSetter<InstanceType, PropType> CreateInstancePropertySetter<InstanceType, PropType>(System.Reflection.PropertyInfo propertyInfo);
            static Sirenix.Utilities.ValueGetter<InstanceType, PropType> CreateInstancePropertyGetter<InstanceType, PropType>(System.Reflection.PropertyInfo propertyInfo);
            static System.Func<InstanceType, ReturnType> CreateMethodReturner<InstanceType, ReturnType>(System.Reflection.MethodInfo methodInfo);
            static /*0x232c210*/ System.Action CreateStaticMethodCaller(System.Reflection.MethodInfo methodInfo);
            static System.Action<object, TArg1> CreateWeakInstanceMethodCaller<TArg1>(System.Reflection.MethodInfo methodInfo);
            static /*0x232c428*/ System.Action<object> CreateWeakInstanceMethodCaller(System.Reflection.MethodInfo methodInfo);
            static System.Func<object, TArg1, TResult> CreateWeakInstanceMethodCaller<TResult, TArg1>(System.Reflection.MethodInfo methodInfo);
            static System.Func<object, TResult> CreateWeakInstanceMethodCallerFunc<TResult>(System.Reflection.MethodInfo methodInfo);
            static System.Func<object, TArg, TResult> CreateWeakInstanceMethodCallerFunc<TArg, TResult>(System.Reflection.MethodInfo methodInfo);
            static System.Action<InstanceType> CreateInstanceMethodCaller<InstanceType>(System.Reflection.MethodInfo methodInfo);
            static System.Action<InstanceType, Arg1> CreateInstanceMethodCaller<InstanceType, Arg1>(System.Reflection.MethodInfo methodInfo);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x232bb98*/ <>c__DisplayClass10_0();
                /*0x232c6f0*/ object <CreateWeakInstanceFieldGetter>b__0(ref object classInstance);
            }

            class <>c__DisplayClass11_0<InstanceType, FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass11_0();
                void <CreateInstanceFieldSetter>b__0(ref InstanceType classInstance, FieldType value);
            }

            class <>c__DisplayClass12_0<FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass12_0();
                void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, FieldType value);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x232bd6c*/ <>c__DisplayClass13_0();
                /*0x232c718*/ void <CreateWeakInstanceFieldSetter>b__0(ref object classInstance, object value);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ System.Reflection.PropertyInfo propertyInfo;

                /*0x232bfd8*/ <>c__DisplayClass14_0();
                /*0x232c738*/ object <CreateWeakInstancePropertyGetter>b__0(ref object classInstance);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ System.Reflection.PropertyInfo propertyInfo;

                /*0x232c208*/ <>c__DisplayClass15_0();
                /*0x232c764*/ void <CreateWeakInstancePropertySetter>b__0(ref object classInstance, object value);
            }

            class <>c__DisplayClass16_0<PropType>
            {
                /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                <>c__DisplayClass16_0();
                void <CreateStaticPropertySetter>b__0(PropType value);
            }

            class <>c__DisplayClass17_0<PropType>
            {
                /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                <>c__DisplayClass17_0();
                PropType <CreateStaticPropertyGetter>b__0();
            }

            class <>c__DisplayClass18_0<InstanceType, PropType>
            {
                /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                <>c__DisplayClass18_0();
                void <CreateInstancePropertySetter>b__0(ref InstanceType classInstance, PropType value);
            }

            class <>c__DisplayClass19_0<InstanceType, PropType>
            {
                /*0x0*/ System.Reflection.PropertyInfo propertyInfo;

                <>c__DisplayClass19_0();
                PropType <CreateInstancePropertyGetter>b__0(ref InstanceType classInstance);
            }

            class <>c__DisplayClass22_0<TArg1>
            {
                /*0x0*/ System.Reflection.MethodInfo methodInfo;

                <>c__DisplayClass22_0();
                void <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ System.Reflection.MethodInfo methodInfo;

                /*0x232c640*/ <>c__DisplayClass23_0();
                /*0x232c790*/ void <CreateWeakInstanceMethodCaller>b__0(object classInstance);
            }

            class <>c__DisplayClass24_0<TResult, TArg1>
            {
                /*0x0*/ System.Reflection.MethodInfo methodInfo;

                <>c__DisplayClass24_0();
                TResult <CreateWeakInstanceMethodCaller>b__0(object classInstance, TArg1 arg1);
            }

            class <>c__DisplayClass25_0<TResult>
            {
                /*0x0*/ System.Reflection.MethodInfo methodInfo;

                <>c__DisplayClass25_0();
                TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance);
            }

            class <>c__DisplayClass26_0<TArg, TResult>
            {
                /*0x0*/ System.Reflection.MethodInfo methodInfo;

                <>c__DisplayClass26_0();
                TResult <CreateWeakInstanceMethodCallerFunc>b__0(object classInstance, TArg arg);
            }

            class <>c__DisplayClass4_0<FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass4_0();
                FieldType <CreateStaticFieldGetter>b__0();
            }

            class <>c__DisplayClass4_<FieldType>
            {
                /*0x0*/ FieldType value;

                <>c__DisplayClass4_();
                FieldType <CreateStaticFieldGetter>b__1();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x232b854*/ <>c__DisplayClass5_0();
                /*0x232c7b0*/ object <CreateWeakStaticFieldGetter>b__0();
            }

            class <>c__DisplayClass6_0<FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass6_0();
                void <CreateStaticFieldSetter>b__0(FieldType value);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x232b9c4*/ <>c__DisplayClass7_0();
                /*0x232c7d8*/ void <CreateWeakStaticFieldSetter>b__0(object value);
            }

            class <>c__DisplayClass8_0<InstanceType, FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass8_0();
                FieldType <CreateInstanceFieldGetter>b__0(ref InstanceType classInstance);
            }

            class <>c__DisplayClass9_0<FieldType>
            {
                /*0x0*/ System.Reflection.FieldInfo fieldInfo;

                <>c__DisplayClass9_0();
                FieldType <CreateWeakInstanceFieldGetter>b__0(ref object classInstance);
            }
        }

        class Flags
        {
            static System.Reflection.BindingFlags AnyVisibility = 48;
            static System.Reflection.BindingFlags InstancePublic = 20;
            static System.Reflection.BindingFlags InstancePrivate = 36;
            static System.Reflection.BindingFlags InstanceAnyVisibility = 52;
            static System.Reflection.BindingFlags StaticPublic = 24;
            static System.Reflection.BindingFlags StaticPrivate = 40;
            static System.Reflection.BindingFlags StaticAnyVisibility = 56;
            static System.Reflection.BindingFlags InstancePublicDeclaredOnly = 22;
            static System.Reflection.BindingFlags InstancePrivateDeclaredOnly = 38;
            static System.Reflection.BindingFlags InstanceAnyDeclaredOnly = 54;
            static System.Reflection.BindingFlags StaticPublicDeclaredOnly = 26;
            static System.Reflection.BindingFlags StaticPrivateDeclaredOnly = 42;
            static System.Reflection.BindingFlags StaticAnyDeclaredOnly = 58;
            static System.Reflection.BindingFlags StaticInstanceAnyVisibility = 60;
            static System.Reflection.BindingFlags AllMembers = 124;
        }

        interface IGlobalConfigEvents
        {
            void OnConfigAutoCreated();
            void OnConfigInstanceFirstAccessed();
        }

        class GlobalConfig<T> : UnityEngine.ScriptableObject, Sirenix.Utilities.IGlobalConfigEvents
        {
            static /*0x0*/ Sirenix.Utilities.GlobalConfigAttribute configAttribute;
            static /*0x0*/ T instance;

            static Sirenix.Utilities.GlobalConfigAttribute get_ConfigAttribute();
            static bool get_HasInstanceLoaded();
            static T get_Instance();
            static void LoadInstanceIfAssetExists();
            GlobalConfig();
            void OpenInEditor();
            void OnConfigInstanceFirstAccessed();
            void OnConfigAutoCreated();
            void Sirenix.Utilities.IGlobalConfigEvents.OnConfigAutoCreated();
            void Sirenix.Utilities.IGlobalConfigEvents.OnConfigInstanceFirstAccessed();
        }

        class GlobalConfigUtility<T>
        {
            static /*0x0*/ T instance;

            static bool get_HasInstanceLoaded();
            static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension);
            static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension);
        }

        class GlobalConfigAttribute : System.Attribute
        {
            /*0x10*/ string assetPath;
            /*0x18*/ bool <UseAsset>k__BackingField;

            /*0x232cbb4*/ GlobalConfigAttribute();
            /*0x232cc08*/ GlobalConfigAttribute(string assetPath);
            /*0x232c7fc*/ string get_FullPath();
            /*0x232c860*/ string get_AssetPath();
            /*0x232c980*/ string get_AssetPathWithAssetsPrefix();
            /*0x232ca00*/ string get_AssetPathWithoutAssetsPrefix();
            /*0x232ca88*/ string get_ResourcesPath();
            /*0x232cba0*/ bool get_UseAsset();
            /*0x232cba8*/ void set_UseAsset(bool value);
            /*0x232cb38*/ bool get_IsInResourcesFolder();
        }

        class GUILayoutOptions
        {
            static /*0x0*/ int CurrentCacheIndex;
            static /*0x8*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance[] GUILayoutOptionsInstanceCache;
            static /*0x10*/ System.Collections.Generic.Dictionary<Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance, UnityEngine.GUILayoutOption[]> GUILayoutOptionsCache;
            static /*0x18*/ UnityEngine.GUILayoutOption[] EmptyGUIOptions;

            static /*0x232cc30*/ GUILayoutOptions();
            static /*0x232ce38*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Width(float width);
            static /*0x232ced4*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Height(float height);
            static /*0x232cf68*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height);
            static /*0x232cffc*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width);
            static /*0x232d090*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width);
            static /*0x232d124*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height);
            static /*0x232d1b8*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand);
            static /*0x232d280*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand);

            enum GUILayoutOptionType
            {
                Width = 0,
                Height = 1,
                MinWidth = 2,
                MaxHeight = 3,
                MaxWidth = 4,
                MinHeight = 5,
                ExpandHeight = 6,
                ExpandWidth = 7,
            }

            class GUILayoutOptionsInstance : System.IEquatable<Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance>
            {
                /*0x10*/ float value;
                /*0x18*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Parent;
                /*0x20*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionType GUILayoutOptionType;

                static /*0x232d6ac*/ UnityEngine.GUILayoutOption[] op_Implicit(Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance options);
                /*0x232ce30*/ GUILayoutOptionsInstance();
                /*0x232d31c*/ UnityEngine.GUILayoutOption[] GetCachedOptions();
                /*0x232d4e0*/ UnityEngine.GUILayoutOption[] CreateOptionsArary();
                /*0x232d424*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Clone();
                /*0x232d6bc*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Width(float width);
                /*0x232d758*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance Height(float height);
                /*0x232d7f8*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MaxHeight(float height);
                /*0x232d898*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MaxWidth(float width);
                /*0x232d938*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MinHeight(float height);
                /*0x232d9d8*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance MinWidth(float width);
                /*0x232da78*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance ExpandHeight(bool expand);
                /*0x232db20*/ Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance ExpandWidth(bool expand);
                /*0x232cec8*/ void SetValue(Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionType type, float value);
                /*0x232d254*/ void SetValue(Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionType type, bool value);
                /*0x232dbc8*/ bool Equals(Sirenix.Utilities.GUILayoutOptions.GUILayoutOptionsInstance other);
                /*0x232dc28*/ int GetHashCode();
            }
        }

        class ImmutableHashSet<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.HashSet<T> hashSet;

            ImmutableHashSet(System.Collections.Generic.HashSet<T> hashSet);
            bool Contains(T item);
            System.Collections.Generic.IEnumerator<T> GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        interface IImmutableList : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
        {
        }

        interface IImmutableList<T> : Sirenix.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>
        {
            T get_Item(int index);
        }

        class ImmutableList : Sirenix.Utilities.IImmutableList<object>, Sirenix.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<object>, System.Collections.Generic.ICollection<object>, System.Collections.Generic.IEnumerable<object>
        {
            /*0x10*/ System.Collections.IList innerList;

            /*0x232dcc0*/ ImmutableList(System.Collections.IList innerList);
            /*0x232dd38*/ int get_Count();
            /*0x232dddc*/ bool get_IsFixedSize();
            /*0x232dde4*/ bool get_IsReadOnly();
            /*0x232ddec*/ bool get_IsSynchronized();
            /*0x232de90*/ object get_SyncRoot();
            /*0x232df34*/ object System.Collections.IList.get_Item(int index);
            /*0x232dfdc*/ void System.Collections.IList.set_Item(int index, object value);
            /*0x232e02c*/ object System.Collections.Generic.IList<System.Object>.get_Item(int index);
            /*0x232e0d4*/ void System.Collections.Generic.IList<System.Object>.set_Item(int index, object value);
            /*0x232e124*/ object get_Item(int index);
            /*0x232e1cc*/ bool Contains(object value);
            /*0x232e278*/ void CopyTo(object[] array, int arrayIndex);
            /*0x232e330*/ void CopyTo(System.Array array, int index);
            /*0x232e3e8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x232e488*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x232e48c*/ System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
            /*0x232e51c*/ int System.Collections.IList.Add(object value);
            /*0x232e56c*/ void System.Collections.IList.Clear();
            /*0x232e5bc*/ void System.Collections.IList.Insert(int index, object value);
            /*0x232e60c*/ void System.Collections.IList.Remove(object value);
            /*0x232e65c*/ void System.Collections.IList.RemoveAt(int index);
            /*0x232e6ac*/ int IndexOf(object value);
            /*0x232e758*/ void System.Collections.Generic.IList<System.Object>.RemoveAt(int index);
            /*0x232e7a8*/ void System.Collections.Generic.IList<System.Object>.Insert(int index, object item);
            /*0x232e7f8*/ void System.Collections.Generic.ICollection<System.Object>.Add(object item);
            /*0x232e848*/ void System.Collections.Generic.ICollection<System.Object>.Clear();
            /*0x232e898*/ bool System.Collections.Generic.ICollection<System.Object>.Remove(object item);

            class <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25 : System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Sirenix.Utilities.ImmutableList <>4__this;
                /*0x28*/ System.Collections.IEnumerator <>7__wrap1;

                /*0x232e4f4*/ <System-Collections-Generic-IEnumerable<System-Object>-GetEnumerator>d__25(int <>1__state);
                /*0x232e8e8*/ void System.IDisposable.Dispose();
                /*0x232e904*/ bool MoveNext();
                /*0x232eb98*/ void <>m__Finally1();
                /*0x232ec54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x232ec5c*/ void System.Collections.IEnumerator.Reset();
                /*0x232ec9c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class ImmutableList<T> : Sirenix.Utilities.IImmutableList<T>, Sirenix.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>
        {
            /*0x0*/ System.Collections.Generic.IList<T> innerList;

            ImmutableList(System.Collections.Generic.IList<T> innerList);
            int get_Count();
            bool System.Collections.ICollection.get_IsSynchronized();
            object System.Collections.ICollection.get_SyncRoot();
            bool System.Collections.IList.get_IsFixedSize();
            bool System.Collections.IList.get_IsReadOnly();
            bool get_IsReadOnly();
            object System.Collections.IList.get_Item(int index);
            void System.Collections.IList.set_Item(int index, object value);
            T System.Collections.Generic.IList<T>.get_Item(int index);
            void System.Collections.Generic.IList<T>.set_Item(int index, T value);
            T get_Item(int index);
            bool Contains(T item);
            void CopyTo(T[] array, int arrayIndex);
            System.Collections.Generic.IEnumerator<T> GetEnumerator();
            void System.Collections.ICollection.CopyTo(System.Array array, int index);
            void System.Collections.Generic.ICollection<T>.Add(T item);
            void System.Collections.Generic.ICollection<T>.Clear();
            bool System.Collections.Generic.ICollection<T>.Remove(T item);
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            int System.Collections.IList.Add(object value);
            void System.Collections.IList.Clear();
            bool System.Collections.IList.Contains(object value);
            int System.Collections.IList.IndexOf(object value);
            void System.Collections.IList.Insert(int index, object value);
            void System.Collections.IList.Remove(object value);
            void System.Collections.Generic.IList<T>.Insert(int index, T item);
            void System.Collections.IList.RemoveAt(int index);
            int IndexOf(T item);
            void System.Collections.Generic.IList<T>.RemoveAt(int index);
        }

        class ImmutableList<TList, TElement> : Sirenix.Utilities.IImmutableList<TElement>, Sirenix.Utilities.IImmutableList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Generic.IList<TElement>, System.Collections.Generic.ICollection<TElement>, System.Collections.Generic.IEnumerable<TElement>
        {
            /*0x0*/ TList innerList;

            ImmutableList(TList innerList);
            int get_Count();
            bool System.Collections.ICollection.get_IsSynchronized();
            object System.Collections.ICollection.get_SyncRoot();
            bool System.Collections.IList.get_IsFixedSize();
            bool System.Collections.IList.get_IsReadOnly();
            bool get_IsReadOnly();
            object System.Collections.IList.get_Item(int index);
            void System.Collections.IList.set_Item(int index, object value);
            TElement System.Collections.Generic.IList<TElement>.get_Item(int index);
            void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value);
            TElement get_Item(int index);
            bool Contains(TElement item);
            void CopyTo(TElement[] array, int arrayIndex);
            System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
            void System.Collections.ICollection.CopyTo(System.Array array, int index);
            void System.Collections.Generic.ICollection<TElement>.Add(TElement item);
            void System.Collections.Generic.ICollection<TElement>.Clear();
            bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item);
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            int System.Collections.IList.Add(object value);
            void System.Collections.IList.Clear();
            bool System.Collections.IList.Contains(object value);
            int System.Collections.IList.IndexOf(object value);
            void System.Collections.IList.Insert(int index, object value);
            void System.Collections.IList.Remove(object value);
            void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item);
            void System.Collections.IList.RemoveAt(int index);
            int IndexOf(TElement item);
            void System.Collections.Generic.IList<TElement>.RemoveAt(int index);
        }

        class MathUtilities
        {
            static float ZERO_TOLERANCE = 9.999999974752427e-7;

            static /*0x232eca4*/ float PointDistanceToLine(UnityEngine.Vector3 point, UnityEngine.Vector3 a, UnityEngine.Vector3 b);
            static /*0x232ecdc*/ float Hermite(float start, float end, float t);
            static /*0x232ed14*/ float StackHermite(float start, float end, float t, int count);
            static /*0x232ed60*/ float Fract(float value);
            static /*0x232edcc*/ UnityEngine.Vector2 Fract(UnityEngine.Vector2 value);
            static /*0x232edfc*/ UnityEngine.Vector3 Fract(UnityEngine.Vector3 value);
            static /*0x232ee48*/ float BounceEaseInFastOut(float t);
            static /*0x232ee78*/ float Hermite01(float t);
            static /*0x232eea8*/ float StackHermite01(float t, int count);
            static /*0x232eee8*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float amount);
            static /*0x232ef10*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float amount);
            static /*0x232ef2c*/ float Bounce(float value);
            static /*0x232ef54*/ float EaseInElastic(float value, float amplitude, float length);
            static /*0x232f00c*/ UnityEngine.Vector3 Pow(UnityEngine.Vector3 v, float p);
            static /*0x232f068*/ UnityEngine.Vector3 Abs(UnityEngine.Vector3 v);
            static /*0x232f078*/ UnityEngine.Vector3 Sign(UnityEngine.Vector3 v);
            static /*0x232f09c*/ float EaseOutElastic(float value, float amplitude, float length);
            static /*0x232f0c0*/ float EaseInOut(float t);
            static /*0x232f0fc*/ UnityEngine.Vector3 Clamp(UnityEngine.Vector3 value, UnityEngine.Vector3 min, UnityEngine.Vector3 max);
            static /*0x232f138*/ UnityEngine.Vector2 Clamp(UnityEngine.Vector2 value, UnityEngine.Vector2 min, UnityEngine.Vector2 max);
            static /*0x232f15c*/ int ComputeByteArrayHash(byte[] data);
            static /*0x232f1e4*/ UnityEngine.Vector3 InterpolatePoints(UnityEngine.Vector3[] path, float t);
            static /*0x232f408*/ bool LineIntersectsLine(UnityEngine.Vector2 a1, UnityEngine.Vector2 a2, UnityEngine.Vector2 b1, UnityEngine.Vector2 b2, ref UnityEngine.Vector2 intersection);
            static /*0x232f588*/ UnityEngine.Vector2 InfiniteLineIntersect(UnityEngine.Vector2 ps1, UnityEngine.Vector2 pe1, UnityEngine.Vector2 ps2, UnityEngine.Vector2 pe2);
            static /*0x232f638*/ float LineDistToPlane(UnityEngine.Vector3 planeOrigin, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 lineOrigin, UnityEngine.Vector3 lineDirectionNormalized);
            static /*0x232f6f4*/ float RayDistToPlane(UnityEngine.Ray ray, UnityEngine.Plane plane);
            static /*0x232f7c4*/ UnityEngine.Vector2 RotatePoint(UnityEngine.Vector2 point, float degrees);
            static /*0x232f814*/ UnityEngine.Vector2 RotatePoint(UnityEngine.Vector2 point, UnityEngine.Vector2 around, float degrees);
            static /*0x232f884*/ float SmoothStep(float a, float b, float t);
            static /*0x232f8bc*/ float LinearStep(float a, float b, float t);
            static /*0x232f8e0*/ double Wrap(double value, double min, double max);
            static /*0x232f9a0*/ float Wrap(float value, float min, float max);
            static /*0x232fa60*/ int Wrap(int value, int min, int max);
            static /*0x232fb14*/ double RoundBasedOnMinimumDifference(double valueToRound, double minDifference);
            static /*0x232fbac*/ double DiscardLeastSignificantDecimal(double v);
            static /*0x232fd94*/ float ClampWrapAngle(float angle, float min, float max);
            static /*0x232fd0c*/ int GetNumberOfDecimalsForMinimumDifference(double minDifference);
        }

        class MemberAliasFieldInfo : System.Reflection.FieldInfo
        {
            static string FAKE_NAME_SEPARATOR_STRING = "+";
            /*0x10*/ System.Reflection.FieldInfo aliasedField;
            /*0x18*/ string mangledName;

            /*0x232febc*/ MemberAliasFieldInfo(System.Reflection.FieldInfo field, string namePrefix);
            /*0x232ff50*/ MemberAliasFieldInfo(System.Reflection.FieldInfo field, string namePrefix, string separatorString);
            /*0x232ffbc*/ System.Reflection.FieldInfo get_AliasedField();
            /*0x232ffc4*/ System.Reflection.Module get_Module();
            /*0x232ffe8*/ int get_MetadataToken();
            /*0x233000c*/ string get_Name();
            /*0x2330014*/ System.Type get_DeclaringType();
            /*0x2330038*/ System.Type get_ReflectedType();
            /*0x233005c*/ System.Type get_FieldType();
            /*0x2330080*/ System.RuntimeFieldHandle get_FieldHandle();
            /*0x23300a4*/ System.Reflection.FieldAttributes get_Attributes();
            /*0x23300c8*/ object[] GetCustomAttributes(bool inherit);
            /*0x23300f0*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
            /*0x2330118*/ bool IsDefined(System.Type attributeType, bool inherit);
            /*0x2330140*/ object GetValue(object obj);
            /*0x2330164*/ void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture);
        }

        class MemberAliasMethodInfo : System.Reflection.MethodInfo
        {
            static string FAKE_NAME_SEPARATOR_STRING = "+";
            /*0x10*/ System.Reflection.MethodInfo aliasedMethod;
            /*0x18*/ string mangledName;

            /*0x2330188*/ MemberAliasMethodInfo(System.Reflection.MethodInfo method, string namePrefix);
            /*0x233021c*/ MemberAliasMethodInfo(System.Reflection.MethodInfo method, string namePrefix, string separatorString);
            /*0x2330288*/ System.Reflection.MethodInfo get_AliasedMethod();
            /*0x2330290*/ System.Reflection.ICustomAttributeProvider get_ReturnTypeCustomAttributes();
            /*0x23302b4*/ System.RuntimeMethodHandle get_MethodHandle();
            /*0x23302d8*/ System.Reflection.MethodAttributes get_Attributes();
            /*0x23302fc*/ System.Type get_ReturnType();
            /*0x2330320*/ System.Type get_DeclaringType();
            /*0x2330344*/ string get_Name();
            /*0x233034c*/ System.Type get_ReflectedType();
            /*0x2330370*/ System.Reflection.MethodInfo GetBaseDefinition();
            /*0x2330394*/ object[] GetCustomAttributes(bool inherit);
            /*0x23303bc*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
            /*0x23303e4*/ System.Reflection.MethodImplAttributes GetMethodImplementationFlags();
            /*0x2330408*/ System.Reflection.ParameterInfo[] GetParameters();
            /*0x233042c*/ object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture);
            /*0x2330450*/ bool IsDefined(System.Type attributeType, bool inherit);
        }

        class MemberAliasPropertyInfo : System.Reflection.PropertyInfo
        {
            static string FakeNameSeparatorString = "+";
            /*0x10*/ System.Reflection.PropertyInfo aliasedProperty;
            /*0x18*/ string mangledName;

            /*0x2330478*/ MemberAliasPropertyInfo(System.Reflection.PropertyInfo prop, string namePrefix);
            /*0x233050c*/ MemberAliasPropertyInfo(System.Reflection.PropertyInfo prop, string namePrefix, string separatorString);
            /*0x2330578*/ System.Reflection.PropertyInfo get_AliasedProperty();
            /*0x2330580*/ System.Reflection.Module get_Module();
            /*0x23305a4*/ int get_MetadataToken();
            /*0x23305c8*/ string get_Name();
            /*0x23305d0*/ System.Type get_DeclaringType();
            /*0x23305f4*/ System.Type get_ReflectedType();
            /*0x2330618*/ System.Type get_PropertyType();
            /*0x233063c*/ System.Reflection.PropertyAttributes get_Attributes();
            /*0x2330660*/ bool get_CanRead();
            /*0x2330684*/ bool get_CanWrite();
            /*0x23306a8*/ object[] GetCustomAttributes(bool inherit);
            /*0x23306d0*/ object[] GetCustomAttributes(System.Type attributeType, bool inherit);
            /*0x23306f8*/ bool IsDefined(System.Type attributeType, bool inherit);
            /*0x2330720*/ System.Reflection.MethodInfo[] GetAccessors(bool nonPublic);
            /*0x2330748*/ System.Reflection.MethodInfo GetGetMethod(bool nonPublic);
            /*0x2330770*/ System.Reflection.ParameterInfo[] GetIndexParameters();
            /*0x2330794*/ System.Reflection.MethodInfo GetSetMethod(bool nonPublic);
            /*0x23307bc*/ object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
            /*0x23307e0*/ void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture);
        }

        class MultiDimArrayUtilities
        {
            static TElement[,] InsertOneColumnLeft<TElement>(TElement[,] array, int columnIndex);
            static TElement[,] InsertOneColumnRight<TElement>(TElement[,] arr, int columnIndex);
            static TElement[,] InsertOneRowAbove<TElement>(TElement[,] array, int rowIndex);
            static TElement[,] InsertOneRowBelow<TElement>(TElement[,] array, int rowIndex);
            static TElement[,] DuplicateColumn<TElement>(TElement[,] array, int columnIndex);
            static TElement[,] DuplicateRow<TElement>(TElement[,] array, int rowIndex);
            static TElement[,] MoveColumn<TElement>(TElement[,] array, int fromColumn, int toColumn);
            static TElement[,] MoveRow<TElement>(TElement[,] array, int fromRow, int toRow);
            static TElement[,] DeleteColumn<TElement>(TElement[,] array, int columnIndex);
            static TElement[,] DeleteRow<TElement>(TElement[,] array, int rowIndex);
        }

        class OdinDefineSymbols
        {
            static bool SIRENIX_INTERNAL = false;
            static bool ODIN_ASSET_STORE = true;
            static bool ODIN_TRIAL = false;
            static bool ODIN_EDUCATIONAL = false;

            /*0x2330804*/ OdinDefineSymbols();
        }

        class PersistentAssemblyAttribute : System.Attribute
        {
            /*0x233080c*/ PersistentAssemblyAttribute();
        }

        class ProjectPathFinder : UnityEngine.ScriptableObject
        {
            /*0x2330814*/ ProjectPathFinder();
        }

        class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
        {
            static /*0x0*/ Sirenix.Utilities.ReferenceEqualityComparer<T> Default;

            static ReferenceEqualityComparer();
            ReferenceEqualityComparer();
            bool Equals(T x, T y);
            int GetHashCode(T obj);
        }

        class SirenixAssetPaths
        {
            static string DefaultSirenixPluginPath = "Assets/Plugins/Sirenix/";
            static string SirenixAssetPathsSOGuid = "08379ccefc05200459f90a1c0711a340";
            static string LookupAssetName = "OdinPathLookup.asset";
            static /*0x0*/ string OdinPath;
            static /*0x8*/ string SirenixAssetsPath;
            static /*0x10*/ string SirenixPluginPath;
            static /*0x18*/ string SirenixAssembliesPath;
            static /*0x20*/ string OdinResourcesPath;
            static /*0x28*/ string OdinEditorConfigsPath;
            static /*0x30*/ string OdinResourcesConfigsPath;
            static /*0x38*/ string OdinTempPath;

            static /*0x233081c*/ SirenixAssetPaths();
            static /*0x233098c*/ string ToPathSafeString(string name, char replace);

            class <>c__DisplayClass12_0
            {
                /*0x10*/ char[] invalids;
                /*0x18*/ char replace;

                /*0x2330abc*/ <>c__DisplayClass12_0();
                /*0x2330ac4*/ char <ToPathSafeString>b__0(char c);
            }
        }

        class SirenixBuildNameAttribute : System.Attribute
        {
            /*0x10*/ string <BuildName>k__BackingField;

            /*0x2330b3c*/ SirenixBuildNameAttribute(string buildName);
            /*0x2330b2c*/ string get_BuildName();
            /*0x2330b34*/ void set_BuildName(string value);
        }

        class SirenixBuildVersionAttribute : System.Attribute
        {
            /*0x10*/ string <Version>k__BackingField;

            /*0x2330b74*/ SirenixBuildVersionAttribute(string version);
            /*0x2330b64*/ string get_Version();
            /*0x2330b6c*/ void set_Version(string value);
        }

        class SirenixEditorConfigAttribute : Sirenix.Utilities.GlobalConfigAttribute
        {
            /*0x2330b9c*/ SirenixEditorConfigAttribute();
        }

        class SirenixGlobalConfigAttribute : Sirenix.Utilities.GlobalConfigAttribute
        {
            /*0x2330c00*/ SirenixGlobalConfigAttribute();
        }

        class StringUtilities
        {
            static /*0x2330c64*/ string NicifyByteSize(int bytes, int decimals);
            static /*0x2330f1c*/ bool FastEndsWith(string str, string endsWith);
            static /*0x2330fc0*/ int NumberAwareStringCompare(string a, string b, bool ignoreLeadingZeroes, bool ignoreWhiteSpace, bool ignoreCase);
        }

        class UnityVersion
        {
            static /*0x0*/ int Major;
            static /*0x4*/ int Minor;

            static /*0x2331408*/ UnityVersion();
            static /*0x2331850*/ void EnsureLoaded();
            static /*0x2331854*/ bool IsVersionOrGreater(int major, int minor);
        }

        namespace Unsafe
        {
            class UnsafeUtilities
            {
                static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength);
                static T[] StructArrayFromBytes<T>(byte[] bytes, int byteLength, int byteOffset);
                static byte[] StructArrayToBytes<T>(T[] array);
                static byte[] StructArrayToBytes<T>(T[] array, ref byte[] bytes, int byteOffset);
                static /*0x2331914*/ string StringFromBytes(byte[] buffer, int charLength, bool needs16BitSupport);
                static /*0x2331d68*/ int StringToBytes(byte[] buffer, string value, bool needs16BitSupport);
                static /*0x23321a8*/ void MemoryCopy(object from, object to, int byteCount, int fromByteOffset, int toByteOffset);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> AEAB8CBF0F8D91747CD9D0B9512DF7A2F96DFAEA4D2FFEA89EF2654D47B721AF;

    struct __StaticArrayInitTypeSize=18
    {
    }
}
