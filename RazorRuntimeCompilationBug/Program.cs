var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Comment this to stop the exceptions
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();
app.UseRouting();
app.MapRazorPages();

app.Run();
