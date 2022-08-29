public class Empleado
{
    private string nombre;
    private string apellido;
    private double salariobasico;
    private string direccion;
    private string fechaingreso;
    private string fechanacimiento;
    private int cantHijos;
    private string fechaDiv;
    private string titulo;
    private string universidad;
    
    public Empleado(string nom, string ape,double salario,string fechaN, string fechaI)
    {
        Nombre=nom;
        Apellido=ape;
        Salariobasico=salario;
        Fechanacimiento=fechaN;
        Fechaingreso=fechaI;
        CantHijos=0;
        fechaDiv="01/01/1999";
        Titulo="Ingeniero en Informatica";
        Universidad="Universidad nacional de Tucuman";
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public double Salariobasico { get => salariobasico; set => salariobasico = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public string Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
    public int CantHijos { get => cantHijos; set => cantHijos = value; }
    public string FechaDiv { get => fechaDiv; set => fechaDiv = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Universidad { get => universidad; set => universidad = value; }

    public int calcularAntiguedad(){
        string convertido=Convert.ToString(DateTime.Now);
        string[]separado=convertido.Split('/',' ');
        string[]separado2=Fechaingreso.Split('/');
        int num1=Convert.ToInt32(separado[2]);
        int num2=Convert.ToInt32(separado2[2]);
        return Math.Abs(num1-num2);
    }

    public int calcularEdad(){
        string convertido=Convert.ToString(DateTime.Now);
        string[]separado=convertido.Split('/',' ');
        int num1=Convert.ToInt32(separado[2]);
        string[]separado2=Fechanacimiento.Split('/');
        int num2=Convert.ToInt32(separado2[2]);
        return Math.Abs(num1-num2);
    }

    public double calcularSueldo(){
        double descuentoN= 0.15*Salariobasico;
        if(calcularAntiguedad()<20){
            int porcentaje=calcularAntiguedad();
            double aux=(Salariobasico*porcentaje)/100;
            return salariobasico+aux-descuentoN;
        }else{
            double aux=(Salariobasico*25)/100;
            return salariobasico+aux-descuentoN;
        }
    }

    //Setter
    public void suministrarInfo(int cant, string fec, string tit, string uni){
        CantHijos=cant;
        FechaDiv=fec;
        Titulo=tit;
        Universidad=uni;
    }
}