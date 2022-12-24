using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace E_MACH.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AddToCartController : ApiController
    {
        /*-------------------------CREATE-------------------------*/

        [Route("api/addToCart/add")]
        [HttpPost]
        public HttpResponseMessage Add(AddToCartDTO addToCart)
        {
            try
            {
                var proget = ProductService.Get(addToCart.PId);
                proget.Qty = proget.Qty - 1;
                ProductService.Update(proget);
                var data = AddToCartService.AddAddToCart(addToCart);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });


        }
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/addToCart")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AddToCartService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/addToCart/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AddToCartService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------UPDATE-------------------------*/

        [Route("api/addToCart/update")]
        [HttpPost]
        public HttpResponseMessage Update(AddToCartDTO addToCart)
        {
            try
            {
                var data = AddToCartService.Update(addToCart);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
    }
}
