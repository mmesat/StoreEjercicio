using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Entities.WCF.Products
{
    public class DTOProductsResponse
    {
        /// <summary>
        /// The body of entity response
        /// </summary>
        [DataMember]
        public List<DTOProductsBody> Body { get; set; }
        /// <summary>
        /// The technical Response.
        /// </summary>
        [DataMember]
        public DTOResult Result { get; set; }
    }
}
