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
    public class AuthService
    {
        public static TokenDTO Authenticate(string Email, string Pass)
        {
            var dataA = DataAccessFactory.AdminAuthDataAccess().Authenticate(Email, Pass);
            var dataF = DataAccessFactory.FishermanAuthDataAccess().Authenticate(Email, Pass);
            var dataO = DataAccessFactory.OfficerAuthDataAccess().Authenticate(Email, Pass);
            if (dataO != null)
            {
                var token = new Token();
                /*token.Username = dataF.Name;*/
                token.Username = dataO.Name;
                token.UserType = "Officer";
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
            }
            else if (dataF != null) {
                var token = new Token();
                token.Username = dataF.Name;
                token.UserType = "Fisherman";
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
            }
            else if (dataA != null)
            {
                var token = new Token();
                token.Username = dataA.Name;
                token.UserType = "Admin";
                token.TKey = Guid.NewGuid().ToString();
                token.CreationTime = DateTime.Now;
                token.ExpirationTime = null;
                var tk = DataAccessFactory.TokenDataAccess().Add(token);
                if (tk != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(token);
                }
            }
            return null;
            
        }
        public static bool IsValid(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);
            if (data != null)
            {
                return true;
            }
            return false;
        }
        public static TokenDTO logout(string token)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(token);

            if (data != null)
            {
                data.ExpirationTime = DateTime.Now;
                var tk = DataAccessFactory.TokenDataAccess().Update(data);
                var cfg = new MapperConfiguration(c =>
                {
                    c.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(cfg);
                return mapper.Map<TokenDTO>(tk);
            }
            return null;
        }
    }
}
