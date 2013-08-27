using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinance.Queries
{
    abstract class QueryFactory
    {
        public abstract Query GetQuery();
    }
}
