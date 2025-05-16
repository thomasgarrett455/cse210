namespace Journalentry
{
    using System;
    using System.Buffers;

    public class JournalEntry
    {
        private string _entry;
        private string _date;
        private string _prompt;

        public JournalEntry(string prompt, string entry)
        {
            _date = DateTime.Now.ToString("yyyy-MM-dd");
            _prompt = prompt;
            _entry = entry;
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_prompt}");
            Console.WriteLine($"Entry: {_entry}");
        }


}











}