using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CumLoader
{
    public class CumLogger
    {
        public static void Log(string s)
        {
            string namesection = GetNameSection();
            Native_Log(namesection, s);
            CumConsole.RunLogCallbacks(namesection, s);
        }

        public static void Log(ConsoleColor color, string s)
        {
            string namesection = GetNameSection();
            Native_LogColor(namesection, s, color);
            CumConsole.RunLogCallbacks(namesection, s);
        }

        public static void Log(string s, params object[] args)
        {
            string namesection = GetNameSection();
            string fmt = string.Format(s, args);
            Native_Log(namesection, fmt);
            CumConsole.RunLogCallbacks(namesection, fmt);
        }

        public static void Log(ConsoleColor color, string s, params object[] args)
        {
            string namesection = GetNameSection();
            string fmt = string.Format(s, args);
            Native_LogColor(namesection, fmt, color);
            CumConsole.RunLogCallbacks(namesection, fmt);
        }

        public static void Log(object o)
        {
            Log(o.ToString());
        }

        public static void Log(ConsoleColor color, object o)
        {
            Log(color, o.ToString());
        }

        public static void LogWarning(string s)
        {
            string namesection = GetNameSection();
            Native_LogWarning(namesection, s);
            CumConsole.RunWarningCallbacks(namesection, s);
        }

        public static void LogWarning(string s, params object[] args)
        {
            string namesection = GetNameSection();
            string fmt = string.Format(s, args);
            Native_LogWarning(namesection, fmt);
            CumConsole.RunWarningCallbacks(namesection, fmt);
            Native_LogWarning(GetNameSection(), fmt);
        }

        public static void LogError(string s)
        {
            string namesection = GetNameSection();
            Native_LogError(namesection, s);
            CumConsole.RunErrorCallbacks(namesection, s);
        }
        public static void LogError(string s, params object[] args)
        {
            string namesection = GetNameSection();
            string fmt = string.Format(s, args);
            Native_LogError(namesection, fmt);
            CumConsole.RunErrorCallbacks(namesection, fmt);
        }

        internal static void LogCumError(string msg, string modname)
        {
            string namesection = (string.IsNullOrEmpty(modname) ? "" : ("[" + modname.Replace(" ", "_") + "] "));
            Native_LogCumError(namesection, msg);
            CumConsole.RunErrorCallbacks(namesection, msg);
        }

        internal static void LogCumCompatibility(CumBase.CumCompatibility comp) => Native_LogCumCompatibility(comp);

        internal static string GetNameSection()
        {
            StackTrace st = new StackTrace(2, true);
            StackFrame sf = st.GetFrame(0);
            if (sf != null)
            {
                MethodBase method = sf.GetMethod();
                if (!method.Equals(null))
                {
                    Type methodClassType = method.DeclaringType;
                    if (!methodClassType.Equals(null))
                    {
                        Assembly asm = methodClassType.Assembly;
                        if (!asm.Equals(null))
                        {
                            CumPlugin plugin = CumHandler.CumPlugins.Find(x => (x.Assembly == asm));
                            if (plugin != null)
                            {
                                if (!string.IsNullOrEmpty(plugin.Info.Name))
                                    return "[" + plugin.Info.Name.Replace(" ", "_") + "] ";
                            }
                            else
                            {
                                CumMod mod = CumHandler.CumMods.Find(x => (x.Assembly == asm));
                                if (mod != null)
                                {
                                    if (!string.IsNullOrEmpty(mod.Info.Name))
                                        return "[" + mod.Info.Name.Replace(" ", "_") + "] ";
                                }
                            }
                        }
                    }
                }
            }
            return "";
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_Log(string namesection, string txt);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_LogColor(string namesection, string txt, ConsoleColor color);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_LogWarning(string namesection, string txt);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_LogError(string namesection, string txt);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_LogCumError(string namesection, string txt);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_LogCumCompatibility(CumBase.CumCompatibility comp);
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern static void Native_ThrowInternalError(string txt);
        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static IntPtr Native_GetConsoleOutputHandle();
    }
}