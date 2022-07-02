using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public void AddProdcut(Product product);
        public void UpdateProdcut(Product product);
        public void DeleteProdcut(Product product);
    }
}
