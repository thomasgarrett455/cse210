namespace Journalentry
{
    using System;

    public class JournalEntry
    {
        public string _entry { get; }
        public string _date { get; set; }
        public string _prompt { get; }

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

        // public void WriteToFile(string filename)
        // {
        //     using (StreamWriter outputFile = new StreamWriter(filename))
        //     {
        //         foreach (JournalEntry entry in entries)
        //         {
        //             outputFile.WriteLine(entry.ToString());
        //         }
        //     }
        // }


}











}