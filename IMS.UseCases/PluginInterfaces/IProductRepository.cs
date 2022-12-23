﻿using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsByName(string name);

        Task<Product> GetProductById(int id);

        Task AddProductAsync(Product product);
    }
}
