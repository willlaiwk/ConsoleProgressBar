namespace ConsoleProgressbar
{
    public class Progressbar
    {
        /// <summary>
        /// Previous progress text
        /// </summary>
        private string _preProgressText = "";

        /// <summary>
        /// Current progress text
        /// </summary>
        private string _currentProgressText = "";

        /// <summary>
        /// Write the current progress text in console
        /// </summary>
        /// <param name="text"></param>
        public void WriteBase(string text)
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', _preProgressText.Length));    // Clear previous text
            Console.SetCursorPosition(0, currentLineCursor);

            _currentProgressText = text;
            Console.Write(_currentProgressText);
            _preProgressText = _currentProgressText;
        }

        /// <summary>
        /// Show the progress bar in console
        /// </summary>
        /// <param name="current"></param>
        /// <param name="total"></param>
        public void Show(int current, int total)
        {
            var percent = Math.Round((float)current * 100 / total, MidpointRounding.ToEven);
            var progressText = new string('=', (int)Math.Floor(percent / 10)) + new string('.', 10 - (int)Math.Floor(percent / 10));
            var text = $"[{progressText}][{current}/{total}]({percent}%)";

            WriteBase(text);
        }

        /// <summary>
        /// Reset progress bar
        /// </summary>
        public void Reset()
        {
            _preProgressText = "";
            _currentProgressText = "";
        }

    }
}
