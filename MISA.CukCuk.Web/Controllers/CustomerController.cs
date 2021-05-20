using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.Core.Entities;
using MISA.CukCuk.Core.Interfaces.Repository;
using MISA.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository, ICustomerService customerService)
        {
            _customerRepository = customerRepository;
            _customerService = customerService;
        }
        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>
        /// 200 - Dữ liệu tất cả khách hàng
        /// 204 - Không có dữ liệu
        /// 400 - Dữ liệu không hợp lệ
        /// 500 - Exception
        /// </returns>
        /// Created by CMChau (20/05/2021)
        [HttpGet]
        public IActionResult GetAll()
        {
            
            var customers = _customerRepository.GetAll();
            return Ok(customers);
        }
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        /// <param name="customer">Dữ liệu khách hàng</param>
        /// <returns>
        /// 200 - Dữ liệu tất cả khách hàng
        /// 204 - Không có dữ liệu
        /// 400 - Dữ liệu không hợp lệ
        /// 500 - Exception
        /// </returns>
        /// Created by CMChau (20/05/2021)
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            int rowAffect = _customerService.Insert(customer);
            return Ok(rowAffect);
        }
    }
}
