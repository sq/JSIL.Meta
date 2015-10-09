#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using JSIL.Meta;

namespace JSIL {
    public static class Verbatim {
        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        public static dynamic Expression (string javascript) {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="variables">The variables to insert into the expression.</param>
        public static dynamic Expression (string javascript, params object[] variables) {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        public static dynamic Expression<TArg0>(string javascript, TArg0 arg0)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1>(string javascript, TArg0 arg0, TArg1 arg1)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2, TArg3>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2, TArg3, TArg4>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        /// <param name="arg6">The variables to insert into '$6' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        /// <param name="arg6">The variables to insert into '$6' placeholder in the expression.</param>
        /// <param name="arg7">The variables to insert into '$7' placeholder in the expression.</param>
        public static dynamic Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            return null;
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        public static T Expression<T> (string javascript) {
            return default(T);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="variables">The variables to insert into the expression.</param>
        public static T Expression<T> (string javascript, params object[] variables) {
            return default(T);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TResult>(string javascript, TArg0 arg0)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TResult>(string javascript, TArg0 arg0, TArg1 arg1)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TArg3, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        /// <param name="arg6">The variables to insert into '$6' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            return default(TResult);
        }

        /// <summary>
        /// When running as C#, this method does nothing and returns null.
        /// When running as JavaScript, the passed-in script code replaces this method call.
        /// Variables can be referenced by index. '$0' is the first variable.
        /// </summary>
        /// <param name="javascript">The script expression.</param>
        /// <param name="arg0">The variables to insert into '$0' placeholder in the expression.</param>
        /// <param name="arg1">The variables to insert into '$1' placeholder in the expression.</param>
        /// <param name="arg2">The variables to insert into '$2' placeholder in the expression.</param>
        /// <param name="arg3">The variables to insert into '$3' placeholder in the expression.</param>
        /// <param name="arg4">The variables to insert into '$4' placeholder in the expression.</param>
        /// <param name="arg5">The variables to insert into '$5' placeholder in the expression.</param>
        /// <param name="arg6">The variables to insert into '$6' placeholder in the expression.</param>
        /// <param name="arg7">The variables to insert into '$7' placeholder in the expression.</param>
        public static TResult Expression<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(string javascript, TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            return default(TResult);
        }
    }
}
