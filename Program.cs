var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/add",(int num1, int num2)=> Addnummers(num1, num2));

app.Run();

string Addnummers(int num1, int num2)
{
    return $"summan av {num1} och {num2} är: {num1 +num2}";
}