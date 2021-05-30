using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces.Infrastructures
{

    public interface ICustomerRepository: IBaseRepository<Customer>
    {
        List<Customer> GetPaging(int? pageIndex = null, int? pageSize = null);

        /// <summary>
        /// Hàm kiểm tra mã khách hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="customerCode">Mã khách hàng cần check</param>
        /// <returns>true: đã tồn tại, false: ko tồn tại</returns>
        /// CreatedBy: MTDUONG(28/05/2021)
        bool CheckCustomerCodeExist(string customerCode);
    }
}

