using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ScoreManagementApp.DAL.Services.Repository
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly DatabaseContext _dbContext;
        public ScoreRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Score> CreateScore(Score expense)
        {
            try
            {
                var result =  _dbContext.Scores.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteScoreById(long id)
        {
            try
            {
                _dbContext.Scores.Remove(_dbContext.Scores.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Score> GetAllScores()
        {
            try
            {
                var result = _dbContext.Scores.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Score> GetScoreById(long id)
        {
            try
            {
                return await _dbContext.Scores.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Score> UpdateScore(Score model)
        {
            var ex = await _dbContext.Scores.FindAsync(model.Id);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}