using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Infrastructures;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastruture.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        protected string className = string.Empty;

        #region Fields
        protected IDbConnection DbConnection;
        #endregion

        #region Constructor
        public CustomerRepository(IConfiguration configuration):base(configuration)
        {

            DbConnection = new MySqlConnection(configuration.GetConnectionString("CukCukDemo"));
        }


        public bool CheckCustomerCodeExist(string customerCode)
        {
            var sqlCommand = "SELECT CustomerCode FROM Customer WHERE CustomerCode = @CustomerCode";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@CustomerCode", customerCode);
            var customerCodeExist = DbConnection.QueryFirstOrDefault<string>(sqlCommand, param: dynamicParameters);
            if(customerCodeExist == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Methods
        public List<Customer> GetPaging(int? pageIndex = null, int? pageSize = null)
        {
       
            var sqlCommand = $"Select * from Customer LIMIT @PageSize, @PageIndex";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@PageSize", pageSize);
            dynamicParameters.Add("@PageIndex", pageIndex);
            var customers = DbConnection.Query<Customer>(sqlCommand, param: dynamicParameters).ToList();

            // Trả về thông tin khách hàng theo ID
            return customers;
        }

        #endregion
    }
}
