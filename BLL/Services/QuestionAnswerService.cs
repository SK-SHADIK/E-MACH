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
    public class QuestionAnswerService
    {
        public static QuestionAnswerDTO AddQuestionAnswer(QuestionAnswerDTO qa)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<QuestionAnswerDTO, QuestionAnswer>();
                c.CreateMap<QuestionAnswer, QuestionAnswerDTO>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<QuestionAnswer>(qa);
            var rt = DataAccessFactory.QuestionAnswerDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<QuestionAnswerDTO>(rt);
            }
            return null;
        }
        public static List<QuestionAnswerDTO> Get()
        {
            var data = DataAccessFactory.QuestionAnswerDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<QuestionAnswer, QuestionAnswerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<QuestionAnswerDTO>>(data);
        }
        public static QuestionAnswerDTO Get(int id)
        {
            var data = DataAccessFactory.QuestionAnswerDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<QuestionAnswer, QuestionAnswerDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<QuestionAnswerDTO>(data);
        }
        public static QuestionAnswerDTO Update(QuestionAnswerDTO qa)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<QuestionAnswerDTO, QuestionAnswer>();
                c.CreateMap<QuestionAnswer, QuestionAnswerDTO>();
            });
            var mapper = new Mapper(cfg);
            var qua = mapper.Map<QuestionAnswer>(qa);

            var data = DataAccessFactory.QuestionAnswerDataAccess().Update(qua);

            var rt = mapper.Map<QuestionAnswerDTO>(qua);
            return rt;
        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.QuestionAnswerDataAccess().Delete(id);
            return data;
        }
    }
}
