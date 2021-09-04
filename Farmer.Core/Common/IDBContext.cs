using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Farmer.Core.Common
{
   public interface IDBContext
    {
        DbConnection connection
        {
            get;
        }
    }
}
