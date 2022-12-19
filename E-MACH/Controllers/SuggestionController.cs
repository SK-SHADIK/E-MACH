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

    public class SuggestionController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/suggestion")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SuggestionService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/suggestion/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SuggestionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------CREATE-------------------------*/

        [Route("api/suggestion/add")]
        [HttpPost]
        public HttpResponseMessage Add(SuggestionDTO suggestion)
        {
            try
            {
                var data = SuggestionService.AddSuggestion(suggestion);
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

        [Route("api/suggestion/update")]
        [HttpPost]
        public HttpResponseMessage Update(SuggestionDTO suggestion)
        {
            try
            {
                var data = SuggestionService.Update(suggestion);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
        /*-------------------------DELETE-------------------------*/

        [Route("api/suggestion/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = SuggestionService.Delete(id);
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
