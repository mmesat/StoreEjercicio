using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Entities.WCF.Products;
using WebStroe.CommonTools;

namespace WebStore.Data
{
    public class WebnStoreDAL
    {
        public List<DTOProductsBody> GetProducts()
        {
            List<DTOProductsBody> Body = null;
            using (SqlConnection conexion = new SqlConnection(ConfigurationWS.GetDBStringConection()))
            {

                Body = conexion.Query<DTOProductsBody>("dbo.SP_GetPRoducts", transaction: null, buffered: false, commandTimeout: null, commandType: CommandType.StoredProcedure).ToList();
            }

            return Body;
        }

        public void SetProducts(DTOPRoductsRequest request)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductName", request.ProductName);
            parameters.Add("@Description", request.Description);
            int result = 0;
            using (SqlConnection conexion = new SqlConnection(ConfigurationWS.GetDBStringConection()))
            {

              conexion.Execute("dbo.SP_SetProducts", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }


        }   
    }
}
