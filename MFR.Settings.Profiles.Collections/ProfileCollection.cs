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

using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Collections
{
    /// <summary>
    /// Implements the methods and properties of a <c>Profile Collection</c>
    /// object.
    /// </summary>
    /// <remarks>
    /// A <c>Profile Collection</c> object is just that -- a container for
    /// <c>Profile</c> s.
    /// </remarks>
    public class ProfileCollection : Collection<IProfile>, IProfileCollection
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Collections.ProfileCollection" /> and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// The object instance reference returned by this constructor represents the empty
        /// collection.
        /// </remarks>
        public ProfileCollection()
        {
            // Default constructor
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Collections.ProfileCollection" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true), JsonConstructor]
        public ProfileCollection(IEnumerable<IProfile> profiles)
        {
            if (profiles == null) return;

            foreach (var profile in profiles)
                Add(profile);
        }

        /// <summary>
        /// A <see cref="T:System.Guid" /> that delineates which profile is
        /// currently "active" i.e., is in use.
        /// </summary>
        public Guid ActiveProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the empty <c>ProfileCollection</c>.
        /// </summary>
        public static IProfileCollection Empty
        {
            get;
        } = new ProfileCollection();

        /// <summary>
        /// Determines whether the profile collection already has a profile with the
        /// name provided.
        /// <para />
        /// There can only be one profile with a given name, case-insensitive.
        /// </summary>
        /// <param name="name">(Required.) Name of the profile to be searched for.</param>
        /// <returns>
        /// <see langword="true" /> if a profile having the given name is found;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public bool HasProfileNamed(string name)
        {
            var result = false;

            try
            {
                if (Count == 0) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;

                result = Items.Any(
                    profile => name.ToLowerInvariant()
                                   .Equals(profile.Name.ToLowerInvariant())
                );
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
        /// Removes all of those elements from the collection that satisfy the specified
        /// <paramref name="predicate" />.
        /// </summary>
        /// <param name="predicate">
        /// (Required.) A predicate that returns
        /// <see langword="true" /> if a specific item is to be removed from the
        /// collection.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the element(s) matching the specified
        /// <paramref name="predicate" /> were removed successfully, or if the collection
        /// is empty; <see langword="false" /> otherwise.
        /// </returns>
        public bool RemoveAll(Predicate<IProfile> predicate)
        {
            var result = true;

            try
            {
                if (Count == 0) return result;
                if (predicate == null) return result;

                for (var i = Count - 1; i >= 0; i--)
                {
                    if (!predicate(this[i])) continue;

                    RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}