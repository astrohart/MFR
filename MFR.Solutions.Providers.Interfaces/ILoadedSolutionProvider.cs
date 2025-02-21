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
 */using System;
using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Solutions.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// the Visual Studio Solution (<c>*.sln</c>) files that are currently loaded in
    /// running instances of Visual Studio..
    /// </summary>
    public interface ILoadedSolutionProvider
    {
        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Each element of the collection represents a Visual Studio Solution (*.sln) that
        /// is loaded in a running instance of Visual Studio.
        /// </remarks>
        IList<IVisualStudioSolution> LoadedSolutions
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder in which the operation(s) that are selected by the user
        /// start.
        /// </summary>
        /// <remarks>
        /// If the value of this property is updated, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        string RootDirectoryPath
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property is updated.
        /// </summary>
        event EventHandler RootDirectoryPathChanged;

        /// <summary>
        /// Updates the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property with the specified folder <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the folder that should be set as the
        /// new root directory value.
        /// </param>
        /// <remarks>
        /// The term "root directory" pertains to the folder in which the operation(s)
        /// specified by the user for this application to execute, start.
        /// <para />
        /// If the argument of the <paramref name="pathname" /> parameter does not refer to
        /// a folder that exists on the file system, then this method does nothing.
        /// <para />
        /// When this method has updated the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        void SetRootDirectoryPath(string pathname);
    }
}