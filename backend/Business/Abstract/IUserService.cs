using Core.Entities.Concrete;
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
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> ListAll();
        IDataResult<User> getOneById(int id);
    }
}
