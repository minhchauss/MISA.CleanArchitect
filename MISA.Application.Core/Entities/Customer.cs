using MISA.CukCuk.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Core.Entities
{
    /// <summary>
    /// Thông tin khách hàng
    /// </summary>
    /// Created by CMChau (19/05/2021)
    public class Customer
    {
        #region Properties
        /// <summary>
        /// Khóa chính id khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Tên khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string FullName { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string CustomerCode { get; set; }
        /// <summary>
        /// Ngày sinh khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Giới tính khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public Gender? Gender { get; set; }
        /// <summary>
        /// Địa chỉ khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string Address { get; set; }
        /// <summary>
        /// Mã thẻ thành viên khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string MemberCardCode { get; set; }
        /// <summary>
        /// Tên công ty khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string CompanyName { get; set; }
        /// <summary>
        /// Email khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string Email { get; set; }
        /// <summary>
        /// Ghi chú của khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string Note { get; set; }
        /// <summary>
        /// Mã số thuế công ty khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string CompanyTaxCode { get; set; }
        /// <summary>
        /// Số điện thoại khách hàng
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public string MobilePhoneNumber { get; set; }
        /// <summary>
        /// Số CMND khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Ngày cấp CMND khách hàng
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime? IdentityDate { get; set; }
        /// <summary>
        /// Id của nhóm khách hang
        /// </summary>
        /// Created by CMChau (21/05/2021)
        public Guid CustomerGroupId { get; set; }
        /// <summary>
        /// Ngày tạo
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Người tạo
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string CreatedBy { get; set; }
        /// <summary>
        /// Ngày thay đổi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Người thay đổi
        /// </summary>
        /// Created by CMChau (19/05/2021)
        public string ModifiedBy { get; set; }

        public EntityState EntityState { get; set; } = EntityState.Add;

        #endregion
    }
}
