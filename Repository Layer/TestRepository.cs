using Consoletowebapi.Models;

namespace Consoletowebapi.Repository_Layer
{
    public class TestRepository : IproductRepository
    {
        public int AddProduct(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return " name from test repository";
        }

        public List<ProductsModel> getProducts()
        {
            throw new NotImplementedException();
        }
    }
}
