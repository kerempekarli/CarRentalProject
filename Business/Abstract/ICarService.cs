using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByBrand(int id);

        IResult Add(Car car);

        void Update(Car car);

        void Delete(Car car);

        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> Get(int id);

    }
}
