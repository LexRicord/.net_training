using System;
using System.IO;
using _005_Book;
using staticClassesPractice_task2;
//Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для
//поиска по книге из примера урока 005_Delegation. При вызове этого метода, производится 
//последовательный поиск строки в книге.
//Задание кринж, но работодатели разные бывают, будем крутиться.
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string findString;
            string path_to_book = "D:\\repos\\.net_training\\006-006_static_classes\\staticClassesPractice\\Task2\\bin\\Debug\\net7.0\\book_example.txt";
            Book book = new Book(0, "Book Example", path_to_book);
            while (true)
            {
                Console.WriteLine("Ввести строку для поиска: ");
                findString = Console.ReadLine();
                FindAndReplaceManager.FindNext(book.BookText, findString);
            }
        }
    }
}