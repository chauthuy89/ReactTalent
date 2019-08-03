using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactTalent.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactTalent.Controllers
{

    [Route("api/Customer")]
    public class CustomerController : Controller
    {
       
        DataAccess obCustomer = new DataAccess();
        // GET: api/<controller>
        [HttpGet]
        [Route("api/Customer/Index")]
        public IEnumerable<Customer> Index()
        {
            return obCustomer.GetAllCustomers();
        }
        [HttpPost]

        [Route("api/Customer/Create")]

        public int Create(Customer customer)

        {

            return obCustomer.AddCustomer(customer);

        }



        [HttpGet]

        [Route("api/Customer/Details/{id}")]

        public Customer Details(int id)

        {

            return obCustomer.GetCustomerData(id);

        }



        [HttpPut]

        [Route("api/Customer/Edit")]

        public int Edit(Customer customer)

        {

            return obCustomer.UpdateCustomer(customer);

        }



        [HttpDelete]

        [Route("api/Customer/Delete/{id}")]

        public int Delete(int id)

        {

            return obCustomer.DeleteCustomer(id);

        }



        [HttpGet]

        [Route("api/Customer/GetProductList")]

        public IEnumerable<Product> Details()

        {

            return obCustomer.GetProducts();

        }
        [HttpGet]

        [Route("api/Customer/GetStoreList")]

        public IEnumerable<Store> StoreDetails()

        {

            return obCustomer.GetStores();

        }
        [HttpGet]

        [Route("api/Customer/GetSaleList")]

        public IEnumerable<Sale> SaleDetails()

        {

            return obCustomer.GetSales();

        }
    }
}
