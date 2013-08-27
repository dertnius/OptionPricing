using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFinance.Queries
{
    class YahooQuery: Query
    {
        private string _company;
        public YahooQuery(string company) {
            this._company = company;
        }
        public override string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
       

    }
}
