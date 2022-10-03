using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapContext>, ICarImageDal
    {
    }
}
