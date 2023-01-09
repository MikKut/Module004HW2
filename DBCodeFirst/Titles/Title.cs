using DBCodeFirst.Employees;

namespace DBCodeFirst.Titles
{
    internal class Title : ITitle
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }

}
