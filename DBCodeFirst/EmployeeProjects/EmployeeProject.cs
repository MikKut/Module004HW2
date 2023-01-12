using DBCodeFirst.Employees;
using DBCodeFirst.Projects;

namespace DBCodeFirst.EmployeeProjects
{
    internal class EmployeeProject : IEmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StarteDate { get; set; }
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
