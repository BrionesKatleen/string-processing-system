namespace StringSystem.Services
{
    public class StringService
    {
        private string currentText = "";
        private string origText = "";

        // HELPER METHODS
        public bool HasText()
        {
            return !string.IsNullOrEmpty(currentText);
        }

        public void SetText(string text)
        {
            currentText = text;
            origText = text;
        }

        // MENU FUNCTIONS
        public string GetCurrentText()
        {
            return currentText;
        }

        public string ConvrtToUp()
        {
            if(!HasText()) return "";
            return currentText.ToUpper();
        }

        public string ConvrtToLow()
        {
            if(!HasText()) return "";
            return currentText.ToLower();
        }

        public int CountChar()
        {
            if(!HasText()) return 0;
            return currentText.Length;
        }

        public bool ContainsWord(string word)
        {
            if(!HasText() || string.IsNullOrEmpty(word)) return false;
            return currentText.Contains(word);
        }

 public string ReplaceWord(string origWord, string newWord)
        {
            if(!HasText() || string.IsNullOrEmpty(origWord)) return currentText;
            return currentText.Replace(origWord, newWord);
        }

        public string GetSubstring(int startIndex, int length)
        {
            if(!HasText()) return "";
            if(startIndex < 0 || startIndex >= currentText.Length)
                return "Invalid start index";
            if(length < 0 || startIndex + length > currentText.Length)
                return "Invalid length";

            return currentText.Substring(startIndex, length);
        }

        public string TrimSpaces()
        {
            if(!HasText()) return "";
            return currentText.Trim();
        }

        public void ResetToOrig()
        {
            currentText = origText;
        }

    }
}
