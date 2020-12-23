using System;
using System.Collections.Generic;

namespace ConsoleCoreApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDal productDal = new ProductDal();
            productDal.ProductOfYear();
        }
    }


    class Customer
    {

    }
    class Product
    {

    }

    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void ProductOfYear()
        {
            Console.Write("Product running");
        }
    }



    class CustomerDal : ICustomerDal //CRUD
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }


    interface ICustomerDal:IRepository<Customer>
    {

    }

    interface IProductDal:IRepository<Product>
    {
        void ProductOfYear();
    }

    //We have actually same code on crud. It's just difference Types.
    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
    }
}