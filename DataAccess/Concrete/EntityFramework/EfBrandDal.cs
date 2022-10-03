using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapContext>, IBrandDal
    {

    }
}
