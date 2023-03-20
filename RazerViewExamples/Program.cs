var builder = WebApplication.CreateBuilder(args);
//for controllers use this code 
//builder.Services.AddControllers();

//for Razer pages design use controller with view
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.MapControllers();

app.Run();
