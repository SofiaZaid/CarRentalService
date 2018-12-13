using CarRental.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace CarRentalService
{
    [ServiceContract(Namespace = "http://sofiazaid.net/carRental/2018/11", Name ="CustomerService")]
    public interface ICustomerService
    {
        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        [FaultContract(typeof(EntityNotFoundFault))]
        Customer GetCustomer(int id);

        [FaultContract(typeof(DbUpdateFault))]
        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        int AddNewCustomer(Customer customer);

        [FaultContract(typeof(DbUpdateFault))]
        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        void ChangeCustomer(Customer customer);

        [OperationContract (ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        void DeleteCustomer(int id);
    }
}
