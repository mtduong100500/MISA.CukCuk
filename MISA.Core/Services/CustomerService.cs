using MISA.Core.Entities;
using MISA.Core.Interfaces.Infrastructures;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService 
    {
        ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository):base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
        public int? Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidateCustom(Customer entity)
        {
            var isValid = true;
            // Check mã khách hàng đã có hay chưa 
            if (string.IsNullOrEmpty(entity.CustomerCode))
            {
                return false;
            }
            return true;
        }

    }
}
