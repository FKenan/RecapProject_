using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new RentalDetailDto
                             {
                                 BrandName = b.Name,
                                 CustomerName = $"{u.FirstName} {u.LastName}",
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }

        public RentalDetailDto GetRentalDetailByCarId(int carId)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             where r.CarId == carId
                             select new RentalDetailDto
                             {
                                 BrandName = b.Name,
                                 CustomerName = $"{u.FirstName} {u.LastName}",
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList().FirstOrDefault();
            }
        }
    }
}
