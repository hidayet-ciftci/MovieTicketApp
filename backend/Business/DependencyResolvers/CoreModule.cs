using Business.Abstract;
using Business.Concrete;
using Core.Utilities.IoC;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieService, MovieManager>();
            serviceCollection.AddScoped<IMoviesDal, EfMovieDal>();

            serviceCollection.AddScoped<MoviesContext>();        
        }
    }
}
