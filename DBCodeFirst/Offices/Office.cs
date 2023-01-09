using DBCodeFirst.Employees;

namespace DBCodeFirst.Offices
{
    internal class Office : IOffice
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
