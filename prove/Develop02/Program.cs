using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        prompt.Greeting();
        string input = prompt.GetInput();
        Journal journal = new Journal();
        while(input != "5")
        {
            if (input == "1")
            {
                Write write = new Write();
                Entry entry = write.WriteEntry();
                journal._entries.Add(entry);
            }
            else if (input == "2")
            {
                Console.WriteLine(journal);
            }
            else if (input == "3")
            {
                string filename = prompt.GetFilename();
                FileManager loadFileManager = new FileManager();
                journal = loadFileManager.LoadJournal("journal.txt");
            }
            else if (input == "4")
            {
                string filename = prompt.GetFilename();
                FileManager fileManager = new FileManager();
                fileManager.SaveJournal(journal, "journal.txt");
            }
            prompt.Greeting();
            input = prompt.GetInput();
        }
    }
}