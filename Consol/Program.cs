using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieContext())
            {
                Console.WriteLine("enter movie title");
                string title = Console.ReadLine();
                Console.WriteLine("enter movie realised year");
                string year = Console.ReadLine();
                Console.WriteLine("enter movie category_name");
                string category_name = Console.ReadLine();
                db.Movies.Add(new Movietbl { title = title });
                db.Movies.Add(new Movietbl { year = year });
                db.Movies.Add(new Movietbl { category_name = category_name });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All movies in database:");
                foreach (var movietbl in db.Movies)
                {
                    Console.WriteLine(" - {0} {1}{2}", movietbl.title, movietbl.year, movietbl.category_name);
                }
            }
        }
    }
}
