using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductService
    {
        public static ProductDTO AddProduct(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Product>(product);
            var rt = DataAccessFactory.ProductDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ProductDTO>(rt);
            }
            return null;
        }
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<ProductDTO>>(data);
        }
        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<ProductDTO>(data);
        }
        public static ProductDTO Update(ProductDTO product)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductDTO, Product>();
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var pduct = mapper.Map<Product>(product);

            var data = DataAccessFactory.ProductDataAccess().Update(pduct);

            var rt = mapper.Map<ProductDTO>(pduct);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ProductDataAccess().Delete(id);
            return data;
        }
    }
}
