﻿using DBCodeFirst.EmployeeProjects;
using DBCodeFirst.Clients;

namespace DBCodeFirst.Projects
{
    internal class Project : IProject
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartedDate { get; set; }
        public int CLientId { get; set; }
        public decimal Budget { get; set; }
        public Client Client { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
