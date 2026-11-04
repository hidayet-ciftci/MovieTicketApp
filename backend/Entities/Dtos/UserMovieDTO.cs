using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserMovieDTO : IDtos
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MovieName { get; set; }
        public decimal duration { get; set; }
    }
}
