using Dapper;
using Microsoft.Extensions.Configuration;
using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.CukCuk.Infrastructure.CustomerRepos.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Khởi tạo chuỗi kết nối đến database
        /// </summary>
        IDbConnection _dbConnection;
        readonly string _connectionString;
        IConfiguration _configuration;
        DynamicParameters Parameters;
        public CustomerRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
            InitConnection();
        }


        public void InitConnection()
        {
            Parameters = new DynamicParameters();
            _dbConnection = new MySqlConnection(_connectionString);
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = _dbConnection.Query<Customer>("Proc_GetCustomers", commandType: CommandType.StoredProcedure);
            return customers;
        }

        public IEnumerable<Customer> GetPaging(int pageIndex, int pageSize)
        {
            Parameters.Add("@m_pageIndex", pageIndex);
            Parameters.Add("@m_pageSize", pageSize);
            var customers = _dbConnection.Query<Customer>("Proc_GetCustomersPaging", commandType: CommandType.StoredProcedure);
            return customers;
        }

        public Customer GetById(Guid customerId)
        {
            Parameters.Add("@m_CustomerId", customerId);
            var customer = _dbConnection.QueryFirstOrDefault<Customer>("Proc_GetCustomerById", param: Parameters, commandType: CommandType.StoredProcedure);
            return customer;
        }

        public int Insert(Customer customer)
        {
            customer.CustomerId = Guid.NewGuid();
            MappingProcParamValueWithObject(customer);
            var rowAffects = _dbConnection.Execute("Proc_InsertCustomer", param: Parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Update(Customer customer, Guid customerId)
        {
            MappingProcParamValueWithObject(customer);
            Parameters.Add("@m_CustomerId", customerId);
            var rowAffects = _dbConnection.Execute("Proc_UpdateCustomer", param: Parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Delete(Guid customerId)
        {
            Parameters.Add("@m_CustomerId", customerId);
            var rowAffects = _dbConnection.Execute("Proc_DeleteCustomer", param: Parameters, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public bool CheckCustomerCodeExist(string customerCode)
        {

            Parameters.Add("@m_CustomerCode", customerCode);
            var isExist = _dbConnection.ExecuteScalar<bool>("Proc_CheckCustomerCodeExist", Parameters, commandType: CommandType.StoredProcedure);
            return isExist;
            ;
        }

        //public bool CheckDuplicatePhoneNumber(string phoneNumber)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Mapping các value vào các tham số trong Procedure
        /// </summary>
        /// <param name="customer">đối tượng thêm mới vào database</param>
        /// Created by CMChâu 21/05/2021
        void MappingProcParamValueWithObject(Customer customer)
        {
            // Lấy ra các property của đối tượng
            var properties = typeof(Customer).GetProperties();
            foreach (var property in properties)
            {
                // Lấy ra giá trị của property
                var value = property.GetValue(customer);
                // Lấy ra tên của property
                var propertyName = property.Name;
                // Gán các tham số vào Parameters
                Parameters.Add($"@m_{propertyName}", value);
            }
        }

        public void ValidateCustomer(Customer customer)
        {
            var isDuplicate = CheckCustomerCodeExist(customer.CustomerCode);
            if (isDuplicate == true)
            {
                throw new Exception("Mã đã tồn tại");
            }
        }
    }
}
