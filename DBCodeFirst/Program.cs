using DBCodeFirst.Clients;
using DBCodeFirst.EmployeeProjects;
using DBCodeFirst.Employees;
using DBCodeFirst.Offices;
using DBCodeFirst.Projects;
using DBCodeFirst.Titles;
using Microsoft.EntityFrameworkCore;

using (var db = new DBCodeFirst.Contextes.ApplicationContext())
{
    db.SaveChanges();
}