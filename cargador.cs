class cargador : decorador
{
    public cargador(decorador orden): base(orden)
    {
    }

    public override string hardware()
    {
        Console.WriteLine("hardware: "+orden);
        return base.hardware();
    }

    
}