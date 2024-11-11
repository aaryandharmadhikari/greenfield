using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokolib;
using BinaryRepositoryApp;
using Specification;
namespace Services
{
    public  class ProductService:IProductService
    {
        public bool Seeding()
        {
            bool status = false;
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductID = 1, Title = "gerbera",Description = "Wedding Flower",Unitprice = 12, Quantity = 2000, ImageURL = "/Images/gerbera.jpg" });
            products.Add(new Product { ProductID = 2, Title = "rose", Description = "Valentine Flower", Unitprice = 23, Quantity = 9000, ImageURL = "/images/rose.jpg" });
            products.Add(new Product { ProductID = 3,Title= "lily", Description = "Delicate Flower", Unitprice = 2, Quantity = 7000, ImageURL = "/images/lily.jpg" });
            products.Add(new Product { ProductID = 4, Title = "jasmine", Description = "Fregrance Flower", Unitprice = 12, Quantity = 55000, ImageURL = "/images/jasmines.jpg" });
            products.Add(new Product { ProductID = 5, Title = "lotus", Description = "Worship Flower", Unitprice = 45, Quantity = 15000, ImageURL = "/images/lotus.jpg" });
            IDataRepository repo = new BinaryReposiTory();
            status = repo.serialize("products.dat", products);

            return status;
        }

        public bool Delete(int id)
        {
            Product theproduct = this.Get(id);
           // return this._productList.Remove(theproduct);
           if(theproduct!=null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theproduct);
                IDataRepository repo = new BinaryReposiTory();
                repo.serialize("products.dat", allProducts);
            }
            return false;

        }

        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();
            foreach (Product p in products)
            {
                if (p.ProductID==id)
                {
                    foundProduct = p;
                }
            }
            return foundProduct;
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            /* products.Add(new Product { ProductID = 1, Title = "rose", Description = "red", Unitprice = 12, Quantity = 10, ImageURL = "/Images/roseimg.jfif" });
             products.Add(new Product { ProductID = 2, Title = "Lotus", Description = "pink", Unitprice = 11, Quantity = 12, ImageURL = "/Images/lotusimg.jfif" });
             products.Add(new Product { ProductID = 3, Title = "Hibiscus", Description = "blue", Unitprice = 10, Quantity = 14, ImageURL = "/Images/hibiscus.jpg" });
             */
            IDataRepository repository = new BinaryReposiTory();
            products = repository.deserialize("products.dat");
            return products;
        }



        public bool Insert(Product product)
        {
            /*this._productList.Add(product);
             return true;*/
            List<Product> allProducts = GetAll();
            allProducts.Add(product);
            IDataRepository repo = new BinaryReposiTory();
            repo.serialize("products.dat", allProducts);

            return false;
        }

        public bool Update(Product producttobeUpdated)
        {
            Product theProduct = Get(producttobeUpdated.ProductID);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                allProducts.Add(producttobeUpdated);
                IDataRepository repo = new BinaryReposiTory();
                repo.serialize("products.dat", allProducts);
            }
            return false;

        }
    }
}
