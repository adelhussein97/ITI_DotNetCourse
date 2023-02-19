using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQtoObject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 1-	Display book title and its ISBN.
            var query = SampleData.Books.Select(b => new { b.Title, b.Isbn }) ;
            foreach (var item in query)
            {
               
                Console.WriteLine($"The book title : {item.Title} ---- ISBN : {item.Isbn}");
            }
            Console.WriteLine("---------------------------------------------------------");
            //2-	Display the first 3 books with price more than 25.
            var query2 = SampleData.Books.Where(b => b.Price > 25).Take(3);
            foreach (var item in query2)
            {
                
                Console.WriteLine($"The book title : {item.Title} ---- Price : {item.Price}");
            }
            Console.WriteLine("---------------------------------------------------------");
            //3-	Display Book title along with its publisher name. (Using 2 methods).
            var query3 =
                from p in SampleData.Publishers
                select new
                {
                    pubName = p.Name,
                    books = from book in SampleData.Books
                            where book.Publisher.Name == p.Name
                            select book.Title

                };

            var query3_1=SampleData.Publishers.Select(p=> new
            {
                pubName = p.Name,
                books = from book in SampleData.Books
                        where book.Publisher.Name == p.Name
                        select book.Title

            });
            foreach (var item in query3_1)
            {
                Console.WriteLine($"The Publisher Name : {item.pubName}");
                foreach (var book in item.books)
                {
                    Console.WriteLine($"    - The book title : {book}");
                }
               
            }
            Console.WriteLine("---------------------------------------------------------");

            // 4-	Find the number of books which cost more than 20.
            var query4 = SampleData.Books.Count(c=>c.Price>20);
            Console.WriteLine($"the number of books which cost more than 20 is : {query4}");
            Console.WriteLine("---------------------------------------------------------");

            // 5-	Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            var query5 =
                from c in SampleData.Books
                orderby c.Subject.Name ascending, c.Price descending
                select c;
            foreach (var item in query5)
            {
                Console.WriteLine($"The book title : {item.Title} - Price : {item.Price} - Subject : {item.Subject.Name}");
            }
            Console.WriteLine("---------------------------------------------------------");
            //6-	Display All subjects with books related to this subject. (Using 2 methods).
            var query6 =
               from s in SampleData.Subjects
               select new
               {
                   subName = s.Name,
                   books = from book in SampleData.Books
                           where book.Subject.Name == s.Name
                           select book.Title

               };

            var query6_1 = SampleData.Subjects.Select(s => new
            {
                subName = s.Name,
                books = from book in SampleData.Books
                        where book.Subject.Name == s.Name
                        select book.Title

            });
            foreach (var item in query6_1)
            {
                Console.WriteLine($"The Subject Name : {item.subName}");
                foreach (var book in item.books)
                {
                    Console.WriteLine($"    - The book title : {book}");
                }

            }
            Console.WriteLine("---------------------------------------------------------");
            //7-	Try to display book title & price (from book objects) returned from GetBooks Function.
            ArrayList title = SampleData.GetBooks(); //get title
            List<Book> li = new List<Book>();
            for (int i = 0; i < title.Count; i++)
            {
                var b = SampleData.Books.SingleOrDefault(s => s.Title == title[i].ToString());
                li.Add(b);

            }
            foreach (var item in li)
            {
                 Console.WriteLine($"The book title : {item.Title} - Price : {item.Price}");
            }

            Console.WriteLine("---------------------------------------------------------");
            //8-	Display books grouped by publisher & Subject.
            var query8 = SampleData.Books.GroupBy(s => new { s.Publisher, s.Subject }).ToList();
            foreach (var item in query8)
            {
                Console.WriteLine($"The book title : {item.Key.Publisher.Name} , The Subject is :{item.Key.Subject.Name}");
            }


            Console.ReadKey();
        }
    }
}
