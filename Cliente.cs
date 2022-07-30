public class Cliente
{
    public string nombre{get;set;}
    public int cedula{get;set;}

    public Cliente(string nombre,int cedula)
    {
        this.nombre=nombre;
        this.cedula=cedula;
    }
    public void imprimir()
    {
        Console.WriteLine("CLIENTE");
        Console.WriteLine("Nombre: "+ nombre);
        Console.WriteLine("Cédula: "+ cedula);
    }


}