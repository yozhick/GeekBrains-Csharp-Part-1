using System;

namespace Task3
{

    [Serializable]
    public class Question
    {
        private string text;      
        private bool trueFalse;

        public string Text { get => text; set => text = value; }
        public bool TrueFalse { get => trueFalse; set => trueFalse = value; }

        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }

}
