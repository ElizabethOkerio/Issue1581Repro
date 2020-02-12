using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ProductServiceClient.Default;
using ProductServiceClient.ProductService.Models;

namespace ProductServiceClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Container cc = new Container(new Uri("http://localhost:24339/"));
            var entity = new ProductEntity
            {
                Id = 3,
                Configuration = new Configuration
                {
                    Things = new ObservableCollection<Product>(new List<Product>{
                        new ProductA{
                            Name = "ProductC",
                            Price = 10.0,
                            Category = "CategoryC"
                        }})
                }
            };
            cc.AddToProductEntity(entity);
            cc.SaveChanges();

        }
    }
}
