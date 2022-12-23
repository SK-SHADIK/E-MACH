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
                List<object> data = new List<object> { new { fishermans = fisherman, officers = officer } };
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
