using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Entities.WCF
{
    public class DTOResult
    {
        public Enums.ResponseCode Code { get; set; }
        public string Messaje { get; set; }
        public string StackError { get; set; }
    }
}
