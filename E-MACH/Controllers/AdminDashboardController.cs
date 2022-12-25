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
    public class AdminDashboardController : ApiController
    {
        /*-------------------------SHOW ALL-------------------------*/
        [Route("api/adminDashboard")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var fisherman = FishermanService.Get();
                var officer = OfficerService.Get();
                var product = ProductService.Get();
                var suggestion = SuggestionService.Get();
                var questionanswer = QuestionAnswerService.Get();
                var order = OrderDetailsService.Get();
                List<object> data = new List<object> { new { fishermans = fisherman, officers = officer, products = product, orders = order, suggestions = suggestion, questionanswers = questionanswer } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------UPDATE-------------------------*/

        [Route("api/admin/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminDTO admin)
        {
            try
            {
                var data = AdminService.Update(admin);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { });

        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/admins/{name}")]
        [HttpGet]
        public HttpResponseMessage Admin(string name)
        {
            try
            {
                var data = AdminService.Admin(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
