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
    public class LeaveApplicationService
    {
        public static LeaveApplicationDTO AddLeaveApplication(LeaveApplicationDTO leaveApplication)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<LeaveApplicationDTO, LeaveApplication>();
                c.CreateMap<LeaveApplication, LeaveApplicationDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Product>(leaveApplication);
            var rt = DataAccessFactory.ProductDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<LeaveApplicationDTO>(rt);
            }
            return null;
        }
        public static List<LeaveApplicationDTO> Get()
        {
            var data = DataAccessFactory.ProductDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<LeaveApplicationDTO>>(data);
        }
        public static LeaveApplicationDTO Get(int id)
        {
            var data = DataAccessFactory.LeaveApplicationDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<LeaveApplication, LeaveApplicationDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<LeaveApplicationDTO>(data);
        }
        public static LeaveApplicationDTO Update(LeaveApplicationDTO leaveApplication)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<LeaveApplicationDTO, LeaveApplication>();
                c.CreateMap<LeaveApplication, LeaveApplicationDTO>();
            });
            var mapper = new Mapper(cfg);
            var leaveApp = mapper.Map<LeaveApplication>(leaveApplication);

            var data = DataAccessFactory.LeaveApplicationDataAccess().Update(leaveApp);

            var rt = mapper.Map<LeaveApplicationDTO>(leaveApp);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.LeaveApplicationDataAccess().Delete(id);
            return data;
        }
    }
}
