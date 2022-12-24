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
    public class ApplicationLeaveService
    {
        public static ApplicationLeaveDTO AddApplicationLeave(ApplicationLeaveDTO la)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicationLeaveDTO, ApplicationLeave>();
                c.CreateMap<ApplicationLeave, ApplicationLeaveDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<ApplicationLeave>(la);
            var rt = DataAccessFactory.ApplicationLeaveDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<ApplicationLeaveDTO>(rt);
            }
            return null;
        }
        public static List<ApplicationLeaveDTO> Get()
        {
            var data = DataAccessFactory.ApplicationLeaveDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicationLeave, ApplicationLeaveDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<ApplicationLeaveDTO>>(data);
        }
        public static ApplicationLeaveDTO Get(int id)
        {
            var data = DataAccessFactory.ApplicationLeaveDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicationLeave, ApplicationLeaveDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<ApplicationLeaveDTO>(data);
        }
        public static ApplicationLeaveDTO Update(ApplicationLeaveDTO la)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ApplicationLeaveDTO, ApplicationLeave>();
                c.CreateMap<ApplicationLeave, ApplicationLeaveDTO>();
            });
            var mapper = new Mapper(cfg);
            var al = mapper.Map<ApplicationLeave>(la);

            var data = DataAccessFactory.ApplicationLeaveDataAccess().Update(al);

            var rt = mapper.Map<ApplicationLeaveDTO>(al);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ApplicationLeaveDataAccess().Delete(id);
            return data;
        }
    }
}
