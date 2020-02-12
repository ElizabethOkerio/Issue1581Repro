using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class DataSource
    {
        private static DataSource instance = null;
        public static DataSource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataSource();
                }
                return instance;
            }
        }
        public List<ProductEntity> ProductEntities { get; set; }
        private DataSource()
        {
            this.Reset();
            this.Initialize();
        }
        public void Reset()
        {
            this.ProductEntities = new List<ProductEntity>();
        }
        public void Initialize()
        {
            this.ProductEntities.AddRange(new List<ProductEntity>()
            {
                new ProductEntity()
                {
                    Id= 1,
                    Configuration = new Configuration()
                    {
                        Things = new ObservableCollection<Product>(new List<Product>
                        {
                            new ProductA
                            {
                                Name = "A",
                                Category = "CATEGORYA",
                                Price = 200.00
                            },
                            new ProductA
                            {
                                Name = "B",
                                Category = "CATEGORYA",
                                Price = 100
                            }
                        })
                    },            
                },
                new ProductEntity()
                {
                    Id=2,
                     Configuration = new Configuration()
                    {
                        Things = new ObservableCollection<Product>(new List<Product>
                        {
                            new ProductB
                            {
                                Name = "C",
                                Category = "CATEGORYB",
                                Price = 10.00,
                            }

                        })
                    },

                }
            });
        }
    }
}