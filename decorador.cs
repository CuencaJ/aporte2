class decorador:Idispositivo
{
    protected  Idispositivo orden;

    public decorador(Idispositivo orden)
    {
        this.orden = orden;
    }
    public virtual string hardware()
    {
        Console.WriteLine("decorador");
        return orden.hardware();
    }
    public virtual string reparar()
    {
        return "";
    }

    
    
}
