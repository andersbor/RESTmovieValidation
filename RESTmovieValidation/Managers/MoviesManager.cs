using RESTmovieValidation.Models;

namespace RESTmovieValidation.Managers
{
    public class MoviesManager
    {
        private static int _nextId = 1;

        private static readonly List<Movie> Data = new List<Movie> {
           new Movie{Id = _nextId++, Description = "Funny Times", Price = 20}
        };

        public List<Movie> GetAll() { return Data; }

        public Movie Add(Movie m)
        {
            m.Id = _nextId++;
            Data.Add(m);
            return m;
        }
    }
}
