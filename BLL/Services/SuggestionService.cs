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
    public class SuggestionService
    {
        public static SuggestionDTO AddSuggestion(SuggestionDTO suggestion)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<SuggestionDTO, Suggestion>();
                c.CreateMap<Suggestion, SuggestionDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Suggestion>(suggestion);
            var rt = DataAccessFactory.SuggestionDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<SuggestionDTO>(rt);
            }
            return null;
        }
        public static List<SuggestionDTO> Get()
        {
            var data = DataAccessFactory.SuggestionDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Suggestion, SuggestionDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<SuggestionDTO>>(data);
        }
        public static SuggestionDTO Get(int id)
        {
            var data = DataAccessFactory.SuggestionDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Suggestion, SuggestionDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<SuggestionDTO>(data);
        }
        public static SuggestionDTO Update(SuggestionDTO suggestion)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<SuggestionDTO, Suggestion>();
                c.CreateMap<Suggestion, SuggestionDTO>();
            });
            var mapper = new Mapper(cfg);
            var sugg = mapper.Map<Suggestion>(suggestion);

            var data = DataAccessFactory.SuggestionDataAccess().Update(sugg);

            var rt = mapper.Map<SuggestionDTO>(sugg);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.SuggestionDataAccess().Delete(id);
            return data;
        }
    }
}
