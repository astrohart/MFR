using MFR.Registry.Helpers;
using MFR.Registry.Writers.Interfaces;
using Microsoft.Win32;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Registry.Writers
{
    /// <summary>
    /// Writes string data to the system Registry.
    /// </summary>
    public class StringWriter : Writer<string>, IStringWriter
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Registry.Writers.StringWriter"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static StringWriter Instance
        {
            get;
        } = new StringWriter();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static StringWriter() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected StringWriter() { }

        /// <summary>
        /// Writes a data value to the system Registry key.
        /// </summary>
        /// <param name="keyName">
        /// (Required.) String containing the name of the subkey under which the
        /// value resides, or is to be written.<para/>If the key does not exist, it will be created.
        /// </param>
        /// <param name="valueName">
        /// (Required.) Name of the Registry value of type <c>REG_SZ</c> that
        /// contains the information requested.
        /// </param>
        /// <param name="data">
        /// (Required.) Value data to be written to the system Registry.
        /// </param>
        public override void ToRegistry(string keyName, string valueName,
            string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(keyName)) return;

                using (var baseKey = RegistryKey.OpenBaseKey(
                           keyName.ToRegistryHive(), RegistryView.Default
                       ))
                using (var key = baseKey.CreateSubKey(keyName.RemoveHiveName()))
                    try
                    {
                        key.SetValue(valueName, data);
                    }
                    catch (Exception ex)
                    {
                        // dump all the exception info to the log
                        DebugUtils.LogException(ex);
                    }
                    finally
                    {
                        key?.Close();
                        baseKey.Close();
                    }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}