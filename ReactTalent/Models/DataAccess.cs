using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReactTalent.Models
{
    public class DataAccess
    {
        readonly ProjectTalentContext db = new ProjectTalentContext();



        public IEnumerable<Customer> GetAllCustomers()

        {

            try

            {

                return db.Customer.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new customer record     

        public int AddCustomer(Customer customer)

        {

            try

            {

                db.Customer.Add(customer);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar customer    

        public int UpdateCustomer(Customer customer)

        {

            try

            {

                db.Entry(customer).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular customer   

        public Customer GetCustomerData(int id)

        {

            try

            {

                Customer customer = db.Customer.Find(id);

                return customer;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular customer    

        public int DeleteCustomer(int id)

        {

            try

            {

                Customer cus = db.Customer.Find(id);

                db.Customer.Remove(cus);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Get the list of Product    

        public List<Product> GetProducts()

        {

            List<Product> lstProduct = new List<Product>();

            lstProduct = (from ProductList in db.Product select ProductList).ToList();



            return lstProduct;

        }
        public List<Store> GetStores()

        {

            List<Store> lstStore = new List<Store>();

            lstStore = (from StoreList in db.Store select StoreList).ToList();



            return lstStore;

        }
        public List<Sale> GetSales()

        {

            List<Sale> lstSale = new List<Sale>();

            lstSale = (from SaleList in db.Sale select SaleList).ToList();



            return lstSale;

        }

        //Products
        public IEnumerable<Product> GetAllProducts()

        {

            try

            {

                return db.Product.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new product record     

        public int AddProduct(Product product)

        {

            try

            {

                db.Product.Add(product);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar product    

        public int UpdateProduct(Product product)

        {

            try

            {

                db.Entry(product).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular product   

        public Product GetProductData(int id)

        {

            try

            {

                Product product = db.Product.Find(id);

                return product;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular product   

        public int DeleteProduct(int id)

        {

            try

            {

                Product cus = db.Product.Find(id);

                db.Product.Remove(cus);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }
        //Store
        public IEnumerable<Store> GetAllStores()

        {

            try

            {

                return db.Store.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new store record     

        public int AddStore(Store store)

        {

            try

            {

                db.Store.Add(store);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar store    

        public int UpdateStore(Store store)

        {

            try

            {

                db.Entry(store).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular store   

        public Store GetStoreData(int id)

        {

            try

            {

                Store store = db.Store.Find(id);

                return store;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular store   

        public int DeleteStore(int id)

        {

            try

            {

                Store store = db.Store.Find(id);

                db.Store.Remove(store);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

        //Sales
        //Store
        public IEnumerable<Sale> GetAllSales()

        {

            try

            {

                return db.Sale.ToList();

            }

            catch

            {

                throw;

            }

        }



        //To Add new store record     

        public int AddSale(Sale sale)

        {

            try

            {

                db.Sale.Add(sale);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }



        //To Update the records of a particluar store    

        public int UpdateSale(Sale sale)

        {

            try

            {

                db.Entry(sale).State = EntityState.Modified;

                db.SaveChanges();



                return 1;

            }

            catch

            {

                throw;

            }

        }



        //Get the details of a particular sale   

        public Sale GetSaleData(int id)

        {

            try

            {

                Sale sale = db.Sale.Find(id);

                return sale;

            }

            catch

            {

                throw;

            }

        }



        //To Delete the record of a particular Sale  

        public int DeleteSale(int id)

        {

            try

            {

                Sale sale = db.Sale.Find(id);

                db.Sale.Remove(sale);

                db.SaveChanges();

                return 1;

            }

            catch

            {

                throw;

            }

        }

    }
}
