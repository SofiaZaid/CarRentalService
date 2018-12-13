using CarRental.BusinessLogic;
using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentalService
{
    [ServiceContract(Namespace = "http://sofiazaid.net/carRental/2018/11", Name = "CarService")]
    public interface ICarService
    {
        [OperationContract]
        int AddCar(Car car);

        [OperationContract]
        void DeleteCar(int id);

        [OperationContract]
        Car GetCarByRegNr(string regNr);

        [FaultContract(typeof(EntityNotFoundFault))]
        [OperationContract]
        Car GetCarById(int id);

        [OperationContract]
        CarInfo GetCarInfo(CarRequest request);
    }
}
