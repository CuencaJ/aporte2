class audifonos : decorador
{
    public audifonos(Idispositivo orden) : base(orden)
    {
    }
    
    public override string hardware()
    {
        Console.WriteLine("hardware: "+orden);
        return base.hardware();
    }
}