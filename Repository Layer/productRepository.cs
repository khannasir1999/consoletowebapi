using Consoletowebapi.Models;

namespace Consoletowebapi.Repository_Layer
{
    public class productRepository : IproductRepository
    {
        private List<ProductsModel> Products = new List<ProductsModel>();
        public int AddProduct(ProductsModel product)
        {
            product.Id = Products.Count + 1;
            Products.Add(product);
            return product.Id;



        }
        public List<ProductsModel> getProducts()
        {
            return Products;
        }

        string IproductRepository.GetName()
        {
            return "name from product repository";
        }
    }
}
