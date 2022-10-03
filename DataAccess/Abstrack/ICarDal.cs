using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstrack
{
    public interface ICarDal : IEntityReposity<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
