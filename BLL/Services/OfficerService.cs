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
    public class OfficerService
    {
        public static OfficerDTO AddOfficer(OfficerDTO officer)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<OfficerDTO, Officer>();
                c.CreateMap<Officer, OfficerDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Officer>(officer);
            var rt = DataAccessFactory.OfficerDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<OfficerDTO>(rt);
            }
            return null;
        }
        public static List<OfficerDTO> Get()
        {
            var data = DataAccessFactory.OfficerDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Officer, OfficerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<OfficerDTO>>(data);
        }
        public static OfficerDTO Get(int id)
        {
            var data = DataAccessFactory.OfficerDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Officer, OfficerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<OfficerDTO>(data);
        }
        public static OfficerDTO Update(OfficerDTO officer)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<OfficerDTO, Officer>();
                c.CreateMap<Officer, OfficerDTO>();
            });
            var mapper = new Mapper(cfg);
            var off = mapper.Map<Officer>(officer);

            var data = DataAccessFactory.OfficerDataAccess().Update(off);

            var rt = mapper.Map<OfficerDTO>(off);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.OfficerDataAccess().Delete(id);
            return data;
        }
        public static OfficerDTO Officer(string ab)
        {
            var data = DataAccessFactory.OfficerAuthDataAccess().Officers(ab);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Officer, OfficerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<OfficerDTO>(data);

        }
    }
}
