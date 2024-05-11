using Northwind.EntityModels; 
// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

#region Configure the web server host and services.

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddNorthwindContext();
var app = builder.Build();

#endregion



//this configure to redirect the http to => https
#region Configure the HTTP pipeline and routes
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();
//app.MapGet("/", () => $"Environment is {app.Environment.EnvironmentName}");
app.MapGet("/hello", () => $"Environment is {app.Environment.EnvironmentName}");
#endregion

// Start the web server, host the website, and wait for requests.
app.Run(); // This is a thread-blocking call.
WriteLine("This executes after the web server has stopped!");