using System;

namespace StringProcessingApp
{
    public class StringService
    {
        private string originalText = "";
        public string CurrentText = "";

        public void SetText(string text)
        {
            originalText = text;
            CurrentText = text;
        }

        public void ToUpper()
        {
            CurrentText = CurrentText.ToUpper();
        }

        public void ToLower()
        {
            CurrentText = CurrentText.ToLower();
        }

        public int GetLength()
        {
            return CurrentText.Length;
        }

        public bool ContainsWord(string word)
        {
            return CurrentText.Contains(word);
        }

        public void ReplaceWord(string oldWord, string newWord)
        {
            CurrentText = CurrentText.Replace(oldWord, newWord);
        }

        public void ExtractSubstring(int start, int len)
        {
            if (start >= 0 && (start + len) <= CurrentText.Length)
            {
                CurrentText = CurrentText.Substring(start, len);
            }
        }

        public void TrimSpaces()
        {
            CurrentText = currentText.Trim();
        }

        public void Reset()
        {
            CurrentText = originalText;
        }
    }
}
