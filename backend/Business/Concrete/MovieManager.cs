using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMoviesDal _movieDal;
        public MovieManager(IMoviesDal moviesDal)
        {
            _movieDal = moviesDal;
        }
        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult(Messages.ApiAdded);
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.ApiDeleted);
        }

        public IDataResult<Movie> getOneById(int id)
        {
            var result = _movieDal.getOne(m=>m.Id==id);
            return result == null ? new ErrorDataResult<Movie>(Messages.ErrorOccured)
           : new SuccessDataResult<Movie>(result, Messages.ApiListed);
        }

        public IDataResult<List<Movie>> ListAll()
        {
            var result = _movieDal.getAll();
            return result == null ? new ErrorDataResult<List<Movie>>(Messages.ErrorOccured)
                : new SuccessDataResult<List<Movie>>(result, Messages.ApiListed);
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.ApiUpdated);
        }

        public IDataResult<List<UserMovieDTO>> ListUserWithMovies()
        {
            var resut = _movieDal.getMoviesWithUser();
            return new SuccessDataResult<List<UserMovieDTO>>(resut,Messages.ApiListed);
        }
    }
}
