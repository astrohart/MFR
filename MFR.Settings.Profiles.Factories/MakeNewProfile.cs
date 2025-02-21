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

using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using MFR.Settings.Profiles.Factories.Properties;
using MFR.Settings.Profiles.Interfaces;
using System;

namespace MFR.Settings.Profiles.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfile
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface.
        /// </returns>
        public static IProfile FromScratch()
            => new Profile();

        /// <summary>
        /// Assigns a name to the <paramref name="profile" /> specified.
        /// </summary>
        /// <param name="profile">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the new name to be assigned to
        /// the profile.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, or
        /// <see langword="null" /> if an error occurs.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="profile" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="name" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <remarks>
        /// This method will not check whether a profile with the specified name already
        /// exists.
        /// <para />
        /// Doing so is the job of the caller.
        /// <para />
        /// Along with assigning the specified <paramref name="profile" /> a new name, this
        /// method also generates a new GUID to use to identify the profile by.  This
        /// done because only one profile can be saved having the same name.
        /// </remarks>
        public static IProfile HavingName(this IProfile profile, string name)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            profile.Name = name;

            /*
             * Along with changing the name of a profile, we also give it a new GUID.
             */

            profile.ProfileId = Guid.NewGuid();

            return profile;
        }

        /// <summary>
        /// Extension method that converts the specified <paramref name="config" />
        /// object to a profile object.
        /// <para />
        /// the config settings in the source are copied to the new profile, and the
        /// specified <paramref name="name" /> is also assigned to the new profile.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the name to be assigned to the
        /// new profile.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface, or
        /// <see langword="null" /> if an error occurs.
        /// </returns>
        /// <remarks>
        /// This method will not check whether a profile with the specified name already
        /// exists.
        /// <para />
        /// Doing so is the job of the caller.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="name" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IProfile ToProfile(this IProjectFileRenamerConfig config,
            string name)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            return new Profile(config, name);
        }
    }
}