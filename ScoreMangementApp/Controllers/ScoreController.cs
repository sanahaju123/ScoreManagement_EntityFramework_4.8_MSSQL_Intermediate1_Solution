using ScoreManagement.Models;
using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ScoreManagementApp.Controllers
{
    public class ScoreController : ApiController
    {
        private readonly IScoreService _service;
        public ScoreController(IScoreService service)
        {
            _service = service;
        }
        public ScoreController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Score/CreateScore")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateScore([FromBody] Score model)
        {
            var leaveExists = await _service.GetScoreById(model.Id);
            var result = await _service.CreateScore(model);
            return Ok(new Response { Status = "Success", Message = "Score created successfully!" });
        }


        [HttpPut]
        [Route("api/Score/UpdateScore")]
        public async Task<IHttpActionResult> UpdateScore([FromBody] Score model)
        {
            var result = await _service.UpdateScore(model);
            return Ok(new Response { Status = "Success", Message = "Score updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Score/DeleteScore")]
        public async Task<IHttpActionResult> DeleteScore(long id)
        {
            var result = await _service.DeleteScoreById(id);
            return Ok(new Response { Status = "Success", Message = "Score deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Score/GetScoreById")]
        public async Task<IHttpActionResult> GetScoreById(long id)
        {
            var expense = await _service.GetScoreById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Score/GetAllScores")]
        public async Task<IEnumerable<Score>> GetAllScores()
        {
            return _service.GetAllScores();
        }
    }
}
