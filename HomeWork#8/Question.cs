using System;
using System.Linq;

namespace OHappy
{
    public class Question
    {
        static Random rand = new();
        const string аnswerChar = "ABCD";
        public string Value;
        public List<string> Answers;
        public int СorrectAnswer;

        public Question(List<string> strs, int correctAnswer)
        {
            Value = strs[0];
            Answers = strs.Skip(1).ToList();
            СorrectAnswer = correctAnswer;
        }

        public void OutputQuestion()
        {
            Console.WriteLine(Value);
            for (int i = 0; i < 4; i++)
                Console.WriteLine($"{аnswerChar[i]}. {Answers[i]}");
        }

        public void OutputFiftyFifty()
        {
            Console.WriteLine(Value);
            List<int> incorrectAnswers = (new int[] {0, 1, 2, 3}).Where(x => x != СorrectAnswer).ToList();
            var answersToFiftyFifty = (new int[] {СorrectAnswer, incorrectAnswers[rand.Next(3)]}).Order();
            foreach (int i in answersToFiftyFifty)
                Console.WriteLine($"{аnswerChar[i]}. {Answers[i]}");
        }

        public void OutputСorrectAnswer() => Console.WriteLine($"Правильный ответ: {аnswerChar[СorrectAnswer]}.");

        public char GetCharAnswer(int numberAnswer) => аnswerChar[numberAnswer];

        public int GetNumberAnswer(char charAnswer) => аnswerChar.IndexOf(charAnswer);
    }
}