using System;
using System.Reflection;
using _005_Book;

namespace staticClassesPractice_task2
{
    public static class FindAndReplaceManager
    {
        public static int FindNext(string path, string str)
        {
            int result = -1;
            var lines = File.ReadLines(path)
             .Select((line, index) => line.Contains(str) ? $"{index}: {line}" : null)
             .Where(line => line != null);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
                result = line.Count();
            }
            if (result == -1)
            {
                Console.WriteLine("Номер строки не найден, введите часть строки ещё раз");
                return result;
            }
            else return result;
        }
    }
}
