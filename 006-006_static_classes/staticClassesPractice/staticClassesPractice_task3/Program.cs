using System;
using System.IO;
using _005_Book;
using staticClassesPractice_task2;
//Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который 
//позволит сохранять заметки читателя.
//Заметки планирую приурочить к номеру строки, интегрируем часть прошлого таска.
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string findString, noteText;
            int indexOfString = 0;
            string path_to_book = "D:\\repos\\.net_training\\006-006_static_classes\\staticClassesPractice\\Task2\\bin\\Debug\\net7.0\\book_example.txt";
            Book book = new Book(0, "Book Example", path_to_book);
            Book.Notes notes = new Book.Notes();
            while (true)
            {
                Console.WriteLine("Write the line you want to find: ");
                findString = Console.ReadLine();
                indexOfString = FindAndReplaceManager.FindNext(book.BookText, findString);
                Console.WriteLine("Write text of the note: ");
                noteText = Console.ReadLine();
                notes.SaveNote(indexOfString, noteText);

                Console.WriteLine("All notes:");
                foreach (var entry in notes.GetAllNotes())
                {
                    Console.WriteLine($"Line: {entry.Key}:");
                    foreach (var note in entry.Value)
                    {
                        Console.WriteLine($" Note {note.Id}: {note.NoteText}");
                    }
                }
            }

        }
    }
}