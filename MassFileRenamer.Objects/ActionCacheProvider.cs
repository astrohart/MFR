using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassFileRenamer.Objects
{
    public static class ActionCacheProvider<TInput, TResult> where TInput : class where TResult : class
    {
        /// <summary>
        /// Cache of already-processed results.
        /// </summary>
        public static IDictionary<TInput, TResult> ResultCache
        {
            get;
        } = new Dictionary<TInput, TResult>();
    }
}
