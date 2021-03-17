using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassFileRenamer.Objects
{
    public interface IRegOperationResult<T>
    {
        string KeyName

        {
            get;
            set;
        }
    }
}
