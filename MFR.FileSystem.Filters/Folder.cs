using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFR.FileSystem.Filters
{
    public class Folder
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.FileSystem.Filters.Folder"/>.
        /// </summary>
        public static Folder Contains
        {
            get;
        } = new Folder();

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Folder() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Folder() { }
    }
}
