using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_MACH.Controllers
{
    public class FishermanController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/fisherman")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = FishermanService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);            
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/fisherman/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = FishermanService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------CREATE-------------------------*/

        [Route("api/fisherman/add")]
        [HttpPost]
        public HttpResponseMessage Add(FishermanDTO fisherman)
        {
            try
            {
                var data = FishermanService.AddFisherman(fisherman);
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

        [Route("api/fisherman/update")]
        [HttpPost]
        public HttpResponseMessage Update(FishermanDTO fisherman)
        {
            try
            {
                var data = FishermanService.Update(fisherman);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
        /*-------------------------DELETE-------------------------*/

        [Route("api/fisherman/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = FishermanService.Delete(id);
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
