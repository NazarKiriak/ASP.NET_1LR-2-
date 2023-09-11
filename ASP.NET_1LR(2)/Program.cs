using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.Run(Result);
app.Run();
async Task Result(HttpContext context)
{
    Company company = new Company();
    company.Name = "Apple";
    company.Address = "One Apple Park Way, Cupertino, California, USA\n";
    company.Phone = "+1746248855\n";

    Random random = new Random();
    int randomNumber = random.Next(0, 101);
    await context.Response.WriteAsync($"Compamy:\n {company.Name} \n {company.Address} {company.Phone}");
    await context.Response.WriteAsync($"\nRandom number: {randomNumber}");
}
public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

}
