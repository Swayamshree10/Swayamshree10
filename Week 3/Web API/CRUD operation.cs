using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Handson4_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id=1,
                Name="Rahul",
                Salary=50000,
                Permanent=true,
                DateOfBirth=new DateTime(1998,5,12),
                Department=new Department
                {
                    Id=101,
                    Name="IT"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=1,Name="C#"},
                    new Skill{Id=2,Name="SQL"}
                }
            },

            new Employee
            {
                Id=2,
                Name="Priya",
                Salary=60000,
                Permanent=true,
                DateOfBirth=new DateTime(1999,10,20),
                Department=new Department
                {
                    Id=102,
                    Name="HR"
                },
                Skills=new List<Skill>
                {
                    new Skill{Id=3,Name="Angular"},
                    new Skill{Id=4,Name="ASP.NET Core"}
                }
            }
        };

        // GET ALL
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        // CREATE
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        // UPDATE
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            return Ok(existingEmployee);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok("Employee deleted successfully");
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}