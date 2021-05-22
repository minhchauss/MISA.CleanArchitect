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
        /// <summary>
        /// Thay đổi thông tin của 1 khách hàng
        /// </summary>
        /// <param name="customer">Thông tin của khách hàng</param>
        /// <param name="customerId">Id của khách hàng cần sửa</param>
        /// <returns>Số dòng đã update trong database</returns>
        /// Created by CMChau (19/05/2021)
        int Update(Customer customer, Guid customerId);
        /// <summary>
        /// Thêm mới 1 khách hàng
        /// </summary>
        /// <param name="customer">thông tin của 1 khách hang</param>
        /// <returns>Số dòng đã thêm được vào database</returns>
        /// Created by CMChau (19/05/2021)
        int Insert(Customer customer);

       
    }
}
