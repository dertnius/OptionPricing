using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinance.Queries
{
    public class YahooFinance: IFinance
    {

         void createQuery(QueryFactory factory, string company, List<string> keys) {

             Query query = factory.GetQuery();

            
        }
    
    }
}
