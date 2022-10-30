using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Entities;
using WebStore.Entities.WCF;
using WebStore.Entities.WCF.Products;
using WebStroe.CommonTools;

namespace WebStoreBussines
{
    public class WebStoreBL
    {
        WebnStoreDAL webStoreDAL;

        public WebStoreBL()
        {
            webStoreDAL = new WebnStoreDAL();
        }

        public DTOProductsResponse GetProducts()
        {

            DTOProductsResponse res = new DTOProductsResponse();
            DTOResult result = new DTOResult();
            res.Body = webStoreDAL.GetProducts();
            result.Code = Enums.ResponseCode.OK;
            result.Messaje = Tools.GetEnumDescription<Enums.ResponseCode>(Enums.ResponseCode.OK);
            res.Result = result;
            return res;
        }
        public DTOResult SetProducts(DTOPRoductsRequest request)
        {

            DTOResult res = new DTOResult();

            webStoreDAL.SetProducts(request);
            res.Code = Enums.ResponseCode.OK;
            res.Messaje = Tools.GetEnumDescription<Enums.ResponseCode>(Enums.ResponseCode.OK);
            return res;
        }
    }
}
