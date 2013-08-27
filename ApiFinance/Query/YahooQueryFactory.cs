using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinance.Queries
{
    class YahooQueryFactory:QueryFactory 
    {
        private string _company;
        

        public YahooQueryFactory(string company, List<string> keys) {

            _company = company;
        
        }

        public override Query GetQuery()
        {
            return new YahooQuery(_company); 
        }
    }
}
