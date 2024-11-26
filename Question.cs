using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuizPlatform.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string? QuestionText { get; set; }
        public List<Answer> PossibleAnswers { get; set; }
        public List<Answer> CorrectAnswers { get; set; }
        public bool AllowMultipleCorrectAnswers { get; set; }
        public int Points { get; set; }
// public Test ID ideaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa ?
        public Question() { }
        public Question(int id, string questionText, List<Answer> possibleAnswers, List<Answer> correctAnswers, bool allowMultipleCorrectAnswers, int points)
        {
            QuestionId = id;
            QuestionText = questionText;
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
            AllowMultipleCorrectAnswers = allowMultipleCorrectAnswers;
            Points = points;
        }

    }
}
