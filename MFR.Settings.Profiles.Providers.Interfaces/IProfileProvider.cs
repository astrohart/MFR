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

using MFR.Events.Common;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using System.ComponentModel;

namespace MFR.Settings.Profiles.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// the user's saved configuration-settings profiles..
    /// </summary>
    public interface IProfileProvider
    {
        /// <summary>
        /// Gets or sets the fully-qualified pathname of the <c>profiles.json</c> file.
        /// </summary>
        string ProfileCollectionFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object to which a reference is returned by this properties
        /// allows access to the set of profiles defined by the user.
        /// <para />
        /// If this property is read prior to any profiles being loaded, it
        /// should return a reference the empty collection.
        /// </remarks>
        IProfileCollection Profiles
        {
            get;
        }

        /// <summary>
        /// Occurs when we are about to begin the process of loading the user's saved
        /// configuration-setting profiles from the data source.
        /// </summary>
        event CancelEventHandler LoadingProfiles;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ProfileCollectionFilePathChanged;

        /// <summary>
        /// Occurs when loading the collection of profiles has failed.
        /// </summary>
        event ExceptionRaisedEventHandler ProfileLoadFailed;

        /// <summary>
        /// Occurs when saving the collection of profiles has failed.
        /// </summary>
        event EventHandler ProfileSaveFailed;

        /// <summary>
        /// Occurs when the collection of profiles has been loaded successfully.
        /// </summary>
        event EventHandler ProfilesLoaded;

        /// <summary>
        /// Occurs when the collection of profiles has been saved successfully.
        /// </summary>
        event EventHandler ProfilesSaved;

        /// <summary>
        /// Occurs when we are about to begin the process of saving the user's saved
        /// configuration-setting profiles from the data source.
        /// </summary>
        event CancelEventHandler SavingProfiles;

        /// <summary>
        /// Loads the profiles from the profile list file.
        /// </summary>
        void Load();

        /// <summary>
        /// Saves profile list data to a file on the file system having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        void Save(string pathname = "");
    }
}