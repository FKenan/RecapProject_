using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Business.Abstrack
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IResult Delete(CarImage carImage);

    }
}
