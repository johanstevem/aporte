using System;

namespace aporte {
public class Funcion1 : Decorador
{
    public Funcion1(Orden_base orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se ha añadido audifonos");
        var agregar = base.Add();
        
        return agregar;
    }
}
}