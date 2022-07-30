public class dispositivos
{
     public string funci1{get;set;}
    public string funci2{get;set;}
    public string funci3{get;set;}
    
    public dispositivos(string funci1,string funci2,string funci3)
    {
        this.funci1=funci1;
        this.funci2=funci2;
        this.funci3=funci3;    
    }

    public void imprimir()
    {
        Console.WriteLine("FUNCIONALIDADES");
        Console.WriteLine("Funcionalidad1: "+funci1);
        Console.WriteLine("Funcionalidad2: "+funci2);
        Console.WriteLine("Funcionalidad3: "+funci3);
    }
}



