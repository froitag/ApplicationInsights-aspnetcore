﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.ApplicationInsights.AspNetCore {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.ApplicationInsights.AspNetCore.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to      &lt;script type=&quot;text/javascript&quot;&gt;
        ///        var appInsights=window.appInsights||function(n){{
        ///            function t(n){{i[n]=function(){{var t=arguments;i.queue.push(function(){{i[n].apply(i,t)}})}}}}var i={{config:n}},u=document,e=window,o=&quot;script&quot;,s=&quot;AuthenticatedUserContext&quot;,h=&quot;start&quot;,c=&quot;stop&quot;,l=&quot;Track&quot;,a=l+&quot;Event&quot;,v=l+&quot;Page&quot;,y=u.createElement(o),r,f;y.src=n.url||&quot;//az416426.vo.msecnd.net/scripts/a/ai.0.js&quot;;u.getElementsByTagName(o)[0].parentNode.appendChild(y);try{{i.cookie=u.cookie}}catch(p){{}}for( [rest of string was truncated]&quot;;.
        /// </summary>
        public static string JavaScriptSnippet {
            get {
                return ResourceManager.GetString("JavaScriptSnippet", resourceCulture);
            }
        }
    }
}