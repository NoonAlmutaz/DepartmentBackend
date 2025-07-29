namespace WebApplication6.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public int ManagerID { get; set; }

        public string Location { get; set; }

        // Navigation property
        //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
