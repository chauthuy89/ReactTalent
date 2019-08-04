using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactTalent.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactTalent.Controllers
{

    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
       
        DataAccess obCustomer = new DataAccess();
        //Customer 
        // GET: api/<controller>
        [HttpGet("[action]")]
        [Route("Index")]
        public IEnumerable<Customer> Index() => obCustomer.GetAllCustomers();
        [HttpPost]

        [Route("Create")]

        public int Create(Customer customer)

        {

            return obCustomer.AddCustomer(customer);

        }



        [HttpGet]

        [Route("Details/{id}")]

        public Customer Details(int id)

        {

            return obCustomer.GetCustomerData(id);

        }



        [HttpPut]

        [Route("/Edit")]

        public int Edit(Customer customer)

        {

            return obCustomer.UpdateCustomer(customer);

        }



        [HttpDelete]

        [Route("Delete/{id}")]

        public int Delete(int id)

        {

            return obCustomer.DeleteCustomer(id);

        }



        [HttpGet]

        [Route("GetProductList")]

        public IEnumerable<Product> Details()

        {

            return obCustomer.GetProducts();

        }
        [HttpGet]

        [Route("GetStoreList")]

        public IEnumerable<Store> StoreDetails()

        {

            return obCustomer.GetStores();

        }
        [HttpGet]

        [Route("GetSaleList")]

        public IEnumerable<Sale> SaleDetails()

        {

            return obCustomer.GetSales();

        }

    }
}
