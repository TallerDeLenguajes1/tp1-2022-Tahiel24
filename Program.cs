//Punto 3
//Nuevo intento
try
{
    Console.WriteLine("Ingrese kilometros recorridos: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese litros empleados: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int resultado = num * num2;
    Console.WriteLine("Resultado: " + resultado);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
