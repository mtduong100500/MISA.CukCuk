using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
        /// <summary>
        /// Khách hàng
        /// Created By mtduong(26/05/2021)
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// Khóa chính
            /// </summary>
            public Guid CustomerId { get; set; }
            /// <summary>
            /// Mã khách hàng
            /// </summary>
            public string CustomerCode { get; set; }
            /// <summary>
            /// Họ và đệm
            /// </summary>
            public string FirstName { get; set; }
            /// <summary>
            /// Tên
            /// </summary>
            public string Lastname { get; set; }
            /// <summary>
            /// Họ và tên
            /// </summary>
            public string Fullname { get; set; }
            /// <summary>
            /// Giới tính(Nullable)
            /// </summary>
            public int? Gender { get; set; }
            /// <summary>
            /// Địa chỉ
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// Ngày sinh
            /// </summary>
            public DateTime? DateOfBirth { get; set; }
            /// <summary>
            /// Địa chỉ email
            /// </summary>
            public string Ẹmail { get; set; }
            /// <summary>
            /// Số điện thoại
            /// </summary>
            public string PhoneNumber { get; set; }
            /// <summary>
            /// Khóa phụ
            /// </summary>
            public Guid? CustomerGroupId { get; set; }
            /// <summary>
            /// Số tiền mượn
            /// </summary>
            public double DebitAmount { get; set; }
            /// <summary>
            /// Mã thành viên
            /// </summary>
            public string MemberCardCode { get; set; }
            /// <summary>
            /// Tên công ty
            /// </summary>
            public string CompanyName { get; set; }
            /// <summary>
            /// Mã thuế công ty
            /// </summary>
            public string CompanyTaxCode { get; set; }
            /// <summary>
            /// Tình trạng theo dõi
            /// </summary>
            public int IsStopFollow { get; set; }
            /// <summary>
            /// Ngày tạo
            /// </summary>
            public DateTime CreatedDate { get; set; }
            /// <summary>
            /// Người tạo
            /// </summary>
            public string CreatedBy { get; set; }
            /// <summary>
            /// Ngày chỉnh sửa
            /// </summary>
            public DateTime ModifiedDate { get; set; }
            /// <summary>
            /// Người chỉnh sửa
            /// </summary>
            public string ModifiedBy { get; set; }
        }
}
