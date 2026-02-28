namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string _originalText = "";
        public string CurrentText { get; private set; } = "";

        public void SetText(string text)
        {
            _originalText = text;
            CurrentText = text;
        }

        public void ToUpper() => CurrentText = CurrentText.ToUpper();

        public void ToLower() => CurrentText = CurrentText.ToLower();

        public int GetLength() => CurrentText.Length;

        public bool ContainsWord(string word) => CurrentText.Contains(word);

        public void ReplaceWord(string oldWord, string newWord) 
            => CurrentText = CurrentText.Replace(oldWord, newWord);

        public void ExtractSubstring(int start, int length)
        {
            if (start >= 0 && start + length <= CurrentText.Length)
                CurrentText = CurrentText.Substring(start, length);
        }

        public void TrimSpaces() => CurrentText = CurrentText.Trim();

        public void Reset() => CurrentText = _originalText;
    }
}
