using System;
using BLL.DTOs;
using BLL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace E_MACH.Controllers
{ 
    [EnableCors("*", "*", "*")]
    public class ApplicationLeaveController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/la")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ApplicationLeaveService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/la/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ApplicationLeaveService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------CREATE-------------------------*/

        [Route("api/la/add")]
        [HttpPost]
        public HttpResponseMessage Add(ApplicationLeaveDTO la)
        {
            try
            {
                var data = ApplicationLeaveService.AddApplicationLeave(la);
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

        [Route("api/la/update")]
        [HttpPost]
        public HttpResponseMessage Update(ApplicationLeaveDTO la)
        {
            try
            {
                var data = ApplicationLeaveService.Update(la);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
        /*-------------------------DELETE-------------------------*/

        [Route("api/la/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ApplicationLeaveService.Delete(id);
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
