using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Delete(Movie movie);
        void Update(Movie movie);
        List<Movie> ListAll();
        Movie getOneById(int id);

    }
}
