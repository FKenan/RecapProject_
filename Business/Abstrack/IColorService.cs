using Entities.Concrete;
using System.Collections.Generic;


namespace Business.Abstrack
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetAll();
    }
}
