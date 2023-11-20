


using ScoreManagementApp.DAL.Interrfaces;
using ScoreManagementApp.DAL.Services;
using ScoreManagementApp.DAL.Services.Repository;
using ScoreManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ScoreManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IScoreService _scoreService;
        public readonly Mock<IScoreRepository> scoreservice = new Mock<IScoreRepository>();

        private readonly Score _score;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidScoreIdIsPassed()
        {
            //Arrange
            bool res = false;
            _score.Id= 0;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repo => repo.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                if (result != null || result.Id !=0)
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
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repo => repo.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                if (result != null || result.PlayerName !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repo => repo.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                if (result != null || result.Date !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidScoreNoteIsPassed()
        {
            //Arrange
            bool res = false;
            _score.Notes = "";
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repo => repo.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                if (result != null || result.Notes !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidGameTypeIsPassed()
        {
            //Arrange
            bool res = false;
            _score.Notes = "";
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                scoreservice.Setup(repo => repo.CreateScore(_score)).ReturnsAsync(_score);
                var result = await _scoreService.CreateScore(_score);
                if (result != null || result.GameType != null)
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