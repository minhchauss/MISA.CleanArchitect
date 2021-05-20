using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.CustomerRepos.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool CheckCustomerCodeExist(string customerCOde)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return null;
        }

        public Customer GetById(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetPaging(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void InitConnection()
        {
            throw new NotImplementedException();
        }
    }
}
