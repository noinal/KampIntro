using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        { 
            // ürün tanımlariken ilkel yöntem:
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitPrice = 3;



            //ürün tanımlarken 2. yöntem:
            Product product2 = new Product {Id=2, CategoryId=5, UnitInStock=5, ProductName="Kalem", UnitPrice=35 };


            //Productmanager classını kullanarak ürün tanımlamak:

            //PascalCase  //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //int,double,bool... değer tip
            //diziler,class,abstract class,interface... referans tip

        }

    }
}
