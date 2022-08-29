List<Empleado> ListaEmpleados = new List<Empleado>();
try
{
    Console.WriteLine("Ingrese la cantidad de empleados: ");
    int cant = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine("Ingrese el nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su apellido: ");
        string ape = Console.ReadLine();
        Console.WriteLine("Sueldo basico: ");
        double sueldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Fecha de nacimiento");
        string fechaN = Console.ReadLine();
        Console.WriteLine("Fecha de ingreso a la empresa: ");
        string fechaI = Console.ReadLine();
        Empleado nuevoEmpleado = new Empleado(nombre, ape, sueldo, fechaN, fechaI);
        ListaEmpleados.Add(nuevoEmpleado);
        Console.WriteLine("\n");
    }
    Console.WriteLine("\nLista de empleados ingresados: ");
    foreach (var i in ListaEmpleados)
    {
        Console.WriteLine(i.Nombre);
        Console.WriteLine(i.Apellido);
        Console.WriteLine(i.calcularAntiguedad());
        Console.WriteLine(i.calcularSueldo());
        Console.WriteLine("\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: "+ex.Message);
}

