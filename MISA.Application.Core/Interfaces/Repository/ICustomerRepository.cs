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
        /// <summary>
        /// Xóa 1 khách hàng
        /// </summary>
        /// <param name="customerId">Id của khách hàng</param>
        /// <returns>Số dòng đã xóa</returns>
        /// Created by CMChau (19/05/2021)
        int Delete(Guid customerId);

        /// <summary>
        /// Kiểm tra trùng CustomerCode
        /// </summary>
        /// <param name="customerCode">Mã khách hàng</param>
        /// <returns> true - trùng mã, false - không trùng mã</returns>
        /// Created by CMChau (19/05/2021)
        bool CheckCustomerCodeExist(string customerCode,Guid? customerId=null);

        ///// <summary>
        ///// Check trùng số điện thoại
        ///// </summary>
        ///// <param name="phoneNumber">Số điện thoại</param>
        ///// <returns>true - trùng số điện thoại, false - không trùng số điện thoại</returns>
        ///// Created by CMChau (19/05/2021)
        //bool CheckDuplicatePhoneNumber(string phoneNumber);

        /// <summary>
        /// validate dữ liệu khách hàng
        /// </summary>
        /// <param name="customer">thông tin được truyền lên từ client</param>
        /// Created by CMChâu 21/05/2021
        void ValidateCustomer(Customer customer);

    }
}
