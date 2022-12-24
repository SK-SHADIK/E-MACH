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
    public class MyOrderService
    {
        public static MyOrderDTO AddMyOrder(MyOrderDTO myOrder)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MyOrderDTO, MyOrder>();
                c.CreateMap<MyOrder, MyOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<MyOrder>(myOrder);
            var rt = DataAccessFactory.MyOrderDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<MyOrderDTO>(rt);
            }
            return null;
        }
        public static List<MyOrderDTO> Get()
        {
            var data = DataAccessFactory.MyOrderDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MyOrder, MyOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<MyOrderDTO>>(data);
        }
        public static MyOrderDTO Get(int id)
        {
            var data = DataAccessFactory.MyOrderDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<MyOrder, MyOrderDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<MyOrderDTO>(data);
        }
    }
}
