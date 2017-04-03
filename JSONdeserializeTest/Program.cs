using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONdeserializeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string json =   @"{
                            'Name': 'Bad Boys',
                            'ReleaseDate': '1995-4-7T00:00:00',
                            'Genres': [
                            'Action',
                            'Comedy'
                            ]
                            }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            string name = m.Name;
            string releaseDate = m.ReleaseDate;
            // Bad Boys

            Console.WriteLine(name + " " + releaseDate);
            Console.ReadKey();

        }

    }

    class Movie
    {
        public string Name { get; set; }

        public string ReleaseDate { get; set; }
    }
}
