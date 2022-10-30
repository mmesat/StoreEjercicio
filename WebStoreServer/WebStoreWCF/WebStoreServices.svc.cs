using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebStore.Entities;
using WebStore.Entities.WCF;
using WebStore.Entities.WCF.Products;
using WebStoreBussines;
using WebStroe.CommonTools;

namespace WebStoreWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebStoreServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WebStoreServices.svc or WebStoreServices.svc.cs at the Solution Explorer and start debugging.
    public class WebStoreServices : IWebStoreServices
    {


        public DTOProductsResponse GetProducts()
        {
            DTOProductsResponse ret = new DTOProductsResponse();
            ServiceTrace trace = new ServiceTrace();


            try
            {
                #region Trace
                trace.Operation = MethodBase.GetCurrentMethod().Name;
                trace.ExecutionDate = DateTime.Now;
                #endregion

                WebStoreBL webstoreBL = new WebStoreBL();
                ret = webstoreBL.GetProducts();

                #region Traza
                trace.Response = Tools.Serialize(ret);
                #endregion
            }
            catch (Exception ex)
            {
                DTOResult res = new DTOResult();
                res.Code = Enums.ResponseCode.InternalServiceError;
                res.Messaje = Tools.GetEnumDescription<Enums.ResponseCode>(Enums.ResponseCode.InternalServiceError);
                res.StackError = ex.Message + " - " + ex.StackTrace;
                trace.ExceptionDetails = ex.Message + " - " + ex.StackTrace;
                ret.Result = res;
                #region Trace
                trace.Response = Tools.Serialize(ret);
                #endregion

            }
            finally
            {
                SaveLog(trace);
            }

            return ret;
        }

        public DTOProductsResponse SetProducts(DTOPRoductsRequest request)
        {
            DTOProductsResponse ret = new DTOProductsResponse() ;
            ServiceTrace trace = new ServiceTrace();


            try
            {
                #region Trace
                trace.Operation = MethodBase.GetCurrentMethod().Name;
                trace.ExecutionDate = DateTime.Now;
                trace.Request = Tools.Serialize(request);
                #endregion
                WebStoreBL webstoreBL = new WebStoreBL();
                ret.Result = webstoreBL.SetProducts(request);
                #region Traza
                trace.Response = Tools.Serialize(ret);
                #endregion
            }
            catch (Exception ex)
            {
                DTOResult res = new DTOResult();
                res.Code = Enums.ResponseCode.InternalServiceError;
                res.Messaje = Tools.GetEnumDescription<Enums.ResponseCode>(Enums.ResponseCode.InternalServiceError);
                res.StackError = ex.Message + " - " + ex.StackTrace;
                trace.ExceptionDetails = ex.Message + " - " + ex.StackTrace;
                ret.Result = res;
                #region Trace
                trace.Response = Tools.Serialize(ret);
                #endregion

            }
            finally
            {
                SaveLog(trace);
            }

            return ret;
        }

        private void SaveLog(ServiceTrace trace)
        {
            //Some trace of all operations to be implemente here. Save on log file, database, service altern, etc... For the assesment I thing this is not neccesary.
        }
    }
}
