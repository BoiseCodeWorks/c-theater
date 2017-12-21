namespace theater.Models
{
    public class Movie
    {
        public Movie(string title)
        {
            Title = title;
        }

        public string Title { get; protected set; }

    }
}