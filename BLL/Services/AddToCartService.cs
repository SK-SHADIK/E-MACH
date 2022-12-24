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
    public class AddToCartService
    {
        public static AddToCartDTO AddAddToCart(AddToCartDTO addToCart)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddToCartDTO, AddToCart>();
                c.CreateMap<AddToCart, AddToCartDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<AddToCart>(addToCart);
            var rt = DataAccessFactory.AddToCartDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<AddToCartDTO>(rt);
            }
            return null;
        }
        public static List<AddToCartDTO> Get()
        {
            var data = DataAccessFactory.AddToCartDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddToCart, AddToCartDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<AddToCartDTO>>(data);
        }
        public static AddToCartDTO Get(int id)
        {
            var data = DataAccessFactory.AddToCartDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddToCart, AddToCartDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AddToCartDTO>(data);
        }
        public static AddToCartDTO Update(AddToCartDTO addToCart)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AddToCartDTO, AddToCart>();
                c.CreateMap<AddToCart, AddToCartDTO>();
            });
            var mapper = new Mapper(cfg);
            var fman = mapper.Map<AddToCart>(addToCart);

            var data = DataAccessFactory.AddToCartDataAccess().Update(fman);

            var rt = mapper.Map<AddToCartDTO>(fman);
            return rt;
        }
        public static AddToCartDTO AddToCarts(string ab)
        {
            var data = DataAccessFactory.AddToCartADataAccess().AddToCarts(ab);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<AddToCart, AddToCartDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AddToCartDTO>(data);

        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.AddToCartDataAccess().Delete(id);
            return data;
        }
    }
}
