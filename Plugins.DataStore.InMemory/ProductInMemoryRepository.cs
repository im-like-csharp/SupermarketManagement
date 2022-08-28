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
            // Checking contributions on github 3
            products = new List<Product>()
            {
                new Product { ProductId = 1, CategoryId = 1, Name = "Ice Tea", Quantity = 100, Price = 1.59},
                new Product { ProductId = 2, CategoryId = 1, Name = "Lipton", Quantity = 200, Price = 2.69},
                new Product { ProductId = 3, CategoryId = 2, Name = "Harry's", Quantity = 150, Price = 2.99},
                new Product { ProductId = 4, CategoryId = 2, Name = "White Bread", Quantity = 200, Price = 1.99},
                new Product { ProductId = 5, CategoryId = 2, Name = "Black Bread", Quantity = 200, Price = 1.99},
                new Product { ProductId = 6, CategoryId = 3, Name = "Chicken fillet", Quantity = 120, Price = 8.99},
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            int maxId = products != null && products.Count > 0
                ? products.Max(x => x.ProductId)
                : 0;
            product.ProductId = ++maxId;

            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
