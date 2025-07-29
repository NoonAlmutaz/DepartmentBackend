namespace WebApplication6.Models
{
    public class UpdateEmployeeDto
    {
 
      

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int DepartmentID { get; set; }

            public int JobID { get; set; }


            public string? Phone { get; set; }
            public string Email { get; set; }

            public decimal Salary { get; set; }

            public DateTime HireDate { get; set; }

            public DateTime BirthDate { get; set; }

            public int StatusID { get; set; }

    

}
}
