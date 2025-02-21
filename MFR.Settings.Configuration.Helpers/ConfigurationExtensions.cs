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
 */using MFR.GUI.Controls.Interfaces;
using MFR.Settings.Configuration.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Settings.Configuration.Helpers
{
    /// <summary>
    /// Extension methods for objects implementing the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Allows us to work with the specified <paramref name="config" /> object
        /// as if it were a Profile.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that
        /// represents the specified <paramref name="config" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public static IProfile AsProfile(this IProjectFileRenamerConfig config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            return config is IProfile profile
                ? profile
                : config.ToProfile(
                    "tmp" + Guid.NewGuid()
                                 .ToString("B")
                                 .ToUpperInvariant()
                );
        }

        /// <summary>
        /// Gets the <see cref="T:MFR.TextMatchingConfiguration" /> value
        /// that corresponds to the values set in the config object, a
        /// reference to which is passed by the <paramref name="config" /> parameter.
        /// </summary>
        /// <param name="config">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// The <see cref="T:MFR.TextMatchingConfiguration" /> value that
        /// corresponds to the values of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchCase" />
        /// and
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// properties.
        /// </returns>
        public static TextMatchingConfiguration GetTextMatchingConfiguration(
            this IProjectFileRenamerConfig config)
        {
            TextMatchingConfiguration result;

            switch (config.MatchCase)
            {
                case true when !config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchCaseOnly;
                    break;

                case false when config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchExactWordOnly;
                    break;

                case true when config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchCaseAndExactWord;
                    break;

                default:
                    result = TextMatchingConfiguration
                        .NeitherMatchCaseNorExactWord;
                    break;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="config" /> actually
        /// refers to a bona fide <c>Profile</c> or whether it was simply transformed into
        /// a temporary <c>Profile</c> object (having a name beginning with <c>tmp</c>).
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="config" /> is merely a temporary <c>Profile</c> object;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsTemporaryProfile(this IProjectFileRenamerConfig config)
        {
            var result = false;

            try
            {
                if (config == null) return result;

                var correspondingProfile = config.AsProfile();
                if (correspondingProfile == null) return result;

                result = string.IsNullOrWhiteSpace(correspondingProfile.Name) ||
                         correspondingProfile.Name.StartsWith("tmp");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Saves the currently-selected Find What text item and the history to
        /// the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Find What content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentFindWhatAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.FindWhat = comboBox.EnteredText;
            config.FindWhatHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.FindWhatHistory.AddRange(comboBox.Items.Cast<string>());
        }

        /// <summary>
        /// Saves the currently-selected Replace With text item and the history
        /// to the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Replace With content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentReplaceWithAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.ReplaceWith = comboBox.EnteredText;
            config.ReplaceWithHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.ReplaceWithHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }

        /// <summary>
        /// Saves the currently-selected Starting Folder text item and the
        /// history to the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Starting Folder
        /// content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentStartingFolderAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.StartingFolder = comboBox.EnteredText;
            config.StartingFolderHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.StartingFolderHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }
    }
}