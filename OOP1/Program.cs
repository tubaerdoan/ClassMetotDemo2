using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //iki çeşit gösterim vardır.. Bunlar burada yazıldı
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { id = 1, CategoryId = 5,UnitInStock=5,ProductName="Kalem",UnitPrice=35 };

            //--------------------------------------------------------------------------------------------------------

            ProductManager pm = new ProductManager();
            pm.Add(product1);
        }
    }
}
