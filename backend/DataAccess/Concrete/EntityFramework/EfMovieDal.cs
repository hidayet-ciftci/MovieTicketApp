using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie, MoviesContext>, IMoviesDal
    {
        public List<UserMovieDTO> getMoviesWithUser()
        {
            using (MoviesContext context = new MoviesContext())
            {
                var result = from m in context.Movies
                             join u in context.Users
                             on m.Id equals u.Id
                             select new UserMovieDTO
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 MovieName = m.Title,
                                 duration = m.Duration
                             };
                return result.ToList();
            }
        }
    }
}
