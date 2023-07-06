using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecGurusCommon.Interfaces;
using TecGurusFactory.Interfaces;

namespace TecGurusFactory.Factories
{
    // Esta capa utiliza a los Services(Common), y también es utilizada el ViewModel (WEB)

    public class ProductModelFactory: IProductModelFactory
    {
        private readonly IProductService _productService;

        public ProductModelFactory (IProductService productService)
        {
            _productService = productService;
        }

        public List<ProductModel> GetAllProductsModel()
        {
            var products = _productService.GetProducts().ToList();
            foreach (var product in products) 
            {
                ProductModelFactory productModel = new ProductModelFactory();
                productModel.
            }
            
            return.products;
        }
    }
}
