using QuizPlatform.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizPlatform.Models;


namespace QuizPlatform.Exceptions
{
    public static class QuestionValidation
    {
        public static void ValidateQuestion(string questionText, List<Answer> possibleAnswers, List<Answer> correctAnswers, bool allowMultipleCorrectAnswers, int points)
        {
            if (questionText.Length < 1 || questionText.Length > 2000)
                throw new ValidationException("Minimum 1 and maximum 2000 symbols.");

            if (possibleAnswers.Count < 2 || possibleAnswers.Count > 8)
                throw new ValidationException("Minumum 2 and maximum 8 possible answers.");

            foreach (var answer in possibleAnswers)
            {
                if (answer.AnswerText.Length < 1 || answer.AnswerText.Length > 250)
                    throw new ValidationException("Minimum 1 and maximum 250 symbols.");
            }

            if (correctAnswers.Distinct().Count() != correctAnswers.Count)
                throw new ValidationException("Correct answers must be unique.");

            if (correctAnswers.Count < 1)
                throw new ValidationException("At least 1 correct answer.");

            if (points < 1 || points > 5)
                throw new ValidationException("Minimum 1 and maximum 5 points.");

            if (!correctAnswers.All(an=>an.IsCorrect ))
                throw new ValidationException("Correct answers contains false IsCorrect property");

        }
    }
}
