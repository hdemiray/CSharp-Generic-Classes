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
    class Product:IEntity
    {

    }
    class Customer:IEntity
    {

    }
    interface IEntity
    {

    }
    class ProductDal : IProductDal
    {
        public void Add(Product customer)
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
            Console.Write("calisti");
        }
    }

    class CustmerDal : ICustomerDal
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
    interface ICustomerDal:IRepository<Customer> //CRUD
    {
    }
    interface IProductDal:IRepository<Product> //CRUD
    {
        void ProductOfYear();
    }

    /*
       This is how we could constrains to generic interface.

       The class keyword tells the interface that it will only accept a reference type.
       IEntity keyword tells it to accept only classes with IEntity implemented.
       These constrains are intended to protect the developer.
    */

    interface IRepository<T> where T:class,IEntity 
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
