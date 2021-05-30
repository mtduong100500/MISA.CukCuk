using MISA.Core.Interfaces.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySqlConnector;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace MISA.Infrastruture.Repositories
{
    public class BaseRepository<MISAEntity> : IBaseRepository<MISAEntity>
    {
        #region Fields
        protected IDbConnection DbConnection;
        protected string className = string.Empty;
        #endregion

        #region Constructor
        public BaseRepository(IConfiguration configuration)
        {

            DbConnection = new MySqlConnection(configuration.GetConnectionString("CukCukDemo"));
            className = typeof(MISAEntity).Name;
        }
        #endregion


        #region Methods
        public List<MISAEntity> getAll()
        {
            var sqlCommand = $"SELECT * FROM {className}";
            var entities = DbConnection.Query<MISAEntity>(sqlCommand).ToList();
            return entities;
        }

        public MISAEntity GetById(Guid entityId)
        {
            var sqlCommand = $"SELECT * FROM {className} WHERE {className}Id = @{className}Id";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@{className}Id", entityId);

            var entities = DbConnection.QueryFirstOrDefault<MISAEntity>(sqlCommand);
            return entities;
        }

        public int Insert(MISAEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(MISAEntity entity, Guid EntityId)
        {
            throw new NotImplementedException();
        }

        public int Delete(MISAEntity entityId)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@CustomerId", entityId);
            var sqlCommand = "Delete from Customer where customerId = @CustomerId";
            var res = DbConnection.Execute(sqlCommand, param: dynamicParameters);

            // Trả về kết quả
            return res;
        }
        #endregion  
    }
}
