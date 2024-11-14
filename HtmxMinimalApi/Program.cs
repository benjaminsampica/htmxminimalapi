using HtmxMinimalApi.Features;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapStaticAssets();

app.MapGet("/", () => new RazorComponentResult<Home>());

app.Run();
