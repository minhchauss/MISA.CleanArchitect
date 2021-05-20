using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Services
{
    public class CustomerService : ICustomerService
    {
        public bool CheckCustomerCodeExist(string customerCOde)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {
            ValidateCustomer(customer);
            throw new NotImplementedException();
        }

        public int Update(Customer customer, Guid customerId)
        {
            ValidateCustomer(customer);
            throw new NotImplementedException();
        }
        /// <summary>
        /// validate dữ liệu khách hàng
        /// </summary>
        /// <param name="customer"></param>
        void ValidateCustomer(Customer customer)
        {
            //Check dữ liệu  khách hàng
        }
    }
}
