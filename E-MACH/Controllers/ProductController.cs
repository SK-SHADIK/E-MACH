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

    public class ProductController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/product")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/product/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ProductService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------CREATE-------------------------*/

        [Route("api/product/add")]
        [HttpPost]
        public HttpResponseMessage Add(ProductDTO product)
        {
            try
            {
                var data = ProductService.AddProduct(product);
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
        /*-------------------------UPDATE-------------------------*/

        [Route("api/product/update")]
        [HttpPost]
        public HttpResponseMessage Update(ProductDTO product)
        {
            try
            {
                var data = ProductService.Update(product);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
        /*-------------------------DELETE-------------------------*/

        [Route("api/product/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ProductService.Delete(id);
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
