using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace ApiFinance
{
    public class Result
    {
        public XmlDocument XmlResult { get; set; }
        public List<string> ListCompanies { get; set; }
        
    }
}
