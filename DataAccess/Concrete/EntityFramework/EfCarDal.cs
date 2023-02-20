using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public CarDetailDto GetCarDetail(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join cl in context.Colors
                             on ca.ColorId equals cl.Id
                             where ca.Id == carId
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandName = b.Name,
                                 CarName = ca.CarName,
                                 ColorName = cl.Name,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description
                             };
                return result.ToList().FirstOrDefault();
            }
        }
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from ca in context.Cars
                             join b in context.Brands
                             on ca.BrandId equals b.Id
                             join cl in context.Colors
                             on ca.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandName = b.Name,
                                 CarName = ca.CarName,
                                 ColorName = cl.Name,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 CarName = c.CarName,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 CarName = c.CarName,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandAndColorId(int brandId, int colorId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             where c.ColorId == colorId
                             where b.Id == brandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 CarName = c.CarName,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
