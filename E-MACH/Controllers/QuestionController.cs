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
    public class QuestionController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/question")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = QuestionService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/question/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = QuestionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------CREATE-------------------------*/

        [Route("api/question/add")]
        [HttpPost]
        public HttpResponseMessage Add(QuestionDTO qa)
        {
            try
            {
                var data = QuestionService.AddQuestion(qa);
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
    }
}
