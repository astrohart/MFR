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
using MFR.Expressions.Matches.Interfaces;
using MFR.Operations.Interfaces;

namespace MFR.Expressions.Matches.Factories.Interfaces
{
    /// <summary>
    /// Creates instances of objects that implements the
    /// <see
    ///     cref="T:MFR.IMatchExpression" />
    /// interface for the
    /// various operation types.
    /// </summary>
    /// <remarks>
    /// This interface is meant to be implemented by fluent-builder objects
    /// whose behavior is affected by the specific operation type and
    /// config settings.
    /// </remarks>
    public interface IMatchExpressionFactory : IFixedOperationTypeSpecificObject,
        IConfigurationComposedObject
    {
        /// <summary>
        /// Gets or sets a string containing the pattern to be utilized as
        /// search criteria.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the text that all occurrences of
        /// the pattern in the
        /// <see
        ///     cref="P:MFR.MatchExpressionFactoryBase.ToFindWhat" />
        /// property get replaced with in the
        /// <see
        ///     cref="P:MFR.MatchExpressionFactoryBase.Value" />
        /// property.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the text data to be searched.
        /// </summary>
        string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes the value that text matching the pattern specified by
        /// the
        /// <see
        ///     cref="M:MFR.IMatchExpressionFactory.ToFindWhat" />
        /// method will be replaced with.
        /// <para />
        /// Whitespace or the empty string is only allowed for the Replace in
        /// Files operation type.
        /// </summary>
        /// <param name="replaceWith">
        /// (Optional for Replace in Files only.) String containing the text
        /// that all occurrences of text matching the pattern are to be replaced with.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpression" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// This method is the final method in the fluent-build chain,
        /// outputting an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpression" />
        /// interface as a result.
        /// <para />
        /// It is required to provide a non-blank, non-whitespace value for
        /// <paramref name="replaceWith" /> except for the Replace Text in Files operation.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="replaceWith" />, is
        /// passed a blank or <see langword="null" /> string for a value, EXCEPT
        /// for the Replace Text in Files operation type.
        /// </exception>
        IMatchExpression AndReplaceItWith(string replaceWith);

        /// <summary>
        /// Sets the text data to be searched for a pattern.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data to be searched for a pattern.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <remarks>
        /// Among the fluent-builder methods of this class, this one must be
        /// invoked first.
        /// <para />
        /// However, prior to even invoking this method, the
        /// <see
        ///     cref="M:MFR.IConfigurationComposedObject.AndAttachConfiguration" />
        /// method must be invoked; otherwise, a
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException" />
        /// will be thrown. It is incumbent upon invokers of this method to
        /// first weed out any possible elements of the source value set that
        /// may make the <paramref name="value" /> parameter get passed a blank string.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed either the empty or <see langword="null" /> string for a
        /// value. Whitespace is allowed ONLY for the Replace Text in Files
        /// operation type.
        /// </exception>
        IMatchExpressionFactory ForTextValue(string value);

        /// <summary>
        /// Initializes the match expression with the pattern to be found in the
        /// value data.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern to search the value data for.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <remarks>
        /// It is recommended to call this method after calling the
        /// <see
        ///     cref="M:MFR.IMatchExpressionFactory.ForTextValue" />
        /// method.
        /// <para />
        /// It is incumbent upon invokers of this method to first weed out any
        /// possible elements of the source value set that may make the
        /// <paramref name="findWhat" /> parameter get passed a blank string.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed either the empty string or <see langword="null" /> string for
        /// a value. Whitespace is allowed, but ONLY for the Replace Text in
        /// Files operation type.
        /// </exception>
        IMatchExpressionFactory ToFindWhat(string findWhat);
    }
}