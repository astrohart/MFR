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
 */using PostSharp.Patterns.Threading;
using MFR.FileSystem.Retrievers.Factories;
using MFR.Operations.Constants;
using MFR.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.FileSystem.Retrievers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Retrievers.SolutionFilePathRetriever" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class SolutionFilePathRetrieverTests
    {
        /// <summary>
        /// String containing the path to the root folder to use for the search.
        /// </summary>
        private static readonly string ROOT_FOLDER = Path.Combine(
            Environment.ExpandEnvironmentVariables("%USERPROFILE%"),
            @"source\repos\astrohart"
        );

        /// <summary>
        /// Unit test to ensure that the object used to retrieve solution file pathnames
        /// works correctly.
        /// </summary>
        [Test]
        public void Test_Retriever_Works()
        {
            Assert.That(!string.IsNullOrWhiteSpace(ROOT_FOLDER));

            Assert.That(Directory.Exists(ROOT_FOLDER));

            /*
             * Have the retriever scan the ROOT_FOLDER for the pathnames
             * of all *.sln files within, including sub-folders. Then,
             * write them all out to the console.
             */
            var paths = new List<string>();

            Assert.DoesNotThrow(
                () => paths = GetFileSystemEntryListRetriever.For(
                        OperationType.ScanDirectoryTreeForSolutionFiles
                    )
                    .WithSearchOption(SearchOption.AllDirectories)
                    .GetMatchingFileSystemPaths(ROOT_FOLDER)
                    .Select(fse => fse.Path)
                    .ToList()
            );

            /*
             * Ensure that the paths variable does not have a null reference.
             * The call above should have worked and given us a list of
             * pathnames.
             */
            Assert.That(paths, Is.Not.Null);

            /*
             * Check that more than zero pathnames were returned.
             */
            Assert.That(paths.Any());

            /*
             * Check that all the pathnames end with the .sln file
             * extension.
             */

            Assert.That(
                paths.All(s => ".sln".Equals(Path.GetExtension(s)))
            );

            this.DumpStringsToConsole(paths);
        }
    }
}