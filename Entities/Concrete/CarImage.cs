using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }

        public CarImage()
        {
                    
        }

        public CarImage(int id, int carId, string imagePath, DateTime date ):this( carId,  imagePath,  date)
        {
            Id = id;   
        }

        public CarImage(int carId, string imagePath, DateTime date)
        {
            CarId = carId;
            ImagePath = imagePath;
            Date = date;
        }
    }

}
