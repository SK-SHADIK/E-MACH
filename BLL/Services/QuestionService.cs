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
    public class QuestionService
    {
        public static QuestionDTO AddQuestion(QuestionDTO qa)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<QuestionDTO, Question>();
                c.CreateMap<Question, QuestionDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Question>(qa);
            var rt = DataAccessFactory.QuestionDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<QuestionDTO>(rt);
            }
            return null;
        }
        public static List<QuestionDTO> Get()
        {
            var data = DataAccessFactory.QuestionDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Question, QuestionDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<QuestionDTO>>(data);
        }
        public static QuestionDTO Get(int id)
        {
            var data = DataAccessFactory.QuestionDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Question, QuestionDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<QuestionDTO>(data);
        }
    }
}
