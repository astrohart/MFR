using System;
using System.Linq;
using System.Reflection;

namespace MFR.Objects
{
    /// <summary>
    /// This class is from the Front-End for Dosbox and is used to present a
    /// 'vista' dialog box to select folders. Being able to use a vista style
    /// dialog box to select folders is much better then using the shell folder
    /// browser. http://code.google.com/p/fed/ Example: var r = new Reflector("System.Windows.Forms");
    /// </summary>
    public class Reflector
    {
        private readonly Assembly m_asmb;

        private readonly string m_ns;

        public Reflector(string ns)
            : this(ns, ns)
        {
        }

        public Reflector(string an, string ns)
        {
            // ReSharper disable once UnusedVariable
            var type = typeof(Form);

            m_ns = ns;

            m_asmb = null;

            var executingAssembly = Assembly.GetEntryAssembly();
            var referencedAssemblies = executingAssembly.GetReferencedAssemblies();

            foreach (var assemblyName in referencedAssemblies.Where(assemblyName => assemblyName.FullName.StartsWith(an)))
            {
                m_asmb = Assembly.Load(assemblyName);
                break;
            }
        }

        public static object Call(object obj, string func, params object[] parameters)
        {
            return Call2(obj, func, parameters);
        }

        public static object Call2(object obj, string func, object[] parameters)
        {
            return CallAs2(obj.GetType(), obj, func, parameters);
        }

        public static object CallAs(Type type, object obj, string func, params object[] parameters)
        {
            return CallAs2(type, obj, func, parameters);
        }

        public static object CallAs2(Type type, object obj, string func, object[] parameters)
        {
            var methInfo = type.GetMethod(func, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            return methInfo.Invoke(obj, parameters);
        }

        public static object GetAs(Type type, object obj, string prop)
        {
            var propInfo = type.GetProperty(prop, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            return propInfo.GetValue(obj, null);
        }

        public object Get(object obj, string prop)
        {
            return GetAs(obj.GetType(), obj, prop);
        }

        public object GetEnum(string typeName, string name)
        {
            var type = GetType(typeName);

            var fieldInfo = type.GetField(name);

            return fieldInfo.GetValue(null);
        }

        public Type GetType(string typeName)
        {
            Type type = null;

            var names = typeName.Split('.');

            if (names.Length > 0)
            {
                if (m_asmb != null)
                {
                    type = m_asmb.GetType(m_ns + "." + names[0]);
                }
            }

            for (var i = 1; i < names.Length; ++i)
            {
                if (type != null)
                {
                    type = type.GetNestedType(names[i], BindingFlags.NonPublic);
                }
            }

            return type;
        }

        public object New(string name, params object[] parameters)
        {
            var type = GetType(name);

            var ctorInfos = type.GetConstructors();

            foreach (var ci in ctorInfos)
            {
                try
                {
                    return ci.Invoke(parameters);
                }
                catch
                {
                    // ignored
                }
            }

            return null;
        }
    }
}