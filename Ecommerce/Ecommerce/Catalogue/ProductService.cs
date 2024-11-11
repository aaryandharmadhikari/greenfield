using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue
{
    public  class ProductService:IProductService
    {
        private List<Product> _productList;
        public ProductService()
        {
            _productList = new List<Product>();
        }

        public bool Delete(int id)
        {
            Product theproduct = this.Get(id);
            return this._productList.Remove(theproduct);

        }

        public Product Get(int id)
        {
            foreach (Product product in _productList)
            {
                if (product.ProductID==id) return product;
            }
            return null;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductID = 1, Title = "rose", Description = "red", Unitprice = 12, Quantity = 10, ImageURL = "/Images/roseimg.jfif" });
            products.Add(new Product { ProductID = 2, Title = "Lotus", Description = "pink", Unitprice = 11, Quantity = 12, ImageURL = "/Images/lotusimg.jfif" });
            products.Add(new Product { ProductID = 3, Title = "Hibiscus", Description = "blue", Unitprice = 10, Quantity = 14, ImageURL = "/Images/hibiscus.jpg" });
            return products;
        }



        public bool Insert(Product product)
        {
            this._productList.Add(product);
            return true;
        }

        public bool Update(Product product)
        {
            Product product1 = this.Get(product.ProductID);
            this._productList.Remove(product1);
            this._productList.Add(product);
            return true;

        }
    }
}
