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
 */using MFR.Settings.Configuration.Interfaces;
using System;

namespace MFR.Settings.Configuration.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// ProjectFileRenamerConfig Provider object.
    /// </summary>
    public interface IProjectFileRenamerConfigProvider
    {
        /// <summary>
        /// Gets or sets the pathname of the config file.
        /// </summary>
        /// <summary>
        /// Gets or sets the pathname of the config file.
        /// </summary>
        /// <remarks>
        /// This property raises the
        /// <see
        ///     cref="E:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider.ConfigFilePathChanged" />
        /// event when its value is updated.
        /// </remarks>
        string ConfigFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// exposes settings changed by the user in order to modify the
        /// application's behavior.
        /// </summary>
        IProjectFileRenamerConfig CurrentConfig
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.ConfigFilePath" />
        /// property is updated.
        /// </summary>
        event EventHandler ConfigFilePathChanged;

        /// <summary>
        /// Resets the config to default values.
        /// </summary>
        void Clear();

        /// <summary>
        /// Exports config data to a file other than the master
        /// config file.
        /// </summary>
        /// <param name="exportFileName">
        /// </param>
        /// <remarks>
        /// Before performing the export, the method first saves the latest
        /// settings out to the master config file.
        /// <para />
        /// It goes without saying that an alternative to calling this method in
        /// the first place is to simply call the
        /// <see
        ///     cref="M:MFR.Settings.ConfigurationProvider.Save" />
        /// method with a
        /// value for its pathname parameter.
        /// <para />
        /// However, doing this will not save the user's settings to the master
        /// file, which is important enough that we write a special method to
        /// handle this.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="exportFileName" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        void Export(string exportFileName);

        /// <summary>
        /// Imports config data from a file whose path is
        /// <paramref name="sourceFilePath" />.
        /// </summary>
        /// <param name="sourceFilePath">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file from which to import the config data.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="sourceFilePath" />,
        /// is passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="sourceFilePath" />
        /// parameter, cannot be located on the file system.
        /// </exception>
        /// <remarks>
        /// First, this method loads the data from the file specified into the
        /// application's config object.
        /// <para />
        /// Then, the method saves the new data out to the master config file.
        /// </remarks>
        void Import(string sourceFilePath);

        /// <summary>
        /// Loads the config from the file system.
        /// <para />
        /// The
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ProjectFileRenamerConfig" />
        /// property is then initialized to point to the data that has been loaded.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the pathname to a file to be loaded
        /// from disk, that contains the config data in JSON format.
        /// <para />
        /// If this value is blank, then the file whose path is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath" />
        /// property is used instead.
        /// </param>
        /// <remarks>
        /// The value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ProjectFileRenamerConfig" />
        /// property is set to <see langword="null" /> if an error occurs during loading.
        /// </remarks>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which has been initialized with data from the config file.
        /// </returns>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file whose pathname is passed in the
        /// <paramref
        ///     name="pathname" />
        /// parameter cannot be located on the file system.
        /// </exception>
        IProjectFileRenamerConfig Load(string pathname = "");

        /// <summary>
        /// Saves config data to a file on the file system having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Providers.ConfigurationProvider.ConfigFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        void Save(string pathname = "");
    }
}