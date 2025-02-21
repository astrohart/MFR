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
 */

using PostSharp.Patterns.Threading;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Provides information for <c>FolderRenamed</c> event handlers.
    /// </summary>
    /// <remarks>
    /// This class is utilized in order to supply data to handlers of the
    /// <c>FolderRenamed</c> event.
    /// <para />
    /// This class has two read-only <see cref="T:System.String" /> properties,
    /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> and
    /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" />.
    /// <para />
    /// The <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> property stores
    /// the fully-qualified pathname of the previous location of a folder that has been
    /// renamed.  The <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" />
    /// property stores the fully-qualified pathname of the current location of a
    /// folder that has been renamed.
    /// <para />
    /// Callers of this class must use the class' constructor to initialize these
    /// properties.
    /// </remarks>
[ExplicitlySynchronized]
    public class FolderRenamedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.Events.FolderRenamedEventArgs" />
        /// and returns a reference to it.
        /// <para />
        /// </summary>
        /// <param name="source">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the previous location of a folder that has been renamed.
        /// </param>
        /// <param name="destination">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname of the current location of a folder that has been renamed.
        /// </param>
        /// <remarks>
        /// This constructor is utilized in order to construct a new instance of an object
        /// that supplies data to handlers of the <c>FolderRenamed</c> event.
        /// <para />
        /// This constructor has two required parameters, <paramref name="source" /> and
        /// <paramref name="destination" />.  Both must be filled in, otherwise
        /// <see cref="T:System.ArgumentException" /> is thrown.  The
        /// <paramref name="source" /> parameter should refer to the name the folder used
        /// to have, and the <paramref name="destination" /> parameter should refer to the
        /// current pathname of the folder.
        /// <para />
        /// If valid values have been passed for both the <paramref name="source" /> and
        /// <paramref name="destination" /> parameters, then this constructor sets the
        /// values of the <see cref="P:MFR.Events.FolderRenamedEventArgs.Source" /> and
        /// <see cref="P:MFR.Events.FolderRenamedEventArgs.Destination" /> properties to
        /// the corresponding parameter values.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required
        /// parameters, <paramref name="source" /> or <paramref name="destination" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public FolderRenamedEventArgs(string source, string destination)
        {
            /*
             * BOTH the source and destination parameters are mandatory.
             */

            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(destination)
                );

            Source = source;
            Destination = destination;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the current location of a folder that has been renamed.
        /// </summary>
        public string Destination
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the previous location of a folder that has been renamed.
        /// </summary>
        public string Source
        {
            get;
        }
    }
}