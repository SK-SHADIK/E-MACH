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
    public class FishermanService
    {
        public static FishermanDTO AddFisherman(FishermanDTO fisherman)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FishermanDTO, Fisherman>();
                c.CreateMap<Fisherman, FishermanDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Fisherman>(fisherman);
            var rt = DataAccessFactory.FishermanDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<FishermanDTO>(rt);
            }
            return null;
        }
        public static List<FishermanDTO> Get()
        {
            var data = DataAccessFactory.FishermanDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fisherman, FishermanDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<FishermanDTO>>(data);
        }
        public static FishermanDTO Get (int id)
        {
            var data = DataAccessFactory.FishermanDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Fisherman, FishermanDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<FishermanDTO>(data);
        }
        public static FishermanDTO Update(FishermanDTO fisherman)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<FishermanDTO, Fisherman>();
                c.CreateMap<Fisherman, FishermanDTO>();
            });
            var mapper = new Mapper(cfg);
            var fman = mapper.Map<Fisherman>(fisherman);

            var data = DataAccessFactory.FishermanDataAccess().Update(fman);

            var rt = mapper.Map<FishermanDTO>(fman);
            return rt;
        }
        public static bool Delete (int id)
        {
            var data = DataAccessFactory.FishermanDataAccess().Delete(id);
            return data;
        } 
    }
}
