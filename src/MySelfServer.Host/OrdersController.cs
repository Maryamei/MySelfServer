using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MySelfServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "Apple", Category = "Fruit", Price = 1000},
            new Order { Id = 2, Name = "Orange", Category = "Fruit", Price = 2000}
        };

        public IEnumerable<Order> GetAllOrders() 
        {
            return orders;
        }
    }

    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Apple"},
            new Product { Id = 2, Name = "Orange"}
        };

        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
