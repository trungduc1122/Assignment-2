using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProdcut(Product product)=>ProductDAO.Instance.AddNew(product);

        public void DeleteProdcut(Product product)=>ProductDAO.Instance.DeleteProduct(product);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void UpdateProdcut(Product product)=>ProductDAO.Instance.UpdateProduct(product);
    }
}
