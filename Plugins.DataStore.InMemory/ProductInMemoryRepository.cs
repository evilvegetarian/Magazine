﻿using CoreBuisness;
using System.Collections.Generic;
using UseCases;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, Name="Bread", Quantity=100,Price=1.99},
                new Product{ProductId=2, CategoryId=2, Name="Cola 1l", Quantity=25,Price=0.99},
                new Product{ProductId=2, CategoryId=2, Name="Cola 0.5l", Quantity=25,Price=0.99},
                new Product{ProductId=3, CategoryId=3, Name="Knife", Quantity=2,Price=7.99},
                new Product{ProductId=4, CategoryId=3, Name="Axe", Quantity=2,Price=7.99}
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
