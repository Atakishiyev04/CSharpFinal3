using CSharpFinal3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal3.Classes
{
    class Product : IMarketableProduct
    {
        List<Product> products = new List<Product>();
        public string Name { get; set; }

        public double Price { get; set; }

        public enum Category { }
        public int Number { get; set; }
        public readonly int Id;
        private static int _id = 0;

        public Product()
        {
            _id++;
            Id = _id;
        }

        public Product(string name,double price,int number)
        {
            Name = name;
            Price = price;
            Number = number;
        }

        public void Products()
        {
            throw new NotImplementedException();
        }

        public string ProductSales()
        {
            throw new NotImplementedException();
        }

        public void AddProduct()
        {
            
        }

        public void ChangeProductInfo()
        {
            throw new NotImplementedException();
        }

        public string ProductForCategory()
        {
            throw new NotImplementedException();
        }

        public string ProductForPrice()
        {
            throw new NotImplementedException();
        }

        public void ShowProductForName()
        {
            throw new NotImplementedException();
        }
    }
}
