public class Celular:dispositivos, Idispositivo
{
    public Celular(string funci1,string funci2,string funci3):base(funci1,funci2,funci3)
    {
    }

    public string reparar()
    {
        return "CELULAR";
    }

    public string hardware()
    {
        Console.WriteLine();
        return "";
    } 

}