using CinemaComfamav4React.Models;
using CinemaComfamav4React.Repositorios;
using CinemaComfamav4React.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CinemaContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

//----------------------------------------------------------
//*************************************  PROGRAMACIÓN CINEMA *******************************

using var db = new CinemaContext();

db.Database.EnsureCreated();


//********************************  CREAR  *********************************************

//Vamos a crear nuevos formatos

//Formato DosD = new Formato("2d");
//Formato TresD = new Formato("3d");


//Vamos a crear nuevos generos

//Genero Drama = new Genero("Drama");
//Genero Terror = new Genero("Terror");
//Genero Comedia = new Genero("Comedia");
//Genero Accion = new Genero("Accion");
//Genero CienciaFiccion = new Genero("CienciaFiccion");


//Vamos a crear nuevas peliculas


//Pelicula peliculaUno = new Pelicula(1, 1, "Rio re tenebroso", "jdjd.jpg", 5, 15000, "Esta es la sinopsis jaja");
//Pelicula jaime = new Pelicula(2, 1, "Rio  tenebroso", "jdjKKKd.jpg", 55, 85000, "Esta es la  ja");
//Pelicula dilbani = new Pelicula(1, 1, "Rio re tenebroso", "jdjd.jpg", 5, 15000, "Esta es la sinopsis jaja");

//********************************  AGREGAR  *********************************************

//Agregar Formatos gracias al DBSET

//db.Formatos.Add(DosD);
//db.Formatos.Add(TresD);


//Agregar Generos gracias al DBSET

//db.Generos.Add(Drama);
//db.Generos.Add(Terror);
//db.Generos.Add(Comedia);
//db.Generos.Add(Accion);
//db.Generos.Add(CienciaFiccion);


//Agregar Peliculas gracias al DBSET

//db.Peliculas.Add(peliculaUno);
//db.Peliculas.Add(jaime);
//db.Peliculas.Add(dilbani);

//********************************  CONSULTAR  *********************************************
var Util = new Utils();


//Consutar Peliculas
//List<Pelicula> results = Util.getPeliculas();
//foreach (var pelicula in results)
//{
//    Console.WriteLine(pelicula.Id);
//    Console.WriteLine(pelicula.Titulo);
//    Console.WriteLine(pelicula.GeneroId);
//    Console.WriteLine("---------------------------------------");
//}


//Consutar Formatos
//List<Formato> results2 = Util.getFormatos();
//foreach (var formato in results2)
//{
//    Console.WriteLine(formato.Id);
//    Console.WriteLine("****************************************");
//}


//Consutar Generos
//List<Genero> results3 = Util.getGeneros();
//foreach (var genero in results3)
//{
//    Console.WriteLine(genero.Id);
//    Console.WriteLine("---------------------------------------");
//}


db.SaveChanges();

Console.WriteLine("Hola Mundoooo");


//********************************************************

app.Run();
