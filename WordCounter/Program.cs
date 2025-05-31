class Program
{

    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a text sentence to allow text testing my new class text");
        wordCounter.DisplayWords();
        int count = wordCounter.CountSingleWord("text");
        Console.WriteLine(count);
    }
}