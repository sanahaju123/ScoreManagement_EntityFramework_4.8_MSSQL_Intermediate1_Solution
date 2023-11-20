using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreManagementApp.DAL.Services.Repository
{
    public interface IScoreRepository
    {
        List<Score> GetAllScores();
        Task<Score> CreateScore(Score expense);
        Task<Score> GetScoreById(long id);
        Task<bool> DeleteScoreById(long id);
        Task<Score> UpdateScore(Score model);
    }
}

