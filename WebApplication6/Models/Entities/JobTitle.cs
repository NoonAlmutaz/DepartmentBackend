namespace WebApplication6.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
      
        public string Description { get; set; }
   
        // Navigation property
        //public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
