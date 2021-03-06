using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 300;
            product1.UnitsInStock = 3;


            //C#'a özel nesne oluşturma!
            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName="Sandalye", UnitPrice=100, UnitsInStock=5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            productManager.Delete(product1);
           

        }
    }
}
