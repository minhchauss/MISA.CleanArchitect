using MISA.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Services
{
    /// <summary>
    /// Service khách hàng
    /// </summary>
    /// Created by CMChau (19/05/2021)
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> GetPaging(int pageIndex, int pageSize);
        Customer GetById(Guid customerId);
        int Insert(Customer customer);
        int Update(Customer customer, Guid customerId);
        int Delete(Guid customerId);
    }
}
