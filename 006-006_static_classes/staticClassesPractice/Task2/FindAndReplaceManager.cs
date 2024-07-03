using System;
using _005_Book;

namespace staticClassesPractice_task2
{
    public static class FindAndReplaceManager
    {
        public static void FindNext(string path, string str)
        {
            var lines = File.ReadLines(path)
             .Select((line, index) => line.Contains(str) ? $"{index}: {line}" : null)
             .Where(line => line != null);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
