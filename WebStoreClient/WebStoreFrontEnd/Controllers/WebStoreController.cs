using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreFrontEnd.Models;
using WebStoreFrontEnd.WebStoreService;

namespace WebStoreFrontEnd.Controllers
{
    public class WebStoreController : Controller
    {


        WebStoreService.WebStoreServicesClient _serviceWebStore = new WebStoreService.WebStoreServicesClient();
        // GET: WebStore
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetProducts()
        {
            List<ProductsModel> Model = new List<ProductsModel>();
            DTOProductsResponse Response = new DTOProductsResponse();
            ProductsModel productsModel;
            Response = _serviceWebStore.GetProducts();

            foreach (DTOProductsBody res in Response.Body)
            {
                productsModel = new ProductsModel();
                productsModel.Id = res.id;
                productsModel.Description = res.Description;
                productsModel.ProductName = res.ProductName;
                Model.Add(productsModel);
                
            }
            return View(Model);
        }

        public ActionResult CreateProducts(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                DTOProductsResponse Response = new DTOProductsResponse();
                DTOPRoductsRequest request = new DTOPRoductsRequest();

                request.Description = model.Description;
                request.ProductName = model.ProductName;
                Response = _serviceWebStore.SetProducts(request);
                if (Response.Result.Code == EnumsResponseCode.OK)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Saved'); window.location = '/WebStore/CreatePRoducts';</script>");
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Contact an Adminsitrator'); window.location = '/WebStore/CreatePRoducts'</script>");
                }
            }
            return View(model);
        }
    }
}