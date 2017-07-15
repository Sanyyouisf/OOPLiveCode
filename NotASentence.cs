using System;

namespace OOPClass
{
    class NotASentence : ISentenceWithPunctuation
    {
        public string GetSentence()
        {
            return "You Suck";
        }
    }
}