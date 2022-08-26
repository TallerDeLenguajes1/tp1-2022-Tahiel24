//Punto 2
Console.WriteLine("Ingrese un numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try
{
    int resultado = num1 / num2;

    Console.WriteLine("Resultado: " + resultado);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    //Console.WriteLine("Division por cero erronea");
}

