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
    public class MyOrderController : ApiController
    {
        /*-------------------------CREATE-------------------------*/

        [Route("api/myOrder/add")]
        [HttpPost]
        public HttpResponseMessage Add(MyOrderDTO myOrder)
        {
            try
            {
                var data = MyOrderService.AddMyOrder(myOrder);
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
        [Route("api/myOrder")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = MyOrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        /*-------------------------SHOW ONE-------------------------*/

        [Route("api/myOrder/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = MyOrderService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/myOrders/{name}")]
        [HttpGet]
        public HttpResponseMessage myOrder(string name)
        {
            /*try
            {
                var data = MyOrderService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }*/
            var data = AddToCartService.Get();
            var y = data.FindAll(x => x.UName.Equals(name));
            var f = 0;
            foreach(var a in y)
            {
                f += Int16.Parse(a.Tprice);
            }
            MyOrderDTO or = new MyOrderDTO
            {
                OId="#order1233"+f,
                TPrice=f.ToString(),
                PayType="cash on",
                UName=name,
                OStatus="confirm"

            };
            var orderm = MyOrderService.AddMyOrder(or);
            foreach(var r in y)
            {
                OrderDetailsDTO odo = new OrderDetailsDTO
                {
                    OId = orderm.Id,
                    PName = r.PName,
                    PId=r.PId,
                    PQty = r.PQty,
                    Tprice = r.Tprice,
                    UName = r.UName,
                    Status = "confirm"

                };
                OrderDetailsService.AddMyOrder(odo);
                AddToCartService.Delete(r.Id);

            }
            return Request.CreateResponse(HttpStatusCode.OK, "succeful");
        }
    }
}
