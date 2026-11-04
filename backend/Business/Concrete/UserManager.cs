using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Results.DataResults;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.ApiAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.ApiDeleted);
        }

        public IDataResult<User> getOneById(int id)
        {
            var result = _userDal.getOne(u => u.Id == id);
            return result == null ? new ErrorDataResult<User>(Messages.NotFound)
                : new SuccessDataResult<User>(Messages.ApiListed);
        }

        public IDataResult<List<User>> ListAll()
        {
            var result = _userDal.getAll();
            return new SuccessDataResult<List<User>>(result, Messages.ApiListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.ApiUpdated);
        }
    }
}
