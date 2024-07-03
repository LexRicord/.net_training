using System.Text;

namespace _005_Book
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BookText { get; set; }
        public Book(int id, string title, string bookText)
        {
            Id = id;
            Title = title;
            BookText = bookText;
        }

        public void FindNext(string str)
        {
            Console.WriteLine("строки : " + str);
        }
    }
}
