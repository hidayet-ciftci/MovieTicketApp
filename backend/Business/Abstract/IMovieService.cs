using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
        IResult Add(Movie movie);
        IResult Delete(Movie movie);
        IResult Update(Movie movie);
        IDataResult<List<Movie>> ListAll();
        IDataResult<Movie> getOneById(int id);
        IDataResult<List<UserMovieDTO>> ListUserWithMovies();

    }
}
