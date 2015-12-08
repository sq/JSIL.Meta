#pragma warning disable 1591
namespace JSIL {
    using System;

    using JSIL.Meta;

    public abstract class JsObject
    {
        //Should work same as Builtins.Global[key]
        public static JsObject Global(string key)
        {
            throw new NotSupportedException("Not available outside JS");
        }
    }

    public abstract class JsFunction
    {
    }

    public static class JsObjectHelpers
    {
        [JSReplacement("$target[$key]")]
        public static JsObject Get(this JsObject target, string key)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("($target[$key] = $value)")]
        public static void Set<TValue>(this JsObject target, string key, TValue value)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("($key in $target)")]
        public static bool In(this JsObject target, string key)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("(delete $target[$key])")]
        public static void Delete(this JsObject target, string key)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]()")]
        public static JsObject Call(this JsFunction target, string key)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1)")]
        public static JsObject Call<TArg1>(this JsFunction target, string key, TArg1 arg1)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2)")]
        public static JsObject Call<TArg1, TArg2>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3)")]
        public static JsObject Call<TArg1, TArg2, TArg3>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3, $arg4)")]
        public static JsObject Call<TArg1, TArg2, TArg3, TArg4>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3, $arg4, $arg5)")]
        public static JsObject Call<TArg1, TArg2, TArg3, TArg4, TArg5>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3, $arg4, $arg5, $arg6)")]
        public static JsObject Call<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7)")]
        public static JsObject Call<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target[$key]($arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7, $arg8)")]
        public static JsObject Call<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this JsFunction target, string key, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null)")]
        public static JsObject Invoke(this JsFunction target)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1)")]
        public static JsObject Invoke<TArg1>(this JsFunction target, TArg1 arg1)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2)")]
        public static JsObject Invoke<TArg1, TArg2>(this JsFunction target, TArg1 arg1, TArg2 arg2)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3, $arg4)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3, TArg4>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3, $arg4, $arg5)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3, TArg4, TArg5>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3, $arg4, $arg5, $arg6)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$target.call(null, $arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7, $arg8)")]
        public static JsObject Invoke<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target()")]
        public static JsObject New(this JsFunction target)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1)")]
        public static JsObject New<TArg1>(this JsFunction target, TArg1 arg1)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2)")]
        public static JsObject New<TArg1, TArg2>(this JsFunction target, TArg1 arg1, TArg2 arg2)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3)")]
        public static JsObject New<TArg1, TArg2, TArg3>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3, $arg4)")]
        public static JsObject New<TArg1, TArg2, TArg3, TArg4>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3, $arg4, $arg5)")]
        public static JsObject New<TArg1, TArg2, TArg3, TArg4, TArg5>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3, $arg4, $arg5, $arg6)")]
        public static JsObject New<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7)")]
        public static JsObject New<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("new $target($arg1, $arg2, $arg3, $arg4, $arg5, $arg6, $arg7, $arg8)")]
        public static JsObject New<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this JsFunction target, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            throw new NotSupportedException("Not available outside JS");
        }


        [JSReplacement("$obj")]
        public static T AssumeType<T>(this JsObject obj)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$T.$$As($obj)")]
        public static T As<T>(this JsObject obj) where T : class
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$T.$$Cast($obj)")]
        public static T Cast<T>(this JsObject obj)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        [JSReplacement("$T.$$Is($obj)")]
        public static bool Is<T>(this JsObject obj)
        {
            throw new NotSupportedException("Not available outside JS");
        }

        // Will wrap JS object in adapter, that implement interface T
        // If T is not interface, than work same as Cast 
        //public static T Adapt<T>(this JsObject obj)
        //{
        //    throw new NotSupportedException("Not available outside JS");
        //}
    }
}
