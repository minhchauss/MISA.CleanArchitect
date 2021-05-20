using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Entities
{
    /// <summary>
    /// Thông tin nhân viên
    /// </summary>
    /// Created by CMChau (19/05/2021)
    public class Employee
    {
        /// <summary>
        /// Id nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Họ và tên nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string FullName { get; set; }
        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string Address { get; set; }
        /// <summary>
        /// Giới tính nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public int? Gender { get; set; }
        /// <summary>
        /// Ngày sinh nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Số CMND nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Ngày cấp CMND
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime IdentityDate { get; set; }
        /// <summary>
        /// Nơi cấp CMND
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string IdentityPlace { get; set; }
        /// <summary>
        /// Số điện thoại di động nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string MobilePhoneNumber { get; set; }
        /// <summary>
        /// Số điện thoại bàn nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string Email { get; set; }
        /// <summary>
        /// Số tài khoản ngân hàng nhân viên
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string BankAccount { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string BankName { get; set; }
        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string BankBranch { get; set; }
        /// <summary>
        /// Ngày tạo bản ghi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Người tạo bản ghi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string Createdby { get; set; }
        /// <summary>
        /// Người sửa đổi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Ngày sửa đổi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// VỊ trí
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string PositionName { get; set; }
        /// <summary>
        /// Id phòng ban
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string DepartmentName { get; set; }
    }
}
