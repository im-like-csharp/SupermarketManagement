﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            // Init with default values
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Ice Tea", Quantity = 100, Price = 6.99},
                new Product { ProductId = 2, CategoryId = 1, Name = "Lipton", Quantity = 200, Price = 3.59},
                new Product { ProductId = 3, CategoryId = 2, Name = "Harry's", Quantity = 200, Price = 2.99},
                new Product { ProductId = 3, CategoryId = 2, Name = "White Bread", Quantity = 200, Price = 1.99},
                new Product { ProductId = 3, CategoryId = 2, Name = "Black Bread", Quantity = 200, Price = 1.98},
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
