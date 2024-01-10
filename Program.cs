// See https://aka.ms/new-console-template for more information
using ConAppAss;

Console.WriteLine("Hello, World!");



List<Products> products = new List<Products>
{
 new Products (){Id=1, PName="Mobile",PPrice=20000,PBrand="Samsung",MfgDate=new DateTime(day:12,month:1,year:2023),ExpDate=new DateTime(day:12,month:1,year:2026)},
  new Products (){Id=2,PName="Mobile",PPrice=75000,PBrand="Apple",MfgDate=new DateTime(day:15,month:4,year:2022),ExpDate=new DateTime(day:30,month:1,year:2026)},
  new Products (){Id=3,PName="Laptop",PPrice=35000,PBrand="Lenovo",MfgDate=new DateTime(day:5,month:2,year:2021),ExpDate=new DateTime(day:16,month:8,year:2024)},
  new Products (){Id=4,PName="Tablet",PPrice=35000,PBrand="Samsung",MfgDate=new DateTime(day:14,month:6,year:2020),ExpDate=new DateTime(day:23,month:1,year:2025)},
  new Products (){Id=5,PName="Laptop",PPrice=55000,PBrand="Vivo",MfgDate=new DateTime(day:6,month:9,year:2021),ExpDate=new DateTime(day:12,month:1,year:2025)},
  new Products (){Id=6,PName="Ipad",PPrice=55000,PBrand="Apple",MfgDate=new DateTime(day:14,month:10,year:2019),ExpDate=new DateTime(day:12,month:1,year:2025)}



};



foreach (Products product in products)
{

    Console.WriteLine(product.Id + "\t \t");
    Console.WriteLine(product.PName + "\t \t");
    Console.WriteLine(product.PPrice + "\t \t");
    Console.WriteLine(product.PBrand + "\t \t");
    Console.WriteLine(product.MfgDate.ToLongDateString());
    Console.WriteLine(product.ExpDate.ToLongDateString());
    Console.WriteLine("\n");

}