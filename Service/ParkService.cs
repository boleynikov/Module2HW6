using Module2HW6.Abstractions;
using Module2HW6.Cars.BMW;
using Module2HW6.Cars.Lamborgini;
using Module2HW6.Cars.Porsche;
using System.Collections.Generic;
namespace Module2HW6.Service
{
    class ParkService : Interfaces.IParkService
    {
        public AbstractCar[] Cars;

        public ParkService()
        {
            Cars = new AbstractCar[15];
            Cars[0] = new BMWFactory(Models.BMW).GetCar();
            Cars[1] = new BMWFactory(Models.BMWwithSpoiler).GetCar();
            Cars[2] = new LamborginiFactory(Models.LamborginiWithToning).GetCar();
            Cars[3] = new PorscheFactory(Models.PorscheWithSpoiler).GetCar();
            Cars[4] = new BMWFactory(Models.BMWNitro).GetCar();
            Cars[5] = new PorscheFactory(Models.Porsche).GetCar();
            Cars[6] = new BMWFactory(Models.BMWwithToning).GetCar();
            Cars[7] = new BMWFactory(Models.BMWwithSpoiler).GetCar();
            Cars[8] = new PorscheFactory(Models.PorsceNitro).GetCar();
            Cars[9] = new PorscheFactory(Models.PorsceNitro).GetCar();
            Cars[10] = new LamborginiFactory(Models.LamborginiWithSpoiler).GetCar();
            Cars[11] = new LamborginiFactory(Models.LamborginiWithToning).GetCar();
            Cars[12] = new LamborginiFactory(Models.Lamborgini).GetCar();
            Cars[13] = new BMWFactory(Models.BMWwithSpoiler).GetCar();
            Cars[14] = new BMWFactory(Models.BMW).GetCar();
        }

        public decimal PriceOfAllCars
        {
            get
            {
                decimal sum = 0;
                foreach (var car in Cars)
                {
                    sum += car.Price;
                }
                return sum;
            }
        }
    }
}
