using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.DAL.Services.Repository;
using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ScoreManagementApp.DAL.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _repository;

        public ScoreService(IScoreRepository repository)
        {
            _repository = repository;
        }

        public Task<Score> CreateScore(Score expense)
        {
            return _repository.CreateScore(expense);
        }

        public Task<bool> DeleteScoreById(long id)
        {
            return _repository.DeleteScoreById(id);
        }

        public List<Score> GetAllScores()
        {
            return _repository.GetAllScores();
        }

        public Task<Score> GetScoreById(long id)
        {
            return _repository.GetScoreById(id); ;
        }

        public Task<Score> UpdateScore(Score model)
        {
            return _repository.UpdateScore(model);
        }
    }
}