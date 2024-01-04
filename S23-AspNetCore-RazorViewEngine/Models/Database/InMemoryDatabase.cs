using Microsoft.AspNetCore.Mvc;
using S23_AspNetCore_RazorViewEngine.Models.Entities;

namespace S23_AspNetCore_RazorViewEngine.Models.Database
{
    public class InMemoryDatabase
    {
        private static List<Product> _products = new List<Product>();
        private static List<Customers> _customers = new List<Customers>();



        #region Product

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product FindProduct(int productId)
        {
            return _products.FirstOrDefault(w => w.Id == productId);
        }

        public void AddProduct(Product model)
        {
            _products.Add(model);
        }

        public void EditProduct(Product model)
        {
            var product = FindProduct(model.Id);
            product.Brand = model.Brand;
            product.Name = model.Name;
            product.Price = model.Price;
        }

        public void DeleteProduct(int id)
        {
            var product = FindProduct(id);
            _products.Remove(product);
        }
        #endregion
    }
}
