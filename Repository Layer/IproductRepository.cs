using Consoletowebapi.Models;

namespace Consoletowebapi.Repository_Layer
{
    public interface IproductRepository
    {
        int AddProduct(ProductsModel product);
        List<ProductsModel> getProducts();
    }
}