namespace ConsoleProgressbar
{
    public class Progressbar
    {
        private string _preProgressText = "";
        private string _currentProgressText = "";

        public void WriteCustom(string text)
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', _preProgressText.Length));    // Clear previous text
            Console.SetCursorPosition(0, currentLineCursor);

            _currentProgressText = text;
            Console.Write(_currentProgressText);
            _preProgressText = _currentProgressText;
        }

        public void Write(string message, int current, int total)
        {
            var percent = Math.Round((float)current * 100 / total, MidpointRounding.ToEven);

            WriteCustom($"{message}[{current}/{total}]({percent}%)");
        }

        public void Reset()
        {
            _preProgressText = "";
            _currentProgressText = "";
        }

    }
}
