using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.MapGet("/", async (HttpContext context) =>
{
    await Result(context);
});
app.Run();

async Task Result(HttpContext context)
{
    Company company = new Company();
    company.Name = "RedFlag";
    company.CEO = "DreadLord";
    company.Address = "Ukraine";

    Random random = new Random();
    int randomNumber = random.Next(0, 101);

    await context.Response.WriteAsync($"1) Company Name, CEO and Address - '{company.Name}', '{company.CEO}', '{company.Address}'\n");
    await context.Response.WriteAsync($"2) Random number - {randomNumber}");
}
public class Company
{
    public string Name { get; set; }
    public string CEO { get; set; }
    public string Address { get; set; }
}
