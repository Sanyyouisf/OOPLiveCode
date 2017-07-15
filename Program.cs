using System;
using System.Collections.Generic;

namespace OOPClass
{
    class Program
    {
        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            var sentences = new List<ISentenceWithPunctuation>();

            var imperative = new Imperative();
            imperative.AddWord("Make");
            imperative.AddWord("Hello");
            imperative.AddWord("World");

            var question = new Question();
            question.WTF();

            var exclamation = new Exclamation();
            exclamation.AddWord("Hello");
            exclamation.AddWord("World");

            sentences.Add(new NotASentence());
            sentences.Add(imperative);
            sentences.Add(question);
            sentences.Add(exclamation);

            foreach (var item in sentences)
            {
                Console.WriteLine(item.GetSentence());           
            }
        }
    }
}
