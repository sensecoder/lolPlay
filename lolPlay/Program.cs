var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var environment = builder.Environment;

if (environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.MapGet("/", () => "Is Developed!");
}
else
{
    app.MapGet("/", () => "Is NOT Developed!");
}

//app.MapGet("/", () => "Hello World!");

app.Run();
