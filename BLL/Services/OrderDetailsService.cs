using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderDetailsService
    {
        public static OrderDetailsDTO AddMyOrder(OrderDetailsDTO od)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetailsDTO, OrderDetails>();
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<OrderDetails>(od);
            var rt = DataAccessFactory.OrderDetailsDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<OrderDetailsDTO>(rt);
            }
            return null;
        }
        public static List<OrderDetailsDTO> Get()
        {
            var data = DataAccessFactory.OrderDetailsDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<OrderDetailsDTO>>(data);
        }
        public static OrderDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.OrderDetailsDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDetails, OrderDetailsDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<OrderDetailsDTO>(data);
        }
    }
}
