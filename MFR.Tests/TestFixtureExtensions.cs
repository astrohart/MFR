using System;
using System.Collections.Generic;
using System.Linq;

namespace MFR.Tests
{
    /// <summary>
    /// Exposes static methods to extend the functionality of test fixtures.
    /// </summary>
    public static class TestFixtureExtensions
    {
        /// <summary>
        /// Dumps a collection of strings to the console, one element per line.
        /// </summary>
        /// <param name="fixture">
        /// (Required.) Reference to an object that is the test
        /// fixture being used.
        /// </param>
        /// <param name="list">
        /// (Required.) Reference to an enumerable collection of
        /// <see cref="T:System.String" /> that represents the list to be dumped.
        /// </param>
        /// <remarks>
        /// If the <paramref name="list" /> parameter is <see langword="null" /> or
        /// contains zero elements, then the method does nothing but print an error
        /// message.
        /// <para />
        /// Otherwise, the list is written to <see cref="P:System.Console.Out" />, one
        /// element per line.
        /// </remarks>
        public static void DumpStringsToConsole(this object fixture,
            IEnumerable<string> list)
        {
            if (list == null || !list.Any()) return;    // nothing to do

            foreach (var element in list) Console.WriteLine(element);
        }
    }
}