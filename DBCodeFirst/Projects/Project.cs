using DBCodeFirst.EmployeeProjects;

namespace DBCodeFirst.Projects
{
    internal class Project : IProject
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; }
        public decimal Budget { get; set; }
    }
}
