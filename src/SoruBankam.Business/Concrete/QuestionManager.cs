﻿using SoruBankam.Business.Abstract;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.DataAccessLayer.Concrete.EntityFramework;
using SoruBankam.Entities;

namespace SoruBankam.Business.Concrete
{
    public class QuestionManager : IQuestionManager
    {
       IQuestionRepository questionRepository;

        public QuestionManager(IQuestionRepository questionRepository)
        {
           this.questionRepository = questionRepository;
        }

        public void Add(Question entity)
        {
            questionRepository.Add(entity);
        }

        public List<Question> GetAll()
        {
            return questionRepository.GetAll();
        }

        public void Remove(Question entity)
        {
            questionRepository.Delete(entity);
        }
    }
}
