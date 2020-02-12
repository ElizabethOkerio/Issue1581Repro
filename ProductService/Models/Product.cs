using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProductA : Product
    {
        public string Category { get; set;}
    }

    public class ProductB : Product
    {
        public string Category { get; set; }

    }

    public class Configuration
    {
        public IEnumerable<Product> Things { get; set; }
    }

    public class ProductEntity
    {
        public int Id { get; set; }
        public Configuration Configuration { get; set; }
    }




}