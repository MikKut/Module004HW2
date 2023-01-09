// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using (var db = new DBCodeFirst.Contextes.ApplicationContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DBCodeFirst.Contextes.ApplicationContext>()))
{
    db.SaveChanges();
}