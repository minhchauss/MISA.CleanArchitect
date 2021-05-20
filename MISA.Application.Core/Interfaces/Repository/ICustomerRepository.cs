using MISA.CukCuk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Interfaces.Repository
{
    /// <summary>
    /// Repository khách hàng
    /// </summary>
    /// Created by CMChau (20/05/2021)
    public interface ICustomerRepository
    {
        /// <summary>
        /// Khởi tạo kết nối đến database
        /// </summary>
        /// Created by CMChau (20/05/2021)
        void InitConnection();
        /// <summary>
        /// Lấy danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách tất cả bản ghi</returns>
        /// Created by CMChau (19/05/2021)
        IEnumerable<Customer> GetAll();
        /// <summary>
        /// Lấy danh sách khách hàng theo phân trang
        /// </summary>
        /// <param name="pageIndex">Trang số</param>
        /// <param name="pageSize">Số bản ghi/trang</param>
        /// <returns>Danh sách khách hàng theo phân trang</returns>
        /// Created by CMChau (19/05/2021)
        IEnumerable<Customer> GetPaging(int pageIndex, int pageSize);
        /// <summary>
        /// Lấy thông tin của 1 khách hàng 
        /// </summary>
        /// <param name="customerId">Id của khách hàng</param>
        /// <returns>Thông tin chi tiết của 1 khách hàng</returns>
        /// Created by CMChau (19/05/2021)
        Customer GetById(Guid customerId);
        /// <summary>
        /// Xóa 1 khách hàng
        /// </summary>
        /// <param name="customerId">Id của khách hàng</param>
        /// <returns>Số dòng đã xóa</returns>
        /// Created by CMChau (19/05/2021)
        int Delete(Guid customerId);
    
    }
}
