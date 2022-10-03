using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
    }
}
