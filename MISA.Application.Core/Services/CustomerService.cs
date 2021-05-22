using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Exceptions;
using MISA.CukCuk.Core.Interfaces.Repository;
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
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        //public bool CheckCustomerCodeExist(string customerCode)
        //{
        //    throw new ValidateException("Mã khách hàng đã tồn tại");
        //}

        //public bool CheckDuplicatePhoneNumber(string phoneNumber)
        //{
        //    throw new ValidateException("Số điện thoại đã tồn tại");
        //}

        public int Insert(Customer customer)
        {
            // Duyệt thông tin nhận được
            ValidateCustomer(customer);
            return _customerRepository.Insert(customer);
        }

        public int Update(Customer customer, Guid customerId)
        {
            // Duyệt dữ liệu nhận được
            ValidateCustomer(customer);
            return _customerRepository.Update(customer, customerId);
        }


        void ValidateCustomer(Customer customer)
        {
            var isDuplicate = false;
            if (customer.EntityState == Enum.EntityState.Add)
            {
                //Check dữ liệu  khách hàng
                isDuplicate = _customerRepository.CheckCustomerCodeExist(customer.CustomerCode);

            }
            else
            {
                isDuplicate = _customerRepository.CheckCustomerCodeExist(customer.CustomerCode,customer.CustomerId);
            }

            if (isDuplicate == true)
            {
                throw new ValidateException("Mã đã tồn tại", customer.GetType().GetProperty("CustomerCode").Name);
            }
        }

    }
}
