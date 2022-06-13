using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Book
    {
        int BookId;
        string BName;
        int price;

        public Book(int bookId, string bName, int price)
        {
            BookId = bookId;
            BName = bName;
            this.price = price;
        }

        public int BookId1 { get => BookId; set => BookId = value; }
        public string BName1 { get => BName; set => BName = value; }
        public int Price { get => price; set => price = value; }
    }
    internal class HomeWork
        {

            public static void Main()
            {
                List<Book> ob = new List<Book>();
                Book ob2 = new Book(101, "Ramayan", 520);
                Book ob3 = new Book(102, "nj", 50);
                Book ob4 = new Book(103, "nnj", 20);
                ob.Add(ob2);
                ob.Add(ob3);
                ob.Add(ob4);

                foreach(Book book in ob)
                {
                    Console.WriteLine(book);
                }

            }
        }
    
}
