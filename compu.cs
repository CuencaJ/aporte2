public class compu:dispositivos, Idispositivo
{
    public compu(string funci1,string funci2,string funci3):base(funci1,funci2,funci3)
    {
    }

    public string reparar()
    {
        return "COMPUTADORA";
    }

    public string hardware()
    {
        Console.WriteLine();
        return "";
    } 
}