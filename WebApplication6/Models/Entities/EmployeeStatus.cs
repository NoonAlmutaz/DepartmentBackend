namespace WebApplication6.Models
{
    public class EmployeeStatus
    {
        public int EmployeeStatusId { get; set; }
        //public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }
        // Navigation property
        //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
