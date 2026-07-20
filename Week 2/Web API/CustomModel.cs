using Handson3_CustomModel.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CustomExceptionFilter>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

namespace Handson3_CustomModel.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

namespace Handson3_CustomModel.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

namespace Handson3_CustomModel.Models
{
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
}

