using System;

class Persona
{
   
    private string nombre;
    private int edad;


    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

   
    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

class Empleado : Persona
{
    
    private double sueldo;

    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value; }
    }

    
    public void ImprimirSueldo()
    {
        Console.WriteLine($"Sueldo: {Sueldo}");
    }
}

class Program
{
    static void Main()
    {
        
        Persona persona = new Persona();
        persona.Nombre = "Juan Pérez";
        persona.Edad = 30;

        
        persona.Imprimir();

       
        Empleado empleado = new Empleado();
        empleado.Nombre = "María López";
        empleado.Edad = 25;
        empleado.Sueldo = 50000;

       
        empleado.Imprimir();
        empleado.ImprimirSueldo();
    }
}
