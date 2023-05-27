using Microsoft.EntityFrameworkCore;
using PlazoletaAtalaya.DB;
using PlazoletaAtalaya.Services;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

//Configurar DB
try
{
    string con = builder.Configuration.GetConnectionString("PlazoletaConnectionString");
    builder.Services.AddDbContext<PlazoletaContext>(ops => ops.UseSqlServer(con));

}
catch (Exception e)
{
    throw new Exception($"{e.Message}");
}

//Configurar IOC
builder.Services.AddScoped<AdministradorPlazoletaRepository>();
builder.Services.AddScoped<AdministradorPlazoletaServices>();

builder.Services.AddScoped<PropietarioRestauranteRepository>();
builder.Services.AddScoped<PropietarioRestauranteServices>();



//La conexion debe crearse antes de que se cree esta linea de aqui abajo que es la creacion de la aplicacion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// PropietarioRestaurante propietarioRestaurante = new(1, "Camilo", "5645", "correo@correo", "No hace nada nunca", "El restaurante colombiano", List<Empleado>)
// Empleado empleado = new(1, "Camilo", "5645", "correo@correo", "No hace nada nunca", "El restaurante colombiano", "1");

