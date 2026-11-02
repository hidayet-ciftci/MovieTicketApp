using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieDal.Delete(movie);    
        }

        public Movie getOneById(int id)
        {
            return _movieDal.getOne(m=>m.Id==id);
        }

        public List<Movie> ListAll()
        {
            return _movieDal.getAll();
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
