

using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.DAL.Services;
using ScoreManagementApp.DAL.Services.Repository;
using ScoreManagementApp.Models;
using ScoreManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ScoreManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IScoreService _scoreService;
        public readonly Mock<IScoreRepository> scoreservice = new Mock<IScoreRepository>();

        private readonly Score _score;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _scoreService = new ScoreService(scoreservice.Object);

            _output = output;

            _score = new Score
            {
                Id = 1,
                Date = DateTime.Now,
                PlayerName = "John Doe",
                PlayerScore = 100,
                GameType = "Chess",
                Notes = "Achieved a high score in a chess match."
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Score()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repos => repos.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Score()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repos => repos.UpdateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.UpdateScore(_score);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetScoreById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repos => repos.GetScoreById(id)).ReturnsAsync(_score);
                var result = await _scoreService.GetScoreById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteScoreById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repos => repos.DeleteScoreById(id)).ReturnsAsync(response);
                var result = await _scoreService.DeleteScoreById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}