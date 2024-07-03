using System;
using System.Collections;
using System.Collections.Generic;

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
            Console.WriteLine("Строка: " + str);
        }

        internal class Note
        {
            internal int Id { get; set; }
            internal int LineId { get; set; }
            internal string NoteText { get; set; }
        }

        internal class Notes : IEnumerable<KeyValuePair<int, List<Note>>>
        {
            private Dictionary<int, List<Note>> notesDict = new Dictionary<int, List<Note>>();
            private int nextNoteId = 0;

            public IEnumerator<KeyValuePair<int, List<Note>>> GetEnumerator()
            {
                foreach (var entry in notesDict)
                {
                    yield return entry;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void SaveNote(int lineId, string noteText)
            {
                if (!notesDict.ContainsKey(lineId))
                {
                    notesDict[lineId] = new List<Note>();
                }

                notesDict[lineId].Add(new Note { Id = nextNoteId++, LineId = lineId, NoteText = noteText });
            }

            public IEnumerable<KeyValuePair<int, List<Note>>> GetAllNotes()
            {
                return notesDict;
            }
        }
    }
}
