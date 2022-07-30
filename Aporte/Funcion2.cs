using System;

namespace aporte {
public class Funcion2 : Decorador
{
    public Funcion2(Orden_base orden) : base(orden)
    {
    }

    public override string Add()
    {
        Console.WriteLine("Se ha añadido un cargador");
        var agregar = base.Add();
        
        return agregar;
    }
}
}