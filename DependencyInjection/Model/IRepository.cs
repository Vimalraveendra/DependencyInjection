using System;
using System.Collections.Generic;

namespace DependencyInjection.Model
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }

        Product this[string name] { get; }

        void AddProduct(Product product);

        void DeleteProduct(Product product);
    }
}
