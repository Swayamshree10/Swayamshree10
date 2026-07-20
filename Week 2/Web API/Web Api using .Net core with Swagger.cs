using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

List<Employee> employees = new()
{
    new Employee { Id = 1, Name = "Rahul", Department = "IT", Salary = 50000 },
    new Employee { Id = 2, Name = "Anjali", Department = "HR", Salary = 45000 },
    new Employee { Id = 3, Name = "Rohan", Department = "Finance", Salary = 60000 }
};

// GET
app.MapGet("/api/Emp", () =>
{
    return Results.Ok(employees);
})
.WithName("GetEmployees")
.WithOpenApi();

// GET By Id
app.MapGet("/api/Emp/{id}", (int id) =>
{
    var emp = employees.FirstOrDefault(e => e.Id == id);

    if (emp == null)
        return Results.NotFound();

    return Results.Ok(emp);
})
.WithOpenApi();

// POST
app.MapPost("/api/Emp", ([FromBody] Employee emp) =>
{
    employees.Add(emp);
    return Results.Ok(emp);
})
.WithOpenApi();

// PUT
app.MapPut("/api/Emp/{id}", (int id, [FromBody] Employee employee) =>
{
    var emp = employees.FirstOrDefault(e => e.Id == id);

    if (emp == null)
        return Results.NotFound();

    emp.Name = employee.Name;
    emp.Department = employee.Department;
    emp.Salary = employee.Salary;

    return Results.Ok(emp);
})
.WithOpenApi();

// DELETE
app.MapDelete("/api/Emp/{id}", (int id) =>
{
    var emp = employees.FirstOrDefault(e => e.Id == id);

    if (emp == null)
        return Results.NotFound();

    employees.Remove(emp);

    return Results.Ok("Employee Deleted Successfully");
})
.WithOpenApi();

app.Run();

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Department { get; set; } = "";

    public double Salary { get; set; }
}