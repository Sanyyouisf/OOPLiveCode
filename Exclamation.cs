namespace OOPClass
{
    class Exclamation : Sentence
    {
        protected override string PunctuationMark => "!";

        public override string GetSentence()
        {
            var sentence = base.GetSentence();
            return sentence.ToUpper();
        }
    }
}
