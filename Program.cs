
public class Program
{
    static void Main (string []args)
    {
        var cliente =new Cliente("Carlos",123456789);
        cliente.imprimir();

        var celular = new Celular("Camara","sonido","pantalla");
        Console.WriteLine($"El dispositivo 1 a reparar es:  {celular.reparar()}");
        celular.imprimir();

        var tablet= new Tablet("pantalla","pin de carga","botones");
        Console.WriteLine($"El dispositivo 2 a reparar es:  {tablet.reparar()}");
        tablet.imprimir();   

        var com=new compu("hdd","sdd","pantalla");
        Console.WriteLine($"El dispositivo 3  reparar es: {com.reparar()}");
        com.imprimir();
        }
    }
   