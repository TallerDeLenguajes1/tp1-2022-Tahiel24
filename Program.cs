//Punto 1
Console.WriteLine("Ingrese un numero para calcular su cuadrado:");
try{
var num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El resultado es: "+ (num*num));
}
catch(FormatException){
    Console.WriteLine("ERROR: Se ha ingresado un caracter erroneo");
}
catch(OverflowException){
    Console.WriteLine("ERROR: Se ha excedido el rango del tipo de dato declarado");
}
catch(Exception ex){
    throw ex;
}

