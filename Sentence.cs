using System;
using System.Collections.Generic;

namespace OOPClass
{
    abstract class Sentence : ISentenceWithPunctuation, ISentenceWithoutPunctuation
    {
        List<string> _words = new List<string>();
        protected virtual string PunctuationMark => "";

        public void AddWord(string word) 
        {
            word += "o";
            _words.Add(word);
        }
        public virtual string GetSentence()
        {
            string sentence = GetSentenceWithoutPunctuation();

            sentence = $"{sentence.Trim()}{PunctuationMark}";

            return sentence;
        }

        public string GetSentenceWithoutPunctuation()
        {
            var sentence = "";
            foreach (var word in _words)
            {
                sentence += $"{word} ";
            }

            return sentence;
        }
    }
}
