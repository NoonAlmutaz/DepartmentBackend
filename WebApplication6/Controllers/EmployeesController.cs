using System.Numerics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;
using WebApplication6.Models.Data;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDB DbContext;

        public EmployeesController(AppDB DbContext)
        {
            this.DbContext = DbContext;
        }

        [HttpGet]

        public IActionResult GetAllEmplyees()
        {
         var AllEmployees= DbContext.Employee.ToList();
            return Ok(AllEmployees);
        }


        [HttpPost]

        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                FirstName = addEmployeeDto.FirstName,
                LastName = addEmployeeDto.LastName,
                DepartmentID = addEmployeeDto.DepartmentID,
                JobID = addEmployeeDto.JobID,
                //JobTitleId = addEmployeeDto.JobID,
                Phone = addEmployeeDto.Phone,
                Email = addEmployeeDto.Email,
                Salary = addEmployeeDto.Salary,
                HireDate = addEmployeeDto.HireDate,
                BirthDate = addEmployeeDto.BirthDate,
                StatusID = addEmployeeDto.StatusID
            };


            DbContext.Employee.Add(employeeEntity);
            DbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{EmployeeID}")]
        public IActionResult UpdateEmployee(int EmployeeID, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = DbContext.Employee.Find(EmployeeID);
            if (employee is null)
            {
                return NotFound();
            }
            employee.Phone = updateEmployeeDto.Phone;
            employee.Email = updateEmployeeDto.Email;
            employee.Salary = updateEmployeeDto.Salary;
            employee.HireDate = updateEmployeeDto.HireDate;
            employee.BirthDate = updateEmployeeDto.BirthDate;
            employee.StatusID = updateEmployeeDto.StatusID;
           

        DbContext.SaveChanges();
            return Ok(employee);
            }



        [HttpDelete]
        [Route("{EmployeeID}")]
        public IActionResult DelteEmployee(int EmployeeID)
        {
            var employee = DbContext.Employee.Find(EmployeeID);
            if (employee is null)
            {
                return NotFound();
            }

            DbContext.Employee.Remove(employee);
            DbContext.SaveChanges();
            return Ok();
        }










    }
}
