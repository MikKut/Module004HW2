using DBCodeFirst.Employees;
using DBCodeFirst.Offices;
using DBCodeFirst.Titles;

var office = new Office() { Employees = new List<Employee>(), Location = "New York", Title = "MMM" };
var title = new Title() { Employees = new List<Employee>(), Name = "T" };
var emp1 = new DBCodeFirst.Employees.Employee() { LastName = "Crumn", HiredDate = DateTime.Now, FirstName = "Slavick", Title = title, TitleId = title.TitleId, Office = office, OfficeId = office.OfficeId };
office.Employees.Add(emp1);
title.Employees.Add(emp1);
using (var db = new DBCodeFirst.Contextes.ApplicationContext())
{
    db.Employees.Add(emp1);
    db.SaveChanges();
}