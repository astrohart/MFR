/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using MFR.Common.Properties;
using System;
using System.Linq;
using System.Reflection;
using xyLOGIX.Core.Debug;

namespace MFR.Common
{
    /// <summary>
    /// This class is from the Front-End for <c>Dosbox</c> and is used to present a
    /// 'vista' dialog box to select folders. Being able to use a vista style
    /// dialog box to select folders is much better then using the shell folder
    /// browser. http://code.google.com/p/fed/ Example: var r = new
    /// Reflector("System.Windows.Forms");
    /// </summary>
    public class Reflector
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Reflector" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="targetNamespace">
        /// (Required.) String containing the name of the C# namespace that
        /// contains the target object.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="targetNamespace" />
        /// , is passed a blank or
        /// <see
        ///     langword="null" />
        /// string for a value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if no referenced assemblies can be found.
        /// </exception>
        public Reflector(string targetNamespace) : this(
            targetNamespace, targetNamespace
        ) { }

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Reflector" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="targetAssembly">
        /// (Required.) String containing the name of the assembly to reflect
        /// the target object from.
        /// </param>
        /// <param name="targetNamespace">
        /// (Required.) String containing the name of the C# namespace that
        /// contains the target object.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="targetAssembly" />
        /// or <paramref name="targetNamespace" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if no referenced assemblies can be found.
        /// </exception>
        public Reflector(string targetAssembly, string targetNamespace)
        {
            if (string.IsNullOrWhiteSpace(targetAssembly))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(targetAssembly)
                );
            if (string.IsNullOrWhiteSpace(targetNamespace))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(targetNamespace)
                );

            // Dump the variable targetAssembly to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Reflector.Reflector: targetAssembly = '{targetAssembly}'"
            );

            // Dump the variable targetNamespace to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Reflector.Reflector: targetNamespace = '{targetNamespace}'"
            );

            TargetNamespace = targetNamespace;

            InitializeTargetAssembly(targetAssembly);
        }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see
        ///     cref="T:System.Reflection.Assembly" />
        /// that corresponds to the target assembly.
        /// </summary>
        public Assembly TargetAssembly
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the C# namespace that contains
        /// the target object.
        /// </summary>
        public string TargetNamespace
        {
            get;
        }

        /// <summary>
        /// Calls a method on the target object.
        /// </summary>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="func">
        /// (Required.) String containing the name of the method to be called on
        /// the target object.
        /// </param>
        /// <param name="parameters">
        /// (Required.) Zero or more parameter values to be passed to the target
        /// method as arguments.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that contains the target
        /// method's return value.
        /// </returns>
        public static object Call(object obj, string func,
            params object[] parameters)
            => Call2(obj, func, parameters);

        /// <summary>
        /// Calls a method on the target object.
        /// </summary>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="func">
        /// (Required.) String containing the name of the method to be called on
        /// the target object.
        /// </param>
        /// <param name="parameters">
        /// (Required.) Zero or more parameter values to be passed to the target
        /// method as arguments.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that contains the target
        /// method's return value.
        /// </returns>
        public static object Call2(object obj, string func, object[] parameters)
            => CallAs2(obj.GetType(), obj, func, parameters);

        /// <summary>
        /// Calls a method on the target object, with the caller masquerading as
        /// the <see cref="T:System.Type" /> specified by the
        /// <paramref
        ///     name="type" />
        /// parameter.
        /// </summary>
        /// <param name="type">
        /// (Required.) A <see cref="T:System.Type" /> that specifies the type
        /// that caller should be masqueraded as.
        /// </param>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="func">
        /// (Required.) String containing the name of the method to be called on
        /// the target object.
        /// </param>
        /// <param name="parameters">
        /// (Required.) Zero or more parameter values to be passed to the target
        /// method as arguments.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that contains the target
        /// method's return value.
        /// </returns>
        public static object CallAs(Type type, object obj, string func,
            params object[] parameters)
            => CallAs2(type, obj, func, parameters);

        /// <summary>
        /// Calls a method on the target object, with the caller masquerading as
        /// the <see cref="T:System.Type" /> specified by the
        /// <paramref
        ///     name="type" />
        /// parameter.
        /// </summary>
        /// <param name="type">
        /// (Required.) A <see cref="T:System.Type" /> that specifies the type
        /// that caller should be masqueraded as.
        /// </param>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="func">
        /// (Required.) String containing the name of the method to be called on
        /// the target object.
        /// </param>
        /// <param name="parameters">
        /// (Required.) Zero or more parameter values to be passed to the target
        /// method as arguments.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that contains the target
        /// method's return value.
        /// </returns>
        public static object CallAs2(Type type, object obj, string func,
            object[] parameters)
        {
            object result;

            try
            {
                var methodInfo = type.GetMethod(
                    func,
                    BindingFlags.Instance | BindingFlags.Public |
                    BindingFlags.NonPublic
                );

                result = methodInfo.Invoke(obj, parameters);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Masquerading as the <see cref="T:System.Type" /> value referred to by
        /// the <paramref name="type" /> command, calls the getter of a property
        /// of the target object.
        /// </summary>
        /// <param name="type">
        /// A <see cref="T:System.Type" /> that specifies which type the caller
        /// should be masqueraded as.
        /// </param>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="propertyName">
        /// (Required.) String containing the name of the target property.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.Object" /> that
        /// contains the value returned from the target property's getter accessor.
        /// <para />
        /// This method returns <see langword="null" /> if an error occurred
        /// during the process of invoking the getter.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="obj" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="propertyName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static object GetAs(Type type, object obj, string propertyName)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(propertyName)
                );

            object result;

            try
            {
                var propertyInfo = type.GetProperty(
                    propertyName,
                    BindingFlags.Instance | BindingFlags.Public |
                    BindingFlags.NonPublic
                );

                result = propertyInfo?.GetValue(obj, null);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Invokes the getter of a property of the target object.
        /// </summary>
        /// <param name="obj">
        /// (Required.) Reference to the target object.
        /// </param>
        /// <param name="propertyName">
        /// (Required.) String containing the name of the target property.
        /// </param>
        /// <returns>
        /// Reference to an instance of <see cref="T:System.Object" /> that
        /// contains the value returned from the target property's getter accessor.
        /// <para />
        /// This method returns <see langword="null" /> if an error occurred
        /// during the process of invoking the getter.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="obj" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="propertyName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public object Get(object obj, string propertyName)
            => GetAs(obj.GetType(), obj, propertyName);

        /// <summary>
        /// Given the fully-qualified <paramref name="typeName" /> of an
        /// <see
        ///     langword="enum" />
        /// , and the <paramref name="name" /> of one of its
        /// members, attempts to fetch the requested enumeration member's value
        /// from the target enumeration.
        /// </summary>
        /// <param name="typeName">
        /// (Required.) String containing the fully-qualified name of a .NET
        /// Framework enumeration type.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the name of the particular member of
        /// the enumeration whose value is to be obtained.
        /// </param>
        /// <returns>
        /// Value of the enumeration member requested, or <see langword="null" />
        /// if either the member or enumeration type requested cannot be located
        /// in the target assembly, or some other type of error has occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="typeName" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="name" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public object GetEnum(string typeName, string name)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(typeName)
                );
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(name)
                );

            object result = null;

            try
            {
                var type = GetType(typeName);
                if (type == null)
                    return result;

                var fieldInfo = type.GetField(name);
                if (fieldInfo == null)
                    return result;

                result = fieldInfo.GetValue(null);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Given a string containing the fully-qualified name of a .NET
        /// Framework type, attempts to get a reference to an instance of
        /// <see
        ///     cref="T:System.Type" />
        /// containing the reflection information for
        /// that type.
        /// </summary>
        /// <param name="typeName">
        /// (Required.) String containing the fully-qualified name of a .NET
        /// Framework type.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Type" /> instance containing the reflection
        /// information for the type whose fully-qualified name is specified.
        /// <para />
        /// If the <paramref name="typeName" /> cannot be parsed, or no such type
        /// can be located, then this method returns <see langword="null" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="typeName" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public Type GetType(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(typeName)
                );

            Type result = null;

            try
            {
                var names = typeName.Split('.');

                if (names.Length > 0)
                    if (TargetAssembly != null)
                        result = TargetAssembly.GetType(
                            TargetNamespace + "." + names[0]
                        );

                for (var i = 1; i < names.Length; ++i)
                    result = result?.GetNestedType(
                        names[i], BindingFlags.NonPublic
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Invokes the constructor of the target object, and returns a
        /// reference to an instance of the target object.
        /// </summary>
        /// <param name="typeName">
        /// (Required.) String containing the fully-qualified name of a .NET
        /// Framework type.
        /// </param>
        /// <param name="parameters">
        /// (Required.) Zero or more values to be passed to the constructor of
        /// the target object as arguments.
        /// </param>
        /// <returns>
        /// Reference to an instance of the target object resulting from the
        /// constructor that has been invoked.
        /// <para />
        /// This method returns <see langword="null" /> in the event that the
        /// specified type cannot be found in the target assembly, or if the
        /// constructor overload that should be invoked cannot be determined
        /// from the information provided, or some other error occurs.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="typeName" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        public object New(string typeName, params object[] parameters)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(typeName)
                );

            object result = null;

            try
            {
                var type = GetType(typeName);
                if (type != null)
                {
                    var ctorInfos = type.GetConstructors();

                    if (ctorInfos.Any())
                        foreach (var ci in ctorInfos)
                            try
                            {
                                result = ci.Invoke(parameters);
                            }
                            catch
                            {
                                //Ignored -- this constructor isn't the correct one to call!
                            }
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Sets up the value of the <see cref="P:MFR.Common.Reflector.TargetAssembly" />
        /// property from the specified <paramref name="targetAssembly" /> value, using the
        /// assemblies that are referenced by the executing assembly.
        /// </summary>
        /// <param name="targetAssembly">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the value that the desired assembly's name should start with.
        /// </param>
        /// <remarks>
        /// This method does nothing if the <paramref name="targetAssembly" /> parameter's
        /// argument is the blank or <see langword="null" /> <see cref="T:System.String" />
        /// value.
        /// </remarks>
        private void InitializeTargetAssembly(string targetAssembly)
        {
            try
            {
                // Dump the variable targetAssembly to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Reflector.InitializeTargetAssembly: targetAssembly = '{targetAssembly}'"
                );

                if (string.IsNullOrWhiteSpace(targetAssembly))
                    return;

                TargetAssembly = Assembly.Load(targetAssembly);
                if (TargetAssembly != null) return;

                var executingAssembly = Assembly.GetEntryAssembly();
                if (executingAssembly == null) return;
                if (string.IsNullOrWhiteSpace(executingAssembly.FullName))
                    return;

                var referencedAssemblies =
                    executingAssembly.GetReferencedAssemblies();
                if (!referencedAssemblies.Any())
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        string.Format(
                            Resources
                                .Error_NoAssembliesReferencedByExecutingAssembly,
                            executingAssembly.FullName
                        )
                    );
                    return;
                }

                var candidateTargetAssemblies = referencedAssemblies.Where(
                        assemblyName
                            => assemblyName.FullName.StartsWith(targetAssembly)
                    )
                    .ToList();
                if (candidateTargetAssemblies == null ||
                    !candidateTargetAssemblies.Any())
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        string.Format(
                            Resources.Error_DesiredTargetAssemblyNotReferenced,
                            targetAssembly, executingAssembly.FullName
                        )
                    );
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: Attempting to load the properly-referenced assembly whose name starts with '{targetAssembly}'..."
                );

                foreach (var assemblyName in candidateTargetAssemblies)
                    TargetAssembly = Assembly.Load(assemblyName);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}