﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        CarDetailDto GetCarDetail(int carId);
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);
        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
        List<CarDetailDto> GetCarDetailsByBrandAndColorId(int brandId,int colorId);
    }
}