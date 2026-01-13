using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.digitalBookshelfApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
