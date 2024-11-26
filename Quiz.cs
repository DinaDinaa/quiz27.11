using QuizPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPlatform.Models
{
    internal class Quiz
    {
        public int QuizId { get; set; }
        public  List<Test> AllTests { get; set; }
        public int TimeLimit { get; set; }
        public int CorrectPoints { get; set; }
        public int TotalPoints { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Quiz(int quizid, List<Test> allTests, int timeLimit, int correctPoints, int totalPoints, DateTime startTime, DateTime endTime)
        {
            QuizId = quizid;
            AllTests = allTests;
            TimeLimit = timeLimit;
            CorrectPoints = correctPoints;
            TotalPoints = totalPoints;
            StartTime = startTime;
            EndTime = endTime;

        }
    }
}
