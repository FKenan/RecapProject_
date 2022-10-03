using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IUserDal : IEntityReposity<User>
    {
    }
}
