using Microsoft.EntityFrameworkCore;
using S34_ConsoleApp_EfCore_Intro;
using S34_ConsoleApp_EfCore_Intro.Models;

Console.WriteLine("Hello, World!");

var db = new AppDbContext();


// *** insert

//for (int i = 0; i < 10; i++)
//{
//    var newProduct = new Product();
//    newProduct.Id = i + 100;
//    newProduct.Title = $"Product-{i + 100}";

//    db.Products.Add(newProduct);
//}
//db.SaveChanges();


// *** update
var q = db.Products.Where(w=>w.Title=="Livan").FirstOrDefault();
if (q != null)
{
    q.Title = "glass";
    db.SaveChanges();
}


// *** delete
//var result = db.Products.Find(104);
var result = db.Products.FirstOrDefault(w=> w.Id == 104);
if (result != null)
{
    db.Products.Remove(result);
    db.SaveChanges();
}




//var sqlQuery = db.Products.ToQueryString();
//var products = sqlQuery.ToList();
var products = db.Products.AsNoTracking().ToList();

foreach (var item in products)
{
    Console.WriteLine($"Id={item.Id} Title={item.Title}");
}