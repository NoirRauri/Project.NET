using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//agregar las inyecciones de dependencias 
//en este primer caso quiero ir a la capa de servicios
//especificamente ClienteService
//tres tipos de manejo de memoria
/*scope - transient-singleton
transient hace un manejo dinamico
el scope es a nivel del ambito
singleton es para que siempre este en memoria
*/

// implementar la interfaz con el parametro y en donde la implemente(ClienteService) 
// yo  quiero acceder al objeto ClienteService
// en este caso accedemos a los servicios
//builder.Services.AddTransient<IService<tbClientes>,ClienteService>();
//pero si quiero ir a datos??
//builder.Services.AddTransient<IData<tbClientes>,ClienteData>();



//se podria crear un  contenedor de dependencias
//ya lo tenemos "ServicesExtensions"
builder.Services.addServices();


builder.Services.AddControllers();  


//que conozca las entidades
//builder.Services.AddDbContext<DbProyectoInaContext>(options=> options.UseSqlServer(builder.Configuration.GetConnectionString("dbINA") ?? throw new InvalidOperationException()));
builder.Services.AddDbContext<DbProyectoInaContext>(opt =>opt.UseSqlServer("name=dbINA"));

// Configure the HTTP request pipeline.
 
builder.Services.AddControllers().AddNewtonsoftJson(opt =>
opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

//automap
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();

