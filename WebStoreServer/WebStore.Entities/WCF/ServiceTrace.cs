using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Entities.WCF
{
    public class ServiceTrace
    {
        public string Operation { get; set; }

        public string Request { get; set; }

        public string Response { get; set; }

        public string ExceptionDetails { get; set; }

        public DateTime ExecutionDate { get; set; }

        public string CustomerIP { get; set; }
    }
}
