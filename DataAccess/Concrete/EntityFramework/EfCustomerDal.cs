﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerName = $"{u.FirstName} {u.LastName}",
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
