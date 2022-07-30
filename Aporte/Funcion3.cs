using System;

namespace aporte {
public class Funcion3 : Decorador
{
    public Funcion3(Orden_base orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se ha añadido parlantes");
        var agregar = base.Add();
        
        return agregar;
    }
}
}