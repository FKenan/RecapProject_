using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
    }
}
