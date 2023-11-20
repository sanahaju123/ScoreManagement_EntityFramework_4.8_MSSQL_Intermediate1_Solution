using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScoreManagementApp.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public string GameType { get; set; }
        public string Notes { get; set; }
    }
}