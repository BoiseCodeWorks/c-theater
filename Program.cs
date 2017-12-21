using System;
using theater.Abstracts;
using theater.Models;

namespace theater
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema edwards14 = new Cinema("Edwards 14", "123 fake str", 14);

            edwards14.AddLocation("hey this works");


            Movie starWarsVIII = new Movie("Star Wars");
            Movie jumanji = new Movie("Jumanji 2");

            Console.WriteLine("Edwards14.name = " + edwards14.Name);

            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1000");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1100");
            edwards14.AddShowTime(edwards14.Theaters[3], starWarsVIII, "1200");
            edwards14.AddShowTime(edwards14.Theaters[0], starWarsVIII, "1300");
            edwards14.AddShowTime(edwards14.Theaters[1], starWarsVIII, "1400");
            edwards14.AddShowTime(edwards14.Theaters[3], starWarsVIII, "1500");
            edwards14.DisplayShowtimes(starWarsVIII);
            

            // edwards14.Name = "paul";

            // Console.WriteLine("is it paul? Edwards14.name = " + edwards14.Name);
            // edwards14.Name = "Majestic";

            // Console.WriteLine("is it Majestic? Edwards14.name = " + edwards14.Name);

            /**
            Models
                cinema
                    - constructor
                    - Get Movies
                        - Movie see showtimes
                            - GetShowtimes(movie)??? each theater show times flag if availble
                                - purchase ticket


                theater
                movie
                ticket - showtime
                concession
            */
        }
    }
}
