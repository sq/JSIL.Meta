#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSIL {
    public sealed class JSGlobal {
        /// <summary>
        /// Retrieves a name from the global namespace (note that this is the global namespace at the time that the JSIL runtime was loaded).
        /// </summary>
        /// <param name="name">The name to retrieve. This may be a literal, or a string-producing expression.</param>
        public JsObject this[string name] {
            get {
                throw new NotSupportedException("Not available outside JS");
            }
        }
    }

    public sealed class JSLocal {
        /// <summary>
        /// Retrieves a name from the local namespace.
        /// </summary>
        /// <param name="name">The name to retrieve. This must be a string literal!</param>
        public JsObject this[string name] {
            get {
                throw new NotSupportedException("Not available outside JS");
            }
        }
    }

    public static class Builtins {
        public static readonly JSGlobal Global = new JSGlobal();
        public static readonly JSLocal Local = new JSLocal();

        /// <summary>
        /// When running as C#, this method throws NotSupportedException.
        /// When running as JavaScript, this method call is replaced with an invocation of the builtin javascript eval function.
        /// </summary>
        /// <param name="expression">The expression to evaluate.</param>
        public static JsObject Eval (string expression) {
            throw new NotSupportedException("Not available outside JS");
        }

        /// <summary>
        /// When running as C#, this method throws NotSupportedException.
        /// When running as JavaScript, this method call is replaced with an invocation of the builtin JSIL CreateNamedFunction utility.
        /// </summary>
        public static T CreateNamedFunction<T> (
            string functionName,
            string[] argumentNames,
            string body,
            object closure = null
        ) {
            throw new NotSupportedException("Not available outside JS");
        }

        public static bool IsTruthy (dynamic value) {
            throw new NotImplementedException("Not available outside JS");
        }

        public static bool IsFalsy (dynamic value) {
            throw new NotImplementedException("Not available outside JS");
        }

        /// <summary>
        /// When running as javascript, this property evaluates to the current scope's this-reference.
        /// </summary>
        public static JsObject This {
            get {
                throw new NotSupportedException("Not available outside JS");
            }
        }

        /// <summary>
        /// When running as javascript, this property evaluates to true.
        /// </summary>
        public static bool IsJavascript {
            get {
                return false;
            }
        }
    }

    public static class Services {
        /// <summary>
        /// When running as C#, this method throws (or returns null if throwIfMissing==false).
        /// When running as JavaScript this method returns a reference to the named runtime service.
        /// </summary>
        /// <param name="serviceName">The name of the runtime service.</param>
        public static JsObject Get (string serviceName, bool throwIfMissing = true) {
            if (throwIfMissing)
                throw new NotImplementedException("Services.get is only available at runtime and you passed true for throwIfMissing.");
            else
                return null;
        }
    }
}
