using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebStore.Entities.WCF.Products;

namespace WebStoreWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebStoreServices" in both code and config file together.
    [ServiceContract]
    public interface IWebStoreServices
    {
        [OperationContract]
        DTOProductsResponse GetProducts();

        [OperationContract]
        DTOProductsResponse SetProducts(DTOPRoductsRequest request);
    }
}