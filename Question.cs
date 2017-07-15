namespace OOPClass
{
    class Question : Sentence
    {
        protected override string PunctuationMark => "?";

        public void WTF()
        {
            AddWord("What");
            AddWord("The");
            AddWord("F*ck");
        }
    }
}