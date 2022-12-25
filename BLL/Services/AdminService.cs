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
    public class AdminService
    {
        public static AdminDTO Update(AdminDTO admin)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            var fman = mapper.Map<Admin>(admin);

            var data = DataAccessFactory.AdminDataAccess().Update(fman);

            var rt = mapper.Map<AdminDTO>(fman);
            return rt;
        }
        public static AdminDTO Admin(string ab)
        {
            var data = DataAccessFactory.AdminAuthDataAccess().Admins(ab);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<AdminDTO>(data);

        }
    }
}
