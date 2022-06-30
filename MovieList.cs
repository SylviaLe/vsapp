using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsapp
{
    internal class MovieList
    {
        List<movie> movies;

        public MovieList()
        {
            movies = new();
        }

        public void AddMovie(movie movie)
        {
            movies.Add(movie);
        }

        public void Delete(movie movie)
        {
            foreach (movie m in movies)
            {
                if (movie.Equals(m))
                {
                    movies.Remove(m);
                    break;
                }
            }
        }

        public void Search(movie movie)
        {
            foreach (movie m in movies)
            {
                if (m.Equals(movie))
                {
                    return m;
                }
            }
        }

        public void ModifyMovie(movie movie, ? newVal)
        {
            foreach (movie m in movies)
            {
                if (m.Equals(movie))
                {
                    ModifyFunc();
                    break;
                }
            }
        }

    }
}
