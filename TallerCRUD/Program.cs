using TallerCRUD.Models;
using System.Collections.Generic;




class Program
{

  static void Main(string[] args)
  {
    agregarCliente();
    
    // consultarCliente();
    // modificarCliente();
   // eliminarCliente();
    //consultarEstudiantesFunciones();
  }

  public static void agregarCliente()
  {
    Console.WriteLine("Metodo agregar estudiante");
    ClienteContext context = new ClienteContext();
    Cliente std = new Cliente();
    std.Nombre = "Anderson";
    std.Apellido = "Jordan";
    std.Direccion = "General Villamil";
    std.Telefono = 098794152;

    std.FechaNacimiento = new DateTime(2000, 12, 12);
    std.Estado = "Activo";

    Cliente std2 = new Cliente();
    std2.Nombre = "Sergio";
    std2.Apellido = "Ramos";
    std2.Direccion = "General Villamil";
    std2.Telefono = 098794152;

    std2.FechaNacimiento = new DateTime(2000, 12, 12);
    std2.Estado = "Activo";


    context.Clientes.Add(std);
    context.Clientes.Add(std2);
    context.SaveChanges();

    Console.WriteLine("Codigo: " + std.Id);
    Console.WriteLine("Nombre: " + std.Nombre);
    Console.WriteLine("Apellido: " + std.Apellido);
    Console.WriteLine("Direccion: " + std.Direccion);
    Console.WriteLine("Telefono: " + std.Telefono);
    Console.WriteLine("Fecha de Nacimiento: " + std.FechaNacimiento);
    Console.WriteLine("Estado: " + std.Estado);


    Console.WriteLine("Codigo: " + std2.Id);
    Console.WriteLine("Nombre: " + std2.Nombre);
    Console.WriteLine("Apellido: " + std2.Apellido);
    Console.WriteLine("Direccion: " + std2.Direccion);
    Console.WriteLine("Telefono: " + std2.Telefono);
    Console.WriteLine("Fecha de Nacimiento: " + std2.FechaNacimiento);
    Console.WriteLine("Estado: " + std2.Estado);

  }

  public static void consultarCliente()
  {
    Console.WriteLine("Metodo consultar estudiante por Id");
    ClienteContext context = new ClienteContext();
    Cliente std = new Cliente();
    std = context.Clientes.Find(1);

    Console.WriteLine("Codigo: " + std.Id);
    Console.WriteLine("Nombre: " + std.Nombre);
    Console.WriteLine("Apellido: " + std.Apellido);
    Console.WriteLine("Direccion: " + std.Direccion);
    Console.WriteLine("Telefono: " + std.Telefono);
    Console.WriteLine("Fecha de Nacimiento: " + std.FechaNacimiento);
    Console.WriteLine("Estado: " + std.Estado);

  }

  public static void modificarCliente()
  {
    Console.WriteLine("Metodo modificar estudiante");
    ClienteContext context = new ClienteContext();
    Cliente std = new Cliente();
    std = context.Clientes.Find(1);

    std.Nombre = "Cristiano";
    std.Apellido = "Ronaldo";
    std.Direccion = "Madeira";
    std.Telefono = 098794145;

    std.FechaNacimiento = new DateTime(1985, 12, 12);
    std.Estado = "Activo";

    context.SaveChanges();

    Console.WriteLine("Codigo: " + std.Id);
    Console.WriteLine("Nombre: " + std.Nombre);
    Console.WriteLine("Apellido: " + std.Apellido);
    Console.WriteLine("Direccion: " + std.Direccion);
    Console.WriteLine("Telefono: " + std.Telefono);
    Console.WriteLine("Fecha de Nacimiento: " + std.FechaNacimiento);
    Console.WriteLine("Estado: " + std.Estado);

  }

  public static void eliminarCliente()
  {
    Console.WriteLine("Metodo eliminar estudiante");
    ClienteContext context = new ClienteContext();
    Cliente std = new Cliente();
    std = context.Clientes.Find(1);
    context.Remove(std);
    context.SaveChanges();
    Console.WriteLine(" Se elimino el cliente con Codigo: " + std.Id + " Nombre: " + std.Nombre
      + " Apellido: " + std.Apellido
      );

  }


}
